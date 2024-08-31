<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mudar_senha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mudar_senha))
        Me.txt_busuario = New System.Windows.Forms.TextBox()
        Me.txt_novasenha = New System.Windows.Forms.TextBox()
        Me.txt_confirmarsenha = New System.Windows.Forms.TextBox()
        Me.btn_trocarsenha = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_bcpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.show_pass2 = New System.Windows.Forms.Label()
        Me.btn2_hide = New System.Windows.Forms.PictureBox()
        Me.hide_pass2 = New System.Windows.Forms.Label()
        Me.btn2_show = New System.Windows.Forms.PictureBox()
        CType(Me.btn2_hide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn2_show, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_busuario
        '
        Me.txt_busuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_busuario.Location = New System.Drawing.Point(191, 82)
        Me.txt_busuario.Multiline = True
        Me.txt_busuario.Name = "txt_busuario"
        Me.txt_busuario.Size = New System.Drawing.Size(160, 22)
        Me.txt_busuario.TabIndex = 1
        '
        'txt_novasenha
        '
        Me.txt_novasenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_novasenha.Location = New System.Drawing.Point(97, 157)
        Me.txt_novasenha.Name = "txt_novasenha"
        Me.txt_novasenha.Size = New System.Drawing.Size(253, 22)
        Me.txt_novasenha.TabIndex = 2
        Me.txt_novasenha.UseSystemPasswordChar = True
        '
        'txt_confirmarsenha
        '
        Me.txt_confirmarsenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_confirmarsenha.Location = New System.Drawing.Point(98, 209)
        Me.txt_confirmarsenha.Name = "txt_confirmarsenha"
        Me.txt_confirmarsenha.Size = New System.Drawing.Size(253, 22)
        Me.txt_confirmarsenha.TabIndex = 3
        Me.txt_confirmarsenha.UseSystemPasswordChar = True
        '
        'btn_trocarsenha
        '
        Me.btn_trocarsenha.BackColor = System.Drawing.Color.Transparent
        Me.btn_trocarsenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_trocarsenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_trocarsenha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_trocarsenha.Image = CType(resources.GetObject("btn_trocarsenha.Image"), System.Drawing.Image)
        Me.btn_trocarsenha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_trocarsenha.Location = New System.Drawing.Point(170, 256)
        Me.btn_trocarsenha.Name = "btn_trocarsenha"
        Me.btn_trocarsenha.Size = New System.Drawing.Size(106, 36)
        Me.btn_trocarsenha.TabIndex = 4
        Me.btn_trocarsenha.Text = "ALTERAR"
        Me.btn_trocarsenha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_trocarsenha.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(116, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "CPF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(94, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "USUARIO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(94, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "NOVA SENHA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(1824, -89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "CONFIRMAR SENHA"
        '
        'txt_bcpf
        '
        Me.txt_bcpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bcpf.Location = New System.Drawing.Point(191, 45)
        Me.txt_bcpf.Mask = "999,999,999-99"
        Me.txt_bcpf.Name = "txt_bcpf"
        Me.txt_bcpf.Size = New System.Drawing.Size(159, 22)
        Me.txt_bcpf.TabIndex = 0
        Me.txt_bcpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(94, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "CONFIRMAR SENHA"
        '
        'show_pass2
        '
        Me.show_pass2.AutoSize = True
        Me.show_pass2.BackColor = System.Drawing.Color.Transparent
        Me.show_pass2.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.show_pass2.Location = New System.Drawing.Point(364, 182)
        Me.show_pass2.Name = "show_pass2"
        Me.show_pass2.Size = New System.Drawing.Size(70, 16)
        Me.show_pass2.TabIndex = 11
        Me.show_pass2.Text = "exibir senha"
        '
        'btn2_hide
        '
        Me.btn2_hide.BackColor = System.Drawing.Color.Transparent
        Me.btn2_hide.Image = CType(resources.GetObject("btn2_hide.Image"), System.Drawing.Image)
        Me.btn2_hide.Location = New System.Drawing.Point(349, 182)
        Me.btn2_hide.Name = "btn2_hide"
        Me.btn2_hide.Size = New System.Drawing.Size(17, 21)
        Me.btn2_hide.TabIndex = 10
        Me.btn2_hide.TabStop = False
        '
        'hide_pass2
        '
        Me.hide_pass2.AutoSize = True
        Me.hide_pass2.BackColor = System.Drawing.Color.Transparent
        Me.hide_pass2.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hide_pass2.Location = New System.Drawing.Point(364, 182)
        Me.hide_pass2.Name = "hide_pass2"
        Me.hide_pass2.Size = New System.Drawing.Size(78, 16)
        Me.hide_pass2.TabIndex = 12
        Me.hide_pass2.Text = "ocultar senha"
        '
        'btn2_show
        '
        Me.btn2_show.BackColor = System.Drawing.Color.Transparent
        Me.btn2_show.Image = CType(resources.GetObject("btn2_show.Image"), System.Drawing.Image)
        Me.btn2_show.Location = New System.Drawing.Point(349, 182)
        Me.btn2_show.Name = "btn2_show"
        Me.btn2_show.Size = New System.Drawing.Size(17, 21)
        Me.btn2_show.TabIndex = 13
        Me.btn2_show.TabStop = False
        '
        'mudar_senha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(454, 318)
        Me.Controls.Add(Me.show_pass2)
        Me.Controls.Add(Me.btn2_hide)
        Me.Controls.Add(Me.hide_pass2)
        Me.Controls.Add(Me.btn2_show)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_bcpf)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_trocarsenha)
        Me.Controls.Add(Me.txt_confirmarsenha)
        Me.Controls.Add(Me.txt_novasenha)
        Me.Controls.Add(Me.txt_busuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "mudar_senha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VETUS SOFT       ══════ • 『 ALTERAR SENHA 』 • ══════"
        CType(Me.btn2_hide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn2_show, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_busuario As TextBox
    Friend WithEvents txt_novasenha As TextBox
    Friend WithEvents txt_confirmarsenha As TextBox
    Friend WithEvents btn_trocarsenha As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_bcpf As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents show_pass2 As Label
    Friend WithEvents btn2_hide As PictureBox
    Friend WithEvents hide_pass2 As Label
    Friend WithEvents btn2_show As PictureBox
End Class
