﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Validação_do_CPF
{
    class CPF
    {
        public static bool isCpf(string cpf)
        {

            int[] mult1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] mult2 = new int[10] {11, 10, 9, 8, 7, 6, 5, 4, 3, 2};

            string tempoCpf;
            string digito;
            
            int soma;
            int resto;
             
            if(cpf.Length != 11)
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            tempoCpf = cpf.Substring(0, 9);

            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempoCpf[i].ToString()) * mult1[i];
            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
                tempoCpf = tempoCpf + digito;


            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempoCpf[i].ToString()) * mult2[i];
            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);




        }

    }
}
