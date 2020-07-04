<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="estadoventa.aspx.cs" Inherits="ProyectoFinal.estadoventa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ButtonType="Button" EditText="Entregar" SelectText="Entregar" ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
    <asp:Button ID="Button1" runat="server" Height="26px" OnClick="Button1_Click" Text="Button" />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</asp:Content>
