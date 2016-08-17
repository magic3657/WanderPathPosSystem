<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.ShowDataView = New System.Windows.Forms.DataGridView()
        Me.emp_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.h_tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mobile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.take_office = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.leave_flag = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.create_datetime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.create_clerk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modify_datetime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modify_clerk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaveData = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        CType(Me.ShowDataView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShowDataView
        '
        Me.ShowDataView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.ShowDataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ShowDataView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ShowDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ShowDataView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.emp_no, Me.emp_name, Me.password, Me.id_no, Me.h_tel, Me.mobile, Me.address, Me.take_office, Me.leave_flag, Me.create_datetime, Me.create_clerk, Me.modify_datetime, Me.modify_clerk})
        Me.ShowDataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.ShowDataView.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.ShowDataView.Location = New System.Drawing.Point(12, 44)
        Me.ShowDataView.Name = "ShowDataView"
        Me.ShowDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle11.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ShowDataView.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.ShowDataView.RowTemplate.Height = 24
        Me.ShowDataView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ShowDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ShowDataView.Size = New System.Drawing.Size(943, 198)
        Me.ShowDataView.TabIndex = 86
        '
        'emp_no
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.emp_no.DefaultCellStyle = DataGridViewCellStyle2
        Me.emp_no.HeaderText = "員工帳號"
        Me.emp_no.Name = "emp_no"
        '
        'emp_name
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.emp_name.DefaultCellStyle = DataGridViewCellStyle3
        Me.emp_name.HeaderText = "員工姓名"
        Me.emp_name.Name = "emp_name"
        '
        'password
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.password.DefaultCellStyle = DataGridViewCellStyle4
        Me.password.HeaderText = "員工密碼"
        Me.password.Name = "password"
        '
        'id_no
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.id_no.DefaultCellStyle = DataGridViewCellStyle5
        Me.id_no.HeaderText = "身份證"
        Me.id_no.Name = "id_no"
        '
        'h_tel
        '
        DataGridViewCellStyle6.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.h_tel.DefaultCellStyle = DataGridViewCellStyle6
        Me.h_tel.HeaderText = "家用電話"
        Me.h_tel.Name = "h_tel"
        '
        'mobile
        '
        DataGridViewCellStyle7.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.mobile.DefaultCellStyle = DataGridViewCellStyle7
        Me.mobile.HeaderText = "手機號碼"
        Me.mobile.Name = "mobile"
        '
        'address
        '
        DataGridViewCellStyle8.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.address.DefaultCellStyle = DataGridViewCellStyle8
        Me.address.HeaderText = "詳細住址"
        Me.address.Name = "address"
        '
        'take_office
        '
        DataGridViewCellStyle9.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.take_office.DefaultCellStyle = DataGridViewCellStyle9
        Me.take_office.HeaderText = "到職日期"
        Me.take_office.Name = "take_office"
        '
        'leave_flag
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle10.NullValue = False
        Me.leave_flag.DefaultCellStyle = DataGridViewCellStyle10
        Me.leave_flag.FalseValue = "N"
        Me.leave_flag.HeaderText = "離職否"
        Me.leave_flag.IndeterminateValue = "False"
        Me.leave_flag.Name = "leave_flag"
        Me.leave_flag.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.leave_flag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.leave_flag.TrueValue = "Y"
        '
        'create_datetime
        '
        Me.create_datetime.HeaderText = "建檔日期時間"
        Me.create_datetime.Name = "create_datetime"
        Me.create_datetime.ReadOnly = True
        Me.create_datetime.Visible = False
        '
        'create_clerk
        '
        Me.create_clerk.HeaderText = "建檔人員"
        Me.create_clerk.Name = "create_clerk"
        Me.create_clerk.ReadOnly = True
        Me.create_clerk.Visible = False
        '
        'modify_datetime
        '
        Me.modify_datetime.HeaderText = "修改日期時間"
        Me.modify_datetime.Name = "modify_datetime"
        Me.modify_datetime.ReadOnly = True
        Me.modify_datetime.Visible = False
        '
        'modify_clerk
        '
        Me.modify_clerk.HeaderText = "修改人員"
        Me.modify_clerk.Name = "modify_clerk"
        Me.modify_clerk.ReadOnly = True
        Me.modify_clerk.Visible = False
        '
        'SaveData
        '
        Me.SaveData.BackColor = System.Drawing.Color.Transparent
        Me.SaveData.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SaveData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SaveData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.SaveData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveData.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SaveData.Location = New System.Drawing.Point(12, 12)
        Me.SaveData.Name = "SaveData"
        Me.SaveData.Size = New System.Drawing.Size(98, 33)
        Me.SaveData.TabIndex = 87
        Me.SaveData.Text = "存檔"
        Me.SaveData.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Cancel.Location = New System.Drawing.Point(116, 12)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(98, 33)
        Me.Cancel.TabIndex = 88
        Me.Cancel.Text = "回主畫面"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(968, 252)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.SaveData)
        Me.Controls.Add(Me.ShowDataView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "員工基本資料維護"
        CType(Me.ShowDataView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ShowDataView As System.Windows.Forms.DataGridView
    Friend WithEvents SaveData As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents emp_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents emp_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents password As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents h_tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mobile As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents take_office As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents leave_flag As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents create_datetime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents create_clerk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modify_datetime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modify_clerk As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
