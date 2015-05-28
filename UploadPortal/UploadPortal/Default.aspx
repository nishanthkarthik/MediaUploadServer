<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UploadPortal.Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Upload Portal</h1>
        <p class="lead">Portal for file transfer</p>
    </div>

    <div class="panel-primary">
        <div class="row">
                <asp:FileUpload ID="UploadBox" runat="server" AllowMultiple="True" EnableTheming="True" ToolTip="Upload File" />
        </div>
        <br/>
        <div class="row">
            <asp:Button class="btn-default" id="UploadButton" runat="server" text="Upload" OnClick="UploadButton_OnClick"></asp:Button>
        </div>
    </div>

</asp:Content>
