using System;
class Calculadora
{
    static void Main ()
    {
        Console.WriteLine("Calculadora basica de c# usando switch");

        Console.WriteLine("Ingrese un numero: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("seleccione una operacion  (+,-,x o /) : ");
        string operacionAsing = Console.ReadLine(); //el string se usa para almacenar el texto asignado arriba

        double resultado;

        string masOperaciones = "SI";

        Calculadora calculadora = new Calculadora();

       

            switch (operacionAsing)
            {
                case "+":
                    //resultado = numero1 + numero2;
                    calculadora.suma();
                    Console.WriteLine("resultado es :" + resultado); //El "+" sirve como una concatenación osea une texto y datos en string
                    break; //define la sentecai de un bucle y un switch

                case "-":
                    //resultado = numero1 + numero1;
                    Console.WriteLine("Resultado de la resta es :" + calculadora.Resta(numero1, numero2));
                    break;

                case "x":
                    resultado = numero1 * numero2;
                    Console.WriteLine("resultado es :" + resultado);
                    break;

                case "/":
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                        Console.WriteLine("el resultado es:" + resultado);
                    }
                    else
                    {
                        Console.WriteLine("no se puede dividir entre 0");

                    }
                    break;

                //default se realizara en switch sin ninguna las expeciones coincide con case en switch
                default:
                    Console.WriteLine("no se a introducido ningun valor, utiliza +,-,x o /");
                    break;

                while (masOperaciones == "SI")
                {

                }
        }

        
    }

    void Sumar() { 
    
    }

    static double Resta(double a, double b) {
        return a + b;
    }


}