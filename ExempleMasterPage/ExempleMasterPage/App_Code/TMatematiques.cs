using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de TMatematiques
/// </summary>
public class TMatematiques
{
    public TMatematiques()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public int Calcular(int num1, int num2, String operacio, ref int error)
    {
        int res = 0;
        error = 0;


        switch (operacio)
        {
            case "+":
                res = num1 + num2;

                break;

            case "-":
                res = num1 - num2;

                break;

            case "*":
                res = num1 * num2;

                break;
            case "/":

                if (num2 == 0)
                {
                    error = -1;
                }
                else
                {
                    res = num1 / num2;
                }


                break;
        }

        return res;
    }

    public int FerMCM(int num1, int num2)
    {
        int res = 0;
        int comodin = 0;
        Boolean mcm = false;
        if (num1 == num2)
        {
            res = num1;
        }
        else
        {

            if (num1 > num2)
            {
                comodin = num1;
            }
            else if (num2 > num1)
            {
                comodin = num2;
            }

            do
            {


                if ((comodin % num1 == 0) && (comodin % num2 == 0))
                {
                    mcm = true;
                    res = comodin;
                }
                else
                {
                    comodin++;
                }
            } while (!mcm);
        }



        return res;
    }

    public int EsPrimer(int num1)
    {
        int res = -1;
        int comodin = num1 - 1;
        Boolean primer = true;
        Boolean fi = false;

        if (num1 > 1)
        {
            do
            {

                if (num1 % comodin == 0)
                {
                    primer = false;
                    res = -2;
                }

                comodin--;
                if (comodin == 1)
                {
                    fi = true;
                }

            } while (primer && !fi);
        }

        return res;
    }


    public int FerFactorial(int num1)
    {
        int res = 1;


        for (int a = 1; a <= num1; a++)
        {
            res = res * a;
        }
        return res;

    }

    public int FerAbs(int num1)
    {
        int res = 0;

        if (num1 > 0)
        {
            res = num1;
        }
        else
        {
            res = num1 * -1;
        }

        return res;

    }

    public int BuscaMajor(int num1, int num2)
    {
        int res = 0;
        if (num1 >= num2)
        {
            res = num1;
        }
        else
        {
            res = num2;
        }

        return res;
    }

    public int BuscaMenor(int num1, int num2)
    {
        int res = 0;
        if (num1 <= num2)
        {
            res = num1;
        }
        else
        {
            res = num2;
        }

        return res;
    }

    public float FesAVG(int num1, int num2)
    {
        return (num1 + num2)/2;
    }
}