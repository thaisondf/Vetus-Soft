Public Class tela_enfermeiro
    Private Sub btn_cotiano_Click(sender As Object, e As EventArgs) Handles btn_cotiano.Click
        btn_cotiano.Visible = False
        btn_sala1.Visible = True
        btn_sala2.Visible = True
        btn_sala3.Visible = True
        btn_editarcotidiano.Visible = False
        btn_voltar.Visible = True
    End Sub

    Private Sub btn_sala2_Click(sender As Object, e As EventArgs) Handles btn_sala2.Click
        Me.Hide()
        sala2.Show()

    End Sub

    Private Sub tela_enfermeiro_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        login.Show()
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        btn_cotiano.Visible = True
        btn_sala1.Visible = False
        btn_sala2.Visible = False
        btn_sala3.Visible = False
        btn_editarcotidiano.Visible = True
        btn_voltar.Visible = False
    End Sub

    Private Sub btn_sala1_Click(sender As Object, e As EventArgs) Handles btn_sala1.Click
        Me.Hide()
        sala1.Show()
    End Sub

    Private Sub btn_sala3_Click(sender As Object, e As EventArgs) Handles btn_sala3.Click
        Me.Hide()
        sala3.Show()
    End Sub

    Private Sub btn_editarcotidiano_Click(sender As Object, e As EventArgs) Handles btn_editarcotidiano.Click
        Me.Hide()
        cotidianos.Show()

    End Sub

    Private Sub tela_enfermeiro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class