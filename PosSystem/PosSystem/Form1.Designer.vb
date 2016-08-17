<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.EmpName = New System.Windows.Forms.TextBox()
        Me.EmpPassword = New System.Windows.Forms.TextBox()
        Me.Login = New System.Windows.Forms.Button()
        Me.CreateEmp = New System.Windows.Forms.Button()
        Me.CloseProgram = New System.Windows.Forms.Button()
        Me.EmpNo = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(26, 40)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 24)
        Me.Label20.TabIndex = 77
        Me.Label20.Text = "帳號:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(26, 77)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 24)
        Me.Label18.TabIndex = 75
        Me.Label18.Text = "密碼:"
        '
        'EmpName
        '
        Me.EmpName.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.EmpName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EmpName.Location = New System.Drawing.Point(346, 35)
        Me.EmpName.Name = "EmpName"
        Me.EmpName.Size = New System.Drawing.Size(20, 33)
        Me.EmpName.TabIndex = 81
        Me.EmpName.Visible = False
        '
        'EmpPassword
        '
        Me.EmpPassword.BackColor = System.Drawing.Color.White
        Me.EmpPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmpPassword.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.EmpPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EmpPassword.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.EmpPassword.Location = New System.Drawing.Point(82, 73)
        Me.EmpPassword.Name = "EmpPassword"
        Me.EmpPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.EmpPassword.Size = New System.Drawing.Size(265, 33)
        Me.EmpPassword.TabIndex = 82
        '
        'Login
        '
        Me.Login.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Login.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Login.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Login.Location = New System.Drawing.Point(82, 110)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(265, 27)
        Me.Login.TabIndex = 83
        Me.Login.Text = "登入"
        Me.Login.UseVisualStyleBackColor = False
        '
        'CreateEmp
        '
        Me.CreateEmp.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CreateEmp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CreateEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.CreateEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateEmp.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CreateEmp.Location = New System.Drawing.Point(82, 141)
        Me.CreateEmp.Name = "CreateEmp"
        Me.CreateEmp.Size = New System.Drawing.Size(265, 27)
        Me.CreateEmp.TabIndex = 84
        Me.CreateEmp.Text = "建立帳號"
        Me.CreateEmp.UseVisualStyleBackColor = True
        '
        'CloseProgram
        '
        Me.CloseProgram.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CloseProgram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CloseProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.CloseProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseProgram.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CloseProgram.Location = New System.Drawing.Point(82, 172)
        Me.CloseProgram.Name = "CloseProgram"
        Me.CloseProgram.Size = New System.Drawing.Size(265, 27)
        Me.CloseProgram.TabIndex = 85
        Me.CloseProgram.Text = "離開"
        Me.CloseProgram.UseVisualStyleBackColor = True
        '
        'EmpNo
        '
        Me.EmpNo.BackColor = System.Drawing.SystemColors.HighlightText
        Me.EmpNo.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.EmpNo.FormattingEnabled = True
        Me.EmpNo.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.EmpNo.Location = New System.Drawing.Point(82, 36)
        Me.EmpNo.Name = "EmpNo"
        Me.EmpNo.Size = New System.Drawing.Size(265, 32)
        Me.EmpNo.TabIndex = 107
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(393, 224)
        Me.ControlBox = False
        Me.Controls.Add(Me.EmpNo)
        Me.Controls.Add(Me.CloseProgram)
        Me.Controls.Add(Me.CreateEmp)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.EmpPassword)
        Me.Controls.Add(Me.EmpName)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label18)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "請登入 - [ 散步路徑收驚系統 ]"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents EmpName As System.Windows.Forms.TextBox
    Friend WithEvents EmpPassword As System.Windows.Forms.TextBox
    Friend WithEvents Login As System.Windows.Forms.Button
    Friend WithEvents CreateEmp As System.Windows.Forms.Button
    Friend WithEvents CloseProgram As System.Windows.Forms.Button
    Friend WithEvents EmpNo As System.Windows.Forms.ComboBox

End Class
