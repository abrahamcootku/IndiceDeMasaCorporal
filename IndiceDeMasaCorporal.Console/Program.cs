using System;
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        //le pedimos al usuario que escriba su estatura y peso
        Console.WriteLine("Escribe tu peso en KG: ");
        string pesoTexto = Console.ReadLine();

        Console.WriteLine("Escribe tu estatura en metros: ");
        string estaturaTexto = Console.ReadLine();

        //convertimos el texto a numeros
        double peso = double.Parse(pesoTexto);
        double estatura = double.Parse(estaturaTexto);

        //luego hacemos la operacion para calcular el imc que es peso entre estatura elevado al cuadrado o multiplicado por si mismo
        double imc = peso / (estatura * estatura);
        Console.WriteLine("Tu IMC es : " + imc);

        //si el imc es menor a 18.5 es bajo de peso
        if (imc < 18.5)
        {
            Console.WriteLine("estas bajo de peso");

        }
        //si el imc es menor a 25 es en peso normal
        else if
        (imc < 25)

        {
            Console.WriteLine("Tu peso es normal");
        }
        //si tu imc es menor a 30 es sobrepeso
        else if
        (imc < 30)
        {
            Console.WriteLine("estas en sobrepeso");
        }
        //si tu imc es menor o igual a 40 estas en obesidad
        else if (imc <= 40)
        {
            Console.WriteLine("estas en obesidad");
        }
        //si tu imc es mayor a 40 estas en obesidad extrema
        else
        {
            Console.WriteLine("estas en obesidad extrema");
        }
      
            Console.ReadKey();

    }

}

