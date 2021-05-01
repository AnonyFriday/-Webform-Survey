<%@ Page Title="Survey" Language="C#" MasterPageFile="~/Laptop.Master" AutoEventWireup="true" CodeBehind="Survey.aspx.cs" Inherits="SurveyWebform.Pages.Home" %>

<%@ Register Src="~/UserControls/QuestionUserControl.ascx" TagPrefix="survey" TagName="QuestionUserControl" %>


<%-- Custom Head --%>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .question {
            width: 40%;
            display: flex;
            flex-direction: column;
            justify-content: space-between;
            text-align: center;
            margin: 100px auto 0 auto;
            height: 300px;
        }

        .question__title {
            margin-bottom: 30px;
        }


        .question__control {
            text-align: center;
            vertical-align: middle;
        }

            .question__control table {
                width: 100%;
            }

            .question__control span,
            .question__control td {
                width: 100%;
                display: flex;
                justify-content: space-between;
                align-items: baseline;
            }

            .question__control label {
                font-size: 2rem;
            }

        /* Check Box List*/
        /* Check Box List*/

        input[type=text] {
            width: 300px;
            height: 50px;
            text-indent: 20px;
        }

        select {
            width: 400px;
        }
    </style>
</asp:Content>

<%-- Main --%>
<asp:Content ID="Content3" ContentPlaceHolderID="id_ContentPlaceHolder" runat="server">
    <div class="container">
        <div class="question">
            <survey:QuestionUserControl runat="server" ID="id_QuestionUserControl" />
            <asp:Button ID="id_NextQuestionButton" class="btn btn-outline-primary mt-3" OnClick="NextButton_Click" runat="server" Text="Next Question" />
        </div>
    </div>
</asp:Content>
