<%@ Page Title="" Language="C#" MasterPageFile="~/Laptop.Master" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="SurveyWebform.Pages.Welcome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .welcome {
            height: 300px;
            margin: 100px auto 0 auto;
            width: 400px;
        }

        .welcome__title {
            font-size: 40px;
            line-height: 45px;
            height: 45px;
        }

        .welcome__desc {
            font-size: 20px;
            line-height: 23px;
            text-overflow:ellipsis;
        }

        .welcome__button {
            display: block;
            width: 100%;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="id_ContentPlaceHolder" runat="server">
    <div class="container">
        <div class="d-flex flex-column justify-content-between align-items-center welcome">
            <asp:Label ID="id_TitleWelcome" class="welcome__title" runat="server" Text="This is the Survey AIT"></asp:Label>
            <p class="welcome__desc" runat="server">This is a Survey AIT conducted by the AIT Corp. Click the button below to the join the survey</p>
            <asp:Button ID="id_ButtonGoToSurvey" CssClass="btn btn-primary welcome__button" runat="server" Text="Start Survey" OnClick="ButtonGoToSurvey_Click" />
        </div>
    </div>
</asp:Content>
