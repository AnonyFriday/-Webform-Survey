<%@ Page Title="Survey" Language="C#" MasterPageFile="~/Laptop.Master" AutoEventWireup="true" CodeBehind="Survey.aspx.cs" Inherits="SurveyWebform.Pages.Home" %>

<%-- Custom Head --%>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
        height: 348px;
    }
        .auto-style2 {
            font-size: xx-large;
        }
    </style>
</asp:Content>

<%-- Main --%>
<asp:Content ID="Content3" ContentPlaceHolderID="content" runat="server">
    <div class="content">

        <div class="card">
            <div class="card-body">
                <div class="card-header">
                </div>
                <div class="card-body">
                    <br />

                    <table class="auto-style1">
                        <tr>
                            <td class="text-center">
                                <strong>
                                <asp:Label ID="QuestionLabel" runat="server" Text="Question Text" CssClass="auto-style2"></asp:Label>
                                </strong>
                            </td>
                        </tr>
                        <tr>
                            <td class="text-center">
                                <asp:PlaceHolder ID="ControlPHolder" runat="server"></asp:PlaceHolder>
                            </td>
                        </tr>
                        <tr>
                            <td  class="text-center">
                                <asp:Button styles="display: block" class="btn btn-primary" ID="NextButton" runat="server" OnClick="NextButton_Click" Text="Next Button" Width="193px" />
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>





    </div>
</asp:Content>
