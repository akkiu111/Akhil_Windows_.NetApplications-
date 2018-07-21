<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AkhilMathematicalApplication.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center">
                        <asp:Label ID="Label1" runat="server" Text="Akhil's Calculator" Font-Bold="True" Font-Size="X-Large" ForeColor="#CC3300"></asp:Label>
            <br /><br />

            <table>
                <tr>
                    <td style ="text-align:right">
                              <asp:Label ID="Label2" runat="server" Text="Enter First Number:" Font-Size="Large" ForeColor="#333300"></asp:Label>

                    </td>
                    <td >
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                    </td>
                </tr>

                <tr>
                    <td>
            <asp:Label ID="Label3" runat="server" Text="Enter Second Number:" Font-Size="Large" ForeColor="#333300"></asp:Label>

                    </td>
                    <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td style ="text-align:right">
            <asp:Label ID="Label4" runat="server" Text="Result:" Font-Size="Large" ForeColor="#333300"></asp:Label>

                    </td>
                    <td>
            <asp:TextBox ID="TextBox3" runat="server" Enabled="False"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td style="text-align:right">
            <asp:Button ID="Button1" runat="server" Text="ADD" OnClick="Button1_Click" />
<asp:Button ID="Button2" runat="server" Text="SUB" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="MUL" OnClick="Button3_Click" />
                    </td>
                    <td style="text-align:left">
 <asp:Button ID="Button4" runat="server" Text="DIV" OnClick="Button4_Click" />
            <asp:Button ID="Button5" runat="server" Text="REM" OnClick="Button5_Click" />
            <asp:Button ID="Button6" runat="server" Text="CLEAR" OnClick="Button6_Click" />
                    </td>
                </tr>
            </table>

            
           

        </div>
    </form>
</body>
</html>
