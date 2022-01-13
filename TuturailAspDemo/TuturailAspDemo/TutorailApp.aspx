<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TutorailApp.aspx.cs" Inherits="TuturailAspDemo.TutorailApp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color: aqua;">
            <table>
                <tr> 
                    <td>
            <asp:Label ID="Label1" runat="server" Text="Tutorial Id"></asp:Label>
                        </td>
                    <td>
            <asp:TextBox ID="TxtTutorialId" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                <tr>
                    <td>
            <asp:Label ID="Label2" runat="server" Text="Tutorial Name"></asp:Label>
                         </td>
                    <td>
            <asp:TextBox ID="TxtTutorialName" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                <tr>
                    <td>
            <asp:Label ID="Label3" runat="server" Text="Tutorial Desc"></asp:Label>
                        </td>
                    <td>
            <asp:TextBox ID="TxtTutorialDesc" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                <tr>
                    <td>
           <asp:Label ID="Label4" runat="server" Text="Published"></asp:Label>
                        </td>
                    <td>
           <asp:TextBox ID="TxtPublished" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                <tr>
                    <td></td>
                    <td>
            <asp:Button ID="ButSave" runat="server" Text="Save" OnClick="ButSave_Click"  />
            <asp:Button ID="ButReset" runat="server" Text="Reset" />
                        </td>
                    </tr>
                </table>
            <hr />
            <asp:Label  Text="" ID="lblResult" runat="server"></asp:Label>
            <hr />
            <h2>
                Tutrial Details
                </h2>
            <asp:GridView ID="gvTutorialDetails" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>

