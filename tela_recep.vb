Public Class tela_recep
    Private Sub tela_recep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub tela_recep_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        login.Close()
    End Sub

    Private Sub btn_rgs_idoso_Click(sender As Object, e As EventArgs) Handles btn_rgs_idoso.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub btn_info_idoso_Click(sender As Object, e As EventArgs) Handles btn_info_idoso.Click
        Me.Hide()
        tela_pacientes.Show()
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Hide()
        login.Show()

    End Sub


End Class