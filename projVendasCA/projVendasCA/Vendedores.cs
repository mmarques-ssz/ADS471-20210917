using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projVendasCA
{
    class Vendedores
    {
        private Vendedor[] osVendedores;
        private int max;
        private int qtde;

        public Vendedor[] OsVendedores
        {
            get { return osVendedores; }
        }

        public int Max
        {
            get { return max; }
        }

        public int Qtde
        {
            get { return qtde; }
        }

        public Vendedores(int max)
        {
            this.max = max;
            this.qtde = 0;
            this.osVendedores = new Vendedor[this.max];
            for (int i = 0; i < this.max; i++)
                this.osVendedores[i] = new Vendedor(0, "", 0.00);
        }

        public double valorVendas()
        {
            double totalVendas = 0;
            foreach (Vendedor v in this.osVendedores)
                totalVendas += v.valorVendas();
            return totalVendas;
        }

        public double valorComissao()
        {
            double totalComissoes = 0;
            foreach (Vendedor v in this.osVendedores)
                totalComissoes += v.valorComissao();
            return totalComissoes;
        }

        public bool addVendedor(Vendedor vendedor)
        {
            bool podeAdd = (this.qtde < this.max);
            if (podeAdd)
            {
                this.osVendedores[this.qtde] = vendedor;
                this.qtde++;
            }
            return podeAdd;
        }

        public bool delVendedor(Vendedor vendedor)
        {
            bool temVendedor = false;
            foreach (Vendedor v in this.osVendedores)
            {
                if (v.Equals(vendedor))
                {
                    v.Id = 0;
                    v.Nome = "";
                    v.PercComissao = 0.00;
                    temVendedor = true;
                }
            }
            return temVendedor;
        }

        public Vendedor searchVendedor(Vendedor vendendor)
        {
            Vendedor vendedorAchado = new Vendedor();
            int i = 0;
            while (i < this.max && !this.osVendedores[i].Equals(vendendor))
            {
                i++;
            }
            if (i < this.max)
            {
                vendedorAchado = this.osVendedores[i];
            }
            return vendedorAchado;
        }

        public override string ToString()
        {
            string dados = "";
            foreach (Vendedor v in this.osVendedores)
                dados += v.ToString();
            dados += "------------------";
            return dados;
        }

    }
}
