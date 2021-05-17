<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReservationType
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.DSHotel = New HotelSystem.DSHotel
        Me.ReservationTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationTypeTableAdapter = New HotelSystem.DSHotelTableAdapters.ReservationTypeTableAdapter
        Me.ReservationTypeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReservationTypeDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReservationTypeEnableDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ReservationNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSHotel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReservationTypeIDDataGridViewTextBoxColumn, Me.ReservationTypeDescDataGridViewTextBoxColumn, Me.ReservationTypeEnableDataGridViewCheckBoxColumn, Me.ReservationNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ReservationTypeBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(452, 140)
        Me.DataGridView1.TabIndex = 0
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
        'ReservationTypeIDDataGridViewTextBoxColumn
        '
        Me.ReservationTypeIDDataGridViewTextBoxColumn.DataPropertyName = "ReservationTypeID"
        Me.ReservationTypeIDDataGridViewTextBoxColumn.HeaderText = "ReservationTypeID"
        Me.ReservationTypeIDDataGridViewTextBoxColumn.Name = "ReservationTypeIDDataGridViewTextBoxColumn"
        Me.ReservationTypeIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReservationTypeDescDataGridViewTextBoxColumn
        '
        Me.ReservationTypeDescDataGridViewTextBoxColumn.DataPropertyName = "ReservationTypeDesc"
        Me.ReservationTypeDescDataGridViewTextBoxColumn.HeaderText = "ReservationTypeDesc"
        Me.ReservationTypeDescDataGridViewTextBoxColumn.Name = "ReservationTypeDescDataGridViewTextBoxColumn"
        '
        'ReservationTypeEnableDataGridViewCheckBoxColumn
        '
        Me.ReservationTypeEnableDataGridViewCheckBoxColumn.DataPropertyName = "ReservationTypeEnable"
        Me.ReservationTypeEnableDataGridViewCheckBoxColumn.HeaderText = "ReservationTypeEnable"
        Me.ReservationTypeEnableDataGridViewCheckBoxColumn.Name = "ReservationTypeEnableDataGridViewCheckBoxColumn"
        '
        'ReservationNameDataGridViewTextBoxColumn
        '
        Me.ReservationNameDataGridViewTextBoxColumn.DataPropertyName = "ReservationName"
        Me.ReservationNameDataGridViewTextBoxColumn.HeaderText = "ReservationName"
        Me.ReservationNameDataGridViewTextBoxColumn.Name = "ReservationNameDataGridViewTextBoxColumn"
        '
        'ReservationType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 140)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ReservationType"
        Me.Text = "ReservationType"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSHotel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DSHotel As HotelSystem.DSHotel
    Friend WithEvents ReservationTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReservationTypeTableAdapter As HotelSystem.DSHotelTableAdapters.ReservationTypeTableAdapter
    Friend WithEvents ReservationTypeIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReservationTypeDescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReservationTypeEnableDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ReservationNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
