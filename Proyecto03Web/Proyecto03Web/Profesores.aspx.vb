Imports Proyecto03Web.WSP
Public Class Profesores
    Inherits System.Web.UI.Page
    Dim objProfesores As New WebServiceProfesorSoapClient
    Dim objvalidate As New WSE.WebService1SoapClient
    Public MessageResponsep As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnlistarP_Click(sender As Object, e As EventArgs) Handles btnlistarP.Click
        listarTable()
    End Sub

    Private Function listarTable()
        DataGridViewProfesores.DataSource = objProfesores.ListarProfesores().Tables(0)
        DataGridViewProfesores.DataBind()
    End Function

    Protected Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub
    Private Function limpiar()
        txtcodigo.Text = ""
        txtCedula.Text = ""
        txtnombre.Text = ""
        txtapellido.Text = ""
        txtdireccion.Text = ""
        txtcelular.Text = ""
        txtcorreo.Text = ""
        cbFacultad.SelectedIndex = -1
        txtsalario.Text = ""
        cbcategoria.DataSource = {}
        cbestado.SelectedIndex = -1

        txtcodigo.Enabled = True

        btnbuscar.Visible = True
        btnbuscar.Enabled = True

        btnAgregar.Visible = False
        btnActualizar.Visible = False
        btnEliminar.Visible = False

        txtCedula.Enabled = False
        txtnombre.Enabled = False
        txtapellido.Enabled = False
        txtdireccion.Enabled = False
        txtcelular.Enabled = False
        txtcorreo.Enabled = False
        cbFacultad.Enabled = False
        txtsalario.Enabled = False
        cbcategoria.Enabled = False
        cbestado.Enabled = False
    End Function

    Protected Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        If String.IsNullOrEmpty(txtcodigo.Text) Then
            MessageBoxShow("Codigo en blanco ", True)


        ElseIf Not objvalidate.ValidarNumero(txtcodigo.Text) Then
            MessageBoxShow("Codigo: " + txtcodigo.Text + " no valida, solo números", True)
        Else
            Dim dtfacultad = objProfesores.ListarFaculdates()
            cbFacultad.DataSource = dtfacultad
            cbFacultad.DataBind()
            cbFacultad.Items.Insert(0, New ListItem("--Seleccionar Facultad--", "0"))

            Dim dtcb As DataSet = objProfesores.ListarCategoria()
            cbcategoria.DataSource = dtcb.Tables(0)
            cbcategoria.DataTextField = dtcb.Tables(0).Columns(1).ColumnName
            cbcategoria.DataValueField = dtcb.Tables(0).Columns(0).ColumnName
            cbcategoria.DataBind()
            cbcategoria.Items.Insert(0, New ListItem("--Seleccionar categoria--", "0"))

            Dim Dt As DataSet = objProfesores.BuscarProfesors(txtcodigo.Text)
            If (Dt.Tables(0).Rows.Count > 0) Then


                txtcodigo.Enabled = False
                txtCedula.Enabled = True
                btnActualizar.Visible = True
                btnEliminar.Visible = True
                btnbuscar.Visible = False
                btnAgregar.Visible = False
                txtCedula.Text = Dt.Tables(0).Rows(0).Item("cedula")
                txtnombre.Text = Dt.Tables(0).Rows(0).Item("nombre")
                txtapellido.Text = Dt.Tables(0).Rows(0).Item("apellido")
                txtdireccion.Text = Dt.Tables(0).Rows(0).Item("direccion")
                txtcelular.Text = Dt.Tables(0).Rows(0).Item("celular")
                txtcorreo.Text = Dt.Tables(0).Rows(0).Item("correo")
                cbFacultad.SelectedValue = Dt.Tables(0).Rows(0).Item("cod_facultad")
                txtsalario.Text = Dt.Tables(0).Rows(0).Item("salario_base")
                MessageBoxShow("Profesor con Codigo: " + txtcodigo.Text + " Nombre: " + txtnombre.Text + " fue encontrado")
                If Dt.Tables(0).Rows(0).Item("estatus") = 1 Then
                    cbestado.SelectedIndex = 0
                Else
                    cbestado.SelectedIndex = 1
                End If




                Try
                    cbcategoria.SelectedValue = Dt.Tables(0).Rows(0).Item("cod_categoria")
                Catch ex As Exception

                End Try



            Else
                btnActualizar.Visible = False
                btnEliminar.Visible = False
                btnAgregar.Visible = True
                txtcodigo.Enabled = False

                txtnombre.Text = ""
                txtapellido.Text = ""
                txtdireccion.Text = ""
                txtcelular.Text = ""
                txtcorreo.Text = ""
                cbFacultad.SelectedIndex = -1
                txtsalario.Text = ""
                cbcategoria.DataSource = {}

                MessageBoxShow("Profesor con codigo: " + txtcodigo.Text + " no fue encontrado, puede crearlo", True)
            End If

            txtCedula.Enabled = True
            txtnombre.Enabled = True
            txtapellido.Enabled = True
            txtdireccion.Enabled = True
            txtcelular.Enabled = True
            txtcorreo.Enabled = True
            cbFacultad.Enabled = True
            txtsalario.Enabled = True
            cbcategoria.Enabled = True
            cbestado.Enabled = True
        End If

    End Sub

    Protected Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If (validateValues()) Then
            Try
                Dim modeloProfesor As New ModeloProfesor()
                modeloProfesor.codigo = txtcodigo.Text
                modeloProfesor.Cedula = txtCedula.Text
                modeloProfesor.Nombre = txtnombre.Text
                modeloProfesor.Apellido = txtapellido.Text
                modeloProfesor.Direccion = txtdireccion.Text
                modeloProfesor.celular = txtcelular.Text
                modeloProfesor.correo = txtcorreo.Text
                modeloProfesor.cod_facultad = cbFacultad.SelectedValue
                modeloProfesor.cod_categoria = cbcategoria.SelectedValue
                modeloProfesor.salario = txtsalario.Text
                modeloProfesor.estatus = cbestado.SelectedValue

                If objProfesores.ActuaizarProfesor(modeloProfesor) Then
                    listarTable()
                    MessageBoxShow("Profesor con cedula: " + txtcodigo.Text + " Nombre: " + txtnombre.Text + " fue actualizado")
                Else
                    MessageBoxShow("Profesor con cedula: " + txtcodigo.Text + " Nombre: " + txtnombre.Text + " no fue actualizado", True)
                End If
            Catch ex As Exception
                MessageBoxShow("Error", True)
            End Try

        End If
    End Sub

    Protected Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click


        If (validateValues()) Then
            Try
                Dim modeloProfesor As New ModeloProfesor()
                modeloProfesor.codigo = txtcodigo.Text
                modeloProfesor.Cedula = txtCedula.Text
                modeloProfesor.Nombre = txtnombre.Text
                modeloProfesor.Apellido = txtapellido.Text
                modeloProfesor.Direccion = txtdireccion.Text
                modeloProfesor.celular = txtcelular.Text
                modeloProfesor.correo = txtcorreo.Text
                modeloProfesor.cod_facultad = cbFacultad.SelectedValue
                modeloProfesor.cod_categoria = cbcategoria.SelectedValue
                modeloProfesor.salario = txtsalario.Text
                modeloProfesor.estatus = cbestado.SelectedValue

                If objProfesores.CrearProfesor(modeloProfesor) Then
                    btnAgregar.Visible = False
                    btnActualizar.Visible = True
                    btnEliminar.Visible = True
                    txtcodigo.Enabled = False
                    listarTable()
                    MessageBoxShow("Profesor con cedula: " + txtcodigo.Text + " Nombre: " + txtnombre.Text + " fue agregado")
                Else
                    MessageBoxShow("Profesor con cedula: " + txtcodigo.Text + " Nombre: " + txtnombre.Text + " no fue agregado", True)
                End If
            Catch ex As Exception

            End Try

        End If

    End Sub
    Private Function validateValues()
        Dim result As Boolean = True
        If (Not objvalidate.ValidarNumero(txtcodigo.Text.Trim())) Then
            MessageBoxShow("el Codigo: " + txtcodigo.Text + " no valido", True)
            result = False
        ElseIf Not objvalidate.ValidarNumero(txtCedula.Text.Trim()) Then
            MessageBoxShow("cedula: " + txtCedula.Text + " no valida, solo números")
            result = False
        ElseIf (Not objvalidate.ValidarLetras(txtnombre.Text.Trim())) Then
            MessageBoxShow("el nombre: " + txtnombre.Text + " no valido", True)
            result = False
        ElseIf Not objvalidate.Validarcorreo(txtcorreo.Text.Trim()) Then
            MessageBoxShow("correo: " + txtcorreo.Text + " no es un correo, ejemplo@correo.com")
            result = False
        ElseIf Not objvalidate.ValidarLetras(txtapellido.Text.Trim()) Then
            MessageBoxShow("el apellido: " + txtapellido.Text + " no valido")
            result = False
        ElseIf Not objvalidate.ValidarLetras(txtdireccion.Text.Trim()) Then
            MessageBoxShow("direccion: " + txtdireccion.Text + " no valida")
            result = False
        ElseIf Not objvalidate.ValidarNumero(txtcelular.Text.Trim()) Then
            MessageBoxShow("celular: " + txtcelular.Text + " no valido, solo números")
            result = False
        ElseIf cbFacultad.SelectedIndex <= 0 Then
            MessageBoxShow("debe seleccionar una facultad")
            result = False
        ElseIf cbcategoria.SelectedIndex <= 0 Then
            MessageBoxShow("debe seleccionar una categoria")
            result = False
        ElseIf Not objvalidate.ValidarNumero(txtsalario.Text.Trim()) Then
            MessageBoxShow("salario: " + txtsalario.Text + " no valido, solo números")
            result = False
        ElseIf cbestado.SelectedIndex < 0 Then
            MessageBoxShow("debe seleccionar el estatus")
            result = False
        End If
        Return result
    End Function

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If String.IsNullOrEmpty(txtcodigo.Text) Then
            MessageBoxShow("codigo en blanco ", True)
        ElseIf Not objvalidate.ValidarNumero(txtcodigo.Text) Then
            MessageBoxShow("codigo: " + txtcodigo.Text + " no valida, solo números")
        Else
            Try
                If objProfesores.EliminarProfesor(txtcodigo.Text) Then

                    MessageBoxShow("Profesore con cedula: " + txtcodigo.Text + " Nombre: " + txtnombre.Text + " fue eliminado")
                    listarTable()
                    limpiar()
                Else

                    MessageBoxShow("Profesore con cedula: " + txtcodigo.Text + " Nombre: " + txtnombre.Text + " no fue eliminado", True)
                End If
            Catch ex As Exception

            End Try

        End If
    End Sub

    Protected Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        MessageResponsep = ""
        Timer1.Enabled = False
        ParrafoDinamico.Visible = False
    End Sub

    Private Function MessageBoxShow(value As String, Optional warning As Boolean = False)
        MessageResponsep = value
        ParrafoDinamico.Visible = True
        If (warning) Then
            ParrafoDinamico.Attributes.Add("class", "bg-warning")
        Else
            ParrafoDinamico.Attributes.Add("class", "bg-success")
        End If
        Timer1.Enabled = True
    End Function
End Class