using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI23T
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Passando os dois  número para a classe de controle
            ControlCalculadora controle = new ControlCalculadora();

            controle.realizarOperacao();//Executar as ações
            Console.ReadLine();//Manter a prompt aberto
        }//Fim do método main
    }//fim da classe program
    //fim do projeto CaculadoraTI23T
}
