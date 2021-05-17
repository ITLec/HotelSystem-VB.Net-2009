Imports System.Data.SqlClient

Public Class ReservationOp
    Dim dt As DataTable
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        changeQuery()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        changeQuery()
    End Sub
    Private Sub changeQuery()
        dt = New DataTable
        Dim dbCon As New DataBaseConnection()
        Dim con As New SqlConnection(dbCon.ConnectionString)
        Dim cmd As New SqlCommand("dbo.StoredSelectFreeRooms", con)

        cmd.Parameters.Add("@ReservedFrom", SqlDbType.DateTime)
        cmd.Parameters("@ReservedFrom").Value = DateTimePicker1.Value


        cmd.Parameters.Add("@Reservedto", SqlDbType.DateTime)
        cmd.Parameters("@Reservedto").Value = DateTimePicker2.Value



        cmd.Parameters.Add("@ClassRoom", SqlDbType.Int)
        cmd.Parameters("@ClassRoom").Value = NumericUpDownClass.Value

        cmd.Parameters.Add("@NumberOfBeds", SqlDbType.Int)
        cmd.Parameters("@NumberOfBeds").Value = NumericUpDownBed.Value
        Try
            cmd.Parameters.Add("@PricePerNight", SqlDbType.Money)
            cmd.Parameters("@PricePerNight").Value = CType(txtPice.Text, Decimal)
        Catch ex As Exception
            cmd.Parameters("@PricePerNight").Value = 0.0
        End Try

        cmd.CommandType = CommandType.StoredProcedure

        Dim rdr As SqlDataReader
        con.Open()
        rdr = cmd.ExecuteReader
        dt.Load(rdr)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub NumericUpDownClass_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDownClass.ValueChanged
        changeQuery()
    End Sub

    Private Sub txtPice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPice.TextChanged
       
    End Sub
    Dim selectedtab As Integer = 0

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            TabControl1.SelectTab(TabControl1.SelectedIndex + 1)
        Catch ex As Exception
            MessageBox.Show("Select Error")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Try
            TabControl1.SelectTab(TabControl1.SelectedIndex - 1)
        Catch ex As Exception
            MessageBox.Show("Select Error")
        End Try
    End Sub

    Private Sub txtPice_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPice.Validating
        Try
            Dim c As Decimal = CType(txtPice.Text, Decimal)
            ErrorProvider1.SetError(txtPice, "")
            changeQuery()
        Catch ex As Exception
            ErrorProvider1.SetError(txtPice, "Value must not contain letters")
        End Try
    End Sub

    Private Sub ReservationOp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillClientID()
        fillReservationType()
    End Sub
    Private Sub fillReservationType()
        cmbReservatonTybe.Items.Clear()
        Dim dbCon As New DataBaseConnection()
        Dim rdr As SqlDataReader
        Dim con As New SqlConnection(dbCon.ConnectionString)
        Try
            rdr = dbCon.ExectuteReader("select ReservationTypeID ,ReservationName from ReservationType", con)
            Dim dt As New DataTable
            dt.Load(rdr)
            cmbReservatonTybe.DataSource = dt
            cmbReservatonTybe.DisplayMember = "ReservationName"
            cmbReservatonTybe.ValueMember = "ReservationTypeID"
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
    Dim selectedRoom As Integer

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        
    End Sub

    Private Sub btnAddReservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddReservation.Click


        Dim dbCon As New DataBaseConnection()
        Dim con As New SqlConnection(dbCon.ConnectionString)
        Dim cmd As New SqlCommand("dbo.dtAddReservation", con)

        cmd.Parameters.Add("@ClientID", SqlDbType.Int)
        cmd.Parameters("@ClientID").Value = cmbClientID.Text

        cmd.Parameters.Add("@ReservationType", SqlDbType.Int)
        cmd.Parameters("@ReservationType").Value = cmbReservatonTybe.SelectedValue

        Dim dr As DataRow = dt(selectedRoom)

        cmd.Parameters.Add("@RoomID", SqlDbType.Int)
        cmd.Parameters("@RoomID").Value = dr(0)

        cmd.Parameters.Add("@ReservedTo", SqlDbType.DateTime)
        cmd.Parameters("@ReservedTo").Value = DateTimePicker2.Value


        cmd.Parameters.Add("@ReservedFrom", SqlDbType.DateTime)
        cmd.Parameters("@ReservedFrom").Value = DateTimePicker2.Value


        cmd.CommandType = CommandType.StoredProcedure
        Dim id As String
        Try
            con.Open()
            id = CType(cmd.ExecuteScalar, String)

        Catch ex As Exception
        Finally
            con.Close()

        End Try

        Dim frm As New Dialog1()
        frm.strID = "The Reservation ID=(" + id + ")Do you want add another Reservation?"
        frm.ShowDialog()

        If frm.DialogResult = DialogResult.OK Then
        Else
            Me.Close()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        selectedRoom = e.RowIndex
        MessageBox.Show(selectedRoom.ToString)
    End Sub
End Class