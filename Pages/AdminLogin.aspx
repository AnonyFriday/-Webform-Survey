<%@ Page Title="" Language="C#" MasterPageFile="~/Laptop.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="SurveyWebform.Pages.AdminLogin" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .login__form {
            margin: 100px auto 0 auto;
            display: flex;
            flex-direction: column;
            justify-content: space-between;
            background: #e6f7e6;
            padding: 20px;
            border-radius: 10px;
            width: 600px;
            height: 200px;
        }


        .login__wrap {
            width: 100%;
            display: flex;
            align-items:center;
            justify-content:space-between;
            line-height: 40px;
        }


        .login__label {
            display: inline-block;
            width: 150px;
            font-size: 30px;
            line-height: 35px;
            color: #000505;
            font-weight: 700;
        }


        .login__textBox {
            display: inline-block;
            width: calc(100% - 30px - 150px);
            padding-left: 20px;
            padding-right:10px;
            border-radius: 10px;
        }


        .login__button {
            display: block;
            margin: 0 auto;
            text-transform: uppercase;
            width: 150px;
            color: white;
            background-color: #2F52E0;
        }
    </style>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="id_ContentPlaceHolder" runat="server">
    <div class="container">
        <div class="login__form">
            <survey:LoginUserControl runat="server" ID="id_LoginUserControl" />
            <asp:Button ID="id_ButtonLogin" runat ="server" class="btn btn-outline-primary login__button" Text="Sign in" OnClick="ButtonLogin_Click"/>
        </div>
    </div>
</asp:Content>




