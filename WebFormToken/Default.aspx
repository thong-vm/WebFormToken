<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server" Text="CREATE TOKEN: " Font-Bold="true" Font-Size="X-Large"></asp:Label>
        <br />
    <asp:Label runat="server" Text="Content that need to encode: "></asp:Label>
        <br />
    <asp:TextBox runat="server" ID="txtCreate" Width="100%"></asp:TextBox>
    <asp:Button runat="server" ID ="btnCreate" Text="Create"/>
    <br />
    <asp:Label runat="server" Text="Token created: "></asp:Label> <asp:Label runat="server" Text="" ID="txtToken" Font-Bold="true"></asp:Label>
    <br />
    <hr />
     <asp:Label runat="server" Text="Check token: "></asp:Label>
        <br />
    <asp:TextBox runat="server" ID="txtCheck" Width="100%"></asp:TextBox>
    <asp:Button runat="server" Text="Check" ID="btnCheck"/>
    <br />
    <asp:Label runat="server" Text="Result: "></asp:Label> <asp:Label runat="server" Text="Valid" ForeColor="Green" ID="txtValid" Visible="false"></asp:Label>  <asp:Label runat="server" Text="Invalid" ID="txtInvalid" ForeColor="Red" Visible="false"></asp:Label>
    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
