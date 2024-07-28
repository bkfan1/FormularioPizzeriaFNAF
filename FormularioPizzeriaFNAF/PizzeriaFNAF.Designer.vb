<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PizzeriaFNAF
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListaDescripcion = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListaCantidad = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListaSubtotal = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BtnNuevoPedido = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.InputValorTotal = New System.Windows.Forms.TextBox()
        Me.InputIVA = New System.Windows.Forms.TextBox()
        Me.InputValorNeto = New System.Windows.Forms.TextBox()
        Me.InputNombreCliente = New System.Windows.Forms.TextBox()
        Me.InputTelefonoCliente = New System.Windows.Forms.TextBox()
        Me.InputDireccionCliente = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuListaPreciosPizzas = New System.Windows.Forms.ListBox()
        Me.MenuListaPizzas = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MenuListaPreciosBebidas = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MenuListaBebidas = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonCredito = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDebito = New System.Windows.Forms.RadioButton()
        Me.LabelNroPedido = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListaDescripcion
        '
        Me.ListaDescripcion.BackColor = System.Drawing.Color.AliceBlue
        Me.ListaDescripcion.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListaDescripcion.FormattingEnabled = True
        Me.ListaDescripcion.ItemHeight = 23
        Me.ListaDescripcion.Location = New System.Drawing.Point(33, 237)
        Me.ListaDescripcion.Name = "ListaDescripcion"
        Me.ListaDescripcion.Size = New System.Drawing.Size(140, 96)
        Me.ListaDescripcion.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.IndianRed
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(30, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Descripción"
        '
        'ListaCantidad
        '
        Me.ListaCantidad.BackColor = System.Drawing.Color.AliceBlue
        Me.ListaCantidad.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListaCantidad.FormattingEnabled = True
        Me.ListaCantidad.ItemHeight = 23
        Me.ListaCantidad.Location = New System.Drawing.Point(194, 237)
        Me.ListaCantidad.Name = "ListaCantidad"
        Me.ListaCantidad.Size = New System.Drawing.Size(110, 96)
        Me.ListaCantidad.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.IndianRed
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(189, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cant."
        '
        'ListaSubtotal
        '
        Me.ListaSubtotal.BackColor = System.Drawing.Color.AliceBlue
        Me.ListaSubtotal.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListaSubtotal.FormattingEnabled = True
        Me.ListaSubtotal.ItemHeight = 23
        Me.ListaSubtotal.Location = New System.Drawing.Point(336, 237)
        Me.ListaSubtotal.Name = "ListaSubtotal"
        Me.ListaSubtotal.Size = New System.Drawing.Size(105, 96)
        Me.ListaSubtotal.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.IndianRed
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(332, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Subtotal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.SeaGreen
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(170, 377)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 23)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Total:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.IndianRed
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(488, 206)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 23)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Nro. Pedido:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.DarkCyan
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(488, 258)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 23)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Cliente:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.DarkCyan
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(488, 306)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 23)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Teléfono:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.DarkCyan
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(488, 349)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 23)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Dirección"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.SeaGreen
        Me.Label13.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(170, 423)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(122, 23)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "I.V.A. (12%):"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.SeaGreen
        Me.Label14.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(170, 466)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(143, 23)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Neto a Cancelar:"
        '
        'BtnNuevoPedido
        '
        Me.BtnNuevoPedido.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnNuevoPedido.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevoPedido.Location = New System.Drawing.Point(648, 400)
        Me.BtnNuevoPedido.Name = "BtnNuevoPedido"
        Me.BtnNuevoPedido.Size = New System.Drawing.Size(115, 37)
        Me.BtnNuevoPedido.TabIndex = 21
        Me.BtnNuevoPedido.Text = "Nuevo Pedido"
        Me.BtnNuevoPedido.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Orange
        Me.BtnSalir.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(648, 459)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(115, 35)
        Me.BtnSalir.TabIndex = 22
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'InputValorTotal
        '
        Me.InputValorTotal.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputValorTotal.Location = New System.Drawing.Point(341, 377)
        Me.InputValorTotal.Name = "InputValorTotal"
        Me.InputValorTotal.Size = New System.Drawing.Size(100, 30)
        Me.InputValorTotal.TabIndex = 26
        '
        'InputIVA
        '
        Me.InputIVA.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputIVA.Location = New System.Drawing.Point(341, 421)
        Me.InputIVA.Name = "InputIVA"
        Me.InputIVA.Size = New System.Drawing.Size(100, 30)
        Me.InputIVA.TabIndex = 27
        '
        'InputValorNeto
        '
        Me.InputValorNeto.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputValorNeto.Location = New System.Drawing.Point(341, 466)
        Me.InputValorNeto.Name = "InputValorNeto"
        Me.InputValorNeto.Size = New System.Drawing.Size(100, 30)
        Me.InputValorNeto.TabIndex = 28
        '
        'InputNombreCliente
        '
        Me.InputNombreCliente.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputNombreCliente.Location = New System.Drawing.Point(573, 258)
        Me.InputNombreCliente.Name = "InputNombreCliente"
        Me.InputNombreCliente.Size = New System.Drawing.Size(190, 30)
        Me.InputNombreCliente.TabIndex = 30
        '
        'InputTelefonoCliente
        '
        Me.InputTelefonoCliente.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputTelefonoCliente.Location = New System.Drawing.Point(573, 303)
        Me.InputTelefonoCliente.Name = "InputTelefonoCliente"
        Me.InputTelefonoCliente.Size = New System.Drawing.Size(190, 30)
        Me.InputTelefonoCliente.TabIndex = 31
        '
        'InputDireccionCliente
        '
        Me.InputDireccionCliente.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputDireccionCliente.Location = New System.Drawing.Point(573, 342)
        Me.InputDireccionCliente.Name = "InputDireccionCliente"
        Me.InputDireccionCliente.Size = New System.Drawing.Size(190, 30)
        Me.InputDireccionCliente.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.MenuListaPreciosPizzas)
        Me.GroupBox1.Controls.Add(Me.MenuListaPizzas)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(33, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(295, 146)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menú"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(156, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 23)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Precios"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Pizzas"
        '
        'MenuListaPreciosPizzas
        '
        Me.MenuListaPreciosPizzas.BackColor = System.Drawing.Color.AliceBlue
        Me.MenuListaPreciosPizzas.FormattingEnabled = True
        Me.MenuListaPreciosPizzas.ItemHeight = 23
        Me.MenuListaPreciosPizzas.Items.AddRange(New Object() {"25", "30", "35"})
        Me.MenuListaPreciosPizzas.Location = New System.Drawing.Point(161, 56)
        Me.MenuListaPreciosPizzas.Name = "MenuListaPreciosPizzas"
        Me.MenuListaPreciosPizzas.Size = New System.Drawing.Size(55, 73)
        Me.MenuListaPreciosPizzas.TabIndex = 37
        '
        'MenuListaPizzas
        '
        Me.MenuListaPizzas.BackColor = System.Drawing.Color.AliceBlue
        Me.MenuListaPizzas.FormattingEnabled = True
        Me.MenuListaPizzas.ItemHeight = 23
        Me.MenuListaPizzas.Items.AddRange(New Object() {"Margarita", "Napolitana", "Especial"})
        Me.MenuListaPizzas.Location = New System.Drawing.Point(20, 56)
        Me.MenuListaPizzas.Name = "MenuListaPizzas"
        Me.MenuListaPizzas.Size = New System.Drawing.Size(120, 73)
        Me.MenuListaPizzas.TabIndex = 36
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox2.Controls.Add(Me.MenuListaPreciosBebidas)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.MenuListaBebidas)
        Me.GroupBox2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(362, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(295, 146)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bebidas"
        '
        'MenuListaPreciosBebidas
        '
        Me.MenuListaPreciosBebidas.BackColor = System.Drawing.Color.AliceBlue
        Me.MenuListaPreciosBebidas.FormattingEnabled = True
        Me.MenuListaPreciosBebidas.ItemHeight = 23
        Me.MenuListaPreciosBebidas.Items.AddRange(New Object() {"2", "3", "2.5"})
        Me.MenuListaPreciosBebidas.Location = New System.Drawing.Point(163, 56)
        Me.MenuListaPreciosBebidas.Name = "MenuListaPreciosBebidas"
        Me.MenuListaPreciosBebidas.Size = New System.Drawing.Size(55, 73)
        Me.MenuListaPreciosBebidas.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(159, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 23)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Precios"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 23)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Bebidas"
        '
        'MenuListaBebidas
        '
        Me.MenuListaBebidas.BackColor = System.Drawing.Color.AliceBlue
        Me.MenuListaBebidas.FormattingEnabled = True
        Me.MenuListaBebidas.ItemHeight = 23
        Me.MenuListaBebidas.Items.AddRange(New Object() {"Refresco", "Cerveza", "Té"})
        Me.MenuListaBebidas.Location = New System.Drawing.Point(21, 56)
        Me.MenuListaBebidas.Name = "MenuListaBebidas"
        Me.MenuListaBebidas.Size = New System.Drawing.Size(120, 73)
        Me.MenuListaBebidas.TabIndex = 38
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox3.Controls.Add(Me.RadioButtonCredito)
        Me.GroupBox3.Controls.Add(Me.RadioButtonDebito)
        Me.GroupBox3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(491, 400)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(132, 96)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Forma de Pago"
        '
        'RadioButtonCredito
        '
        Me.RadioButtonCredito.AutoSize = True
        Me.RadioButtonCredito.Location = New System.Drawing.Point(6, 59)
        Me.RadioButtonCredito.Name = "RadioButtonCredito"
        Me.RadioButtonCredito.Size = New System.Drawing.Size(83, 27)
        Me.RadioButtonCredito.TabIndex = 1
        Me.RadioButtonCredito.TabStop = True
        Me.RadioButtonCredito.Text = "Crédito"
        Me.RadioButtonCredito.UseVisualStyleBackColor = True
        '
        'RadioButtonDebito
        '
        Me.RadioButtonDebito.AutoSize = True
        Me.RadioButtonDebito.Location = New System.Drawing.Point(6, 24)
        Me.RadioButtonDebito.Name = "RadioButtonDebito"
        Me.RadioButtonDebito.Size = New System.Drawing.Size(78, 27)
        Me.RadioButtonDebito.TabIndex = 0
        Me.RadioButtonDebito.TabStop = True
        Me.RadioButtonDebito.Text = "Débito"
        Me.RadioButtonDebito.UseVisualStyleBackColor = True
        '
        'LabelNroPedido
        '
        Me.LabelNroPedido.AutoSize = True
        Me.LabelNroPedido.BackColor = System.Drawing.Color.IndianRed
        Me.LabelNroPedido.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNroPedido.ForeColor = System.Drawing.Color.White
        Me.LabelNroPedido.Location = New System.Drawing.Point(594, 206)
        Me.LabelNroPedido.Name = "LabelNroPedido"
        Me.LabelNroPedido.Size = New System.Drawing.Size(20, 23)
        Me.LabelNroPedido.TabIndex = 36
        Me.LabelNroPedido.Text = "0"
        '
        'PizzeriaFNAF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.BackgroundImage = Global.FormularioPizzeriaFNAF.My.Resources.Resources.istockphoto_837344068_612x612
        Me.ClientSize = New System.Drawing.Size(798, 536)
        Me.Controls.Add(Me.LabelNroPedido)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.InputDireccionCliente)
        Me.Controls.Add(Me.InputTelefonoCliente)
        Me.Controls.Add(Me.InputNombreCliente)
        Me.Controls.Add(Me.InputValorNeto)
        Me.Controls.Add(Me.InputIVA)
        Me.Controls.Add(Me.InputValorTotal)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnNuevoPedido)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListaSubtotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListaCantidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListaDescripcion)
        Me.Name = "PizzeriaFNAF"
        Me.Text = "Pizzeria Paula"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaDescripcion As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ListaCantidad As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ListaSubtotal As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents BtnNuevoPedido As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents InputValorTotal As TextBox
    Friend WithEvents InputIVA As TextBox
    Friend WithEvents InputValorNeto As TextBox
    Friend WithEvents InputNombreCliente As TextBox
    Friend WithEvents InputTelefonoCliente As TextBox
    Friend WithEvents InputDireccionCliente As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuListaPreciosPizzas As ListBox
    Friend WithEvents MenuListaPizzas As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents MenuListaBebidas As ListBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButtonCredito As RadioButton
    Friend WithEvents RadioButtonDebito As RadioButton
    Friend WithEvents MenuListaPreciosBebidas As ListBox
    Friend WithEvents LabelNroPedido As Label
End Class
