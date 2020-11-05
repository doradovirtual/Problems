using System;

namespace Problems
{
    
    class main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************************************************************");
            Console.WriteLine("********************Pruebas_Desarollo*******************************");
            Console.WriteLine("********************************************************************");
            Console.WriteLine("1. Cuerdas Periodicas");
            Console.WriteLine("2. Sala de Chat");
            Console.WriteLine("3. Todo en Uno");
            Console.WriteLine("********************************************************************");

            string caso = Console.ReadLine();
            int caseSwitch= Int32.Parse(caso);

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1");
                break;
                case 2:
                    problem_two.solution2 message = new problem_two.solution2();
                    Console.WriteLine("Introduzca Cadena: ");
                    string cadena = Console.ReadLine();
                    while (cadena == " ")
                    {
                        Console.WriteLine("Cadena vacia, Digite un valor correcto: ");
                        cadena = Console.ReadLine();
                    }
            
                    bool result = message.sala_chat(cadena);
                    Console.WriteLine(" resultado: " + result);
                break;

                case 3:
                     problem_three.solution conc = new problem_three.solution();
                     Console.WriteLine("Digite la primera cadena: ");
                     string a = Console.ReadLine();
                     Console.WriteLine("Digite la segunda cadena: ");
                     string b = Console.ReadLine();

                     conc.concatenacion(a,b);

                     string resultado = conc.concatenacion(a,b); 
                     if(resultado == "YES"){
                        Console.WriteLine("YES");
                     }
                     if(resultado == "NO"){
                        Console.WriteLine("NO");
                     }
                break;

                default:
                    Console.WriteLine("Default case");
                break;
            }
    
        }
           
    }
      
}


