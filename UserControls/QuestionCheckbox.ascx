<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="QuestionCheckbox.ascx.cs" Inherits="SurveyWebform.Web_User_Controls.QuestionCheckbox" %>
<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<asp:CheckBoxList ID="CheckBoxList1" runat="server" DataSourceID="testing" DataTextField="Question_Name" DataValueField="Question_Name">
</asp:CheckBoxList>
<asp:ObjectDataSource ID="testing" runat="server" SelectMethod="GetQuestions" TypeName="SurveyWebform.Models.SurveyDbRepository"></asp:ObjectDataSource>
<asp:DropDownList ID="DropDownList1" runat="server">
</asp:DropDownList>

