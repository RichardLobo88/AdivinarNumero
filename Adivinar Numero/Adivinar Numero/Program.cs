/*1) Generar un número secretoaleatorio con la siguiente instruccion:

// Genera un numero entero aleatorio de 1 a 20
int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);

2) Pedir al usuario que ingrese un número y que
intente adivinar el número que eligió la computadora.

3) Si el numero ingresado por el usuario es mayor
al número secreto, avisarle que es muy grande y que intente de nuevo y que
vuelva al paso 2.

4) Si el numero ingresado es menor al número
secreto, avisarle que es muy chico, y que intente de nuevo volviendo al paso 2.

5) Si el número ingresado coincide con el número
secreto, sacar el siguiente mensaje:

"Felicitaciones, has adivinado el número
secreto que era:  [numeroSecreto] "
"Lo has logrado en [n] intentos!!"

Y finalizar el programa.*/

int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);
var opcionElegida = int.Parse(Console.ReadLine());

do
{
Console.WriteLine("Por favor ingrese un número");

    if (numeroSecreto < opcionElegida)
    {

        Console.WriteLine("el numero es muy grande,intente de nuevo ");
    }
    else
    {
        opcionElegida = int.Parse(Console.ReadLine());
        Console.WriteLine("El número ingresado es muy chico, intente de nuevo");
    }
   
}
while (numeroSecreto != opcionElegida);

 {
        Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era:{numeroSecreto}" );
    Console.WriteLine($"Lo has logrado en [n] intentos!!"); 
}
 
   

/* probando de otra manera
while (numeroSecreto != opcionElegida)
{
   

 
    Console.WriteLine("Por favor ingrese un número");
 Console.ReadLine();

}
if (numeroSecreto < opcionElegida)
    {

    opcionElegida = int.Parse(Console.ReadLine());

        Console.WriteLine("el numero es muy grande,intente de nuevo ");
    }
else 
    {
        Console.WriteLine("El número ingresado es muy chico, intente de nuevo");
    }
    
       */






