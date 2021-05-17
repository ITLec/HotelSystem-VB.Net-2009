<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nationality
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
        Me.NationalityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NationalityTableAdapter = New HotelSystem.DSHotelTableAdapters.NationalityTableAdapter
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NationalityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSHotel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NationalityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NationalityDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.NationalityBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(247, 155)
        Me.DataGridView1.TabIndex = 0
        '
        'DSHotel
        '
        Me.DSHotel.DataSetName = "DSHotel"
        Me.DSHotel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NationalityBindingSource
        '
        Me.NationalityBindingSource.DataMember = "Nationality"
        Me.NationalityBindingSource.DataSource = Me.DSHotel
        '
        'NationalityTableAdapter
        '
        Me.NationalityTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NationalityDataGridViewTextBoxColumn
        '
        Me.NationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality"
        Me.NationalityDataGridViewTextBoxColumn.HeaderText = "Nationality"
        Me.NationalityDataGridViewTextBoxColumn.Name = "NationalityDataGridViewTextBoxColumn"
        '
        'nationality
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 155)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "nationality"
        Me.Text = "nationality"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSHotel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NationalityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DSHotel As HotelSystem.DSHotel
    Friend WithEvents NationalityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NationalityTableAdapter As HotelSystem.DSHotelTableAdapters.NationalityTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NationalityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
