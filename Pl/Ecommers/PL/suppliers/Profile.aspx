<%@ Page Title="" Language="C#" MasterPageFile="~/suppliers/SuppliersSite.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Ecommers.PL.suppliers.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
<br />
        <table align="center" style="width: 40%">
            <tr>
                <td colspan="3" style="text-align: center">infromation
                    <asp:Label ID="Nameuser" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="height: 38px; width: 124px">Fullname</td>
                <td style="height: 38px; width: 217px">
                    <asp:TextBox ID="txtfull" runat="server"></asp:TextBox>
                </td>
                <td style="height: 38px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 124px">Username</td>
                <td style="width: 217px">
                    <asp:TextBox ID="txtuser" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 124px">Password</td>
                <td style="width: 217px">
                    <asp:TextBox ID="txtpass" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 124px">Phone</td>
                <td style="width: 217px">
                    <asp:TextBox ID="txtphone" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 124px">Email</td>
                <td style="width: 217px">
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 124px">Address</td>
                <td style="width: 217px">
                    <asp:TextBox ID="txtaddres" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="3" style="text-align: center">
                    <asp:Button ID="Save" runat="server" OnClick="Save_Click" Text="Save" />
                </td>
            </tr>
            <tr>
                <td colspan="3" style="text-align: center">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
<br />
<br />
    </ContentTemplate>
</asp:UpdatePanel>
</asp:Content>
