using System;
using GFTEtapaTecnica.Teste01.src.Entities;
using GFTEtapaTecnica.Teste02;
using GFTEtapaTecnica.Teste04;

namespace GFTEtapaTecnica
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Teste 01
            Pessoa pessoa = new Pessoa("Carlos", "28/02/83", 1,83);
            pessoa.imprimirDados();

            // Teste 02
            /* TurnoDeTrabalho turno = new TurnoDeTrabalho();
            turno.turnoDeTrabalho(); */

            // Teste 04
            /* DoarSangue idadePermitida = new DoarSangue();
            idadePermitida.DoacaoSangue(); */       


        }
    }
}