<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="ProyectoFinal.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>Producto nuevo</h2>
    <div class="form-group">
        <label class="label-control">Nombre del producto</label>
        <asp:TextBox ID="TextBox2" runat="server" class="form-control"></asp:TextBox>
    </div>
       
    <div class="form-row">
        <div class="col-md-4 mb-3">
            <label>Codigo del producto</label>
            <asp:TextBox ID="TextBox1" runat="server" class="form-control" MaxLength="6"></asp:TextBox>
        </div>
        <div class="col-md-4 mb-3">
            <label>Precio de compra</label>
                <asp:TextBox ID="TextBox6" runat="server" class="form-control"></asp:TextBox>
        </div>
        <div class="col-md-4 mb-3">
            <label>Precio de venta</label>
            <asp:TextBox ID="TextBox7" runat="server" class="form-control"></asp:TextBox>
        </div>

        <div class="col-md-4 mb-3">
            <label>Marca</label>
            <select id="Select1" class="form-control">
                <option>Seleccione</option>
            </select>
        </div>
        <div class="col-md-4 mb-3">
            <label>cantidad en existencia</label>
            <asp:TextBox ID="TextBox8" runat="server" class="form-control"></asp:TextBox>
        </div>
        <div class="col-md-4 mb-3">
            <label>Imagen del Producto</label>
            <input id="File1" type="file" class="form-control"/>
        </div>
       
    </div>

    <div class="form-group">
                <label>Descripcion del Producto</label>
            <textarea id="TextArea1" cols="20" name="S1" rows="2" class="form-control"></textarea>
    </div>

    <div>
            <asp:Button ID="Button1" runat="server" Text="Guardar" Class="btn btn-success" />
    </div>

</asp:Content>
