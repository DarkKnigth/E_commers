<%@ Page Title="" Language="C#" MasterPageFile="~/customer/CustomerSite.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Ecommers.PL.customer.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
<br />
            <table align="center" style="width: 40%">
                <tr>
                    <td>suppliers</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" Width="100%" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Category</td>
                    <td>
                        <asp:DropDownList ID="DropDownList2" runat="server" Width="200px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align: center">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Show Product" />
                    </td>
                </tr>
            </table>
<br />
<br />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
