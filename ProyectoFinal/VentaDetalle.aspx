<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VentaDetalle.aspx.cs" Inherits="ProyectoFinal.VentaDetalle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <h2><%: Title %> Venta Detalle</h2>

    <div class="form-group">
        <div class="col-md-12 mb-12">
            <label class="label-control">Codigo venta</label>
            <input id="txtcodigo" type="text" class="form-control" value="101010"/>
        </div>
    </div>
       
    <div class="form-row">
        <div class="col-md-4 mb-3">
            <label>Cliente</label>
            <input id="txtcliente" type="text" class="form-control" value="Sergio Reyes"/>
        </div>
        <div class="col-md-4 mb-3">
            <label>Fecha</label>
            <input id="txtfecha" type="text" class="form-control" value="01/01/2020"/>
        </div>
        <div class="col-md-4 mb-3">
            <label>Total</label>
            <input id="txttotal" type="text" class="form-control" value="550"/>
        </div>
    </div>
    <br />
    <br />
    <table style="width: 100%;">
            <tr>
                <th>Producto</th>
                <th>Marca</th>
                <th>Cantidad</th>
                <th>Precio</th>
                <th>Sub total</th>
                
            </tr>
            <tr>
                <td>Agua</td>
                <td>Coca cola</td>
                <td>10</td>
                <td>5</td>
                <td>50</td>
            </tr>
            <tr>
                <td>Agua</td>
                <td>Pepsi Cola</td>
                <td>50</td>
                <td>10</td>
                <td>500</td>
            </tr>
        </table>
</asp:Content>
