<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Book.aspx.cs" Inherits="WebApplication1.Forms.Book" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Contact Me</title>
    <link type="text/css" rel="stylesheet" href="/Content/bootstrap.css" />
    <link type="text/css" rel="stylesheet" href="/Content/Site.css" />
    <link type="text/css" rel="stylesheet" href="/Content/ContactMe.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Contact Me</h1>
        
        <div class="row">
            <div class="col-12-lg">
                <label for="txtName">Name: </label><br />
                <asp:TextBox ID="txtName" runat="server" ></asp:TextBox>                
            </div>
        </div>
        <div class="row">
            <div class="col-12-lg">
                <label for="txtEmail">Email: </label><br />
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-12-lg">
                <label for="txtSubject">Subject: </label><br />
                <asp:TextBox ID="txtSubject" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-12-lg">
                <label for="txtMessage">Message: </label><br />
                <asp:TextBox ID="txtMessage" runat="server" TextMode="multiline" Rows="10" Columns="400">
                    
                </asp:TextBox>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-12">
                <asp:Button ID="send" Text="Send" CssClass="button" runat="server" />
            </div>
        </div>
    </div>
    </form>
</body>
</html>
