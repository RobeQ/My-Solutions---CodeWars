<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASPDemo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 371px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Employee Id:"></asp:Label>
            <asp:TextBox ID="TextBoxEID" runat="server"></asp:TextBox>
            <asp:LinkButton ID="LinkButtonGetEmployee" runat="server" OnClick="LinkButtonGetEmployee_Click">Go</asp:LinkButton>
        </div>
        <p>
            &nbsp;</p>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">First Name</td>
                <td>
                    <asp:TextBox ID="TextBoxFirstName" runat="server" style="margin-left: 0px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Last Name</td>
                <td>
                    <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Department</td>
                <td>
                    <asp:TextBox ID="TextBoxDepartment" runat="server"></asp:TextBox>
                    <asp:LinkButton ID="LinkButtonUpdateDeptName" runat="server" OnClick="LinkButtonUpdateDeptName_Click">Update</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:GridView ID="GridViewAppLog" runat="server">
                    </asp:GridView>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="LabelDeptId" runat="server" Text="0"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:LinkButton ID="LinkButtonDeleteLogApplication" runat="server" OnClick="LinkButtonDeleteLogApplication_Click">Delete Log</asp:LinkButton>
                    <br />
                    <asp:Label ID="LabelError" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelOldName" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
