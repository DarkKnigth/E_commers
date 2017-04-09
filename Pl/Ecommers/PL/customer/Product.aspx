<%@ Page Title="" Language="C#" MasterPageFile="~/customer/CustomerSite.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="Ecommers.PL.customer.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



 
       
            <br />
            <table align="center" style="width: 40%" border="1">
                <tr>
                    <td>Item Name</td>
                    <td style="text-align: center">
                        <asp:TextBox ID="txt_ItemName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align: center">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Serach" />
                    </td>
                </tr>
            </table>
            <br />
<br />
          
                        <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" style="text-align: center" Width="100%" OnItemCommand="DataList1_ItemCommand">
                            <HeaderTemplate>
                                <table style="width: 100%">
                                    <tr>
                                     <td style="width:10%">ID</td>
                                    <td style="width:20%">Name</td>
                                    <td style="width:15%">Price</td>
                                    <td style="width:30%">Image</td>
                                    <td style="width:5%">isAV</td>
                                    <td style="width:5%">Qrt</td>
                                    <td style="width:5%">Add</td>
                                    </tr>
                                </table>
                            </HeaderTemplate>
                            <ItemTemplate>
                             
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width:10%">
                                            <asp:Label ID="ProductIDLabel" runat="server" Text='<%# Eval("ProductID") %>' />
                                        </td>
                                        <td style="width:20%">
                                            <asp:Label ID="ProductNameLabel" runat="server" Text='<%# Eval("ProductName") %>' />
                                        </td>
                                        <td style="width:15%">
                                            <asp:Label ID="ProductPriceLabel" runat="server" Text='<%# Eval("ProductPrice") %>' />
                                        </td>
                                        <td style="width: 6px; background-color: #FFFFFF ;width:30%">
                                       
                                        <asp:Image ID="Image1" runat="server" ImageUrl= '<%# Eval("ProductPicture") %>' Height="20%" Width="20%" BorderStyle="Solid" />
                                    </td>
                                          <td style="background-color: #FFFFFF;width:5%">
                                        <asp:CheckBox ID="CheckBox2" runat="server" Checked='<%# Eval("IsAvilable") %>' Enabled="true"/>
                                    </td>

                                          </td>
                                          <td style="background-color: #FFFFFF;width:5%">
                                              <asp:TextBox ID="TextBox1" runat="server" onkeypress="return onlyNumbers(event)"></asp:TextBox>
                                    </td>
                                          </td>
                                          <td style="background-color: #FFFFFF;width:5%">
                                              <asp:Button ID="Button2" runat="server" Text="Add" CommandName="btn_Add" />
                                    </td>

                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:DataList>
            
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EcommersConnectionString2 %>" SelectCommand="SELECT [ProductID], [ProductName], [ProductPrice], [ProductPicture], [IsAvilable] FROM [Product] WHERE (([CategoryID] = @CategoryID) AND ([SupplerID] = @SupplerID) AND ([ProductName] LIKE '%' + @ProductName + '%'))">
                <SelectParameters>
                    <asp:SessionParameter Name="CategoryID" SessionField="IDCat" Type="Int32" />
                    <asp:SessionParameter Name="SupplerID" SessionField="IDSupp" Type="Int32" />
                    <asp:ControlParameter ControlID="txt_ItemName" Name="ProductName" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
<br />
     
</asp:Content>
