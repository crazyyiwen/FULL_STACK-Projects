<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/TropicalServer.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="TropicalServer.UI.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link href="../AppThemes/TropicalStyles/Products.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   
    <div style=" width: 180px; float: left; height: 300px;">
            <!--create Repeater to display the Products catagories -->
            <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                <HeaderTemplate>
                    <div style="font-weight: bold;">Product Categories</div>
                </HeaderTemplate>
                <ItemTemplate>
                    <div><asp:Button ID="Button1" runat="server"   CommandName='<%# Container.DataItem %>' style="width:150px" Text='<%# Container.DataItem %>' UseSubmitBehavior="false"/></div>
                </ItemTemplate>
            </asp:Repeater>
    </div>

    
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Height="295px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged2" Width="759px" style="margin-top: 0px; margin-left: 0px;" autogeneratecolumns="true">
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
    
   
    </asp:Content>
