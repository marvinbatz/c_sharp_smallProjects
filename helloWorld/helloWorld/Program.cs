// See https://aka.ms/new-console-template for more information

namespace holaMundo
{
    class Program
    {
        static void Main(String[] args)
        {
            int height = 180;
            int age = 34;
            string name = "Marvin Batz";
            string infomation = "The requested info is: " +
                "\n User name: " + name +
                "\n Age: " + age +
                "\n Height: " + height; 

            Console.WriteLine(infomation);
        }
    }
}