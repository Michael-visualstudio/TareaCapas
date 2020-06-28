<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tarea.aspx.cs" Inherits="WebCapasTarea.inicio.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
&nbsp;
            <asp:Label ID="lblNum" runat="server" Text="Ingrese un número"></asp:Label>
            <asp:TextBox ID="txtNum" runat="server"></asp:TextBox>
        </p>
        <p>
&nbsp;<asp:Label ID="lblNmes" runat="server" Text="Ingrese un valor"></asp:Label>
&nbsp;<asp:TextBox ID="txtNmes" runat="server"></asp:TextBox>
            <asp:Button ID="btnEjecutar" runat="server" Text="Ejecutar" OnClick="btnEjecutar_Click" />
        </p>
        <p>
            <asp:Label ID="lblResultnum" runat="server"></asp:Label>
        </p>
        <asp:Label ID="lblResultnmes" runat="server"></asp:Label>
    </form>
</body>
</html>
