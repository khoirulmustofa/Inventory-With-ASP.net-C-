<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Main.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="TugasRPL.Home.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadMain" runat="server">
    <title>Home Invetory | ERP mini Khorul M</title>
    <link href="../assets/plugins/jquery.fancybox-1.3.4/fancybox/jquery.fancybox-1.3.4.css" rel="stylesheet" />
    <style>
        .panel-body a img {
            margin-bottom: 5px !important;
        }

        .panel-body a {
            color: transparent!important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentMain" runat="server">
    <!--PAGE CONTENT -->
    <div id="content">
        <div class="inner">
            <div class="row">
                <div class="col-lg-12">
                    <h2>DAFTAR ANGGOTA TEAM INVENTORY</h2>
                </div>
            </div>
            <hr />
            <div class="row">
                <div class="col-lg-12">
                    <div class="panel panel-success">
                        <div class="panel-heading">
                            <marquee>Model Tahun 2014</marquee>
                        </div>
                        <div class="panel-body">
                            <p style="text-align: center">
                                <a id="example1" href="../assets/img/aku.gif" title="Lorem ipsum dolor sit amet">
                                    <img src="../assets/img/aku.gif" alt="" /></a>

                                <a id="example2" href="../assets/img/aku.gif" title="Lorem ipsum dolor sit amet">
                                    <img src="../assets/img/aku.gif" alt="" /></a>

                                <a id="example3" href="../assets/img/aku.gif" title="Etiam quis mi eu elit temp">
                                    <img src="../assets/img/aku.gif" alt="" /></a>

                                <a id="example4" href="../assets/img/aku.gif" title="Cras neque mi, semper leon">
                                    <img src="../assets/img/aku.gif" alt="" /></a>
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--END PAGE CONTENT -->
    <!-- PAGE LEVEL SCRIPTS -->
    <script src="../assets/plugins/jquery.fancybox-1.3.4/jquery-1.4.3.min.js"></script>
    <!--important for gallery-->
    <script src="../assets/plugins/jquery.fancybox-1.3.4/fancybox/jquery.mousewheel-3.0.4.pack.js"></script>
    <script src="../assets/plugins/jquery.fancybox-1.3.4/fancybox/jquery.fancybox-1.3.4.js"></script>
    <script src="../assets/js/image_gallery.js"></script>
    <!--END PAGE LEVEL SCRIPTS -->
</asp:Content>
