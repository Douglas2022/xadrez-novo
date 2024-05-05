using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuleiro
{
    class tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Pecas[,] peca;

        public tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            peca = new Pecas[Linhas,Colunas];
        }
    }

 
}
