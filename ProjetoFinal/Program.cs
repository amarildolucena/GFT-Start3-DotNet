﻿using ProjetoFinal.src.Entities;
using ProjetoFinal.src.Enum;

namespace ProjetoFinal
{

    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();

        static void Main(string[] args)
        {

            string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarSeries();
						break;
					case "2":
						InserirSerie();
						break;
					case "3":
						AtualizarSerie();
						break;
					case "4":
						ExcluirSerie();
						break;
					case "5":
						VisualizarSerie();
						break;
					
					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}

			Console.WriteLine("Fechando...");
			Console.ReadLine();

        }

        private static void ExcluirSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse( Console.ReadLine() );

            repositorio.Excluir(indiceSerie);
        }

        private static void VisualizarSerie()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse( Console.ReadLine() );

			var serie = repositorio.RetornarPorId(indiceSerie);

			Console.WriteLine(serie);
            Console.WriteLine();
            Console.WriteLine("Digite ENTER para continuar...");
            Console.ReadLine();
		}

        private static void AtualizarSerie()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse( Console.ReadLine() );

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}

			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse( Console.ReadLine() );

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse( Console.ReadLine() );

			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

			Series atualizaSerie = new Series(id: indiceSerie,
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Atualizar(indiceSerie, atualizaSerie);
		}

        private static void ListarSeries()
		{
			Console.WriteLine("Listar séries");

			var lista = repositorio.Listar();

			if ( lista.Count == 0 )
			{
				Console.WriteLine("Nenhuma série cadastrada.");
                Console.WriteLine();
                Console.WriteLine("Digite ENTER para continuar...");
                Console.ReadLine();
				return;
			}

			foreach (var serie in lista)
			{
                var inativo = serie.isInativo();
                
				Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (inativo ? "*Excluído*" : ""));
			}

            Console.WriteLine();
            Console.WriteLine("Digite ENTER para continuar...");
            Console.ReadLine();
		}

        private static void InserirSerie()
		{
			Console.WriteLine("Inserir nova série");

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}

			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(  Console.ReadLine() );

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse( Console.ReadLine() );

			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

			Series novaSerie = new Series(id: repositorio.ProximoId(),
										  genero: (Genero)entradaGenero,
										  titulo: entradaTitulo,
										  ano: entradaAno,
										  descricao: entradaDescricao);

			repositorio.Inserir(novaSerie);
		}

        private static string ObterOpcaoUsuario()
		{
            Console.Clear();
			Console.WriteLine();
			Console.WriteLine("Séries a seu dispor!!!");
			
			Console.WriteLine("1- Listar séries");
			Console.WriteLine("2- Inserir nova série");
			Console.WriteLine("3- Atualizar série");
			Console.WriteLine("4- Excluir série");
			Console.WriteLine("5- Visualizar série");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();
            Console.Write("Informe a opção desejada: ");
			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();

			return opcaoUsuario;
		}
            
    }

}