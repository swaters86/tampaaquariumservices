<%@ Page Title="" Language="VB" MasterPageFile="~/Masters/Homepage.master" AutoEventWireup="false" CodeFile="Gallery.aspx.vb" Inherits="Gallery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:DataList ID="dlGallery1" runat="server" CssClass="Gallery1" RepeatColumns="5">
        <ItemTemplate>
            <a runat="server" href='<%# DataBinder.Eval(Container.DataItem, "FullImageLink")%>'>
                <img  runat="server"
                    src='<%# DataBinder.Eval(Container.DataItem, "ThumbNailLink")%>' />
            </a>
        </ItemTemplate>
    </asp:DataList>

    <script type="text/javascript">
        $(function () { $('.Gallery1 a').lightBox(); });
    </script>
</asp:Content>

