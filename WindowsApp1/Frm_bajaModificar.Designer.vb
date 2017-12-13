<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_bajaModificar
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
        Me.dgvPersona = New System.Windows.Forms.DataGridView()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.col_idPersona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fechaNacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPersona
        '
        Me.dgvPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPersona.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_idPersona, Me.col_nombre, Me.col_fechaNacimiento, Me.col_edad, Me.col_sexo})
        Me.dgvPersona.Location = New System.Drawing.Point(73, 73)
        Me.dgvPersona.Name = "dgvPersona"
        Me.dgvPersona.Size = New System.Drawing.Size(642, 277)
        Me.dgvPersona.TabIndex = 0
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(415, 376)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(133, 23)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "BAJA PERSONA"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(190, 376)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(133, 23)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "MODIFICAR PERSONA"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(688, 415)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(246, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "BAJA/ MODIFICAR Persona"
        '
        'col_idPersona
        '
        Me.col_idPersona.DataPropertyName = "id_persona"
        Me.col_idPersona.HeaderText = "Id_persona"
        Me.col_idPersona.Name = "col_idPersona"
        '
        'col_nombre
        '
        Me.col_nombre.DataPropertyName = "nombreApellido"
        Me.col_nombre.HeaderText = "Nombre y apellido"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.Width = 200
        '
        'col_fechaNacimiento
        '
        Me.col_fechaNacimiento.DataPropertyName = "fechaNacimiento"
        Me.col_fechaNacimiento.HeaderText = "Fecha Nacimiento"
        Me.col_fechaNacimiento.Name = "col_fechaNacimiento"
        '
        'col_edad
        '
        Me.col_edad.DataPropertyName = "edad"
        Me.col_edad.HeaderText = "Edad"
        Me.col_edad.Name = "col_edad"
        '
        'col_sexo
        '
        Me.col_sexo.DataPropertyName = "sexo"
        Me.col_sexo.HeaderText = "Sexo"
        Me.col_sexo.Name = "col_sexo"
        '
        'Frm_bajaModificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dgvPersona)
        Me.Name = "Frm_bajaModificar"
        Me.Text = "Frm_bajaModificar"
        CType(Me.dgvPersona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvPersona As DataGridView
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents col_idPersona As DataGridViewTextBoxColumn
    Friend WithEvents col_nombre As DataGridViewTextBoxColumn
    Friend WithEvents col_fechaNacimiento As DataGridViewTextBoxColumn
    Friend WithEvents col_edad As DataGridViewTextBoxColumn
    Friend WithEvents col_sexo As DataGridViewTextBoxColumn
End Class
