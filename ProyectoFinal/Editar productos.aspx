<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Editar productos.aspx.cs" Inherits="ProyectoFinal.Editar_productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    

    
    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Height="139px" Width="201px">
        <Columns>
            <asp:CommandField SelectText="Editar" ShowSelectButton="True" />

        </Columns>
    </asp:GridView>



    codigo del producto
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    Nombre del producto<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    Marca<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    Descripcion del producto<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <br />
    imgen del producto<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
    <br />
    precio de compra<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    <br />
    precio de venta<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    <br />
    cantidad en existencia<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Buscar" />



</asp:Content>
