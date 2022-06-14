// See https://aka.ms/new-console-template for more information


bool salir = false;

while (!salir)
{
    Console.WriteLine("Calculadora operaciones basicas");
    double valor1, valor2, suma, resta, multiplicacion, division, potencia, potenciaraiz;
    Console.WriteLine("Ingrese un número");
    valor1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese un número");
    valor2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Eliga una operacion");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Multiplicacion");
    Console.WriteLine("4. Divison");
    Console.WriteLine("5. Potencia");
    Console.WriteLine("6. Raiz");
    Console.WriteLine("7. Salir");
    int opcion = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Operacion seleccionada: " + opcion);



    switch (opcion)
    {
        case 1:
            suma = valor1 + valor2;
            Console.WriteLine("El resultado de la suma es  " + suma);
            break;

        case 2:
            resta = valor1 - valor2;
            Console.WriteLine("El restado de la resta es " + resta);
            break;

        case 3:
            multiplicacion = valor1 * valor2;
            Console.WriteLine("El resultado de la multiplicación es " + multiplicacion);
            break;

        case 4:
            division = valor1 / valor2;
            Console.WriteLine("El resultado de la división es " + "{0:N4}", division);
            break;

        case 5:
            //math.pow sirve para elevar un numero
            potencia = Math.Pow(valor1, valor2);
            //Console.WriteLine("El resultado de la potencia es " + potencia);
            Console.WriteLine("La potencia {0} elevado a {1} es {2} ", valor1, valor2, potencia.ToString("N4"));
            break;

        case 6:
            potenciaraiz = Math.Pow(valor1, (double)1 / valor2);
            Console.WriteLine("La raiz de {0} es {1} ", valor1, potenciaraiz.ToString("N4"));
            break;

        case 7: 
            Console.WriteLine("Saliendo de la calculadora");
            salir = true;
            break;

        default:
            Console.WriteLine("No se ha seleccionado una opcion");
            break;
    }

    Console.ReadKey();
    Console.Clear();
}

