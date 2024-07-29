
Partial Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
    End Sub

    Protected Sub btnCreate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCreate.Click
        Dim tokenCreated = JwtHelper.GenerateToken(txtCreate.Text)
        txtToken.Text = tokenCreated
    End Sub

    Protected Sub btnCheck_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCheck.Click
        Dim isValid = JwtHelper.ValidateToken(txtCheck.Text)
        If isValid Then
            txtValid.Visible = True
            txtInvalid.Visible = False
        Else
            txtValid.Visible = False
            txtInvalid.Visible = True
        End If
    End Sub
End Class