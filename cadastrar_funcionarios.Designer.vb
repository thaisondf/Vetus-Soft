<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cadastrar_funcionarios
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cadastrar_funcionarios))
        Me.txt_nomef = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cadastrarsenha = New System.Windows.Forms.TextBox()
        Me.txt_cadastrarlogin = New System.Windows.Forms.TextBox()
        Me.cmb_new_employe = New System.Windows.Forms.Button()
        Me.cmb_permissao = New System.Windows.Forms.ComboBox()
        Me.txt_cpff = New System.Windows.Forms.MaskedTextBox()
        Me.btn_voltar = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.show_pass3 = New System.Windows.Forms.Label()
        Me.btn3_hide = New System.Windows.Forms.PictureBox()
        Me.hide_pass3 = New System.Windows.Forms.Label()
        Me.btn3_show = New System.Windows.Forms.PictureBox()
        CType(Me.btn_voltar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn3_hide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn3_show, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_nomef
        '
        Me.txt_nomef.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_nomef.Location = New System.Drawing.Point(7, 32)
        Me.txt_nomef.Name = "txt_nomef"
        Me.txt_nomef.Size = New System.Drawing.Size(253, 22)
        Me.txt_nomef.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(41, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 24)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "CPF"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(100, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "NOME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(358, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LOGIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiBold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(354, 64)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "SENHA"
        '
        'txt_cadastrarsenha
        '
        Me.txt_cadastrarsenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_cadastrarsenha.Location = New System.Drawing.Point(265, 89)
        Me.txt_cadastrarsenha.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cadastrarsenha.Name = "txt_cadastrarsenha"
        Me.txt_cadastrarsenha.Size = New System.Drawing.Size(253, 22)
        Me.txt_cadastrarsenha.TabIndex = 4
        Me.txt_cadastrarsenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_cadastrarsenha.UseSystemPasswordChar = True
        '
        'txt_cadastrarlogin
        '
        Me.txt_cadastrarlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_cadastrarlogin.Location = New System.Drawing.Point(265, 32)
        Me.txt_cadastrarlogin.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cadastrarlogin.Name = "txt_cadastrarlogin"
        Me.txt_cadastrarlogin.Size = New System.Drawing.Size(253, 22)
        Me.txt_cadastrarlogin.TabIndex = 1
        Me.txt_cadastrarlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmb_new_employe
        '
        Me.cmb_new_employe.BackColor = System.Drawing.Color.Transparent
        Me.cmb_new_employe.BackgroundImage = CType(resources.GetObject("cmb_new_employe.BackgroundImage"), System.Drawing.Image)
        Me.cmb_new_employe.FlatAppearance.BorderSize = 0
        Me.cmb_new_employe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_new_employe.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmb_new_employe.Location = New System.Drawing.Point(211, 127)
        Me.cmb_new_employe.Name = "cmb_new_employe"
        Me.cmb_new_employe.Size = New System.Drawing.Size(103, 36)
        Me.cmb_new_employe.TabIndex = 5
        Me.cmb_new_employe.Text = "CADASTRAR"
        Me.cmb_new_employe.UseVisualStyleBackColor = False
        '
        'cmb_permissao
        '
        Me.cmb_permissao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmb_permissao.FormattingEnabled = True
        Me.cmb_permissao.Location = New System.Drawing.Point(141, 88)
        Me.cmb_permissao.Name = "cmb_permissao"
        Me.cmb_permissao.Size = New System.Drawing.Size(119, 24)
        Me.cmb_permissao.TabIndex = 3
        '
        'txt_cpff
        '
        Me.txt_cpff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_cpff.Location = New System.Drawing.Point(7, 89)
        Me.txt_cpff.Mask = "999,999,999-99"
        Me.txt_cpff.Name = "txt_cpff"
        Me.txt_cpff.Size = New System.Drawing.Size(119, 22)
        Me.txt_cpff.TabIndex = 2
        Me.txt_cpff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.Transparent
        Me.btn_voltar.Image = CType(resources.GetObject("btn_voltar.Image"), System.Drawing.Image)
        Me.btn_voltar.Location = New System.Drawing.Point(465, 114)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(52, 53)
        Me.btn_voltar.TabIndex = 16
        Me.btn_voltar.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(160, 64)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 24)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "CARGO"
        '
        'show_pass3
        '
        Me.show_pass3.AutoSize = True
        Me.show_pass3.BackColor = System.Drawing.Color.Transparent
        Me.show_pass3.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.show_pass3.ForeColor = System.Drawing.Color.White
        Me.show_pass3.Location = New System.Drawing.Point(363, 122)
        Me.show_pass3.Name = "show_pass3"
        Me.show_pass3.Size = New System.Drawing.Size(70, 16)
        Me.show_pass3.TabIndex = 19
        Me.show_pass3.Text = "exibir senha"
        '
        'btn3_hide
        '
        Me.btn3_hide.BackColor = System.Drawing.Color.Transparent
        Me.btn3_hide.Image = CType(resources.GetObject("btn3_hide.Image"), System.Drawing.Image)
        Me.btn3_hide.Location = New System.Drawing.Point(348, 122)
        Me.btn3_hide.Name = "btn3_hide"
        Me.btn3_hide.Size = New System.Drawing.Size(17, 29)
        Me.btn3_hide.TabIndex = 18
        Me.btn3_hide.TabStop = False
        '
        'hide_pass3
        '
        Me.hide_pass3.AutoSize = True
        Me.hide_pass3.BackColor = System.Drawing.Color.Transparent
        Me.hide_pass3.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hide_pass3.ForeColor = System.Drawing.Color.White
        Me.hide_pass3.Location = New System.Drawing.Point(363, 122)
        Me.hide_pass3.Name = "hide_pass3"
        Me.hide_pass3.Size = New System.Drawing.Size(78, 16)
        Me.hide_pass3.TabIndex = 20
        Me.hide_pass3.Text = "ocultar senha"
        '
        'btn3_show
        '
        Me.btn3_show.BackColor = System.Drawing.Color.Transparent
        Me.btn3_show.Image = CType(resources.GetObject("btn3_show.Image"), System.Drawing.Image)
        Me.btn3_show.Location = New System.Drawing.Point(348, 122)
        Me.btn3_show.Name = "btn3_show"
        Me.btn3_show.Size = New System.Drawing.Size(17, 29)
        Me.btn3_show.TabIndex = 21
        Me.btn3_show.TabStop = False
        '
        'cadastrar_funcionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(529, 172)
        Me.Controls.Add(Me.show_pass3)
        Me.Controls.Add(Me.btn3_hide)
        Me.Controls.Add(Me.hide_pass3)
        Me.Controls.Add(Me.btn3_show)
        Me.Controls.Add(Me.cmb_new_employe)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.cmb_permissao)
        Me.Controls.Add(Me.txt_cpff)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_cadastrarlogin)
        Me.Controls.Add(Me.txt_cadastrarsenha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nomef)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "cadastrar_funcionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VETUS SOFT       ══════ • 『 CADASTRAR FUNCIONÁRIOS 』 • ══════"
        CType(Me.btn_voltar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn3_hide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn3_show, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nomef As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_cadastrarsenha As TextBox
    Friend WithEvents txt_cadastrarlogin As TextBox
    Friend WithEvents cmb_new_employe As Button
    Friend WithEvents cmb_permissao As ComboBox
    Friend WithEvents txt_cpff As MaskedTextBox
    Friend WithEvents btn_voltar As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents show_pass3 As Label
    Friend WithEvents btn3_hide As PictureBox
    Friend WithEvents hide_pass3 As Label
    Friend WithEvents btn3_show As PictureBox
End Class
