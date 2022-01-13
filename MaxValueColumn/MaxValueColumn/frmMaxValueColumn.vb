#Region "About"
' / --------------------------------------------------------------------
' / Developer : Mr.Surapon Yodsanga (Thongkorn Tubtimkrob)
' / eMail : thongkorn@hotmail.com
' / URL: http://www.g2gnet.com (Khon Kaen - Thailand)
' / Facebook: https://www.facebook.com/g2gnet (For Thailand)
' / Facebook: https://www.facebook.com/commonindy (Worldwide)
' / More Info: http://www.g2gnet.com/webboard
' /
' / Purpose: Get max value of any column in DataGridView.
' / Microsoft Visual Basic .NET (2010)
' /
' / This is open source code under @CopyLeft by Thongkorn Tubtimkrob.
' / You can modify and/or distribute without to inform the developer.
' / --------------------------------------------------------------------
#End Region

Public Class frmMaxValueColumn
    '/ Start-Stop Timer
    Private mTimeDouble As Double
    Private sWatch As New Stopwatch()

    '// START HERE
    Private Sub frmMaxValueColumn_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call InitializeGrid(DataGridView1)
        Call FillSampleData()
    End Sub

    ' / --------------------------------------------------------------------------------
    '// Default settings for Grids in @Run Time
    Private Sub InitializeGrid(ByRef dgv As DataGridView)
        With dgv
            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .Font = New Font("Tahoma", 10)
            .RowHeadersVisible = True
            .AlternatingRowsDefaultCellStyle.BackColor = Color.SkyBlue
            .DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
            '/ Auto size column width of each main by sorting the field.
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoResizeColumns()
            '/ Adjust Header Styles
            With .ColumnHeadersDefaultCellStyle
                .BackColor = Color.Navy
                .ForeColor = Color.White
                .Font = New Font("Tahoma", 10, FontStyle.Bold)
            End With
        End With
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / SAMPLE DATA INTO DATAGRIDVIEW
    Private Sub FillSampleData()
        Dim DT As New DataTable
        DT.Columns.Add("Number Field")
        Dim RandomClass As New Random()
        For iRow As Long = 0 To 199999
            Dim DR As DataRow = DT.NewRow()
            DR(0) = RandomClass.Next(1, 999999)
            DT.Rows.Add(DR)
        Next
        DataGridView1.DataSource = DT
        lblRecordCount.Text = "Total: " & Format(DT.Rows.Count, "#,##0") & " Records."
        DT.Dispose()
    End Sub

    '// First Method.
    Private Sub btnMethodI_Click(sender As System.Object, e As System.EventArgs) Handles btnMethodI.Click
        '// เริ่มจับเวลา
        sWatch.Reset()
        sWatch.Start()
        Cursor = Cursors.WaitCursor
        '//
        Dim MaxValue As Long
        '// ByRef--> DataGridView, ByVal --> Column Index = 0
        MaxValue = GetMaxValueI(DataGridView1, 0)
        '//
        Cursor = Cursors.Default
        sWatch.Stop()
        mTimeDouble = sWatch.ElapsedMilliseconds * 0.001
        lblReport.Text = "Max Value = " & MaxValue & " [Timer: " & mTimeDouble & "]"
        lblRecordCount.Text = "Total: " & Format(DataGridView1.Rows.Count, "#,##0") & " Records." & " [First Method.]"
    End Sub

    '// Second Method.
    Private Sub btnMethodII_Click(sender As System.Object, e As System.EventArgs) Handles btnMethodII.Click
        '// เริ่มจับเวลา
        sWatch.Reset()
        sWatch.Start()
        Cursor = Cursors.WaitCursor
        '//
        Dim MaxValue As Long
        MaxValue = GetMaxValueII(DataGridView1, 0)
        '//
        Cursor = Cursors.Default
        sWatch.Stop()
        mTimeDouble = sWatch.ElapsedMilliseconds * 0.001
        lblReport.Text = "Max Value = " & MaxValue & " [Timer: " & mTimeDouble & "]"
        lblRecordCount.Text = "Total: " & Format(DataGridView1.Rows.Count, "#,##0") & " Records." & " [Second Method.]"
    End Sub

    '// Third Method.
    Private Sub btnMethodIII_Click(sender As System.Object, e As System.EventArgs) Handles btnMethodIII.Click
        '// เริ่มจับเวลา
        sWatch.Reset()
        sWatch.Start()
        Cursor = Cursors.WaitCursor
        '//
        Dim MaxValue As Long
        '// ByRef--> DataGridView, Column Index = 0
        MaxValue = GetMaxValueIII(DataGridView1, 0)
        '//
        Cursor = Cursors.Default
        sWatch.Stop()
        mTimeDouble = sWatch.ElapsedMilliseconds * 0.001
        lblReport.Text = "Max Value = " & MaxValue & " [Timer: " & mTimeDouble & "]"
        lblRecordCount.Text = "Total: " & Format(DataGridView1.Rows.Count, "#,##0") & " Records." & " [Third Method.]"
    End Sub

    '// Maximum value Method I.
    Function GetMaxValueI(ByRef dgv As DataGridView, ByVal ColNum As Integer) As Long
        '// นำค่าจากแถวแรกไปใส่ไว้ในตัวแปร (ชื่อฟังค์ชั่นตัวมันเอง)
        GetMaxValueI = dgv.Rows(ColNum).Cells(ColNum).Value
        For iRow As Long = 1 To dgv.Rows.Count - 1
            '// นำค่าจากแถวถัดไปมาเปรียบเทียบกับค่าในตัวแปร หากค่าในแถวมากกว่าค่าในตัวแปร ให้เอาค่าจากแถวมาให้ตัวแปร
            If dgv.Rows(iRow).Cells(ColNum).Value > GetMaxValueI Then GetMaxValueI = dgv.Rows(iRow).Cells(ColNum).Value
        Next
        Return GetMaxValueI
    End Function

    '// Maximum value Method II.
    Function GetMaxValueII(ByRef dgv As DataGridView, ByVal ColNum As Integer) As Long
        '// Start Get Max Value
        Dim ListData As New List(Of Long)
        For Each iRow As DataGridViewRow In dgv.Rows
            ListData.Add(iRow.Cells(ColNum).Value)
        Next
        Return ListData.Max
        '// Get Min Value.
        'ListData.Min
        '// Get Average Value.
        'ListData.Average
    End Function

    '// Maximum value Method III.
    Function GetMaxValueIII(ByRef dgv As DataGridView, ByVal ColNum As Integer) As Long
        '// Start Get Max Value and return.
        Return dgv.Rows.Cast(Of DataGridViewRow)().Max(Function(r) Convert.ToInt32(r.Cells(ColNum).Value))
    End Function

    Private Sub btnSample_Click(sender As System.Object, e As System.EventArgs) Handles btnSample.Click
        Call FillSampleData()
        lblReport.Text = "Report: "
    End Sub

    Private Sub frmMaxValueColumn_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        GC.SuppressFinalize(Me)
        Application.Exit()
    End Sub

End Class
