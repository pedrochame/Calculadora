using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (visor.Text.Count()>0) {
                if (visor.Text[visor.Text.Count() - 1] == ')')
                {
                    return;
                }
                if (visor.Text[visor.Text.Count()-1] == '=') {
                    return;
                }
            }



                visor.Text += "1";
     

            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botao2_Click(object sender, EventArgs e)
        {

            if (visor.Text.Count() > 0)
            {
                if (visor.Text[visor.Text.Count() - 1] == ')')
                {
                    return;
                }
                if (visor.Text[visor.Text.Count() - 1] == '=')
                {
                    return;
                }
            }
            visor.Text += "2";
            

            
        }

        private void botao3_Click(object sender, EventArgs e)
        {
            if (visor.Text.Count() > 0)
            {
                if (visor.Text[visor.Text.Count() - 1] == ')')
                {
                    return;
                }
                if (visor.Text[visor.Text.Count() - 1] == '=')
                {
                    return;
                }
            }
            visor.Text += "3";
           
        }

        private void botao4_Click(object sender, EventArgs e)
        {
            if (visor.Text.Count() > 0)
            {
                if (visor.Text[visor.Text.Count() - 1] == ')')
                {
                    return;
                }
                if (visor.Text[visor.Text.Count() - 1] == '=')
                {
                    return;
                }
            }
            visor.Text += "4";
            
            
        }

        private void botao5_Click(object sender, EventArgs e)
        {
            if (visor.Text.Count() > 0)
            {
                if (visor.Text[visor.Text.Count() - 1] == ')')
                {
                    return;
                }
                if (visor.Text[visor.Text.Count() - 1] == '=')
                {
                    return;
                }
            }

            visor.Text += "5";

            
        }

        private void botao6_Click(object sender, EventArgs e)
        {
            if (visor.Text.Count() > 0)
            {
                if (visor.Text[visor.Text.Count() - 1] == ')')
                {
                    return;
                }
                if (visor.Text[visor.Text.Count() - 1] == '=')
                {
                    return;
                }
            }

            visor.Text += "6";

        }

        private void botao7_Click(object sender, EventArgs e)
        {
            if (visor.Text.Count() > 0)
            {
                if (visor.Text[visor.Text.Count() - 1] == ')')
                {
                    return;
                }
                if (visor.Text[visor.Text.Count() - 1] == '=')
                {
                    return;
                }
            }
            visor.Text += "7";

            
        }

        private void botao8_Click(object sender, EventArgs e)
        {
            if (visor.Text.Count() > 0)
            {
                if (visor.Text[visor.Text.Count() - 1] == ')')
                {
                    return;
                }
                if (visor.Text[visor.Text.Count() - 1] == '=')
                {
                    return;
                }
            }
            visor.Text += "8";

          
        }

        private void botao9_Click(object sender, EventArgs e)
        {
            if (visor.Text.Count() > 0)
            {
                if (visor.Text[visor.Text.Count() - 1] == ')')
                {
                    return;
                }
                if (visor.Text[visor.Text.Count() - 1] == '=')
                {
                    return;
                }
            }
            visor.Text += "9";

        }

        private void botao0_Click(object sender, EventArgs e)
        {
            if (visor.Text.Count() > 0)
            {
                if (visor.Text[visor.Text.Count() -1] == ')')
                {
                    return;
                }
                if (visor.Text[visor.Text.Count() - 1] == '=')
                {
                    return;
                }
            }
            visor.Text += "0";
            
        }

        private void botaoPonto_Click(object sender, EventArgs e)
        {
            if (visor.Text.Count() > 0)
            {
                if (visor.Text[visor.Text.Count() - 1] == '=')
                {
                    return;
                }
            }
            int ultimaPos = visor.Text.Count() - 1;

            if (ultimaPos == -1)
            {
                visor.Text = "0,";
                return;
            }

            if (visor.Text[ultimaPos] == '(' || visor.Text[ultimaPos] == '+' || visor.Text[ultimaPos] == '-' || visor.Text[ultimaPos] == '*' || visor.Text[ultimaPos] == '/')
            {
                visor.Text += "0,";
                return;
            }




            int nVirgula = 0, nOp = 0;
            for(int i = 0; i <= ultimaPos; i++)
            {
                if (visor.Text[i] == ',')
                {
                    nVirgula++;
                }
                if (visor.Text[i] == '+' || visor.Text[i] == '-' || visor.Text[i] == '/' || visor.Text[i] == '*')
                {
                    nOp++;
                }
            }

            if (nVirgula > nOp)
            {
                return;
            }
            
            
            
            
            
            visor.Text += ",";
        }

        private void botaoDiv_Click(object sender, EventArgs e)
        {
            if (visor.Text.Count() > 0)
            {
                if (visor.Text[visor.Text.Count() - 1] == '*')
                {
                    return;
                }

                if (visor.Text.Count() > 1 && visor.Text[visor.Text.Count() - 2] == '(' && visor.Text[visor.Text.Count() - 1] == '+' || visor.Text[visor.Text.Count() - 1] == '-')
                {
                    return;
                }

                if (visor.Text[visor.Text.Count() - 1] == '(')
                {
                    return;
                }
                if (visor.Text[visor.Text.Count() - 1] == '/')
                {
                    return;
                }
                if (visor.Text[visor.Text.Count() - 1] == '=')
                {
                    return;
                }
            }
            int ultimaPos = visor.Text.Count() - 1;

            if (visor.Text == "-" || visor.Text == "+")
            {
                return;
            }

            if (ultimaPos == -1)
            {
                return;
            }

            if (visor.Text[ultimaPos] == '+' || visor.Text[ultimaPos] == '-' || visor.Text[ultimaPos] == '*' || visor.Text[ultimaPos] == '/')
            {
                visor.Text = visor.Text.Remove(ultimaPos);
            }

            if (visor.Text[ultimaPos] == ',') {
                visor.Text += "0/";
            }
            else {
                visor.Text += "/";
            }
        }

        private void botaoMult_Click(object sender, EventArgs e)
        {
            if (visor.Text.Count() > 0)
            {
                if (visor.Text.Count()>1 && visor.Text[visor.Text.Count() - 2] == '(' && visor.Text[visor.Text.Count() - 1] == '+' || visor.Text[visor.Text.Count() - 1] == '-')
                {
                    return;
                }

                if (visor.Text[visor.Text.Count() - 1] == '(')
                {
                    return;
                }
                if (visor.Text[visor.Text.Count() - 1] == '*')
                {
                    return;
                }
                if (visor.Text[visor.Text.Count() - 1] == '=')
                {
                    return;
                }
            }
            int ultimaPos = visor.Text.Count() - 1;

            if (ultimaPos == -1)
            {
                return;
            }

            if (visor.Text == "-" || visor.Text == "+")
            {
                return;
            }

            if (visor.Text[ultimaPos] == '+' || visor.Text[ultimaPos] == '-' || visor.Text[ultimaPos] == '*' || visor.Text[ultimaPos] == '/')
            {
                visor.Text = visor.Text.Remove(ultimaPos);
                ultimaPos--;
            }

            if (visor.Text[ultimaPos] == ',')
            {
                visor.Text += "0*";
            }
            else {
                visor.Text += "*";
            }
        }

        private void botaoMenos_Click(object sender, EventArgs e)
        {
            if (visor.Text.Count() > 0)
            {
                
                if (visor.Text[visor.Text.Count() - 1] == '=')
                {
                    return;
                }
            }
            int ultimaPos = visor.Text.Count() - 1;
            
            
            if (ultimaPos > -1)
            {

                if (visor.Text[ultimaPos] == '+')
                {
                    visor.Text = visor.Text.Remove(ultimaPos);
                    visor.Text += "-";
                }

                else if (visor.Text[ultimaPos] == '-')
                {
                    visor.Text = visor.Text.Remove(ultimaPos);
                    visor.Text += "+";
                }

                else if (visor.Text[ultimaPos] == '*' || visor.Text[ultimaPos] == '/')
                {
                    visor.Text += "-";
                }
                else if (visor.Text[ultimaPos] == ',')
                {
                    visor.Text += "0-";
                }
                else{
                    visor.Text += "-";
                }
            }
            else
            {
                visor.Text += "-";
            }
        }

        private void botaoMais_Click(object sender, EventArgs e)
        {
            if (visor.Text.Count() > 0)
            {


                if (visor.Text[visor.Text.Count() - 1] == '-')
                {
                    visor.Text = visor.Text.Remove(visor.Text.Count() - 1);
                    visor.Text += '+';
                    return;
                }
                if (visor.Text[visor.Text.Count() - 1] == '+')
                {
                    return;
                }
                if (visor.Text[visor.Text.Count() - 1] == '=')
                {
                    return;
                }
            }
            int ultimaPos = visor.Text.Count() - 1;

            if (ultimaPos == -1)
            {
                return;
            }

            if (visor.Text == "-" || visor.Text == "+")
            {
                return;
            }

            if (visor.Text[ultimaPos] == ',')
            {
                visor.Text += "0+";
            }
            else {
                visor.Text += "+";
            }
            
        }

        private void botaoIgual_Click(object sender, EventArgs e)
        {
            int abreP = 0, fechaP = 0;
            for (int i = 0; i < visor.Text.Count(); i++) {
                if (visor.Text[i] == '(')
                {
                    abreP++;
                    if (visor.Text[i+1] == ')') { return; }
                }
                if (visor.Text[i] == ')')
                {
                    fechaP++;
                }
            }
            if (abreP != fechaP)
            {
                return;
            }

            if (visor.Text.Count() > 0)
            {
                if (visor.Text[visor.Text.Count() - 1] == '=')
                {
                    return;
                }
            }
            int ultimaPos = visor.Text.Count() - 1;
            string visorTexto = visor.Text;
            

            if (ultimaPos == -1)
            {
                return;
            }

            if (visorTexto[0] == '*' || visorTexto[0] == '/')
            {
                return;
            }

            if (!visorTexto.Contains('+') && !visorTexto.Contains('-') && !visorTexto.Contains('*') && !visorTexto.Contains('/'))
            {
                return;
            }

            if (visorTexto[ultimaPos] == '=' || visorTexto[ultimaPos] == '+' || visorTexto[ultimaPos] == '-' || visorTexto[ultimaPos] == '*' || visorTexto[ultimaPos] == '/') {
                return;
            }

            if (visor.Text[ultimaPos] == ',')
            {
                visor.Text += "0=";
                ultimaPos += 2;
            }
            else
            {

                visor.Text += '=';
                ultimaPos += 1;
            }

            visorTexto = visor.Text;
            
            List<string> conta = new List<string>();

            for (int i = 0; i <= ultimaPos; i++)
            {
                if (visorTexto[i] == '(' || visorTexto[i] == ')' || visorTexto[i] == '=' || visorTexto[i] == '+' || visorTexto[i] == '-' || visorTexto[i] == '*' || visorTexto[i] == '/')
                {
                    string elemento = "";
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (visorTexto[j] == '(' || visorTexto[j] == ')' || visorTexto[j] == '+' || visorTexto[j] == '-' || visorTexto[j] == '*' || visorTexto[j] == '/')
                        {
                            break;
                        }
                        else
                        {
                            elemento += visorTexto[j];
                        }
                    }
                    string elementoFinal = "";
                    for (int k = elemento.Count() - 1; k >= 0; k--) {
                        elementoFinal += elemento[k];
                    }
                    conta.Add(elementoFinal);
                    conta.Add(Convert.ToString(visorTexto[i]));
                }
            }

            



            //Lista "conta" contém em cada posição números e operações da conta em questão

            for (int i = 0; i < conta.Count; i++)
            {
                if (conta[i] == "+" || conta[i] == "-")
                {
                    int j;
                    for (j = i + 1; j < conta.Count; j++)
                    {
                        if (conta[j] != "")
                        {
                            break;
                        }
                    }
                    int achou = 0;
                    for (int k = i - 1; k >=0; k--)
                    {
                        if (conta[k] != "")
                        {
                            achou++;
                        }
                    }
                    if (achou == 0 && conta[j] == "(")
                    {
                        conta[i - 1] = "0";
                    }
                }

                
            }














            while (conta.Contains(""))
            {
                conta.Remove("");
            }

          


            if (conta[0] == "-")
            {
                if (conta[1] != "+" && conta[1] != "-" && conta[1] != "*" && conta[1] != "/" && conta[1] != "(" && conta[1] != ")") {
                    conta[1] = "-" + conta[1];
                    conta.RemoveAt(0);
                }
                
            }

            if (conta[0] == "+")
            {
                if (conta[1] != "+" && conta[1] != "-" && conta[1] != "*" && conta[1] != "/" && conta[1] != "(" && conta[1] != ")")
                {
                    conta[1] = "+" + conta[1];
                    conta.RemoveAt(0);
                }
            }

            for (int i = 0; i < conta.Count; i++)
            {
                if (conta[i] == "-")
                {
                    if (conta[i - 1] == "*" || conta[i - 1] == "/" || conta[i - 1] == "(")
                    {
                        if (conta[i+1] != "+" && conta[i + 1] != "-" && conta[i + 1] != "*" && conta[i + 1] != "/" && conta[i + 1] != "(" && conta[i + 1] != ")" ) {
                            conta[i + 1] = "-" + conta[i + 1];
                            conta.RemoveAt(i);
                        }
                    }
                }
                if (conta[i] == "+")
                {
                    if (conta[i - 1] == "*" || conta[i - 1] == "/" || conta[i - 1] == "(")
                    {
                        if (conta[i + 1] != "+" && conta[i + 1] != "-" && conta[i + 1] != "*" && conta[i + 1] != "/" && conta[i + 1] != "(" && conta[i + 1] != ")")
                        {
                            conta[i + 1] = "+" + conta[i + 1];
                            conta.RemoveAt(i);
                        }
                    }
                }
            }


















            


            //Resolvendo a conta -> Parênteses

            while (conta.Contains("("))
            {
                int k;
                for (k=conta.LastIndexOf("(");k<conta.Count;k++)
                {
                    if (conta[k] ==  ")") 
                    {
                        break;
                    }
                }
                
           


                ResolveOp(conta.LastIndexOf("(") + 1, k, conta, "*", "/");


                int k2;
                for (k2 = conta.LastIndexOf("("); k2 < conta.Count; k2++)
                {
                    if (conta[k2] == ")")
                    {
                        break;
                    }
                }


                ResolveOp(conta.LastIndexOf("(") + 1, k2, conta, "+", "-");



                int m;
                int pos = conta.LastIndexOf("(");
                for (m = pos; m < conta.Count; m++)
                {
                    if (conta[m] == ")")
                    {
                        break;
                    }
                }
                

                if (pos>0 && conta[pos-1] == "-")
                {
                    if (conta[pos+1][0] == '-') {
                        conta[pos+1] = conta[pos + 1].Replace('-', '+');
                    }
                    else
                    {
                        conta[pos+1] = conta[pos + 1].Replace('+', '-');

                    }
                    conta[pos-1] = "+";
                }

                conta.RemoveAt(m);
                conta.RemoveAt(pos);

               


            }
















            


            //Resolvendo a conta -> Multiplicações/Divisões
            ResolveOp(0,conta.Count,conta,"*","/");




            

            //Resolvendo a conta -> Somas/substrações
            ResolveOp(0, conta.Count,conta, "+", "-");
            



















            //Definições finais

            conta.RemoveAt(1);

            if (conta[0][0] == '+')
            {
                resultado.Text = conta[0].Substring(1);
            }
            else
            {
                resultado.Text = conta[0];
            }




            resultado.Visible = true;
            if (resultado.Text[0] == '-')
            {
                resultado.ForeColor = Color.Red;
            }
            else {
                resultado.ForeColor = Color.Green;
            }

            if (resultado.Text == "NaN" || resultado.Text == "∞")
            {
                resultado.ForeColor = Color.Black;
            }

            if (resultado.Text == "0") {
                resultado.ForeColor = Color.Black;
            }
            
































        }

        private void ResolveOp(int posInicio,int posFim,List<string> conta, string op1,string op2)
        {
            

            for (int indice = posInicio; indice < posFim; indice++)
            {
                if (conta[indice] == op1 || conta[indice] == op2)
                {

                    double elemento1 = 0;
                    double elemento2 = 0;

                    int k;
                    for (k = indice - 1; k >= 0; k--)
                    {
                        if (conta[k] != "+" && conta[k] != "-" && conta[k] != "*" && conta[k] != "/" && conta[k] != "$" && conta[k] != "(" && conta[k] != ")" )
                        {
                            
                            elemento1 = double.Parse(conta[k]);
                            break;
                        }
                    }

                    int k2;
                    for (k2 = indice + 1; k2 <conta.Count; k2++)
                    {
                        if (conta[k2] != "+" && conta[k2] != "-" && conta[k2] != "*" && conta[k2] != "/" && conta[k2] != "$" && conta[k2] != "(" && conta[k2] != ")" )
                        {

                            elemento2 = double.Parse(conta[k2]);
                            break;
                        }
                    }


                    double r;

                    if (op1 == "*")
                    {

                        if (conta[indice] == op1)
                        {
                            r = elemento1 * elemento2;
                        }
                        else
                        {
                            r = elemento1 / elemento2;

                        }

                    }
                    else
                    {

                        if (conta[indice] == op1)
                        {
                            r = elemento1 + elemento2;
                        }
                        else
                        {
                            r = elemento1 - elemento2;

                        }

                    }




                    conta[indice + 1] = "$";
                    conta[indice] = "$";



                    if (r>0) {
                        conta[k] = '+' + Convert.ToString(r);
                    }
                    else
                    {
                        conta[k] = Convert.ToString(r);
                    }
                    

                    

                }

                

            }
            while (conta.Contains("$"))
            {
                conta.RemoveAt(conta.IndexOf("$"));
            }

        }


        private void botaoApagar_Click(object sender, EventArgs e)
        {
            int ultimaPos = visor.Text.Count() - 1;
            if (ultimaPos>-1) {
                visor.Text = visor.Text.Remove(ultimaPos);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void botaoReset_Click(object sender, EventArgs e)
        {
            visor.Text = "";
            resultado.Visible=false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int abreP = 0, fechaP=0;
            for (int i = 0;i < visor.Text.Length;i++)
            {
                if (visor.Text[i] == '(')
                {
                    abreP++;
                }
                if (visor.Text[i] == ')')
                {
                    fechaP++;
                }
            }

            if(!(fechaP+1<= abreP))
            {
                return;
            }

            if (visor.Text.Contains('(')) {
                visor.Text += ')';
            }
        }

        private void abreParentese_Click(object sender, EventArgs e)
        {
            int ultimaPos = visor.Text.Count() - 1;

            if (ultimaPos == -1)
            {
                visor.Text += '(';
                return;
            }

            if (visor.Text[ultimaPos] == '+' || visor.Text[ultimaPos] == '-' || visor.Text[ultimaPos] == '*' || visor.Text[ultimaPos] == '/')
            {
                visor.Text += '(';
            }
        }
    }
}