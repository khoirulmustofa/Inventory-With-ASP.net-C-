<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Main.Master" AutoEventWireup="true" CodeBehind="PenjualanList.aspx.cs" Inherits="TugasRPL.Penjualan.PenjualanList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadMain" runat="server">
    <title>Penjualan List | ERP mini Khorul M</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentMain" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div id="content">
                <div class="col-lg-12">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <table style="width: 100%;">
                                <tr>
                                    <td class="col-lg-4">
                                        <h5 style="font-family: 'Arial Rounded MT'">HOME >> PENJUALAN</h5>
                                    </td>
                                    <td class="col-lg-4">
                                        <asp:TextBox ID="txtKODE_PENJUALAN" runat="server" class="form-control" placeholder="KODE PENJULAN"></asp:TextBox></td>
                                    <td class="col-lg-4">
                                        <asp:TextBox ID="txtKODE_CUSTOMER" runat="server" class="form-control" placeholder="KODE CUSTOMER"></asp:TextBox></td>
                                    <td>
                                        <asp:Button ID="btnLOOKUPCUSTOMER" runat="server" class="btn btn-warning btn-sm" Text="PILIH" OnClick="btnLOOKUPCUSTOMER_Click"
                                            OnClientClick="ShowPopupWindow('../Customer/LookupCustomer.aspx','400','700')" /></td>
                                </tr>
                            </table>
                        </div>
                        <div class="panel-body">
                            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                <ContentTemplate>
                                    <table class="table table-hover">
                                        <tr>
                                            <td>
                                                <label style="width: 200px;">KODE BARANG</label></td>
                                            <td>
                                                <label style="width: 10px;">:</label>
                                            </td>
                                            <td>
                                                <div class="input-group">
                                                    <asp:TextBox ID="txtKODE_BARANG" runat="server" class="form-control" placeholder="KODE BARANG" Style="width: 200px;"></asp:TextBox>
                                                    <span>
                                                        <asp:Button ID="btnLOOKUPBARANG" runat="server" class="btn btn-warning btn-sm" Text="PILIH" OnClick="btnLOOKUPBARANG_Click"
                                                            OnClientClick="ShowPopupWindow('../Barang/LookupBarang.aspx','400','700')" />
                                                    </span>
                                                </div>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <label>NAMA BARANG</label></td>
                                            <td>
                                                <label>:</label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtNAMA_BARANG" runat="server" class="form-control"  placeholder="NAMA BARANG" Style="width: 400px;"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <label>JUMLAH</label></td>
                                            <td>
                                                <label>:</label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtJUMLAH" runat="server" class="form-control" placeholder="JUMLAH" Style="width: 150px;"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <label>TANGGAL JUAL</label></td>
                                            <td>
                                                <label>:</label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtTGL_PENJUALAN" runat="server" class="form-control" disabled="disabled" Style="width: 200px;"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td></td>
                                            <td></td>
                                            <td>
                                                <asp:Button ID="btnSave" runat="server" Text="Simpan" class="btn btn-success btn-sm" OnClick="btnSave_Click" /></td>
                                        </tr>
                                    </table>
                                </ContentTemplate>
                            </asp:UpdatePanel>

                            <div class="table-responsive">
                                <asp:GridView ID="gvPenjualan" runat="server" AutoGenerateColumns="false" class="table table-striped table-bordered table-hover"
                                    AllowPaging="true" OnPageIndexChanging="gvPenjualan_PageIndexChanging">
                                    <Columns>
                                        <asp:TemplateField HeaderText="">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="btnDetail" runat="server" Style="color: Blue;" OnClick="btnDetail_Click"
                                                    class="icon-edit btn btn-primary btn-sm btn-circle btn-line" title="EDIT GAN !!"></asp:LinkButton>&nbsp
                                                    <asp:LinkButton ID="btnDelete" runat="server" class="icon-trash btn btn-danger btn-sm btn-circle btn-line"
                                                        title="Yakin Akan Hapus Data ???" OnClientClick="return confirm('Apakah Anda Yakin Akan Menghapus Data Ini ?')" OnClick="btnDelete_Click"
                                                        CommandArgument='<%#Eval("ID_PENJUALAN") %>'></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="KODE_PENJUALAN" HeaderText="KODE PENJUALAN" />
                                        <asp:BoundField DataField="KODE_CUSTOMER" HeaderText="KODE CUSTOMER" />
                                        <asp:BoundField DataField="KODE_BARANG" HeaderText="KODE BARANG" />
                                        <asp:BoundField DataField="JUMLAH_JUAL" HeaderText="JUMLAH JUAL" />
                                        <asp:BoundField DataField="TGL_PENJUALAN" HeaderText="TANGGAL PENJUALAN" HtmlEncode="false" DataFormatString="{0:dd-MMM-yyyy hh:mm:ss}" />
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
