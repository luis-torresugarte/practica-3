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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.materia1 = New System.Windows.Forms.TextBox()
        Me.materia2 = New System.Windows.Forms.TextBox()
        Me.materia3 = New System.Windows.Forms.TextBox()
        Me.materia4 = New System.Windows.Forms.TextBox()
        Me.materia5 = New System.Windows.Forms.TextBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Resultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Soc. y cultura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Matematicas IV"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Med. y tec."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ingles"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Or. vocacional"
        '
        'materia1
        '
        Me.materia1.Location = New System.Drawing.Point(138, 80)
        Me.materia1.Name = "materia1"
        Me.materia1.Size = New System.Drawing.Size(189, 20)
        Me.materia1.TabIndex = 5
        '
        'materia2
        '
        Me.materia2.Location = New System.Drawing.Point(138, 126)
        Me.materia2.Name = "materia2"
        Me.materia2.Size = New System.Drawing.Size(189, 20)
        Me.materia2.TabIndex = 6
        '
        'materia3
        '
        Me.materia3.Location = New System.Drawing.Point(138, 175)
        Me.materia3.Name = "materia3"
        Me.materia3.Size = New System.Drawing.Size(189, 20)
        Me.materia3.TabIndex = 7
        '
        'materia4
        '
        Me.materia4.Location = New System.Drawing.Point(138, 223)
        Me.materia4.Name = "materia4"
        Me.materia4.Size = New System.Drawing.Size(189, 20)
        Me.materia4.TabIndex = 8
        '
        'materia5
        '
        Me.materia5.Location = New System.Drawing.Point(138, 271)
        Me.materia5.Name = "materia5"
        Me.materia5.Size = New System.Drawing.Size(189, 20)
        Me.materia5.TabIndex = 9
        '
        'Calcular
        '
        Me.Calcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calcular.Location = New System.Drawing.Point(562, 196)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(129, 73)
        Me.Calcular.TabIndex = 10
        Me.Calcular.Text = "Calcular promedio"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(513, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Promedio:"
        '
        'Resultado
        '
        Me.Resultado.AutoSize = True
        Me.Resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resultado.Location = New System.Drawing.Point(661, 83)
        Me.Resultado.Name = "Resultado"
        Me.Resultado.Size = New System.Drawing.Size(30, 31)
        Me.Resultado.TabIndex = 12
        Me.Resultado.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Resultado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.materia5)
        Me.Controls.Add(Me.materia4)
        Me.Controls.Add(Me.materia3)
        Me.Controls.Add(Me.materia2)
        Me.Controls.Add(Me.materia1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents materia1 As TextBox
    Friend WithEvents materia2 As TextBox
    Friend WithEvents materia3 As TextBox
    Friend WithEvents materia4 As TextBox
    Friend WithEvents materia5 As TextBox
    Friend WithEvents Calcular As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Resultado As Label
End Class
