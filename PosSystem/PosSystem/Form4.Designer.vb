<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.ShowDataView = New System.Windows.Forms.DataGridView()
        Me.ShowSubtraction = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ShowId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShowType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShowFullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShowQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShowPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddWith = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShowSubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShowAddToFlag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IceTemp = New System.Windows.Forms.DataGridView()
        Me.IceId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IceFullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IcePrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IceAddition = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.IceSubtraction = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.AddToTemp = New System.Windows.Forms.DataGridView()
        Me.AddToId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddToType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddToFullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddToPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Finish = New System.Windows.Forms.Button()
        CType(Me.ShowDataView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IceTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddToTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.ShowDataView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ShowSubtraction, Me.ShowId, Me.ShowType, Me.ShowFullName, Me.ShowQty, Me.ShowPrice, Me.AddWith, Me.ShowSubTotal, Me.ShowAddToFlag})
        Me.ShowDataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.ShowDataView.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.ShowDataView.Location = New System.Drawing.Point(316, 14)
        Me.ShowDataView.Name = "ShowDataView"
        Me.ShowDataView.RowHeadersVisible = False
        Me.ShowDataView.RowTemplate.Height = 24
        Me.ShowDataView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ShowDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ShowDataView.Size = New System.Drawing.Size(443, 236)
        Me.ShowDataView.TabIndex = 23
        '
        'ShowSubtraction
        '
        Me.ShowSubtraction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.ShowSubtraction.DefaultCellStyle = DataGridViewCellStyle2
        Me.ShowSubtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShowSubtraction.HeaderText = ""
        Me.ShowSubtraction.Name = "ShowSubtraction"
        Me.ShowSubtraction.Width = 40
        '
        'ShowId
        '
        Me.ShowId.HeaderText = "品項代號"
        Me.ShowId.Name = "ShowId"
        Me.ShowId.Visible = False
        '
        'ShowType
        '
        Me.ShowType.HeaderText = "種類"
        Me.ShowType.Name = "ShowType"
        Me.ShowType.Visible = False
        '
        'ShowFullName
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.ShowFullName.DefaultCellStyle = DataGridViewCellStyle3
        Me.ShowFullName.HeaderText = "項目名稱"
        Me.ShowFullName.Name = "ShowFullName"
        Me.ShowFullName.ReadOnly = True
        '
        'ShowQty
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.ShowQty.DefaultCellStyle = DataGridViewCellStyle4
        Me.ShowQty.HeaderText = "項目數量"
        Me.ShowQty.Name = "ShowQty"
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
        'AddWith
        '
        Me.AddWith.HeaderText = "冰品附加註記"
        Me.AddWith.Name = "AddWith"
        Me.AddWith.Visible = False
        '
        'ShowSubTotal
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.ShowSubTotal.DefaultCellStyle = DataGridViewCellStyle6
        Me.ShowSubTotal.HeaderText = "小計"
        Me.ShowSubTotal.Name = "ShowSubTotal"
        Me.ShowSubTotal.ReadOnly = True
        '
        'ShowAddToFlag
        '
        Me.ShowAddToFlag.HeaderText = "加點否"
        Me.ShowAddToFlag.Name = "ShowAddToFlag"
        Me.ShowAddToFlag.Visible = False
        '
        'IceTemp
        '
        Me.IceTemp.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IceTemp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.IceTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IceTemp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IceId, Me.IceFullName, Me.IcePrice, Me.IceAddition, Me.IceSubtraction})
        Me.IceTemp.Location = New System.Drawing.Point(9, 14)
        Me.IceTemp.MultiSelect = False
        Me.IceTemp.Name = "IceTemp"
        Me.IceTemp.ReadOnly = True
        Me.IceTemp.RowHeadersVisible = False
        Me.IceTemp.RowTemplate.Height = 24
        Me.IceTemp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.IceTemp.Size = New System.Drawing.Size(301, 56)
        Me.IceTemp.TabIndex = 24
        '
        'IceId
        '
        DataGridViewCellStyle8.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.IceId.DefaultCellStyle = DataGridViewCellStyle8
        Me.IceId.HeaderText = "冰品代號"
        Me.IceId.Name = "IceId"
        Me.IceId.ReadOnly = True
        Me.IceId.Visible = False
        '
        'IceFullName
        '
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle9.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        Me.IceFullName.DefaultCellStyle = DataGridViewCellStyle9
        Me.IceFullName.HeaderText = "冰品名"
        Me.IceFullName.Name = "IceFullName"
        Me.IceFullName.ReadOnly = True
        '
        'IcePrice
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle10.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        Me.IcePrice.DefaultCellStyle = DataGridViewCellStyle10
        Me.IcePrice.HeaderText = "價格"
        Me.IcePrice.Name = "IcePrice"
        Me.IcePrice.ReadOnly = True
        '
        'IceAddition
        '
        Me.IceAddition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle11.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        Me.IceAddition.DefaultCellStyle = DataGridViewCellStyle11
        Me.IceAddition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IceAddition.HeaderText = ""
        Me.IceAddition.Name = "IceAddition"
        Me.IceAddition.ReadOnly = True
        Me.IceAddition.Width = 40
        '
        'IceSubtraction
        '
        Me.IceSubtraction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle12.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        Me.IceSubtraction.DefaultCellStyle = DataGridViewCellStyle12
        Me.IceSubtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IceSubtraction.HeaderText = ""
        Me.IceSubtraction.Name = "IceSubtraction"
        Me.IceSubtraction.ReadOnly = True
        Me.IceSubtraction.Width = 40
        '
        'AddToTemp
        '
        Me.AddToTemp.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AddToTemp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.AddToTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AddToTemp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AddToId, Me.AddToType, Me.AddToFullName, Me.AddToPrice})
        Me.AddToTemp.Location = New System.Drawing.Point(9, 85)
        Me.AddToTemp.Name = "AddToTemp"
        Me.AddToTemp.ReadOnly = True
        Me.AddToTemp.RowHeadersVisible = False
        Me.AddToTemp.RowTemplate.Height = 24
        Me.AddToTemp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.AddToTemp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AddToTemp.Size = New System.Drawing.Size(204, 165)
        Me.AddToTemp.TabIndex = 28
        '
        'AddToId
        '
        Me.AddToId.HeaderText = "品項代號"
        Me.AddToId.Name = "AddToId"
        Me.AddToId.ReadOnly = True
        Me.AddToId.Visible = False
        '
        'AddToType
        '
        Me.AddToType.HeaderText = "種類註記: 加點"
        Me.AddToType.Name = "AddToType"
        Me.AddToType.ReadOnly = True
        Me.AddToType.Visible = False
        '
        'AddToFullName
        '
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle14.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black
        Me.AddToFullName.DefaultCellStyle = DataGridViewCellStyle14
        Me.AddToFullName.HeaderText = "加點項目"
        Me.AddToFullName.Name = "AddToFullName"
        Me.AddToFullName.ReadOnly = True
        '
        'AddToPrice
        '
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle15.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black
        Me.AddToPrice.DefaultCellStyle = DataGridViewCellStyle15
        Me.AddToPrice.HeaderText = "價格"
        Me.AddToPrice.Name = "AddToPrice"
        Me.AddToPrice.ReadOnly = True
        '
        'Finish
        '
        Me.Finish.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Finish.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Finish.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Finish.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Finish.ForeColor = System.Drawing.Color.Black
        Me.Finish.Location = New System.Drawing.Point(212, 85)
        Me.Finish.Name = "Finish"
        Me.Finish.Size = New System.Drawing.Size(98, 165)
        Me.Finish.TabIndex = 29
        Me.Finish.Text = "確認"
        Me.Finish.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(768, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.Finish)
        Me.Controls.Add(Me.AddToTemp)
        Me.Controls.Add(Me.IceTemp)
        Me.Controls.Add(Me.ShowDataView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "冰品細項確認"
        CType(Me.ShowDataView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IceTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddToTemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ShowDataView As System.Windows.Forms.DataGridView
    Friend WithEvents IceTemp As System.Windows.Forms.DataGridView
    Friend WithEvents AddToTemp As System.Windows.Forms.DataGridView
    Friend WithEvents Finish As System.Windows.Forms.Button
    Friend WithEvents ShowSubtraction As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ShowId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShowType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShowFullName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShowQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShowPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddWith As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShowSubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShowAddToFlag As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IceId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IceFullName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IcePrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IceAddition As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents IceSubtraction As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents AddToId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddToType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddToFullName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddToPrice As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
