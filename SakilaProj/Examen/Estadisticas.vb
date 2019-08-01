Imports System.Windows.Forms.DataVisualization.Charting
Imports System.ComponentModel
Public Class Estadisticas
    Private suma As Double
    Private Sub Estadisticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Columns.Add("Datos", "Datos")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        RecorreDGV()
    End Sub

    Sub RecorreDGV()
        suma = 0
        If DataGridView1.Rows.Count = 1 Then
            MessageBox.Show("Debe ingresar datos en la grilla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            micolecciondatos = New ColeccionDatos

            For FILA = 0 To DataGridView1.Rows.Count - 2
                misdatos = New Datos
                misdatos.dato1 = DataGridView1.Rows(FILA).Cells(0).Value
                suma += misdatos.dato1
                micolecciondatos.Add(misdatos)
            Next
            NumeroFilas()
            cargarGrafica()
            calcular()

        End If
    End Sub

    Sub calcular()
        Dim aux As Integer = 0
        For i = 0 To micolecciondatos.Count - 1
            For j = 0 To micolecciondatos.Count - 2
                If micolecciondatos.item(j).dato1 >= micolecciondatos.item(j + 1).dato1 Then
                    aux = micolecciondatos.item(j).dato1
                    micolecciondatos.item(j).dato1 = micolecciondatos.item(j + 1).dato1
                    micolecciondatos.item(j + 1).dato1 = aux
                End If
            Next
        Next

        txtSuma.Text = suma
        txtPromedio.Text = suma / micolecciondatos.Count
        txtMenor.Text = micolecciondatos.item(0).dato1
        txtMayor.Text = micolecciondatos.item(micolecciondatos.Count - 1).dato1
    End Sub

    Sub cargarGrafica()
        'Aqui se prepara la grafica
        Chart1.Series.Clear()
        Chart1.ChartAreas.Clear()

        Chart1.Series.Add("Series1")

        'Aqui se cargan los datos
        For i = 0 To micolecciondatos.Count - 1
            Chart1.Series("Series1").Points.AddY(micolecciondatos.item(i).dato1)
        Next

        Chart1.ChartAreas.Add("Default")

        Chart1.Series("Series1").MarkerStyle = MarkerStyle.Cross
        Chart1.Series("Series1").MarkerSize = 10
        Chart1.Series("Series1").MarkerColor = Color.White
        Chart1.Series("Series1").MarkerBorderColor = Color.Green
        Chart1.Series("Series1").MarkerBorderWidth = 1


        Chart1.Series("Series1").ChartType = DataVisualization.Charting.SeriesChartType.Spline


        Chart1.Series("Series1").IsValueShownAsLabel = True



    End Sub

    Sub NumeroFilas()
        Me.DataGridView1.RowHeadersWidth = 35
        If DataGridView1.Rows.Count > 0 Then
            For r = 0 To DataGridView1.Rows.Count - 1
                Me.DataGridView1.Rows(r).HeaderCell.Value = CStr(r + 1)
            Next
        End If
        DataGridView1.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders)
    End Sub


End Class