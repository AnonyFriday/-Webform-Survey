<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RegisterMembershipUserControl.ascx.cs" Inherits="SurveyWebform.UserControls.RegisterMembershipUserControl" %>


<style type="text/css">
    .auto-style1 {
        color: #FF3300;
    }
    .auto-style2 {
        color: #FF0066;
    }
    .auto-style3 {
        color: #FF5050;
    }
</style>


<div class="register__wrap">
    <asp:Label ID="id_LabelFirstName" class="register__label" runat="server" Text="First Name"></asp:Label>
    <asp:TextBox ID="id_TextBoxFirstName" CssClass="register__textBox" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="id_TextBoxFirstName" CssClass="auto-style3" ErrorMessage="First Name cannot be blank">*</asp:RequiredFieldValidator>
    <strong>
        <br />
        <%--    <asp:RegularExpressionValidator 
        ID="RegularExpressionValidatorUsername" 
        runat="server"
        ErrorMessage="At least one letter or number" ValidationExpression="^[a-zA-Z0-9]+$" ControlToValidate="id_TextBoxUsername"></asp:RegularExpressionValidator>--%>
    </strong>
</div>


<div class="register__wrap">
    <asp:Label ID="id_LabelLastName" class="register__label" runat="server" Text="Last Name"></asp:Label>
    <asp:TextBox ID="id_TextBoxLastName" CssClass="register__textBox" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="id_TextBoxLastName" CssClass="auto-style3" ErrorMessage="Last Name cannot be blank">*</asp:RequiredFieldValidator>
    <strong>
        <br />
        <%--    <asp:RegularExpressionValidator 
        ID="RegularExpressionValidatorPassword" 
        runat="server" 
        ErrorMessage="At least one letter or number" ValidationExpression="^[a-zA-Z0-9]+$" ControlToValidate="id_TextBoxPassword"></asp:RegularExpressionValidator>--%>
    </strong>
</div>

<div class="register__wrap">
    <asp:Label ID="id_LabelPhone" class="register__label" runat="server" Text="Phone Number"></asp:Label>
    <asp:TextBox ID="id_TextBoxPhone" CssClass="register__textBox" runat="server" MaxLength="13"></asp:TextBox>
    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="id_TextBoxPhone" CssClass="auto-style3" ErrorMessage="Phone number must have 12 digits" MaximumValue="13" MinimumValue="1">*</asp:RangeValidator>
    <strong>
        <br />
        <%--    <asp:RegularExpressionValidator 
        ID="RegularExpressionValidatorPassword" 
        runat="server" 
        ErrorMessage="At least one letter or number" ValidationExpression="^[a-zA-Z0-9]+$" ControlToValidate="id_TextBoxPassword"></asp:RegularExpressionValidator>--%>
    </strong>
</div>

<div class="register__wrap">
    <asp:Label ID="id_LabelDOB" class="register__label" runat="server" Text="Date Of Birth"></asp:Label>
    <asp:TextBox ID="id_TextBoxDOB" CssClass="register__textBox" runat="server" ReadOnly></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="id_TextBoxDOB" CssClass="auto-style2" ErrorMessage="Date of Birth cannot be blank">*</asp:RequiredFieldValidator>
</div>
<asp:Calendar ID="id_CalendarDOB" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="100%" OnSelectionChanged="CalendarDOB_SelectionChanged">
    <DayHeaderStyle Font-Bold="True" Font-Size="12pt" VerticalAlign="Middle"/>
    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
    <OtherMonthDayStyle ForeColor="#999999" />
    <SelectedDayStyle BackColor="Black" ForeColor="White" Font-Bold="true"/>
    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
    <TodayDayStyle BackColor="Wheat" Font-Bold="true" />
</asp:Calendar>

<strong>
<asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="auto-style1" />
</strong>

