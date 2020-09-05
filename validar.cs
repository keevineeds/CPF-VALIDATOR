using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ValidadorCPF
{
    class validar
    {
        //atributos
        public
            string cpf;

        //construtor
        public validar(string c)
        {
            cpf = c;
        }

        //getter e setter
        public void setCPF(string c)
        {
            cpf = c;
        }
        public string getCPF()
        {
            return cpf;
        }

        //método
        public bool ValidarCPF()
        {
            int mult = 10;
            cpf = cpf.Replace("-", "");
            int soma1 = 0;
            for (int i = 0; i <= 8; i++)
            {
                int digito = Convert.ToInt32(cpf[i].ToString());
                soma1 += digito * mult;
                mult--;
            }
            int f1 = (soma1 * 10) % 11;
            int dv1 = Convert.ToInt32(cpf[9].ToString());

            mult = 11;
            int soma2 = 0;
            for (int i = 0; i <= 9; i++)
            {
                int digito = Convert.ToInt32(cpf[i].ToString());
                soma2 += digito * mult;
                mult--;
            }
            int f2 = (soma2 * 10) % 11;
            int dv2 = Convert.ToInt32(cpf[10].ToString());

            if ((f1 == dv1) && (f2 == dv2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

