<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServiceCenter.aspx.cs" Inherits="QueueCollectionExample.ServiceCenter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 152px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table border="1" style="font-family: Arial; border: 1Px solid black; text-align: center">
            <tr>
                <td class="auto-style1">Counter 1 </td>
                <td></td>
                <td>Counter 2 </td>
                <td></td>
                <td>Counter 3 </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:TextBox ID="TxtCounter1"  runat="server" BackColor="#0033CC" ForeColor="White" Height="20px" Width="150px"></asp:TextBox>
                </td>
                <td></td>
                <td>
                    <asp:TextBox ID="TxtCounter2" runat="server" BackColor="#0033CC" ForeColor="White" Height="20px" Width="150px"></asp:TextBox>
                </td>
                <td></td>
                <td>
                    <asp:TextBox ID="TxtCounter3" runat="server" BackColor="#0033CC" ForeColor="White" Height="20px" Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="btnCounter1" runat="server" Text="Next" Width="114px" OnClick="btnCounter1_Click" />
                </td>
                <td></td>
                <td>
                    <asp:Button ID="btnCounter2" runat="server" Text="Next" Width="115px" OnClick="btnCounter2_Click" />
                </td>
                <td></td>
                <td>
                    <asp:Button ID="btnCounter3" runat="server" Text="Next" Width="116px" OnClick="btnCounter3_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:TextBox ID="txtDisplay" runat="server" BackColor="#0033CC" ForeColor="White" Font-Size="Large" Width="500px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:ListBox ID="ListTokens" Font-Size="Large" runat="server" Width="100px"></asp:ListBox>

                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:Button ID="btnPrintToken" runat="server" Text="Print token" OnClick="btnPrintToken_Click" /></td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:Label ID="lblStatus" runat="server"></asp:Label></td>
            </tr>
        </table>
    </form>
</body>
</html>
