// See https://aka.ms/new-console-template for mais informação
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Hello, World!");
class Program
{
	static void Main()
	{
		//exercicio1.  Leitura da quantidade de maçãs compradas
		Console.Write("Digite o número de maçãs compradas: ");
		int quantidadeMacas = int.Parse(Console.ReadLine());


		// Definição do preço com base na quantidade de maçãs
		double preco;
		if (quantidadeMacas < 12)
		{
			preco = 1.30;
		}
		else
		{
			preco = 1.00;
		}

		// Cálculo do custo total
		double custoTotal = quantidadeMacas * preco;

		// Exibição do custo total
		Console.WriteLine("O custo total da compra é:" + custoTotal);
	}



	static void Main2()
	{
		//Exercicio2. 
		Console.Write("Digite primeiro numero: ");
		int num1 = int.Parse(Console.ReadLine());
		Console.Write("Digite segundo numero: ");
		int num2 = int.Parse(Console.ReadLine());
		Console.Write("Digite terceiro numero: ");
		int num3 = int.Parse(Console.ReadLine());


		// Definição do valro com base nos três numeros 
		int primeiromaior, segundomaior, terceiromaior;

		if (num1 >= num2 && num1 >= num3)
		{
			primeiromaior = num1;
			if (num2 >= num3)
			{
				segundomaior = num2;
				terceiromaior = num3;
			}
			else
			{
				segundomaior = num3;
				terceiromaior = num2;
			}
		}
		else if (num2 >= num1 && num2 >= num3)
		{
			primeiromaior = num2;
			if (num1 >= num3)
			{
				segundomaior = num1;
				terceiromaior = num3;
			}
			else
			{
				segundomaior = num3;
				terceiromaior = num1;
			}
		}
		else
		{
			primeiromaior = num3;
			if (num1 >= num2)
			{
				segundomaior = num1;
				terceiromaior = num2;
			}
			else
			{
				segundomaior = num2;
				terceiromaior = num1;
			}
		}

		// Exibição do custo total
		Console.WriteLine("O numero maior é:" + primeiromaior);
		Console.WriteLine("O segundo numero maior é:" + segundomaior);
		Console.WriteLine("O terceiro maior é:" + terceiromaior);
	}


	static void Main3()
	{
		//Exercicio3
		int salario, totaldeVendas;
		Console.Write("Informe o salario do vendedor: R$");
		salario = int.Parse(Console.ReadLine());
		Console.Write("Informe o total de vendas do vendedor: R$");
		totaldeVendas = int.Parse(Console.ReadLine());

		//Processamento e saida
		Console.Write("O valor a ser pago para o vendedor é: R$" +
			(salario + ((totaldeVendas > 1500) ? 1500 * 03 +
			(totaldeVendas - 1500) * 0.05 : totaldeVendas * 0.03));
	}


	//Exercicio4
	static void Main4()
	{
		int ano;

		Console.Write("Informe o ano: ");
		ano = int.Parse(Console.ReadLine());

		//processamento e saida
		if(
		    (ano % 4 == 0 && ano %100 !=0)
		    ||
		    (ano % 400 == 0)
		  )
		{
		    Console.WriteLine("É bissexto!");
		}
		else
		{
		    Console.WriteLine("NÃO é bissexto!");
		}

	}

	//exercicio5
	static void Main5()
	{
		double entrada;
		int diaSemana;
		string musicaAoVivo;

		Console.Write("Informe o valor normal de entrada: R$");
		entrada = double.Parse(Console.ReadLine());
		Console.Write("Informe o numero correspondente ao dia da semana:" +
		    "\n1-DOMINGO" +
		    "\n2-SEGUNDA" +
		    "\n3-TERÇA" +
		    "\n4-QUARTA" +
		    "\n5-QUINTA" +
		    "\n6-SEXTA" +
		    "\n7-SABADO" +    
		    "\nInforme o numero: ");
		diaSemana = int.Parse(Console.ReadLine());
		Console.Write("Terá musica ao vivo (S/N): ");
		musicaAoVivo = Console.ReadLine();

		//processamento
		if (diaSemana == 2 || diaSemana == 3 || diaSemana == 5)
		    entrada -= 10; // entrada = entrada - 10
		if (musicaAoVivo.ToUpper() == "S")
		    entrada += 7.5;

		//saida
		Console.WriteLine("O valor da entrada será de: R$" + entrada);




		//Exercicio6
		Console.Write("Digite primeiro numero: ");
		int num1 = int.Parse(Console.ReadLine());
		Console.Write("Digite segundo numero: ");
		int num2 = int.Parse(Console.ReadLine());
		Console.Write("Digite terceiro numero: ");
		int num3 = int.Parse(Console.ReadLine());

		//processamento e saida 
		if ((num1 < num2 + num3) &&
		    (num3 < num1 + num2) && (num2 < num1 + num3))
		{
		    //que tipo de triangulo ele forma?
		    if(num1 == num2 && num3 == num1)
		    {
		        Console.WriteLine("Triangulo EQUILATERO!");
		    }
		    else
		    {
		        if(num1 == num2 || num1 == num3 || num2 == num3)
		        {
		            Console.WriteLine("Triangulo ISOSCELES!");
		        }
		        else
		        {
		            Console.WriteLine("Triangulo ESCALENO!");
		        }
		    }
		}
		else
		{
		    Console.WriteLine("Não formam um triangulo!");
		}


		//exercicio7
		//entradas
		int num1, num2, num3;

		Console.Write("informe o primeiro numero: ");
		num1 = int.Parse(Console.ReadLine());
		Console.Write("informe o segundo numero: ");
		num2 = int.Parse(Console.ReadLine());
		Console.Write("informe o terceiro numero: ");
		num3 = int.Parse(Console.ReadLine());

		if (num1 % 2 == 0 && num1 > 10)
		{
			if (num2 % 2 != 0 && num2 < num1)
			{
				if (num3 == num1 + num2 && num3 % 5 != 0)
				{
					Console.WriteLine("Bau aberto! Parabéns!");
				}
				else
				{
					Console.WriteLine("O terceiro numero precisa ser a soma dos dois primeiros e não pode ser multiplo de 5!");
				}
			}
			else
			{
				Console.WriteLine("O segundo numero precisa ser impar e menor que o primeiro!");
			}
		}
		else
		{
			Console.WriteLine("O primeiro numero precisa ser par e maior que 10!");
		}
	}
	
