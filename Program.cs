using System.Globalization;
namespace FunçoesInteressantesParaString
{
    class program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ abc DEFG   ";

            //converter tudo para maiuscula usa ToUpper.

            string s1 = original.ToUpper();
            //Converter para minusculo 

            string s2 = original.ToLower();
            //apaga espaços em branco

            string s3 = original.Trim();

            // indentifica a posição
            int n1 = original.IndexOf("bc");
            //indentifica onde está a ultima ocorrencia do bc
            int n2 = original.LastIndexOf("bc");
            //corta o string
            string s4 = original.Substring(3);

            string s5 = original.Substring(3, 5);

            //substituir uma string pela outra
            string s6 = original.Replace('a', 'x');

            string s7 = original.Replace("abc", "xy");

            //verificando se e a string e nula ou vazia.
            bool b1 = String.IsNullOrEmpty(original);

            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine("Orignal: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastOf('bc'): " + n2);
            Console.WriteLine("Substring(3): " + s4 + "-");
            Console.WriteLine("Substring(3,5): " + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): " + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): " + s7 + "-");
            Console.WriteLine("IsNullOrEmpty:" + b1);
            Console.WriteLine("IsNullOrWhiteSpace:" + b2);


        }
    }
}