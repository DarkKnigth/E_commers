<%@ Page Title="" Language="C#" MasterPageFile="~/visitor/VisitroSite.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Ecommers.PL.visitor.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <table align="center" style="width: 40%">
        <tr>
            <td colspan="3" style="text-align: center">Contact</td>
        </tr>
        <tr>
            <td>Name</td>
            <td style="width: 218px">
                <asp:Label ID="Label1" runat="server" CssClass="label" Text="Arar Suliman Al_Tawil"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Email</td>
            <td style="width: 218px">
                <asp:Label ID="Label2" runat="server" CssClass="label" Text="arartawil@yahoo.com"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Address</td>
            <td style="width: 218px">
                <asp:Label ID="Label3" runat="server" CssClass="label" Text="Jordan-Irbid"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Phone</td>
            <td style="width: 218px">
                <asp:Label ID="Label4" runat="server" CssClass="label" Text="0795289310"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
