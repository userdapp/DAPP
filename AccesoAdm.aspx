<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AccesoAdm.aspx.cs" Inherits="AccesoAdm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:Panel ID="pnlAccesoAdm" runat="server">
        <div class="Acceder">
            <div class="fila">
             <div class="columna">                    
                        <h1>Acceso a Administradores</h1> 
                </div>
             <div class="columna">
             </div>
             </div>
            <table style="width: 25%">
            <tr>
                <td>
                    <asp:Label ID="lblUsr" runat="server" Text="Usuario"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txbUsr" runat="server"></asp:TextBox>
                </td>    
            </tr>   
             <tr>
                 <td>
                     <asp:Label ID="lblPsw" runat="server" Text="Password"></asp:Label>
                </td> 
                 
                 <td>
                     <asp:TextBox ID="txbPsw" runat="server" TextMode="Password"></asp:TextBox>
                </td>   
            </tr>
             <tr>
                 <td>
                </td>                  
                 <td>
                     <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                </td> 
                <td>
                    <asp:Button ID="btnCancel" runat="server" Text="Cancelar" />
                </td>  
            </tr>  
            
            </table>

        </div>
    </asp:Panel>

    <asp:Panel  ID ="pnlEnt" runat="server">
        <div class="Entidad">
            <div class="fila">
             <div class="columna">                    
                        <h1>Información de Denuncias</h1> 
                </div>
             <div class="columna">
             </div>
             </div>            
        </div>
    </asp:Panel>
</asp:Content>

