<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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

    '注意: 以下為 Windows Form 設計工具所需的程序
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.ShowDataView = New System.Windows.Forms.DataGridView()
        Me.ChargeDate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChooseChargeNo = New System.Windows.Forms.TextBox()
        Me.DayTotal = New System.Windows.Forms.TextBox()
        Me.DayTotalLabel = New System.Windows.Forms.Label()
        Me.Chose = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Detail = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MealNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Seat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpecMealNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChargeNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChargeDateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChargeClerk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaidAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_amt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ShowDataView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.ShowDataView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Chose, Me.Detail, Me.Remark, Me.MealNo, Me.Seat, Me.SpecMealNo, Me.ChargeNo, Me.ChargeDateTime, Me.ChargeClerk, Me.TotalAmt, Me.DiscountAmt, Me.PaidAmt, Me.ReturnAmt, Me.customer_amt})
        Me.ShowDataView.Location = New System.Drawing.Point(10, 52)
        Me.ShowDataView.Name = "ShowDataView"
        Me.ShowDataView.ReadOnly = True
        Me.ShowDataView.RowHeadersVisible = False
        Me.ShowDataView.RowTemplate.Height = 24
        Me.ShowDataView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ShowDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ShowDataView.Size = New System.Drawing.Size(1320, 317)
        Me.ShowDataView.TabIndex = 24
        '
        'ChargeDate
        '
        Me.ChargeDate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ChargeDate.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ChargeDate.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ChargeDate.Location = New System.Drawing.Point(104, 10)
        Me.ChargeDate.Name = "ChargeDate"
        Me.ChargeDate.Size = New System.Drawing.Size(121, 33)
        Me.ChargeDate.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 24)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "結帳日期:"
        '
        'Cancel
        '
        Me.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Cancel.Location = New System.Drawing.Point(262, 10)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(98, 33)
        Me.Cancel.TabIndex = 81
        Me.Cancel.Text = "取消"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(1116, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 24)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "收費號碼:"
        '
        'ChooseChargeNo
        '
        Me.ChooseChargeNo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ChooseChargeNo.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ChooseChargeNo.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ChooseChargeNo.Location = New System.Drawing.Point(1209, 15)
        Me.ChooseChargeNo.Name = "ChooseChargeNo"
        Me.ChooseChargeNo.ReadOnly = True
        Me.ChooseChargeNo.Size = New System.Drawing.Size(121, 33)
        Me.ChooseChargeNo.TabIndex = 89
        '
        'DayTotal
        '
        Me.DayTotal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.DayTotal.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DayTotal.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.DayTotal.Location = New System.Drawing.Point(1209, 375)
        Me.DayTotal.Name = "DayTotal"
        Me.DayTotal.ReadOnly = True
        Me.DayTotal.Size = New System.Drawing.Size(121, 33)
        Me.DayTotal.TabIndex = 91
        Me.DayTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DayTotalLabel
        '
        Me.DayTotalLabel.AutoSize = True
        Me.DayTotalLabel.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DayTotalLabel.Location = New System.Drawing.Point(1135, 380)
        Me.DayTotalLabel.Name = "DayTotalLabel"
        Me.DayTotalLabel.Size = New System.Drawing.Size(72, 24)
        Me.DayTotalLabel.TabIndex = 92
        Me.DayTotalLabel.Text = "日總額:"
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
        Me.Detail.Width = 50
        '
        'Remark
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.Remark.DefaultCellStyle = DataGridViewCellStyle4
        Me.Remark.HeaderText = "備註"
        Me.Remark.Name = "Remark"
        Me.Remark.ReadOnly = True
        '
        'MealNo
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.MealNo.DefaultCellStyle = DataGridViewCellStyle5
        Me.MealNo.HeaderText = "點餐號碼"
        Me.MealNo.Name = "MealNo"
        Me.MealNo.ReadOnly = True
        '
        'Seat
        '
        Me.Seat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Seat.DefaultCellStyle = DataGridViewCellStyle6
        Me.Seat.HeaderText = "桌位"
        Me.Seat.Name = "Seat"
        Me.Seat.ReadOnly = True
        Me.Seat.Width = 70
        '
        'SpecMealNo
        '
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SpecMealNo.DefaultCellStyle = DataGridViewCellStyle7
        Me.SpecMealNo.HeaderText = "特殊號碼"
        Me.SpecMealNo.Name = "SpecMealNo"
        Me.SpecMealNo.ReadOnly = True
        '
        'ChargeNo
        '
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        Me.ChargeNo.DefaultCellStyle = DataGridViewCellStyle8
        Me.ChargeNo.HeaderText = "收費號碼"
        Me.ChargeNo.Name = "ChargeNo"
        Me.ChargeNo.ReadOnly = True
        '
        'ChargeDateTime
        '
        Me.ChargeDateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        Me.ChargeDateTime.DefaultCellStyle = DataGridViewCellStyle9
        Me.ChargeDateTime.HeaderText = "收費日期時間"
        Me.ChargeDateTime.Name = "ChargeDateTime"
        Me.ChargeDateTime.ReadOnly = True
        Me.ChargeDateTime.Width = 135
        '
        'ChargeClerk
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        Me.ChargeClerk.DefaultCellStyle = DataGridViewCellStyle10
        Me.ChargeClerk.HeaderText = "收費人員"
        Me.ChargeClerk.Name = "ChargeClerk"
        Me.ChargeClerk.ReadOnly = True
        '
        'TotalAmt
        '
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        Me.TotalAmt.DefaultCellStyle = DataGridViewCellStyle11
        Me.TotalAmt.HeaderText = "總金額"
        Me.TotalAmt.Name = "TotalAmt"
        Me.TotalAmt.ReadOnly = True
        '
        'DiscountAmt
        '
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        Me.DiscountAmt.DefaultCellStyle = DataGridViewCellStyle12
        Me.DiscountAmt.HeaderText = "折扣金額"
        Me.DiscountAmt.Name = "DiscountAmt"
        Me.DiscountAmt.ReadOnly = True
        '
        'PaidAmt
        '
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        Me.PaidAmt.DefaultCellStyle = DataGridViewCellStyle13
        Me.PaidAmt.HeaderText = "實收金額"
        Me.PaidAmt.Name = "PaidAmt"
        Me.PaidAmt.ReadOnly = True
        '
        'ReturnAmt
        '
        Me.ReturnAmt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black
        Me.ReturnAmt.DefaultCellStyle = DataGridViewCellStyle14
        Me.ReturnAmt.HeaderText = "退費/加收"
        Me.ReturnAmt.Name = "ReturnAmt"
        Me.ReturnAmt.ReadOnly = True
        Me.ReturnAmt.Width = 105
        '
        'customer_amt
        '
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black
        Me.customer_amt.DefaultCellStyle = DataGridViewCellStyle15
        Me.customer_amt.HeaderText = "收款金額"
        Me.customer_amt.Name = "customer_amt"
        Me.customer_amt.ReadOnly = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1358, 416)
        Me.ControlBox = False
        Me.Controls.Add(Me.DayTotalLabel)
        Me.Controls.Add(Me.DayTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ChooseChargeNo)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ChargeDate)
        Me.Controls.Add(Me.ShowDataView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "查詢已結帳資料"
        CType(Me.ShowDataView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShowDataView As System.Windows.Forms.DataGridView
    Friend WithEvents ChargeDate As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ChooseChargeNo As System.Windows.Forms.TextBox
    Friend WithEvents DayTotal As System.Windows.Forms.TextBox
    Friend WithEvents DayTotalLabel As System.Windows.Forms.Label
    Friend WithEvents Chose As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Detail As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Remark As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MealNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Seat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SpecMealNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChargeNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChargeDateTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChargeClerk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiscountAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaidAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReturnAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_amt As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
