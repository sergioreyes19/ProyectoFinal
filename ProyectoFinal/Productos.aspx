<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="ProyectoFinal.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>Producto nuevo</h2>
    
    <div class="col-md-4 mb-3">
            <label>Codigo del producto</label>
            <asp:TextBox ID="Txtcodigo" runat="server" class="form-control" MaxLength="6"></asp:TextBox>
        </div>

    <div class="form-group">
        <label class="label-control">Nombre del producto</label>
        <asp:TextBox ID="Txtnombre" runat="server" class="form-control"></asp:TextBox>
    </div>
       
    <div class="form-row">
        
        <div class="col-md-4 mb-3">
            <label>Precio de compra</label>
                <asp:TextBox ID="Txtpreciocompra" runat="server" class="form-control"></asp:TextBox>
        </div>
        <div class="col-md-4 mb-3">
            <label>Precio de venta</label>
            <asp:TextBox ID="Txtprecioventa" runat="server" class="form-control"></asp:TextBox>
        </div>

        <div class="col-md-4 mb-3">
            <label>Marca</label>&nbsp;
            <asp:DropDownList ID="DropDownMarca" runat="server">
            </asp:DropDownList>
        </div>
        <div class="col-md-4 mb-3">
            <label>cantidad en existencia</label>
            <asp:TextBox ID="Txtcantidad" runat="server" class="form-control"></asp:TextBox>
        </div>
        <div class="col-md-4 mb-3">
            <label>Imagen del Producto</label>
            <input id="File1" type="file" class="form-control"/>
        </div>
       
    </div>

    <div class="form-group">
                <label>Descripcion del Producto</label>
        <asp:TextBox ID="txtdescripcion" runat="server"></asp:TextBox>
    </div>

    <div>
            <asp:Button ID="Button1" runat="server" Text="Guardar" Class="btn btn-success" OnClick="Button1_Click" />
    </div>

</asp:Content>
