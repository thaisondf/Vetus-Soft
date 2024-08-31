Public Class cadastrar_funcionarios
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmb_new_employe.Click
        Try
            If String.IsNullOrEmpty(txt_nomef.Text) OrElse
               String.IsNullOrEmpty(txt_cpff.Text) OrElse
               String.IsNullOrEmpty(txt_cadastrarlogin.Text) OrElse
               String.IsNullOrEmpty(txt_cadastrarsenha.Text) OrElse
               cmb_permissao.SelectedItem Is Nothing Then
                MsgBox("Preencha todos os campos antes de salvar!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                limpar_funcio()
                Exit Sub
            End If
            SQL = "SELECT * FROM tb_login WHERE login='" & txt_cadastrarlogin.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF Then
                Dim permissao As String = cmb_permissao.SelectedItem.ToString()
                SQL = "INSERT INTO tb_login (nome, cpf, login, senha, permissao, status) VALUES ('" & txt_nomef.Text & "'," &
                                                                                   "'" & txt_cpff.Text & "', " &
                                                                                   "'" & txt_cadastrarlogin.Text & "', " &
                                                                                   "'" & txt_cadastrarsenha.Text & "', " &
                                                                                   "'" & permissao & "', " &
                                                                                   "'válida')"
                rs = db.Execute(SQL)
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                carregar_d()
                limpar_funcio()
            Else
                MsgBox("Login já existente!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Erro ao gravar: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub cadastrar_funcionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_permissao()
        hide_pass3.Hide()
    End Sub

    Private Sub cadastrar_funcionarios_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        login.Close()
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Hide()
        tela_gerente.Show()
    End Sub

    Private Sub txt_cpff_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_cpff.MaskInputRejected

    End Sub

    Private Sub btn3_hide_Click(sender As Object, e As EventArgs) Handles btn3_hide.Click
        txt_cadastrarsenha.UseSystemPasswordChar = Not txt_cadastrarsenha.UseSystemPasswordChar
        btn3_hide.Hide()
        btn3_show.Show()
        show_pass3.Hide()
        hide_pass3.Show()
    End Sub

    Private Sub btn3_show_Click(sender As Object, e As EventArgs) Handles btn3_show.Click
        txt_cadastrarsenha.UseSystemPasswordChar = Not txt_cadastrarsenha.UseSystemPasswordChar
        btn3_hide.Show()
        btn3_show.Hide()
        show_pass3.Show()
        hide_pass3.Hide()
    End Sub
End Class