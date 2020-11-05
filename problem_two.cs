using System;
using System.Collections.Generic;


namespace problem_two{


    public class solution2{

        public bool sala_chat (string cadena){
            //convert to min
            string message_m = cadena.ToLower();
            char[] charsToTrim = {' '};
            //var for comparate
            string comparation = "hola";
            //create obj of type <Hashset> and to validate each character in the string.
            var validation_char = new HashSet<char>();
            //create vector of chars for to stock each character of string validate.
            char [] validation = new char[comparation.Length];
          

    
            for (int i = 0; i < message_m.Length; i++)
            {
                validation_char.Add(message_m[i]);
            }

            validation_char.CopyTo(validation);
            //Console.WriteLine("tamaño validacion: " + validation.Length);
            
            string validation_string =  new string(validation).Trim(charsToTrim);
            
            //Console.WriteLine("comparacion: " + comparation);
            bool result = string.Equals(validation_string,comparation);

         

            //Console.WriteLine("resultado:" + result);
            if(result){
                return true;
            }else{
                return false;
            }
        return default;
        }
    
    }
}