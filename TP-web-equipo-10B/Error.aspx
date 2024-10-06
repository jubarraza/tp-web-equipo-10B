<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="TP_web_equipo_10B.Error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

    <div class="row mt-4 mb-4">
    <h1>⛔ Se ha producido un Error</h1>
        </div>
    
        <div class="mb-5 row bg-danger-subtle">   
    <asp:Label Text="Error" ID="lblError" runat="server" />
        </div>

    <div>
        <div class="button-center card border-0">
            <asp:Button Text="Volver a la pantalla principal" runat="server" CssClass="btn btn-secondary btn-group-lg mt-5" OnClick="Unnamed_Click"/>
</div>


    </div>
</asp:Content>
