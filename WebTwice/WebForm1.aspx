<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebTwice.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>TWICE</h1>
            <asp:Button ID="btnMostrar" runat="server" Text="Mostrar Integrantes" OnClick="btnMostrar_Click" />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Height="156px" Width="432px"></asp:ListBox>
            <br />
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar una Integrante" OnClick="btnAgregar_Click"/>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label>
            <br />
            <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
            <br />
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Edad"></asp:Label>
            <br />
            <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
