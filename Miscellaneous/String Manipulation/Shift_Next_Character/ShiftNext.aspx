<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShiftNext.aspx.cs" Inherits="ShiftNext" %>

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
                    <td>Enter the string
                    </td>
                    <td>
                        <asp:TextBox ID="txtInputString" runat="server">
                        </asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnShowResult" runat="server" OnClick="btnShowResult_Click" Text="Click for result" />
                    </td>
                </tr>
                <tr>
                    <td>The result is 
                    </td>
                    <td>
                        <asp:Label ID="lblResult" runat="server"></asp:Label>
                    </td>
                    <td>

                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
