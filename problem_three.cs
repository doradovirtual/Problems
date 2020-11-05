using System;



namespace problem_three{

    class solution{

        public string concatenacion (string a, string b){

            int index = b.IndexOf(a, 0,b.Length); 
            
            //Console.WriteLine(index); 

            if(index != -1){
                 return "YES";  

            }
            else{
                return "NO";
            }

        }

    }



}