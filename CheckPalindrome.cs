using Microsoft.VisualBasic;

namespace CheckPalindrome;


    class CheckPalindrome{

        
       

        static void Main(string [] args){

          Console.WriteLine(HowToCheckPalindrome());     

           
        }
            

             public static bool HowToCheckPalindrome()
            {
                 Console.WriteLine("Please enter the word you would like to check = ");
              string word= Console.ReadLine();

                char [] wordArray= word.ToCharArray();
                var newWord="";
                var lastWord="";
                
                for (int i = wordArray.Length - 1; i >= 0 ; i--)
                {
                    Console.WriteLine(wordArray[i]);
                     newWord= newWord +wordArray[i];
                     lastWord= newWord;
                    Console.WriteLine(lastWord);
                }

                if(word.Equals(lastWord)){
                    return true;
                }else{
                    return false;
                }
                
            }




    }