<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_WorkOff
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意:  以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_WorkOff))
        Me.WorkEmpNo = New System.Windows.Forms.TextBox()
        Me.WorkEmpName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.No = New System.Windows.Forms.Button()
        Me.Yes = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WorkAmt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WorkPaidAmt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.WorkTotalAmt = New System.Windows.Forms.TextBox()
        Me.ShowDataView = New System.Windows.Forms.DataGridView()
        Me.Chose = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Detail = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ShowWorkDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShowWorkEmpName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShowWorkAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShowWorkPaidAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShowLostAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShowWorkTotalAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShowWorkTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.general = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.ShowDataView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WorkEmpNo
        '
        Me.WorkEmpNo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.WorkEmpNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WorkEmpNo.Font = New System.Drawing.Font("Microsoft JhengHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.WorkEmpNo.ForeColor = System.Drawing.Color.Red
        Me.WorkEmpNo.Location = New System.Drawing.Point(971, 98)
        Me.WorkEmpNo.Name = "WorkEmpNo"
        Me.WorkEmpNo.ReadOnly = True
        Me.WorkEmpNo.Size = New System.Drawing.Size(27, 35)
        Me.WorkEmpNo.TabIndex = 112
        Me.WorkEmpNo.Visible = False
        '
        'WorkEmpName
        '
        Me.WorkEmpName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.WorkEmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WorkEmpName.Font = New System.Drawing.Font("Microsoft JhengHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.WorkEmpName.ForeColor = System.Drawing.Color.Navy
        Me.WorkEmpName.Location = New System.Drawing.Point(806, 98)
        Me.WorkEmpName.Name = "WorkEmpName"
        Me.WorkEmpName.ReadOnly = True
        Me.WorkEmpName.Size = New System.Drawing.Size(166, 35)
        Me.WorkEmpName.TabIndex = 111
        Me.WorkEmpName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(725, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(320, 28)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "請確認交班明細正確無誤再執行"
        '
        'No
        '
        Me.No.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.No.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.No.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.No.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.No.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.No.Location = New System.Drawing.Point(905, 241)
        Me.No.Name = "No"
        Me.No.Size = New System.Drawing.Size(138, 33)
        Me.No.TabIndex = 109
        Me.No.Text = "取消"
        Me.No.UseVisualStyleBackColor = True
        '
        'Yes
        '
        Me.Yes.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Yes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Yes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Yes.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Yes.Location = New System.Drawing.Point(740, 241)
        Me.Yes.Name = "Yes"
        Me.Yes.Size = New System.Drawing.Size(138, 33)
        Me.Yes.TabIndex = 108
        Me.Yes.Text = "確定"
        Me.Yes.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(737, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 24)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "點帳(應收)金額"
        '
        'WorkAmt
        '
        Me.WorkAmt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.WorkAmt.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.WorkAmt.ForeColor = System.Drawing.Color.Crimson
        Me.WorkAmt.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.WorkAmt.Location = New System.Drawing.Point(740, 183)
        Me.WorkAmt.Multiline = True
        Me.WorkAmt.Name = "WorkAmt"
        Me.WorkAmt.ReadOnly = True
        Me.WorkAmt.Size = New System.Drawing.Size(138, 33)
        Me.WorkAmt.TabIndex = 104
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(902, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 24)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "清點(實收)金額"
        '
        'WorkPaidAmt
        '
        Me.WorkPaidAmt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.WorkPaidAmt.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.WorkPaidAmt.ForeColor = System.Drawing.Color.Navy
        Me.WorkPaidAmt.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.WorkPaidAmt.Location = New System.Drawing.Point(905, 183)
        Me.WorkPaidAmt.Multiline = True
        Me.WorkPaidAmt.Name = "WorkPaidAmt"
        Me.WorkPaidAmt.Size = New System.Drawing.Size(138, 33)
        Me.WorkPaidAmt.TabIndex = 113
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(847, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 24)
        Me.Label4.TabIndex = 115
        Me.Label4.Text = "點帳人員"
        '
        'WorkTotalAmt
        '
        Me.WorkTotalAmt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.WorkTotalAmt.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.WorkTotalAmt.ForeColor = System.Drawing.Color.Crimson
        Me.WorkTotalAmt.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.WorkTotalAmt.Location = New System.Drawing.Point(905, 218)
        Me.WorkTotalAmt.Multiline = True
        Me.WorkTotalAmt.Name = "WorkTotalAmt"
        Me.WorkTotalAmt.ReadOnly = True
        Me.WorkTotalAmt.Size = New System.Drawing.Size(138, 20)
        Me.WorkTotalAmt.TabIndex = 116
        Me.WorkTotalAmt.Visible = False
        '
        'ShowDataView
        '
        Me.ShowDataView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ShowDataView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ShowDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ShowDataView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Chose, Me.Detail, Me.ShowWorkDate, Me.ShowWorkEmpName, Me.ShowWorkAmt, Me.ShowWorkPaidAmt, Me.ShowLostAmt, Me.ShowWorkTotalAmt, Me.ShowWorkTime})
        Me.ShowDataView.Location = New System.Drawing.Point(11, 24)
        Me.ShowDataView.Name = "ShowDataView"
        Me.ShowDataView.ReadOnly = True
        Me.ShowDataView.RowHeadersVisible = False
        Me.ShowDataView.RowTemplate.Height = 24
        Me.ShowDataView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ShowDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ShowDataView.Size = New System.Drawing.Size(708, 250)
        Me.ShowDataView.TabIndex = 117
        '
        'Chose
        '
        Me.Chose.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.Chose.DefaultCellStyle = DataGridViewCellStyle2
        Me.Chose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Chose.HeaderText = ""
        Me.Chose.Name = "Chose"
        Me.Chose.ReadOnly = True
        Me.Chose.Visible = False
        Me.Chose.Width = 50
        '
        'Detail
        '
        Me.Detail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.Detail.DefaultCellStyle = DataGridViewCellStyle3
        Me.Detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Detail.HeaderText = ""
        Me.Detail.Name = "Detail"
        Me.Detail.ReadOnly = True
        Me.Detail.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Detail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Detail.Visible = False
        Me.Detail.Width = 50
        '
        'ShowWorkDate
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.ShowWorkDate.DefaultCellStyle = DataGridViewCellStyle4
        Me.ShowWorkDate.HeaderText = "交班日期"
        Me.ShowWorkDate.Name = "ShowWorkDate"
        Me.ShowWorkDate.ReadOnly = True
        '
        'ShowWorkEmpName
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.ShowWorkEmpName.DefaultCellStyle = DataGridViewCellStyle5
        Me.ShowWorkEmpName.HeaderText = "交班人員"
        Me.ShowWorkEmpName.Name = "ShowWorkEmpName"
        Me.ShowWorkEmpName.ReadOnly = True
        '
        'ShowWorkAmt
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.ShowWorkAmt.DefaultCellStyle = DataGridViewCellStyle6
        Me.ShowWorkAmt.HeaderText = "點帳金額"
        Me.ShowWorkAmt.Name = "ShowWorkAmt"
        Me.ShowWorkAmt.ReadOnly = True
        '
        'ShowWorkPaidAmt
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        Me.ShowWorkPaidAmt.DefaultCellStyle = DataGridViewCellStyle7
        Me.ShowWorkPaidAmt.HeaderText = "清點金額"
        Me.ShowWorkPaidAmt.Name = "ShowWorkPaidAmt"
        Me.ShowWorkPaidAmt.ReadOnly = True
        '
        'ShowLostAmt
        '
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        Me.ShowLostAmt.DefaultCellStyle = DataGridViewCellStyle8
        Me.ShowLostAmt.HeaderText = "清點差額"
        Me.ShowLostAmt.Name = "ShowLostAmt"
        Me.ShowLostAmt.ReadOnly = True
        '
        'ShowWorkTotalAmt
        '
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        Me.ShowWorkTotalAmt.DefaultCellStyle = DataGridViewCellStyle9
        Me.ShowWorkTotalAmt.HeaderText = "累計總額"
        Me.ShowWorkTotalAmt.Name = "ShowWorkTotalAmt"
        Me.ShowWorkTotalAmt.ReadOnly = True
        '
        'ShowWorkTime
        '
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ShowWorkTime.DefaultCellStyle = DataGridViewCellStyle10
        Me.ShowWorkTime.HeaderText = "交班時間"
        Me.ShowWorkTime.Name = "ShowWorkTime"
        Me.ShowWorkTime.ReadOnly = True
        '
        'general
        '
        Me.general.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.general.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.general.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.general.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.general.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.general.Location = New System.Drawing.Point(725, 37)
        Me.general.Name = "general"
        Me.general.Size = New System.Drawing.Size(45, 33)
        Me.general.TabIndex = 118
        Me.general.Text = "產生"
        Me.general.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Navy
        Me.TextBox1.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.TextBox1.Location = New System.Drawing.Point(776, 36)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(267, 33)
        Me.TextBox1.TabIndex = 119
        '
        'Form_WorkOff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1068, 297)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.general)
        Me.Controls.Add(Me.ShowDataView)
        Me.Controls.Add(Me.WorkTotalAmt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.WorkPaidAmt)
        Me.Controls.Add(Me.WorkEmpNo)
        Me.Controls.Add(Me.WorkEmpName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.No)
        Me.Controls.Add(Me.Yes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WorkAmt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_WorkOff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "交班點帳"
        CType(Me.ShowDataView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WorkEmpNo As System.Windows.Forms.TextBox
    Friend WithEvents WorkEmpName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents No As System.Windows.Forms.Button
    Friend WithEvents Yes As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents WorkAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents WorkPaidAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents WorkTotalAmt As System.Windows.Forms.TextBox
    Friend WithEvents ShowDataView As System.Windows.Forms.DataGridView
    Friend WithEvents Chose As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Detail As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ShowWorkDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShowWorkEmpName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShowWorkAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShowWorkPaidAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShowLostAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShowWorkTotalAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShowWorkTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents general As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
