<%@ Page Title="" Language="C#" MasterPageFile="~/Laptop.Master" AutoEventWireup="true" CodeBehind="EndOfSurvey.aspx.cs" Inherits="SurveyWebform.Pages.EndOfSurvey" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .gridView {
            margin: 50px auto 0 auto;
        }

        .answers__button {
            margin: 30px auto 0 auto;
            display: block;
            width: 400px;
        }

        .answers__status-label {
            font-size: 30px;
            line-height: 40px;
            height: 40px;
            display: inline-block;
            margin-top: 80px;
            text-transform: uppercase;
            font-weight: bolder;
        }

        .registerUser__button {
            margin: 30px auto 0 auto;
            display: block;
            width: 400px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="id_ContentPlaceHolder" runat="server">
    <div class="container text-center">
        <asp:Label ID="id_LabelStatus" class="answers__status-label" runat="server" Text=""></asp:Label>
        <div class="gridView">
            <asp:GridView ID="id_AnswerResultGridView" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Height="100%" Width="100%" AutoGenerateColumns="False" AllowSorting="True" HorizontalAlign="Center">
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <Columns>
                    <asp:BoundField DataField="QOption_Id" HeaderText="QOption_Id" SortExpression="QOption_Id" />
                    <asp:BoundField DataField="QOption_TextBoxValue" HeaderText="QOption_TextBoxValue" SortExpression="QOption_TextBoxValue" />
                    <asp:BoundField DataField="Question_Id" HeaderText="Question_Id" SortExpression="Question_Id" />
                </Columns>
                <EditRowStyle BorderColor="#FFCCFF" BorderWidth="1px" />
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
        </div>

        <asp:Button class="btn btn-outline-success answers__button" ID="id_ButtonSaveSurvey" OnClick="ButtonSaveSurvey_Click" runat="server" Text="Save Survey" />
        <asp:Button class="btn btn-outline-primary answers__button" ID="id_ButtonRegisterUser" OnClick="ButtonRegisterUser_Click" runat="server" Text="Register Member Program" />
        <asp:Button class="btn btn-outline-secondary answers__button" ID="id_ButtonStartSurvey" OnClick="ButtonStartSurvey_Click" runat="server" Text="Start new Survey" />
    </div>
</asp:Content>
