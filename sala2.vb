Public Class sala2
    Private Sub sala2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_sala2()

    End Sub

    Private Sub sala2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        tela_enfermeiro.Show()
    End Sub


End Class