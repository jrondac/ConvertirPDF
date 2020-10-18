<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class unir_Dividir
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
        Me.BtnUnir = New System.Windows.Forms.Button()
        Me.btnDividir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbunir = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
        Me.btnCargar1 = New System.Windows.Forms.Button()
        Me.txtArchivo1 = New System.Windows.Forms.TextBox()
        Me.TxtArchivo2 = New System.Windows.Forms.TextBox()
        Me.btnCargar2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.gbunir.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnUnir
        '
        Me.BtnUnir.Location = New System.Drawing.Point(64, 163)
        Me.BtnUnir.Name = "BtnUnir"
        Me.BtnUnir.Size = New System.Drawing.Size(88, 26)
        Me.BtnUnir.TabIndex = 0
        Me.BtnUnir.Text = "Unir PDF"
        Me.BtnUnir.UseVisualStyleBackColor = True
        '
        'btnDividir
        '
        Me.btnDividir.Location = New System.Drawing.Point(79, 163)
        Me.btnDividir.Name = "btnDividir"
        Me.btnDividir.Size = New System.Drawing.Size(100, 26)
        Me.btnDividir.TabIndex = 1
        Me.btnDividir.Text = "Dividir PDF"
        Me.btnDividir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "UNIR / DIVIDIR PDF"
        '
        'gbunir
        '
        Me.gbunir.Controls.Add(Me.Label3)
        Me.gbunir.Controls.Add(Me.Label2)
        Me.gbunir.Controls.Add(Me.TxtArchivo2)
        Me.gbunir.Controls.Add(Me.btnCargar2)
        Me.gbunir.Controls.Add(Me.txtArchivo1)
        Me.gbunir.Controls.Add(Me.btnCargar1)
        Me.gbunir.Controls.Add(Me.BtnUnir)
        Me.gbunir.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbunir.Location = New System.Drawing.Point(12, 74)
        Me.gbunir.Name = "gbunir"
        Me.gbunir.Size = New System.Drawing.Size(263, 195)
        Me.gbunir.TabIndex = 3
        Me.gbunir.TabStop = False
        Me.gbunir.Text = "Unir"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Me.txtBuscar)
        Me.GroupBox2.Controls.Add(Me.btnDividir)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(290, 74)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(239, 195)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dividir"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(18, 47)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(204, 26)
        Me.txtBuscar.TabIndex = 2
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(18, 79)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 34)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'btnCargar1
        '
        Me.btnCargar1.Location = New System.Drawing.Point(179, 47)
        Me.btnCargar1.Name = "btnCargar1"
        Me.btnCargar1.Size = New System.Drawing.Size(75, 26)
        Me.btnCargar1.TabIndex = 2
        Me.btnCargar1.Text = "Cargar"
        Me.btnCargar1.UseVisualStyleBackColor = True
        '
        'txtArchivo1
        '
        Me.txtArchivo1.Location = New System.Drawing.Point(22, 47)
        Me.txtArchivo1.Name = "txtArchivo1"
        Me.txtArchivo1.Size = New System.Drawing.Size(149, 26)
        Me.txtArchivo1.TabIndex = 3
        '
        'TxtArchivo2
        '
        Me.TxtArchivo2.Location = New System.Drawing.Point(22, 111)
        Me.TxtArchivo2.Name = "TxtArchivo2"
        Me.TxtArchivo2.Size = New System.Drawing.Size(149, 26)
        Me.TxtArchivo2.TabIndex = 5
        '
        'btnCargar2
        '
        Me.btnCargar2.Location = New System.Drawing.Point(177, 111)
        Me.btnCargar2.Name = "btnCargar2"
        Me.btnCargar2.Size = New System.Drawing.Size(75, 27)
        Me.btnCargar2.TabIndex = 4
        Me.btnCargar2.Text = "Cargar"
        Me.btnCargar2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Archivo 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Archivo 2"
        '
        'unir_Dividir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 281)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbunir)
        Me.Controls.Add(Me.Label1)
        Me.Name = "unir_Dividir"
        Me.Text = "unir_Dividir"
        Me.gbunir.ResumeLayout(False)
        Me.gbunir.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnUnir As Button
    Friend WithEvents btnDividir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents gbunir As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents SaveFileDialog2 As SaveFileDialog
    Friend WithEvents btnCargar1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtArchivo2 As TextBox
    Friend WithEvents btnCargar2 As Button
    Friend WithEvents txtArchivo1 As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
