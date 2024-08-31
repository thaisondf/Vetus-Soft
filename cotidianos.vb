Imports System.Data.OleDb

Public Class cotidianos
    Private Sub cotidianos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()

    End Sub

    Private Sub txt_cpf_TextChanged(sender As Object, e As EventArgs) Handles txt_cpf.TextChanged
        Try
            Dim cpf As String = txt_cpf.Text


            Dim query As String = "SELECT cotidiano1, cotidiano2, cotidiano3, cotidiano4, cotidiano5, cotidiano6 FROM tb_cadastro WHERE cpf = @cpf"


            Using conn As New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & caminho_banco)
                conn.Open()
                Using cmd As New OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("@cpf", cpf)
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()

                    If reader.Read() Then
                        txt_cotidiano1.Text = reader("cotidiano1").ToString()
                        txt_cotidiano2.Text = reader("cotidiano2").ToString()
                        txt_cotidiano3.Text = reader("cotidiano3").ToString()
                        txt_cotidiano4.Text = reader("cotidiano4").ToString()
                        txt_cotidiano5.Text = reader("cotidiano5").ToString()
                        txt_cotidiano6.Text = reader("cotidiano6").ToString()

                    End If

                    reader.Close()
                End Using
            End Using
        Catch ex As Exception
            MsgBox("erro!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub



    Private Sub btn_cadastrarcotidiano_Click(sender As Object, e As EventArgs) Handles btn_cadastrarcotidiano.Click
        Try
            Dim cpf As String = txt_cpf.Text
            Dim cotidiano1 As String = txt_cotidiano1.Text
            Dim cotidiano2 As String = txt_cotidiano2.Text
            Dim cotidiano3 As String = txt_cotidiano3.Text
            Dim cotidiano4 As String = txt_cotidiano4.Text
            Dim cotidiano5 As String = txt_cotidiano5.Text
            Dim cotidiano6 As String = txt_cotidiano6.Text
            If String.IsNullOrEmpty(cpf) OrElse String.IsNullOrEmpty(cotidiano1) OrElse
               String.IsNullOrEmpty(cotidiano2) OrElse String.IsNullOrEmpty(cotidiano3) OrElse
               String.IsNullOrEmpty(cotidiano4) OrElse String.IsNullOrEmpty(cotidiano5) OrElse
               String.IsNullOrEmpty(cotidiano6) Then
                MsgBox("Preencha todos os campos antes de salvar!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                limpar_cotidiano()
                Exit Sub
            End If
            Dim SQL As String = "SELECT * FROM tb_cadastro WHERE cpf='" & cpf & "'"
            rs = db.Execute(SQL)

            If rs.EOF Then

                MsgBox("CPF não encontrado na tabela!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Else
                SQL = "UPDATE tb_cadastro SET cotidiano1='" & cotidiano1 & "', cotidiano2='" & cotidiano2 & "', cotidiano3='" & cotidiano3 & "', " &
                "cotidiano4='" & cotidiano4 & "', cotidiano5='" & cotidiano5 & "', cotidiano6='" & cotidiano6 & "' WHERE cpf='" & cpf & "'"
                rs = db.Execute(UCase(SQL))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If

            limpar_cotidiano()
            carregar_dados()
        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub



    Private Sub cotidianos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        tela_enfermeiro.Show()
    End Sub
End Class