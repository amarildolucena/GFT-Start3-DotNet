using System;

namespace PraticaDotNet02
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indice = 0;
            string opcao = Menu();

            while (opcao.ToUpper() != "X")
            {
                switch (opcao)
                {
                    case "1":
                        //DO: Adicionar aluno
                        var aluno = new Aluno();
                        
                        Console.WriteLine("Informe o nome do aluno: ");
                        aluno.Nome = Console.ReadLine();
                        
                        Console.WriteLine("Informe a nota do aluno: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal media))
                        {
                            aluno.Media = media;
                        }
                        else
                        {
                            throw new ArgumentOutOfRangeException("Valor da média deve ser decimal!");
                        }

                        alunos[indice] = aluno;
                        indice++;

                        break;
                    case "2":
                        //DO: Listar aluno
                        foreach( var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"ALUNO: {a.Nome} - MEDIA: {a.Media}");
                            }
                        }

                        break;
                    
                    case "3":
                        //DO: Calcular média
                        decimal somaNotas = 0;
                        var numeroAlunos = 0;

                        for ( var i=0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                somaNotas = somaNotas + alunos[i].Media;
                                numeroAlunos++;
                            }
                        }

                        var mediaGeral = somaNotas / numeroAlunos;

                        Conceito conceito;

                        if (mediaGeral < 2)
                        {
                            conceito = Conceito.E;
                        } 
                        else if (mediaGeral < 4)
                        {
                            conceito = Conceito.D;                            
                        }
                        else if (mediaGeral < 6)
                        {
                            conceito = Conceito.C;                            
                        }
                        else if (mediaGeral < 8)
                        {
                            conceito = Conceito.B;                            
                        }
                        else
                        {
                            conceito = Conceito.A;                            
                        }

                        Console.WriteLine($"Média Geral: {mediaGeral} - Conceito: {conceito}");

                        break;
                    
                    default:
                        throw new ArgumentOutOfRangeException();
                        // Console.WriteLine("Opção inválida. Escolha outra opção!");                        
                }

                opcao = Menu();
            }
        }

        private static string Menu()
        {
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcaular média");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcao = Console.ReadLine();
            Console.WriteLine();

            return opcao;
        }
    }
}