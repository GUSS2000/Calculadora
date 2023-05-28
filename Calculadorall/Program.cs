using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora con Buenas Practicas";
            Console.ForegroundColor = ConsoleColor.Green;
            double numero1;
            double numero2;
            double resultado = 0;

            while (true)
            {
                Console.WriteLine("Calculadora");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Potenciación (al cuadrado)");
                Console.WriteLine("6. Potenciación (al cubo)");
                Console.WriteLine("7. Raíz cuadrada");
                Console.WriteLine("8. Raíz cúbica");
                Console.WriteLine("0. Salir");
                Console.WriteLine("Ingrese la opción deseada:");

                string opcion = Console.ReadLine();

                if (opcion == "0")
                    break;

                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("OPERACIN SUMA");
                        Console.WriteLine("Ingrese el primer número:");
                        while (!double.TryParse(Console.ReadLine(), out numero1))
                        {
                            Console.WriteLine("Entrada inválida. Ingrese nuevamente el primer número:");
                        }
                        Console.WriteLine("Ingrese el segundo número:");
                        while (!double.TryParse(Console.ReadLine(), out numero2))
                        {
                            Console.WriteLine("Entrada inválida. Ingrese nuevamente el segundo número:");
                        }
                        resultado = numero1 + numero2;
                        Console.WriteLine("Resultado: " + resultado);
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("OPERACIÓN RESTA");
                        Console.WriteLine("Ingrese el primer número:");
                        while (!double.TryParse(Console.ReadLine(), out numero1))
                        {
                            Console.WriteLine("Entrada inválida. Ingrese nuevamente el primer número:");
                        }
                        Console.WriteLine("Ingrese el segundo número:");
                        while (!double.TryParse(Console.ReadLine(), out numero2))
                        {
                            Console.WriteLine("Entrada inválida. Ingrese nuevamente el segundo número:");
                        }
                        resultado = numero1 - numero2;
                        Console.WriteLine("Resultado: " + resultado);
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("OPERACIÓN MULTIPLICACIÓN");
                        Console.WriteLine("Ingrese el primer número:");
                        while (!double.TryParse(Console.ReadLine(), out numero1))
                        {
                            Console.WriteLine("Entrada inválida. Ingrese nuevamente el primer número:");
                        }
                        Console.WriteLine("Ingrese el segundo número:");
                        while (!double.TryParse(Console.ReadLine(), out numero2))
                        {
                            Console.WriteLine("Entrada inválida. Ingrese nuevamente el segundo número:");
                        }
                        resultado = numero1 * numero2;
                        Console.WriteLine("Resultado: " + resultado);
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("OPERACIÓN DIVISIÓN");
                        Console.WriteLine("Ingrese el primer número:");
                        while (!double.TryParse(Console.ReadLine(), out numero1))
                        {
                            Console.WriteLine("Entrada inválida. Ingrese nuevamente el primer número:");
                        }
                        Console.WriteLine("Ingrese el segundo número:");
                        while (!double.TryParse(Console.ReadLine(), out numero2) || numero2 == 0)
                        {
                            Console.WriteLine("Entrada inválida. Ingrese nuevamente el segundo número (no puede ser cero):");
                        }
                        resultado = numero1 / numero2;
                        Console.WriteLine("Resultado: " + resultado);
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("OPERACIÓN POTENCIA AL CUADRADO");
                        Console.WriteLine("Ingrese el número:");
                        while (!double.TryParse(Console.ReadLine(), out numero1))
                        {
                            Console.WriteLine("Entrada inválida. Ingrese nuevamente el primer número:");
                        }
                        resultado = Math.Pow(numero1, 2);
                        Console.WriteLine("Resultado: " + resultado);
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("OPERACIÓN POTENCIA AL CUBO");
                        Console.WriteLine("Ingrese el número:");
                        while (!double.TryParse(Console.ReadLine(), out numero1))
                        {
                            Console.WriteLine("Entrada inválida. Ingrese nuevamente el primer número:");
                        }
                        resultado = Math.Pow(numero1, 3);
                        Console.WriteLine("Resultado: " + resultado);
                        break;
                    case "7":
                        Console.WriteLine("Ingrese el número:");
                        while (!double.TryParse(Console.ReadLine(), out numero1))
                        {
                            Console.WriteLine("Entrada inválida. Ingrese nuevamente el primer número:");
                        }
                        if (numero1 >= 0)
                        {
                            Console.Clear();
                            Console.WriteLine("OPERACIÓN RAÍZ CUADRADA");
                            resultado = Math.Sqrt(numero1);
                            Console.WriteLine("Resultado: " + resultado);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Error: No se puede calcular la raíz cuadrada de un número negativo.");
                        }
                        break;
                    case "8":
                        Console.Clear();
                        Console.WriteLine("OPERACIÓN RAÍZ CUBICA");
                        Console.WriteLine("Ingrese el número:");
                        while (!double.TryParse(Console.ReadLine(), out numero1))
                        {
                            Console.WriteLine("Entrada inválida. Ingrese nuevamente el primer número:");
                        }
                        resultado = Math.Pow(numero1, 1.0 / 3.0);
                        Console.WriteLine("Resultado: " + resultado);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                // Conversion del resultado a letras
                string resultadoEnLetras = ConvertirResultado(resultado);
                Console.WriteLine("Resultado: " + resultadoEnLetras);
                Console.WriteLine();
            }
        }

        static string ConvertirResultado(double resultado)
        {
            string resultadoEnLetras = "";

            int parteEntera = (int)resultado;
            double parteDecimal = resultado - parteEntera;

            resultadoEnLetras = ConvParteEnteraEnLetras(parteEntera);

            if (parteDecimal > 0)
            {
                resultadoEnLetras += " coma " + ConvParteDecimalEnLetras(parteDecimal);
            }

            return resultadoEnLetras;
        }

        static string ConvParteEnteraEnLetras(int numero)
        {
            string[] unidades = { "", "Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve", "Diez",
                "Once", "Doce", "Trece", "Catorce", "Quince", "Dieciséis", "Diecisiete", "Dieciocho", "Diecinueve" };
            string[] decenas = { "", "Diez", "Veinte", "Treinta", "Cuarenta", "Cincuenta", "Sesenta", "Setenta", "Ochenta", "Noventa" };
            string[] centenas = { "", "Ciento", "Doscientos", "Trescientos", "Cuatrocientos", "Quinientos", "Seiscientos", "Setecientos",
                "Ochocientos", "Novecientos" };

            if (numero < 20)
            {
                return unidades[numero];
            }
            else if (numero < 100)
            {
                int unidad = numero % 10;
                int decena = numero / 10;

                if (unidad == 0)
                {
                    return decenas[decena];
                }
                else
                {
                    return decenas[decena] + " y " + unidades[unidad];
                }
            }
            else if (numero < 1000)
            {
                int unidad = numero % 10;
                int decena = (numero % 100) / 10;
                int centena = numero / 100;

                if (decena == 0 && unidad == 0)
                {
                    return centenas[centena];
                }
                else if (decena == 0)
                {
                    return centenas[centena] + " " + unidades[unidad];
                }
                else if (unidad == 0)
                {
                    return centenas[centena] + " " + decenas[decena];
                }
                else
                {
                    return centenas[centena] + " " + decenas[decena] + " y " + unidades[unidad];
                }
            }

            return "";
        }

        static string ConvParteDecimalEnLetras(double numero)
        {
            string[] unidadesDecimales = { "Cero", "Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve" };

            int digitos = 2; // Conversion hasta dos decimales

            int parteEntera = (int)Math.Round(numero * Math.Pow(10, digitos));
            string parteDecimalEnLetras = "";

            for (int i = digitos - 1; i >= 0; i--)
            {
                int digito = parteEntera % 10;
                parteEntera /= 10;

                parteDecimalEnLetras = unidadesDecimales[digito] + " " + parteDecimalEnLetras;
            }

            return parteDecimalEnLetras;
        }
    }
}



