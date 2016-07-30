<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Detail.Master" AutoEventWireup="true" CodeBehind="BarangDetail.aspx.cs" Inherits="TugasRPL.Barang.BarangDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadDetail" runat="server">
    <script type="text/javascript">
        //function pageLoad() {
         //setDatePicker('<% %>');

        //}
        //$(document).ready(function () {
        //    $("#txtTGL_KADALUARSA").datepicker({
        //        dateFormat: "dd-MM-yy"
        //    });
        //});
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentDetail" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <div class="box dark">
                <header>
                    <div class="icons"><i class="icon-edit"></i></div>
                    <h5 style="font-family: Castellar; font-size: 18px;">BARANG</h5>
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
                                <label style="width: 200px;">KODE BARANG</label></td>
                            <td>
                                <label style="width: 10px;">:</label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtKODE_BARANG" runat="server" class="form-control" placeholder="KODE BARANG" Style="width: 200px;"></asp:TextBox></td>
                        </tr>

                        <tr>
                            <td>
                                <label>NAMA BARANG</label></td>
                            <td>
                                <label>:</label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtNAMA_BARANG" runat="server" class="form-control" placeholder="NAMA BARANG" Style="width: 400px;"></asp:TextBox></td>
                        </tr>

                        <tr class="form-group">
                            <td>
                                <label>STOCK</label></td>
                            <td>
                                <label>:</label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtSTOK" runat="server" class="form-control" placeholder="STOCK   " Style="width: 150px;"></asp:TextBox></td>
                        </tr>

                        <tr class="form-group">
                            <td>
                                <label>HARGA SATUAN</label></td>
                            <td>
                                <label>:</label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtHARGA" runat="server" class="form-control" placeholder="HARGA SATUAN" Style="width: 400px;"></asp:TextBox></td>
                        </tr>

                        <tr class="form-group">
                            <td>
                                <label>KODE SUPPLIER</label></td>
                            <td>
                                <label>:</label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtKODE_SUPPLIER" runat="server" class="form-control" placeholder="KODE SUPPLIER" Style="width: 400px;"></asp:TextBox></td>
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
