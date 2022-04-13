using System;
using System.Collections.Generic;
using FinalProject.Source;

namespace FinalProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            CadastrarProdutos();
        }

        private static void CadastrarProdutos()
        {
            Tecnologia monitor = new Tecnologia("Monitor", 2000.0f, 5.0f, "Asus", TipoProduto.TECNOLOGIA);
            Tecnologia iphone15 = new Tecnologia("Iphone15", 9999999.0f, 2.0f, "Apple", TipoProduto.TECNOLOGIA);

            Limpeza fralda = new Limpeza("Fralda", 100.0f, 1.0f, "Harpa", TipoProduto.LIMPEZA);
            Limpeza sabaoEmPo = new Limpeza("Sabão em pó", 50.0f, 1.0f, "Omo", TipoProduto.LIMPEZA);

            Alimento pao = new Alimento("Pão", 10.0f, 1.0f, "Pão de queijo", TipoProduto.ALIMENTO, "12/2022");
            Alimento chocolate = new Alimento("Chocolate", 5.0f, 0.5f, "Nestle", TipoProduto.ALIMENTO, "12/2022");

            List<Produto> produtosList = new List<Produto>();
            produtosList.Add(monitor);
            produtosList.Add(iphone15);
            
            produtosList.Add(fralda);
            produtosList.Add(sabaoEmPo);

            produtosList.Add(pao);
            produtosList.Add(chocolate);

            List<Tecnologia> tecnologiaList = new List<Tecnologia>();
            List<Limpeza> limpezaList = new List<Limpeza>();
            List<Alimento> alimentoList = new List<Alimento>();

            foreach (Produto produto in produtosList)
            {
                switch (produto.TipoProduto)
                {
                    case TipoProduto.ALIMENTO:
                        alimentoList.Add((Alimento) produto);
                        break;

                    case TipoProduto.LIMPEZA:
                        limpezaList.Add((Limpeza) produto);
                        break;

                    case TipoProduto.TECNOLOGIA:
                        tecnologiaList.Add((Tecnologia) produto);
                        break;
                }
            }

            Console.WriteLine("--- Lista de Produtos Alimentos Cadastrados: ---");
            foreach (Alimento alimento in alimentoList)
            {
                alimento.DescreverProduto();
            }

            Console.WriteLine("--- Lista de Produtos Limpeza Cadastrados: ---");
            foreach (Limpeza limpeza in limpezaList)
            {
                limpeza.DescreverProduto();
            }
            
            Console.WriteLine("--- Lista de Produtos Tecnologia Cadastrados: ---");
            foreach (Tecnologia tecnologia in tecnologiaList)
            {
                tecnologia.DescreverProduto();
            }
        }

    }
}
