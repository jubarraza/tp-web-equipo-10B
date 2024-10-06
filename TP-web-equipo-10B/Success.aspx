<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Success.aspx.cs" Inherits="TP_web_equipo_10B.Success" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
    body {
        font-family: 'Poppins', sans-serif;
        background: url('https://cdn.cbeditz.com/cbeditz/preview/blue-white-gradiant-powerpoint-background-2-116109704563a3dqfntna.jpg') no-repeat center center fixed;
        background-size: cover;
    }

    .img-small {
        height: 350px;
        width: 90%;
        object-fit: scale-down;
    }

    h1 {
        font-weight: 700;
    }

    p{
        font-weight: 400;
        font-size:larger;
    }
</style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row mt-4 mb-4">
        <h1>✅ ¡Su participacion ha sido cargada correctamente!</h1>
    </div>
    
        <div class="row mt-4 mb-4">
            <asp:Label Text="Voucher" ID="lblVoucher" runat="server" />
        </div>
    
    <div class="mb-4 row">
            <asp:Label Text="Premio" ID="lblPremio" runat="server" />
        </div>
    
    <div class="mb-4 row">
            <asp:Label Text="DNI" ID="lblDniCliente" runat="server" />
        </div>


</asp:Content>
