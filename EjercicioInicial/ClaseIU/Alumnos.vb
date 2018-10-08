Imports ClaseNE
Imports ClaseLN
Public Class Alumnos

    Private Sub Alumnos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        llenarGrilla()
    End Sub
    Private Sub llenarGrilla()
        Dim ds As DataSet
        Dim objAlumnosLN As New AlumnosLN
        ds = objAlumnosLN.cargarGrilla()
        dtgAlumno.DataSource = ds.Tables(0)

    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles Label6.Click

    End Sub
End Class
