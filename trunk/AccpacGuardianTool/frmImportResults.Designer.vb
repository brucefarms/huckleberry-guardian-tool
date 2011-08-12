<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportResults
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgvImportRes = New System.Windows.Forms.DataGridView
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UpdatedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InsertedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProcessedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VIEWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAccpac = New AccpacGuardianTool.dsAccpac
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.IndexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PPriorityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PMsgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PErrCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PHelpFileDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PHelpIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SessionErrorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAccpac1 = New AccpacGuardianTool.dsAccpac
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvImportRes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VIEWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAccpac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SessionErrorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAccpac1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvImportRes)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(915, 193)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Import Message"
        '
        'dgvImportRes
        '
        Me.dgvImportRes.AllowUserToAddRows = False
        Me.dgvImportRes.AllowUserToDeleteRows = False
        Me.dgvImportRes.AutoGenerateColumns = False
        Me.dgvImportRes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvImportRes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvImportRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvImportRes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.UpdatedDataGridViewTextBoxColumn, Me.InsertedDataGridViewTextBoxColumn, Me.ProcessedDataGridViewTextBoxColumn})
        Me.dgvImportRes.DataSource = Me.VIEWBindingSource
        Me.dgvImportRes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvImportRes.Location = New System.Drawing.Point(3, 16)
        Me.dgvImportRes.Name = "dgvImportRes"
        Me.dgvImportRes.ReadOnly = True
        Me.dgvImportRes.Size = New System.Drawing.Size(909, 174)
        Me.dgvImportRes.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UpdatedDataGridViewTextBoxColumn
        '
        Me.UpdatedDataGridViewTextBoxColumn.DataPropertyName = "Updated"
        Me.UpdatedDataGridViewTextBoxColumn.HeaderText = "Updated"
        Me.UpdatedDataGridViewTextBoxColumn.Name = "UpdatedDataGridViewTextBoxColumn"
        Me.UpdatedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InsertedDataGridViewTextBoxColumn
        '
        Me.InsertedDataGridViewTextBoxColumn.DataPropertyName = "Inserted"
        Me.InsertedDataGridViewTextBoxColumn.HeaderText = "Inserted"
        Me.InsertedDataGridViewTextBoxColumn.Name = "InsertedDataGridViewTextBoxColumn"
        Me.InsertedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProcessedDataGridViewTextBoxColumn
        '
        Me.ProcessedDataGridViewTextBoxColumn.DataPropertyName = "Processed"
        Me.ProcessedDataGridViewTextBoxColumn.HeaderText = "Processed"
        Me.ProcessedDataGridViewTextBoxColumn.Name = "ProcessedDataGridViewTextBoxColumn"
        Me.ProcessedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VIEWBindingSource
        '
        Me.VIEWBindingSource.DataMember = "VIEW"
        Me.VIEWBindingSource.DataSource = Me.DsAccpac
        '
        'DsAccpac
        '
        Me.DsAccpac.DataSetName = "dsAccpac"
        Me.DsAccpac.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 193)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(915, 359)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Accpac Errors"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IndexDataGridViewTextBoxColumn, Me.PPriorityDataGridViewTextBoxColumn, Me.PMsgDataGridViewTextBoxColumn, Me.PSourceDataGridViewTextBoxColumn, Me.PErrCodeDataGridViewTextBoxColumn, Me.PHelpFileDataGridViewTextBoxColumn, Me.PHelpIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SessionErrorBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(909, 340)
        Me.DataGridView1.TabIndex = 0
        '
        'IndexDataGridViewTextBoxColumn
        '
        Me.IndexDataGridViewTextBoxColumn.DataPropertyName = "index"
        Me.IndexDataGridViewTextBoxColumn.HeaderText = "index"
        Me.IndexDataGridViewTextBoxColumn.Name = "IndexDataGridViewTextBoxColumn"
        Me.IndexDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PPriorityDataGridViewTextBoxColumn
        '
        Me.PPriorityDataGridViewTextBoxColumn.DataPropertyName = "pPriority"
        Me.PPriorityDataGridViewTextBoxColumn.HeaderText = "pPriority"
        Me.PPriorityDataGridViewTextBoxColumn.Name = "PPriorityDataGridViewTextBoxColumn"
        Me.PPriorityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PMsgDataGridViewTextBoxColumn
        '
        Me.PMsgDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PMsgDataGridViewTextBoxColumn.DataPropertyName = "pMsg"
        Me.PMsgDataGridViewTextBoxColumn.HeaderText = "pMsg"
        Me.PMsgDataGridViewTextBoxColumn.Name = "PMsgDataGridViewTextBoxColumn"
        Me.PMsgDataGridViewTextBoxColumn.ReadOnly = True
        Me.PMsgDataGridViewTextBoxColumn.Width = 58
        '
        'PSourceDataGridViewTextBoxColumn
        '
        Me.PSourceDataGridViewTextBoxColumn.DataPropertyName = "pSource"
        Me.PSourceDataGridViewTextBoxColumn.HeaderText = "pSource"
        Me.PSourceDataGridViewTextBoxColumn.Name = "PSourceDataGridViewTextBoxColumn"
        Me.PSourceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PErrCodeDataGridViewTextBoxColumn
        '
        Me.PErrCodeDataGridViewTextBoxColumn.DataPropertyName = "pErrCode"
        Me.PErrCodeDataGridViewTextBoxColumn.HeaderText = "pErrCode"
        Me.PErrCodeDataGridViewTextBoxColumn.Name = "PErrCodeDataGridViewTextBoxColumn"
        Me.PErrCodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PHelpFileDataGridViewTextBoxColumn
        '
        Me.PHelpFileDataGridViewTextBoxColumn.DataPropertyName = "pHelpFile"
        Me.PHelpFileDataGridViewTextBoxColumn.HeaderText = "pHelpFile"
        Me.PHelpFileDataGridViewTextBoxColumn.Name = "PHelpFileDataGridViewTextBoxColumn"
        Me.PHelpFileDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PHelpIDDataGridViewTextBoxColumn
        '
        Me.PHelpIDDataGridViewTextBoxColumn.DataPropertyName = "pHelpID"
        Me.PHelpIDDataGridViewTextBoxColumn.HeaderText = "pHelpID"
        Me.PHelpIDDataGridViewTextBoxColumn.Name = "PHelpIDDataGridViewTextBoxColumn"
        Me.PHelpIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SessionErrorBindingSource
        '
        Me.SessionErrorBindingSource.DataMember = "SessionError"
        Me.SessionErrorBindingSource.DataSource = Me.DsAccpac1
        '
        'DsAccpac1
        '
        Me.DsAccpac1.DataSetName = "dsAccpac"
        Me.DsAccpac1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmImportResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 552)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmImportResults"
        Me.Text = "Import Results"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvImportRes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VIEWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAccpac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SessionErrorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAccpac1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents dgvImportRes As System.Windows.Forms.DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UpdatedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InsertedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProcessedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VIEWBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsAccpac As AccpacGuardianTool.dsAccpac
    Friend WithEvents SessionErrorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsAccpac1 As AccpacGuardianTool.dsAccpac
    Friend WithEvents IndexDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PPriorityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PMsgDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSourceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PErrCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PHelpFileDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PHelpIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
