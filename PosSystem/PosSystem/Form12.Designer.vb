<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Seat
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Seat))
        Me.A1 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChangeSeat = New System.Windows.Forms.ToolStripComboBox()
        Me.ClearSeat = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterOrder = New System.Windows.Forms.ToolStripMenuItem()
        Me.A2 = New System.Windows.Forms.Button()
        Me.A3 = New System.Windows.Forms.Button()
        Me.A4 = New System.Windows.Forms.Button()
        Me.A5 = New System.Windows.Forms.Button()
        Me.B1 = New System.Windows.Forms.Button()
        Me.B2 = New System.Windows.Forms.Button()
        Me.C2 = New System.Windows.Forms.Button()
        Me.C1 = New System.Windows.Forms.Button()
        Me.C3 = New System.Windows.Forms.Button()
        Me.R1 = New System.Windows.Forms.Button()
        Me.R2 = New System.Windows.Forms.Button()
        Me.R3 = New System.Windows.Forms.Button()
        Me.L1 = New System.Windows.Forms.Button()
        Me.L2 = New System.Windows.Forms.Button()
        Me.L3 = New System.Windows.Forms.Button()
        Me.ColorClear = New System.Windows.Forms.Button()
        Me.ColorUnpaid = New System.Windows.Forms.Button()
        Me.ColorPaid = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CloseProgram = New System.Windows.Forms.Button()
        Me.ModifyOrder = New System.Windows.Forms.Button()
        Me.ItemMaintain = New System.Windows.Forms.Button()
        Me.EmployeeMaintain = New System.Windows.Forms.Button()
        Me.ExecutePosCharge = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ChangePassword = New System.Windows.Forms.TextBox()
        Me.ChangeEmpNo = New System.Windows.Forms.ComboBox()
        Me.NowEmployeeNo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NowEmployeeName = New System.Windows.Forms.TextBox()
        Me.O = New System.Windows.Forms.Button()
        Me.OpenChangeSeat = New System.Windows.Forms.Button()
        Me.CancelChangeSeat = New System.Windows.Forms.Button()
        Me.WorkOffCharge = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'A1
        '
        Me.A1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.A1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.A1.FlatAppearance.BorderSize = 3
        Me.A1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.A1.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.A1.Location = New System.Drawing.Point(865, 36)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(75, 71)
        Me.A1.TabIndex = 1
        Me.A1.Text = "A1"
        Me.A1.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.AutoSize = False
        Me.ContextMenuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Microsoft JhengHei", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeSeat, Me.ClearSeat, Me.EnterOrder})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(120, 40)
        '
        'ChangeSeat
        '
        Me.ChangeSeat.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ChangeSeat.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ChangeSeat.Name = "ChangeSeat"
        Me.ChangeSeat.Size = New System.Drawing.Size(75, 32)
        '
        'ClearSeat
        '
        Me.ClearSeat.Name = "ClearSeat"
        Me.ClearSeat.Size = New System.Drawing.Size(135, 28)
        Me.ClearSeat.Text = "清位"
        Me.ClearSeat.Visible = False
        '
        'EnterOrder
        '
        Me.EnterOrder.Name = "EnterOrder"
        Me.EnterOrder.Size = New System.Drawing.Size(135, 28)
        Me.EnterOrder.Text = "點餐"
        Me.EnterOrder.Visible = False
        '
        'A2
        '
        Me.A2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.A2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.A2.FlatAppearance.BorderSize = 3
        Me.A2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.A2.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.A2.Location = New System.Drawing.Point(757, 36)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(75, 71)
        Me.A2.TabIndex = 2
        Me.A2.Text = "A2"
        Me.A2.UseVisualStyleBackColor = True
        '
        'A3
        '
        Me.A3.BackColor = System.Drawing.SystemColors.HighlightText
        Me.A3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.A3.FlatAppearance.BorderSize = 3
        Me.A3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.A3.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.A3.Location = New System.Drawing.Point(649, 36)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(75, 71)
        Me.A3.TabIndex = 3
        Me.A3.Text = "A3"
        Me.A3.UseVisualStyleBackColor = True
        '
        'A4
        '
        Me.A4.BackColor = System.Drawing.SystemColors.HighlightText
        Me.A4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.A4.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.A4.FlatAppearance.BorderSize = 3
        Me.A4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.A4.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.A4.Location = New System.Drawing.Point(541, 36)
        Me.A4.Name = "A4"
        Me.A4.Size = New System.Drawing.Size(75, 71)
        Me.A4.TabIndex = 4
        Me.A4.Text = "A4"
        Me.A4.UseVisualStyleBackColor = False
        '
        'A5
        '
        Me.A5.BackColor = System.Drawing.SystemColors.HighlightText
        Me.A5.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.A5.FlatAppearance.BorderSize = 3
        Me.A5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.A5.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.A5.Location = New System.Drawing.Point(433, 36)
        Me.A5.Name = "A5"
        Me.A5.Size = New System.Drawing.Size(75, 71)
        Me.A5.TabIndex = 5
        Me.A5.Text = "A5"
        Me.A5.UseVisualStyleBackColor = True
        '
        'B1
        '
        Me.B1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.B1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.B1.FlatAppearance.BorderSize = 3
        Me.B1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B1.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.B1.Location = New System.Drawing.Point(541, 149)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(75, 71)
        Me.B1.TabIndex = 6
        Me.B1.Text = "B1"
        Me.B1.UseVisualStyleBackColor = True
        '
        'B2
        '
        Me.B2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.B2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.B2.FlatAppearance.BorderSize = 3
        Me.B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B2.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.B2.Location = New System.Drawing.Point(433, 149)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(75, 71)
        Me.B2.TabIndex = 7
        Me.B2.Text = "B2"
        Me.B2.UseVisualStyleBackColor = True
        '
        'C2
        '
        Me.C2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.C2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.C2.FlatAppearance.BorderSize = 3
        Me.C2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C2.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.C2.Location = New System.Drawing.Point(541, 262)
        Me.C2.Name = "C2"
        Me.C2.Size = New System.Drawing.Size(75, 71)
        Me.C2.TabIndex = 8
        Me.C2.Text = "C2"
        Me.C2.UseVisualStyleBackColor = True
        '
        'C1
        '
        Me.C1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.C1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.C1.FlatAppearance.BorderSize = 3
        Me.C1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C1.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.C1.Location = New System.Drawing.Point(649, 262)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(75, 71)
        Me.C1.TabIndex = 9
        Me.C1.Text = "C1"
        Me.C1.UseVisualStyleBackColor = True
        '
        'C3
        '
        Me.C3.BackColor = System.Drawing.SystemColors.HighlightText
        Me.C3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.C3.FlatAppearance.BorderSize = 3
        Me.C3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.C3.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.C3.Location = New System.Drawing.Point(433, 262)
        Me.C3.Name = "C3"
        Me.C3.Size = New System.Drawing.Size(75, 71)
        Me.C3.TabIndex = 10
        Me.C3.Text = "C3"
        Me.C3.UseVisualStyleBackColor = True
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.R1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.R1.FlatAppearance.BorderSize = 3
        Me.R1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.R1.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.R1.Location = New System.Drawing.Point(278, 36)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(75, 71)
        Me.R1.TabIndex = 11
        Me.R1.Text = "右1"
        Me.R1.UseVisualStyleBackColor = True
        '
        'R2
        '
        Me.R2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.R2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.R2.FlatAppearance.BorderSize = 3
        Me.R2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.R2.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.R2.Location = New System.Drawing.Point(170, 36)
        Me.R2.Name = "R2"
        Me.R2.Size = New System.Drawing.Size(75, 71)
        Me.R2.TabIndex = 12
        Me.R2.Text = "右2"
        Me.R2.UseVisualStyleBackColor = True
        '
        'R3
        '
        Me.R3.BackColor = System.Drawing.SystemColors.HighlightText
        Me.R3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.R3.FlatAppearance.BorderSize = 3
        Me.R3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.R3.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.R3.Location = New System.Drawing.Point(62, 36)
        Me.R3.Name = "R3"
        Me.R3.Size = New System.Drawing.Size(75, 71)
        Me.R3.TabIndex = 13
        Me.R3.Text = "右3"
        Me.R3.UseVisualStyleBackColor = True
        '
        'L1
        '
        Me.L1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.L1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.L1.FlatAppearance.BorderSize = 3
        Me.L1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.L1.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.L1.Location = New System.Drawing.Point(278, 262)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(75, 71)
        Me.L1.TabIndex = 14
        Me.L1.Text = "左1"
        Me.L1.UseVisualStyleBackColor = True
        '
        'L2
        '
        Me.L2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.L2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.L2.FlatAppearance.BorderSize = 3
        Me.L2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.L2.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.L2.Location = New System.Drawing.Point(170, 262)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(75, 71)
        Me.L2.TabIndex = 15
        Me.L2.Text = "左2"
        Me.L2.UseVisualStyleBackColor = True
        '
        'L3
        '
        Me.L3.BackColor = System.Drawing.SystemColors.HighlightText
        Me.L3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.L3.FlatAppearance.BorderSize = 3
        Me.L3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.L3.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.L3.Location = New System.Drawing.Point(62, 262)
        Me.L3.Name = "L3"
        Me.L3.Size = New System.Drawing.Size(75, 71)
        Me.L3.TabIndex = 16
        Me.L3.Text = "左3"
        Me.L3.UseVisualStyleBackColor = True
        '
        'ColorClear
        '
        Me.ColorClear.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ColorClear.FlatAppearance.BorderSize = 0
        Me.ColorClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ColorClear.Location = New System.Drawing.Point(64, 375)
        Me.ColorClear.Name = "ColorClear"
        Me.ColorClear.Size = New System.Drawing.Size(23, 23)
        Me.ColorClear.TabIndex = 18
        Me.ColorClear.UseVisualStyleBackColor = False
        '
        'ColorUnpaid
        '
        Me.ColorUnpaid.BackColor = System.Drawing.Color.Crimson
        Me.ColorUnpaid.FlatAppearance.BorderSize = 0
        Me.ColorUnpaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ColorUnpaid.Location = New System.Drawing.Point(64, 404)
        Me.ColorUnpaid.Name = "ColorUnpaid"
        Me.ColorUnpaid.Size = New System.Drawing.Size(23, 23)
        Me.ColorUnpaid.TabIndex = 19
        Me.ColorUnpaid.UseVisualStyleBackColor = False
        '
        'ColorPaid
        '
        Me.ColorPaid.BackColor = System.Drawing.Color.DodgerBlue
        Me.ColorPaid.FlatAppearance.BorderSize = 0
        Me.ColorPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ColorPaid.Location = New System.Drawing.Point(64, 434)
        Me.ColorPaid.Name = "ColorPaid"
        Me.ColorPaid.Size = New System.Drawing.Size(23, 23)
        Me.ColorPaid.TabIndex = 20
        Me.ColorPaid.UseVisualStyleBackColor = False
        Me.ColorPaid.Visible = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(93, 376)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(54, 19)
        Me.Label24.TabIndex = 114
        Me.Label24.Text = "空座位"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(93, 406)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 19)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "記帳未付"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(93, 436)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 19)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "已付清"
        Me.Label2.Visible = False
        '
        'CloseProgram
        '
        Me.CloseProgram.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CloseProgram.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CloseProgram.FlatAppearance.BorderSize = 3
        Me.CloseProgram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CloseProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.CloseProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseProgram.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CloseProgram.ForeColor = System.Drawing.Color.Black
        Me.CloseProgram.Location = New System.Drawing.Point(801, 444)
        Me.CloseProgram.Name = "CloseProgram"
        Me.CloseProgram.Size = New System.Drawing.Size(139, 36)
        Me.CloseProgram.TabIndex = 119
        Me.CloseProgram.Text = "離開系統"
        Me.CloseProgram.UseVisualStyleBackColor = True
        '
        'ModifyOrder
        '
        Me.ModifyOrder.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ModifyOrder.FlatAppearance.BorderSize = 3
        Me.ModifyOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ModifyOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.ModifyOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModifyOrder.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ModifyOrder.ForeColor = System.Drawing.Color.Black
        Me.ModifyOrder.Location = New System.Drawing.Point(801, 345)
        Me.ModifyOrder.Name = "ModifyOrder"
        Me.ModifyOrder.Size = New System.Drawing.Size(139, 36)
        Me.ModifyOrder.TabIndex = 121
        Me.ModifyOrder.Text = "修改訂單"
        Me.ModifyOrder.UseVisualStyleBackColor = True
        '
        'ItemMaintain
        '
        Me.ItemMaintain.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ItemMaintain.FlatAppearance.BorderSize = 3
        Me.ItemMaintain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ItemMaintain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.ItemMaintain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ItemMaintain.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ItemMaintain.ForeColor = System.Drawing.Color.Black
        Me.ItemMaintain.Location = New System.Drawing.Point(801, 378)
        Me.ItemMaintain.Name = "ItemMaintain"
        Me.ItemMaintain.Size = New System.Drawing.Size(139, 36)
        Me.ItemMaintain.TabIndex = 123
        Me.ItemMaintain.Text = "商品維護"
        Me.ItemMaintain.UseVisualStyleBackColor = True
        '
        'EmployeeMaintain
        '
        Me.EmployeeMaintain.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.EmployeeMaintain.FlatAppearance.BorderSize = 3
        Me.EmployeeMaintain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.EmployeeMaintain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.EmployeeMaintain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmployeeMaintain.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.EmployeeMaintain.ForeColor = System.Drawing.Color.Black
        Me.EmployeeMaintain.Location = New System.Drawing.Point(801, 411)
        Me.EmployeeMaintain.Name = "EmployeeMaintain"
        Me.EmployeeMaintain.Size = New System.Drawing.Size(139, 36)
        Me.EmployeeMaintain.TabIndex = 124
        Me.EmployeeMaintain.Text = "員工資料維護"
        Me.EmployeeMaintain.UseVisualStyleBackColor = True
        '
        'ExecutePosCharge
        '
        Me.ExecutePosCharge.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ExecutePosCharge.FlatAppearance.BorderSize = 3
        Me.ExecutePosCharge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ExecutePosCharge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.ExecutePosCharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExecutePosCharge.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ExecutePosCharge.ForeColor = System.Drawing.Color.Black
        Me.ExecutePosCharge.Location = New System.Drawing.Point(801, 246)
        Me.ExecutePosCharge.Name = "ExecutePosCharge"
        Me.ExecutePosCharge.Size = New System.Drawing.Size(139, 36)
        Me.ExecutePosCharge.TabIndex = 125
        Me.ExecutePosCharge.Text = "執行補帳系統"
        Me.ExecutePosCharge.UseVisualStyleBackColor = True
        Me.ExecutePosCharge.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(430, 416)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 21)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "切換使用者:"
        '
        'ChangePassword
        '
        Me.ChangePassword.BackColor = System.Drawing.Color.White
        Me.ChangePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ChangePassword.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ChangePassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ChangePassword.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.ChangePassword.Location = New System.Drawing.Point(524, 448)
        Me.ChangePassword.Name = "ChangePassword"
        Me.ChangePassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ChangePassword.Size = New System.Drawing.Size(200, 33)
        Me.ChangePassword.TabIndex = 127
        Me.ChangePassword.Visible = False
        Me.ChangePassword.WordWrap = False
        '
        'ChangeEmpNo
        '
        Me.ChangeEmpNo.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ChangeEmpNo.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ChangeEmpNo.FormattingEnabled = True
        Me.ChangeEmpNo.Location = New System.Drawing.Point(524, 410)
        Me.ChangeEmpNo.Name = "ChangeEmpNo"
        Me.ChangeEmpNo.Size = New System.Drawing.Size(200, 32)
        Me.ChangeEmpNo.TabIndex = 126
        '
        'NowEmployeeNo
        '
        Me.NowEmployeeNo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.NowEmployeeNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NowEmployeeNo.Font = New System.Drawing.Font("DFKai-SB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NowEmployeeNo.ForeColor = System.Drawing.Color.Red
        Me.NowEmployeeNo.Location = New System.Drawing.Point(723, 371)
        Me.NowEmployeeNo.Name = "NowEmployeeNo"
        Me.NowEmployeeNo.ReadOnly = True
        Me.NowEmployeeNo.Size = New System.Drawing.Size(27, 33)
        Me.NowEmployeeNo.TabIndex = 132
        Me.NowEmployeeNo.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(395, 375)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 24)
        Me.Label10.TabIndex = 131
        Me.Label10.Text = "目前結帳人員:"
        '
        'NowEmployeeName
        '
        Me.NowEmployeeName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.NowEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NowEmployeeName.Font = New System.Drawing.Font("DFKai-SB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.NowEmployeeName.ForeColor = System.Drawing.Color.Red
        Me.NowEmployeeName.Location = New System.Drawing.Point(524, 371)
        Me.NowEmployeeName.Name = "NowEmployeeName"
        Me.NowEmployeeName.ReadOnly = True
        Me.NowEmployeeName.Size = New System.Drawing.Size(200, 33)
        Me.NowEmployeeName.TabIndex = 130
        Me.NowEmployeeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'O
        '
        Me.O.BackColor = System.Drawing.SystemColors.HighlightText
        Me.O.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.O.FlatAppearance.BorderSize = 3
        Me.O.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.O.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.O.Location = New System.Drawing.Point(865, 149)
        Me.O.Name = "O"
        Me.O.Size = New System.Drawing.Size(75, 71)
        Me.O.TabIndex = 133
        Me.O.Text = "外帶"
        Me.O.UseVisualStyleBackColor = True
        '
        'OpenChangeSeat
        '
        Me.OpenChangeSeat.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.OpenChangeSeat.FlatAppearance.BorderSize = 3
        Me.OpenChangeSeat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.OpenChangeSeat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.OpenChangeSeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OpenChangeSeat.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.OpenChangeSeat.ForeColor = System.Drawing.Color.Black
        Me.OpenChangeSeat.Location = New System.Drawing.Point(801, 312)
        Me.OpenChangeSeat.Name = "OpenChangeSeat"
        Me.OpenChangeSeat.Size = New System.Drawing.Size(139, 36)
        Me.OpenChangeSeat.TabIndex = 135
        Me.OpenChangeSeat.Text = "換座位"
        Me.OpenChangeSeat.UseVisualStyleBackColor = True
        '
        'CancelChangeSeat
        '
        Me.CancelChangeSeat.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CancelChangeSeat.FlatAppearance.BorderSize = 3
        Me.CancelChangeSeat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CancelChangeSeat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.CancelChangeSeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelChangeSeat.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CancelChangeSeat.ForeColor = System.Drawing.Color.Black
        Me.CancelChangeSeat.Location = New System.Drawing.Point(801, 279)
        Me.CancelChangeSeat.Name = "CancelChangeSeat"
        Me.CancelChangeSeat.Size = New System.Drawing.Size(139, 36)
        Me.CancelChangeSeat.TabIndex = 136
        Me.CancelChangeSeat.Text = "取消換座位"
        Me.CancelChangeSeat.UseVisualStyleBackColor = True
        '
        'WorkOffCharge
        '
        Me.WorkOffCharge.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.WorkOffCharge.FlatAppearance.BorderSize = 3
        Me.WorkOffCharge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.WorkOffCharge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.WorkOffCharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WorkOffCharge.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.WorkOffCharge.ForeColor = System.Drawing.Color.Black
        Me.WorkOffCharge.Location = New System.Drawing.Point(741, 444)
        Me.WorkOffCharge.Name = "WorkOffCharge"
        Me.WorkOffCharge.Size = New System.Drawing.Size(63, 36)
        Me.WorkOffCharge.TabIndex = 138
        Me.WorkOffCharge.Text = "交班"
        Me.WorkOffCharge.UseVisualStyleBackColor = True
        '
        'Form_Seat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1004, 490)
        Me.Controls.Add(Me.WorkOffCharge)
        Me.Controls.Add(Me.CancelChangeSeat)
        Me.Controls.Add(Me.OpenChangeSeat)
        Me.Controls.Add(Me.O)
        Me.Controls.Add(Me.NowEmployeeNo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.NowEmployeeName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ChangePassword)
        Me.Controls.Add(Me.ChangeEmpNo)
        Me.Controls.Add(Me.ExecutePosCharge)
        Me.Controls.Add(Me.EmployeeMaintain)
        Me.Controls.Add(Me.ItemMaintain)
        Me.Controls.Add(Me.ModifyOrder)
        Me.Controls.Add(Me.CloseProgram)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.ColorPaid)
        Me.Controls.Add(Me.ColorUnpaid)
        Me.Controls.Add(Me.ColorClear)
        Me.Controls.Add(Me.L3)
        Me.Controls.Add(Me.L2)
        Me.Controls.Add(Me.L1)
        Me.Controls.Add(Me.R3)
        Me.Controls.Add(Me.R2)
        Me.Controls.Add(Me.R1)
        Me.Controls.Add(Me.C3)
        Me.Controls.Add(Me.C1)
        Me.Controls.Add(Me.C2)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.A5)
        Me.Controls.Add(Me.A4)
        Me.Controls.Add(Me.A3)
        Me.Controls.Add(Me.A2)
        Me.Controls.Add(Me.A1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Form_Seat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "座位圖"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents A1 As System.Windows.Forms.Button
    Friend WithEvents A2 As System.Windows.Forms.Button
    Friend WithEvents A3 As System.Windows.Forms.Button
    Friend WithEvents A4 As System.Windows.Forms.Button
    Friend WithEvents A5 As System.Windows.Forms.Button
    Friend WithEvents B1 As System.Windows.Forms.Button
    Friend WithEvents B2 As System.Windows.Forms.Button
    Friend WithEvents C2 As System.Windows.Forms.Button
    Friend WithEvents C1 As System.Windows.Forms.Button
    Friend WithEvents C3 As System.Windows.Forms.Button
    Friend WithEvents R1 As System.Windows.Forms.Button
    Friend WithEvents R2 As System.Windows.Forms.Button
    Friend WithEvents R3 As System.Windows.Forms.Button
    Friend WithEvents L1 As System.Windows.Forms.Button
    Friend WithEvents L2 As System.Windows.Forms.Button
    Friend WithEvents L3 As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ClearSeat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnterOrder As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorClear As System.Windows.Forms.Button
    Friend WithEvents ColorUnpaid As System.Windows.Forms.Button
    Friend WithEvents ColorPaid As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CloseProgram As System.Windows.Forms.Button
    Friend WithEvents ModifyOrder As System.Windows.Forms.Button
    Friend WithEvents ItemMaintain As System.Windows.Forms.Button
    Friend WithEvents EmployeeMaintain As System.Windows.Forms.Button
    Friend WithEvents ExecutePosCharge As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ChangePassword As System.Windows.Forms.TextBox
    Friend WithEvents ChangeEmpNo As System.Windows.Forms.ComboBox
    Friend WithEvents NowEmployeeNo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents NowEmployeeName As System.Windows.Forms.TextBox
    Friend WithEvents O As System.Windows.Forms.Button
    Friend WithEvents ChangeSeat As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents OpenChangeSeat As System.Windows.Forms.Button
    Friend WithEvents CancelChangeSeat As System.Windows.Forms.Button
    Friend WithEvents WorkOffCharge As System.Windows.Forms.Button
End Class
