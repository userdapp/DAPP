using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class AccesoAdm : System.Web.UI.Page
{
    public String usr;
    public String psw;
    UsuarioVO usuarioVO = new UsuarioVO();

    protected void Page_Load(object sender, EventArgs e)
    {
        this.pnlEnt.Visible = false;
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        BDComun.ObtenerConexion();

        usr = txbUsr.Text;
        psw = txbPsw.Text;

        List<UsuarioVO> usuario = UsuarioDAO.Buscar(usr,psw);

        if (usuario.Count > 0 && usuario != null)
        {
            this.pnlEnt.Visible = true;
            this.pnlAccesoAdm.Visible = false;
        }
        else
        {
            this.pnlAccesoAdm.Visible = true;
        }

    }
}