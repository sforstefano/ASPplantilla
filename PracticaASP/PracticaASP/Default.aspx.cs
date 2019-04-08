using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

        int valor;
        String missatge;

        if (Int32.TryParse(importe.Text, out valor))
        {

            
        }
        else
        {
            missatge = "Sembla que no has introduït un import correcte...";
        }

        resul.Text = missatge;

    }

    private String CalculImport(object sender, EventArgs e, decimal valor)
    {
        String dia;
        String mensaje = "";
        dia = importe.ID;
        switch (dia)
        {
            case "1":
                mensaje = diaSemana(valor, 10);
                break;
            case "2":
                mensaje = diaSemana(valor, 14);
                break;
        }


        return mensaje;
    }

    private string diaSemana(decimal valor, int preu)
    {
        int importe = 0;
        String mensaje = "";
        importe = valor - preu;

        if (importe > 0)
        {
            mensaje = "Et retornem " + importe + " €";
        }
        else if (importe < 0)
        {
            mensaje = "Ens deus " + importe + " €";
        }
        else
        {
            mensaje = "Mersi per la teva visita";
        }

        return mensaje;
    }


    protected void DropDownList1_SelectedIndexChanged2(object sender, EventArgs e)
    {

        decimal pagado = 0;
        String missatge = "";

        pagado = decimal.Parse(importe.Text);

        if (!pagado.Equals(null))
        {
            missatge = CalculImport(sender, e, pagado);
        }

        String muestra = pagado.ToString();

        resul.Text = muestra;





    }

}