<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Main.Master" AutoEventWireup="true" CodeBehind="LaporanBarang.aspx.cs" Inherits="TugasRPL.Laporan.LaporanBarang" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadMain" runat="server">
    <title>Hallo</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentMain" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div id="content">
                <div class="col-lg-12">
                    <div class="panel panel-default">
                        <div style="margin: 20px 20px;">
                            <rsweb:ReportViewer ID="ReportViewerBarang" runat="server" Width="99%" Height="70%"
                                ></rsweb:ReportViewer>
                        </div>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
