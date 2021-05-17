Public Class nationality

    Private Sub nationality_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHotel.Nationality' table. You can move, or remove it, as needed.
        Me.NationalityTableAdapter.Fill(Me.DSHotel.Nationality)

    End Sub

    Private Sub nationality_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.NationalityTableAdapter.Update(DSHotel)
    End Sub
End Class