Public Class tela_pacientes
    Private Sub tela_pacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_d()
        carregar_tipo2()
    End Sub

    Private Sub tela_pacientes_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Hide()
        tela_recep.Show()
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) 
        Me.Hide()
        tela_recep.Show()
    End Sub



    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        Try
            SQL = "select * from tb_cadastro where " & cmb_tipo.Text & " like '" & txt_buscar.Text & "%' order by nome asc"
            rs = db.Execute(SQL)
            cont = 1
            With dgv_pacientes
                .Rows.Clear()
                Do While rs.EOF = False 'Enquanto existir registro no banco
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(6).Value, rs.Fields(2).Value)
                    cont = cont + 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
End Class