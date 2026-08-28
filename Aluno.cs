using System;
using System.Collections.Generic;
using System.Text;

namespace Abstracao
{
    internal class Aluno
    {
        public string Nome;
        public int Matricula;
        public double Nota1;
        public double Nota2;

        public Aluno(string nome, int matricula, double n1, double n2)
        {
            Nome = nome;
            Matricula = matricula;
            Nota1 = n1;
            Nota2 = n2;
        }

        public double CalcularMedia()
        {

            double Media = (Nota1 + Nota2) / 2;
            return Media;


        }





    }
}
