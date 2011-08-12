<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTermMatch
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
        Me.components = New System.ComponentModel.Container
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.TERMSCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.APRTABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAccpac = New AccpacGuardianTool.dsAccpac
        Me.TermsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TermsMatchingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsGuardian = New AccpacGuardianTool.dsGuardian
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APRTABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAccpac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TermsMatchingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsGuardian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TERMSCODEDataGridViewTextBoxColumn, Me.TermsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TermsMatchingBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(498, 305)
        Me.DataGridView1.TabIndex = 0
        '
        'TERMSCODEDataGridViewTextBoxColumn
        '
        Me.TERMSCODEDataGridViewTextBoxColumn.DataPropertyName = "TERMSCODE"
        Me.TERMSCODEDataGridViewTextBoxColumn.DataSource = Me.APRTABindingSource
        Me.TERMSCODEDataGridViewTextBoxColumn.DisplayMember = "TERMSCODE"
        Me.TERMSCODEDataGridViewTextBoxColumn.HeaderText = "Accpac Term Code"
        Me.TERMSCODEDataGridViewTextBoxColumn.Name = "TERMSCODEDataGridViewTextBoxColumn"
        Me.TERMSCODEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TERMSCODEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.TERMSCODEDataGridViewTextBoxColumn.ValueMember = "TERMSCODE"
        '
        'APRTABindingSource
        '
        Me.APRTABindingSource.DataMember = "APRTA"
        Me.APRTABindingSource.DataSource = Me.DsAccpac
        '
        'DsAccpac
        '
        Me.DsAccpac.DataSetName = "dsAccpac"
        Me.DsAccpac.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TermsDataGridViewTextBoxColumn
        '
        Me.TermsDataGridViewTextBoxColumn.DataPropertyName = "Terms"
        Me.TermsDataGridViewTextBoxColumn.HeaderText = "Guardian Term Codes"
        Me.TermsDataGridViewTextBoxColumn.Name = "TermsDataGridViewTextBoxColumn"
        '
        'TermsMatchingBindingSource
        '
        Me.TermsMatchingBindingSource.DataMember = "TermsMatching"
        Me.TermsMatchingBindingSource.DataSource = Me.DsGuardian
        '
        'DsGuardian
        '
        Me.DsGuardian.DataSetName = "dsGuardian"
        Me.DsGuardian.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 251)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(498, 54)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(411, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmTermMatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 305)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmTermMatch"
        Me.Text = "frmTermMatch"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APRTABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAccpac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TermsMatchingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsGuardian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TermsMatchingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsGuardian As AccpacGuardianTool.dsGuardian
    Friend WithEvents DsAccpac As AccpacGuardianTool.dsAccpac
    Friend WithEvents APRTABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TERMSCODEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents TermsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
