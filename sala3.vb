Imports System.Data.OleDb

Public Class sala3


    Private Sub sala3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_sala3()

    End Sub

    Private Sub sala3_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        tela_enfermeiro.Show()
    End Sub


End Class