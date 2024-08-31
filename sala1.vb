Public Class sala1
    Private Sub sala1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_sala1()

    End Sub

    Private Sub sala1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        tela_enfermeiro.Show()

    End Sub


End Class