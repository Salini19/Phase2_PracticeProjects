<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SchlManagement.aspx.cs" Inherits="SchoolWebForm.SchlManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="text-align:Center;background-color:aqua">
    <form id="form1" runat="server">
        <div >
            <h1> School Management System</h1>
            <br />
            &nbsp;&nbsp;&nbsp;<asp:Image ID="Image1" runat="server" Height="341px" ImageUrl="~/images/schl.jpg" Width="676px" />
            <br />
             <br />
            <asp:Button ID="Button1" runat="server" Text="Student" BackColor="#CCFFFF" OnClick="Button1_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Class" BackColor="#CCFFFF" OnClick="Button2_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button runat="server" Text="Subject" ID="Button3" BackColor="#CCFFFF" OnClick="Button3_Click"></asp:Button>
        </div>
    </form>
</body>
</html>
