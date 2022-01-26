using System.Text;

var sb = new StringBuilder();
sb.AppendLine("inicio de arquivo");
sb.AppendLine("Projeto de exemplo StringReader");
sb.AppendLine("fim de arquivo");

using var sr = new StringReader( sb.ToString() );
var buffer = new char[10];
var tamanho = 0;

// Ler arquivo com ReadLine, indicado para arquivos pequenos
do{

    Console.Write(sr.ReadLine());

} while ( sr.Peek() >= 0);


// Ler arquivo com Buffer, indicado para texto grandes
// evitar consumo alto de memória
do{

    buffer = new char[10];
    tamanho = sr.Read(buffer);
    Console.Write(string.Join("", buffer));

} while (tamanho >= buffer.Length);


Console.ReadLine();
Console.WriteLine();


string texto = "A mineração de processos é uma área de pesquisa relativamente nova e está " +
               "relacionada a aprendizagem de máquina e mineração de dados. A ideia básica " +
               "da Mineração de Processos é descobrir, monitorar e melhorar processos reais, " +
               "extraindo conhecimentos de logs de eventos disponíveis em diversos sistemas de informação.";

Console.WriteLine($"Texto original: {texto}");

var srr = new StringReader(texto);

string linha, paragrafo = null;

while ( true )
{

    linha = srr.ReadLine();
    if ( linha != null)
    {
        paragrafo += linha + " ";
    }
    else{
        paragrafo += '\n';
        break;
    }

}

Console.WriteLine($"Texto modificado: {paragrafo}");

int caractereLido;
char caracterConvertido;

var sw = new StringWriter();
srr = new StringReader(texto);

while ( true )
{
    caractereLido = sr.Read();

    if ( caractereLido == -1) break;

    caracterConvertido = Convert.ToChar(caractereLido);

    if ( caracterConvertido == '.' )
    {
        sw.Write("\n\n");

        sr.Read();
        sr.Read();
    }
    else
    {
        sw.WriteLine(caracterConvertido);
    }

}

Console.WriteLine($"Texto armazenado {sw.ToString()}");
Console.ReadLine();