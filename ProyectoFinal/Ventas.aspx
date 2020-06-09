<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="ProyectoFinal.Ventas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <h2><%: Title %>Carrito</h2>

    <div class="form-group">
        <div class="col-md-12 mb-12">
            <label class="label-control">Codigo</label>
            <input id="txtcodigo" type="text" class="form-control"/>
        </div>
    </div>
       
    <div class="form-row">
        <div class="col-md-4 mb-3">
            <label>Nit</label>
            <input id="txtnit" type="text" class="form-control"/>
        </div>
        <div class="col-md-4 mb-3">
            <label>Fecha</label>
            <input id="txtfecha" type="text" class="form-control"/>
        </div>
        <div class="col-md-4 mb-3">
            <label>Total</label>
            <input id="txttotal" type="text" class="form-control"/>
        </div>
    </div>

    <div class="form-group">
        <div class="col-md-12 mb-12">
            <label>Estado</label>
            <input id="txtestado" type="text" class="form-control"/>
        </div>
    </div>
  
    <div class="col-md-12 mb-12">
        <input id="btnagregar" type="button" value="Agregar"  class="btn btn-primary"/>
    </div>

    <div >
        <table style="width: 100%;">
            <tr>
                <th></th>
                <th>Nombre producto</th>
                <th>Cantidad</th>
                <th>Precio</th>
                <th>Total</th>
                
            </tr>
            <tr>
                <td>
                    <input id="Button1" type="button" value="x" /></td>
                <td>Coca cola</td>
                <td>10</td>
                <td>5</td>
                <td>50</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>

     <div class="col-md-12 mb-12">
        <input id="btnguardarv" type="button" value="Guardar"  class="btn btn-success"/>
    </div>
</asp:Content>
