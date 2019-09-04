using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldTutorial
{
    //Primeira classe em C#
    //Classe para Hello World
    class Program
    {
        //Função Main
        //É a primeira a ser chamada no projeto, tudo inicia nela
        static void Main(string[] args)
        {
            //Console.WriteLine escreve uma mensagem no console 
            Console.WriteLine("Hello World!!");

            //No C#, após ele mostrar o texto, ele jpa fecha a tela, assim, não podendo 
            //vizualizar a mensagem.
            //Por isso, vamos pedir para o usuário apertar qualquer tecla para sair do programa
            Console.WriteLine("Aperte qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}
