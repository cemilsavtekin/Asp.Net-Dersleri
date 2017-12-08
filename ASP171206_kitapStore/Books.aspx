<%@ Page Title="" Language="C#" MasterPageFile="~/MasterFromMain.master" AutoEventWireup="true" CodeBehind="Books.aspx.cs" Inherits="ASP171206_kitapStore.Books" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderIcerik" runat="server">
    <div class="row">

        <asp:Repeater ID="bookList" runat="server">

            <ItemTemplate>
                <div class="col-sm-6 col-md-3">
                    <div class="thumbnail">
                        <a href="/Details.aspx?ktpID=<%#Eval("Id") %>">
                            <img class="img-fluid" src="/image/<%#Eval("Resim") %>" alt=""/>
                        </a>
                        
                        <div class="caption">
                            <h4><%#Eval("KitapAdi") %></h4>
                            <h3><%#Eval("yazar") %></h3>
                            <p><%#Eval("Detay") %></p>
                            
                        </div>
                    </div>
                </div>
            </ItemTemplate>

        </asp:Repeater>




    </div>
</asp:Content>
