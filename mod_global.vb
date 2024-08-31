Module mod_global
    Public diretorio, SQL, aux_cpf, resp As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public caminho_banco = Application.StartupPath & "\banco\cadastro.mdb"
    Public cont, tentativa As Integer


    Sub conectar_banco()
        'String de Conexão ADO Banco de Dados Access
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & caminho_banco)

        Catch ex As Exception
            MsgBox("Erro ao conectar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub limpar_cadastro()
        Try
            With Form1
                .txt_cpf.Clear()
                .txt_nome.Clear()
                .cmb_data_nasc.Value = Now
                .txt_fone.Clear()
                .txt_doenca.Clear()
                .img_foto.Load(Application.StartupPath & "\Fotos\nova_foto.png")
                .txt_cpf.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub limpar_cotidiano()
        Try
            With cotidianos
                .txt_cpf.Clear()
                .txt_cotidiano1.Clear()
                .txt_cotidiano2.Clear()
                .txt_cotidiano3.Clear()
                .txt_cotidiano4.Clear()
                .txt_cotidiano5.Clear()
                .txt_cotidiano6.Clear()
                .txt_cpf.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_dados()
        Try
            SQL = "select * from tb_cadastro order by nome asc"
            rs = db.Execute(SQL)
            cont = 1
            With Form1.dgv_dados
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

    Sub carregar_sala()

        Try
            With Form1.cmb_sala.Items
                .Add("1")
                .Add("2")
                .Add("3")
            End With
            Form1.cmb_sala.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao carregar o tipo do campo", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

    End Sub
    Sub carregar_tipo()

        Try
            With Form1.cmb_tipo.Items
                .Add("CPF")
                .Add("Nome")
            End With
            Form1.cmb_tipo.SelectedIndex = 1
        Catch ex As Exception
            MsgBox("Erro ao carregar o tipo do campo", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

    End Sub

    Sub carregar_tipo2()

        Try
            With tela_pacientes.cmb_tipo.Items
                .Add("CPF")
                .Add("Nome")
            End With
            tela_pacientes.cmb_tipo.SelectedIndex = 1
        Catch ex As Exception
            MsgBox("Erro ao carregar o tipo do campo", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

    End Sub
    Sub carregar_t()
        'A+, B+, AB+, O+, A-, B-, AB-, O-
        Try
            With Form1.cmb_tiposang.Items
                .Add("A+")
                .Add("B+")
                .Add("AB+")
                .Add("O+")
                .Add("A-")
                .Add("B-")
                .Add("AB-")
                .Add("O-")
            End With
            Form1.cmb_tiposang.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("Erro ao carregar o tipo sanguineo", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

    End Sub

    Sub carregar_sala1()
        Try
            SQL = "SELECT * FROM tb_cadastro WHERE sala = '1'"
            rs = db.Execute(SQL)
            cont = 1
            With sala1.dgv_sala1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(8).Value, rs.Fields(9).Value, rs.Fields(10).Value, rs.Fields(11).Value, rs.Fields(12).Value, rs.Fields(13).Value)
                    cont = cont + 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub


    Sub carregar_sala2()
        Try
            SQL = "SELECT * FROM tb_cadastro WHERE sala = '2'"
            rs = db.Execute(SQL)
            cont = 1
            With sala2.dgv_sala2
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(8).Value, rs.Fields(9).Value, rs.Fields(10).Value, rs.Fields(11).Value, rs.Fields(12).Value, rs.Fields(13).Value)
                    cont = cont + 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_sala3()
        Try
            SQL = "SELECT * FROM tb_cadastro WHERE sala = '3'"
            rs = db.Execute(SQL)
            cont = 1
            With sala3.dgv_sala3
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(8).Value, rs.Fields(9).Value, rs.Fields(10).Value, rs.Fields(11).Value, rs.Fields(12).Value, rs.Fields(13).Value)
                    cont = cont + 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub carregar_d()
        Try
            SQL = "select * from tb_cadastro order by nome asc"
            rs = db.Execute(SQL)
            cont = 1
            With tela_pacientes.dgv_pacientes
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(3).Value, rs.Fields(6).Value, rs.Fields(2).Value)
                    cont = cont + 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
    Sub carregar_permissao()
        Try
            With cadastrar_funcionarios.cmb_permissao.Items
                .Add("enfermeiro")
                .Add("recepcionista")
                .Add("gerente")
            End With
            cadastrar_funcionarios.cmb_permissao.SelectedIndex = 1
        Catch ex As Exception
            MsgBox("Erro ao carregar o tipo do campo", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Sub limpar_funcio()
        Try
            With cadastrar_funcionarios
                .txt_cpff.Clear()
                .txt_nomef.Clear()
                .txt_cadastrarlogin.Clear()
                .txt_cadastrarsenha.Clear()
                .txt_nomef.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
    Sub limpar_login()
        Try
            With login
                .txt_login.Clear()
                .txt_senha.Clear()
                .txt_login.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
    Sub limpar_nsenha()


        Try
            With mudar_senha
                .txt_bcpf.Clear()
                .txt_busuario.Clear()
                .txt_confirmarsenha.Clear()
                .txt_novasenha.Clear()
            End With
        Catch ex As Exception
            MsgBox("Erro ao apagar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub




End Module
