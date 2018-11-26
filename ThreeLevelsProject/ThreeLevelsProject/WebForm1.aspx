<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ThreeLevelsProject.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Готель "Троя"</h3>
            <br />
            <br />
            Клієнти готелю:<br />
                <div>
                    <h1>Список студентів</h1>
                    <hr />
                    <asp:Button ID="findallClients" runat="server"
                        Text="Вивести список" OnClick="findallClients_Click" />
                    <hr />
                    <asp:Literal ID="ltrClients" runat="server" />
                </div>
                <hr />
                <asp:Label ID="lblErrorMessage" runat="server" />
            <br />
            <br />
            Додати клієнта:<br />
            <br />
            Ім&#39;я:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="name1" runat="server"></asp:TextBox>
            <br />
            <br />
            Прізвище:
            <asp:TextBox ID="sname1" runat="server"></asp:TextBox>
            <br />
            <br />
            Логін:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="login1" runat="server"></asp:TextBox>
            <br />
            <br />
            Пароль:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="password1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="addClient" runat="server" OnClick="addClient_Click" Text="Додати" />
            <br />
            <br />
            <asp:Label ID="lblErrorMessage1" runat="server"></asp:Label>
            <br />
            <br />
            Видалити клієнта:<br />
            <br />
            ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="id1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="deleteClient" runat="server" OnClick="deleteClient_Click" Text="Видалити" />
            <br />
            <br />
            <asp:Label ID="lblErrorMessage2" runat="server"></asp:Label>
            <br />
            <br />
            Оновити інформацію:<br />
            <br />
            ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="id2" runat="server"></asp:TextBox>
            <br />
            <br />
            Ім&#39;я:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="name2" runat="server"></asp:TextBox>
            <br />
            <br />
            Прізвище:
            <asp:TextBox ID="sname2" runat="server"></asp:TextBox>
            <br />
            <br />
            Логін:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="login2" runat="server"></asp:TextBox>
            <br />
            <br />
            Пароль:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="password2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="updateClient" runat="server" OnClick="updateClient_Click" Text="Оновити" />
            <br />
            <br />
            <asp:Label ID="lblErrorMessage3" runat="server"></asp:Label>
            <br />
            <br />
            Отримати інформацію:
            <br /><br />
            ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="id3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="getClient" runat="server" OnClick="getClient_Click" Text="Info" />
            <br />
            <asp:Label ID="clientInfo" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblErrorMessage4" runat="server"></asp:Label>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
