<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReservationOp
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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label3 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPageClass = New System.Windows.Forms.TabPage
        Me.NumericUpDownClass = New System.Windows.Forms.NumericUpDown
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.NumericUpDownBed = New System.Windows.Forms.NumericUpDown
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.txtPice = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.cmbClientID = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.cmbReservatonTybe = New System.Windows.Forms.ComboBox
        Me.btnAddReservation = New System.Windows.Forms.Button
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.Label13 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPageClass.SuspendLayout()
        CType(Me.NumericUpDownClass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.NumericUpDownBed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPageClass)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(510, 174)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.DateTimePicker2)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.DateTimePicker1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(502, 148)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Date"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(87, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 35)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Select Date"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(67, 102)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 3
        Me.DateTimePicker2.Value = New Date(2000, 1, 13, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "To"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(67, 58)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 1
        Me.DateTimePicker1.Value = New Date(1999, 1, 13, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From"
        '
        'TabPageClass
        '
        Me.TabPageClass.Controls.Add(Me.NumericUpDownClass)
        Me.TabPageClass.Controls.Add(Me.Label6)
        Me.TabPageClass.Controls.Add(Me.Label5)
        Me.TabPageClass.Location = New System.Drawing.Point(4, 22)
        Me.TabPageClass.Name = "TabPageClass"
        Me.TabPageClass.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageClass.Size = New System.Drawing.Size(502, 148)
        Me.TabPageClass.TabIndex = 1
        Me.TabPageClass.Text = "Class"
        Me.TabPageClass.UseVisualStyleBackColor = True
        '
        'NumericUpDownClass
        '
        Me.NumericUpDownClass.Location = New System.Drawing.Point(92, 80)
        Me.NumericUpDownClass.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDownClass.Name = "NumericUpDownClass"
        Me.NumericUpDownClass.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDownClass.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Class"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(86, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 35)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Select Class"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.NumericUpDownBed)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(502, 148)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Beds"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'NumericUpDownBed
        '
        Me.NumericUpDownBed.Location = New System.Drawing.Point(103, 79)
        Me.NumericUpDownBed.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDownBed.Name = "NumericUpDownBed"
        Me.NumericUpDownBed.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDownBed.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(97, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(218, 35)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Number of beds"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtPice)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(502, 148)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Price"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtPice
        '
        Me.txtPice.Location = New System.Drawing.Point(101, 80)
        Me.txtPice.Name = "txtPice"
        Me.txtPice.Size = New System.Drawing.Size(100, 20)
        Me.txtPice.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Price"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(95, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 35)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Price"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 305)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(510, 40)
        Me.Panel1.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(235, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Available Room in this time"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(1, 200)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(509, 104)
        Me.DataGridView1.TabIndex = 8
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(300, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Next>>"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(84, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "<<Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label13)
        Me.TabPage4.Controls.Add(Me.NumericUpDown1)
        Me.TabPage4.Controls.Add(Me.btnAddReservation)
        Me.TabPage4.Controls.Add(Me.cmbReservatonTybe)
        Me.TabPage4.Controls.Add(Me.Label12)
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Controls.Add(Me.cmbClientID)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(502, 148)
        Me.TabPage4.TabIndex = 4
        Me.TabPage4.Text = "Add"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'cmbClientID
        '
        Me.cmbClientID.FormattingEnabled = True
        Me.cmbClientID.Location = New System.Drawing.Point(120, 28)
        Me.cmbClientID.Name = "cmbClientID"
        Me.cmbClientID.Size = New System.Drawing.Size(121, 21)
        Me.cmbClientID.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "ClientID"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Reservation Type"
        '
        'cmbReservatonTybe
        '
        Me.cmbReservatonTybe.FormattingEnabled = True
        Me.cmbReservatonTybe.Location = New System.Drawing.Point(120, 65)
        Me.cmbReservatonTybe.Name = "cmbReservatonTybe"
        Me.cmbReservatonTybe.Size = New System.Drawing.Size(121, 21)
        Me.cmbReservatonTybe.TabIndex = 3
        '
        'btnAddReservation
        '
        Me.btnAddReservation.Location = New System.Drawing.Point(406, 96)
        Me.btnAddReservation.Name = "btnAddReservation"
        Me.btnAddReservation.Size = New System.Drawing.Size(75, 23)
        Me.btnAddReservation.TabIndex = 5
        Me.btnAddReservation.Text = "Add"
        Me.btnAddReservation.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(120, 99)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 105)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 13)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Number of nights"
        '
        'ReservationOp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 345)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "ReservationOp"
        Me.Text = "ReservationOp"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPageClass.ResumeLayout(False)
        Me.TabPageClass.PerformLayout()
        CType(Me.NumericUpDownClass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.NumericUpDownBed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageClass As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownClass As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents NumericUpDownBed As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents txtPice As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents cmbClientID As System.Windows.Forms.ComboBox
    Friend WithEvents cmbReservatonTybe As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnAddReservation As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
End Class
