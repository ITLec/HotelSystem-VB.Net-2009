Public Class ReservationType

    Private Sub ReservationType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHotel.ReservationType' table. You can move, or remove it, as needed.
        Me.ReservationTypeTableAdapter.Fill(Me.DSHotel.ReservationType)

    End Sub

    Private Sub ReservationType_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ReservationTypeTableAdapter.Update(DSHotel)
    End Sub
End Class