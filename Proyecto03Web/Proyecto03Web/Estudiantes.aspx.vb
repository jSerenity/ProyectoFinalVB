Imports Proyecto03Web.WSE
Imports Xceed.Wpf.Toolkit

Public Class Estudiantes
    Inherits System.Web.UI.Page
    Dim objEstudiante As New WSE.WebService1SoapClient
    Public MessageResponse As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnlistarE_Click(sender As Object, e As EventArgs) Handles btnlistarE.Click
        listarTable()
    End Sub

    Private Function listarTable()
        DataGridViewEstudiantes.DataSource = objEstudiante.ListarEstudiantes().Tables(0)
        DataGridViewEstudiantes.DataBind()
    End Function

    Protected Sub cbFacultad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFacultad.SelectedIndexChanged
        Console.WriteLine("test")
        Dim faculdad = CType(sender, DropDownList)
        If (String.IsNullOrEmpty(cbFacultad.SelectedValue)) Then

        Else
            Try
                Dim dtcb As DataSet = objEstudiante.BuscarCarreras(cbFacultad.SelectedValue)
                cbcarreras.DataSource = dtcb.Tables(0)
                cbcarreras.DataTextField = dtcb.Tables(0).Columns(1).ColumnName
                cbcarreras.DataValueField = dtcb.Tables(0).Columns(0).ColumnName
                cbcarreras.DataBind()
                cbcarreras.Items.Insert(0, New ListItem("--Seleccionar Carrera--", "0"))
            Catch ex As Exception

            End Try
        End If
    End Sub

    Protected Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub
    Private Function limpiar()
        txtCedula.Text = ""
        txtnombre.Text = ""
        txtapellido.Text = ""
        txtdireccion.Text = ""
        txtcelular.Text = ""
        txtcorreo.Text = ""
        cbFacultad.SelectedIndex = -1
        txtindice.Text = ""
        cbsexo.SelectedIndex = -1
        cbcarreras.DataSource = {}
        cbestado.SelectedIndex = -1
        txtCedula.Enabled = True
        btnbuscar.Visible = True
        btnbuscar.Enabled = True

        btnAgregar.Visible = False
        btnActualizar.Visible = False
        btnEliminar.Visible = False

        txtnombre.Enabled = False
        txtapellido.Enabled = False
        txtdireccion.Enabled = False
        txtcelular.Enabled = False
        txtcorreo.Enabled = False
        cbFacultad.Enabled = False
        txtindice.Enabled = False
        cbsexo.Enabled = False
        cbcarreras.Enabled = False
        cbestado.Enabled = False
    End Function

    Protected Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If String.IsNullOrEmpty(txtCedula.Text) Then
            MessageBoxShow("cedula en blanco ", True)


        ElseIf Not objEstudiante.ValidarNumero(txtCedula.Text) Then
            MessageBoxShow("cedula: " + txtCedula.Text + " no valida, solo números", True)
        Else
            Dim Dt As DataSet = objEstudiante.BuscarEstudiantes(txtCedula.Text)
            If (Dt.Tables(0).Rows.Count > 0) Then
                Dim dtfacultad = objEstudiante.ListarFaculdates()
                cbFacultad.DataSource = dtfacultad
                cbFacultad.DataBind()
                cbFacultad.Items.Insert(0, New ListItem("--Seleccionar Facultad--", "0"))

                txtCedula.Enabled = False
                btnActualizar.Visible = True
                btnEliminar.Visible = True
                btnbuscar.Visible = False
                btnAgregar.Visible = False
                txtnombre.Text = Dt.Tables(0).Rows(0).Item("nombre")
                txtapellido.Text = Dt.Tables(0).Rows(0).Item("apellido")
                txtdireccion.Text = Dt.Tables(0).Rows(0).Item("direccion")
                txtcelular.Text = Dt.Tables(0).Rows(0).Item("celular")
                txtcorreo.Text = Dt.Tables(0).Rows(0).Item("correo")
                cbFacultad.SelectedValue = Dt.Tables(0).Rows(0).Item("cod_facultad")
                txtindice.Text = Dt.Tables(0).Rows(0).Item("indice_academico")
                MessageBoxShow("Estudiante con cedula: " + txtCedula.Text + " Nombre: " + txtnombre.Text + " fue encontrado")
                If Dt.Tables(0).Rows(0).Item("estatus") = 1 Then
                    cbestado.SelectedIndex = 0
                Else
                    cbestado.SelectedIndex = 1
                End If


                cbsexo.SelectedValue = Dt.Tables(0).Rows(0).Item("sexo")
                Dim dtcb As DataSet = objEstudiante.BuscarCarreras(Dt.Tables(0).Rows(0).Item("cod_facultad"))
                cbcarreras.DataSource = dtcb.Tables(0)
                cbcarreras.DataTextField = dtcb.Tables(0).Columns(1).ColumnName
                cbcarreras.DataValueField = dtcb.Tables(0).Columns(0).ColumnName
                cbcarreras.DataBind()
                cbcarreras.SelectedValue = Dt.Tables(0).Rows(0).Item("cod_carrera")
                cbcarreras.Items.Insert(0, New ListItem("--Seleccionar Carrera--", "0"))

            Else
                btnActualizar.Visible = False
                btnEliminar.Visible = False
                btnAgregar.Visible = True
                txtCedula.Enabled = False

                txtnombre.Text = ""
                txtapellido.Text = ""
                txtdireccion.Text = ""
                txtcelular.Text = ""
                txtcorreo.Text = ""
                cbFacultad.SelectedIndex = -1
                txtindice.Text = ""
                cbsexo.SelectedIndex = -1
                cbcarreras.DataSource = {}

                MessageBoxShow("Estudiante con cedula: " + txtCedula.Text + " no fue encontrado, puede crearlo", True)
            End If
            txtnombre.Enabled = True
            txtapellido.Enabled = True
            txtdireccion.Enabled = True
            txtcelular.Enabled = True
            txtcorreo.Enabled = True
            cbFacultad.Enabled = True
            txtindice.Enabled = True
            cbsexo.Enabled = True
            cbcarreras.Enabled = True
            cbestado.Enabled = True
        End If

    End Sub

    Protected Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If (validateValues()) Then
            Try
                Dim modeloEstudiante As New modeloEstudiante()
                modeloEstudiante.Cedula = txtCedula.Text
                modeloEstudiante.Nombre = txtnombre.Text
                modeloEstudiante.Apellido = txtapellido.Text
                modeloEstudiante.Direccion = txtdireccion.Text
                modeloEstudiante.celular = txtcelular.Text
                modeloEstudiante.correo = txtcorreo.Text
                modeloEstudiante.cod_facultad = cbFacultad.SelectedValue
                modeloEstudiante.cod_carrera = cbcarreras.SelectedValue
                modeloEstudiante.indice_academico = txtindice.Text
                modeloEstudiante.sexo = cbsexo.SelectedValue
                modeloEstudiante.estatus = cbestado.SelectedValue

                If objEstudiante.ActualizarEstudiantes(modeloEstudiante) Then
                    listarTable()
                    MessageBoxShow("Estudiante con cedula: " + txtCedula.Text + " Nombre: " + txtnombre.Text + " fue actualizado")
                Else
                    MessageBoxShow("Estudiante con cedula: " + txtCedula.Text + " Nombre: " + txtnombre.Text + " no fue actualizado", True)
                End If
            Catch ex As Exception
                MessageBoxShow("Error", True)
            End Try

        End If
    End Sub

    Protected Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click


        If (validateValues()) Then
            Try
                Dim modeloEstudiante As New modeloEstudiante()
                modeloEstudiante.Cedula = txtCedula.Text
                modeloEstudiante.Nombre = txtnombre.Text
                modeloEstudiante.Apellido = txtapellido.Text
                modeloEstudiante.Direccion = txtdireccion.Text
                modeloEstudiante.celular = txtcelular.Text
                modeloEstudiante.correo = txtcorreo.Text
                modeloEstudiante.cod_facultad = cbFacultad.SelectedValue
                modeloEstudiante.cod_carrera= cbcarreras.SelectedValue
                modeloEstudiante.indice_academico = txtindice.Text
                modeloEstudiante.sexo = cbsexo.SelectedValue
                modeloEstudiante.estatus = cbestado.SelectedValue

                If objEstudiante.CrearEstudiantes(modeloEstudiante) Then
                    btnAgregar.Visible = False
                    btnActualizar.Visible = True
                    btnEliminar.Visible = True
                    txtCedula.Visible = False
                    listarTable()
                    MessageBoxShow("Estudiante con cedula: " + txtCedula.Text + " Nombre: " + txtnombre.Text + " fue agregado")
                Else
                    MessageBoxShow("Estudiante con cedula: " + txtCedula.Text + " Nombre: " + txtnombre.Text + " no fue agregado", True)
                End If
            Catch ex As Exception

            End Try

        End If

    End Sub
    Private Function validateValues()
        Dim result As Boolean = True
        If (Not objEstudiante.ValidarLetras(txtnombre.Text)) Then
            MessageBoxShow("el nombre: " + txtnombre.Text + " no valido", True)
            result = False
        ElseIf Not objEstudiante.Validarcorreo(txtcorreo.Text) Then
            MessageBoxShow("correo: " + txtcorreo.Text + " no es un correo, ejemplo@correo.com")
            result = False
        ElseIf Not objEstudiante.ValidarLetras(txtapellido.Text) Then
            MessageBoxShow("el apellido: " + txtapellido.Text + " no valido")
            result = False
        ElseIf Not objEstudiante.ValidarLetras(txtdireccion.Text) Then
            MessageBoxShow("direccion: " + txtdireccion.Text + " no valida")
            result = False
        ElseIf Not objEstudiante.ValidarNumero(txtCedula.Text) Then
            MessageBoxShow("cedula: " + txtCedula.Text + " no valida, solo números")
            result = False
        ElseIf Not objEstudiante.ValidarNumero(txtcelular.Text.Trim()) Then
            MessageBoxShow("celular: " + txtcelular.Text + " no valido, solo números")
            result = False
        ElseIf cbFacultad.SelectedIndex <= 0 Then
            MessageBoxShow("debe seleccionar una facultad")
            result = False
        ElseIf cbcarreras.SelectedIndex <= 0 Then
            MessageBoxShow("debe seleccionar una carrera")
            result = False
        ElseIf Not objEstudiante.ValidarNumero(txtindice.Text) Then
            MessageBoxShow("indice: " + txtindice.Text + " no valido, solo números")
            result = False
        ElseIf objEstudiante.ValidarNumero(txtindice.Text) Then
            If Not String.IsNullOrEmpty(txtindice.Text) Then
                If txtindice.Text > 0 And txtindice.Text <= 3 Then


                Else
                    MessageBoxShow("indice: " + txtindice.Text + " no valido, valor entre 0 y 3")
                    result = False
                End If
            End If
        End If

        If cbsexo.SelectedIndex < 0 Then
            MessageBoxShow("debe seleccionar el sexo")
            result = False
        ElseIf cbestado.SelectedIndex < 0 Then
            MessageBoxShow("debe seleccionar el estatus")
            result = False
        End If
        Return result
    End Function

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If String.IsNullOrEmpty(txtCedula.Text) Then
            MessageBoxShow("cedula en blanco ", True)
        ElseIf Not objEstudiante.ValidarNumero(txtCedula.Text) Then
            MessageBoxShow("cedula: " + txtCedula.Text + " no valida, solo números")
        Else
            Try
                If objEstudiante.EliminarEstudiantes(txtCedula.Text) Then

                    MessageBoxShow("Estudiante con cedula: " + txtCedula.Text + " Nombre: " + txtnombre.Text + " fue eliminado")
                    listarTable()
                    limpiar()
                Else

                    MessageBoxShow("Estudiante con cedula: " + txtCedula.Text + " Nombre: " + txtnombre.Text + " no fue eliminado", True)
                End If
            Catch ex As Exception

            End Try

        End If
    End Sub

    Protected Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        MessageResponse = ""
        Timer1.Enabled = False
        ParrafoDinamico.Visible = False
    End Sub

    Private Function MessageBoxShow(value As String, Optional warning As Boolean = False)
        MessageResponse = value
        ParrafoDinamico.Visible = True
        If (warning) Then
            ParrafoDinamico.Attributes.Add("class", "bg-warning")
        Else
            ParrafoDinamico.Attributes.Add("class", "bg-success")
        End If
        Timer1.Enabled = True
    End Function
End Class