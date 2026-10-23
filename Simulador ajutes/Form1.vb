Public Class Form1

    Private bloques As New List(Of Integer)
    Private numeroProceso As Integer = 1
    Private tamanos As New List(Of Integer)
    Private memoria As Integer = 0
    Private asignaciones As New List(Of Integer())
    Private colores() As Color = {Color.Orange, Color.LightSkyBlue, Color.Plum, Color.Khaki, Color.LightSalmon, Color.Aquamarine}
    Private Sub CargarFormulario(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbAjuste.DropDownStyle = ComboBoxStyle.DropDownList
        cmbAjuste.Items.Add("Primer ajuste")
        cmbAjuste.Items.Add("Mejor ajuste")
        cmbAjuste.Items.Add("Peor ajuste")
        cmbAjuste.SelectedIndex = 0

        btnAsignar.Enabled = False
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Dim tam As Integer

        If tamanos.Count = 0 Then
            If Not Integer.TryParse(txtMemoria.Text, memoria) OrElse memoria <= 0 Then
                MessageBox.Show("Ingresa un tamano de memoria valido.")
                Return
            End If
        End If

        If Not Integer.TryParse(txtM.Text, tam) OrElse tam <= 0 Then
            MessageBox.Show("Ingresa un tamano de bloque valido.")
            Return
        End If

        If tamanos.Sum() + tam > memoria Then
            MessageBox.Show("No cabe: solo quedan " & (memoria - tamanos.Sum()) & " de memoria libre.")
            Return
        End If

        tamanos.Add(tam)
        bloques.Add(tam)
        txtN.Text = bloques.Count
        txtMemoria.Enabled = False
        txtM.Clear()
        txtM.Focus()
        btnAsignar.Enabled = True
        MostrarBloques()
    End Sub

    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click
        Dim proceso As Integer
        If Not Integer.TryParse(txtProceso.Text, proceso) OrElse proceso <= 0 Then
            MessageBox.Show("Ingresa un tamano de proceso valido (mayor que 0).")
            Return
        End If

        Dim indice As Integer
        If cmbAjuste.SelectedIndex = 0 Then
            indice = PrimerAjuste(proceso)
        ElseIf cmbAjuste.SelectedIndex = 1 Then
            indice = MejorAjuste(proceso)
        Else
            indice = PeorAjuste(proceso)
        End If

        If indice = -1 Then
            lstLog.Items.Add("Proceso " & numeroProceso & " (" & proceso & "): NO cabe en ningun bloque.")
        Else
            Dim sobrante As Integer = bloques(indice) - proceso
            lstLog.Items.Add("Proceso " & numeroProceso & " -> bloque " & (indice + 1) &
                             " (" & bloques(indice) & " - " & proceso & " = " & sobrante &
                             " sobran) [" & cmbAjuste.Text & "]")
            bloques(indice) = sobrante
            asignaciones.Add(New Integer() {indice, numeroProceso, proceso})
        End If

        numeroProceso += 1
        MostrarBloques()
        txtProceso.Clear()
        txtProceso.Focus()
    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        bloques.Clear()
        tamanos.Clear()
        asignaciones.Clear()
        memoria = 0
        numeroProceso = 1
        lstBloques.Items.Clear()
        lstLog.Items.Clear()
        lblLibre.Text = "Memoria libre total: 0"
        txtN.Clear()
        txtMemoria.Enabled = True
        btnAsignar.Enabled = False
        AjustarAncho()
    End Sub

    Private Function PrimerAjuste(proceso As Integer) As Integer
        For i As Integer = 0 To bloques.Count - 1
            If bloques(i) >= proceso Then
                Return i
            End If
        Next
        Return -1
    End Function

    Private Function MejorAjuste(proceso As Integer) As Integer
        Dim elegido As Integer = -1
        For i As Integer = 0 To bloques.Count - 1
            If bloques(i) >= proceso AndAlso (elegido = -1 OrElse bloques(i) < bloques(elegido)) Then
                elegido = i
            End If
        Next
        Return elegido
    End Function

    Private Function PeorAjuste(proceso As Integer) As Integer
        Dim elegido As Integer = -1
        For i As Integer = 0 To bloques.Count - 1
            If bloques(i) >= proceso AndAlso (elegido = -1 OrElse bloques(i) > bloques(elegido)) Then
                elegido = i
            End If
        Next
        Return elegido
    End Function

    Private Sub MostrarBloques()
        lstBloques.Items.Clear()
        Dim total As Integer = 0
        For i As Integer = 0 To bloques.Count - 1
            lstBloques.Items.Add("Bloque " & (i + 1) & ": " & bloques(i) & " libres")
            total += bloques(i)
        Next
        lblLibre.Text = "Memoria libre total: " & total
        AjustarAncho()
    End Sub

    Private Sub picMemoria_Paint(sender As Object, e As PaintEventArgs) Handles picMemoria.Paint
        Dim g = e.Graphics
        g.Clear(Color.WhiteSmoke)
        If memoria <= 0 Then Return

        Dim ancho As Single = picMemoria.Width - 1
        Dim alto As Single = picMemoria.Height - 1
        Dim franja As Single = 18
        Dim x As Single = 0

        For i = 0 To tamanos.Count - 1
            Dim w As Single = tamanos(i) / memoria * ancho

            g.FillRectangle(Brushes.LightGreen, x, 0, w, alto)

            Dim xp = x
            For Each a In asignaciones
                If a(0) = i Then
                    Dim pw As Single = a(2) / memoria * ancho
                    Using pincel As New SolidBrush(colores((a(1) - 1) Mod colores.Length))
                        g.FillRectangle(pincel, xp, franja, pw, alto - franja)
                    End Using
                    g.DrawRectangle(Pens.Gray, xp, franja, pw, alto - franja)
                    g.DrawString("P" & a(1) & vbCrLf & a(2), Font, Brushes.Black,
                                 New RectangleF(xp + 2, franja + 2, pw - 2, alto - franja - 2))
                    xp += pw
                End If
            Next

            g.DrawRectangle(Pens.Black, x, 0, w, alto)
            g.DrawString("B" & i + 1 & "  " & bloques(i) & "/" & tamanos(i), Font, Brushes.Black,
                         New RectangleF(x + 2, 2, w - 2, franja))
            x += w
        Next
    End Sub

    Private Sub AjustarAncho()
        If picMemoria Is Nothing Then Return

        Dim baseAncho As Integer = Me.ClientSize.Width - picMemoria.Left - 30
        Dim necesario As Double = 0

        If memoria > 0 Then
            If tamanos.Count > 0 Then
                necesario = Math.Max(necesario, 60.0 * memoria / tamanos.Min())
            End If
            If asignaciones.Count > 0 Then
                necesario = Math.Max(necesario, 40.0 * memoria / asignaciones.Min(Function(a) a(2)))
            End If
        End If

        picMemoria.Width = CInt(Math.Min(Math.Max(baseAncho, necesario), 30000))
        picMemoria.Invalidate()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        AjustarAncho()
    End Sub
End Class