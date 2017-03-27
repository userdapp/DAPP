using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DenunciaVO
/// </summary>
public class DenunciaVO
{
   
    public String IdTipoDenuncia { get; set; }
    public decimal IdDenuncia { get; set; }
    public String DescDenuncia { get; set; }
    public decimal PrioridadDenuncia { get; set; }
    public DateTime FechaDenuncia { get; set; }
    public String Token { get; set; }

   public DenunciaVO() { }

    public DenunciaVO(String denIdTipoDen, decimal denIdDen, String denDescDen, decimal denPriorDen,DateTime denFechaDen, String denToken)
    {
        this.IdTipoDenuncia = denIdTipoDen;
        this.IdDenuncia = denIdDen;
        this.DescDenuncia = denDescDen;
        this.PrioridadDenuncia = denPriorDen;
        this.FechaDenuncia = denFechaDen;
        this.Token = denToken;
    }
}
