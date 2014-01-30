<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HurMangaVersaler.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hur många versaler?</title>
    <link href="~/Content/Site.css" rel="stylesheet" />
</head>
<body>

    <form id="form1" runat="server">
        <div>
            <h1>Hur många versaler?</h1>
            <asp:TextBox ID="TextBox" TextMode="MultiLine" runat="server"></asp:TextBox>
        </div>
        <asp:PlaceHolder ID="OutputPlaceHolder" runat="server" Visible="false">
            <p>
                Texten innehåller 
              <asp:Label ID="Result" runat="server" Text=""></asp:Label>
                versaler
            </p>
        </asp:PlaceHolder>
        <p>
            <asp:Button ID="Button" runat="server" Text="Bestäm antalet versaler" OnClick="Button_Click" />
        </p>
    </form>
</body>
</html>
