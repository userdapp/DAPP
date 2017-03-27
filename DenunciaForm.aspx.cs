using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Windows;




public partial class DenunciaForm : System.Web.UI.Page
{

    DenunciaVO denunciaVO = new DenunciaVO(); 

    protected void Page_Load(object sender, EventArgs e)
    {
        this.pnlMostrarDenuncia.Visible = false;

        txbFechaDenuncia.Text = DateTime.Now.ToString("yyyy-MM-dd");//debe quitarse
        txbToken.Text = GenerarToken();
        txbIdDenuncia.Text=GenerarRandomID();
        txbPriorDenuncia.Text = "2";

    }

    protected string GenerarToken()
    {
        String date = DateTime.Now.ToString("yyyyMMdd");
        String random = GenerarRandomToken();
        string token = date + "EE" + random;
        return token;
    }


    protected String GenerarRandomID()
    {
        String rand;
        Random rnd = new Random();
        rand = Convert.ToString(rnd.Next(10000000, 100000000));
        return rand;
    }

    protected String GenerarRandomToken()
    {
        String rand;
        Random rnd = new Random();
        rand = Convert.ToString(rnd.Next(10000, 100000));
        return rand;
    }

    protected void btnRegistrar_Click(object sender, EventArgs e)
    {

        BDComun.ObtenerConexion();

        // txbIdTipoDen.Text = GenerarRandom();          


        denunciaVO.IdTipoDenuncia = ddlTipoDen.SelectedItem.Value;
        denunciaVO.IdDenuncia = Convert.ToInt32(txbIdDenuncia.Text);//debe traer esta info automáticamente
        denunciaVO.DescDenuncia = txbDescDenuncia.Text;
        denunciaVO.PrioridadDenuncia = Convert.ToInt32(txbPriorDenuncia.Text);//Debe generar esta info automáticamente
        //denunciaVO.FechaDenuncia = Convert.ToDateTime(txbFechaDenuncia.Text);
        denunciaVO.Token = txbToken.Text;

        int resultado = DenunciaDAO.Agregar(denunciaVO);


        if (resultado > 0)
        {
            this.pnlMostrarDenuncia.Visible = true;
            this.pnlInsertarDen.Visible = false;


            this.lblMostrarToken.Text = txbToken.Text;

        }
        else
        {
            this.pnlInsertarDen.Visible = false;
        }

        /* this.tipoDenuncia = this.txbTipoDenuncia.Text;
         this.descDenuncia = this.txbDescDenuncia.Text;
         this.fechaDenuncia = this.txbFechaDenuncia.Text;

         this.pnlMostrarDenuncia.Visible = true;
         this.pnlInsertarDen.Visible = false;

         this.lblTipoDenuncia2.Text = this.tipoDenuncia;
         this.lblDescDenuncia2.Text = this.descDenuncia;
         this.lblFechaDenuncia2.Text = this.fechaDenuncia;*/

    }

   
   


    
}