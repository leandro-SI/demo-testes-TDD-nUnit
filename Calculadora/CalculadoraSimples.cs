﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class CalculadoraSimples
    {
        // Método para Adicionar 2 números
        public int Adicionar(int num1, int num2)
        {
            return num1 + num2;
        }

        // Método para Multiplicar 2 números
        public int Multiplicar(int num1, int num2)
        {
            //Para fins de demo (bug) => return num1 * num2
            return num1 * num2;
        }
    }
}
