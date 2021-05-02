<%@ Page Title="" Language="C#" MasterPageFile="~/Laptop.Master" AutoEventWireup="true" CodeBehind="RegisterMemberProgram.aspx.cs" Inherits="SurveyWebform.Pages.RegisterMemberProgram" %>
<%@ Register Src="~/UserControls/RegisterMembershipUserControl.ascx" TagPrefix="survey" TagName="RegisterMembershipUserControl" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="id_ContentPlaceHolder" runat="server">
    <div class="container">
        <survey:RegisterMembershipUserControl runat="server" id="RegisterMembershipUserControl" />
        <asp:Button Id="id_ButtonRegister" name="Register Membership Program" runat="server"/>
    </div>
</asp:Content>
