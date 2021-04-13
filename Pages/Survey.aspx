<%@ Page Title="Survey" Language="C#" MasterPageFile="~/Laptop.Master" AutoEventWireup="true" CodeBehind="Survey.aspx.cs" Inherits="SurveyWebform.Pages.Home" %>

<%-- Custom Head --%>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .survey {
            margin: 20vh auto 0 auto;
            display: flex;
            flex-direction: column;
            justify-content: space-between;
            align-items: center;
            font-size: 1em;
            height: 20vh;
        }

        .survey__title {
            font-size: 3em;
            font-family:'Times New Roman', Times, serif;
        }

        .survey__control {
            color: black;
            text-transform: uppercase;
        }

        
        input[type=checkbox] {
            margin-right: 2em;

        }
    </style>
</asp:Content>

<%-- Main --%>
<asp:Content ID="Content3" ContentPlaceHolderID="content" runat="server">
    <div class="survey">
        <asp:Label class="survey__title" ID="QuestionLabel" runat="server" Text="Question Text" CssClass="auto-style2"></asp:Label>
        <div class="survey__control">
            <asp:PlaceHolder ID="ControlPHolder" runat="server"></asp:PlaceHolder>
        </div>
        <asp:Button class="btn btn-primary survey__button" ID="NextButton" runat="server" OnClick="NextButton_Click" Text="Next Button" Width="193px" />
    </div>
</asp:Content>
