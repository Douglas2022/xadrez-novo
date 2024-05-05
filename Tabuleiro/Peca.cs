using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;

namespace xadez_console.Tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public int QtdMovimento { get;protected set; }
        public Cor cor { get;protected set; }
        public tabuleiro Tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, tabuleiro tab)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.Tab = tab;
            this.QtdMovimento = 0;
        }
    }
}
