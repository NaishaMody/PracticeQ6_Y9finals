namespace PracticeQ6_Y9finals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string UserName1 = "Yusuf5";
            string Password1 = "33kk";
            
            string UserName2 = "Mary80";
            string Password2 = "af5r";
           
            string UserAttempt = "0";
            string PasswordAttempt = "0";
            bool loop = true;

            while (loop == true)
            {
                Console.WriteLine("Please enter your UserName");
                UserAttempt = Console.ReadLine();
                Console.WriteLine("Please enter your Password");
                PasswordAttempt = Console.ReadLine();
                if ((UserAttempt == UserName1 && PasswordAttempt == Password1) || (UserAttempt == UserName2 && PasswordAttempt == Password2))
                {
                    Console.WriteLine("Access granted");
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Access denied");
                }
            }
            

            
        }
    }
}
