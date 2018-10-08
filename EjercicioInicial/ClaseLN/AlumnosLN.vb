Imports ClaseDA
Imports ClaseNE
Public Class AlumnosLN
    Private objAlumnosAD As AlumnosDA
    Public Sub New()
        objAlumnosAD = New AlumnosDA
    End Sub
    Public Function cargarGrilla() As DataSet
        Return objAlumnosAD.CargaGrilla()
    End Function

End Class
