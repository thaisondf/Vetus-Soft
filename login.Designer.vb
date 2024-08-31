<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_login = New System.Windows.Forms.TextBox()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_hide = New System.Windows.Forms.PictureBox()
        Me.show_pass = New System.Windows.Forms.Label()
        Me.hide_pass = New System.Windows.Forms.Label()
        Me.btn_show = New System.Windows.Forms.PictureBox()
        CType(Me.btn_hide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_show, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(207, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "LOGIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(207, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "SENHA"
        '
        'txt_login
        '
        Me.txt_login.Location = New System.Drawing.Point(121, 73)
        Me.txt_login.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(245, 29)
        Me.txt_login.TabIndex = 0
        '
        'txt_senha
        '
        Me.txt_senha.Location = New System.Drawing.Point(121, 134)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(245, 29)
        Me.txt_senha.TabIndex = 1
        Me.txt_senha.UseSystemPasswordChar = True
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_login.Image = CType(resources.GetObject("btn_login.Image"), System.Drawing.Image)
        Me.btn_login.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_login.Location = New System.Drawing.Point(192, 213)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(96, 43)
        Me.btn_login.TabIndex = 3
        Me.btn_login.Text = "ENTRAR"
        Me.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(176, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "esqueceu a senha?"
        '
        'btn_hide
        '
        Me.btn_hide.BackColor = System.Drawing.Color.Transparent
        Me.btn_hide.Image = CType(resources.GetObject("btn_hide.Image"), System.Drawing.Image)
        Me.btn_hide.Location = New System.Drawing.Point(372, 134)
        Me.btn_hide.Name = "btn_hide"
        Me.btn_hide.Size = New System.Drawing.Size(17, 29)
        Me.btn_hide.TabIndex = 5
        Me.btn_hide.TabStop = False
        '
        'show_pass
        '
        Me.show_pass.AutoSize = True
        Me.show_pass.BackColor = System.Drawing.Color.Transparent
        Me.show_pass.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.show_pass.Location = New System.Drawing.Point(389, 134)
        Me.show_pass.Name = "show_pass"
        Me.show_pass.Size = New System.Drawing.Size(70, 16)
        Me.show_pass.TabIndex = 6
        Me.show_pass.Text = "exibir senha"
        '
        'hide_pass
        '
        Me.hide_pass.AutoSize = True
        Me.hide_pass.BackColor = System.Drawing.Color.Transparent
        Me.hide_pass.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hide_pass.Location = New System.Drawing.Point(389, 134)
        Me.hide_pass.Name = "hide_pass"
        Me.hide_pass.Size = New System.Drawing.Size(78, 16)
        Me.hide_pass.TabIndex = 7
        Me.hide_pass.Text = "ocultar senha"
        '
        'btn_show
        '
        Me.btn_show.BackColor = System.Drawing.Color.Transparent
        Me.btn_show.Image = CType(resources.GetObject("btn_show.Image"), System.Drawing.Image)
        Me.btn_show.Location = New System.Drawing.Point(372, 134)
        Me.btn_show.Name = "btn_show"
        Me.btn_show.Size = New System.Drawing.Size(17, 29)
        Me.btn_show.TabIndex = 8
        Me.btn_show.TabStop = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(479, 270)
        Me.Controls.Add(Me.show_pass)
        Me.Controls.Add(Me.btn_hide)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.txt_login)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.hide_pass)
        Me.Controls.Add(Me.btn_show)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MaximizeBox = False
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BEM-VINDO AO VETUS            ══════ • 『 LOGIN 』 • ══════"
        CType(Me.btn_hide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_show, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_login As TextBox
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_hide As PictureBox
    Friend WithEvents show_pass As Label
    Friend WithEvents hide_pass As Label
    Friend WithEvents btn_show As PictureBox
End Class
