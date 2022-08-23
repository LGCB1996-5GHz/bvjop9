<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnavion = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnbarco = New System.Windows.Forms.Button()
        Me.btnauto = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnavion
        '
        Me.btnavion.BackgroundImage = CType(resources.GetObject("btnavion.BackgroundImage"), System.Drawing.Image)
        Me.btnavion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnavion.Location = New System.Drawing.Point(98, 357)
        Me.btnavion.Name = "btnavion"
        Me.btnavion.Size = New System.Drawing.Size(140, 53)
        Me.btnavion.TabIndex = 0
        Me.btnavion.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(98, 331)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(435, 20)
        Me.TextBox1.TabIndex = 1
        '
        'btnbarco
        '
        Me.btnbarco.BackgroundImage = CType(resources.GetObject("btnbarco.BackgroundImage"), System.Drawing.Image)
        Me.btnbarco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbarco.Location = New System.Drawing.Point(246, 357)
        Me.btnbarco.Name = "btnbarco"
        Me.btnbarco.Size = New System.Drawing.Size(140, 53)
        Me.btnbarco.TabIndex = 2
        Me.btnbarco.UseVisualStyleBackColor = True
        '
        'btnauto
        '
        Me.btnauto.BackgroundImage = CType(resources.GetObject("btnauto.BackgroundImage"), System.Drawing.Image)
        Me.btnauto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnauto.Location = New System.Drawing.Point(393, 357)
        Me.btnauto.Name = "btnauto"
        Me.btnauto.Size = New System.Drawing.Size(140, 53)
        Me.btnauto.TabIndex = 3
        Me.btnauto.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(262, 183)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 80)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnauto)
        Me.Controls.Add(Me.btnbarco)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnavion)
        Me.MaximumSize = New System.Drawing.Size(640, 480)
        Me.MinimumSize = New System.Drawing.Size(640, 480)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnavion As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnbarco As Button
    Friend WithEvents btnauto As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
