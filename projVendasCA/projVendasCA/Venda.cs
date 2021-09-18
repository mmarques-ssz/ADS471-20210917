using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projVendasCA
{
    class Venda
    {
        private int qtde;
        private double valor;

        public int Qtde
        {
            get { return qtde; }
            set { qtde = value; }
        }

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public Venda(int qtde, double valor)
        {
            this.qtde = qtde;
            this.valor = valor;
        }

        public Venda()
            : this(0, 0.00)
        { }

        public double valorMedio()
        {
            return (this.valor == 0 ? 0 : this.valor / this.qtde);
        }

    }
}
