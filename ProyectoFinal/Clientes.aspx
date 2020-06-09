<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="ProyectoFinal.Clientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2><%: Title %>Clientes</h2>
    <div class="form-group">
        <div class="col-md-12 mb-12">
            <label class="label-control">Nit</label>
            <input id="txtnit" type="text" class="form-control"/>
        </div>
    </div>
       
    <div class="form-row">
        <div class="col-md-4 mb-3">
            <label>Nombre</label>
            <input id="txtnombre" type="text" class="form-control"/>
        </div>
        <div class="col-md-4 mb-3">
            <label>Apellido</label>
            <input id="txtapellido" type="text" class="form-control"/>
        </div>
        <div class="col-md-4 mb-3">
            <label>Telefono</label>
            <input id="txttelefono" type="text" class="form-control"/>
        </div>
    </div>

    <div class="form-group">
        <div class="col-md-12 mb-12">
            <label>Direcciòn</label>
            <input id="txtdireccion" type="text" class="form-control"/>
        </div>
    </div>
  
    <div class="col-md-12 mb-12">
        <input id="btncliente" type="button" value="button"  class="btn btn-success"/>
    </div>

</asp:Content>
