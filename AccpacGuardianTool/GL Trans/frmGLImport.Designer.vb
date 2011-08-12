<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGLImport
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtBTCHDESC = New System.Windows.Forms.TextBox
        Me.btnFdrCNTBTCH = New System.Windows.Forms.Button
        Me.txtCNTBTCH = New System.Windows.Forms.TextBox
        Me.rbExistingBatch = New System.Windows.Forms.RadioButton
        Me.rbNewBatch = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnImport = New System.Windows.Forms.Button
        Me.btnLoad = New System.Windows.Forms.Button
        Me.btnBrowseFile2 = New System.Windows.Forms.Button
        Me.btnBrowseFile1 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtFile2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtFile1 = New System.Windows.Forms.TextBox
        Me.cbAction = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dgvAccpacErrors = New System.Windows.Forms.DataGridView
        Me.IndexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PPriorityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PMsgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PSourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PErrCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PHelpFileDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PHelpIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SessionErrorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAccpac1 = New AccpacGuardianTool.dsAccpac
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.dgvImportRes = New System.Windows.Forms.DataGridView
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UpdatedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InsertedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProcessedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VIEWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAccpac = New AccpacGuardianTool.dsAccpac
        Me.BatchNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.JournalNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AccountNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PostDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.JournalDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.JournalSourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CurrTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CurrRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TransactionDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SEG1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SEG2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SEG3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SEG4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SEG5DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SEG6DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SEG7DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SEG8DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SEG9DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SEG10DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GuardianSourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SupplierNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SupplierNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PONumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InvoiceNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InvoiceDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PaymentDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CatalogCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CatalogShortDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PartDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SupPartNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TaxCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReceiptDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InvoiceRefNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IsReversalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReceiptJournalNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GlTransExportBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsGuardian = New AccpacGuardianTool.dsGuardian
        Me.GlTransExportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtpPostingDate = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvAccpacErrors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SessionErrorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAccpac1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvImportRes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VIEWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAccpac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GlTransExportBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsGuardian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GlTransExportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.dtpPostingDate)
        Me.GroupBox2.Controls.Add(Me.txtBTCHDESC)
        Me.GroupBox2.Controls.Add(Me.btnFdrCNTBTCH)
        Me.GroupBox2.Controls.Add(Me.txtCNTBTCH)
        Me.GroupBox2.Controls.Add(Me.rbExistingBatch)
        Me.GroupBox2.Controls.Add(Me.rbNewBatch)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1133, 83)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Accpac Batch"
        '
        'txtBTCHDESC
        '
        Me.txtBTCHDESC.Location = New System.Drawing.Point(110, 18)
        Me.txtBTCHDESC.Name = "txtBTCHDESC"
        Me.txtBTCHDESC.Size = New System.Drawing.Size(324, 20)
        Me.txtBTCHDESC.TabIndex = 12
        '
        'btnFdrCNTBTCH
        '
        Me.btnFdrCNTBTCH.Location = New System.Drawing.Point(216, 44)
        Me.btnFdrCNTBTCH.Name = "btnFdrCNTBTCH"
        Me.btnFdrCNTBTCH.Size = New System.Drawing.Size(27, 20)
        Me.btnFdrCNTBTCH.TabIndex = 11
        Me.btnFdrCNTBTCH.Text = "..."
        Me.btnFdrCNTBTCH.UseVisualStyleBackColor = True
        '
        'txtCNTBTCH
        '
        Me.txtCNTBTCH.Location = New System.Drawing.Point(110, 44)
        Me.txtCNTBTCH.Name = "txtCNTBTCH"
        Me.txtCNTBTCH.Size = New System.Drawing.Size(100, 20)
        Me.txtCNTBTCH.TabIndex = 10
        '
        'rbExistingBatch
        '
        Me.rbExistingBatch.AutoSize = True
        Me.rbExistingBatch.Location = New System.Drawing.Point(12, 47)
        Me.rbExistingBatch.Name = "rbExistingBatch"
        Me.rbExistingBatch.Size = New System.Drawing.Size(92, 17)
        Me.rbExistingBatch.TabIndex = 9
        Me.rbExistingBatch.Text = "Existing Batch"
        Me.rbExistingBatch.UseVisualStyleBackColor = True
        '
        'rbNewBatch
        '
        Me.rbNewBatch.AutoSize = True
        Me.rbNewBatch.Checked = True
        Me.rbNewBatch.Location = New System.Drawing.Point(12, 19)
        Me.rbNewBatch.Name = "rbNewBatch"
        Me.rbNewBatch.Size = New System.Drawing.Size(78, 17)
        Me.rbNewBatch.TabIndex = 8
        Me.rbNewBatch.TabStop = True
        Me.rbNewBatch.Text = "New Batch"
        Me.rbNewBatch.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnImport)
        Me.GroupBox1.Controls.Add(Me.btnLoad)
        Me.GroupBox1.Controls.Add(Me.btnBrowseFile2)
        Me.GroupBox1.Controls.Add(Me.btnBrowseFile1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtFile2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtFile1)
        Me.GroupBox1.Controls.Add(Me.cbAction)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1133, 110)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "File Info"
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(673, 46)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(83, 45)
        Me.btnImport.TabIndex = 10
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Enabled = False
        Me.btnLoad.Location = New System.Drawing.Point(584, 46)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(83, 45)
        Me.btnLoad.TabIndex = 9
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnBrowseFile2
        '
        Me.btnBrowseFile2.Enabled = False
        Me.btnBrowseFile2.Location = New System.Drawing.Point(503, 72)
        Me.btnBrowseFile2.Name = "btnBrowseFile2"
        Me.btnBrowseFile2.Size = New System.Drawing.Size(75, 20)
        Me.btnBrowseFile2.TabIndex = 8
        Me.btnBrowseFile2.Text = "Browse"
        Me.btnBrowseFile2.UseVisualStyleBackColor = True
        '
        'btnBrowseFile1
        '
        Me.btnBrowseFile1.Location = New System.Drawing.Point(503, 46)
        Me.btnBrowseFile1.Name = "btnBrowseFile1"
        Me.btnBrowseFile1.Size = New System.Drawing.Size(75, 20)
        Me.btnBrowseFile1.TabIndex = 7
        Me.btnBrowseFile1.Text = "Browse"
        Me.btnBrowseFile1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(12, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "File 2:"
        '
        'txtFile2
        '
        Me.txtFile2.Enabled = False
        Me.txtFile2.Location = New System.Drawing.Point(81, 72)
        Me.txtFile2.Name = "txtFile2"
        Me.txtFile2.Size = New System.Drawing.Size(416, 20)
        Me.txtFile2.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "File 1:"
        '
        'txtFile1
        '
        Me.txtFile1.Location = New System.Drawing.Point(81, 46)
        Me.txtFile1.Name = "txtFile1"
        Me.txtFile1.Size = New System.Drawing.Size(416, 20)
        Me.txtFile1.TabIndex = 3
        '
        'cbAction
        '
        Me.cbAction.Enabled = False
        Me.cbAction.FormattingEnabled = True
        Me.cbAction.Items.AddRange(New Object() {"Import", "Export"})
        Me.cbAction.Location = New System.Drawing.Point(81, 19)
        Me.cbAction.Name = "cbAction"
        Me.cbAction.Size = New System.Drawing.Size(205, 21)
        Me.cbAction.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Import Type"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BatchNumberDataGridViewTextBoxColumn, Me.JournalNumberDataGridViewTextBoxColumn, Me.AccountNumberDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.PostDateDataGridViewTextBoxColumn, Me.JournalDescriptionDataGridViewTextBoxColumn, Me.JournalSourceDataGridViewTextBoxColumn, Me.CurrTypeDataGridViewTextBoxColumn, Me.CurrRateDataGridViewTextBoxColumn, Me.TransactionDateDataGridViewTextBoxColumn, Me.SEG1DataGridViewTextBoxColumn, Me.SEG2DataGridViewTextBoxColumn, Me.SEG3DataGridViewTextBoxColumn, Me.SEG4DataGridViewTextBoxColumn, Me.SEG5DataGridViewTextBoxColumn, Me.SEG6DataGridViewTextBoxColumn, Me.SEG7DataGridViewTextBoxColumn, Me.SEG8DataGridViewTextBoxColumn, Me.SEG9DataGridViewTextBoxColumn, Me.SEG10DataGridViewTextBoxColumn, Me.GuardianSourceDataGridViewTextBoxColumn, Me.SupplierNumDataGridViewTextBoxColumn, Me.SupplierNameDataGridViewTextBoxColumn, Me.PONumDataGridViewTextBoxColumn, Me.InvoiceNumDataGridViewTextBoxColumn, Me.InvoiceDateDataGridViewTextBoxColumn, Me.PaymentDateDataGridViewTextBoxColumn, Me.CatalogCodeDataGridViewTextBoxColumn, Me.CatalogShortDescDataGridViewTextBoxColumn, Me.PartDescDataGridViewTextBoxColumn, Me.SupPartNumDataGridViewTextBoxColumn, Me.TaxCodeDataGridViewTextBoxColumn, Me.ReceiptDateDataGridViewTextBoxColumn, Me.InvoiceRefNoDataGridViewTextBoxColumn, Me.DestDataGridViewTextBoxColumn, Me.IsReversalDataGridViewTextBoxColumn, Me.ReceiptJournalNumberDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GlTransExportBindingSource1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1119, 372)
        Me.DataGridView1.TabIndex = 5
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 193)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1133, 404)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1125, 378)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Preview"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1125, 378)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Results"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvAccpacErrors)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 196)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1119, 179)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Accpac Errors"
        '
        'dgvAccpacErrors
        '
        Me.dgvAccpacErrors.AllowUserToAddRows = False
        Me.dgvAccpacErrors.AllowUserToDeleteRows = False
        Me.dgvAccpacErrors.AutoGenerateColumns = False
        Me.dgvAccpacErrors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAccpacErrors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvAccpacErrors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccpacErrors.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IndexDataGridViewTextBoxColumn, Me.PPriorityDataGridViewTextBoxColumn, Me.PMsgDataGridViewTextBoxColumn, Me.PSourceDataGridViewTextBoxColumn, Me.PErrCodeDataGridViewTextBoxColumn, Me.PHelpFileDataGridViewTextBoxColumn, Me.PHelpIDDataGridViewTextBoxColumn})
        Me.dgvAccpacErrors.DataSource = Me.SessionErrorBindingSource
        Me.dgvAccpacErrors.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAccpacErrors.Location = New System.Drawing.Point(3, 16)
        Me.dgvAccpacErrors.Name = "dgvAccpacErrors"
        Me.dgvAccpacErrors.ReadOnly = True
        Me.dgvAccpacErrors.Size = New System.Drawing.Size(1113, 160)
        Me.dgvAccpacErrors.TabIndex = 0
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvImportRes)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1119, 193)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Import Message"
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
        Me.dgvImportRes.Size = New System.Drawing.Size(1113, 174)
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
        'BatchNumberDataGridViewTextBoxColumn
        '
        Me.BatchNumberDataGridViewTextBoxColumn.DataPropertyName = "Batch_Number"
        Me.BatchNumberDataGridViewTextBoxColumn.HeaderText = "Batch_Number"
        Me.BatchNumberDataGridViewTextBoxColumn.Name = "BatchNumberDataGridViewTextBoxColumn"
        '
        'JournalNumberDataGridViewTextBoxColumn
        '
        Me.JournalNumberDataGridViewTextBoxColumn.DataPropertyName = "Journal_Number"
        Me.JournalNumberDataGridViewTextBoxColumn.HeaderText = "Journal_Number"
        Me.JournalNumberDataGridViewTextBoxColumn.Name = "JournalNumberDataGridViewTextBoxColumn"
        '
        'AccountNumberDataGridViewTextBoxColumn
        '
        Me.AccountNumberDataGridViewTextBoxColumn.DataPropertyName = "Account_Number"
        Me.AccountNumberDataGridViewTextBoxColumn.HeaderText = "Account_Number"
        Me.AccountNumberDataGridViewTextBoxColumn.Name = "AccountNumberDataGridViewTextBoxColumn"
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        '
        'PostDateDataGridViewTextBoxColumn
        '
        Me.PostDateDataGridViewTextBoxColumn.DataPropertyName = "PostDate"
        Me.PostDateDataGridViewTextBoxColumn.HeaderText = "PostDate"
        Me.PostDateDataGridViewTextBoxColumn.Name = "PostDateDataGridViewTextBoxColumn"
        '
        'JournalDescriptionDataGridViewTextBoxColumn
        '
        Me.JournalDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Journal_Description"
        Me.JournalDescriptionDataGridViewTextBoxColumn.HeaderText = "Journal_Description"
        Me.JournalDescriptionDataGridViewTextBoxColumn.Name = "JournalDescriptionDataGridViewTextBoxColumn"
        '
        'JournalSourceDataGridViewTextBoxColumn
        '
        Me.JournalSourceDataGridViewTextBoxColumn.DataPropertyName = "Journal_Source"
        Me.JournalSourceDataGridViewTextBoxColumn.HeaderText = "Journal_Source"
        Me.JournalSourceDataGridViewTextBoxColumn.Name = "JournalSourceDataGridViewTextBoxColumn"
        '
        'CurrTypeDataGridViewTextBoxColumn
        '
        Me.CurrTypeDataGridViewTextBoxColumn.DataPropertyName = "CurrType"
        Me.CurrTypeDataGridViewTextBoxColumn.HeaderText = "CurrType"
        Me.CurrTypeDataGridViewTextBoxColumn.Name = "CurrTypeDataGridViewTextBoxColumn"
        '
        'CurrRateDataGridViewTextBoxColumn
        '
        Me.CurrRateDataGridViewTextBoxColumn.DataPropertyName = "CurrRate"
        Me.CurrRateDataGridViewTextBoxColumn.HeaderText = "CurrRate"
        Me.CurrRateDataGridViewTextBoxColumn.Name = "CurrRateDataGridViewTextBoxColumn"
        '
        'TransactionDateDataGridViewTextBoxColumn
        '
        Me.TransactionDateDataGridViewTextBoxColumn.DataPropertyName = "TransactionDate"
        Me.TransactionDateDataGridViewTextBoxColumn.HeaderText = "TransactionDate"
        Me.TransactionDateDataGridViewTextBoxColumn.Name = "TransactionDateDataGridViewTextBoxColumn"
        '
        'SEG1DataGridViewTextBoxColumn
        '
        Me.SEG1DataGridViewTextBoxColumn.DataPropertyName = "SEG1"
        Me.SEG1DataGridViewTextBoxColumn.HeaderText = "SEG1"
        Me.SEG1DataGridViewTextBoxColumn.Name = "SEG1DataGridViewTextBoxColumn"
        '
        'SEG2DataGridViewTextBoxColumn
        '
        Me.SEG2DataGridViewTextBoxColumn.DataPropertyName = "SEG2"
        Me.SEG2DataGridViewTextBoxColumn.HeaderText = "SEG2"
        Me.SEG2DataGridViewTextBoxColumn.Name = "SEG2DataGridViewTextBoxColumn"
        '
        'SEG3DataGridViewTextBoxColumn
        '
        Me.SEG3DataGridViewTextBoxColumn.DataPropertyName = "SEG3"
        Me.SEG3DataGridViewTextBoxColumn.HeaderText = "SEG3"
        Me.SEG3DataGridViewTextBoxColumn.Name = "SEG3DataGridViewTextBoxColumn"
        '
        'SEG4DataGridViewTextBoxColumn
        '
        Me.SEG4DataGridViewTextBoxColumn.DataPropertyName = "SEG4"
        Me.SEG4DataGridViewTextBoxColumn.HeaderText = "SEG4"
        Me.SEG4DataGridViewTextBoxColumn.Name = "SEG4DataGridViewTextBoxColumn"
        '
        'SEG5DataGridViewTextBoxColumn
        '
        Me.SEG5DataGridViewTextBoxColumn.DataPropertyName = "SEG5"
        Me.SEG5DataGridViewTextBoxColumn.HeaderText = "SEG5"
        Me.SEG5DataGridViewTextBoxColumn.Name = "SEG5DataGridViewTextBoxColumn"
        '
        'SEG6DataGridViewTextBoxColumn
        '
        Me.SEG6DataGridViewTextBoxColumn.DataPropertyName = "SEG6"
        Me.SEG6DataGridViewTextBoxColumn.HeaderText = "SEG6"
        Me.SEG6DataGridViewTextBoxColumn.Name = "SEG6DataGridViewTextBoxColumn"
        '
        'SEG7DataGridViewTextBoxColumn
        '
        Me.SEG7DataGridViewTextBoxColumn.DataPropertyName = "SEG7"
        Me.SEG7DataGridViewTextBoxColumn.HeaderText = "SEG7"
        Me.SEG7DataGridViewTextBoxColumn.Name = "SEG7DataGridViewTextBoxColumn"
        '
        'SEG8DataGridViewTextBoxColumn
        '
        Me.SEG8DataGridViewTextBoxColumn.DataPropertyName = "SEG8"
        Me.SEG8DataGridViewTextBoxColumn.HeaderText = "SEG8"
        Me.SEG8DataGridViewTextBoxColumn.Name = "SEG8DataGridViewTextBoxColumn"
        '
        'SEG9DataGridViewTextBoxColumn
        '
        Me.SEG9DataGridViewTextBoxColumn.DataPropertyName = "SEG9"
        Me.SEG9DataGridViewTextBoxColumn.HeaderText = "SEG9"
        Me.SEG9DataGridViewTextBoxColumn.Name = "SEG9DataGridViewTextBoxColumn"
        '
        'SEG10DataGridViewTextBoxColumn
        '
        Me.SEG10DataGridViewTextBoxColumn.DataPropertyName = "SEG10"
        Me.SEG10DataGridViewTextBoxColumn.HeaderText = "SEG10"
        Me.SEG10DataGridViewTextBoxColumn.Name = "SEG10DataGridViewTextBoxColumn"
        '
        'GuardianSourceDataGridViewTextBoxColumn
        '
        Me.GuardianSourceDataGridViewTextBoxColumn.DataPropertyName = "Guardian_Source"
        Me.GuardianSourceDataGridViewTextBoxColumn.HeaderText = "Guardian_Source"
        Me.GuardianSourceDataGridViewTextBoxColumn.Name = "GuardianSourceDataGridViewTextBoxColumn"
        '
        'SupplierNumDataGridViewTextBoxColumn
        '
        Me.SupplierNumDataGridViewTextBoxColumn.DataPropertyName = "SupplierNum"
        Me.SupplierNumDataGridViewTextBoxColumn.HeaderText = "SupplierNum"
        Me.SupplierNumDataGridViewTextBoxColumn.Name = "SupplierNumDataGridViewTextBoxColumn"
        '
        'SupplierNameDataGridViewTextBoxColumn
        '
        Me.SupplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName"
        Me.SupplierNameDataGridViewTextBoxColumn.HeaderText = "SupplierName"
        Me.SupplierNameDataGridViewTextBoxColumn.Name = "SupplierNameDataGridViewTextBoxColumn"
        '
        'PONumDataGridViewTextBoxColumn
        '
        Me.PONumDataGridViewTextBoxColumn.DataPropertyName = "PONum"
        Me.PONumDataGridViewTextBoxColumn.HeaderText = "PONum"
        Me.PONumDataGridViewTextBoxColumn.Name = "PONumDataGridViewTextBoxColumn"
        '
        'InvoiceNumDataGridViewTextBoxColumn
        '
        Me.InvoiceNumDataGridViewTextBoxColumn.DataPropertyName = "InvoiceNum"
        Me.InvoiceNumDataGridViewTextBoxColumn.HeaderText = "InvoiceNum"
        Me.InvoiceNumDataGridViewTextBoxColumn.Name = "InvoiceNumDataGridViewTextBoxColumn"
        '
        'InvoiceDateDataGridViewTextBoxColumn
        '
        Me.InvoiceDateDataGridViewTextBoxColumn.DataPropertyName = "InvoiceDate"
        Me.InvoiceDateDataGridViewTextBoxColumn.HeaderText = "InvoiceDate"
        Me.InvoiceDateDataGridViewTextBoxColumn.Name = "InvoiceDateDataGridViewTextBoxColumn"
        '
        'PaymentDateDataGridViewTextBoxColumn
        '
        Me.PaymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate"
        Me.PaymentDateDataGridViewTextBoxColumn.HeaderText = "PaymentDate"
        Me.PaymentDateDataGridViewTextBoxColumn.Name = "PaymentDateDataGridViewTextBoxColumn"
        '
        'CatalogCodeDataGridViewTextBoxColumn
        '
        Me.CatalogCodeDataGridViewTextBoxColumn.DataPropertyName = "CatalogCode"
        Me.CatalogCodeDataGridViewTextBoxColumn.HeaderText = "CatalogCode"
        Me.CatalogCodeDataGridViewTextBoxColumn.Name = "CatalogCodeDataGridViewTextBoxColumn"
        '
        'CatalogShortDescDataGridViewTextBoxColumn
        '
        Me.CatalogShortDescDataGridViewTextBoxColumn.DataPropertyName = "CatalogShort_Desc"
        Me.CatalogShortDescDataGridViewTextBoxColumn.HeaderText = "CatalogShort_Desc"
        Me.CatalogShortDescDataGridViewTextBoxColumn.Name = "CatalogShortDescDataGridViewTextBoxColumn"
        '
        'PartDescDataGridViewTextBoxColumn
        '
        Me.PartDescDataGridViewTextBoxColumn.DataPropertyName = "PartDesc"
        Me.PartDescDataGridViewTextBoxColumn.HeaderText = "PartDesc"
        Me.PartDescDataGridViewTextBoxColumn.Name = "PartDescDataGridViewTextBoxColumn"
        '
        'SupPartNumDataGridViewTextBoxColumn
        '
        Me.SupPartNumDataGridViewTextBoxColumn.DataPropertyName = "SupPartNum"
        Me.SupPartNumDataGridViewTextBoxColumn.HeaderText = "SupPartNum"
        Me.SupPartNumDataGridViewTextBoxColumn.Name = "SupPartNumDataGridViewTextBoxColumn"
        '
        'TaxCodeDataGridViewTextBoxColumn
        '
        Me.TaxCodeDataGridViewTextBoxColumn.DataPropertyName = "TaxCode"
        Me.TaxCodeDataGridViewTextBoxColumn.HeaderText = "TaxCode"
        Me.TaxCodeDataGridViewTextBoxColumn.Name = "TaxCodeDataGridViewTextBoxColumn"
        '
        'ReceiptDateDataGridViewTextBoxColumn
        '
        Me.ReceiptDateDataGridViewTextBoxColumn.DataPropertyName = "ReceiptDate"
        Me.ReceiptDateDataGridViewTextBoxColumn.HeaderText = "ReceiptDate"
        Me.ReceiptDateDataGridViewTextBoxColumn.Name = "ReceiptDateDataGridViewTextBoxColumn"
        '
        'InvoiceRefNoDataGridViewTextBoxColumn
        '
        Me.InvoiceRefNoDataGridViewTextBoxColumn.DataPropertyName = "InvoiceRefNo"
        Me.InvoiceRefNoDataGridViewTextBoxColumn.HeaderText = "InvoiceRefNo"
        Me.InvoiceRefNoDataGridViewTextBoxColumn.Name = "InvoiceRefNoDataGridViewTextBoxColumn"
        '
        'DestDataGridViewTextBoxColumn
        '
        Me.DestDataGridViewTextBoxColumn.DataPropertyName = "Dest"
        Me.DestDataGridViewTextBoxColumn.HeaderText = "Dest"
        Me.DestDataGridViewTextBoxColumn.Name = "DestDataGridViewTextBoxColumn"
        '
        'IsReversalDataGridViewTextBoxColumn
        '
        Me.IsReversalDataGridViewTextBoxColumn.DataPropertyName = "IsReversal"
        Me.IsReversalDataGridViewTextBoxColumn.HeaderText = "IsReversal"
        Me.IsReversalDataGridViewTextBoxColumn.Name = "IsReversalDataGridViewTextBoxColumn"
        '
        'ReceiptJournalNumberDataGridViewTextBoxColumn
        '
        Me.ReceiptJournalNumberDataGridViewTextBoxColumn.DataPropertyName = "Receipt_Journal_Number"
        Me.ReceiptJournalNumberDataGridViewTextBoxColumn.HeaderText = "Receipt_Journal_Number"
        Me.ReceiptJournalNumberDataGridViewTextBoxColumn.Name = "ReceiptJournalNumberDataGridViewTextBoxColumn"
        '
        'GlTransExportBindingSource1
        '
        Me.GlTransExportBindingSource1.DataMember = "GlTransExport"
        Me.GlTransExportBindingSource1.DataSource = Me.DsGuardian
        '
        'DsGuardian
        '
        Me.DsGuardian.DataSetName = "dsGuardian"
        Me.DsGuardian.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GlTransExportBindingSource
        '
        Me.GlTransExportBindingSource.DataMember = "GlTransExport"
        Me.GlTransExportBindingSource.DataSource = Me.DsGuardian
        '
        'dtpPostingDate
        '
        Me.dtpPostingDate.Location = New System.Drawing.Point(532, 18)
        Me.dtpPostingDate.Name = "dtpPostingDate"
        Me.dtpPostingDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpPostingDate.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(458, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Posting Date"
        '
        'frmGLImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1133, 597)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmGLImport"
        Me.Text = "frmGLImport"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvAccpacErrors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SessionErrorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAccpac1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvImportRes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VIEWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAccpac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GlTransExportBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsGuardian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GlTransExportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBTCHDESC As System.Windows.Forms.TextBox
    Friend WithEvents btnFdrCNTBTCH As System.Windows.Forms.Button
    Friend WithEvents txtCNTBTCH As System.Windows.Forms.TextBox
    Friend WithEvents rbExistingBatch As System.Windows.Forms.RadioButton
    Friend WithEvents rbNewBatch As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnBrowseFile2 As System.Windows.Forms.Button
    Friend WithEvents btnBrowseFile1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFile2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFile1 As System.Windows.Forms.TextBox
    Friend WithEvents cbAction As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GlTransExportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsGuardian As AccpacGuardianTool.dsGuardian
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BatchNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JournalNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccountNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PostDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JournalDescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JournalSourceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrRateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransactionDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEG1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEG2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEG3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEG4DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEG5DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEG6DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEG7DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEG8DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEG9DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEG10DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GuardianSourceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupplierNumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupplierNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PONumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvoiceNumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvoiceDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CatalogCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CatalogShortDescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PartDescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupPartNumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TaxCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReceiptDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvoiceRefNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DestDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsReversalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReceiptJournalNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GlTransExportBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents VIEWBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsAccpac As AccpacGuardianTool.dsAccpac
    Friend WithEvents SessionErrorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsAccpac1 As AccpacGuardianTool.dsAccpac
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvAccpacErrors As System.Windows.Forms.DataGridView
    Friend WithEvents IndexDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PPriorityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PMsgDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PSourceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PErrCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PHelpFileDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PHelpIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvImportRes As System.Windows.Forms.DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UpdatedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InsertedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProcessedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpPostingDate As System.Windows.Forms.DateTimePicker
End Class
