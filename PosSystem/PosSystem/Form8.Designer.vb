<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.Cancel = New System.Windows.Forms.Button()
        Me.ShowDataView = New System.Windows.Forms.DataGridView()
        Me.ShowFullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShowQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShowPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShowSubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Cancel.Location = New System.Drawing.Point(12, 5)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(98, 33)
        Me.Cancel.TabIndex = 88
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
        Me.ShowDataView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ShowFullName, Me.ShowQty, Me.ShowPrice, Me.ShowSubTotal})
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
        Me.ShowDataView.Size = New System.Drawing.Size(653, 270)
        Me.ShowDataView.TabIndex = 87
        '
        'ShowFullName
        '
        Me.ShowFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.ShowFullName.DefaultCellStyle = DataGridViewCellStyle2
        Me.ShowFullName.HeaderText = "項目名稱"
        Me.ShowFullName.Name = "ShowFullName"
        Me.ShowFullName.ReadOnly = True
        Me.ShowFullName.Width = 350
        '
        'ShowQty
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.ShowQty.DefaultCellStyle = DataGridViewCellStyle3
        Me.ShowQty.HeaderText = "項目數量"
        Me.ShowQty.Name = "ShowQty"
        Me.ShowQty.ReadOnly = True
        '
        'ShowPrice
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.ShowPrice.DefaultCellStyle = DataGridViewCellStyle4
        Me.ShowPrice.HeaderText = "項目價格"
        Me.ShowPrice.Name = "ShowPrice"
        Me.ShowPrice.ReadOnly = True
        '
        'ShowSubTotal
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.ShowSubTotal.DefaultCellStyle = DataGridViewCellStyle5
        Me.ShowSubTotal.HeaderText = "小計"
        Me.ShowSubTotal.Name = "ShowSubTotal"
        Me.ShowSubTotal.ReadOnly = True
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(679, 331)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.ShowDataView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form8"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "收費明細資料"
        CType(Me.ShowDataView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents ShowDataView As System.Windows.Forms.DataGridView
    Friend WithEvents ShowFullName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShowQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShowPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShowSubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
