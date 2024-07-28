Public Class PizzeriaFNAF
    ' Variables para mantener el total y el número de pedido
    Private totalAmount As Decimal
    Private orderNumber As Integer = 0

    ' Evento que se dispara al hacer clic en un tipo de pizza
    Private Sub MenuListaPizzas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MenuListaPizzas.SelectedIndexChanged
        If MenuListaPizzas.SelectedIndex <> -1 Then
            Dim precio As Decimal = MenuListaPreciosPizzas.Items(MenuListaPizzas.SelectedIndex)
            Dim cantidad As Integer

            ' Cuadro de diálogo para ingresar la cantidad
            Dim cantidadStr As String = InputBox("Ingrese la cantidad de " & MenuListaPizzas.SelectedItem.ToString() & ":", "Cantidad")
            If Integer.TryParse(cantidadStr, cantidad) Then
                ' Añadir a las listas de descripción, cantidad y subtotal
                ListaDescripcion.Items.Add(MenuListaPizzas.SelectedItem.ToString())
                ListaCantidad.Items.Add(cantidad)
                Dim subtotal As Decimal = cantidad * precio
                ListaSubtotal.Items.Add(subtotal)

                ' Actualizar el total
                totalAmount += subtotal
                ActualizarTotales()
            Else
                ' Verificar si se presionó el botón Cancelar
                If Not String.IsNullOrEmpty(cantidadStr) Then
                    MessageBox.Show("Ingrese una cantidad válida.")
                End If
            End If
        End If
    End Sub

    ' Evento que se dispara al hacer clic en un tipo de bebida
    Private Sub MenuListaBebidas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MenuListaBebidas.SelectedIndexChanged
        If MenuListaBebidas.SelectedIndex <> -1 Then
            Dim precio As Decimal = MenuListaPreciosBebidas.Items(MenuListaBebidas.SelectedIndex)
            Dim cantidad As Integer

            ' Cuadro de diálogo para ingresar la cantidad
            Dim cantidadStr As String = InputBox("Ingrese la cantidad de " & MenuListaBebidas.SelectedItem.ToString() & ":", "Cantidad")
            If Integer.TryParse(cantidadStr, cantidad) Then
                ' Añadir a las listas de descripción, cantidad y subtotal
                ListaDescripcion.Items.Add(MenuListaBebidas.SelectedItem.ToString())
                ListaCantidad.Items.Add(cantidad)
                Dim subtotal As Decimal = cantidad * precio
                ListaSubtotal.Items.Add(subtotal)

                ' Actualizar el total
                totalAmount += subtotal
                ActualizarTotales()
            Else
                ' Verificar si se presionó el botón Cancelar
                If Not String.IsNullOrEmpty(cantidadStr) Then
                    MessageBox.Show("Ingrese una cantidad válida.")
                End If
            End If
        End If
    End Sub

    ' Función para actualizar las cajas de texto de total, IVA y neto a cancelar
    Private Sub ActualizarTotales()
        InputValorTotal.Text = totalAmount.ToString("F2")
        Dim iva As Decimal = totalAmount * 0.12D
        InputIVA.Text = iva.ToString("F2")
        Dim neto As Decimal = totalAmount + iva
        If RadioButtonDebito.Checked Then
            neto *= 0.9D
        End If
        InputValorNeto.Text = neto.ToString("F2")
    End Sub

    ' Evento que se dispara al seleccionar la forma de pago
    Private Sub RadioButtonDebito_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonDebito.CheckedChanged, RadioButtonCredito.CheckedChanged
        ActualizarTotales()
    End Sub

    ' Evento para manejar el botón de nuevo pedido
    Private Sub BtnNuevoPedido_Click(sender As Object, e As EventArgs) Handles BtnNuevoPedido.Click
        ' Incrementar el número de pedido
        orderNumber += 1
        LabelNroPedido.Text = orderNumber.ToString()

        ' Reiniciar el total antes de limpiar las cajas de texto
        totalAmount = 0

        ' Limpiar las listas y las cajas de texto
        ListaDescripcion.Items.Clear()
        ListaCantidad.Items.Clear()
        ListaSubtotal.Items.Clear()

        InputValorTotal.Clear()
        InputIVA.Clear()
        InputValorNeto.Clear()
        InputNombreCliente.Clear()
        InputTelefonoCliente.Clear()
        InputDireccionCliente.Clear()

        ' Deseleccionar las opciones de forma de pago
        RadioButtonDebito.Checked = False
        RadioButtonCredito.Checked = False

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class
