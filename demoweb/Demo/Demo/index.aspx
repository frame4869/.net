<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Demo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>FIFA</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;ชื่อผู้ใช้:
            <asp:TextBox ID="txt_number" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" BorderStyle="Solid" OnClick="Button1_Click" Text="ตกลง" />
        </div>
    </form>
</body>
</html>
