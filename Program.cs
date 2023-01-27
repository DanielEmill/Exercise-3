
parOImpar();
perimetroArea();
/*Hacer un programa que le pida al usuario
un número y la computadora responda si
es par o impar.*/
void parOImpar(){
    System.Console.WriteLine("Ingrese el digito:");
    int num = Convert.ToInt32(Console.ReadLine());
    if(num % 2 == 0){
        System.Console.WriteLine("Es par");
    }
    else{
        System.Console.WriteLine("Es impar");
    }
}
void perimetroArea(){
    System.Console.WriteLine("Que desea hacer: 1. Perimetro o area, de un 2.polígono");
    int opcion = Convert.ToInt32(Console.ReadLine());

    switch(opcion){
        case 1:
        perimetro();
        break;

        case 2:
        Area();
        break;
        default:
        System.Console.WriteLine("No hay mas opciones.");
        break;
    }

}
/*Hacer una programa que pueda calcular
el perímetro y el área de cualquier
polígono regular, pero que le pregunte al
usuario qué desea calcular*/
void perimetro(){
    System.Console.WriteLine("Ingrese el valor del lado:");
    int lado = (int)Convert.ToInt64(Console.ReadLine());
    System.Console.WriteLine("El perimetro es: " + (lado * 5));
    }
void Area(){
    System.Console.WriteLine("Ingresa el valor de apotema: ");
    int apotema = (int)Convert.ToInt64(Console.ReadLine());

    System.Console.WriteLine("Ingrese el valor del lado:");
    int perimetroFormula = (int)Convert.ToInt64(Console.ReadLine());
    perimetroFormula = perimetroFormula * 5;
    double area = ((perimetroFormula * apotema) / 2);
    

    System.Console.WriteLine($"El area es: {area}" );
    }