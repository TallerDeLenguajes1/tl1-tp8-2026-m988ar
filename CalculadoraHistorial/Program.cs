
using EspacioCalculadora;



int indice;
double num = 0;
Calculadora calculadora = new Calculadora();

do
{
    System.Console.WriteLine("Elija la operacion que desea realizar");
    System.Console.WriteLine("| " + calculadora.Dato + " |");
    System.Console.WriteLine("0)Salir\n1)Suma\n2)Resta\n3)Multiplicacion\n4)Division\n5)Limpiar");
    if (!int.TryParse(Console.ReadLine(), out indice))
    {
        System.Console.WriteLine("Meeeeh");
    }
    if (indice != 0 && indice != 5)
    {
        System.Console.WriteLine("Ingrese un numero para realizar la operacion");
        if (!double.TryParse(Console.ReadLine(), out num))
        {
            System.Console.WriteLine("Meeeeh El regreso");
        }
    }
    switch (indice)
    {
        case 1:
            calculadora.Sumar(num);
            break;
        case 2:
            calculadora.Restar(num);
            break;
        case 3:
            calculadora.Multiplicar(num);
            break;
        case 4:
            if (num == 0)
            {
                System.Console.WriteLine("Tus papas son hermanos o intentas divividr por 0");
            }
            else
            {
                calculadora.Dividir(num);
            }

            break;
        case 5:

            calculadora.Limpiar();
            break;

    }
} while (indice != 0);
