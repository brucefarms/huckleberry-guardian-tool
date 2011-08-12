<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendorExport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtIDGRPFrom = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtIDGRPTo = New System.Windows.Forms.TextBox
        Me.btnExport = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtIDGRPFrom
        '
        Me.txtIDGRPFrom.Location = New System.Drawing.Point(15, 25)
        Me.txtIDGRPFrom.Name = "txtIDGRPFrom"
        Me.txtIDGRPFrom.Size = New System.Drawing.Size(100, 20)
        Me.txtIDGRPFrom.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "From Group:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To Group:"
        '
        'txtIDGRPTo
        '
        Me.txtIDGRPTo.Location = New System.Drawing.Point(121, 25)
        Me.txtIDGRPTo.Name = "txtIDGRPTo"
        Me.txtIDGRPTo.Size = New System.Drawing.Size(100, 20)
        Me.txtIDGRPTo.TabIndex = 2
        Me.txtIDGRPTo.Text = "ZZZZZZZ"
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(146, 51)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 4
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'frmVendorExport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 80)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIDGRPTo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIDGRPFrom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVendorExport"
        Me.Text = "frmVendorExport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIDGRPFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIDGRPTo As System.Windows.Forms.TextBox
    Friend WithEvents btnExport As System.Windows.Forms.Button
End Class
