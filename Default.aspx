<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Salary Caculator</title> 
<link rel="stylesheet" type="text/css" href="stylesheet.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Salary Caculator</h1>
        <p>&nbsp;</p>
        <p>Hourly Wage:
            <asp:TextBox ID="txtb_wage" runat="server"></asp:TextBox>
        </p>
        <p>Hours Worked:
            <asp:TextBox ID="txtb_hours" runat="server"></asp:TextBox>
        </p>
        <p>Pre-Tax Deduction:
            <asp:TextBox ID="txtb_pretax" runat="server"></asp:TextBox>
        </p>
        <p>After-Tax Deduction:
            <asp:TextBox ID="txtb_aftertax" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Btn_clear" runat="server" Text="Clear" />
&nbsp;
            <asp:Button ID="btn_caculate" runat="server" Text="Caculate" />
        </p>
        <p>&nbsp;</p>
    </div>
    </form>
</body>
</html>
