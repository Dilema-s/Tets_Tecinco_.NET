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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombreApellido = New System.Windows.Forms.TextBox()
        Me.fechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbMasculino = New System.Windows.Forms.RadioButton()
        Me.rbFemenino = New System.Windows.Forms.RadioButton()
        Me.edad = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_altaPersona = New System.Windows.Forms.Button()
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ABMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ALTAPERSONAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BAJAPERSONAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MODIFICARPERSONAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LISTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.edad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(135, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre y apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha Nacimiento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(137, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Edad"
        '
        'txtNombreApellido
        '
        Me.txtNombreApellido.Location = New System.Drawing.Point(255, 121)
        Me.txtNombreApellido.Name = "txtNombreApellido"
        Me.txtNombreApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreApellido.TabIndex = 4
        '
        'fechaNacimiento
        '
        Me.fechaNacimiento.Location = New System.Drawing.Point(255, 161)
        Me.fechaNacimiento.Name = "fechaNacimiento"
        Me.fechaNacimiento.Size = New System.Drawing.Size(200, 20)
        Me.fechaNacimiento.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbMasculino)
        Me.GroupBox1.Controls.Add(Me.rbFemenino)
        Me.GroupBox1.Location = New System.Drawing.Point(138, 236)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 45)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sexo"
        '
        'rbMasculino
        '
        Me.rbMasculino.AutoSize = True
        Me.rbMasculino.Location = New System.Drawing.Point(160, 19)
        Me.rbMasculino.Name = "rbMasculino"
        Me.rbMasculino.Size = New System.Drawing.Size(88, 17)
        Me.rbMasculino.TabIndex = 1
        Me.rbMasculino.TabStop = True
        Me.rbMasculino.Text = "MASCULINO"
        Me.rbMasculino.UseVisualStyleBackColor = True
        '
        'rbFemenino
        '
        Me.rbFemenino.AutoSize = True
        Me.rbFemenino.Location = New System.Drawing.Point(25, 19)
        Me.rbFemenino.Name = "rbFemenino"
        Me.rbFemenino.Size = New System.Drawing.Size(81, 17)
        Me.rbFemenino.TabIndex = 0
        Me.rbFemenino.TabStop = True
        Me.rbFemenino.Text = "FEMENINO"
        Me.rbFemenino.UseVisualStyleBackColor = True
        '
        'edad
        '
        Me.edad.Location = New System.Drawing.Point(255, 199)
        Me.edad.Name = "edad"
        Me.edad.Size = New System.Drawing.Size(120, 20)
        Me.edad.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(451, 330)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "SALIR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_altaPersona
        '
        Me.btn_altaPersona.Location = New System.Drawing.Point(326, 330)
        Me.btn_altaPersona.Name = "btn_altaPersona"
        Me.btn_altaPersona.Size = New System.Drawing.Size(75, 23)
        Me.btn_altaPersona.TabIndex = 9
        Me.btn_altaPersona.Text = "ACEPTAR"
        Me.btn_altaPersona.UseVisualStyleBackColor = True
        '
        'lbTitulo
        '
        Me.lbTitulo.AutoSize = True
        Me.lbTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.Location = New System.Drawing.Point(188, 47)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(167, 24)
        Me.lbTitulo.TabIndex = 10
        Me.lbTitulo.Text = "ALTA PERSONA"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMLToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(582, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ABMLToolStripMenuItem
        '
        Me.ABMLToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ALTAPERSONAToolStripMenuItem, Me.BAJAPERSONAToolStripMenuItem, Me.MODIFICARPERSONAToolStripMenuItem, Me.LISTAToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.ABMLToolStripMenuItem.Name = "ABMLToolStripMenuItem"
        Me.ABMLToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.ABMLToolStripMenuItem.Text = "ABML"
        '
        'ALTAPERSONAToolStripMenuItem
        '
        Me.ALTAPERSONAToolStripMenuItem.Name = "ALTAPERSONAToolStripMenuItem"
        Me.ALTAPERSONAToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ALTAPERSONAToolStripMenuItem.Text = "ALTA PERSONA"
        '
        'BAJAPERSONAToolStripMenuItem
        '
        Me.BAJAPERSONAToolStripMenuItem.Name = "BAJAPERSONAToolStripMenuItem"
        Me.BAJAPERSONAToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.BAJAPERSONAToolStripMenuItem.Text = "BAJA PERSONA"
        '
        'MODIFICARPERSONAToolStripMenuItem
        '
        Me.MODIFICARPERSONAToolStripMenuItem.Name = "MODIFICARPERSONAToolStripMenuItem"
        Me.MODIFICARPERSONAToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.MODIFICARPERSONAToolStripMenuItem.Text = "MODIFICAR PERSONA"
        '
        'LISTAToolStripMenuItem
        '
        Me.LISTAToolStripMenuItem.Name = "LISTAToolStripMenuItem"
        Me.LISTAToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.LISTAToolStripMenuItem.Text = "LISTA"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(245, 330)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 13
        Me.btnModificar.Text = "ACEPTAR"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 386)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.lbTitulo)
        Me.Controls.Add(Me.btn_altaPersona)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.edad)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.fechaNacimiento)
        Me.Controls.Add(Me.txtNombreApellido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ALTA PERSONA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.edad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombreApellido As TextBox
    Friend WithEvents fechaNacimiento As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbMasculino As RadioButton
    Friend WithEvents rbFemenino As RadioButton
    Friend WithEvents edad As NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_altaPersona As Button
    Friend WithEvents lbTitulo As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ABMLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ALTAPERSONAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BAJAPERSONAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MODIFICARPERSONAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LISTAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnModificar As Button
End Class
