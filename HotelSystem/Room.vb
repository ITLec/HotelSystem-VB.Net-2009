Imports System.Data.SqlClient

Public Class Room

    Private Sub Room_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillID()
    End Sub
    Private Sub fillID()
        cmbRoomID.Items.Clear()
        Dim dbCon As New DataBaseConnection()
        Dim rdr As SqlDataReader
        Dim con As New SqlConnection(dbCon.ConnectionString)
        Try

            rdr = dbCon.ExectuteReader("select roomid from hotelroom", con)
            While rdr.Read
                Me.cmbRoomID.Items.Add(rdr(0).ToString())
            End While

        Catch ex As Exception
            MessageBox.Show("There is an Error")
        Finally
            con.Close()

        End Try
    End Sub
    Private Sub fillDatagridView()
        Dim dbCon As New DataBaseConnection()
        Dim rdr As SqlDataReader
        Dim con As New SqlConnection(dbCon.ConnectionString)
        Try

            rdr = dbCon.ExectuteReader("select * from RoomReservations where RoomID =" + cmbRoomID.Text, con)
            Dim dt As New DataTable
            dt.Load(rdr)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("There is an Error")
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub cmbRoomID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRoomID.SelectedIndexChanged
        fillDatagridView()
        Dim dbCon As New DataBaseConnection()
        Dim rdr As SqlDataReader
        Dim con As New SqlConnection(dbCon.ConnectionString)
        Try

            rdr = dbCon.ExectuteReader("select * from hotelroom where roomid=" + Me.cmbRoomID.Text, con)
            While rdr.Read
                Me.NumericUpDownRoomFloor.Value = CType(rdr(1), Integer)
                Me.NumericUpDownRoomClass.Value = CType(rdr(2), Integer)
                Me.NumericUpDownBed.Value = CType(rdr(3), Integer)
                txtPricePerNight.Text = CType(rdr(5), String)
                checkbxEnable.Checked = CType(rdr(4), Boolean)
            End While


        Catch ex As Exception
            MessageBox.Show("There is an Error")
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        addFun()
    End Sub
    Private Sub addFun()
        cmbRoomID.Visible = False
        NumericUpDownBed.Enabled = True
        NumericUpDownRoomClass.Enabled = True
        NumericUpDownRoomFloor.Enabled = True
        checkbxEnable.Enabled = True
        txtPricePerNight.Enabled = True
        DataGridView1.Visible = False
        btnAdd.Visible = True



        NumericUpDownBed.Value = 0
        NumericUpDownRoomClass.Value = 0
        NumericUpDownRoomFloor.Value = 0
        checkbxEnable.Checked = False
        txtPricePerNight.Text = "0"
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim dbCon As New DataBaseConnection()
        Dim con As New SqlConnection(dbCon.ConnectionString)
        Dim cmd As New SqlCommand("dbo.dtAddRoom", con)

        cmd.Parameters.Add("@RoomFloor", SqlDbType.Int)
        cmd.Parameters("@RoomFloor").Value = NumericUpDownRoomFloor.Value


        cmd.Parameters.Add("@RoomClass", SqlDbType.Int)
        cmd.Parameters("@RoomClass").Value = CType(NumericUpDownRoomClass.Value, Integer)

        cmd.Parameters.Add("@NumberOfBeds", SqlDbType.Int)
        cmd.Parameters("@NumberOfBeds").Value = NumericUpDownBed.Value


        cmd.Parameters.Add("@PricePerNight", SqlDbType.Int)
        cmd.Parameters("@PricePerNight").Value = CType(txtPricePerNight.Text, Decimal)

        cmd.Parameters.Add("@EnableReservation", SqlDbType.Bit)
        cmd.Parameters("@EnableReservation").Value = CType(checkbxEnable.Checked, Boolean)
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
        frm.strID = "The Room ID=(" + id + ")Do you want add another Room?"
        frm.ShowDialog()

        If frm.DialogResult = DialogResult.OK Then
            addFun()
        Else
            Me.Close()
        End If

    End Sub
    Public Sub searchRoom(ByVal roomID As String)
        cmbRoomID.Text = roomID
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click


        Dim frm As New Dialog1()
        frm.strID = "The Client ID=(" + cmbRoomID.Text + ")Do you want save this Client?"
        frm.ShowDialog()

        If frm.DialogResult = DialogResult.OK Then
            Dim dbCon As New DataBaseConnection()
            Dim con As New SqlConnection(dbCon.ConnectionString)
            Dim cmd As New SqlCommand("dbo.dtUpdateRoom", con)

            cmd.Parameters.Add("@RoomID", SqlDbType.Int)
            cmd.Parameters("@RoomID").Value = cmbRoomID.Text

            cmd.Parameters.Add("@RoomFloor", SqlDbType.Int)
            cmd.Parameters("@RoomFloor").Value = NumericUpDownRoomFloor.Value


            cmd.Parameters.Add("@RoomClass", SqlDbType.Int)
            cmd.Parameters("@RoomClass").Value = CType(NumericUpDownRoomClass.Value, Integer)

            cmd.Parameters.Add("@NumberOfBeds", SqlDbType.Int)
            cmd.Parameters("@NumberOfBeds").Value = NumericUpDownBed.Value


            cmd.Parameters.Add("@PricePerNight", SqlDbType.Int)
            cmd.Parameters("@PricePerNight").Value = CType(txtPricePerNight.Text, Decimal)

            cmd.Parameters.Add("@EnableReservation", SqlDbType.Bit)
            cmd.Parameters("@EnableReservation").Value = CType(checkbxEnable.Checked, Boolean)
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

        cmbRoomID.Visible = False
        NumericUpDownBed.Enabled = True
        NumericUpDownRoomClass.Enabled = True
        NumericUpDownRoomFloor.Enabled = True
        checkbxEnable.Enabled = True
        txtPricePerNight.Enabled = True
        btnSave.Visible = True
        DataGridView1.Visible = False
    End Sub
End Class