<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Resevation
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
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbReservationID = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnClientID = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbReservationType = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbClientID = New System.Windows.Forms.ComboBox
        Me.cmbRoomID = New System.Windows.Forms.ComboBox
        Me.btnRoomIdInfo = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.DateTimeFrom = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.DateTimeTo = New System.Windows.Forms.DateTimePicker
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ReservationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DSHotel = New HotelSystem.DSHotel
        Me.ReservationTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationTypeTableAdapter = New HotelSystem.DSHotelTableAdapters.ReservationTypeTableAdapter
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DSHotel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ReservationID"
        '
        'cmbReservationID
        '
        Me.cmbReservationID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReservationID.FormattingEnabled = True
        Me.cmbReservationID.Location = New System.Drawing.Point(24, 57)
        Me.cmbReservationID.Name = "cmbReservationID"
        Me.cmbReservationID.Size = New System.Drawing.Size(121, 21)
        Me.cmbReservationID.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ClientID"
        '
        'btnClientID
        '
        Me.btnClientID.Location = New System.Drawing.Point(165, 128)
        Me.btnClientID.Name = "btnClientID"
        Me.btnClientID.Size = New System.Drawing.Size(59, 23)
        Me.btnClientID.TabIndex = 4
        Me.btnClientID.Text = "Get Info"
        Me.btnClientID.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Reservation Type"
        '
        'cmbReservationType
        '
        Me.cmbReservationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReservationType.Enabled = False
        Me.cmbReservationType.FormattingEnabled = True
        Me.cmbReservationType.Location = New System.Drawing.Point(24, 214)
        Me.cmbReservationType.Name = "cmbReservationType"
        Me.cmbReservationType.Size = New System.Drawing.Size(121, 21)
        Me.cmbReservationType.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Room ID"
        '
        'cmbClientID
        '
        Me.cmbClientID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClientID.Enabled = False
        Me.cmbClientID.FormattingEnabled = True
        Me.cmbClientID.Location = New System.Drawing.Point(24, 128)
        Me.cmbClientID.Name = "cmbClientID"
        Me.cmbClientID.Size = New System.Drawing.Size(121, 21)
        Me.cmbClientID.TabIndex = 8
        '
        'cmbRoomID
        '
        Me.cmbRoomID.Enabled = False
        Me.cmbRoomID.FormattingEnabled = True
        Me.cmbRoomID.Location = New System.Drawing.Point(24, 296)
        Me.cmbRoomID.Name = "cmbRoomID"
        Me.cmbRoomID.Size = New System.Drawing.Size(121, 21)
        Me.cmbRoomID.TabIndex = 9
        '
        'btnRoomIdInfo
        '
        Me.btnRoomIdInfo.Location = New System.Drawing.Point(165, 296)
        Me.btnRoomIdInfo.Name = "btnRoomIdInfo"
        Me.btnRoomIdInfo.Size = New System.Drawing.Size(59, 23)
        Me.btnRoomIdInfo.TabIndex = 10
        Me.btnRoomIdInfo.Text = "Get Info"
        Me.btnRoomIdInfo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 339)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "From"
        '
        'DateTimeFrom
        '
        Me.DateTimeFrom.Enabled = False
        Me.DateTimeFrom.Location = New System.Drawing.Point(24, 369)
        Me.DateTimeFrom.Name = "DateTimeFrom"
        Me.DateTimeFrom.Size = New System.Drawing.Size(200, 20)
        Me.DateTimeFrom.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 413)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "To"
        '
        'DateTimeTo
        '
        Me.DateTimeTo.Enabled = False
        Me.DateTimeTo.Location = New System.Drawing.Point(24, 439)
        Me.DateTimeTo.Name = "DateTimeTo"
        Me.DateTimeTo.Size = New System.Drawing.Size(200, 20)
        Me.DateTimeTo.TabIndex = 14
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReservationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(345, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReservationToolStripMenuItem
        '
        Me.ReservationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem, Me.AddToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ReservationToolStripMenuItem.Name = "ReservationToolStripMenuItem"
        Me.ReservationToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.ReservationToolStripMenuItem.Text = "Reservation"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SearchToolStripMenuItem.Text = "Search"
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
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'DSHotel
        '
        Me.DSHotel.DataSetName = "DSHotel"
        Me.DSHotel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReservationTypeBindingSource
        '
        Me.ReservationTypeBindingSource.DataMember = "ReservationType"
        Me.ReservationTypeBindingSource.DataSource = Me.DSHotel
        '
        'ReservationTypeTableAdapter
        '
        Me.ReservationTypeTableAdapter.ClearBeforeFill = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(242, 200)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Sava"
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(242, 246)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'Resevation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 466)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.DateTimeTo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateTimeFrom)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnRoomIdInfo)
        Me.Controls.Add(Me.cmbRoomID)
        Me.Controls.Add(Me.cmbClientID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbReservationType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnClientID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbReservationID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Resevation"
        Me.Text = "Resevation"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DSHotel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbReservationID As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClientID As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbReservationType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbClientID As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRoomID As System.Windows.Forms.ComboBox
    Friend WithEvents btnRoomIdInfo As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimeFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateTimeTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ReservationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DSHotel As HotelSystem.DSHotel
    Friend WithEvents ReservationTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReservationTypeTableAdapter As HotelSystem.DSHotelTableAdapters.ReservationTypeTableAdapter
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
