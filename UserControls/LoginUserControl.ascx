<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginUserControl.ascx.cs" Inherits="SurveyWebform.UserControls.LoginUserControl" %>

<style type="text/css">
    .auto-style1 {
        color: #FF0066;
    }
    .auto-style2 {
        color: #FF5050;
    }
</style>

<div class="login__wrap">
    <asp:Label ID="id_LabelUsername" class="login__label" runat="server" Text="Username"></asp:Label>
    <asp:TextBox ID="id_TextBoxUsername" CssClass="login__textBox" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="id_TextBoxUsername" CssClass="auto-style2" ErrorMessage="Username is required">*</asp:RequiredFieldValidator>
</div>


<div class="login__wrap">
    <asp:Label ID="id_LabelPassword" class="login__label" runat="server" Text="Password"></asp:Label>
    <asp:TextBox ID="id_TextBoxPassword" CssClass="login__textBox" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="id_TextBoxPassword" CssClass="auto-style2" ErrorMessage="Password is required">*</asp:RequiredFieldValidator>
</div>








<strong>
<asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="auto-style1" />
</strong>








