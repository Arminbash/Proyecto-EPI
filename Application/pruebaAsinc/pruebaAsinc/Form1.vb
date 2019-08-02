Imports Controller
Imports Models
Public Class Form1
    Dim nEmployee As New C_Employee
    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim task As New Task(Of List(Of Employee))(ObtenerEmpleado)
        task.Start()
        GridControl1.DataSource = Await task
    End Sub

    Private Function ObtenerEmpleado()
        Return nEmployee.getEmployee
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ObtenerEmpleado()
    End Sub
End Class
