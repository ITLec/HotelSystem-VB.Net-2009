Public Class Form1

    Private Sub ClientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientToolStripMenuItem.Click
        Dim frm As New frmClient
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub ReservationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservationToolStripMenuItem.Click
        Dim frm As New Resevation
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub RoomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomToolStripMenuItem.Click
        Dim frm As New Room
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TeservationTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeservationTypeToolStripMenuItem.Click
        Dim frm As New ReservationType
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub NationalityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NationalityToolStripMenuItem.Click
        Dim frm As New nationality
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class
