Public Class Form1
    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .Title = "SELECIONE UMA FOTO DO CLIENTE"
                .InitialDirectory = Application.StartupPath & "\Fotos"
                .ShowDialog()
                diretorio = .FileName
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_dados()
        carregar_tipo()
        carregar_t()
        carregar_sala()
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Try
            If String.IsNullOrEmpty(txt_cpf.Text) OrElse
               String.IsNullOrEmpty(txt_nome.Text) OrElse
               String.IsNullOrEmpty(cmb_data_nasc.Text) OrElse
               String.IsNullOrEmpty(txt_fone.Text) OrElse
               String.IsNullOrEmpty(cmb_tiposang.Text) OrElse
               String.IsNullOrEmpty(txt_doenca.Text) OrElse
               String.IsNullOrEmpty(cmb_sala.Text) OrElse
               String.IsNullOrEmpty(diretorio) Then
                MsgBox("Preencha todos os campos antes de salvar!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
                limpar_cadastro()
                Exit Sub
            End If
            SQL = "select * from tb_cadastro where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = True Then
                Dim tiposanguineo As String = cmb_tiposang.SelectedItem.ToString()
                Dim sala As String = cmb_sala.SelectedItem.ToString()
                SQL = "insert into tb_cadastro (cpf, nome, data_nasc, fone, tipos_sanguineos, doenca, sala, foto) values ('" & txt_cpf.Text & "', " &
                                                                                                            "'" & txt_nome.Text & "', " &
                                                                                                            "'" & cmb_data_nasc.Value.Date & "', " &
                                                                                                            "'" & txt_fone.Text & "', " &
                                                                                                            "'" & tiposanguineo & "', " &
                                                                                                            "'" & txt_doenca.Text & "', " &
                                                                                                            "'" & sala & "', " &
                                                                                                            "'" & diretorio & "')"
                rs = db.Execute(UCase(SQL))
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

            Else
                SQL = "update tb_cadastro set nome='" & txt_nome.Text & "', " &
                                              "data_nasc='" & cmb_data_nasc.Value.Date & "', " &
                                              "fone='" & txt_fone.Text & "', " &
                                              "tipos_sanguineos='" & cmb_tiposang.Text & "', " &
                                              "doenca='" & txt_doenca.Text & "', " &
                                              "sala='" & cmb_sala.Text & "', " &
                                              "foto='" & diretorio & "' where cpf='" & txt_cpf.Text & "'"
                rs = db.Execute(UCase(SQL))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

            End If
            limpar_cadastro()
            carregar_dados()
        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Try
            SQL = "select * from tb_cadastro where " & cmb_tipo.Text & " like '" & txt_buscar.Text & "%' order by nome asc"
            rs = db.Execute(SQL)
            cont = 1
            With dgv_dados
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, Nothing, Nothing)
                    cont = cont + 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try

    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            With dgv_dados

                If .CurrentRow.Cells(3).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    SQL = "select * from tb_cadastro where cpf='" & aux_cpf & "'"
                    rs = db.Execute(SQL)
                    If rs.EOF = False Then
                        txt_cpf.Text = rs.Fields(0).Value
                        txt_nome.Text = rs.Fields(1).Value
                        cmb_data_nasc.Value = rs.Fields(2).Value
                        txt_fone.Text = rs.Fields(3).Value
                        cmb_tiposang.Text = rs.Fields(4).Value
                        txt_doenca.Text = rs.Fields(5).Value
                        cmb_sala.Text = rs.Fields(6).Value
                        diretorio = rs.Fields(7).Value

                        img_foto.Load(diretorio)
                    End If
                ElseIf .CurrentRow.Cells(4).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja realmente excluir o " + vbNewLine &
                                "CPF: " & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO")
                    If resp = MsgBoxResult.Yes Then
                        SQL = "delete * from tb_cadastro where cpf='" & aux_cpf & "'"
                        rs = db.Execute(SQL)
                        limpar_cadastro()
                        carregar_dados()
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Hide()
        tela_recep.Show()
    End Sub


End Class
