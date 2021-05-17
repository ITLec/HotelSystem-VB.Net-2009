Imports System.Data.SqlClient

Public Class frmClient

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillID()
        fillNationality()

    End Sub
    Private Sub fillID()
        cmbClientID.Items.Clear()
        Dim dbCon As New DataBaseConnection()
        Dim rdr As SqlDataReader
        Dim con As New SqlConnection(dbCon.ConnectionString)
        Try

            rdr = dbCon.ExectuteReader("select id from clients", con)
            While rdr.Read
                Me.cmbClientID.Items.Add(rdr(0).ToString())
            End While

        Catch ex As Exception
            MessageBox.Show("There is an Error")
        Finally
            con.Close()

        End Try
        clrControls()
    End Sub
    Private Sub fillNationality()
        Dim dbCon As New DataBaseConnection()
        Dim rdr As SqlDataReader
        Dim con As New SqlConnection(dbCon.ConnectionString)
        Try

            rdr = dbCon.ExectuteReader("select * from Nationality ", con)
            Dim dt As New DataTable
            dt.Load(rdr)

            cmbNationality.DataSource = dt
            cmbNationality.ValueMember = "ID"
            cmbNationality.DisplayMember = "Nationality"

        Catch ex As Exception
            MessageBox.Show("There is an Error")
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
      
        addfun()
    End Sub
    Private Sub addfun()
        Me.cmbClientID.Visible = False
        Me.Label1.Visible = False
        lblStatus.Text = "Add new Client"
        Me.DateTimeBirthDate.Value = Date.Now
        Me.txtAddress.Enabled = True
        Me.txtCCN.Enabled = True
        Me.txtName.Enabled = True
        Me.cmbNationality.Enabled = True
        Me.DateTimeBirthDate.Enabled = True
        Me.btnAdd.Visible = True
        clrControls()
    End Sub
    Private Sub clrControls()

        Me.txtAddress.Text = ""
        Me.txtCCN.Text = ""
        Me.txtName.Text = ""
        Me.cmbNationality.Text = ""
    End Sub
    Private Sub cmbClientID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbClientID.SelectedIndexChanged

        Dim dbCon As New DataBaseConnection()
        Dim rdr As SqlDataReader
        Dim con As New SqlConnection(dbCon.ConnectionString)
        Try

            rdr = dbCon.ExectuteReader("select * from clients where id=" + Me.cmbClientID.Text, con)
            While rdr.Read
                Me.txtName.Text = rdr(1).ToString()
                Me.txtCCN.Text = rdr(2).ToString()
                Me.cmbNationality.SelectedValue = rdr(3).ToString()
                Me.txtAddress.Text = rdr(4).ToString()
                DateTimeBirthDate.Value = CType(rdr(5), Date)
            End While


        Catch ex As Exception
            MessageBox.Show("There is an Error")
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim dbCon As New DataBaseConnection()
        Dim con As New SqlConnection(dbCon.ConnectionString)
        Dim cmd As New SqlCommand("dbo.dtAddClient", con)

        cmd.Parameters.Add("@Name", SqlDbType.NVarChar)
        cmd.Parameters("@Name").Value = txtName.Text


        cmd.Parameters.Add("@NationalityID", SqlDbType.Int)
        cmd.Parameters("@NationalityID").Value = CType(cmbNationality.SelectedValue, Integer)

        cmd.Parameters.Add("@Address", SqlDbType.NVarChar)
        cmd.Parameters("@Address").Value = txtAddress.Text


        cmd.Parameters.Add("@ccn", SqlDbType.NVarChar)
        cmd.Parameters("@ccn").Value = txtCCN.Text

        cmd.Parameters.Add("@Birthdate", SqlDbType.DateTime)
        cmd.Parameters("@Birthdate").Value = CType(DateTimeBirthDate.Value, Date)
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
        frm.strID = "The Client ID=(" + id + ")Do you want add another Client?"
        frm.ShowDialog()

        If frm.DialogResult = DialogResult.OK Then
            addfun()
        Else
            Me.Close()
        End If





    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        DeleteClient()
    End Sub
    Private Sub DeleteClient()

        Dim frm As New Dialog1()
        frm.strID = "The Client ID=(" + cmbClientID.Text + ")Do you want delete this Client?"
        frm.ShowDialog()

        If frm.DialogResult = DialogResult.OK Then
            Dim dbCon As New DataBaseConnection()
            Dim con As New SqlConnection(dbCon.ConnectionString)
            Try

                dbCon.ExectuteNonQuery("delete clients where id=" + cmbClientID.Text, con)

            Catch ex As Exception
                MessageBox.Show("There is an Error")
            Finally
                con.Close()

            End Try
            '  Me.Close()
            fillID()
        Else
        End If

    End Sub

    Private Sub btdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btdEdit.Click
        

        Dim frm As New Dialog1()
        frm.strID = "The Client ID=(" + cmbClientID.Text + ")Do you want save this Client?"
        frm.ShowDialog()

        If frm.DialogResult = DialogResult.OK Then
            Dim dbCon As New DataBaseConnection()
            Dim con As New SqlConnection(dbCon.ConnectionString)
            Dim cmd As New SqlCommand("dbo.dtUpdateClient", con)

            cmd.Parameters.Add("@Name", SqlDbType.NVarChar)
            cmd.Parameters("@Name").Value = txtName.Text

            cmd.Parameters.Add("@id", SqlDbType.Int)
            cmd.Parameters("@id").Value = CType(cmbClientID.Text, Integer)

            cmd.Parameters.Add("@NationalityID", SqlDbType.Int)
            cmd.Parameters("@NationalityID").Value = CType(cmbNationality.SelectedValue, Integer)

            cmd.Parameters.Add("@Address", SqlDbType.NVarChar)
            cmd.Parameters("@Address").Value = txtAddress.Text


            cmd.Parameters.Add("@ccn", SqlDbType.NVarChar)
            cmd.Parameters("@ccn").Value = txtCCN.Text

            cmd.Parameters.Add("@Birthdate", SqlDbType.DateTime)
            cmd.Parameters("@Birthdate").Value = CType(DateTimeBirthDate.Value, Date)
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
        lblStatus.Text = "Edit client"
        Me.txtAddress.Enabled = True
        Me.txtCCN.Enabled = True
        Me.txtName.Enabled = True
        Me.cmbNationality.Enabled = True
        Me.DateTimeBirthDate.Enabled = True
        Me.btdEdit.Visible = True
    End Sub

    Public Sub SearchClientID(ByVal str As String)
        cmbClientID.Text = str
    End Sub
End Class