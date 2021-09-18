using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projVendasCA
{
    class Program
    {
        static void Main(string[] args)
        {
            Vendedor joao = new Vendedor(1, "Joao", 10);
            Vendedor jose = new Vendedor(2, "Jose", 20);
            /*
            Console.WriteLine(joao.ToString());
            Console.WriteLine(jose.ToString());
            */
            joao.registrarVenda(5, new Venda(10, 500.00));
            joao.registrarVenda(10, new Venda(8, 700.00));
            jose.registrarVenda(10, new Venda(15, 1000.00));
            /*
            Console.WriteLine(joao.ToString());
            Console.WriteLine(jose.ToString());
            
            foreach (Venda v in joao.AsVendas)
            {
                Console.WriteLine(v.valorMedio());
            }
            */

            Vendedores meusVendedores = new Vendedores(10);
            meusVendedores.addVendedor(joao);
            meusVendedores.addVendedor(jose);
            Console.WriteLine(meusVendedores.ToString());
            meusVendedores.OsVendedores[0].registrarVenda(12, new Venda(15, 500.00));
            Console.WriteLine(meusVendedores.ToString());

            Vendedor vendedorBuscado = meusVendedores.searchVendedor(new Vendedor(1, "", 0.00));
            Console.WriteLine((vendedorBuscado.Id == 0 ? "Não encontrou" : vendedorBuscado.ToString()));

            meusVendedores.delVendedor(new Vendedor(1, "", 0.00));
            Console.WriteLine(meusVendedores.ToString());

            Vendedor vendedorBuscado2 = meusVendedores.searchVendedor(new Vendedor(1, "", 0.00));
            Console.WriteLine((vendedorBuscado2.Id == 0 ? "Não encontrou" : vendedorBuscado2.ToString()));

            Console.ReadKey();

        }
    }
}
