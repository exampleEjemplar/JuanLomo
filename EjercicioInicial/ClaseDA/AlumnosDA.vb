Imports System.Data.SqlClient
Imports ClaseNE
Public Class AlumnosDA
    Private con As New SqlConnection
    Private com As New SqlCommand
    Public Sub New()
        Dim objcon As New Coneccion
        con = objcon.abrir
        com.Connection = con
    End Sub

    Public Function CargaGrilla() As DataSet ' o reporte todos los alumnos
        Dim da As New SqlDataAdapter("select * from alumnos", con)
        Dim ds As New DataSet
        Try
            da.Fill(ds)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds
    End Function
End Class
