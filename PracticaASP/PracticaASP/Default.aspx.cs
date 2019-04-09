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
        String missatge = "";

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
        dia = DropDownList1.DataValueField;
        System.Diagnostics.Debug.WriteLine("Estamos dentro de calculo de importe");

        System.Diagnostics.Debug.WriteLine("El valor de dia es " + dia);
        switch (dia)
        {
            case "1":
                mensaje = diaSemana(valor, 10);
                System.Diagnostics.Debug.WriteLine("Es del tipo de dia 1");
                break;
            case "2":
                mensaje = diaSemana(valor, 14);
                System.Diagnostics.Debug.WriteLine("Es del tipo de dia 2");
                break;
        }


        return mensaje;
    }

    private string diaSemana(decimal valor, decimal preu)
    {
        decimal importe = 0;
        String mensaje = "";
        
        importe = valor - preu;
        System.Diagnostics.Debug.WriteLine("El importe a pagar es " + importe);

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
        String missatge = "Ejems";

        pagado = decimal.Parse(importe.Text);

        System.Diagnostics.Debug.WriteLine("El importe de pagado es " + pagado);

        if (!pagado.Equals(null))
        {
            System.Diagnostics.Debug.WriteLine("Estamos dentro de que no és null");
            missatge = CalculImport(sender, e, pagado);
        }

        resul.Text = missatge;
    }

}