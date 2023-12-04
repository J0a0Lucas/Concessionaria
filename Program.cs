// Aluno: João Lucas Pereira de Morais.
// Aluno:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATVSistemaDeConcessionaria
{
    class Veiculo
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public int Ano { get; set; }
        public int NumeroPortas { get; set; }
        public int Preco { get; set; }
        public string TipoCombustivel { get; set; }

        public virtual void MostrarDetalhes()
        {
            Console.WriteLine("Detalhes do veículo:");
            Console.WriteLine("");
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Cor: " + Cor);
            Console.WriteLine("Ano: " + Ano);
            Console.WriteLine("Número de portas: " + NumeroPortas);
            Console.WriteLine("Preço R$ " + Preco);
            Console.WriteLine("Tipo de combustível: " + TipoCombustivel);
        }
    }

    class Carro : Veiculo
    {
        public override void MostrarDetalhes()
        {
            Console.WriteLine("--- Carro ---");
            base.MostrarDetalhes();
            Console.WriteLine();
        }
    }

    class Moto : Veiculo
    {
        public override void MostrarDetalhes()
        {
            Console.WriteLine("--- Moto ---");
            base.MostrarDetalhes();
            Console.WriteLine();
        }
    }

    class Concessionaria
    {
        static void Main()
        {
            Carro carro1 = new Carro()
            {
                Nome = "Fusca",
                Marca = "Volkswagen",
                Cor = "Preto",
                Ano = 2003,
                NumeroPortas = 2,
                Preco = 3500,
                TipoCombustivel = "Gasolina"
            };

            Carro carro2 = new Carro()
            {
                Nome = "Fiesta",
                Marca = "Ford",
                Cor = "Prata",
                Ano = 2020,
                NumeroPortas = 4,
                Preco = 52690,
                TipoCombustivel = "Gasolina/Álcool"
            };

            Carro carro3 = new Carro()
            {
                Nome = "Siena",
                Marca = "Fiat",
                Cor = "Branco",
                Ano = 2004,
                NumeroPortas = 4,
                Preco = 14204,
                TipoCombustivel = "Álcool, Gás Natural e Gasolina"
            };

            Carro carro4 = new Carro()
            {
                Nome = "Uno",
                Marca = "Fiat",
                Cor = "Preto",
                Ano = 2021,
                NumeroPortas = 4,
                Preco = 84990,
                TipoCombustivel = "Etanol"
            };

            Carro carro5 = new Carro()
            {
                Nome = "Panamera",
                Marca = "Porsche",
                Cor = "Preta",
                Ano = 2023,
                NumeroPortas = 4,
                Preco = 680000,
                TipoCombustivel = "Eletricidade"
            };

            Carro carro6 = new Carro()
            {
                Nome = "Renegade",
                Marca = "Jeep",
                Cor = "Prata",
                Ano = 2015,
                NumeroPortas = 4,
                Preco = 125990,
                TipoCombustivel = "Álcool"
            };

            Carro carro7 = new Carro()
            {
                Nome = "Compass",
                Marca = "Jeep",
                Cor = "Branco",
                Ano = 2016,
                NumeroPortas = 4,
                Preco = 180390,
                TipoCombustivel = "Gasolina Tipo C"
            };

            Carro carro8 = new Carro()
            {
                Nome = "X4",
                Marca = "BMW",
                Cor = "Roxa",
                Ano = 2017,
                NumeroPortas = 4,
                Preco = 475950,
                TipoCombustivel = "Gasolina TwinPower"
            };

            Carro carro9 = new Carro()
            {
                Nome = "X3",
                Marca = "BMW",
                Cor = "Vinho",
                Ano = 2015,
                NumeroPortas = 4,
                Preco = 410950,
                TipoCombustivel = "Gasolina TwinPower"
            };

            Carro carro10 = new Carro()
            {
                Nome = "X1",
                Marca = "BMW",
                Cor = "Vermelho",
                Ano = 2014,
                NumeroPortas = 4,
                Preco = 299950,
                TipoCombustivel = "Gasolina TwinPower"
            };



            Moto moto1 = new Moto()
            {
                Nome = "CB300",
                Marca = "Honda",
                Cor = "Vermelho",
                Ano = 2020,
                NumeroPortas = 0,
                Preco = 52590,
                TipoCombustivel = "Gasolina"
            };

            Console.WriteLine("Olá seja bem-vindo(a)! Nossa concessionária Alta Racing!");
            Console.WriteLine("");
            Console.WriteLine("Opções de veículos disponíveis:");
            Console.WriteLine("");
            Console.WriteLine("1. Fusca - Volkswagen");
            Console.WriteLine("2. Fiesta - Ford");
            Console.WriteLine("3. CB300 - Honda");
            Console.WriteLine("4. Siena - Fiat");
            Console.WriteLine("5. Uno - Fiat");
            Console.WriteLine("6. Panamera - Porsche");
            Console.WriteLine("7. Renegade - Jeep");
            Console.WriteLine("8. Compass - Jeep");
            Console.WriteLine("9. X4 - BMW");
            Console.WriteLine("10. X3 - BMW");
            Console.WriteLine("11. X1 - BMW");
            Console.WriteLine();

            Console.Write("Digite o número do veículo desejado: ");
            int opcao = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite seu nome: ");
            string nomeComprador = Console.ReadLine();
            Console.WriteLine();

            Veiculo veiculoEscolhido = null;
            switch (opcao)
            {
                case 1:
                    veiculoEscolhido = carro1;
                    break;
                case 2:
                    veiculoEscolhido = carro2;
                    break;
                case 3:
                    veiculoEscolhido = moto1;
                    break;
                case 4:
                    veiculoEscolhido = carro3;
                    break;
                case 5:
                    veiculoEscolhido = carro4;
                    break;
                case 6:
                    veiculoEscolhido = carro5;
                    break;
                case 7:
                    veiculoEscolhido = carro6;
                    break;
                case 8:
                    veiculoEscolhido = carro7;
                    break;
                case 9:
                    veiculoEscolhido = carro8;
                    break;
                case 10:
                    veiculoEscolhido = carro9;
                    break;
                case 11:
                    veiculoEscolhido = carro10;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    return;
            }

            Console.WriteLine("Veículo escolhido por " + nomeComprador + ":");
            veiculoEscolhido.MostrarDetalhes();

            // Aqui vou por as formas de pagamentos.


            Console.ReadLine();
            Console.WriteLine("Parabéns pela compra!");
            Console.Write("Sr(a) " + nomeComprador + " Poderia está dando um feedback para o nosso atendimento? Nota: ");
            Console.ReadLine();
            Console.WriteLine("Muito obrigado(a) " + nomeComprador + " O seu feedback é muito importante.");
            Console.WriteLine("Volte sempre à Alta Racing!");
            Console.ReadLine();
        }
    }
}
