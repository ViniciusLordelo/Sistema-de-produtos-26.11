using System;

namespace Sistema_de_produtos_26._11
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] nomes = new string[1];

            Console.Clear();
            //criar menu
            int escolha;
            int contador = 0;


            do
            {

                Console.WriteLine("Menu inicial");
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("[1] - Cadastrar produto");
                Console.WriteLine("[2] - Listar produto");
                Console.WriteLine("[0] - Sair");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {

                    case 1:
                        //Cadastrar Passagem
                        string resposta;



                        do
                        {
                            if (contador < 10)
                            {
                                Console.WriteLine("Digite o nome do produto: ");
                                string produto = Console.ReadLine();

                                Console.WriteLine("Digite a quantidade do produto: ");
                                int quantidade = int.Parse(Console.ReadLine());

                                Console.WriteLine("Digite o preço: ");
                                float preco = float.Parse(Console.ReadLine());
                                TotalAPagar(quantidade, preco);

                                TotalAPagar(quantidade, preco);

                                float TotalAPagar(int quantidade, float preco)
                                {

                                    float total = quantidade * preco;
                                    float desconto;
                                    if (quantidade <= 5)
                                    {
                                        desconto = 0.02f;
                                    }
                                    else if (quantidade <= 10)
                                    {
                                        desconto = 0.03f;
                                    }
                                    else
                                    {
                                        desconto = 0.05f;
                                    }

                                    float valorDoDesconto = total * desconto;
                                    float totalComDesconto = total - desconto;

                                    Console.WriteLine($"O valor total é de:{total}");

                                    Console.WriteLine($"Você terá R${valorDoDesconto} de desconto");

                                    Console.WriteLine($"Sua compra com desconto fica R${totalComDesconto}");

                                    return totalComDesconto;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Limite excedido de produtos");
                                break;
                            }



                            Console.WriteLine("Gostaria de cadastrar um novo produto?  s/n");
                            resposta = Console.ReadLine();
                        } while (resposta == "s");



                        break;
                    case 2:
                        //Listar Produtos
                        for (var i = 0; i < 10; i++)
                        {
                            Console.WriteLine($"O {nomes[i]} está listado");
                        }
                        break;
                    case 0:
                        //sair
                        Console.WriteLine("Obrigado! Volte sempre!");


                        break;
                    default:
                        Console.WriteLine("Opção invalida!");
                        break;

                }


            } while (escolha != 0); // se a escolha for diferente de 0, ele repete





        }
    }
}
