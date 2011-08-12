<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAPImport
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtTaxLine1 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtBTCHDESC = New System.Windows.Forms.TextBox
        Me.btnFdrCNTBTCH = New System.Windows.Forms.Button
        Me.txtCNTBTCH = New System.Windows.Forms.TextBox
        Me.rbExistingBatch = New System.Windows.Forms.RadioButton
        Me.rbNewBatch = New System.Windows.Forms.RadioButton
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.APTransExport1APTransExport2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpPostingDate = New System.Windows.Forms.DateTimePicker
        Me.InvoiceNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DocumentTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DocDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BatchNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VendorIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TermsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CurrencyIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CurrRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PurchaseAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FreightAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MiscAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TaxAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PostDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.APTransExport1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsGuardian = New AccpacGuardianTool.dsGuardian
        Me.InvoiceNumberDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PONumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.POLineNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateReceivedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LineDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DistributionTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AccountNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DebitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CreditDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TaxCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UnitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IsReversalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tax1AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tax1AccountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tax1HoldAccountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tax2AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tax2AccountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tax2HoldAccountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tax3AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tax3AccountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tax3HoldAccountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tax4AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tax4AccountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tax4HoldAccountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        Me.ExpAccountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EXPSEG1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EXPSEG2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EXPSEG3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EXPSEG4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EXPSEG5DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EXPSEG6DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EXPSEG7DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EXPSEG8DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EXPSEG9DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EXPSEG10DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APTransExport1APTransExport2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.APTransExport1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsGuardian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupBox1.Size = New System.Drawing.Size(1083, 110)
        Me.GroupBox1.TabIndex = 0
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
        Me.btnLoad.Location = New System.Drawing.Point(584, 46)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(83, 45)
        Me.btnLoad.TabIndex = 9
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnBrowseFile2
        '
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
        Me.Label3.Location = New System.Drawing.Point(12, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "File 2:"
        '
        'txtFile2
        '
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.dtpPostingDate)
        Me.GroupBox2.Controls.Add(Me.txtTaxLine1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtBTCHDESC)
        Me.GroupBox2.Controls.Add(Me.btnFdrCNTBTCH)
        Me.GroupBox2.Controls.Add(Me.txtCNTBTCH)
        Me.GroupBox2.Controls.Add(Me.rbExistingBatch)
        Me.GroupBox2.Controls.Add(Me.rbNewBatch)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1083, 83)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Accpac Batch"
        '
        'txtTaxLine1
        '
        Me.txtTaxLine1.Location = New System.Drawing.Point(580, 18)
        Me.txtTaxLine1.Name = "txtTaxLine1"
        Me.txtTaxLine1.Size = New System.Drawing.Size(200, 20)
        Me.txtTaxLine1.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(458, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Tax Line Description:"
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataGridView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1069, 323)
        Me.SplitContainer1.SplitterDistance = 140
        Me.SplitContainer1.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InvoiceNumberDataGridViewTextBoxColumn, Me.DocumentTypeDataGridViewTextBoxColumn, Me.DocDateDataGridViewTextBoxColumn, Me.BatchNumberDataGridViewTextBoxColumn, Me.VendorIDDataGridViewTextBoxColumn, Me.TermsDataGridViewTextBoxColumn, Me.CurrencyIDDataGridViewTextBoxColumn, Me.CurrRateDataGridViewTextBoxColumn, Me.PurchaseAmountDataGridViewTextBoxColumn, Me.FreightAmountDataGridViewTextBoxColumn, Me.MiscAmountDataGridViewTextBoxColumn, Me.TaxAmountDataGridViewTextBoxColumn, Me.PostDateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.APTransExport1BindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1069, 140)
        Me.DataGridView1.TabIndex = 0
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InvoiceNumberDataGridViewTextBoxColumn1, Me.PONumberDataGridViewTextBoxColumn, Me.POLineNumDataGridViewTextBoxColumn, Me.DateReceivedDataGridViewTextBoxColumn, Me.LineDescriptionDataGridViewTextBoxColumn, Me.DistributionTypeDataGridViewTextBoxColumn, Me.AccountNumDataGridViewTextBoxColumn, Me.DebitDataGridViewTextBoxColumn, Me.CreditDataGridViewTextBoxColumn, Me.TaxCodeDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn, Me.UnitPriceDataGridViewTextBoxColumn, Me.IsReversalDataGridViewTextBoxColumn, Me.Tax1AmountDataGridViewTextBoxColumn, Me.Tax1AccountDataGridViewTextBoxColumn, Me.Tax1HoldAccountDataGridViewTextBoxColumn, Me.Tax2AmountDataGridViewTextBoxColumn, Me.Tax2AccountDataGridViewTextBoxColumn, Me.Tax2HoldAccountDataGridViewTextBoxColumn, Me.Tax3AmountDataGridViewTextBoxColumn, Me.Tax3AccountDataGridViewTextBoxColumn, Me.Tax3HoldAccountDataGridViewTextBoxColumn, Me.Tax4AmountDataGridViewTextBoxColumn, Me.Tax4AccountDataGridViewTextBoxColumn, Me.Tax4HoldAccountDataGridViewTextBoxColumn, Me.SEG1DataGridViewTextBoxColumn, Me.SEG2DataGridViewTextBoxColumn, Me.SEG3DataGridViewTextBoxColumn, Me.SEG4DataGridViewTextBoxColumn, Me.SEG5DataGridViewTextBoxColumn, Me.SEG6DataGridViewTextBoxColumn, Me.SEG7DataGridViewTextBoxColumn, Me.SEG8DataGridViewTextBoxColumn, Me.SEG9DataGridViewTextBoxColumn, Me.SEG10DataGridViewTextBoxColumn, Me.ExpAccountDataGridViewTextBoxColumn, Me.EXPSEG1DataGridViewTextBoxColumn, Me.EXPSEG2DataGridViewTextBoxColumn, Me.EXPSEG3DataGridViewTextBoxColumn, Me.EXPSEG4DataGridViewTextBoxColumn, Me.EXPSEG5DataGridViewTextBoxColumn, Me.EXPSEG6DataGridViewTextBoxColumn, Me.EXPSEG7DataGridViewTextBoxColumn, Me.EXPSEG8DataGridViewTextBoxColumn, Me.EXPSEG9DataGridViewTextBoxColumn, Me.EXPSEG10DataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.APTransExport1APTransExport2BindingSource
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(1069, 179)
        Me.DataGridView2.TabIndex = 0
        '
        'APTransExport1APTransExport2BindingSource
        '
        Me.APTransExport1APTransExport2BindingSource.DataMember = "APTransExport1_APTransExport2"
        Me.APTransExport1APTransExport2BindingSource.DataSource = Me.APTransExport1BindingSource
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 193)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1083, 355)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1075, 329)
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
        Me.TabPage2.Size = New System.Drawing.Size(1075, 329)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Results"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvAccpacErrors)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 147)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1069, 179)
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
        Me.dgvAccpacErrors.Size = New System.Drawing.Size(1063, 160)
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
        Me.GroupBox4.Size = New System.Drawing.Size(1069, 144)
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
        Me.dgvImportRes.Size = New System.Drawing.Size(1063, 125)
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(458, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Posting Date"
        Me.Label5.Visible = False
        '
        'dtpPostingDate
        '
        Me.dtpPostingDate.Location = New System.Drawing.Point(580, 44)
        Me.dtpPostingDate.Name = "dtpPostingDate"
        Me.dtpPostingDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpPostingDate.TabIndex = 15
        Me.dtpPostingDate.Visible = False
        '
        'InvoiceNumberDataGridViewTextBoxColumn
        '
        Me.InvoiceNumberDataGridViewTextBoxColumn.DataPropertyName = "InvoiceNumber"
        Me.InvoiceNumberDataGridViewTextBoxColumn.HeaderText = "InvoiceNumber"
        Me.InvoiceNumberDataGridViewTextBoxColumn.Name = "InvoiceNumberDataGridViewTextBoxColumn"
        '
        'DocumentTypeDataGridViewTextBoxColumn
        '
        Me.DocumentTypeDataGridViewTextBoxColumn.DataPropertyName = "DocumentType"
        Me.DocumentTypeDataGridViewTextBoxColumn.HeaderText = "DocumentType"
        Me.DocumentTypeDataGridViewTextBoxColumn.Name = "DocumentTypeDataGridViewTextBoxColumn"
        '
        'DocDateDataGridViewTextBoxColumn
        '
        Me.DocDateDataGridViewTextBoxColumn.DataPropertyName = "DocDate"
        Me.DocDateDataGridViewTextBoxColumn.HeaderText = "DocDate"
        Me.DocDateDataGridViewTextBoxColumn.Name = "DocDateDataGridViewTextBoxColumn"
        '
        'BatchNumberDataGridViewTextBoxColumn
        '
        Me.BatchNumberDataGridViewTextBoxColumn.DataPropertyName = "BatchNumber"
        Me.BatchNumberDataGridViewTextBoxColumn.HeaderText = "BatchNumber"
        Me.BatchNumberDataGridViewTextBoxColumn.Name = "BatchNumberDataGridViewTextBoxColumn"
        '
        'VendorIDDataGridViewTextBoxColumn
        '
        Me.VendorIDDataGridViewTextBoxColumn.DataPropertyName = "VendorID"
        Me.VendorIDDataGridViewTextBoxColumn.HeaderText = "VendorID"
        Me.VendorIDDataGridViewTextBoxColumn.Name = "VendorIDDataGridViewTextBoxColumn"
        '
        'TermsDataGridViewTextBoxColumn
        '
        Me.TermsDataGridViewTextBoxColumn.DataPropertyName = "Terms"
        Me.TermsDataGridViewTextBoxColumn.HeaderText = "Terms"
        Me.TermsDataGridViewTextBoxColumn.Name = "TermsDataGridViewTextBoxColumn"
        '
        'CurrencyIDDataGridViewTextBoxColumn
        '
        Me.CurrencyIDDataGridViewTextBoxColumn.DataPropertyName = "CurrencyID"
        Me.CurrencyIDDataGridViewTextBoxColumn.HeaderText = "CurrencyID"
        Me.CurrencyIDDataGridViewTextBoxColumn.Name = "CurrencyIDDataGridViewTextBoxColumn"
        '
        'CurrRateDataGridViewTextBoxColumn
        '
        Me.CurrRateDataGridViewTextBoxColumn.DataPropertyName = "CurrRate"
        Me.CurrRateDataGridViewTextBoxColumn.HeaderText = "CurrRate"
        Me.CurrRateDataGridViewTextBoxColumn.Name = "CurrRateDataGridViewTextBoxColumn"
        '
        'PurchaseAmountDataGridViewTextBoxColumn
        '
        Me.PurchaseAmountDataGridViewTextBoxColumn.DataPropertyName = "PurchaseAmount"
        Me.PurchaseAmountDataGridViewTextBoxColumn.HeaderText = "PurchaseAmount"
        Me.PurchaseAmountDataGridViewTextBoxColumn.Name = "PurchaseAmountDataGridViewTextBoxColumn"
        '
        'FreightAmountDataGridViewTextBoxColumn
        '
        Me.FreightAmountDataGridViewTextBoxColumn.DataPropertyName = "FreightAmount"
        Me.FreightAmountDataGridViewTextBoxColumn.HeaderText = "FreightAmount"
        Me.FreightAmountDataGridViewTextBoxColumn.Name = "FreightAmountDataGridViewTextBoxColumn"
        '
        'MiscAmountDataGridViewTextBoxColumn
        '
        Me.MiscAmountDataGridViewTextBoxColumn.DataPropertyName = "MiscAmount"
        Me.MiscAmountDataGridViewTextBoxColumn.HeaderText = "MiscAmount"
        Me.MiscAmountDataGridViewTextBoxColumn.Name = "MiscAmountDataGridViewTextBoxColumn"
        '
        'TaxAmountDataGridViewTextBoxColumn
        '
        Me.TaxAmountDataGridViewTextBoxColumn.DataPropertyName = "TaxAmount"
        Me.TaxAmountDataGridViewTextBoxColumn.HeaderText = "TaxAmount"
        Me.TaxAmountDataGridViewTextBoxColumn.Name = "TaxAmountDataGridViewTextBoxColumn"
        '
        'PostDateDataGridViewTextBoxColumn
        '
        Me.PostDateDataGridViewTextBoxColumn.DataPropertyName = "PostDate"
        Me.PostDateDataGridViewTextBoxColumn.HeaderText = "PostDate"
        Me.PostDateDataGridViewTextBoxColumn.Name = "PostDateDataGridViewTextBoxColumn"
        '
        'APTransExport1BindingSource
        '
        Me.APTransExport1BindingSource.DataMember = "APTransExport1"
        Me.APTransExport1BindingSource.DataSource = Me.DsGuardian
        '
        'DsGuardian
        '
        Me.DsGuardian.DataSetName = "dsGuardian"
        Me.DsGuardian.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InvoiceNumberDataGridViewTextBoxColumn1
        '
        Me.InvoiceNumberDataGridViewTextBoxColumn1.DataPropertyName = "InvoiceNumber"
        Me.InvoiceNumberDataGridViewTextBoxColumn1.HeaderText = "InvoiceNumber"
        Me.InvoiceNumberDataGridViewTextBoxColumn1.Name = "InvoiceNumberDataGridViewTextBoxColumn1"
        '
        'PONumberDataGridViewTextBoxColumn
        '
        Me.PONumberDataGridViewTextBoxColumn.DataPropertyName = "PONumber"
        Me.PONumberDataGridViewTextBoxColumn.HeaderText = "PONumber"
        Me.PONumberDataGridViewTextBoxColumn.Name = "PONumberDataGridViewTextBoxColumn"
        '
        'POLineNumDataGridViewTextBoxColumn
        '
        Me.POLineNumDataGridViewTextBoxColumn.DataPropertyName = "POLineNum"
        Me.POLineNumDataGridViewTextBoxColumn.HeaderText = "POLineNum"
        Me.POLineNumDataGridViewTextBoxColumn.Name = "POLineNumDataGridViewTextBoxColumn"
        '
        'DateReceivedDataGridViewTextBoxColumn
        '
        Me.DateReceivedDataGridViewTextBoxColumn.DataPropertyName = "DateReceived"
        Me.DateReceivedDataGridViewTextBoxColumn.HeaderText = "DateReceived"
        Me.DateReceivedDataGridViewTextBoxColumn.Name = "DateReceivedDataGridViewTextBoxColumn"
        '
        'LineDescriptionDataGridViewTextBoxColumn
        '
        Me.LineDescriptionDataGridViewTextBoxColumn.DataPropertyName = "LineDescription"
        Me.LineDescriptionDataGridViewTextBoxColumn.HeaderText = "LineDescription"
        Me.LineDescriptionDataGridViewTextBoxColumn.Name = "LineDescriptionDataGridViewTextBoxColumn"
        '
        'DistributionTypeDataGridViewTextBoxColumn
        '
        Me.DistributionTypeDataGridViewTextBoxColumn.DataPropertyName = "DistributionType"
        Me.DistributionTypeDataGridViewTextBoxColumn.HeaderText = "DistributionType"
        Me.DistributionTypeDataGridViewTextBoxColumn.Name = "DistributionTypeDataGridViewTextBoxColumn"
        '
        'AccountNumDataGridViewTextBoxColumn
        '
        Me.AccountNumDataGridViewTextBoxColumn.DataPropertyName = "AccountNum"
        Me.AccountNumDataGridViewTextBoxColumn.HeaderText = "AccountNum"
        Me.AccountNumDataGridViewTextBoxColumn.Name = "AccountNumDataGridViewTextBoxColumn"
        '
        'DebitDataGridViewTextBoxColumn
        '
        Me.DebitDataGridViewTextBoxColumn.DataPropertyName = "Debit"
        Me.DebitDataGridViewTextBoxColumn.HeaderText = "Debit"
        Me.DebitDataGridViewTextBoxColumn.Name = "DebitDataGridViewTextBoxColumn"
        '
        'CreditDataGridViewTextBoxColumn
        '
        Me.CreditDataGridViewTextBoxColumn.DataPropertyName = "Credit"
        Me.CreditDataGridViewTextBoxColumn.HeaderText = "Credit"
        Me.CreditDataGridViewTextBoxColumn.Name = "CreditDataGridViewTextBoxColumn"
        '
        'TaxCodeDataGridViewTextBoxColumn
        '
        Me.TaxCodeDataGridViewTextBoxColumn.DataPropertyName = "TaxCode"
        Me.TaxCodeDataGridViewTextBoxColumn.HeaderText = "TaxCode"
        Me.TaxCodeDataGridViewTextBoxColumn.Name = "TaxCodeDataGridViewTextBoxColumn"
        '
        'QtyDataGridViewTextBoxColumn
        '
        Me.QtyDataGridViewTextBoxColumn.DataPropertyName = "Qty"
        Me.QtyDataGridViewTextBoxColumn.HeaderText = "Qty"
        Me.QtyDataGridViewTextBoxColumn.Name = "QtyDataGridViewTextBoxColumn"
        '
        'UnitPriceDataGridViewTextBoxColumn
        '
        Me.UnitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice"
        Me.UnitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice"
        Me.UnitPriceDataGridViewTextBoxColumn.Name = "UnitPriceDataGridViewTextBoxColumn"
        '
        'IsReversalDataGridViewTextBoxColumn
        '
        Me.IsReversalDataGridViewTextBoxColumn.DataPropertyName = "IsReversal"
        Me.IsReversalDataGridViewTextBoxColumn.HeaderText = "IsReversal"
        Me.IsReversalDataGridViewTextBoxColumn.Name = "IsReversalDataGridViewTextBoxColumn"
        '
        'Tax1AmountDataGridViewTextBoxColumn
        '
        Me.Tax1AmountDataGridViewTextBoxColumn.DataPropertyName = "Tax1Amount"
        Me.Tax1AmountDataGridViewTextBoxColumn.HeaderText = "Tax1Amount"
        Me.Tax1AmountDataGridViewTextBoxColumn.Name = "Tax1AmountDataGridViewTextBoxColumn"
        '
        'Tax1AccountDataGridViewTextBoxColumn
        '
        Me.Tax1AccountDataGridViewTextBoxColumn.DataPropertyName = "Tax1Account"
        Me.Tax1AccountDataGridViewTextBoxColumn.HeaderText = "Tax1Account"
        Me.Tax1AccountDataGridViewTextBoxColumn.Name = "Tax1AccountDataGridViewTextBoxColumn"
        '
        'Tax1HoldAccountDataGridViewTextBoxColumn
        '
        Me.Tax1HoldAccountDataGridViewTextBoxColumn.DataPropertyName = "Tax1HoldAccount"
        Me.Tax1HoldAccountDataGridViewTextBoxColumn.HeaderText = "Tax1HoldAccount"
        Me.Tax1HoldAccountDataGridViewTextBoxColumn.Name = "Tax1HoldAccountDataGridViewTextBoxColumn"
        '
        'Tax2AmountDataGridViewTextBoxColumn
        '
        Me.Tax2AmountDataGridViewTextBoxColumn.DataPropertyName = "Tax2Amount"
        Me.Tax2AmountDataGridViewTextBoxColumn.HeaderText = "Tax2Amount"
        Me.Tax2AmountDataGridViewTextBoxColumn.Name = "Tax2AmountDataGridViewTextBoxColumn"
        '
        'Tax2AccountDataGridViewTextBoxColumn
        '
        Me.Tax2AccountDataGridViewTextBoxColumn.DataPropertyName = "Tax2Account"
        Me.Tax2AccountDataGridViewTextBoxColumn.HeaderText = "Tax2Account"
        Me.Tax2AccountDataGridViewTextBoxColumn.Name = "Tax2AccountDataGridViewTextBoxColumn"
        '
        'Tax2HoldAccountDataGridViewTextBoxColumn
        '
        Me.Tax2HoldAccountDataGridViewTextBoxColumn.DataPropertyName = "Tax2HoldAccount"
        Me.Tax2HoldAccountDataGridViewTextBoxColumn.HeaderText = "Tax2HoldAccount"
        Me.Tax2HoldAccountDataGridViewTextBoxColumn.Name = "Tax2HoldAccountDataGridViewTextBoxColumn"
        '
        'Tax3AmountDataGridViewTextBoxColumn
        '
        Me.Tax3AmountDataGridViewTextBoxColumn.DataPropertyName = "Tax3Amount"
        Me.Tax3AmountDataGridViewTextBoxColumn.HeaderText = "Tax3Amount"
        Me.Tax3AmountDataGridViewTextBoxColumn.Name = "Tax3AmountDataGridViewTextBoxColumn"
        '
        'Tax3AccountDataGridViewTextBoxColumn
        '
        Me.Tax3AccountDataGridViewTextBoxColumn.DataPropertyName = "Tax3Account"
        Me.Tax3AccountDataGridViewTextBoxColumn.HeaderText = "Tax3Account"
        Me.Tax3AccountDataGridViewTextBoxColumn.Name = "Tax3AccountDataGridViewTextBoxColumn"
        '
        'Tax3HoldAccountDataGridViewTextBoxColumn
        '
        Me.Tax3HoldAccountDataGridViewTextBoxColumn.DataPropertyName = "Tax3HoldAccount"
        Me.Tax3HoldAccountDataGridViewTextBoxColumn.HeaderText = "Tax3HoldAccount"
        Me.Tax3HoldAccountDataGridViewTextBoxColumn.Name = "Tax3HoldAccountDataGridViewTextBoxColumn"
        '
        'Tax4AmountDataGridViewTextBoxColumn
        '
        Me.Tax4AmountDataGridViewTextBoxColumn.DataPropertyName = "Tax4Amount"
        Me.Tax4AmountDataGridViewTextBoxColumn.HeaderText = "Tax4Amount"
        Me.Tax4AmountDataGridViewTextBoxColumn.Name = "Tax4AmountDataGridViewTextBoxColumn"
        '
        'Tax4AccountDataGridViewTextBoxColumn
        '
        Me.Tax4AccountDataGridViewTextBoxColumn.DataPropertyName = "Tax4Account"
        Me.Tax4AccountDataGridViewTextBoxColumn.HeaderText = "Tax4Account"
        Me.Tax4AccountDataGridViewTextBoxColumn.Name = "Tax4AccountDataGridViewTextBoxColumn"
        '
        'Tax4HoldAccountDataGridViewTextBoxColumn
        '
        Me.Tax4HoldAccountDataGridViewTextBoxColumn.DataPropertyName = "Tax4HoldAccount"
        Me.Tax4HoldAccountDataGridViewTextBoxColumn.HeaderText = "Tax4HoldAccount"
        Me.Tax4HoldAccountDataGridViewTextBoxColumn.Name = "Tax4HoldAccountDataGridViewTextBoxColumn"
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
        'ExpAccountDataGridViewTextBoxColumn
        '
        Me.ExpAccountDataGridViewTextBoxColumn.DataPropertyName = "ExpAccount"
        Me.ExpAccountDataGridViewTextBoxColumn.HeaderText = "ExpAccount"
        Me.ExpAccountDataGridViewTextBoxColumn.Name = "ExpAccountDataGridViewTextBoxColumn"
        '
        'EXPSEG1DataGridViewTextBoxColumn
        '
        Me.EXPSEG1DataGridViewTextBoxColumn.DataPropertyName = "EXPSEG1"
        Me.EXPSEG1DataGridViewTextBoxColumn.HeaderText = "EXPSEG1"
        Me.EXPSEG1DataGridViewTextBoxColumn.Name = "EXPSEG1DataGridViewTextBoxColumn"
        '
        'EXPSEG2DataGridViewTextBoxColumn
        '
        Me.EXPSEG2DataGridViewTextBoxColumn.DataPropertyName = "EXPSEG2"
        Me.EXPSEG2DataGridViewTextBoxColumn.HeaderText = "EXPSEG2"
        Me.EXPSEG2DataGridViewTextBoxColumn.Name = "EXPSEG2DataGridViewTextBoxColumn"
        '
        'EXPSEG3DataGridViewTextBoxColumn
        '
        Me.EXPSEG3DataGridViewTextBoxColumn.DataPropertyName = "EXPSEG3"
        Me.EXPSEG3DataGridViewTextBoxColumn.HeaderText = "EXPSEG3"
        Me.EXPSEG3DataGridViewTextBoxColumn.Name = "EXPSEG3DataGridViewTextBoxColumn"
        '
        'EXPSEG4DataGridViewTextBoxColumn
        '
        Me.EXPSEG4DataGridViewTextBoxColumn.DataPropertyName = "EXPSEG4"
        Me.EXPSEG4DataGridViewTextBoxColumn.HeaderText = "EXPSEG4"
        Me.EXPSEG4DataGridViewTextBoxColumn.Name = "EXPSEG4DataGridViewTextBoxColumn"
        '
        'EXPSEG5DataGridViewTextBoxColumn
        '
        Me.EXPSEG5DataGridViewTextBoxColumn.DataPropertyName = "EXPSEG5"
        Me.EXPSEG5DataGridViewTextBoxColumn.HeaderText = "EXPSEG5"
        Me.EXPSEG5DataGridViewTextBoxColumn.Name = "EXPSEG5DataGridViewTextBoxColumn"
        '
        'EXPSEG6DataGridViewTextBoxColumn
        '
        Me.EXPSEG6DataGridViewTextBoxColumn.DataPropertyName = "EXPSEG6"
        Me.EXPSEG6DataGridViewTextBoxColumn.HeaderText = "EXPSEG6"
        Me.EXPSEG6DataGridViewTextBoxColumn.Name = "EXPSEG6DataGridViewTextBoxColumn"
        '
        'EXPSEG7DataGridViewTextBoxColumn
        '
        Me.EXPSEG7DataGridViewTextBoxColumn.DataPropertyName = "EXPSEG7"
        Me.EXPSEG7DataGridViewTextBoxColumn.HeaderText = "EXPSEG7"
        Me.EXPSEG7DataGridViewTextBoxColumn.Name = "EXPSEG7DataGridViewTextBoxColumn"
        '
        'EXPSEG8DataGridViewTextBoxColumn
        '
        Me.EXPSEG8DataGridViewTextBoxColumn.DataPropertyName = "EXPSEG8"
        Me.EXPSEG8DataGridViewTextBoxColumn.HeaderText = "EXPSEG8"
        Me.EXPSEG8DataGridViewTextBoxColumn.Name = "EXPSEG8DataGridViewTextBoxColumn"
        '
        'EXPSEG9DataGridViewTextBoxColumn
        '
        Me.EXPSEG9DataGridViewTextBoxColumn.DataPropertyName = "EXPSEG9"
        Me.EXPSEG9DataGridViewTextBoxColumn.HeaderText = "EXPSEG9"
        Me.EXPSEG9DataGridViewTextBoxColumn.Name = "EXPSEG9DataGridViewTextBoxColumn"
        '
        'EXPSEG10DataGridViewTextBoxColumn
        '
        Me.EXPSEG10DataGridViewTextBoxColumn.DataPropertyName = "EXPSEG10"
        Me.EXPSEG10DataGridViewTextBoxColumn.HeaderText = "EXPSEG10"
        Me.EXPSEG10DataGridViewTextBoxColumn.Name = "EXPSEG10DataGridViewTextBoxColumn"
        '
        'frmAPImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1083, 548)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAPImport"
        Me.Text = "frmImport"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APTransExport1APTransExport2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.APTransExport1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsGuardian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbAction As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFile2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFile1 As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowseFile2 As System.Windows.Forms.Button
    Friend WithEvents btnBrowseFile1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtBTCHDESC As System.Windows.Forms.TextBox
    Friend WithEvents btnFdrCNTBTCH As System.Windows.Forms.Button
    Friend WithEvents txtCNTBTCH As System.Windows.Forms.TextBox
    Friend WithEvents rbExistingBatch As System.Windows.Forms.RadioButton
    Friend WithEvents rbNewBatch As System.Windows.Forms.RadioButton
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents InvoiceNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocumentTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BatchNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VendorIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TermsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrencyIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrRateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurchaseAmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FreightAmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MiscAmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TaxAmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PostDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents APTransExport1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsGuardian As AccpacGuardianTool.dsGuardian
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents InvoiceNumberDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PONumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POLineNumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateReceivedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LineDescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DistributionTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccountNumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DebitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreditDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TaxCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsReversalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tax1AmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tax1AccountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tax1HoldAccountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tax2AmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tax2AccountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tax2HoldAccountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tax3AmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tax3AccountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tax3HoldAccountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tax4AmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tax4AccountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tax4HoldAccountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents ExpAccountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXPSEG1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXPSEG2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXPSEG3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXPSEG4DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXPSEG5DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXPSEG6DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXPSEG7DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXPSEG8DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXPSEG9DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXPSEG10DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents APTransExport1APTransExport2BindingSource As System.Windows.Forms.BindingSource
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
    Friend WithEvents txtTaxLine1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpPostingDate As System.Windows.Forms.DateTimePicker
End Class
