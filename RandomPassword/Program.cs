using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace RndPassword {
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Şifre uzunluğunu giriniz :");
            int passwordLenght = int.Parse(Console.ReadLine());

            string password = SifreOlustur(passwordLenght);
            Console.WriteLine("Oluşturulan şifre :" + password);
            Console.ReadLine();
        
        
        }
    
        static string SifreOlustur(int lenght)
        {
            while(true) { 
             const string chars =
               "ABCDEFGIHJKLMNOPQRSTUVWYZabcdefgıhjklmnopqrstuvwyz0123456789!@#$½&^?*()_+";
            
            StringBuilder sb = new StringBuilder();
            Random random= new Random();
            for (int i = 0; i < lenght; i++)
            {
                int index = random.Next(chars.Length);
                sb.Append(chars[index]);
            }
            return sb.ToString();
        
            
           
            
            
            } 

          
           

        }
           
}   
    }