<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cotidianos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cotidianos))
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cotidiano1 = New System.Windows.Forms.TextBox()
        Me.txt_cotidiano2 = New System.Windows.Forms.TextBox()
        Me.txt_cotidiano3 = New System.Windows.Forms.TextBox()
        Me.txt_cotidiano4 = New System.Windows.Forms.TextBox()
        Me.txt_cotidiano5 = New System.Windows.Forms.TextBox()
        Me.txt_cotidiano6 = New System.Windows.Forms.TextBox()
        Me.btn_cadastrarcotidiano = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(110, 53)
        Me.txt_cpf.Mask = "999,999,999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(134, 20)
        Me.txt_cpf.TabIndex = 0
        Me.txt_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_cotidiano1
        '
        Me.txt_cotidiano1.Location = New System.Drawing.Point(36, 113)
        Me.txt_cotidiano1.Name = "txt_cotidiano1"
        Me.txt_cotidiano1.Size = New System.Drawing.Size(134, 20)
        Me.txt_cotidiano1.TabIndex = 1
        '
        'txt_cotidiano2
        '
        Me.txt_cotidiano2.Location = New System.Drawing.Point(195, 113)
        Me.txt_cotidiano2.Name = "txt_cotidiano2"
        Me.txt_cotidiano2.Size = New System.Drawing.Size(134, 20)
        Me.txt_cotidiano2.TabIndex = 2
        '
        'txt_cotidiano3
        '
        Me.txt_cotidiano3.Location = New System.Drawing.Point(36, 177)
        Me.txt_cotidiano3.Name = "txt_cotidiano3"
        Me.txt_cotidiano3.Size = New System.Drawing.Size(134, 20)
        Me.txt_cotidiano3.TabIndex = 3
        '
        'txt_cotidiano4
        '
        Me.txt_cotidiano4.Location = New System.Drawing.Point(195, 177)
        Me.txt_cotidiano4.Name = "txt_cotidiano4"
        Me.txt_cotidiano4.Size = New System.Drawing.Size(134, 20)
        Me.txt_cotidiano4.TabIndex = 4
        '
        'txt_cotidiano5
        '
        Me.txt_cotidiano5.Location = New System.Drawing.Point(36, 250)
        Me.txt_cotidiano5.Name = "txt_cotidiano5"
        Me.txt_cotidiano5.Size = New System.Drawing.Size(134, 20)
        Me.txt_cotidiano5.TabIndex = 5
        '
        'txt_cotidiano6
        '
        Me.txt_cotidiano6.Location = New System.Drawing.Point(195, 250)
        Me.txt_cotidiano6.Name = "txt_cotidiano6"
        Me.txt_cotidiano6.Size = New System.Drawing.Size(134, 20)
        Me.txt_cotidiano6.TabIndex = 6
        '
        'btn_cadastrarcotidiano
        '
        Me.btn_cadastrarcotidiano.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_cadastrarcotidiano.ForeColor = System.Drawing.Color.White
        Me.btn_cadastrarcotidiano.Image = CType(resources.GetObject("btn_cadastrarcotidiano.Image"), System.Drawing.Image)
        Me.btn_cadastrarcotidiano.Location = New System.Drawing.Point(110, 297)
        Me.btn_cadastrarcotidiano.Name = "btn_cadastrarcotidiano"
        Me.btn_cadastrarcotidiano.Size = New System.Drawing.Size(146, 60)
        Me.btn_cadastrarcotidiano.TabIndex = 7
        Me.btn_cadastrarcotidiano.Text = "CADASTRAR/EDITAR"
        Me.btn_cadastrarcotidiano.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(125, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "DIGITE O CPF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(60, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "08:00-10:20"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(219, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "10:20-12:40"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(60, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "12:40-15:00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(219, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "15:00-17:20"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(60, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "17:20-19:40"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(220, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "19:40-22:00"
        '
        'cotidianos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(365, 391)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_cadastrarcotidiano)
        Me.Controls.Add(Me.txt_cotidiano6)
        Me.Controls.Add(Me.txt_cotidiano5)
        Me.Controls.Add(Me.txt_cotidiano4)
        Me.Controls.Add(Me.txt_cotidiano3)
        Me.Controls.Add(Me.txt_cotidiano2)
        Me.Controls.Add(Me.txt_cotidiano1)
        Me.Controls.Add(Me.txt_cpf)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "cotidianos"
        Me.Text = "VETUS SOFT          ══ • 『 COTIDIANOS 』 • ══"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents txt_cotidiano1 As TextBox
    Friend WithEvents txt_cotidiano2 As TextBox
    Friend WithEvents txt_cotidiano3 As TextBox
    Friend WithEvents txt_cotidiano4 As TextBox
    Friend WithEvents txt_cotidiano5 As TextBox
    Friend WithEvents txt_cotidiano6 As TextBox
    Friend WithEvents btn_cadastrarcotidiano As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
