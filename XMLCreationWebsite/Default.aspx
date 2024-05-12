<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GoogleAPIWebsite._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>XML generation </h1><h6>Dr. Ahmad Rawashdeh's class</h6>
    <header>
        <script type="text/javascript" >           
        </script>    
    </header>
    <main>
        <br />
        input Produc 1, 2 and 3. 
        <br />
        <br />
        <div class="row">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <asp:Label runat="server" Text="Input Product 1" ID="Label1">Input Product 1</asp:Label>
                <asp:TextBox runat="server" ID="product1TextBox"></asp:TextBox>
            </section>
            <section class="col-md-4" style="align-content:center" aria-labelledby="gettingStartedTitle">
                <asp:Label runat="server" Text="Input Product 2" ID="Label4">Input product 2</asp:Label>
                <asp:TextBox runat="server" ID="product2TextBox"></asp:TextBox>
                <br />
            </section>
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                 <asp:Label runat="server" Text="Input Product 3" ID="Label3">Input Product 3</asp:Label>
                <asp:TextBox runat="server" ID="product3TextBox"></asp:TextBox>
                <br />
            </section>
        </div>
        <asp:Button runat="server" Text="Search" style="align-content:center" onClientClick="search();" onclick="Unnamed2_Click"></asp:Button>
              
        <div style="align-content:center" >
            <asp:Label runat="server" ID="outputLabel">...</asp:Label>
        </div>

    </main>

</asp:Content>
