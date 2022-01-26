namespace PraticaDotNet03
{
    public class Util
    {

        static void CriarArquivo1()
        {
            var path_config = Path.Combine(Environment.CurrentDirectory, "CONFIG.txt");
            var sw = File.CreateText(path_config);
            sw.WriteLine("CONFIG");
            sw.WriteLine("Versão_BD");
            sw.WriteLine("Versão_App");
            sw.WriteLine("Versão_Schemas");
            sw.Flush();
        }

        // Criar o arquivo sem a necessidade de usar o Flush
        static void CriarArquivo2(string path) 
        {
            try
            {
                using (var swa = File.CreateText(path)) 
                {
                    swa.WriteLine("CONFIG_USING");
                    swa.WriteLine("Versão_BD");
                    swa.WriteLine("Versão_App");
                    swa.WriteLine("Versão_Schemas");
                };

            } 
            catch
            {
                Console.WriteLine("Erro na criação do arquivo!");
            }
        }

        static string LimparNome(string nome)
        {   
            // substituir caracteres inválidos
            foreach (var @char in Path.GetInvalidFileNameChars())
            {
                nome = nome.Replace(@char, '-');
            }

            return nome;
        }

        static void CriarPasta(string pasta) 
        {
            var folder = Path.Combine(Environment.CurrentDirectory, $"{pasta}");
            if ( !Directory.Exists(folder) ) {
                var diretorio = Directory.CreateDirectory(folder);

                var subDiretorio = diretorio.CreateSubdirectory("Teste_N1");
                var subPasta = subDiretorio.CreateSubdirectory("Teste_N2");
            }   
        }

        static void MoverArquivo(string origem, string destino)
        {
            if ( !File.Exists (origem))
            {
                Console.WriteLine("Arquivo de origem não existe!");
                return;
            }

            if ( File.Exists (destino)) 
            {
                Console.WriteLine("Arquivo já existe na pasta destino!");
                return;
            }
            
            File.Move(origem, destino);
        }

        static void CopiarArquivo(string origem, string destino)
        {
            if ( !File.Exists (origem))
            {
                Console.WriteLine("Arquivo de origem não existe!");
                return;
            }

            if ( File.Exists (destino)) 
            {
                Console.WriteLine("Arquivo já existe na pasta destino!");
                return;
            }
            
            File.Copy(origem, destino);
        }

        static void CriarArquivo(string arquivo) 
        {
            var file = Path.Combine(Environment.CurrentDirectory, $"{arquivo}");
            if ( !File.Exists(file) ) {
                try
                {
                    using var swa = File.CreateText(file);
                    swa.WriteLine("CONFIG_USING");
                    swa.WriteLine("Versão_BD");
                    swa.WriteLine("Versão_App");
                    swa.WriteLine("Versão_Schemas");
                } 
                catch
                {
                    Console.WriteLine("Erro na criação do arquivo!");
                }
            }
        }
                
                
        static void LerDiretorio(string pasta) 
        {
            if ( !Directory.Exists(pasta) ) 
            {
                var diretorios = Directory.GetDirectories(pasta, "*", SearchOption.AllDirectories);
                foreach ( var dir in diretorios )
                {
                    var dirInfo = new DirectoryInfo(dir);
                    WriteLine($"[Nome]: {dirInfo.Name}");
                    WriteLine($"[Raiz]: {dirInfo.Root}");
                    if ( dirInfo.Parent != null ) 
                        WriteLine($"[Pai]: {dirInfo.Parent.Name}");
                }
            } 
            else
            {
                WriteLine("A pasta indicada não existe!");
                return;
            }
        }

        static void LerArquivos(string pasta) 
        {
            if ( !Directory.Exists(pasta) ) 
            {
                var arquivos = Directory.GetFiles(pasta, "*", SearchOption.AllDirectories);
                foreach ( var arquivo in arquivos )
                {
                    var arquivoInfo = new FileInfo(arquivo);
                    WriteLine($"[Nome]: {arquivoInfo.Name}");
                    WriteLine($"[Tam]: {arquivoInfo.Length}");
                    WriteLine($"[Acesso]: {arquivoInfo.LastAccessTime}");
                    WriteLine($"[Acesso]: {arquivoInfo.DirectoryName}");
                }
            } 
            else
            {
                WriteLine("A pasta indicada não existe!");
                return;
            }
        }

        // var arquivo = "CONFIG";
        // CriarArquivo(arquivo);

        // Console.WriteLine("Digite o nome ds pasta a ser criada:");
        // var pasta = ReadLine();
        // CriarPasta(pasta);

        // var origem = Path.Combine(Environment.CurrentDirectory, $"{arquivo}");
        // var destino = Path.Combine(Environment.CurrentDirectory, $"{pasta}", $"{arquivo}");

        // MoverArquivo(origem, destino);

        // Console.WriteLine("Digite enter para finalizar...");
        // Console.ReadLine();

        // WriteLine("Digite o nome ds pasta a ser lida:");
        // var pasta = ReadLine();
        // var diretorio = Path.Combine(Environment.CurrentDirectory, $"{pasta}");

        // LerDiretorio(diretorio);
        // LerArquivos(diretorio);

        // WriteLine("Digite [ENTER] para finalizar...");
        // ReadLine();
    }
}


