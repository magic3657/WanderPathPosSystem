<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Me.CheckCharge = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.ConfirmStatis = New System.Windows.Forms.Button()
        Me.ConfirmFill = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChargeAmt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChargeRemark = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ChargeDate = New System.Windows.Forms.TextBox()
        Me.NowEmployeeNo = New System.Windows.Forms.TextBox()
        Me.NowEmployeeName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CheckCharge
        '
        Me.CheckCharge.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CheckCharge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CheckCharge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.CheckCharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckCharge.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckCharge.ForeColor = System.Drawing.Color.Black
        Me.CheckCharge.Location = New System.Drawing.Point(326, 82)
        Me.CheckCharge.Name = "CheckCharge"
        Me.CheckCharge.Size = New System.Drawing.Size(98, 33)
        Me.CheckCharge.TabIndex = 108
        Me.CheckCharge.Text = "查詢帳款"
        Me.CheckCharge.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Cancel.Location = New System.Drawing.Point(430, 159)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(98, 33)
        Me.Cancel.TabIndex = 107
        Me.Cancel.Text = "離        開"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'ConfirmStatis
        '
        Me.ConfirmStatis.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ConfirmStatis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ConfirmStatis.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ConfirmStatis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConfirmStatis.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ConfirmStatis.Location = New System.Drawing.Point(430, 120)
        Me.ConfirmStatis.Name = "ConfirmStatis"
        Me.ConfirmStatis.Size = New System.Drawing.Size(98, 33)
        Me.ConfirmStatis.TabIndex = 106
        Me.ConfirmStatis.Text = "確認統計"
        Me.ConfirmStatis.UseVisualStyleBackColor = True
        '
        'ConfirmFill
        '
        Me.ConfirmFill.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ConfirmFill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ConfirmFill.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ConfirmFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConfirmFill.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ConfirmFill.Location = New System.Drawing.Point(430, 82)
        Me.ConfirmFill.Name = "ConfirmFill"
        Me.ConfirmFill.Size = New System.Drawing.Size(98, 33)
        Me.ConfirmFill.TabIndex = 105
        Me.ConfirmFill.Text = "確認補帳"
        Me.ConfirmFill.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(429, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 24)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "補帳金額"
        '
        'ChargeAmt
        '
        Me.ChargeAmt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ChargeAmt.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ChargeAmt.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ChargeAmt.Location = New System.Drawing.Point(430, 43)
        Me.ChargeAmt.Name = "ChargeAmt"
        Me.ChargeAmt.Size = New System.Drawing.Size(98, 33)
        Me.ChargeAmt.TabIndex = 103
        Me.ChargeAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(144, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 24)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "補帳原因"
        '
        'ChargeRemark
        '
        Me.ChargeRemark.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ChargeRemark.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ChargeRemark.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.ChargeRemark.Location = New System.Drawing.Point(147, 43)
        Me.ChargeRemark.Multiline = True
        Me.ChargeRemark.Name = "ChargeRemark"
        Me.ChargeRemark.Size = New System.Drawing.Size(278, 33)
        Me.ChargeRemark.TabIndex = 101
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 24)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "補帳/統計日期"
        '
        'ChargeDate
        '
        Me.ChargeDate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ChargeDate.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ChargeDate.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ChargeDate.Location = New System.Drawing.Point(9, 43)
        Me.ChargeDate.Name = "ChargeDate"
        Me.ChargeDate.Size = New System.Drawing.Size(132, 33)
        Me.ChargeDate.TabIndex = 99
        Me.ChargeDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NowEmployeeNo
        '
        Me.NowEmployeeNo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.NowEmployeeNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NowEmployeeNo.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NowEmployeeNo.ForeColor = System.Drawing.Color.Red
        Me.NowEmployeeNo.Location = New System.Drawing.Point(130, 159)
        Me.NowEmployeeNo.Name = "NowEmployeeNo"
        Me.NowEmployeeNo.ReadOnly = True
        Me.NowEmployeeNo.Size = New System.Drawing.Size(27, 33)
        Me.NowEmployeeNo.TabIndex = 111
        Me.NowEmployeeNo.Visible = False
        '
        'NowEmployeeName
        '
        Me.NowEmployeeName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.NowEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NowEmployeeName.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NowEmployeeName.ForeColor = System.Drawing.Color.Red
        Me.NowEmployeeName.Location = New System.Drawing.Point(9, 159)
        Me.NowEmployeeName.Name = "NowEmployeeName"
        Me.NowEmployeeName.ReadOnly = True
        Me.NowEmployeeName.Size = New System.Drawing.Size(122, 33)
        Me.NowEmployeeName.TabIndex = 110
        Me.NowEmployeeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NowEmployeeName.Visible = False
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(542, 199)
        Me.Controls.Add(Me.NowEmployeeNo)
        Me.Controls.Add(Me.NowEmployeeName)
        Me.Controls.Add(Me.CheckCharge)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.ConfirmStatis)
        Me.Controls.Add(Me.ConfirmFill)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ChargeAmt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChargeRemark)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ChargeDate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Form9"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "[ 散步路徑 補帳 / 統計 系統 ]"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckCharge As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents ConfirmStatis As System.Windows.Forms.Button
    Friend WithEvents ConfirmFill As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ChargeAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChargeRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ChargeDate As System.Windows.Forms.TextBox
    Friend WithEvents NowEmployeeNo As System.Windows.Forms.TextBox
    Friend WithEvents NowEmployeeName As System.Windows.Forms.TextBox
End Class
