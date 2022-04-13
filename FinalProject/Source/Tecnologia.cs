using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Source
{
    public class Tecnologia : Produto
    {

        // Construtor com parametros do produto de tecnologia.
        public Tecnologia(string nome, float preco, float peso, string fabricante, TipoProduto tipoProduto = TipoProduto.ALIMENTO)
        {
            Nome = nome;
            Preco = preco;
            Peso = peso;
            Fabricante = fabricante;

            // Verifique se o tipo de produto é válido (Tecnologia).
            if (TipoProduto != TipoProduto.TECNOLOGIA)
            {
                // Redefine o tipo do produto para tecnologia.
                tipoProduto = TipoProduto.TECNOLOGIA;
            }
            
            TipoProduto = tipoProduto;
        }

        public override void DescreverProduto()
        {
            base.DescreverProduto();
            Console.WriteLine("---------------------------------");
        }

    }
}
