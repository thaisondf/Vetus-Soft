Imports System.Data.OleDb

Public Class login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If tentativa >= 4 Then
            MsgBox("Número máximo de tentativas excedido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
            Application.Exit()
            Return
        End If

        If String.IsNullOrEmpty(txt_login.Text) Or String.IsNullOrEmpty(txt_senha.Text) Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            limpar_login()
            tentativa = tentativa + 1
            Return
        End If

        Dim conn As New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & caminho_banco)
        Dim cmd As New OleDbCommand("SELECT * FROM tb_login WHERE login=@username AND senha=@password AND status='válida'", conn)
        cmd.Parameters.AddWithValue("@username", txt_login.Text)
        cmd.Parameters.AddWithValue("@password", txt_senha.Text)

        Try
            conn.Open()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                Dim permissao As String = reader("permissao").ToString()

                If permissao = "enfermeiro" Then
                    Me.Hide()
                    limpar_login()
                    tela_enfermeiro.Show()
                ElseIf permissao = "recepcionista" Then
                    Me.Hide()
                    limpar_login()
                    tela_recep.Show()
                ElseIf permissao = "gerente" Then
                    Me.Hide()
                    limpar_login()
                    tela_gerente.Show()
                End If

            Else
                MsgBox("Usuários ou senha incorretos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
                limpar_login()
                tentativa = tentativa + 1
            End If
        Catch ex As Exception
            MsgBox("Erro ao conectar ao banco de dados: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERRO")
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Hide()
        mudar_senha.Show()
    End Sub


    Private Sub btn_hide_Click(sender As Object, e As EventArgs) Handles btn_hide.Click
        txt_senha.UseSystemPasswordChar = Not txt_senha.UseSystemPasswordChar
        btn_hide.Hide()
        btn_show.Show()
        show_pass.Hide()
        hide_pass.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles btn_show.Click
        txt_senha.UseSystemPasswordChar = Not txt_senha.UseSystemPasswordChar
        btn_hide.Show()
        btn_show.Hide()
        show_pass.Show()
        hide_pass.Hide()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hide_pass.Hide()
    End Sub
End Class