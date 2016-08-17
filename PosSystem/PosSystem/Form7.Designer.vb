<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowPriceDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShowPriceDetail))
        Me.NowEmployeeNo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NowEmployeeName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ReturnAmt = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.NowPaidAmt = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DiscountAmt = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ChangeAmt = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PaidAmt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TotalAmt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NowEmployeeNo
        '
        Me.NowEmployeeNo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.NowEmployeeNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NowEmployeeNo.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NowEmployeeNo.ForeColor = System.Drawing.Color.Red
        Me.NowEmployeeNo.Location = New System.Drawing.Point(339, 11)
        Me.NowEmployeeNo.Name = "NowEmployeeNo"
        Me.NowEmployeeNo.ReadOnly = True
        Me.NowEmployeeNo.Size = New System.Drawing.Size(27, 33)
        Me.NowEmployeeNo.TabIndex = 114
        Me.NowEmployeeNo.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(12, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 24)
        Me.Label10.TabIndex = 113
        Me.Label10.Text = "結帳人員:"
        '
        'NowEmployeeName
        '
        Me.NowEmployeeName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.NowEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NowEmployeeName.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NowEmployeeName.ForeColor = System.Drawing.Color.Red
        Me.NowEmployeeName.Location = New System.Drawing.Point(109, 11)
        Me.NowEmployeeName.Name = "NowEmployeeName"
        Me.NowEmployeeName.ReadOnly = True
        Me.NowEmployeeName.Size = New System.Drawing.Size(231, 33)
        Me.NowEmployeeName.TabIndex = 112
        Me.NowEmployeeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(199, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 24)
        Me.Label7.TabIndex = 111
        Me.Label7.Text = "退款:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(341, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 24)
        Me.Label9.TabIndex = 110
        Me.Label9.Text = "元"
        '
        'ReturnAmt
        '
        Me.ReturnAmt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ReturnAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReturnAmt.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ReturnAmt.ForeColor = System.Drawing.Color.Red
        Me.ReturnAmt.Location = New System.Drawing.Point(262, 131)
        Me.ReturnAmt.Name = "ReturnAmt"
        Me.ReturnAmt.ReadOnly = True
        Me.ReturnAmt.Size = New System.Drawing.Size(78, 33)
        Me.ReturnAmt.TabIndex = 109
        Me.ReturnAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(341, 58)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(29, 24)
        Me.Label19.TabIndex = 108
        Me.Label19.Text = "元"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(200, 58)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 24)
        Me.Label20.TabIndex = 107
        Me.Label20.Text = "付款:"
        '
        'NowPaidAmt
        '
        Me.NowPaidAmt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.NowPaidAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NowPaidAmt.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NowPaidAmt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NowPaidAmt.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.NowPaidAmt.Location = New System.Drawing.Point(262, 53)
        Me.NowPaidAmt.Name = "NowPaidAmt"
        Me.NowPaidAmt.ReadOnly = True
        Me.NowPaidAmt.Size = New System.Drawing.Size(78, 33)
        Me.NowPaidAmt.TabIndex = 106
        Me.NowPaidAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(341, 97)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(29, 24)
        Me.Label17.TabIndex = 105
        Me.Label17.Text = "元"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(200, 99)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 24)
        Me.Label18.TabIndex = 104
        Me.Label18.Text = "折扣:"
        '
        'DiscountAmt
        '
        Me.DiscountAmt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.DiscountAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DiscountAmt.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.DiscountAmt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DiscountAmt.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.DiscountAmt.Location = New System.Drawing.Point(262, 92)
        Me.DiscountAmt.Name = "DiscountAmt"
        Me.DiscountAmt.ReadOnly = True
        Me.DiscountAmt.Size = New System.Drawing.Size(78, 33)
        Me.DiscountAmt.TabIndex = 103
        Me.DiscountAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(12, 136)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 24)
        Me.Label16.TabIndex = 102
        Me.Label16.Text = "找零:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(149, 136)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(29, 24)
        Me.Label15.TabIndex = 101
        Me.Label15.Text = "元"
        '
        'ChangeAmt
        '
        Me.ChangeAmt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ChangeAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ChangeAmt.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ChangeAmt.ForeColor = System.Drawing.Color.Red
        Me.ChangeAmt.Location = New System.Drawing.Point(69, 131)
        Me.ChangeAmt.Name = "ChangeAmt"
        Me.ChangeAmt.ReadOnly = True
        Me.ChangeAmt.Size = New System.Drawing.Size(78, 33)
        Me.ChangeAmt.TabIndex = 100
        Me.ChangeAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(149, 58)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 24)
        Me.Label14.TabIndex = 99
        Me.Label14.Text = "元"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(12, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 24)
        Me.Label13.TabIndex = 98
        Me.Label13.Text = "已付:"
        '
        'PaidAmt
        '
        Me.PaidAmt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PaidAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PaidAmt.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.PaidAmt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PaidAmt.Location = New System.Drawing.Point(69, 53)
        Me.PaidAmt.Name = "PaidAmt"
        Me.PaidAmt.ReadOnly = True
        Me.PaidAmt.Size = New System.Drawing.Size(78, 33)
        Me.PaidAmt.TabIndex = 97
        Me.PaidAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(149, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 24)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "元"
        '
        'TotalAmt
        '
        Me.TotalAmt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TotalAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalAmt.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TotalAmt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TotalAmt.Location = New System.Drawing.Point(69, 92)
        Me.TotalAmt.Name = "TotalAmt"
        Me.TotalAmt.ReadOnly = True
        Me.TotalAmt.Size = New System.Drawing.Size(78, 33)
        Me.TotalAmt.TabIndex = 95
        Me.TotalAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 24)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "總計:"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.Location = New System.Drawing.Point(69, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(271, 38)
        Me.Button1.TabIndex = 115
        Me.Button1.Text = "確定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ShowPriceDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(378, 223)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.NowEmployeeNo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.NowEmployeeName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ReturnAmt)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.NowPaidAmt)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.DiscountAmt)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ChangeAmt)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PaidAmt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TotalAmt)
        Me.Controls.Add(Me.Label6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ShowPriceDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "此次結帳明細"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NowEmployeeNo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents NowEmployeeName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ReturnAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents NowPaidAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents DiscountAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ChangeAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PaidAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TotalAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
