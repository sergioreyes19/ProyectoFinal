<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VentaListado.aspx.cs" Inherits="ProyectoFinal.VentaListado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <h2><%: Title %>Venta</h2>

    <div >
        <table style="width: 100%;">
            <tr>
                <th>Cliente</th>
                <th>Fecha</th>
                <th>Producto</th>
                <th>Estado</th>
                <th></th>
                
            </tr>
            <tr>
                <td>Sergio Reyes</td>
                <td>01/01/2020</td>
                <td>Coca cola</td>
                <td>Entregado</td>
                <td><a runat="server" href="~/VentaDetalle"><input id="Button1" type="button" value="Detalle" class="btn btn-info"/></a></td>
            </tr>
        </table>
    </div>
</asp:Content>
