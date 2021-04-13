<%@ Page Title="Admin" Language="C#" MasterPageFile="~/Laptop.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="SurveyWebform.Pages.Admin" %>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .controls {
            margin: 0 auto;
        }

        .control {
            display: block;
            width: 400px;
            padding: 2px;
        }

        .label {
            font-size: 1.3em;
            color: black;
            display: inline-block;
            width: 60%;
            text-align: start;
        }

        .controls__gridview {
            margin-top: 2em;
        }
    </style>
</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="content" runat="server">
    <div class="controls">
        <div class="controls__searchs">
            <div class="controls__bankUsed control">
                <strong>
                    <asp:Label CssClass="label" runat="server" Text="Bank Services" ></asp:Label>
                </strong>
                <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            </div>
            <div class="controls__ageRange control">
                <strong>
                    <asp:Label CssClass="label" runat="server" Text="Age Ranges"></asp:Label>
                </strong>
                <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
            </div>
            <div class="controls__livingState control">
                <strong>
                    <asp:Label CssClass="label" runat="server" Text="States"></asp:Label>
                </strong>
                <asp:DropDownList ID="DropDownList3" runat="server"></asp:DropDownList>
            </div>
            <div class="controls__gender control">
                <strong>
                    <asp:Label CssClass="label" runat="server" Text="Genders"></asp:Label>
                </strong>
                <asp:DropDownList ID="DropDownList4" runat="server"></asp:DropDownList>
            </div>
        </div>
        <div class="controls__gridview">
            <asp:GridView ID="GridView1" runat="server"
                BackColor="White"
                BorderColor="#CCCCCC"
                BorderStyle="None"
                BorderWidth="1px"
                CellPadding="4"
                ForeColor="Black"
                GridLines="Horizontal"
                Height="251px"
                Width="100%" AutoGenerateColumns="False" DataSourceID="RespondentObjectDataSource" HorizontalAlign="Left">
                <Columns>
                    <asp:BoundField DataField="Respondent_Id" HeaderText="Respondent_Id" SortExpression="Respondent_Id" />
                    <asp:BoundField DataField="Question_Id" HeaderText="Question_Id" SortExpression="Question_Id" />
                    <asp:BoundField DataField="User_Id" HeaderText="User_Id" SortExpression="User_Id" />
                    <asp:BoundField DataField="Answer_Id" HeaderText="Answer_Id" SortExpression="Answer_Id" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
            <asp:ObjectDataSource ID="RespondentObjectDataSource" runat="server" SelectMethod="GetAllRespondents" TypeName="SurveyWebform.Models.RespondentRepository"></asp:ObjectDataSource>
        </div>

    </div>
</asp:Content>
