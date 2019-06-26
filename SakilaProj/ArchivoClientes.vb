Imports System.Xml
Public Class ArchivoClientes
    Dim indice As Integer = 0

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        misclientes = New Clientes

        misclientes.Id = txtId.Text
        misclientes.FirstName = txtNombre.Text
        misclientes.LastName = txtApellido.Text
        misclientes.Phone = txtTelefono.Text
        misclientes.Email = txtCorreo.Text
        misclientes.Gender = cbGenero.Text

        micoleccionclientes.Add(misclientes)

    End Sub



    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Dim tamaño_coleccion = micoleccionclientes.Count
        Dim cliente_temp As Clientes

        If indice = tamaño_coleccion - 1 Then
            MessageBox.Show("No podemos mostrar mas registros")
            BtnNext.Enabled = False
        Else
            btnBack.Enabled = True
            indice += 1
        End If

        cliente_temp = micoleccionclientes.item(indice)

        txtPreId.Text = cliente_temp.Id
        txtPreNombre.Text = cliente_temp.FirstName
        txtPreApellido.Text = cliente_temp.LastName
        txtPreTelefono.Text = cliente_temp.Phone
        txtPreCorreo.Text = cliente_temp.Email
        txtPreGenero.Text = cliente_temp.Gender

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim tamaño_coleccion = micoleccionclientes.Count
        Dim cliente_temp As Clientes

        If indice = 0 Then
            MessageBox.Show("No podemos mostrar mas registros")
            btnBack.Enabled = False
        Else
            BtnNext.Enabled = True
            indice -= 1
        End If

        cliente_temp = micoleccionclientes.item(indice)

        txtPreId.Text = cliente_temp.Id
        txtPreNombre.Text = cliente_temp.FirstName
        txtPreApellido.Text = cliente_temp.LastName
        txtPreTelefono.Text = cliente_temp.Phone
        txtPreCorreo.Text = cliente_temp.Email
        txtPreGenero.Text = cliente_temp.Gender
    End Sub

    Private Sub btnDescargar_Click(sender As Object, e As EventArgs) Handles btnDescargar.Click
        Dim Doc As New XmlDocument, id, first_name As XmlNode

        id = Doc.CreateElement("Clientes")
        first_name = Doc.CreateElement("Clientes")

        Doc.AppendChild(id)
        id = Doc.CreateElement("id")
        id.InnerText = "0105199300425"
        Doc.DocumentElement.AppendChild(id)

        first_name = Doc.CreateElement("first_name")
        first_name.InnerText = "0105199300425"
        Doc.DocumentElement.AppendChild(first_name)


        Doc.Save(Application.StartupPath & "\datos.xml")
    End Sub
End Class