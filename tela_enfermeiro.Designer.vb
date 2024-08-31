<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tela_enfermeiro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tela_enfermeiro))
        Me.btn_cotiano = New System.Windows.Forms.Button()
        Me.btn_sala1 = New System.Windows.Forms.Button()
        Me.btn_sala3 = New System.Windows.Forms.Button()
        Me.btn_sala2 = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.PictureBox()
        Me.btn_editarcotidiano = New System.Windows.Forms.Button()
        CType(Me.btn_voltar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_cotiano
        '
        Me.btn_cotiano.BackColor = System.Drawing.Color.White
        Me.btn_cotiano.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cotiano.ForeColor = System.Drawing.Color.White
        Me.btn_cotiano.Image = CType(resources.GetObject("btn_cotiano.Image"), System.Drawing.Image)
        Me.btn_cotiano.Location = New System.Drawing.Point(103, 87)
        Me.btn_cotiano.Name = "btn_cotiano"
        Me.btn_cotiano.Size = New System.Drawing.Size(124, 65)
        Me.btn_cotiano.TabIndex = 0
        Me.btn_cotiano.Text = "COTIDIANO DOS PACIENTES"
        Me.btn_cotiano.UseVisualStyleBackColor = False
        '
        'btn_sala1
        '
        Me.btn_sala1.BackColor = System.Drawing.Color.White
        Me.btn_sala1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sala1.ForeColor = System.Drawing.Color.White
        Me.btn_sala1.Image = CType(resources.GetObject("btn_sala1.Image"), System.Drawing.Image)
        Me.btn_sala1.Location = New System.Drawing.Point(103, 39)
        Me.btn_sala1.Name = "btn_sala1"
        Me.btn_sala1.Size = New System.Drawing.Size(124, 65)
        Me.btn_sala1.TabIndex = 2
        Me.btn_sala1.Text = "SALA 1"
        Me.btn_sala1.UseVisualStyleBackColor = False
        Me.btn_sala1.Visible = False
        '
        'btn_sala3
        '
        Me.btn_sala3.BackColor = System.Drawing.Color.White
        Me.btn_sala3.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sala3.ForeColor = System.Drawing.Color.White
        Me.btn_sala3.Image = CType(resources.GetObject("btn_sala3.Image"), System.Drawing.Image)
        Me.btn_sala3.Location = New System.Drawing.Point(103, 240)
        Me.btn_sala3.Name = "btn_sala3"
        Me.btn_sala3.Size = New System.Drawing.Size(124, 65)
        Me.btn_sala3.TabIndex = 4
        Me.btn_sala3.Text = "SALA 3"
        Me.btn_sala3.UseVisualStyleBackColor = False
        Me.btn_sala3.Visible = False
        '
        'btn_sala2
        '
        Me.btn_sala2.BackColor = System.Drawing.Color.White
        Me.btn_sala2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sala2.ForeColor = System.Drawing.Color.White
        Me.btn_sala2.Image = CType(resources.GetObject("btn_sala2.Image"), System.Drawing.Image)
        Me.btn_sala2.Location = New System.Drawing.Point(103, 142)
        Me.btn_sala2.Name = "btn_sala2"
        Me.btn_sala2.Size = New System.Drawing.Size(124, 65)
        Me.btn_sala2.TabIndex = 3
        Me.btn_sala2.Text = "SALA 2"
        Me.btn_sala2.UseVisualStyleBackColor = False
        Me.btn_sala2.Visible = False
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.Transparent
        Me.btn_voltar.Image = CType(resources.GetObject("btn_voltar.Image"), System.Drawing.Image)
        Me.btn_voltar.Location = New System.Drawing.Point(261, 142)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(52, 53)
        Me.btn_voltar.TabIndex = 16
        Me.btn_voltar.TabStop = False
        Me.btn_voltar.Visible = False
        '
        'btn_editarcotidiano
        '
        Me.btn_editarcotidiano.BackColor = System.Drawing.Color.White
        Me.btn_editarcotidiano.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editarcotidiano.ForeColor = System.Drawing.Color.White
        Me.btn_editarcotidiano.Image = CType(resources.GetObject("btn_editarcotidiano.Image"), System.Drawing.Image)
        Me.btn_editarcotidiano.Location = New System.Drawing.Point(103, 190)
        Me.btn_editarcotidiano.Name = "btn_editarcotidiano"
        Me.btn_editarcotidiano.Size = New System.Drawing.Size(124, 65)
        Me.btn_editarcotidiano.TabIndex = 1
        Me.btn_editarcotidiano.TabStop = False
        Me.btn_editarcotidiano.Text = "EDITAR COTIDIANOS"
        Me.btn_editarcotidiano.UseVisualStyleBackColor = False
        '
        'tela_enfermeiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(325, 349)
        Me.Controls.Add(Me.btn_editarcotidiano)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.btn_sala2)
        Me.Controls.Add(Me.btn_sala3)
        Me.Controls.Add(Me.btn_sala1)
        Me.Controls.Add(Me.btn_cotiano)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "tela_enfermeiro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VETUS SOFT"
        CType(Me.btn_voltar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Friend WithEvents btn_cotiano As Button
    Friend WithEvents btn_sala1 As Button
    Friend WithEvents btn_sala3 As Button
    Friend WithEvents btn_sala2 As Button
    Friend WithEvents btn_voltar As PictureBox
    Friend WithEvents btn_editarcotidiano As Button
End Class
