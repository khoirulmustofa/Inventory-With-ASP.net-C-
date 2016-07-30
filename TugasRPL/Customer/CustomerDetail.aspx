<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Detail.Master" AutoEventWireup="true" CodeBehind="CustomerDetail.aspx.cs" Inherits="TugasRPL.Customer.CustomerDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadDetail" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentDetail" runat="server">
        <div class="row">
        <div class="col-lg-12">
            <div class="box dark">
                <header>
                    <div class="icons"><i class="icon-edit"></i></div>
                    <h5 style="font-family: Castellar; font-size: 18px;">CUSTOMER</h5>
                    <div class="toolbar">
                        <ul class="nav">
                            <li>
                                <a class="accordion-toggle minimize-box" data-toggle="collapse" href="#div-1">
                                    <i class="icon-chevron-up"></i>
                                </a>
                            </li>
                        </ul>
                    </div>
                </header>
                <div id="div-1" class="accordion-body collapse in body" style="padding-left: 50px; padding-right: 50px; padding-top: 40px;">
                    <table class="table table-hover">
                        <tr>
                            <td>
                                <label style="width: 200px;">KODE CUSTOMER</label></td>
                            <td>
                                <label style="width: 10px;">:</label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtKODE_CUSTOMER" runat="server" class="form-control" placeholder="KODE CUSTOMER" Style="width: 200px;"></asp:TextBox></td>
                        </tr>

                        <tr>
                            <td>
                                <label>NAMA CUSTOMER</label></td>
                            <td>
                                <label>:</label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtNAMA_CUSTOMER" runat="server" class="form-control" placeholder="NAMA CUSTOMER" Style="width: 400px;"></asp:TextBox></td>
                        </tr>

                        <tr class="form-group">
                            <td>
                                <label>ALAMAT CUSTOMER</label></td>
                            <td>
                                <label>:</label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtALAMAT_CUSTOMER" runat="server" class="form-control" placeholder="ALAMAT CUSTOMER" Style="width: 400PX;" TextMode="MultiLine"></asp:TextBox></td>
                        </tr>

                        <tr class="form-group">
                            <td>
                                <label>TELEPON CUSTOMER</label></td>
                            <td>
                                <label>:</label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtTELEPON_CUSTOMER" runat="server" class="form-control" placeholder="TELEPON CUSTOMER" Style="width: 400px;"></asp:TextBox></td>
                        </tr>
                    </table>
                    <div style="padding-top: 2%; padding-left: 40%;">
                        <asp:Button ID="btnSimpan" runat="server" Text="SIMPAN" class="btn btn-success btn-sm" OnClick="btnSimpan_Click" />
                        &nbsp
                        <asp:Button ID="btnCancel" runat="server" Text="BATAL" class="btn btn-danger btn-sm" OnClientClick="window.close();" />
                    </div>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                </div>
            </div>
        </div>
    </div>

</asp:Content>
