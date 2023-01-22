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
        Me.btnConsulta = New System.Windows.Forms.Button()
        Me.dgGrid = New System.Windows.Forms.DataGridView()
        Me.txtSQL = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConsulta
        '
        Me.btnConsulta.Location = New System.Drawing.Point(644, 66)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(88, 29)
        Me.btnConsulta.TabIndex = 9
        Me.btnConsulta.Text = "Executar"
        Me.btnConsulta.UseVisualStyleBackColor = True
        '
        'dgGrid
        '
        Me.dgGrid.AllowUserToAddRows = False
        Me.dgGrid.AllowUserToDeleteRows = False
        Me.dgGrid.AllowUserToOrderColumns = True
        Me.dgGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgGrid.Location = New System.Drawing.Point(88, 193)
        Me.dgGrid.Name = "dgGrid"
        Me.dgGrid.ReadOnly = True
        Me.dgGrid.RowHeadersWidth = 51
        Me.dgGrid.RowTemplate.Height = 29
        Me.dgGrid.Size = New System.Drawing.Size(550, 188)
        Me.dgGrid.TabIndex = 11
        '
        'txtSQL
        '
        Me.txtSQL.Location = New System.Drawing.Point(88, 35)
        Me.txtSQL.Name = "txtSQL"
        Me.txtSQL.Size = New System.Drawing.Size(550, 120)
        Me.txtSQL.TabIndex = 12
        Me.txtSQL.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Consulta"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 443)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSQL)
        Me.Controls.Add(Me.dgGrid)
        Me.Controls.Add(Me.btnConsulta)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConsulta As Button
    Friend WithEvents dgGrid As DataGridView
    Friend WithEvents txtSQL As RichTextBox
    Friend WithEvents Label1 As Label
End Class
