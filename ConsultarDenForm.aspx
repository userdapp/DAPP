<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ConsultarDenForm.aspx.cs" Inherits="ConsultarDenForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:Panel ID="pnlConsultarDen" runat="server">
        <div class="tabConsultarDen">
            <div class="fila">
             <div class="columna">                    
                        <h1>Digite token para realizar la consulta</h1> 
                </div>
             <div class="columna">
                </div>
             </div>

             <table style="width: 25%">
                 <tr>
                     <td>
                         <asp:TextBox ID="txbConsultarDen" runat="server"></asp:TextBox>
                     </td>
                     <td>
                         <asp:Button ID="btnConsultarDen" runat="server" Text="Consultar" OnClick="btnConsultarDen_Click" />
                     </td>
                 </tr>

              </table>
        </div>
    </asp:Panel>
    <asp:Panel ID="pnlMostrarInfoDen" runat="server">
        <div class="tabMostrarInfDen">
            <div class="fila">
             <div class="columna">                    
                        <h1>Resultados de la consulta</h1> 
             </div>
             <div class="columna">
             </div>
            </div>
             <asp:GridView ID="GridViewConsDen" runat="server" AutoGenerateColumns="False">
                 <columns>
                     <asp:BoundField DataField="Token" HeaderText="Token"/>
                     <asp:BoundField DataField="FechaDenuncia" HeaderText="Fecha de Denuncia"/>
                     <asp:BoundField DataField="DescDenuncia" HeaderText="Descripcion"/>
                 </columns>

            </asp:GridView>

        </div>
    </asp:Panel>

</asp:Content>

