<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Detail.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="TugasRPL.LogIn.LogIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadDetail" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentDetail" runat="server">
    <div class="row">
        <div class="masuk">
            <div class="col-lg-8 box dark" style="background-color:#c2dd37;">
                <div style="text-align:center;">
                    <h2 style="font-family:Castellar;">Selamat Datang Di Sistem Inventory</h2>
                </div>
                <hr />
                <div id="div-1" class="accordion-body collapse in body" style="padding-left: 50px; padding-right: 50px;padding-top: 40px;">
                    <table class="table table-hover">
                        <tr>
                            <td>
                                <label style="width: 200px;">KODE BARANG</label></td>
                            <td>
                                <label style="width: 10px;">:</label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtNAMA_USERS" runat="server" class="form-control col-lg-4" placeholder=""></asp:TextBox></td>
                        </tr>

                        <tr>
                            <td>
                                <label>NAMA BARANG</label></td>
                            <td>
                                <label>:</label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtPASSWORDS" runat="server" class="form-control col-lg-4" type="password" placeholder=""></asp:TextBox></td>
                        </tr>
                    </table>
                    <asp:Button ID="btnSigIn" runat="server" Text="Masuk" class="btn btn-success" OnClick="btnSigIn_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
