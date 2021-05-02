<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginUserControl.ascx.cs" Inherits="SurveyWebform.UserControls.LoginUserControl" %>

<div class="login__wrap">
    <asp:Label ID="id_LabelUsername" class="login__label" runat="server" Text="Username"></asp:Label>
    <asp:TextBox ID="id_TextBoxUsername" CssClass="login__textBox" runat="server"></asp:TextBox>
    <strong>
    <br />
<%--    <asp:RegularExpressionValidator 
        ID="RegularExpressionValidatorUsername" 
        runat="server"
        ErrorMessage="At least one letter or number" ValidationExpression="^[a-zA-Z0-9]+$" ControlToValidate="id_TextBoxUsername"></asp:RegularExpressionValidator>--%>
    </strong>
</div>


<div class="login__wrap">
    <asp:Label ID="id_LabelPassword" class="login__label" runat="server" Text="Password"></asp:Label>
    <asp:TextBox ID="id_TextBoxPassword" CssClass="login__textBox" runat="server"></asp:TextBox>
    <strong>
    <br />
<%--    <asp:RegularExpressionValidator 
        ID="RegularExpressionValidatorPassword" 
        runat="server" 
        ErrorMessage="At least one letter or number" ValidationExpression="^[a-zA-Z0-9]+$" ControlToValidate="id_TextBoxPassword"></asp:RegularExpressionValidator>--%>
    </strong>
</div>








