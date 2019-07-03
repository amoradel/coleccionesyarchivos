Imports System.Windows.Forms.DataVisualization.Charting

Public Class Graficas
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub Graficas_Load(sender As Object, e As EventArgs) Handles Me.Load
        NombreColumnas.ShowDialog()
        DataGridView1.Columns.Add(misfunciones.Col1, misfunciones.Col1)
        DataGridView1.Columns.Add(misfunciones.Col2, misfunciones.Col2)
    End Sub

    Sub RecorreDGV()
        If DataGridView1.Rows.Count = 1 Then
            MessageBox.Show("Debe ingresar datos en la grilla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            micolecciondatos = New ColeccionDatos

            For FILA = 0 To DataGridView1.Rows.Count - 2
                misdatos = New Datos
                misdatos.dato1 = DataGridView1.Rows(FILA).Cells(0).Value
                misdatos.dato2 = DataGridView1.Rows(FILA).Cells(1).Value
                micolecciondatos.Add(misdatos)
            Next
            NumeroFilas()
        End If
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

    Sub cargarGrafica()
        'Aqui se prepara la grafica
        Grafiquita1.Series.Clear()
        Grafiquita1.ChartAreas.Clear()

        Grafiquita1.Series.Add("Dispersion")
        'Grafiquita1.Series.Add("Linea")

        Grafiquita1.ChartAreas.Add("Default")

        Grafiquita1.Series("Dispersion").ChartType = DataVisualization.Charting.SeriesChartType.Point

        'Aqui se cargan los datos
        'For i = 0 To micolecciondatos.Count - 1
        '    Grafiquita1.Series("Dispersion").Points.AddXY(micolecciondatos.item(i).dato1, micolecciondatos.item(i).dato2)
        'Next
        For FILA = 0 To DataGridView1.Rows.Count - 2
            Grafiquita1.Series("Dispersion").Points.AddXY(DataGridView1.Rows(FILA).Cells(0).Value, DataGridView1.Rows(FILA).Cells(1).Value)

        Next

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        RecorreDGV()
        cargarGrafica()
    End Sub
End Class