Imports System.Data.SqlClient

Public Class Coneccion

#Region "Coneccion"
    Public Shared scon As New SqlConnection
    Public Function Abrir() As SqlConnection
        Dim con As String
        con = "Data Source=puesto157;Initial Catalog=NombreDB;Integrated Security=True"
        scon = New SqlConnection(con)
        scon.Open()
        Return scon
    End Function
    Public Shared Function Cerrar() As Boolean
        Try
            If scon.State = ConnectionState.Open Then
                scon.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
#End Region

End Class
