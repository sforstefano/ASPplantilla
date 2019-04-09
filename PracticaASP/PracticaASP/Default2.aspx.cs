using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        System.Diagnostics.Debug.WriteLine("Entra a la execusió del botó");

        String value = TextBox1.Text;
        int numero = Int32.Parse(value);
        System.Diagnostics.Debug.WriteLine("El numero es " + numero);
        String result = "";

        result = es_perfecte(numero);
        System.Diagnostics.Debug.WriteLine("La funcio retorna " + result);
        Label1.Text = result;
    }

    private String es_perfecte(int numero)
    {
        String esPerf = "No és perfecte :(";
        int limit;
        int suma = 0;
        int comodin = numero;

        if (numero % 2 == 2)
        {
            limit = numero / 2;
        }
        else
        {
            numero += 1;
            limit = numero / 2;
        }

        System.Diagnostics.Debug.WriteLine("El limit és " + limit);

        for (int i = limit; i>0; i--)
        {
            if (comodin % i == 0)
            {
                suma += i;
            }
        }

        System.Diagnostics.Debug.WriteLine("La suma és " + suma);

        if (suma == comodin)
        {
            esPerf = "Sí és perfecte :)";
        }

        return esPerf;
    }
}