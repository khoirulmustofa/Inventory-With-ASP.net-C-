<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Main.Master" AutoEventWireup="true" CodeBehind="SuppllierList.aspx.cs" Inherits="TugasRPL.Suppllier.SuppllierList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadMain" runat="server">
    <title>Supplier List | ERP Mini Khoirul M</title>
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
                                        <h5 style="font-family: 'Arial Rounded MT'">HOME >> DAFTAR SUPPLIER</h5>
                                    </td>
                                    <td class="col-lg-4">
                                        <asp:DropDownList ID="ddlCari" runat="server" class="form-control">
                                            <asp:ListItem>KODE_SUPPLIER</asp:ListItem>
                                            <asp:ListItem>NAMA_SUPPLIER</asp:ListItem>
                                            <asp:ListItem>ALAMAT_SUPPLIER</asp:ListItem>
                                            <asp:ListItem>TELEPON_SUPPLIER</asp:ListItem>
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
                                <asp:GridView ID="gvSuppllier" runat="server" AutoGenerateColumns="false" class="table table-striped table-bordered table-hover"
                                    AllowPaging="true" OnPageIndexChanging="gvSuppllier_PageIndexChanging">
                                    <Columns>
                                        <asp:TemplateField HeaderText="">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="btnDetail" runat="server" Style="color: Blue;" OnClick="btnDetail_Click"
                                                    OnClientClick='<%# "ShowPopupWindow(\"SupplierDetail.aspx?DataID="+Eval("KODE_SUPPLIER")+"&PageState=1\",\"800\",\"700\")" %>'
                                                    class="icon-edit btn btn-primary btn-sm btn-circle btn-line" title="EDIT GAN !!"></asp:LinkButton>&nbsp
                                                    <asp:LinkButton ID="btnDelete" runat="server" class="icon-remove btn btn-danger btn-sm btn-circle btn-line"
                                                        title="Yakin Akan Hapus Data ???" OnClientClick="return confirm('Apakah Anda Yakin Akan Menghapus Data Ini ?')" OnClick="btnDelete_Click"
                                                        CommandArgument='<%#Eval("KODE_SUPPLIER") %>'></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="KODE_SUPPLIER" HeaderText="KODE SUPPLIER" />
                                        <asp:BoundField DataField="NAMA_SUPPLIER" HeaderText="NAMA SUPPLIER" />
                                        <asp:BoundField DataField="ALAMAT_SUPPLIER" HeaderText="ALAMAT SUPPLIER" />
                                        <asp:BoundField DataField="TELEPON_SUPPLIER" HeaderText="TELEPON SUPPLIER" />
                                    </Columns>
                                </asp:GridView>
                            </div>
                            <div style="padding-left: 80%">
                                <asp:Button ID="btnTambah" runat="server" Text="TAMBAH BARANG BARU" class="btn btn-success btn-sm"
                                    OnClick="btnTambah_Click"
                                    OnClientClick="ShowPopupWindow('SupplierDetail.aspx?PageState=0','800','700');" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
