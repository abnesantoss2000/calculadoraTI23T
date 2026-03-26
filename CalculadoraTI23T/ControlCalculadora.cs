using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI23T
{
    class ControlCalculadora
    {
        //Variáveis Globais
        ModelCalculadora model;//Começado a conectar a control e a model

        //Construtor vazio da classe ModelCalculadora
        public ControlCalculadora()
        {
            this.model = new ModelCalculadora();//Efetivamente a ligação com a model
        }//fim do construtor vazio

        public ControlCalculadora(double num1, double num2)
        {
            this.model = new ModelCalculadora(num1, num2);
        }//fim do construtor com parâmetros
         //Método do Menu
        public String mostrarMenu()
        {
            return "--------Menu--------\n\n" +
                   "Escolha uma das opções abaixo: \n" +
                   "0. Sair\n" +
                     "1. Somar\n" +
                     "2. Subtrair\n" +
                     "3. Multiplicar\n" +
                     "4. Dividir\n" +
                     "5. Potência\n" +
                     "6. Raiz Primeiro Número\n" +
                     "7. Raiz Segundo Número\n" +
                     "8. Tabuada\n" +
                     "9. Bissexto\n" +
                     "10. Verificar se o número é par ou ímpar\n" +
                     "11.Verificar situação eleitoral\n" +
                     "12. Verificar se um númer oestá dentro de um intervalo\n"+
                     "13. Verificar se um número está entre os 10 maiores\n" +
                     "14. Verificar se um triângulo é equilátero, isósceles ou escaleno\n";
        }//fim do método

        public void realizarOperacao()
        {
            int opcao = 0;//Declarar do lado de fora do do...while()
            do {
                Console.WriteLine(this.mostrarMenu());//Chamar o menu
                opcao = Convert.ToInt32(Console.ReadLine());//Leia
              
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        this.coletar();//Pegar o que usuário está digitando 
                        Console.WriteLine("A soma é: " + this.model.somar());
                        break;
                    case 2:
                        this.coletar();
                        Console.WriteLine("A subtração é: " + this.model.subtrair());
                        break;
                    case 3:
                        this.coletar();
                        Console.WriteLine("A multiplicação é: " + this.model.multiplicar());
                        break;
                    case 4:
                        this.coletar();
                        if (this.model.dividir() == -1)
                        {
                            Console.WriteLine("Impossível dividir por zero!");
                        }
                        else
                        {
                            Console.WriteLine("A divisão é: " + this.model.dividir());
                        }
                        break;
                    case 5:
                        this.coletar();
                        Console.WriteLine("A potência é: " + this.model.potencia());
                        break;
                    case 6:
                        Console.WriteLine("Informe um número: ");
                        this.model.setnum1(Convert.ToInt32(Console.ReadLine()));
                        
                        Console.WriteLine("A raiz do primerio número é: " + this.model.raizPrimerioNumero());
                        
                        break;
                    case 7:
                        Console.WriteLine("Informe um número: ");
                        this.model.setnum2(Convert.ToInt32(Console.ReadLine()));

                        Console.WriteLine("A razi do segundo número é: " + this.model.raizSegundoNumero());
                        break;
                    case 8:
                        Console.WriteLine("Informe um número: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        //Para chamar a tabuada
                        Console.WriteLine(this.model.tabuada(num));
                        break;
                    case 9:
                        Console.WriteLine("Informe um ano: ");
                        int ano = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.model.bissexto(ano));
                        break;                   
                    case 10:
                        Console.WriteLine("Informe um número para verificar:");
                        int numParaVerificar = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(this.model.VerificarNumero(numParaVerificar));
                        break;
                    case 11:
                        Console.WriteLine("Informe sua idade: ");
                        int idade = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.model.verificarVotacao(idade));
                        break;
                    case 12:
                        Console.WriteLine("Informe o início do intervalo. ");
                        int inicio = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o fim do intervalo. ");
                        int fim = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o número do intervalo. ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(this.model.verificarintervalo(num, inicio, fim));
                        break;
                    case 13:
                        Console.WriteLine("Digite um número para verificar se está entre os 10 maiores: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(this.model.verificarDezMaiores(num));
                        break;
                    case 14:
                        Console.WriteLine("Informe o lado 1 do triângulo: ");
                        int lado1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o lado 2 do triângulo: ");
                        int lado2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o lado 3 do triângulo: ");
                        int lado3 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(this.model.verificarIsoscelesUoEscaleno(lado1, lado2, lado3));
                        break;
                    case 15:
                        Console.WriteLine("Número inválido! Digite um número entre 1 e 7. ");
                        Console.WriteLine("Digite um número de 1 a 7 para mostrar o dia da semana: ");
                        int dia = Convert.ToInt32(Console.ReadLine());
                        this.model.verificarSemana(dia);
                        break;
                }//fim do escolha
            } while (opcao != 0);
        }//fim do método

        public void coletar()
        {
            Console.Write("\nInforme o primeiro número: ");
            this.model.setnum1(Convert.ToDouble(Console.ReadLine()));//Peguei o primeiro número

            Console.Write("Informe o segundo número: ");//Peguei o segundo núemero
            this.model.setnum2(Convert.ToDouble(Console.ReadLine()));
        }//fim do coletar

















































































    }//fim da classe
}//fim do projeto