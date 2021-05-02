<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RegisterMembershipUserControl.ascx.cs" Inherits="SurveyWebform.UserControls.RegisterMembershipUserControl" %>


<div class="register__wrap">
    <asp:Label ID="id_LabelFirstname" class="register__label" runat="server" Text="First Name"></asp:Label>
    <asp:TextBox ID="id_TextBoxFirstname" CssClass="register__textBox" runat="server"></asp:TextBox>
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
    <asp:TextBox ID="id_TextBoxPhone" CssClass="register__textBox" runat="server"></asp:TextBox>
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
    <asp:TextBox ID="id_TextBoxDOB" CssClass="register__textBox" runat="server"></asp:TextBox>
    <asp:Calendar ID="id_CalendarDOB" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
        <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
        <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
        <OtherMonthDayStyle ForeColor="#999999" />
        <SelectedDayStyle BackColor="#333399" ForeColor="White" />
        <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
        <TodayDayStyle BackColor="#CCCCCC" />
    </asp:Calendar>
</div>

