<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Detail.Master" AutoEventWireup="true" CodeBehind="LookupCustomer.aspx.cs" Inherits="TugasRPL.Customer.LookupCustomer" %>

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
                <div class="panel-body">
                    <div class="table-responsive">
                        <asp:GridView ID="gvlookupcustomer" runat="server" AutoGenerateColumns="false" class="table table-striped table-bordered table-hover">
                            <Columns>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lbSelect" runat="server" class="btn btn-default btn-circle icon-check" OnClick="lbSelect_Click"
                                            CommandArgument='<%#Eval("KODE_CUSTOMER")%>'>PILIH</asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="KODE_CUSTOMER" HeaderText="KODE CUSTOMER" />
                                <asp:BoundField DataField="NAMA_CUSTOMER" HeaderText="NAMA CUSTOMER" />
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
