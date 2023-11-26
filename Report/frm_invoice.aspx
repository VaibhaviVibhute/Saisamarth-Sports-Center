<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_invoice.aspx.cs" Inherits="saisamarthsportscenter.Report.frm_invoice" %>

<%@ Register assembly="CrystalDecisions.Web, Version=10.5.3700.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 79px;
        }
        .style2
        {
            height: 133px;
        }
        .style3
        {
            width: 397px;
        }
        .style4
        {
            width: 236px;
        }
        .style5
        {
            width: 397px;
            height: 320px;
        }
        .style6
        {
            width: 236px;
            height: 320px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <table class="style1">
        <tr>
            <td class="style2">
                <table class="table">
                    <tr>
                        <td class="style5">

                            <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
                                AutoDataBind="true" />
                            <br />
                        </td>
                        <td class="style6">
                           
                            <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="Medium" 
                                Height="54px" onclick="Button1_Click1" Text="Logout" Width="136px" 
                                BackColor="Black" ForeColor="White" />
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style3">
                         </td>
                        <td class="style4">
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
