<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form11))
        Me.Cancel = New System.Windows.Forms.Button()
        Me.ShowDataView = New System.Windows.Forms.DataGridView()
        Me.ShowId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShowType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShowFullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShowQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShowPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShowSubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DayTotalLabel = New System.Windows.Forms.Label()
        Me.AmtTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.QtyTotal = New System.Windows.Forms.TextBox()
        Me.PrintData = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DiscountTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PaidTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.StartDate = New System.Windows.Forms.TextBox()
        Me.EndDate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Query = New System.Windows.Forms.Button()
        CType(Me.ShowDataView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cancel
        '
        Me.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Cancel.Location = New System.Drawing.Point(12, 12)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(98, 33)
        Me.Cancel.TabIndex = 90
        Me.Cancel.Text = "回上一層"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'ShowDataView
        '
        Me.ShowDataView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ShowDataView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ShowDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ShowDataView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ShowId, Me.ShowType, Me.ShowFullName, Me.ShowQty, Me.ShowPrice, Me.ShowSubTotal})
        Me.ShowDataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.ShowDataView.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.ShowDataView.Location = New System.Drawing.Point(12, 44)
        Me.ShowDataView.Name = "ShowDataView"
        Me.ShowDataView.ReadOnly = True
        Me.ShowDataView.RowHeadersVisible = False
        Me.ShowDataView.RowTemplate.Height = 30
        Me.ShowDataView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ShowDataView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ShowDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ShowDataView.Size = New System.Drawing.Size(780, 270)
        Me.ShowDataView.TabIndex = 89
        '
        'ShowId
        '
        Me.ShowId.HeaderText = "商品代號"
        Me.ShowId.Name = "ShowId"
        Me.ShowId.ReadOnly = True
        Me.ShowId.Visible = False
        Me.ShowId.Width = 70
        '
        'ShowType
        '
        Me.ShowType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.ShowType.DefaultCellStyle = DataGridViewCellStyle2
        Me.ShowType.HeaderText = "種類"
        Me.ShowType.Name = "ShowType"
        Me.ShowType.ReadOnly = True
        Me.ShowType.Width = 70
        '
        'ShowFullName
        '
        Me.ShowFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.ShowFullName.DefaultCellStyle = DataGridViewCellStyle3
        Me.ShowFullName.HeaderText = "項目名稱"
        Me.ShowFullName.Name = "ShowFullName"
        Me.ShowFullName.ReadOnly = True
        Me.ShowFullName.Width = 367
        '
        'ShowQty
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.ShowQty.DefaultCellStyle = DataGridViewCellStyle4
        Me.ShowQty.HeaderText = "項目數量"
        Me.ShowQty.Name = "ShowQty"
        Me.ShowQty.ReadOnly = True
        '
        'ShowPrice
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.ShowPrice.DefaultCellStyle = DataGridViewCellStyle5
        Me.ShowPrice.HeaderText = "項目價格"
        Me.ShowPrice.Name = "ShowPrice"
        Me.ShowPrice.ReadOnly = True
        '
        'ShowSubTotal
        '
        Me.ShowSubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.ShowSubTotal.DefaultCellStyle = DataGridViewCellStyle6
        Me.ShowSubTotal.HeaderText = "小計"
        Me.ShowSubTotal.Name = "ShowSubTotal"
        Me.ShowSubTotal.ReadOnly = True
        Me.ShowSubTotal.Width = 140
        '
        'DayTotalLabel
        '
        Me.DayTotalLabel.AutoSize = True
        Me.DayTotalLabel.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DayTotalLabel.Location = New System.Drawing.Point(197, 325)
        Me.DayTotalLabel.Name = "DayTotalLabel"
        Me.DayTotalLabel.Size = New System.Drawing.Size(72, 24)
        Me.DayTotalLabel.TabIndex = 94
        Me.DayTotalLabel.Text = "總應收:"
        '
        'AmtTotal
        '
        Me.AmtTotal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.AmtTotal.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.AmtTotal.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.AmtTotal.Location = New System.Drawing.Point(269, 320)
        Me.AmtTotal.Name = "AmtTotal"
        Me.AmtTotal.ReadOnly = True
        Me.AmtTotal.Size = New System.Drawing.Size(121, 33)
        Me.AmtTotal.TabIndex = 93
        Me.AmtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 325)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "總數量:"
        '
        'QtyTotal
        '
        Me.QtyTotal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.QtyTotal.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.QtyTotal.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.QtyTotal.Location = New System.Drawing.Point(86, 320)
        Me.QtyTotal.Name = "QtyTotal"
        Me.QtyTotal.ReadOnly = True
        Me.QtyTotal.Size = New System.Drawing.Size(101, 33)
        Me.QtyTotal.TabIndex = 95
        Me.QtyTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PrintData
        '
        Me.PrintData.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.PrintData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PrintData.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PrintData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrintData.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.PrintData.Location = New System.Drawing.Point(694, 12)
        Me.PrintData.Name = "PrintData"
        Me.PrintData.Size = New System.Drawing.Size(98, 33)
        Me.PrintData.TabIndex = 97
        Me.PrintData.Text = "列印"
        Me.PrintData.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(399, 325)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 24)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "總折扣:"
        '
        'DiscountTotal
        '
        Me.DiscountTotal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.DiscountTotal.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DiscountTotal.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.DiscountTotal.Location = New System.Drawing.Point(471, 320)
        Me.DiscountTotal.Name = "DiscountTotal"
        Me.DiscountTotal.ReadOnly = True
        Me.DiscountTotal.Size = New System.Drawing.Size(121, 33)
        Me.DiscountTotal.TabIndex = 99
        Me.DiscountTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(599, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 24)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "總實收:"
        '
        'PaidTotal
        '
        Me.PaidTotal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PaidTotal.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.PaidTotal.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.PaidTotal.Location = New System.Drawing.Point(671, 320)
        Me.PaidTotal.Name = "PaidTotal"
        Me.PaidTotal.ReadOnly = True
        Me.PaidTotal.Size = New System.Drawing.Size(121, 33)
        Me.PaidTotal.TabIndex = 101
        Me.PaidTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(144, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 24)
        Me.Label5.TabIndex = 105
        Me.Label5.Text = "統計日期起迄:"
        '
        'StartDate
        '
        Me.StartDate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.StartDate.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.StartDate.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.StartDate.Location = New System.Drawing.Point(273, 12)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Size = New System.Drawing.Size(132, 33)
        Me.StartDate.TabIndex = 104
        Me.StartDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EndDate
        '
        Me.EndDate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.EndDate.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.EndDate.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.EndDate.Location = New System.Drawing.Point(434, 12)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(132, 33)
        Me.EndDate.TabIndex = 106
        Me.EndDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(405, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 24)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "～"
        '
        'Query
        '
        Me.Query.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Query.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Query.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Query.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Query.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Query.Location = New System.Drawing.Point(590, 12)
        Me.Query.Name = "Query"
        Me.Query.Size = New System.Drawing.Size(98, 33)
        Me.Query.TabIndex = 108
        Me.Query.Text = "查詢"
        Me.Query.UseVisualStyleBackColor = True
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(804, 368)
        Me.ControlBox = False
        Me.Controls.Add(Me.Query)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.EndDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.StartDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PaidTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DiscountTotal)
        Me.Controls.Add(Me.PrintData)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.QtyTotal)
        Me.Controls.Add(Me.DayTotalLabel)
        Me.Controls.Add(Me.AmtTotal)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.ShowDataView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Form11"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "清帳統計表"
        CType(Me.ShowDataView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents ShowDataView As System.Windows.Forms.DataGridView
    Friend WithEvents DayTotalLabel As System.Windows.Forms.Label
    Friend WithEvents AmtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents QtyTotal As System.Windows.Forms.TextBox
    Friend WithEvents PrintData As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DiscountTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PaidTotal As System.Windows.Forms.TextBox
    Friend WithEvents ShowId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShowType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShowFullName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShowQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShowPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShowSubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents StartDate As System.Windows.Forms.TextBox
    Friend WithEvents EndDate As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Query As System.Windows.Forms.Button
End Class
