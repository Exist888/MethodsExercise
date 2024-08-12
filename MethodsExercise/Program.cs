namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Story();
        }
        public static void Story()
        {
            //Introducing Game to User
            Console.WriteLine("\n" +
                              "Hello, welcome to MadLibs2.0.\n" +
                              "We are going to ask you a few questions,\n" +
                              "and then we are going to turn your answers\n" +
                              "into a fun story for you:\n" +
                              "\n" +
                              
                              //Prompt 1 - Name
                              "Firstly, what is your name?");
            
            //Input 1 - Name
            string name = Console.ReadLine();

            //Output 1 - Name
            //Question 2 - Color
            Console.WriteLine($"Nice to meet you, {name}.\n" +
                              $"Now, what is your favorite color?");
            
            //Input 2 - Color
            string color = Console.ReadLine();
            
            //Output 2 - Color
            //Question 3 - Animal
            Console.WriteLine($"Nice! I happen to like the color {color} too.\n" +
                              $"Next, what is your favorite animal?");
            
            //Input 3 - Animal
            string animal = Console.ReadLine();
            
            //Output 3 - Animal
            //Question 4 - Band
            Console.WriteLine($"Sweet! {animal}s are cool animals indeed.\n" +
                              $"Lastly, what is your favorite Band?");
            
            //Input 4 - Band
            string band = Console.ReadLine();
            
            //Output 4 - Band
            Console.WriteLine($"Awesome. I like {band} too. They have some really cool songs.\n" +
                              $"");
            
            //Story
            Console.WriteLine("Okay, now it's time to put all of your answers into a fun story.\n" +
                              "Are you Ready?\n" +
                              "Let's gooooooo...\n" +
                              "\n");
            Console.WriteLine($"Yesterday, I saw {band} playing at the Stadium.\n" +
                              $"Their guitarist was tired, so they replaced him with a {animal}.\n" +
                              $"The {animal} spoke into the mic, and said hello to {name}.\n" +
                              $"{name} was excited about that, and was wearing a {color} tie.");
        }    
        
    }

}
