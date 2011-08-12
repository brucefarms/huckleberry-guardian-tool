<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportAPTrans
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
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
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
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
        Me.APTransExport1APTransExport2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APTransExport1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsGuardian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APTransExport1APTransExport2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 117)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(928, 374)
        Me.SplitContainer1.SplitterDistance = 163
        Me.SplitContainer1.TabIndex = 0
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
        Me.DataGridView1.Size = New System.Drawing.Size(928, 163)
        Me.DataGridView1.TabIndex = 0
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
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InvoiceNumberDataGridViewTextBoxColumn1, Me.PONumberDataGridViewTextBoxColumn, Me.POLineNumDataGridViewTextBoxColumn, Me.DateReceivedDataGridViewTextBoxColumn, Me.LineDescriptionDataGridViewTextBoxColumn, Me.DistributionTypeDataGridViewTextBoxColumn, Me.AccountNumDataGridViewTextBoxColumn, Me.DebitDataGridViewTextBoxColumn, Me.CreditDataGridViewTextBoxColumn, Me.TaxCodeDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn, Me.UnitPriceDataGridViewTextBoxColumn, Me.IsReversalDataGridViewTextBoxColumn, Me.Tax1AmountDataGridViewTextBoxColumn, Me.Tax1AccountDataGridViewTextBoxColumn, Me.Tax1HoldAccountDataGridViewTextBoxColumn, Me.Tax2AmountDataGridViewTextBoxColumn, Me.Tax2AccountDataGridViewTextBoxColumn, Me.Tax2HoldAccountDataGridViewTextBoxColumn, Me.Tax3AmountDataGridViewTextBoxColumn, Me.Tax3AccountDataGridViewTextBoxColumn, Me.Tax3HoldAccountDataGridViewTextBoxColumn, Me.Tax4AmountDataGridViewTextBoxColumn, Me.Tax4AccountDataGridViewTextBoxColumn, Me.Tax4HoldAccountDataGridViewTextBoxColumn, Me.SEG1DataGridViewTextBoxColumn, Me.SEG2DataGridViewTextBoxColumn, Me.SEG3DataGridViewTextBoxColumn, Me.SEG4DataGridViewTextBoxColumn, Me.SEG5DataGridViewTextBoxColumn, Me.SEG6DataGridViewTextBoxColumn, Me.SEG7DataGridViewTextBoxColumn, Me.SEG8DataGridViewTextBoxColumn, Me.SEG9DataGridViewTextBoxColumn, Me.SEG10DataGridViewTextBoxColumn, Me.ExpAccountDataGridViewTextBoxColumn, Me.EXPSEG1DataGridViewTextBoxColumn, Me.EXPSEG2DataGridViewTextBoxColumn, Me.EXPSEG3DataGridViewTextBoxColumn, Me.EXPSEG4DataGridViewTextBoxColumn, Me.EXPSEG5DataGridViewTextBoxColumn, Me.EXPSEG6DataGridViewTextBoxColumn, Me.EXPSEG7DataGridViewTextBoxColumn, Me.EXPSEG8DataGridViewTextBoxColumn, Me.EXPSEG9DataGridViewTextBoxColumn, Me.EXPSEG10DataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.APTransExport1APTransExport2BindingSource
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(928, 207)
        Me.DataGridView2.TabIndex = 0
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
        'APTransExport1APTransExport2BindingSource
        '
        Me.APTransExport1APTransExport2BindingSource.DataMember = "APTransExport1_APTransExport2"
        Me.APTransExport1APTransExport2BindingSource.DataSource = Me.APTransExport1BindingSource
        '
        'frmImportAPTrans
        '
        Me.ClientSize = New System.Drawing.Size(928, 491)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmImportAPTrans"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APTransExport1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsGuardian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APTransExport1APTransExport2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
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

End Class
