<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaxValueColumn
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
        Me.btnMethodI = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnMethodII = New System.Windows.Forms.Button()
        Me.lblRecordCount = New System.Windows.Forms.Label()
        Me.btnSample = New System.Windows.Forms.Button()
        Me.lblReport = New System.Windows.Forms.Label()
        Me.btnMethodIII = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMethodI
        '
        Me.btnMethodI.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMethodI.BackColor = System.Drawing.Color.DarkOrange
        Me.btnMethodI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMethodI.FlatAppearance.BorderSize = 0
        Me.btnMethodI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMethodI.Location = New System.Drawing.Point(364, 502)
        Me.btnMethodI.Name = "btnMethodI"
        Me.btnMethodI.Size = New System.Drawing.Size(100, 31)
        Me.btnMethodI.TabIndex = 2
        Me.btnMethodI.Text = "Method I"
        Me.btnMethodI.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 29)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(676, 467)
        Me.DataGridView1.TabIndex = 0
        '
        'btnMethodII
        '
        Me.btnMethodII.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMethodII.BackColor = System.Drawing.Color.LightGreen
        Me.btnMethodII.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMethodII.FlatAppearance.BorderSize = 0
        Me.btnMethodII.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMethodII.Location = New System.Drawing.Point(470, 502)
        Me.btnMethodII.Name = "btnMethodII"
        Me.btnMethodII.Size = New System.Drawing.Size(100, 31)
        Me.btnMethodII.TabIndex = 3
        Me.btnMethodII.Text = "Method II"
        Me.btnMethodII.UseVisualStyleBackColor = False
        '
        'lblRecordCount
        '
        Me.lblRecordCount.AutoSize = True
        Me.lblRecordCount.Location = New System.Drawing.Point(-3, 8)
        Me.lblRecordCount.Name = "lblRecordCount"
        Me.lblRecordCount.Size = New System.Drawing.Size(46, 18)
        Me.lblRecordCount.TabIndex = 18
        Me.lblRecordCount.Text = "Total:"
        '
        'btnSample
        '
        Me.btnSample.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSample.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSample.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSample.FlatAppearance.BorderSize = 0
        Me.btnSample.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSample.Location = New System.Drawing.Point(258, 502)
        Me.btnSample.Name = "btnSample"
        Me.btnSample.Size = New System.Drawing.Size(100, 31)
        Me.btnSample.TabIndex = 1
        Me.btnSample.Text = "Sample Data"
        Me.btnSample.UseVisualStyleBackColor = False
        '
        'lblReport
        '
        Me.lblReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblReport.AutoSize = True
        Me.lblReport.Location = New System.Drawing.Point(-3, 508)
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Size = New System.Drawing.Size(56, 18)
        Me.lblReport.TabIndex = 20
        Me.lblReport.Text = "Report:"
        '
        'btnMethodIII
        '
        Me.btnMethodIII.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMethodIII.BackColor = System.Drawing.Color.Gold
        Me.btnMethodIII.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMethodIII.FlatAppearance.BorderSize = 0
        Me.btnMethodIII.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMethodIII.Location = New System.Drawing.Point(576, 502)
        Me.btnMethodIII.Name = "btnMethodIII"
        Me.btnMethodIII.Size = New System.Drawing.Size(100, 31)
        Me.btnMethodIII.TabIndex = 4
        Me.btnMethodIII.Text = "Method III"
        Me.btnMethodIII.UseVisualStyleBackColor = False
        '
        'frmMaxValueColumn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 537)
        Me.Controls.Add(Me.btnMethodIII)
        Me.Controls.Add(Me.lblReport)
        Me.Controls.Add(Me.btnSample)
        Me.Controls.Add(Me.lblRecordCount)
        Me.Controls.Add(Me.btnMethodII)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnMethodI)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(686, 568)
        Me.Name = "frmMaxValueColumn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Get Max Value of any Column in DataGridView - coDe bY: Thongkorn Tubtimkrob"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMethodI As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnMethodII As System.Windows.Forms.Button
    Friend WithEvents lblRecordCount As System.Windows.Forms.Label
    Friend WithEvents btnSample As System.Windows.Forms.Button
    Friend WithEvents lblReport As System.Windows.Forms.Label
    Friend WithEvents btnMethodIII As System.Windows.Forms.Button

End Class
