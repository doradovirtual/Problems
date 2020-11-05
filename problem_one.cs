using System;

namespace problem_one{
    public class solution{
        public void cuerda(string cadena){
            string subcadena=null;
            string subcadena_2 = null;
            int contador= 0;
            for (int i = 0; i < (cadena.Length+2); i++)
                {
               
                    if(cadena[i] == cadena[i+1]){
                    
                        contador++;
                        subcadena = subcadena;
                    }
                    else{
                        subcadena = cadena[0].ToString();
                        subcadena = subcadena + cadena[i].ToString();
                    }
                    Console.WriteLine("caracter: "  + subcadena + " posicion: " + i + " contador: " + contador);
                }
            
          
        }
    }

}

