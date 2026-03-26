using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI23T
{
    internal class ModelCalculadora
    {
        //Variáveis = GLOBALMENTE = Código interio enxerga elas
        private double num1;//Encapulsar a variável
        private double num2;
        private double resultado;

        //Métodos que instancia as variévis = dá valores iniciais
        //2º Método construtor
        public ModelCalculadora()
        {
            this.num1 = 0;
            this.num2 = 0;
            this.resultado = 0;
        }//fim do construtor

        public ModelCalculadora(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }//fim do construtor

        //Métdod GET e SET
        public double getNum1()
        {
            return this.num1;
        }//fim do método get

        public double getNum2()
        {
            return this.num2;
        }//fim do get


        public double getResultado()
        {
            return this.resultado;
        }//fim do get


        //Método set - Modificadores

        public void setnum1(double num1)
        {
            this.num1 = num1;
        }//fim do set

        public void setnum2(double num2)
        {
            this.num2 = num2;
        }//fim do set

        public void setResultado(double resultado)
        {
            this.resultado = resultado;
        }//fim do set

        //Operacões artméticas
        public double somar()
        {
            this.setResultado(this.getNum1() + this.getNum2());//Alterandoa resultado
            return this.getResultado();//Mostrando o resultado
        }//fim do método

        public double subtrair()
        {
            this.setResultado(this.getNum1() - this.getNum2());
            return this.getResultado();
        }//fim da classe Model

        public double multiplicar()
        {
            this.setResultado(this.getNum1() * this.getNum2());
            return this.getResultado();
        }//fim do subtrair

        public double dividir()
        {
            if(this.getNum2() == 0)
            {
                return -1;//Flag = Porque elel vai indicar que não da para dividir por zero
            }
            else
            {
                this.setResultado(this.getNum1() / this.getNum2());
                return this.getResultado();
            }
        }//fim do dividir

        //Potência

        public double potencia()
        {
            this.setResultado(Math.Pow(this.getNum1(), this.getNum2()));
            return this.getResultado();
        }//fim do método

        public double raizPrimerioNumero()
        {
            this.setResultado(Math.Sqrt(this.getNum1()));
            return this.getResultado();
        }//fim do primeiro numero

        public double raizSegundoNumero()
        {
            this.setResultado(Math.Sqrt(this.getNum2()));
            return this.getResultado();
        }//fim do primeiro numero

        public string tabuada(int num)
        {
            string msg = "";
            int i = 0;
            for( i = 0; i <= 10; i++)
            {
                msg += "\n" + num + " * " + i + " = " + (num * i);
            }///fim do for
            return msg;
        }//fim do método

        public string bissexto(int ano)//ex 1
        {
            if(ano % 4 == 0)
            {
                return $"{ano} é bissexto";//Interpolação
            }
            else
            {
                return $"{ano} NÃO é bissexto";
            }
        }//1. Verifique se um ano é bissexto.

        public string VerificarIntervalo(int num)
        {
            if (num >= 100 && num <= 200)
            {
                return $"{num} está entre 100 e 200";
            }
            else
            {
                return $"{num} NÃo está entre 100 e 200 ";
                
            }
        }//2. Verifique se um número está entre 100 e 200.

        public string VerificarNumero(int num) // método único e claro
        {
            if (num >= 100 && num <= 200)
            {
                return $"{num} está entre 100 e 200";
            }
            else
            {
                return $"{num} NÃO está entre 100 e 200";
            }
        } //3. Leia a idade e verifique se pode votar.

        public static void main(string[] args)
        {
            Console.Write("Digitie sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 16)
            {
                Console.WriteLine("Não pode votar!");
            }
            else if (idade >= 18)
            {
                Console.WriteLine("Voto facultativo (opcional)!");
            }
            else if (idade >= 70)
            {
                Console.WriteLine("Voto obrigatório!");
            }
            else
            {
                Console.WriteLine("Voto facultativo (opcional)!");
            }
        }

        public string verificarVotacao(int idade)
        {
            if (idade < 16)
            {
                return "Não pode votar!";
            }
            else if (idade >= 18 && idade <= 70)
            {
                return "Voto obrigatório!";
            }
            else
            {
                return "Voto facultativo (opcional)!";
            }
        }//4. Verifique se um número está dentro de um intervalo.

        public string verificarintervalo(int num, int inicio, int fim)
        {
            if (num >= inicio && num <= fim)
            {
                return "Erro: O início do intervalo deve ser menor que o fim!";
            }
            else
            {
                return $"O número {num} não está dentro do intervalo [{inicio}, {fim}]";
            }
        }

        public string verificarDezMaiores(int num)
        {
            int nume = 0;//Dando um valor inicial
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º número: ");
                nume = Convert.ToInt32(Console.ReadLine());

                if (num == nume)
                {
                    return $"{num} está entre os 10 maiores números!";
                }
            }//fim do for
            return $"{num} NÃO está entre os 10 maiores números!";
        }//5. Leia um número e diga se está entre os 10 maiores valores já lidos.

        public string verificarIsoscelesUoEscaleno(double lado1, double lado2, double lado3)
        {             if (lado1 == lado2 && lado2 == lado3)
            {
                return "O triângulo é equilátero.";
            }
            else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
            {
                return "O triângulo é isósceles.";
            }
            else
            {
                return "O triângulo é escaleno.";
            }
        }//6. Verifique se um triângulo é equilátero, isósceles ou escaleno.

        public void verificarSemana(int dia)
        {
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda-feira");
                    break;
                case 3:
                    Console.WriteLine("Terça-feira");
                    break;
                case 4:
                    Console.WriteLine("Quarta-feira");
                    break;
                case 5:
                    Console.WriteLine("Quinta-feira");
                    break;
                case 6:
                    Console.WriteLine("Sexta-feira");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;
                default:
                    Console.WriteLine("Número inválido! Digite um número entre 1 e 7.");
                    break;
            }
            
        }//7. Leia um número de 1 a 7 e mostre o dia da semana.

























































    }//fim da classe Model
}//fim do porjetoCalcudoraTI23T