using System;
using System.Collections.Generic;

namespace CalculadoraSomaMedia{

     class Menu{

        static public void Main(){

            Console.WriteLine("Olá, essa é uma calculadora de Media.");
            Console.WriteLine("Para começar nos diga seu nome: ");
            string userName = Console.ReadLine()!;

            menu:

            Console.WriteLine("Certo, {0}, quantos numeros gostaria de calcular? ", userName);
            int numbersQuantity = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Ok, nesse caso informe os {0} numeros que precisam ser calculados.", numbersQuantity);
            List<double> userNumbers = new List<double>();

            inicio:
            userNumbers.Add(double.Parse(Console.ReadLine()!));
            if(userNumbers.Count < numbersQuantity){
                goto inicio;
            }
            double sum = 0;
            foreach(double element in userNumbers){
                sum = sum + element;
            }
            double avg;
            avg = sum / userNumbers.Count;

            Console.WriteLine("A soma dos valores é {0}", sum);
            Console.WriteLine("A média dos valores é {0}", avg);
            Console.WriteLine("gostaria de calcular novamente?[s/n] ");
            string userChoice = Console.ReadLine()!;
            if(userChoice == "s" || userChoice == "S"){
                goto menu;
            }else{
                Console.Clear();
                Console.WriteLine("Fim do Programa!");
            }

            
            

            
            

            


            
            
                          
            
        } 
                
    }

}