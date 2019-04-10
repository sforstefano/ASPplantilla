using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    public int random = 0;
    public int intents = -1;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        random = new Random().Next(1000, 9999);

        Label1.Text = Convert.ToString(random);

        Button1.Enabled = false;

        TextBox1.Enabled = true;

        TextBox2.Enabled = true;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if (intents > 0)
        {
            
            int numero = Convert.ToInt16(TextBox2.Text);
            if (numero != random)
            {
                Label3.Text =  ":(((((((((((";
            }
            else
            {
                Label3.Text = ":))))))))))";
                Button2.Enabled = false;
            }

            intents--;
            TextBox1.Text = Convert.ToString(intents);
        }
        else
        {
            Button2.Enabled = false;
        }
        
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        
        String a = TextBox1.Text;

        intents = Convert.ToInt16(a);
        System.Diagnostics.Debug.WriteLine("A canviado el valor del TextBox a " + a);

        TextBox1.Attributes.Add("readonly", "readonly");
        Button2.Enabled = true;
    }
}