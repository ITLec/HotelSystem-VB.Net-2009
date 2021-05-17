<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OperationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReservationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TeservationTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NationalityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OperationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(292, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'OperationToolStripMenuItem
        '
        Me.OperationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientToolStripMenuItem, Me.ReservationToolStripMenuItem, Me.RoomToolStripMenuItem, Me.TeservationTypeToolStripMenuItem, Me.NationalityToolStripMenuItem})
        Me.OperationToolStripMenuItem.Name = "OperationToolStripMenuItem"
        Me.OperationToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.OperationToolStripMenuItem.Text = "Operation"
        '
        'ClientToolStripMenuItem
        '
        Me.ClientToolStripMenuItem.Name = "ClientToolStripMenuItem"
        Me.ClientToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ClientToolStripMenuItem.Text = "Client"
        '
        'ReservationToolStripMenuItem
        '
        Me.ReservationToolStripMenuItem.Name = "ReservationToolStripMenuItem"
        Me.ReservationToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ReservationToolStripMenuItem.Text = "Reservation"
        '
        'RoomToolStripMenuItem
        '
        Me.RoomToolStripMenuItem.Name = "RoomToolStripMenuItem"
        Me.RoomToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.RoomToolStripMenuItem.Text = "Room"
        '
        'TeservationTypeToolStripMenuItem
        '
        Me.TeservationTypeToolStripMenuItem.Name = "TeservationTypeToolStripMenuItem"
        Me.TeservationTypeToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.TeservationTypeToolStripMenuItem.Text = "Reservation Type"
        '
        'NationalityToolStripMenuItem
        '
        Me.NationalityToolStripMenuItem.Name = "NationalityToolStripMenuItem"
        Me.NationalityToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.NationalityToolStripMenuItem.Text = "Nationality"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OperationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReservationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TeservationTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NationalityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
