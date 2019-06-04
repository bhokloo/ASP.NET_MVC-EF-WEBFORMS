<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForms.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataSourceID="ObjectDataSource3">
                <Columns>
                    <asp:BoundField DataField="eId" HeaderText="eId" SortExpression="eId" />
                    <asp:BoundField DataField="ename" HeaderText="ename" SortExpression="ename" />
                    <asp:BoundField DataField="eaddress" HeaderText="eaddress" SortExpression="eaddress" />
                    <asp:BoundField DataField="Manager.mname" HeaderText="Manager" SortExpression="Manager" />
                </Columns>
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


        </div>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="mmm" TypeName="WebApplication1.Controllers.NewController"></asp:ObjectDataSource>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                <asp:BoundField DataField="mname" HeaderText="mname" SortExpression="mname" />
                <asp:TemplateField HeaderText="Employees">
                    <ItemTemplate>
                        <asp:GridView ID="GridView3" runat="server" DataSource='<%# Eval("Employees") %>'>
                        </asp:GridView>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
        <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False" DataSourceID="ObjectDataSource3" DefaultMode="Insert" Height="50px" Width="125px">
            <Fields>
                <asp:BoundField DataField="eId" HeaderText="eId" visible="false" SortExpression="eId" />
                <asp:BoundField DataField="ename" HeaderText="ename" SortExpression="ename" />
                <asp:BoundField DataField="eaddress" HeaderText="eaddress" SortExpression="eaddress" />
                <asp:BoundField DataField="ManagerId" HeaderText="ManagerId" SortExpression="ManagerId" />
                <asp:CommandField ShowInsertButton="True" />
            </Fields>
        </asp:DetailsView>
        <br />
        <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" DataObjectTypeName="WebApplication1.Models.Employee" InsertMethod="Insert" SelectMethod="Create" TypeName="WebApplication1.Controllers.NewController">
           </asp:ObjectDataSource>
        
        <br />
        <br />
        <asp:ObjectDataSource ID="ObjectDataSource4" runat="server" SelectMethod="self" TypeName="WebApplication1.Controllers.NewController" DataObjectTypeName="WebApplication1.Models.Employee" InsertMethod="Insert"></asp:ObjectDataSource>
        <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource5">
            <Columns>
                <asp:BoundField DataField="emp" HeaderText="emp" SortExpression="emp" />
                <asp:BoundField DataField="man" HeaderText="man" SortExpression="man" />
            </Columns>
        </asp:GridView>
        <br />
        <br />
        <asp:ObjectDataSource ID="ObjectDataSource5" runat="server" SelectMethod="selfByLinQ" TypeName="WebApplication1.Controllers.NewController"></asp:ObjectDataSource>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
