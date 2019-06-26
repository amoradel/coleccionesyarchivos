Public Class FrmGestionCliente
    Private Sub FrmGestionCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadHeaderDGV()
        LoadDataDGV()
    End Sub

    ''' <summary>
    ''' Se cargan los encabezados del DataGridView
    ''' </summary>
    Private Sub LoadHeaderDGV()
        Me.DataGridView1.Columns.Add("ID", "ID")
        Me.DataGridView1.Columns.Add("Nombre", "Nombre")
        Me.DataGridView1.Columns.Add("Apellidos", "Apellidos")
        Me.DataGridView1.Columns.Add("Nacionalidad", "Nacionalidad")
        Me.DataGridView1.Columns.Add("Correo", "Correo")
        Me.DataGridView1.Columns.Add("Telefono", "Telefono")

        Me.DataGridView1.Columns("ID").Width = 50
        Me.DataGridView1.Columns("Nombre").Width = 200
        Me.DataGridView1.Columns("Apellidos").Width = 200
        Me.DataGridView1.Columns("Nacionalidad").Width = 100
        Me.DataGridView1.Columns("Correo").Width = 150
        Me.DataGridView1.Columns("Telefono").Width = 100

    End Sub

    ''' <summary>
    ''' Se cargan los datos en el DataGridView
    ''' </summary>
    Private Sub LoadDataDGV()
        DataGridView1.Rows.Add()

        DataGridView1.Rows(0).Cells(0).Value = 1
        DataGridView1.Rows(0).Cells(1).Value = "Anibal"
        DataGridView1.Rows(0).Cells(2).Value = "Moradel"
        DataGridView1.Rows(0).Cells(3).Value = "Hondureño"
        DataGridView1.Rows(0).Cells(4).Value = "amoradel@unicah.edu"
        DataGridView1.Rows(0).Cells(5).Value = "+504 9646-8846"

    End Sub

    Private Sub btnFile_Click(sender As Object, e As EventArgs) Handles btnFile.Click
        ArchivoClientes.ShowDialog()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
End Class
