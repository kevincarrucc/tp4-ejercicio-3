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
        Me.Boton = New System.Windows.Forms.Button()
        Me.GrillaMatrizDiagonales = New System.Windows.Forms.DataGridView()
        Me.GrillaMatrizEntera = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.GrillaMatrizDiagonales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrillaMatrizEntera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Boton
        '
        Me.Boton.Location = New System.Drawing.Point(50, 361)
        Me.Boton.Name = "Boton"
        Me.Boton.Size = New System.Drawing.Size(75, 23)
        Me.Boton.TabIndex = 0
        Me.Boton.Text = "Ejecutar"
        Me.Boton.UseVisualStyleBackColor = True
        '
        'GrillaMatrizDiagonales
        '
        Me.GrillaMatrizDiagonales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaMatrizDiagonales.ColumnHeadersVisible = False
        Me.GrillaMatrizDiagonales.Location = New System.Drawing.Point(444, 12)
        Me.GrillaMatrizDiagonales.Name = "GrillaMatrizDiagonales"
        Me.GrillaMatrizDiagonales.RowHeadersVisible = False
        Me.GrillaMatrizDiagonales.Size = New System.Drawing.Size(344, 194)
        Me.GrillaMatrizDiagonales.TabIndex = 3
        '
        'GrillaMatrizEntera
        '
        Me.GrillaMatrizEntera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaMatrizEntera.ColumnHeadersVisible = False
        Me.GrillaMatrizEntera.Location = New System.Drawing.Point(12, 12)
        Me.GrillaMatrizEntera.Name = "GrillaMatrizEntera"
        Me.GrillaMatrizEntera.RowHeadersVisible = False
        Me.GrillaMatrizEntera.Size = New System.Drawing.Size(345, 194)
        Me.GrillaMatrizEntera.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Grilla Matriz"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(8, 428)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(161, 13)
        Me.lblCount.TabIndex = 6
        Me.lblCount.Text = "Cantidad de numeros ingresados"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(441, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Grilla diagonales"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrillaMatrizEntera)
        Me.Controls.Add(Me.GrillaMatrizDiagonales)
        Me.Controls.Add(Me.Boton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GrillaMatrizDiagonales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrillaMatrizEntera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Boton As Button
    Friend WithEvents GrillaMatrizDiagonales As DataGridView
    Friend WithEvents GrillaMatrizEntera As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCount As Label
    Friend WithEvents Label3 As Label
End Class
