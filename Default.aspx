﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownListArtist" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListArtist_SelectedIndexChanged"></asp:DropDownList>
        <asp:DropDownList ID="DropDownListVenue" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListVenue_SelectedIndexChanged"></asp:DropDownList>
        <asp:GridView ID="GridView" runat="server"></asp:GridView>
    
    </div>
    </form>
</body>
</html>
