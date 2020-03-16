using System;
using System.IO;
using System.Collections.Generic;

namespace InterfaceComparativa {
    class Program {
        static void Main(string[] args) {
            //mapeando o caminho do arquivo
            string path = @"c:\temp\in.txt";
            //bloco try/catch
            try {
                //abrir o arquivo usando o StreamReader
                using (StreamReader sr = File.OpenText(path)) {
                    //instanciando uma lista do tipo string
                    List<string> list = new List<string>();
                    //enquanto (!sr.EndOfStream) for diferente do fim, 
                    while (!sr.EndOfStream) {
                        //chama a lista e coloca dentro do add, tudo que 
                        //ler dentro desse arquivo.
                        list.Add(sr.ReadLine());
                    }
                    //ordena a lista em ordem alfabetica!
                    list.Sort();
                    //para cada string na minha lista
                    foreach (string str in list) {
                        //vai imprimir na tela
                        Console.WriteLine(str);
                    }
                }
            }
            catch(IOException e) {
                Console.WriteLine("Um Erro Ocorreu");
                Console.WriteLine(e.Message);
            }
        }
    }
}
