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

        public void CalcularMedia()
        {
            Console.WriteLine($"Nome:{Nome}");
            Console.WriteLine($"Matricula: {Matricula}");
            Console.WriteLine($"Nota 1: {Nota1}");
            Console.WriteLine($"Nota 2: {Nota2}");
            double Media = (Nota1 + Nota2) / 2;
            Console.WriteLine($"a media das notas do aluno {Nome} é:  {Media}");

        }





    }
}
