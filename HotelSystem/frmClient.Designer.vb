<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClient
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
        Me.cmbClientID = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCCN = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbNationality = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.DateTimeBirthDate = New System.Windows.Forms.DateTimePicker
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.lblStatus = New System.Windows.Forms.Label
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btdEdit = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ClientID"
        '
        'cmbClientID
        '
        Me.cmbClientID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClientID.FormattingEnabled = True
        Me.cmbClientID.Location = New System.Drawing.Point(15, 72)
        Me.cmbClientID.Name = "cmbClientID"
        Me.cmbClientID.Size = New System.Drawing.Size(121, 21)
        Me.cmbClientID.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(15, 150)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CCN"
        '
        'txtCCN
        '
        Me.txtCCN.Enabled = False
        Me.txtCCN.Location = New System.Drawing.Point(18, 222)
        Me.txtCCN.Name = "txtCCN"
        Me.txtCCN.Size = New System.Drawing.Size(100, 20)
        Me.txtCCN.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nationality"
        '
        'cmbNationality
        '
        Me.cmbNationality.Enabled = False
        Me.cmbNationality.FormattingEnabled = True
        Me.cmbNationality.Location = New System.Drawing.Point(15, 293)
        Me.cmbNationality.Name = "cmbNationality"
        Me.cmbNationality.Size = New System.Drawing.Size(121, 21)
        Me.cmbNationality.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 325)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Birthdate"
        '
        'DateTimeBirthDate
        '
        Me.DateTimeBirthDate.Enabled = False
        Me.DateTimeBirthDate.Location = New System.Drawing.Point(15, 355)
        Me.DateTimeBirthDate.Name = "DateTimeBirthDate"
        Me.DateTimeBirthDate.Size = New System.Drawing.Size(200, 20)
        Me.DateTimeBirthDate.TabIndex = 12
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(316, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'ClientToolStripMenuItem
        '
        Me.ClientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ClientToolStripMenuItem.Name = "ClientToolStripMenuItem"
        Me.ClientToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ClientToolStripMenuItem.Text = "Client"
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 390)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.Enabled = False
        Me.txtAddress.Location = New System.Drawing.Point(15, 422)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(289, 54)
        Me.txtAddress.TabIndex = 15
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(111, 9)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(139, 42)
        Me.lblStatus.TabIndex = 16
        Me.lblStatus.Text = "Clients"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(229, 291)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        Me.btnAdd.Visible = False
        '
        'btdEdit
        '
        Me.btdEdit.Location = New System.Drawing.Point(229, 256)
        Me.btdEdit.Name = "btdEdit"
        Me.btdEdit.Size = New System.Drawing.Size(75, 23)
        Me.btdEdit.TabIndex = 18
        Me.btdEdit.Text = "Save"
        Me.btdEdit.UseVisualStyleBackColor = True
        Me.btdEdit.Visible = False
        '
        'frmClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 479)
        Me.Controls.Add(Me.btdEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateTimeBirthDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbNationality)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCCN)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbClientID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmClient"
        Me.Text = "frmClient"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbClientID As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCCN As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbNationality As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimeBirthDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ClientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btdEdit As System.Windows.Forms.Button
End Class
