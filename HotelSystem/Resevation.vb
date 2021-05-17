Imports System.Data.SqlClient

Public Class Resevation

    Private Sub Resevation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHotel.ReservationType' table. You can move, or remove it, as needed.
        Me.ReservationTypeTableAdapter.Fill(Me.DSHotel.ReservationType)

        fillClientID()
        fillRoomID()
        fillReservationType()
        fillIdReservation()
    End Sub
    Private Sub fillReservationType()
        cmbReservationType.Items.Clear()
        Dim dbCon As New DataBaseConnection()
        Dim rdr As SqlDataReader
        Dim con As New SqlConnection(dbCon.ConnectionString)
        Try

            rdr = dbCon.ExectuteReader("select ReservationTypeID ,ReservationName from ReservationType", con)
            Dim dt As New DataTable
            dt.Load(rdr)
            cmbReservationType.DataSource = dt
            cmbReservationType.DisplayMember = "ReservationName"
            cmbReservationType.ValueMember = "ReservationTypeID"
        Catch ex As Exception
            MessageBox.Show("There is an Error")
        Finally
            con.Close()

        End Try
    End Sub
    Private Sub fillRoomID()
        cmbRoomID.Items.Clear()
        Dim dbCon As New DataBaseConnection()
        Dim rdr As SqlDataReader
        Dim con As New SqlConnection(dbCon.ConnectionString)
        Try

            rdr = dbCon.ExectuteReader("select RoomID from HotelRoom", con)
            Dim dt As New DataTable
            dt.Load(rdr)
            cmbRoomID.DataSource = dt
            cmbRoomID.DisplayMember = "RoomID"
        Catch ex As Exception
            MessageBox.Show("There is an Error")
        Finally
            con.Close()

        End Try
    End Sub
    Private Sub fillIdReservation()
        cmbReservationID.Items.Clear()
        Dim dbCon As New DataBaseConnection()
        Dim rdr As SqlDataReader
        Dim con As New SqlConnection(dbCon.ConnectionString)
        Try

            rdr = dbCon.ExectuteReader("select ReservationID from RoomReservations", con)
            Dim dt As New DataTable
            dt.Load(rdr)
            cmbReservationID.DataSource = dt
            cmbReservationID.DisplayMember = "ReservationID"
        Catch ex As Exception
            MessageBox.Show("There is an Error")
        Finally
            con.Close()

        End Try
    End Sub
    Private Sub fillClientID()
        cmbClientID.Items.Clear()
        Dim dbCon As New DataBaseConnection()
        Dim rdr As SqlDataReader
        Dim con As New SqlConnection(dbCon.ConnectionString)
        Try

            rdr = dbCon.ExectuteReader("select id from clients", con)
            Dim dt As New DataTable
            dt.Load(rdr)
            cmbClientID.DataSource = dt
            cmbClientID.DisplayMember = "id"
        Catch ex As Exception
            MessageBox.Show("There is an Error")
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub cmbReservationID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbReservationID.SelectedIndexChanged
        Dim dbCon As New DataBaseConnection()
        Dim rdr As SqlDataReader
        Dim con As New SqlConnection(dbCon.ConnectionString)
        Try

            rdr = dbCon.ExectuteReader("select * from RoomReservations where ReservationID =" + Me.cmbReservationID.Text, con)
            While rdr.Read
                Me.cmbClientID.Text = rdr(1).ToString()
                Me.cmbReservationType.SelectedValue = rdr(2).ToString()
                Me.cmbRoomID.Text = rdr(3).ToString()
                DateTimeFrom.Value = CType(rdr(4), Date)

                DateTimeTo.Value = CType(rdr(5), Date)
            End While


        Catch ex As Exception
            'MessageBox.Show("There is an Error")
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub btnClientID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClientID.Click
        Dim frm As New frmClient
        frm.Show()
        frm.SearchClientID(cmbClientID.Text)
    End Sub

    Private Sub btnRoomIdInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoomIdInfo.Click
        Dim frm As New Room
        frm.Show()
        frm.searchRoom(cmbRoomID.Text)
    End Sub

    Private Sub SearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem.Click
        Dim frm As New ReservationOp
        frm.Show()
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        Dim frm As New ReservationOp
        frm.Show()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click


        Dim frm As New Dialog1()
        frm.strID = "The Reservation ID=(" + cmbReservationID.Text + ")Do you want save this Reservation?"
        frm.ShowDialog()

        If frm.DialogResult = DialogResult.OK Then
            Dim dbCon As New DataBaseConnection()
            Dim con As New SqlConnection(dbCon.ConnectionString)
            Dim cmd As New SqlCommand("dbo.dtUpdateReservation", con)

            cmd.Parameters.Add("@ReservationID", SqlDbType.Int)
            cmd.Parameters("@ReservationID").Value = cmbReservationID.Text

            cmd.Parameters.Add("@ClientID", SqlDbType.Int)
            cmd.Parameters("@ClientID").Value = CType(cmbClientID.Text, Integer)

            cmd.Parameters.Add("@ReservationType", SqlDbType.Int)
            cmd.Parameters("@ReservationType").Value = CType(cmbReservationType.SelectedValue, Integer)

            cmd.Parameters.Add("@RoomID", SqlDbType.Int)
            cmd.Parameters("@RoomID").Value = cmbRoomID.Text


            cmd.Parameters.Add("@ReservedTo", SqlDbType.DateTime)
            cmd.Parameters("@ReservedTo").Value = DateTimeTo.Value

            cmd.Parameters.Add("@ReservedFrom", SqlDbType.DateTime)
            cmd.Parameters("@ReservedFrom").Value = CType(DateTimeFrom.Value, Date)
            cmd.CommandType = CommandType.StoredProcedure

            Try
                con.Open()
                cmd.ExecuteNonQuery()

            Catch ex As Exception
            Finally
                con.Close()

            End Try
        Else
        End If

        Me.Close()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click

        Me.cmbClientID.Enabled = True
        Me.cmbReservationType.Enabled = True
        Me.cmbRoomID.Enabled = True
        DateTimeFrom.Enabled = True
        DateTimeTo.Enabled = True
        btnSave.Visible = True
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim frm As New Dialog1()
        frm.strID = "The Reservation ID=(" + cmbReservationID.Text + ")Do you want delete this Reservation?"
        frm.ShowDialog()

        If frm.DialogResult = DialogResult.OK Then
            Dim dbCon As New DataBaseConnection()
            Dim con As New SqlConnection(dbCon.ConnectionString)
            Try

                dbCon.ExectuteNonQuery("delete RoomReservations where ReservationID=" + cmbReservationID.Text, con)

            Catch ex As Exception
                MessageBox.Show("There is an Error")
            Finally
                con.Close()

            End Try
            Me.Close()
        Else
        End If
    End Sub
End Class