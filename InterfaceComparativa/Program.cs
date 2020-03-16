using System;
using System.IO;
using System.Collections.Generic;
using InterfaceComparativa.Entities;

namespace InterfaceComparativa {
    class Program {
        static void Main(string[] args) {
            //mapeando o caminho do arquivo
            string path = @"c:\temp\in.csv";
            //bloco try/catch
            try {
                //abrir o arquivo usando o StreamReader
                using (StreamReader sr = File.OpenText(path)) {
                    //instanciando uma lista do tipo Funcionario
                    List<Funcionario> list = new List<Funcionario>();
                    //enquanto (!sr.EndOfStream) for diferente do fim, 
                    while (!sr.EndOfStream) {
                        //chama a lista e coloca dentro do add, para
                        //cada item da lista, ela adiciona dentro de funcionario.
                        list.Add(new Funcionario(sr.ReadLine()));
                    }
                    //ordena a lista em ordem alfabetica!
                    list.Sort();
                    //para cada string na minha lista
                    foreach (Funcionario funcionario in list) {
                        //vai imprimir na tela
                        Console.WriteLine(funcionario);
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
