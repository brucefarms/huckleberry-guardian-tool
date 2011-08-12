Partial Class frmAPImport

    Public Session As AccpacCOMAPI.AccpacSession
    Public DBLink As AccpacCOMAPI.AccpacDBLink

    Sub UpdateCNTBTCH()
        Dim v As AccpacCOMAPI.AccpacView = Nothing
        DBLink.OpenView("AP0020", v)

        v.Browse("CNTBTCH=" & txtCNTBTCH.Text, True)
        Do While v.Fetch
            Me.txtBTCHDESC.Text = v.Fields.FieldByName("BTCHDESC").Value
            Me.rbExistingBatch.Checked = True
        Loop

    End Sub

    Function CreateAPInvoiceBatch(ByVal str As String) As Integer
        Dim mDBLinkCmpRW As AccpacCOMAPI.AccpacDBLink
        mDBLinkCmpRW = Session.OpenDBLink(AccpacCOMAPI.tagDBLinkTypeEnum.DBLINK_COMPANY, AccpacCOMAPI.tagDBLinkFlagsEnum.DBLINK_FLG_READWRITE)

        Dim temp As Boolean
        Dim APINVOICE1batch As AccpacCOMAPI.AccpacView
        Dim APINVOICE1batchFields As AccpacCOMAPI.AccpacViewFields
        mDBLinkCmpRW.OpenView("AP0020", APINVOICE1batch)
        APINVOICE1batchFields = APINVOICE1batch.Fields

        Dim APINVOICE1header As AccpacCOMAPI.AccpacView
        Dim APINVOICE1headerFields As AccpacCOMAPI.AccpacViewFields
        mDBLinkCmpRW.OpenView("AP0021", APINVOICE1header)
        APINVOICE1headerFields = APINVOICE1header.Fields

        Dim APINVOICE1detail1 As AccpacCOMAPI.AccpacView
        Dim APINVOICE1detail1Fields As AccpacCOMAPI.AccpacViewFields
        mDBLinkCmpRW.OpenView("AP0022", APINVOICE1detail1)
        APINVOICE1detail1Fields = APINVOICE1detail1.Fields

        Dim APINVOICE1detail2 As AccpacCOMAPI.AccpacView
        Dim APINVOICE1detail2Fields As AccpacCOMAPI.AccpacViewFields
        mDBLinkCmpRW.OpenView("AP0023", APINVOICE1detail2)
        APINVOICE1detail2Fields = APINVOICE1detail2.Fields

        Dim APINVOICE1detail3 As AccpacCOMAPI.AccpacView
        Dim APINVOICE1detail3Fields As AccpacCOMAPI.AccpacViewFields
        mDBLinkCmpRW.OpenView("AP0402", APINVOICE1detail3)
        APINVOICE1detail3Fields = APINVOICE1detail3.Fields

        Dim APINVOICE1detail4 As AccpacCOMAPI.AccpacView
        Dim APINVOICE1detail4Fields As AccpacCOMAPI.AccpacViewFields
        mDBLinkCmpRW.OpenView("AP0401", APINVOICE1detail4)
        APINVOICE1detail4Fields = APINVOICE1detail4.Fields

        APINVOICE1batch.Compose(New AccpacCOMAPI.AccpacView() {APINVOICE1header})
        APINVOICE1header.Compose(New AccpacCOMAPI.AccpacView() {APINVOICE1batch, APINVOICE1detail1, APINVOICE1detail2, APINVOICE1detail3})
        APINVOICE1detail1.Compose(New AccpacCOMAPI.AccpacView() {APINVOICE1header, APINVOICE1batch, APINVOICE1detail4})
        APINVOICE1detail2.Compose(New AccpacCOMAPI.AccpacView() {APINVOICE1header})
        APINVOICE1detail3.Compose(New AccpacCOMAPI.AccpacView() {APINVOICE1header})
        APINVOICE1detail4.Compose(New AccpacCOMAPI.AccpacView() {APINVOICE1detail1})


        APINVOICE1batch.Browse("((BTCHSTTS = 1) OR (BTCHSTTS = 7))", 1)
        APINVOICE1batch.RecordCreate(1)

        APINVOICE1batchFields.FieldByName("PROCESSCMD").PutWithoutVerification("1")      ' Process Command Code

        APINVOICE1batch.Process()
        APINVOICE1batch.Read()
        APINVOICE1header.RecordCreate(2)
        APINVOICE1detail1.Cancel()
        APINVOICE1batchFields.FieldByName("BTCHDESC").PutWithoutVerification(str)     ' Description
        APINVOICE1batch.Update()

        Return APINVOICE1batch.Fields.FieldByName("CNTBTCH").Value
    End Function

End Class
