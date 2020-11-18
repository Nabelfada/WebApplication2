<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 328px;
        }
    </style>
</head>
<body style="height: 413px">
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Label ID="Label1" runat="server" Text="The name: "></asp:Label>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
    
        <asp:Label ID="Label2" runat="server" Text="The Age: "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="margin-bottom: 0px"></asp:TextBox>
    
        <br />
    
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Are You Sure?" />
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ok" /><br />
        <asp:Button ID="Button2" runat="server" Text="send" OnClick="Button2_Click" style="width: 42px" /><br />
    
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
    
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="view session" /><br />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
    
        <asp:Button ID="Button4" runat="server" Text="send cookie" OnClick="Button4_Click" />
    
    </div>
    </form>
</body>
</html>
