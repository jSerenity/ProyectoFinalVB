<%@ Page Title="Estudiantes" MessageResponse="" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Estudiantes.aspx.vb" Inherits="Proyecto03Web.Estudiantes" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.
    </h2>
    <div class="body-content">

        <div class="row">
            <p id="ParrafoDinamico" runat="server" style="padding: 15px"><%: MessageResponse %>
                
            </p>
            <asp:Timer ID="Timer1" runat="server" Interval="3000" >
                </asp:Timer>
        </div>
  <div class="row">
    <div class="col-md-8">
        <asp:Button ID="btnlistarE" runat="server" Text="Listar estudiantes" class="btn btn-primary"/>
        <asp:GridView ID="DataGridViewEstudiantes" runat="server" Width="387px" Height="196px" CssClass="table table-condensed table-hover">
        </asp:GridView>
    </div>
    <div class="col-md-4">
        <div class="row">
            <div class="col-md-2">
                   <asp:Button ID="btnbuscar" runat="server" Text="Buscar" class="btn btn-default"/>
             </div>
        </div>
          <div class="row">
            
            <div class="col-md-2">
                  <asp:Button ID="btnAgregar" runat="server" Text="Agregar" class="btn btn-success"/>
                </div>
            <div class="col-md-2">
                <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" class="btn btn-primary" />
                </div>
            <div class="col-md-2">
                 <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" class="btn btn-danger"/>
                </div>
            <div class="col-md-2">
                <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" class="btn btn-warning" />
            </div>
        </div>
          <div class="form-group">
              <asp:Label ID="Label1" runat="server" Text="Cedula" for="MainContent_txtCedula" class="col-sm-2 control-label"></asp:Label>
                
            <%--<div class="col-sm-10">--%>
                 <asp:TextBox ID="txtCedula" runat="server"  class="form-control"></asp:TextBox>
            <%--</div>--%>
         </div>
          <div class="form-group">
                  <asp:Label ID="Label2" runat="server" Text="Nombre" class="col-sm-2 control-label"></asp:Label>
                    <asp:TextBox ID="txtnombre" runat="server" class="form-control"></asp:TextBox>
             </div>
  
     
          <div class="form-group">
                  <asp:Label ID="Label3" runat="server" Text="Apellido" class="col-sm-2 control-label"></asp:Label>
        <asp:TextBox ID="txtapellido" runat="server" class="form-control"></asp:TextBox>
             </div>
    
          <div class="form-group">
                  <asp:Label ID="Label4" runat="server" Text="Dirección" class="col-sm-2 control-label"></asp:Label>
        <asp:TextBox ID="txtdireccion" runat="server" class="form-control"></asp:TextBox>
             </div>
        
          <div class="form-group">
              <asp:Label ID="Label5" runat="server" Text="Celular" class="col-sm-2 control-label"></asp:Label>
    <asp:TextBox ID="txtcelular" runat="server" class="form-control"></asp:TextBox>
         </div>
    
          <div class="form-group">
               <asp:Label ID="Label6" runat="server" Text="Correo" class="col-sm-2 control-label"></asp:Label>
               <asp:TextBox ID="txtcorreo" runat="server" class="form-control"></asp:TextBox>
         </div>
          <div class="form-group">
        <asp:Label ID="Label7" runat="server" Text="Indice" class="col-sm-2 control-label"></asp:Label>
    <asp:TextBox ID="txtindice" runat="server" class="form-control"></asp:TextBox>
        </div>
    

        <div class="form-group">
            <asp:Label ID="Label8" runat="server" Text="Facultad" class="col-sm-2 control-label"></asp:Label>
    <asp:DropDownList ID="cbFacultad" runat="server" AutoPostBack="true" EnableViewState="true" OnSelectedIndexChanged="cbFacultad_SelectedIndexChanged" DataTextField="facultad" DataValueField="codigo" class="form-control"></asp:DropDownList>
    
        </div>

        <div class="form-group">
            <asp:Label ID="Label9" runat="server" Text="Carrera" class="col-sm-2 control-label"></asp:Label>
        <asp:DropDownList ID="cbcarreras" runat="server" class="form-control"></asp:DropDownList>
            </div>
        
        <div class="form-group">
                <asp:Label ID="Label10" runat="server" Text="Sexo" class="col-sm-2 control-label"></asp:Label>
     <asp:DropDownList ID="cbsexo" runat="server" class="form-control">

        <asp:ListItem>M</asp:ListItem>
        <asp:ListItem>F</asp:ListItem>
    </asp:DropDownList>
        </div>

        <div class="form-group">
            <asp:Label ID="Label11" runat="server" Text="Estado" class="col-sm-2 control-label"></asp:Label>
    <asp:DropDownList ID="cbestado" runat="server" class="form-control">
        <asp:ListItem Value="1">Activo</asp:ListItem>
        <asp:ListItem Value="0">InActivo</asp:ListItem>
    </asp:DropDownList>
        </div>
    
    </div>   
  </div>
</div>
   
   
     
</asp:Content>
