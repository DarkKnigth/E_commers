<%@ Page Title="" Language="C#" MasterPageFile="~/customer/CustomerSite.Master" AutoEventWireup="true" CodeBehind="Bscket.aspx.cs" Inherits="Ecommers.PL.customer.Bscket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
<br />
<br />
        </ContentTemplate>
    </asp:UpdatePanel>
    <asp:GridView ID="GridView1" runat="server" Width="100%" OnRowDeleting="GridView1_RowDeleting">
        <Columns>
            <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
    <table style="width: 100%">
        <tr>
            <td style="text-align: center">
                <asp:Button ID="OrderSave" runat="server" OnClick="OrderSave_Click" style="text-align: center" Text="Save" />
                Totle invoice is&nbsp;
                <asp:Label ID="lblbtotle" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
