<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Room
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbRoomID = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.NumericUpDownBed = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtPricePerNight = New System.Windows.Forms.TextBox
        Me.checkbxEnable = New System.Windows.Forms.CheckBox
        Me.NumericUpDownRoomClass = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDownRoomFloor = New System.Windows.Forms.NumericUpDown
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.RoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        CType(Me.NumericUpDownBed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownRoomClass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownRoomFloor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Room ID"
        '
        'cmbRoomID
        '
        Me.cmbRoomID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRoomID.FormattingEnabled = True
        Me.cmbRoomID.Location = New System.Drawing.Point(99, 30)
        Me.cmbRoomID.Name = "cmbRoomID"
        Me.cmbRoomID.Size = New System.Drawing.Size(120, 21)
        Me.cmbRoomID.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Room Floor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Room Class"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Num of Bed"
        '
        'NumericUpDownBed
        '
        Me.NumericUpDownBed.Enabled = False
        Me.NumericUpDownBed.Location = New System.Drawing.Point(99, 152)
        Me.NumericUpDownBed.Name = "NumericUpDownBed"
        Me.NumericUpDownBed.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDownBed.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Price per night"
        '
        'txtPricePerNight
        '
        Me.txtPricePerNight.Enabled = False
        Me.txtPricePerNight.Location = New System.Drawing.Point(99, 189)
        Me.txtPricePerNight.Name = "txtPricePerNight"
        Me.txtPricePerNight.Size = New System.Drawing.Size(100, 20)
        Me.txtPricePerNight.TabIndex = 9
        '
        'checkbxEnable
        '
        Me.checkbxEnable.AutoSize = True
        Me.checkbxEnable.Enabled = False
        Me.checkbxEnable.Location = New System.Drawing.Point(99, 230)
        Me.checkbxEnable.Name = "checkbxEnable"
        Me.checkbxEnable.Size = New System.Drawing.Size(58, 17)
        Me.checkbxEnable.TabIndex = 10
        Me.checkbxEnable.Text = "Enable"
        Me.checkbxEnable.UseVisualStyleBackColor = True
        '
        'NumericUpDownRoomClass
        '
        Me.NumericUpDownRoomClass.Enabled = False
        Me.NumericUpDownRoomClass.Location = New System.Drawing.Point(99, 115)
        Me.NumericUpDownRoomClass.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDownRoomClass.Name = "NumericUpDownRoomClass"
        Me.NumericUpDownRoomClass.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDownRoomClass.TabIndex = 11
        '
        'NumericUpDownRoomFloor
        '
        Me.NumericUpDownRoomFloor.Enabled = False
        Me.NumericUpDownRoomFloor.Location = New System.Drawing.Point(99, 70)
        Me.NumericUpDownRoomFloor.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NumericUpDownRoomFloor.Name = "NumericUpDownRoomFloor"
        Me.NumericUpDownRoomFloor.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDownRoomFloor.TabIndex = 12
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowDrop = True
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 221)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(364, 112)
        Me.DataGridView1.TabIndex = 13
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RoomToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(364, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'RoomToolStripMenuItem
        '
        Me.RoomToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.RoomToolStripMenuItem.Name = "RoomToolStripMenuItem"
        Me.RoomToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.RoomToolStripMenuItem.Text = "Room"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(19, 267)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        Me.btnAdd.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(131, 266)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'Room
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 333)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.NumericUpDownRoomFloor)
        Me.Controls.Add(Me.NumericUpDownRoomClass)
        Me.Controls.Add(Me.checkbxEnable)
        Me.Controls.Add(Me.txtPricePerNight)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NumericUpDownBed)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbRoomID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Room"
        Me.Text = "Room"
        CType(Me.NumericUpDownBed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownRoomClass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownRoomFloor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbRoomID As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownBed As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPricePerNight As System.Windows.Forms.TextBox
    Friend WithEvents checkbxEnable As System.Windows.Forms.CheckBox
    Friend WithEvents NumericUpDownRoomClass As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDownRoomFloor As System.Windows.Forms.NumericUpDown
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents RoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
