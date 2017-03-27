<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Inicio.aspx.cs" Inherits="Inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:Panel ID="pnlInicio" runat="server">
        <div class="tabInicio">
         <div class="fila">
             <div class="columna">                    
                        <h1>Bienvenido a Denuncia Ambiental</h1> 
                </div>
             <div class="columna">
                </div>
             </div>
        
             <table style="width: 50%">
                 <tr>
                     <td>
                         <input id="Button1" type="button" value="Hacer denuncia" onclick="location='DenunciaForm.aspx'" />
                        
                     </td>
                     <td>
                         <input id="Button2" type="button" value="Consultar denuncia" onclick="location='ConsultarDenForm.aspx'" /> 
                         
                     </td>
                 </tr>
                 
                 <tr>
                     <td>
                         <asp:LinkButton ID="lnkAccesoAdm" runat="server">Acceso a Administradores</asp:LinkButton>
                     </td>
                 </tr>

             </table>

        
        </div>

    </asp:Panel>

</asp:Content>

