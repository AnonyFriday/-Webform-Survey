<%@ Page Title="Survey" Language="C#" MasterPageFile="~/Laptop.Master" AutoEventWireup="true" CodeBehind="Survey.aspx.cs" Inherits="SurveyWebform.Pages.Home" %>

<%-- Custom Head --%>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<%-- Main --%>
<asp:Content ID="Content3" ContentPlaceHolderID="content" runat="server">
    <div class="content">
        <asp:Label ID="QuestionLabel" runat="server" Text="Question Text"></asp:Label>
        <br />
        <br />
        <asp:PlaceHolder ID="ControlPHolder" runat="server"></asp:PlaceHolder>
        <br />
        <br />
        <asp:Button ID="NextButton" runat="server" OnClick="NextButton_Click" Text="Next Button" />
    </div>
</asp:Content>
