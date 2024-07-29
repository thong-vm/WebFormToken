Imports System.Web.Script.Serialization
Imports System.Security.Cryptography

Public Class JwtHelper

    Private Const SecretKey As String = "your_secret_key_here"

    Public Shared Function GenerateToken(username As String) As String
        ' Header
        Dim header As New Dictionary(Of String, String) From {
            {"alg", "HS256"},
            {"typ", "JWT"}
        }

        ' Payload
        Dim payload As New Dictionary(Of String, String) From {
            {"sub", username},
            {"exp", (DateTime.UtcNow.AddHours(1).Subtract(New DateTime(1970, 1, 1))).TotalSeconds.ToString()}
        }

        ' Convert to JSON and Base64Url encode
        Dim headerJson = New JavaScriptSerializer().Serialize(header)
        Dim payloadJson = New JavaScriptSerializer().Serialize(payload)
        Dim headerBase64Url = Base64UrlEncode(Encoding.UTF8.GetBytes(headerJson))
        Dim payloadBase64Url = Base64UrlEncode(Encoding.UTF8.GetBytes(payloadJson))

        ' Create Signature
        Dim signature = CreateSignature(headerBase64Url, payloadBase64Url)

        ' Return JWT
        Return $"{headerBase64Url}.{payloadBase64Url}.{signature}"
    End Function

    Public Shared Function ValidateToken(token As String) As Boolean
        Dim parts = token.Split("."c)
        If parts.Length <> 3 Then Return False

        Dim headerBase64Url = parts(0)
        Dim payloadBase64Url = parts(1)
        Dim signature = parts(2)

        Dim expectedSignature = CreateSignature(headerBase64Url, payloadBase64Url)
        Return signature = expectedSignature
    End Function

    Private Shared Function CreateSignature(headerBase64Url As String, payloadBase64Url As String) As String
        Dim keyBytes = Encoding.UTF8.GetBytes(SecretKey)
        Dim dataToSign = Encoding.UTF8.GetBytes($"{headerBase64Url}.{payloadBase64Url}")

        Using hmac = New HMACSHA256(keyBytes)
            Dim hashBytes = hmac.ComputeHash(dataToSign)
            Return Base64UrlEncode(hashBytes)
        End Using
    End Function

    Private Shared Function Base64UrlEncode(input As Byte()) As String
        Dim base64 = Convert.ToBase64String(input)
        base64 = base64.TrimEnd("="c)
        base64 = base64.Replace("+"c, "-"c)
        base64 = base64.Replace("/"c, "_"c)
        Return base64
    End Function
End Class
