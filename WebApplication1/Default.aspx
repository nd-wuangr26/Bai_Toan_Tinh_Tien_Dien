<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
               <tr>
                   <td colspan ="2">
                       WEB V1: TÍNH TIỀN ĐIỆN
                   </td>
               </tr>
                <tr>
                    <td>Nhập số điện: </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Tính tiền" OnClick="Button1_Click" />
                    </td>
                </tr>
                <tr>
                        <td colspan="2" id="ketqua" runat="server"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
