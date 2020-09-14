﻿<%@ Page Title="Usuarios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UI.Web.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server" >
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" SelectedRowStyle-BackColor="Black" SelectedRowStyle-ForeColor="White" DataKeyNames="ID" OnLoad="Page_Load">
        <Columns>
            <asp:BoundField HeaderText="Nombre" DataField="Nombre"/>
            <asp:BoundField HeaderText="Apellido" DataField="Apellido"/>
            <asp:BoundField HeaderText="Email" DataField="Email"/>
            <asp:BoundField HeaderText="Usuario" DataField="NombreUsuario"/>
            <asp:BoundField HeaderText="Habilitado" DataField="Habilitado"/>
            <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />
        </Columns>
        </asp:GridView>
    </asp:Panel>
</asp:Content>