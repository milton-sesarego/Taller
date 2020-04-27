<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmProductos.aspx.cs" Inherits="WebApp.WebForm1" EnableEventValidation="false"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
	<style type="text/css">
		#txtDescripcion {
        }
	</style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
        <br />
		<asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
		<br />
        <asp:Label ID="lblDescripcion" runat="server" Text="Descripcion"></asp:Label>
        <br />
		<asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine" Rows="3"></asp:TextBox>
		<br />
        <asp:Label ID="lblPrecio" runat="server" Text="Precio"></asp:Label>
        <br />
		<asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
		<br />
        <asp:Label ID="lblStock" runat="server" Text="Stock"></asp:Label>
        <br />
		<asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
		<br />
		<br />
		<asp:Button ID="btnGuardar" runat="server" Text="Nuevo" OnClick="btnGuardar_Click" />
		<asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
		<asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
		<asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
		<br />
		<br />
		<asp:GridView ID="dgv" runat="server" OnRowDataBound="dgv_RowDataBound" OnSelectedIndexChanged="dgv_SelectedIndexChanged"></asp:GridView>
        <br />
    </form>
</body>
</html>
