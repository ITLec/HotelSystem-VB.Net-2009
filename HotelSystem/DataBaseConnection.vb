Imports System.Data.SqlClient

Public Class DataBaseConnection
    Public ConnectionString As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\HotelProject.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
    Public Sub New()
    End Sub
    Public Function ExectuteReader(ByVal sqlStr As String, ByVal con As SqlConnection) As SqlDataReader
        Dim cmd As New SqlCommand(sqlStr, con)
        con.Open()
        Dim rdr As SqlDataReader = cmd.ExecuteReader
        Return rdr
    End Function
    Public Sub ExectuteNonQuery(ByVal sqlStr As String, ByVal con As SqlConnection)
        Dim cmd As New SqlCommand(sqlStr, con)
        con.Open()
        cmd.ExecuteNonQuery()
    End Sub
End Class
