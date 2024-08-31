Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class mudar_senha
    Private Sub btn_trocarsenha_Click(sender As Object, e As EventArgs) Handles btn_trocarsenha.Click
        If String.IsNullOrEmpty(txt_bcpf.Text) OrElse
           String.IsNullOrEmpty(txt_busuario.Text) OrElse
           String.IsNullOrEmpty(txt_novasenha.Text) OrElse
           String.IsNullOrEmpty(txt_confirmarsenha.Text) Then
            MsgBox("Preencha todos os campos antes de salvar!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            limpar_nsenha()
            Exit Sub
        End If
        Dim cpf As String = txt_bcpf.Text
        Dim login As String = txt_bUsuario.Text
        Dim novaSenha As String = txt_novasenha.Text
        Dim confirmarSenha As String = txt_confirmarsenha.Text

        If ValidarCpfUsuario(cpf, login) Then
            If novaSenha = confirmarSenha Then
                ' Atualize a senha no banco de dados aqui (exemplo):
                AtualizarSenha(cpf, novaSenha)
                MessageBox.Show("Senha alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpar_nsenha()

            Else
                MessageBox.Show("As senhas não coincidem. Por favor, verifique.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                limpar_nsenha()

            End If
        Else
            MessageBox.Show("CPF ou usuário inválido. Verifique suas credenciais.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            limpar_nsenha()
        End If
    End Sub

    Private Function ValidarCpfUsuario(cpf As String, login As String) As Boolean
        Dim connectionString As String = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & caminho_banco

        Using connection As New System.Data.OleDb.OleDbConnection(connectionString)
            Try
                connection.Open()

                Dim query As String = "SELECT COUNT(*) FROM tb_login WHERE cpf = @cpf AND login = @login"
                Using command As New System.Data.OleDb.OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@cpf", cpf)
                    command.Parameters.AddWithValue("@login", login)

                    Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

                    Return result > 0
                End Using
            Catch ex As Exception
                MsgBox("Erro ao acessar o banco de dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                Return False
            Finally
                connection.Close()
            End Try
        End Using


    End Function
    Private Sub AtualizarSenha(cpf As String, novaSenha As String)
        Try
            Dim conexao As New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & caminho_banco)


            conexao.Open()
            Dim query As String = "UPDATE tb_login SET senha = @novaSenha WHERE cpf = @cpf"
            Using comando As New OleDbCommand(query, conexao)
                comando.Parameters.AddWithValue("@novaSenha", novaSenha)
                comando.Parameters.AddWithValue("@cpf", cpf)

                comando.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("Erro ao acessar banco!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub mudar_senha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        hide_pass2.Hide()
    End Sub



    Private Sub mudar_senha_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        login.Show()
    End Sub

    Private Sub txt_confirmarsenha_TextChanged(sender As Object, e As EventArgs) Handles txt_confirmarsenha.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub btn2_hide_Click(sender As Object, e As EventArgs) Handles btn2_hide.Click
        txt_novasenha.UseSystemPasswordChar = Not txt_novasenha.UseSystemPasswordChar
        txt_confirmarsenha.UseSystemPasswordChar = Not txt_confirmarsenha.UseSystemPasswordChar
        btn2_hide.Hide()
        btn2_show.Show()
        show_pass2.Hide()
        hide_pass2.Show()
    End Sub

    Private Sub btn2_show_Click(sender As Object, e As EventArgs) Handles btn2_show.Click
        txt_novasenha.UseSystemPasswordChar = Not txt_novasenha.UseSystemPasswordChar
        txt_confirmarsenha.UseSystemPasswordChar = Not txt_confirmarsenha.UseSystemPasswordChar
        btn2_hide.Show()
        btn2_show.Hide()
        show_pass2.Show()
        hide_pass2.Hide()
    End Sub
End Class