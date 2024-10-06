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

        p {
            font-weight: 400;
            font-size: larger;
        }

        .bold{
            font-weight: 600;
            font-size: large;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row mt-4 mb-4">
        <h1 class="alert alert-success">✅ ¡Su participacion ha sido registrada correctamente!</h1>
    </div>

    <div class="row mb-4">
        <p>Ya estas participando por el premio que elegiste.</p>
    </div>

    <div class="card ms-auto me-auto mb-4" style="max-width: 540px;">
        <div class="card-body text-center">

            <div class="card-title text-bg-success">
                <asp:Label Text="El codigo del Voucher" ID="lblVoucher" runat="server" CssClass="bold" />
            </div>

            <div class="card-title">
                <asp:Label Text="Premio elegido" ID="lblPremio" runat="server" CssClass="bold" />
            </div>

            <div class="card-title">
                <asp:Label Text="DNI del cliente registrado" ID="lblDniCliente" runat="server" CssClass="bold" />
            </div>

        </div>
    </div>


    <div class="row mt-5 mb-4">
        <p>Si realizas nuevas compras en nuestros establecimientos, podras recibir nuevos vouchers que te permitiran participar nuevamente.</p>
        <p>Con cada voucher, podes participar por un premio distinto o el mismo, segun lo que prefieras.</p>
    </div>



</asp:Content>
