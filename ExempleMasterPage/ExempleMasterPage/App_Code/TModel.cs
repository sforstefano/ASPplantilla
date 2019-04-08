using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de TModel
/// </summary>
public class TModel
{
    public TModel()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public int CheckNombres(String num1)
    {
        int e = 0;
        if (num1 == "")
        {
            e = -2;
        }

        return e;
    }




    public string MissatgeError(int num)
    {
        String error = "";

        switch (num)
        {
            case -1:
                error = "No es pot dividir per 0";
                break;
            case -2:
                error = "Error introduint els nombres";
                break;
        }

        return error;
    }
}