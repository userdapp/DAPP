using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de UsuarioVO
/// </summary>
public class UsuarioVO
{
    public String IdEntidad { get; set; }
    public String IdUsuario { get; set; }
    public String IdTipoDoc { get; set; }
    public float DocIdent { get; set; }
    public String NombreUsuario { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public float Tel1 { get; set; }
    public float Tel2 { get; set; }
    public float Cel { get; set; }
    public String Email { get; set; }
    public String Usr { get; set; }
    public String Pass { get; set; }

    public UsuarioVO() { }

    public UsuarioVO(String uIdEntidad, String uIdUsuario, String uIdTipoDoc, float uDocIdent, String uNombreUsuario, DateTime uFechaNacimiento, float uTel1, float uTel2, float uCel, String uEmail, String uUsr, String uPass)
    {
        this.IdEntidad = uIdEntidad;
        this.IdUsuario = uIdUsuario;
        this.IdTipoDoc = uIdTipoDoc;
        this.DocIdent = uDocIdent;
        this.NombreUsuario = uNombreUsuario;
        this.FechaNacimiento = uFechaNacimiento;
        this.Tel1 = uTel1;
        this.Tel2 = uTel2;
        this.Cel = uCel;
        this.Email = uEmail;
        this.Usr = uUsr;
        this.Pass = uPass;
    }
}