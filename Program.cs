using System;

namespace Triangulo.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args) {
            float[] abc = new float[3];
            char[] _abc = { 'A', 'B', 'C' };

            while (true) {
                for (int i = 0; i < abc.Length; i++) {
                    Console.WriteLine("Digite um Valor para {0}:", _abc[i]);
                    if (!float.TryParse(Console.ReadLine(), out abc[i])) {
                        Console.WriteLine("Somente números são aceitos, outros caracteres serão rejeitados !!!");
                        Console.WriteLine("Se o número for negativo o seu módulo será aceito");
                        i = -1;
                    } else if (abc[i] < 0)
                        abc[i] *= -1;
                }
                bool condExistencia = abc[0] + abc[1] > abc[2] && abc[0] + abc[2] > abc[1] && abc[1] + abc[2] > abc[0];
                if (!condExistencia) {
                    Console.WriteLine("Triângulo Inválido!!\n\tTodos os lados devem" +
                        " ser menores que a soma dos dois outros lados...");
                    continue;
                }
                else {
                    if (abc[0] == abc[1] && abc[1] == abc[2])
                        Console.WriteLine("O triângulo é do tipo Equilátero : Todos os lados são iguais!!");
                    else if (abc[0] == abc[1] || abc[0] == abc[2])
                        Console.WriteLine("O triângulo é do tipo Isósceles : Dois lados são iguais!!");
                    else
                        Console.WriteLine("O triângulo é do tipo Escaleno : Todos os lados são diferentes!!!");
                }
                Console.WriteLine("\tLado A : {0}\n\tLado B : {1}\n\tLado C : {2}", abc[0], abc[1], abc[2]);
                Console.WriteLine("Para encerrar a aplicação digite 'sair', ou qualquer outra tecla para continuar");
                if ( Console.ReadLine().ToLower().Equals("sair")) {
                    break;   
                }
            }
            Console.WriteLine("Encerrando ...");
            Console.ReadLine();
        }
    }
}
