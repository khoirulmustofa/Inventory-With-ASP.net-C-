<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Detail.Master" AutoEventWireup="true" CodeBehind="SupplierDetail.aspx.cs" Inherits="TugasRPL.Suppllier.SupplierDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadDetail" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentDetail" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <div class="box dark">
                <header>
                    <div class="icons"><i class="icon-edit"></i></div>
                    <h5 style="font-family: Castellar; font-size: 18px;">SUPPLIER</h5>
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
                                <label style="width: 200px;">KODE SUPPLIER</label></td>
                            <td>
                                <label style="width: 10px;">:</label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtKODE_SUPPLIER" runat="server" class="form-control" placeholder="KODE SUPPLIER" Style="width: 200px;"></asp:TextBox></td>
                        </tr>

                        <tr>
                            <td>
                                <label>NAMA SUPPLIER</label></td>
                            <td>
                                <label>:</label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtNAMA_SUPPLIER" runat="server" class="form-control" placeholder="NAMA SUPPLIER" Style="width: 400px;"></asp:TextBox></td>
                        </tr>

                        <tr class="form-group">
                            <td>
                                <label>ALAMAT SUPPLIER</label></td>
                            <td>
                                <label>:</label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtALAMAT_SUPPLIER" runat="server" class="form-control" placeholder="ALAMAT SUPPLIER" Style="width: 400px;" TextMode="MultiLine"></asp:TextBox></td>
                        </tr>

                        <tr class="form-group">
                            <td>
                                <label>NO TELEPON</label></td>
                            <td>
                                <label>:</label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtTELEPON_SUPPLIER" runat="server" class="form-control" placeholder="TELEPON SUPPLIER" Style="width: 400px;"></asp:TextBox></td>
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
                </div>
            </div>
        </div>
    </div>
</asp:Content>
