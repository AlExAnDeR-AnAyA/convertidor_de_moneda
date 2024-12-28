using System; //Se importa la Biblioteca. 

class ConversionMoneda // Se declara la clase principal, la cual va a contener el código que debe ejecutarse.
{
    const double Dolares_rate = 4000.0; // Declaración de constantes, para realizar la operación de conversión. Estos valores no se pueden modificar. 
    const double Euros_rate = 4500.0;

    static void Main() // Método principal o punto de partida donde el código se empieza a funcionar cuando se ejecuta el archivo. 
    {
        Console.WriteLine("Convertidor de Moneda: Pesos a Dolares y Euros"); // Muestra al usuario en la consola un mensaje para que este identifique la función del programa.
        double pesosAmount = GetValidInput(); // Llamada a la función para validar la entrada, en pesos colombianos y almacenarlos en la variable (PesosAmount)
        ConvertAndDisplay(pesosAmount); // Llamada a la función para mostrar los resultados.
    }

    static double GetValidInput() // Método para validar la entrada del usuario. 
    {
        double amount; // Se declara una variable para almacenar el monto ingresado por el usuario. 
        while (true) // Bucle infinito, que se utiliza para seguir solicitando un valor hasta que el usuario ingrese uno no valido. 
        {
            Console.Write("Ingrese el monto en moneda colombiana (Pesos): "); // Muestra un mensaje en consola para que el usuario ingrese un valor en pesos colombianos. 
            string? input = Console.ReadLine(); // Permite valores nulos
            if (string.IsNullOrEmpty(input))    // Verifica si el valor es nulo o vacío
            {
                Console.WriteLine("Entrada vacía, por favor ingrese un valor.");
                continue; // Solicita nuevamente el dato
            }

            // CORREGIDO: No debe tener punto y coma (;) al final.
            if (double.TryParse(input, out amount) && amount > 0) 
            {
                return amount; // Devuelve el valor ingresado si es correcto. 
            }
            else
            {
                Console.WriteLine("Valor incorrecto. Por favor ingrese un dato valido."); // Muestra en pantalla que el valor ingresado no es válido. 
            }
        }
    }
    
    static void ConvertAndDisplay(double pesosAmount) // Método para la conversión de unidades. 
    {
        double Dolares = pesosAmount / Dolares_rate; // Conversión de dolares a pesos.
        double Euros = pesosAmount / Euros_rate; // Conversión de euros a pesos. 

        Console.WriteLine($"El valor en Dolares es {Dolares:F2}"); //Muestra el valor imprimiendo el resultado con dos decimales (F2).
        Console.WriteLine($"El valor en Euros es {Euros:F2}");

    }
}
