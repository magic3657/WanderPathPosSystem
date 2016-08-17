<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form10))
        Me.NowEmployeeNo = New System.Windows.Forms.TextBox()
        Me.NowEmployeeName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.No = New System.Windows.Forms.Button()
        Me.Yes = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChargeAmt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChargeRemark = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ChargeDate = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'NowEmployeeNo
        '
        Me.NowEmployeeNo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.NowEmployeeNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NowEmployeeNo.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NowEmployeeNo.ForeColor = System.Drawing.Color.Red
        Me.NowEmployeeNo.Location = New System.Drawing.Point(119, 118)
        Me.NowEmployeeNo.Name = "NowEmployeeNo"
        Me.NowEmployeeNo.ReadOnly = True
        Me.NowEmployeeNo.Size = New System.Drawing.Size(27, 33)
        Me.NowEmployeeNo.TabIndex = 112
        Me.NowEmployeeNo.Visible = False
        '
        'NowEmployeeName
        '
        Me.NowEmployeeName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.NowEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NowEmployeeName.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NowEmployeeName.ForeColor = System.Drawing.Color.Red
        Me.NowEmployeeName.Location = New System.Drawing.Point(14, 118)
        Me.NowEmployeeName.Name = "NowEmployeeName"
        Me.NowEmployeeName.ReadOnly = True
        Me.NowEmployeeName.Size = New System.Drawing.Size(111, 33)
        Me.NowEmployeeName.TabIndex = 111
        Me.NowEmployeeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NowEmployeeName.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(95, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(390, 24)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "即將進行補帳，請確認以下補帳資訊是否正確"
        '
        'No
        '
        Me.No.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.No.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.No.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.No.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.No.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.No.Location = New System.Drawing.Point(291, 118)
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
        Me.Yes.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Yes.Location = New System.Drawing.Point(151, 118)
        Me.Yes.Name = "Yes"
        Me.Yes.Size = New System.Drawing.Size(138, 33)
        Me.Yes.TabIndex = 108
        Me.Yes.Text = "確定"
        Me.Yes.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(432, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 24)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "補帳金額"
        '
        'ChargeAmt
        '
        Me.ChargeAmt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ChargeAmt.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ChargeAmt.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ChargeAmt.Location = New System.Drawing.Point(434, 76)
        Me.ChargeAmt.Name = "ChargeAmt"
        Me.ChargeAmt.ReadOnly = True
        Me.ChargeAmt.Size = New System.Drawing.Size(98, 33)
        Me.ChargeAmt.TabIndex = 106
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(148, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 24)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "補帳原因"
        '
        'ChargeRemark
        '
        Me.ChargeRemark.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ChargeRemark.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ChargeRemark.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.ChargeRemark.Location = New System.Drawing.Point(151, 76)
        Me.ChargeRemark.Multiline = True
        Me.ChargeRemark.Name = "ChargeRemark"
        Me.ChargeRemark.ReadOnly = True
        Me.ChargeRemark.Size = New System.Drawing.Size(278, 33)
        Me.ChargeRemark.TabIndex = 104
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 24)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "補帳/統計日期"
        '
        'ChargeDate
        '
        Me.ChargeDate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ChargeDate.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ChargeDate.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ChargeDate.Location = New System.Drawing.Point(14, 76)
        Me.ChargeDate.Name = "ChargeDate"
        Me.ChargeDate.ReadOnly = True
        Me.ChargeDate.Size = New System.Drawing.Size(132, 33)
        Me.ChargeDate.TabIndex = 102
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(547, 165)
        Me.ControlBox = False
        Me.Controls.Add(Me.NowEmployeeNo)
        Me.Controls.Add(Me.NowEmployeeName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.No)
        Me.Controls.Add(Me.Yes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ChargeAmt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChargeRemark)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ChargeDate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form10"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "補帳資訊確認"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NowEmployeeNo As System.Windows.Forms.TextBox
    Friend WithEvents NowEmployeeName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents No As System.Windows.Forms.Button
    Friend WithEvents Yes As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ChargeAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChargeRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ChargeDate As System.Windows.Forms.TextBox
End Class
