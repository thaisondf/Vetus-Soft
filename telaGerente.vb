Public Class tela_gerente
    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        Me.Hide()
        cadastrar_funcionarios.Show()
    End Sub
    Private Sub tela_gerente_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        login.Close()
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub tela_gerente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class