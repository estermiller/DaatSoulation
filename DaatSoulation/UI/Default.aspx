<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DaatSoulation.UI.Default" %>
<link href="style.css" rel="stylesheet" />
<script src="script.js"></script>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Google News</title>
        <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
</head>
<body>
        <h1>Google News</h1>
        <div id="counter">
            <div class="half-width">
                <h2>Topics</h2>
<%--                // Repeater control used to display a list of topics --%>
                    <asp:Repeater ID="rptTopics" runat="server">
                    <ItemTemplate>
                       <p onclick="getNews('<%# Container.ItemIndex%>')"> <%# Eval("Title.Text") %></p>
                    </ItemTemplate>
                    </asp:Repeater>
            </div>
           <div class="half-width" id="left-side">
              <h2>Post</h2>
               <div id="body"></div>
           </div>
       </div>
</body>
</html>

