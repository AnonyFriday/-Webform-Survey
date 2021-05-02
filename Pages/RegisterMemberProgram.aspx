<%@ Page Title="" Language="C#" MasterPageFile="~/Laptop.Master" AutoEventWireup="true" CodeBehind="RegisterMemberProgram.aspx.cs" Inherits="SurveyWebform.Pages.RegisterMemberProgram" %>

<%@ Register Src="~/UserControls/RegisterMembershipUserControl.ascx" TagPrefix="survey" TagName="RegisterMembershipUserControl" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .register__form {
            margin: 100px auto 0 auto;
            display: flex;
            flex-direction: column;
            justify-content: space-between;
            background: #e6f7e6;
            padding: 20px;
            border-radius: 10px;
            width: 800px;
            height: 800px;
        }

        .register__wrap {
            width: 100%;
            display: flex;
            align-items: center;
            justify-content: space-between;
            line-height: 40px;
        }

        .register__label {
            display: inline-block;
            width: 330px;
            font-size: 30px;
            line-height: 35px;
            color: #000505;
            font-weight: 700;
        }

        .register__textBox {
            display: inline-block;
            width: calc(100% - 30px - 150px);
            padding-left: 20px;
            padding-right: 10px;
            border-radius: 10px;
        }

        .register__button {
            display: block;
            margin: 30px auto 0 auto;
            text-transform: uppercase;
            width: 400px;
            color: white;
            font-size: medium;
            background-color: #2F52E0;
        }
        .register__labelStatus {
        
            color: red;
            line-height: 30px;
            height: 30px;
            font-size: 25px;
            display: inline-block;
            margin: 30px auto;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="id_ContentPlaceHolder" runat="server">
    <div class="container">
        <div class="register__form">
            <survey:RegisterMembershipUserControl runat="server" ID="id_RegisterMembershipUserControl" />
            <asp:Button ID="id_ButtonRegister" class="btn btn-outline-primary register__button" Text="Register Membership Program" runat="server" OnClick="ButtonRegister_Click" />
            <asp:Label ID="id_LabelStatus" runat="server" CssClass="register__labelStatus"></asp:Label>
            
        </div>
    </div>
</asp:Content>
