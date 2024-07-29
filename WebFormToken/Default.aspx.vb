
Partial Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim tokenCreated = JwtHelper.GenerateToken("username_example")
        Dim tokenFaked = "eyJhbGciOiJIUzI1NiIsInR.5cCI6IkpXVCJ9.eyJzdW"
        Response.Write("Generated Token: " & tokenCreated)

        ' Authencation token
        Dim isValid = JwtHelper.ValidateToken(tokenCreated)
        If isValid Then
            Response.Write("Token is valid.")
        Else
            Response.Write("Token is invalid.")
        End If

        Dim isNotValid = JwtHelper.ValidateToken(tokenFaked)
        If isNotValid Then
            Response.Write("Token is valid.")
        Else
            Response.Write("Token is invalid.")
        End If
    End Sub
End Class