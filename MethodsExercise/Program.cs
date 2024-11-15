namespace MethodsExercise
{
    public class Program
    {
        public static void StoryCreation()
        {
            //collect user input for story
            Console.WriteLine("What is your name?");
            string username = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string favcolor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal");
            string favanimal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string favband = Console.ReadLine();

            //write story
            Console.WriteLine($"{username}'s favorite color is {favcolor}, favorite animal is a {favanimal}, and favorite band are the {favband}");
        }
        
        
        
        static void Main(string[] args)
        {
            //call story creation method
            StoryCreation();
        }
    }
}
