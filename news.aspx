<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="news.aspx.cs" Inherits="news" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <link rel="stylesheet" href="minified/themes/default.min.css" />
<script src="minified/sceditor.min.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <br /><br /><br />
    <textarea id="editor1" name="txt" cols="100" rows="20" runat="server"></textarea>

    <script src="minified/formats/xhtml.min.js"></script>
<script>
// Replace the textarea #example with SCEditor
    var textarea = document.getElementById('<%=editor1.ClientID%>');
sceditor.create(textarea, {
	format: 'xhtml',
	style: 'minified/themes/content/default.min.css'
});
</script>

    <br />
    <br />

    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

&nbsp;
    <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Получить текст" />
&nbsp;
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

&nbsp;&nbsp;
    <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Записать в БД" />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

</asp:Content>

