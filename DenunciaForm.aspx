<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DenunciaForm.aspx.cs" Inherits="DenunciaForm"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:Panel ID="pnlInsertarDen" runat="server">
        <div class="tabInsert">
            <div class="fila">
             <div class="columna">                    
                        <h1>Registrar Denuncia</h1> 
                </div>
             <div class="columna">
                </div>
             </div>
            <table style="width: 25%">
                <tr>
                    <td>
                        <asp:Label ID="lblTipoDen1" runat="server" Text="Id Tipo Denuncia" ></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlTipoDen" runat="server">
                            <asp:ListItem Value="DA01">Daño Forestal</asp:ListItem>
                            <asp:ListItem Value="DA02">Extracción y Explotación Minera</asp:ListItem>
                            <asp:ListItem Value="DA03">Descarte de Escombros y Vertimiento de Residuos Sólidos</asp:ListItem>
                            <asp:ListItem Value="DA04">Daño o Maltrato a la Fauna</asp:ListItem>
                            <asp:ListItem Value="DA05">Emisiones Contaminantes</asp:ListItem>
                            <asp:ListItem Value="DA06">Invasión de Espacio Natural</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                                

                <tr>
                    <td>
                        <asp:Label ID="lblIdDenuncia" runat="server" Text="Id Denuncia" Visible="false" Enabled="false"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txbIdDenuncia" runat="server" Visible="false" Enabled="false"></asp:TextBox>
                    </td>                   
                </tr>

                <tr>
                     <td>
                        <asp:Label ID="lblDescDenuncia" runat="server" Text="Descripción Denuncia"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txbDescDenuncia" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblAdjSoporte" runat="server" Text="Soportes"></asp:Label>
                    </td>
                 
                    <td>                        
                        <INPUT type="file" id="inAdjSoporte" name="objFile" runat="server" style="DISPLAY: block"/>
                        <br>
                        <input type="submit" id="btnAdjSoporte" value="Subir" runat="server" />
                    </td>   
                    
                </tr>
               


                 <tr>
                     <td>
                         <asp:Label ID="lblPriorDenuncia" runat="server" Text="Prioridad Denuncia" Visible="false" Enabled="false"></asp:Label>
                    </td>
                    <td>
                         <asp:TextBox ID="txbPriorDenuncia" runat="server" Visible="false" Enabled="false"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                     <td>
                         <asp:Label ID="lblFechaDenuncia" runat="server" Text="Fecha Denuncia" Visible="false" ></asp:Label>
                    </td>
                    <td>
                         <asp:TextBox ID="txbFechaDenuncia" runat="server" Enabled="false" Visible="false"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                     <td>
                         <asp:Label ID="lblToken" runat="server" Text="Token" Visible="false" Enabled="false"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txbToken" runat="server" Visible="false" Enabled="false"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                     <td>
                     </td>
                  
                     <td>
                         <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" />
                     </td>
                 </tr>

            </table>       
            
          </div>        
   


  </asp:Panel>
    
     <asp:Panel ID="pnlMostrarDenuncia" runat="server">
       
        
             <div class="columna">                    
                        <h1>¡Denuncia registrada con éxito!</h1> 
              </div>

               <table style="width: 50%">
                   <tr>
                       <td>
                           <h3>Su denuncia fue registrada bajo el token:</h3>
                           <h2><asp:Label ID="lblMostrarToken" runat="server" ForeColor="Red"/></h2>
                           <h4>Por favor, tenga en cuenta este token para realizar la consulta del estado de su denuncia.</h4>
                       </td>
                   </tr>


               </table>

       

  </asp:Panel>
  
</asp:Content>


