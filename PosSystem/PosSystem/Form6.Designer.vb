<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.SaveData = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.ShowDataView = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fullname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.addto_flag = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.stop_flag = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.QueryType = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.ShowDataView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SaveData
        '
        Me.SaveData.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SaveData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SaveData.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.SaveData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveData.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SaveData.Location = New System.Drawing.Point(12, 8)
        Me.SaveData.Name = "SaveData"
        Me.SaveData.Size = New System.Drawing.Size(98, 33)
        Me.SaveData.TabIndex = 82
        Me.SaveData.Text = "存檔"
        Me.SaveData.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Cancel.Location = New System.Drawing.Point(116, 8)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(98, 33)
        Me.Cancel.TabIndex = 83
        Me.Cancel.Text = "回主畫面"
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
        Me.ShowDataView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.fullname, Me.price, Me.addto_flag, Me.stop_flag})
        Me.ShowDataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.ShowDataView.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.ShowDataView.Location = New System.Drawing.Point(12, 45)
        Me.ShowDataView.Name = "ShowDataView"
        Me.ShowDataView.RowTemplate.Height = 24
        Me.ShowDataView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ShowDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ShowDataView.Size = New System.Drawing.Size(543, 222)
        Me.ShowDataView.TabIndex = 85
        '
        'id
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.id.DefaultCellStyle = DataGridViewCellStyle2
        Me.id.HeaderText = "商品代碼"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'fullname
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.fullname.DefaultCellStyle = DataGridViewCellStyle3
        Me.fullname.HeaderText = "商品名稱"
        Me.fullname.Name = "fullname"
        '
        'price
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.price.DefaultCellStyle = DataGridViewCellStyle4
        Me.price.HeaderText = "商品價格"
        Me.price.Name = "price"
        '
        'addto_flag
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.NullValue = False
        Me.addto_flag.DefaultCellStyle = DataGridViewCellStyle5
        Me.addto_flag.FalseValue = "N"
        Me.addto_flag.HeaderText = "加點否"
        Me.addto_flag.IndeterminateValue = "False"
        Me.addto_flag.Name = "addto_flag"
        Me.addto_flag.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.addto_flag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.addto_flag.TrueValue = "Y"
        '
        'stop_flag
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.NullValue = False
        Me.stop_flag.DefaultCellStyle = DataGridViewCellStyle6
        Me.stop_flag.FalseValue = "N"
        Me.stop_flag.HeaderText = "停用否"
        Me.stop_flag.IndeterminateValue = "False"
        Me.stop_flag.Name = "stop_flag"
        Me.stop_flag.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.stop_flag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.stop_flag.TrueValue = "Y"
        '
        'QueryType
        '
        Me.QueryType.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.QueryType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.QueryType.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.QueryType.FormattingEnabled = True
        Me.QueryType.Items.AddRange(New Object() {"冰品", "加點", "點心", "飲品", "其它", "全部"})
        Me.QueryType.Location = New System.Drawing.Point(434, 9)
        Me.QueryType.Name = "QueryType"
        Me.QueryType.Size = New System.Drawing.Size(121, 32)
        Me.QueryType.TabIndex = 86
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(341, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 24)
        Me.Label13.TabIndex = 87
        Me.Label13.Text = "查詢條件:"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(565, 279)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.QueryType)
        Me.Controls.Add(Me.ShowDataView)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.SaveData)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "商品維護檔"
        CType(Me.ShowDataView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaveData As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents ShowDataView As System.Windows.Forms.DataGridView
    Friend WithEvents QueryType As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fullname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents addto_flag As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents stop_flag As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
