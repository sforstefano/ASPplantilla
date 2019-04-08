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


    protected void Operacio_Click(object sender, EventArgs e)
    {
        TModel calc = new TModel();
        TMatematiques mates = new TMatematiques();
        int error = 0;
        int res = 0;
        int error2 = 0;
        int num1 = 0;
        int num2 = 0;
        int.TryParse(op1.Text, out num1);
        int.TryParse(op2.Text, out num2);

        error = calc.CheckNombres(op1.Text);
        error = calc.CheckNombres(op2.Text);



        if (error == 0)
        {
            String operacio = ((Button)sender).Text;
            res = mates.Calcular(num1, num2, operacio, ref error2);

            if (error2 == 0)
            {
                resposta.Text = Convert.ToString(res);
            }
            else
            {
                resposta.Text = calc.MissatgeError(error2);
            }
        }
        else
        {
            resposta.Text = calc.MissatgeError(error);
        }

        
    }



    protected void DDaltresOps_SelectedIndexChanged(object sender, EventArgs e)
    {
        TModel calc = new TModel();
        int error = 0;
        float res = 0;
        int num1;
        int num2 = 0;

        int.TryParse(op1.Text, out num1);
        int.TryParse(op2.Text, out num2);


        String operacio = "";

        error = calc.CheckNombres(op1.Text);

        if (error == 0)
        {
            operacio = DDaltresOps.SelectedValue;

            res = OperacionsComplexes(num1, num2, operacio);
            if (res > -1)
            {
                resposta.Text = Convert.ToString(res);
            }
            else
            {
                if (res == -1)
                {
                    resposta.Text = "Si";
                }
                else
                {
                    resposta.Text = "No";
                }
            }
            
        }
        else {
            resposta.Text = calc.MissatgeError(error);
        }


    }

    public float OperacionsComplexes(int num1, int num2, String operacio)
    {
        float res = 0;
        TModel calc = new TModel();
        TMatematiques mates = new TMatematiques();

        switch (operacio)
        {
            case "f":
                res = mates.FerFactorial(num1);
                break;
            case "abs":
                res = mates.FerAbs(num1);
                break;

            case "mcm":
                res = mates.FerMCM(num1, num2);
                break;
            case "primer":
                res = mates.EsPrimer(num1);
                break;
            case "major":
                res = mates.BuscaMajor(num1, num2);
                break;
            case "menor":
                res = mates.BuscaMenor(num1, num2);
                break;
            case "avg":
                res = mates.FesAVG(num1, num2);
                break;

        }

        return res;
    }




}