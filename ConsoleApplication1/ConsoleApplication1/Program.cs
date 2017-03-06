using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1");
            TextReader reader = new StreamReader("nomes_telefones.txt");
            int a;
            String linha = reader.ReadLine();
            while (linha != null)
            {
                linha = linha.Replace('(', ' ');
                linha = linha.Replace(')', ' ');
                linha = linha.Replace('-', ' ');               
                Console.WriteLine(linha);
             linha = reader.ReadLine();
            }
            Console.WriteLine("2");
            reader = new StreamReader("nomes_telefones.txt");
            linha = reader.ReadLine();
            while (linha != null)
            {
                a = linha.IndexOf('(');
                linha = linha.Remove(a,14);
                if(linha.Count()-1>12)
                {
                    linha = linha.ToUpper();
                    Console.WriteLine(linha);
                }                
                linha = reader.ReadLine();
            }
            Console.WriteLine("3");
            reader = new StreamReader("datas.txt");
            linha = reader.ReadLine();
            while (linha != null)
            {
                a = linha.IndexOf('/');
                linha = linha.Remove(0,a+1);
                a = linha.IndexOf('/');
                linha = linha.Remove(0, a+1);
                Console.WriteLine(linha);
                linha = reader.ReadLine();
            }
            Console.WriteLine("4");
            reader = new StreamReader("marcas_carros.txt");
            linha = reader.ReadLine();
            while (linha != null)
            {
                a = linha.IndexOf('@');
                int l = linha.Length;
                linha = linha.Remove(a, l-a);
                Console.WriteLine(linha);
                linha = reader.ReadLine();
            }
            Console.WriteLine("5");
            reader = new StreamReader("produtos_estoque.txt");
            linha = reader.ReadLine();
            int c;
            float d, e = 0;
            int b = 0;
            while (linha != null)
            {
                c = int.Parse(linha.Substring(linha.IndexOf('|') + 1));
                b += c;
                linha = linha.Remove(linha.IndexOf('|'));
                d = float.Parse(linha.Substring(linha.IndexOf('$') + 1));
                linha = linha.Remove(linha.IndexOf('$'));
                e += d * c;
                linha = reader.ReadLine();
            }
            Console.WriteLine("Numero de produtos: " + b.ToString() + "\nValor dos produtos: $" + e.ToString());

            Console.ReadKey();
        }
    }
}
