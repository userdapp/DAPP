using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ConsultarDenForm : System.Web.UI.Page
{
    public String denToken;
    DenunciaVO denunciaVO = new DenunciaVO();

    protected void Page_Load(object sender, EventArgs e)
    {
        this.pnlMostrarInfoDen.Visible = false;
    }

    protected void btnConsultarDen_Click(object sender, EventArgs e)
    {      

        BDComun.ObtenerConexion();

        denToken = txbConsultarDen.Text;

        List<DenunciaVO> denuncia= DenunciaDAO.Buscar(denToken);
      
        if(denuncia.Count> 0 && denuncia != null)
        {
            GridViewConsDen.DataSource = denuncia;
            GridViewConsDen.DataBind();
        }             
        /*
        txbToken.Text = denuncia[0].Token; //denunciaVO.Token;
        txbFechaDenuncia.Text = "hola";//String.Format("{0:MM/dd/yyyy}", denuncia[1].FechaDenuncia);//denunciaVO.FechaDenuncia;
        txbDescripcion.Text = denuncia[2].DescDenuncia;//denunciaVO.DescDenuncia;*/
        
        this.pnlMostrarInfoDen.Visible = true;
        this.pnlConsultarDen.Visible = false;
    }

 }