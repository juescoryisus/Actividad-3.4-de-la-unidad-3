<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.calcular = New System.Windows.Forms.Button()
        Me.txtprimero = New System.Windows.Forms.TextBox()
        Me.txtsegundo = New System.Windows.Forms.TextBox()
        Me.txttercero = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'calcular
        '
        Me.calcular.Location = New System.Drawing.Point(336, 339)
        Me.calcular.Name = "calcular"
        Me.calcular.Size = New System.Drawing.Size(112, 34)
        Me.calcular.TabIndex = 0
        Me.calcular.Text = "CALCULAR"
        Me.calcular.UseVisualStyleBackColor = True
        '
        'txtprimero
        '
        Me.txtprimero.Location = New System.Drawing.Point(319, 79)
        Me.txtprimero.Name = "txtprimero"
        Me.txtprimero.Size = New System.Drawing.Size(150, 31)
        Me.txtprimero.TabIndex = 1
        '
        'txtsegundo
        '
        Me.txtsegundo.Location = New System.Drawing.Point(319, 160)
        Me.txtsegundo.Name = "txtsegundo"
        Me.txtsegundo.Size = New System.Drawing.Size(150, 31)
        Me.txtsegundo.TabIndex = 2
        '
        'txttercero
        '
        Me.txttercero.Location = New System.Drawing.Point(319, 230)
        Me.txttercero.Name = "txttercero"
        Me.txttercero.Size = New System.Drawing.Size(150, 31)
        Me.txttercero.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txttercero)
        Me.Controls.Add(Me.txtsegundo)
        Me.Controls.Add(Me.txtprimero)
        Me.Controls.Add(Me.calcular)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents calcular As Button
    Friend WithEvents txtprimero As TextBox
    Friend WithEvents txtsegundo As TextBox
    Friend WithEvents txttercero As TextBox
End Class
