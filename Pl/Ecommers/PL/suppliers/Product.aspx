<%@ Page Title="" Language="C#" MasterPageFile="~/suppliers/SuppliersSite.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="Ecommers.PL.suppliers.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <p>
        <br />
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </p>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                <asp:View ID="View1" runat="server">
                    <br />
                    <br />
                    <table border="1" align="center" style="width: 56%">
                        <tr>
                            <td colspan="3" style="text-align: center">
                                <asp:Label ID="Label6" runat="server" style="text-align: center" Text="New Product"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 238px">
                                <asp:Label ID="Label7" runat="server" Text="Category" Width="40%"></asp:Label>
                            </td>
                            <td colspan="2" style="text-align: left">
                                <asp:DropDownList ID="DropCatName" runat="server" Width="50%">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 238px">
                                ProductID</td>
                            <td colspan="2" style="text-align: left">
                                <asp:TextBox ID="txtid" runat="server" ReadOnly="True"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 238px">
                                Producrt Name</td>
                            <td style="width: 184px; text-align: left">
                                <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtname" ErrorMessage="*" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 238px">
                                Price</td>
                            <td style="width: 184px">
                                <asp:TextBox ID="txtprice" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtprice" ErrorMessage="*" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 238px">
                                Quantity</td>
                            <td style="width: 184px">
                                <asp:TextBox ID="txtQuity" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtQuity" ErrorMessage="*" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 238px">
                                Picture</td>
                            <td style="width: 184px">
                                <asp:FileUpload ID="fU" runat="server" Width="220px" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 238px">isAvalibal</td>
                            <td style="width: 184px">
                                <asp:CheckBox ID="CheckBox1" runat="server" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="text-align: center;" colspan="3">
                                <asp:Button ID="Save" runat="server" OnClick="Save_Click" Text="Save" />
                                <asp:Button ID="Show" runat="server" OnClick="Show_Click" Text="Show your Product" ValidationGroup="a" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" style="text-align: center;">
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EcommersConnectionString2 %>" SelectCommand="SELECT [ProductID], [ProductName], [ProductPrice], [ProductQuantity], [ProductPicture], [IsAvilable] FROM [Product] WHERE ([SupplerID] = @SupplerID)">
                                    <SelectParameters>
                                        <asp:SessionParameter Name="SupplerID" SessionField="id" Type="Int32" />
                                    </SelectParameters>
                                </asp:SqlDataSource>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="text-align: center;">
                                <asp:Label ID="lblMessage" runat="server"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                    <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" Width="100%">
                        <HeaderTemplate>
                            <table border="1" style="width: 100%">
                                <tr>
                                    <td style="width:10%">ID</td>
                                    <td style="width:30%">Name</td>
                                    <td style="width:15%">Price</td>
                                    <td  style="width:10%">Qrt</td>
                                    <td style="width:30%">Image</td>
                                    <td style="width:5%">isAV</td>
                                </tr>
                            </table>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <table border="1" style="width: 100%">
                                <tr style="color: #0033CC">
                                    <td style="background-color: #FFFFFF; width:10%">
                                        <asp:Label ID="ProductIDLabel" runat="server" Text='<%# Eval("ProductID") %>' />
                                    </td>
                                    <td style="width: 164px; background-color: #FFFFFF; width:30%">
                                        <asp:Label ID="ProductNameLabel" runat="server" Text='<%# Eval("ProductName") %>' />
                                    </td>
                                    <td style="background-color: #FFFFFF ;width:15%">
                                        <asp:Label ID="ProductPriceLabel" runat="server" Text='<%# Eval("ProductPrice") %>' />
                                    </td>
                                    <td style="background-color: #FFFFFF ;width:10%">
                                        <asp:Label ID="ProductQuantityLabel" runat="server" Text='<%# Eval("ProductQuantity") %>' />
                                    </td>
                                    <td style="width: 6px; background-color: #FFFFFF ;width:30%">
                                       
                                        <asp:Image ID="Image1" runat="server" ImageUrl= '<%# Eval("ProductPicture") %>' Height="20%" Width="20%" BorderStyle="Solid" />
                                    </td>
                                    <td style="background-color: #FFFFFF;width:5%">
                                        <asp:CheckBox ID="CheckBox2" runat="server" Checked='<%# Eval("IsAvilable") %>' Enabled="true"/>
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:DataList>
                    <br />
                </asp:View>
                <asp:View ID="View2" runat="server">
                    <br />
                    <br />
                    <table align="center" border="1" style="width: 53%">
                        <tr>
                            <td colspan="3" style="font-weight: 700; font-size: x-large; text-align: center;">Edit Product</td>
                        </tr>
                        <tr>
                            <td style="height: 27px">Product ID</td>
                            <td style="height: 27px">
                                <asp:TextBox ID="TextBox3" runat="server" Width="54px"></asp:TextBox>
                            </td>
                            <td style="height: 27px">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox3" ErrorMessage="Required" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>Product Name</td>
                            <td>
                                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Required" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>ProductPrice</td>
                            <td>
                                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>ProductQuantity</td>
                            <td>
                                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>ProductPicture</td>
                            <td>
                                <asp:FileUpload ID="FileUpload1" runat="server" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>IsAvilable</td>
                            <td>
                                <asp:DropDownList ID="DropDownList1" runat="server" Width="40%">
                                    <asp:ListItem>True</asp:ListItem>
                                    <asp:ListItem Value="Fale">Fale</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>CategoryID</td>
                            <td>
                                <asp:DropDownList ID="DropCatName0" runat="server" Width="50%">
                                </asp:DropDownList>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>
                                <asp:Button ID="btnEdit" runat="server" Enabled="False" OnClick="Button3_Click" Text="Edit" />
                                <asp:Button ID="btnRemove" runat="server" Enabled="False" OnClick="Button5_Click" OnClientClick="return confirm(&quot;delete this category ..?&quot;);" Text="Remove" />
                                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Back" ValidationGroup="no" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="3" style="text-align: center">
                                <br />
                                <asp:Label ID="lblMsg1" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                <asp:GridView ID="GridView2" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="100%">
                                    <Columns>
                                        <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                                    </Columns>
                                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                                    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                                    <RowStyle BackColor="White" ForeColor="#330099" />
                                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                                    <SortedAscendingCellStyle BackColor="#FEFCEB" />
                                    <SortedAscendingHeaderStyle BackColor="#AF0101" />
                                    <SortedDescendingCellStyle BackColor="#F6F0C0" />
                                    <SortedDescendingHeaderStyle BackColor="#7E0000" />
                                </asp:GridView>
                            </td>
                        </tr>
                    </table>
                    <br />
                </asp:View>
            </asp:MultiView>
            <br />
            <br />
            <br />
<br />
            
        </ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="Save" />
        </Triggers>
    </asp:UpdatePanel>
   
</asp:Content>
