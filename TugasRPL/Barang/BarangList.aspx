<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Main.Master" AutoEventWireup="true" CodeBehind="BarangList.aspx.cs" Inherits="TugasRPL.Barang.BarangList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadMain" runat="server">
    <title>Barang List | ERP mini Khorul M</title>
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
                                        <h5 style="font-family: 'Arial Rounded MT'">HOME >> DAFTAR BARANG</h5>
                                    </td>
                                    <td class="col-lg-4">
                                        <asp:DropDownList ID="ddlCari" runat="server" class="form-control">
                                            <asp:ListItem>KODE_BARANG</asp:ListItem>
                                            <asp:ListItem>NAMA_BARANG</asp:ListItem>
                                            <asp:ListItem>STOK</asp:ListItem>
                                            <asp:ListItem>HARGA</asp:ListItem>
                                            <asp:ListItem>KODE_SUPPLIER</asp:ListItem>
                                        </asp:DropDownList></td>
                                    <td class="col-lg-4">
                                        <asp:TextBox ID="txtCari" runat="server" class="form-control" placeholder="Cari Disini Mas Bro !!"></asp:TextBox></td>
                                    <td class="col-lg-2">
                                        <asp:Button ID="btnCari" runat="server" Text="CARI" class="btn btn-default" OnClick="btnCari_Click" /></td>
                                </tr>
                            </table>
                        </div>
                        <div class="panel-body">
                            <div class="table-responsive">
                                <asp:GridView ID="gvBarang" runat="server" AutoGenerateColumns="false" class="table table-striped table-bordered table-hover"
                                    AllowPaging="true" OnPageIndexChanging="gvBarang_PageIndexChanging">
                                    <Columns>
                                        <asp:TemplateField HeaderText="">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="btnDetail" runat="server" Style="color: Blue;" OnClick="btnDetail_Click"
                                                    OnClientClick='<%# "ShowPopupWindow(\"BarangDetail.aspx?DataID="+Eval("KODE_BARANG")+"&PageState=1\",\"800\",\"700\")" %>'
                                                    class="icon-edit btn btn-primary btn-sm btn-circle btn-line" title="EDIT GAN !!"></asp:LinkButton>&nbsp
                                                    <asp:LinkButton ID="btnDelete" runat="server" class="icon-trash btn btn-danger btn-sm btn-circle btn-line"
                                                        title="Yakin Akan Hapus Data ???" OnClientClick="return confirm('Apakah Anda Yakin Akan Menghapus Data Ini ?')" OnClick="btnDelete_Click"
                                                        CommandArgument='<%#Eval("KODE_BARANG") %>'></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="KODE_BARANG" HeaderText="KODE BARANG" />
                                        <asp:BoundField DataField="NAMA_BARANG" HeaderText="NAMA BARANG" />
                                        <asp:BoundField DataField="STOK" HeaderText="STOK" />
                                        <asp:BoundField DataField="HARGA" HeaderText="HARGA" />
                                        <asp:BoundField DataField="KODE_SUPPLIER" HeaderText="KODE SUPPLIER" />
                                    </Columns>
                                </asp:GridView>
                            </div>
                            <div style="padding-left: 80%">
                                <asp:Button ID="btnTambah" runat="server" Text="TAMBAH BARANG BARU" class="btn btn-success btn-sm"
                                    OnClick="btnTambah_Click"
                                    OnClientClick="ShowPopupWindow('BarangDetail.aspx?PageState=0','800','700');" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
