<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmPrincipal.aspx.cs" Inherits="Proyecto.Web.Inferfaces.frmPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width: 100%">
            <tr>
                <td style="width: 50%">Identificacion:</td>
                <td style="width: 50%">
                    <asp:TextBox ID="txtIdentificacion" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 50%">Nombres:</td>
                <td style="width: 50%">
                    <asp:TextBox ID="txtNombres" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 50%">Apellidos:</td>
                <td style="width: 50%">
                    <asp:TextBox ID="txtApellidos" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 50%" colspan="2">
                    <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
                    <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click"  />
                    <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click"  />
                </td>
            </tr>
             <tr>
                <td style="width: 50%" colspan="2">
                  
                    <asp:Label ID="lblMensaje" runat="server" style="color: #FF3300; font-weight: 700"></asp:Label>
                  
                </td>
            </tr>
            <tr>
                <td style="width: 50%" colspan="2">
                    <asp:GridView ID="gvwDatos" runat="server" AutoGenerateColumns="False" Width="100%" CellPadding="4" ForeColor="#333333" GridLines="None" EmptyDataText="No se encontraron registros">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField HeaderText="Identificacion" DataField="clieIdentificacion"/>
                             <asp:BoundField HeaderText="Nombres" DataField="clieNombres"/>
                             <asp:BoundField HeaderText="Apellidos" DataField="clieApellidos"/>
                        </Columns>
                        <EditRowStyle BackColor="#7C6F57" />
                        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#E3EAEB" />
                        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F8FAFA" />
                        <SortedAscendingHeaderStyle BackColor="#246B61" />
                        <SortedDescendingCellStyle BackColor="#D4DFE1" />
                        <SortedDescendingHeaderStyle BackColor="#15524A" />
                    </asp:GridView>
                  
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
