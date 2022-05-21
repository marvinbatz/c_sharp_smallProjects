using System;

namespace createMethod // Note: actual namespace depends on the project name.
{
    internal class myMethods
    {
        public void IntegerAddition(int a, int b)
        {
            int Addition = a + b;
            Console.WriteLine("El resultado de la suma es " + Addition);
        }

        public void IntegerMultiplication(int a, int b)
        {
            int Addition = a * b;
            Console.WriteLine("El resultado del producto es " + Addition);
        }

        public void floatDivision(float a, float b)
        {
            float Addition = a / b;
            Console.WriteLine("El resultado de la division es " + Addition);
        }


        static void Main(string[] args)
        {
            // Generamos una refereancia creando una isntancia de nuestra clase
            myMethods suma = new myMethods();
            suma.IntegerAddition(3, 6);

            myMethods multi = new myMethods();
            multi.IntegerMultiplication(3, 6);

            myMethods div = new myMethods();
            div.floatDivision(5, 2);
        }
    }
}