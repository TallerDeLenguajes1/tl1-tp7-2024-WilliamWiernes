using EspacioEmpleado;

Empleado[] Empleados = new Empleado[3];

// Empleados
Empleados[0] = new Empleado();
Empleados[0].Nombre1 = "William";
Empleados[0].Apellido1 = "Wiernes";
Empleados[0].FecNac1 = new DateTime(2004, 1, 23);
Empleados[0].EstCiv1 = 'c';
Empleados[0].IngEmp1 = new DateTime(2023, 1, 1);
Empleados[0].SueBas1 = 900000;
Empleados[0].Cargo1 = Cargos.Especialista;

Empleados[1] = new Empleado();
Empleados[1].Nombre1 = "Brian";
Empleados[1].Apellido1 = "Wiernes";
Empleados[1].FecNac1 = new DateTime(2002, 1, 7);
Empleados[1].EstCiv1 = 'c';
Empleados[1].IngEmp1 = new DateTime(2021, 1, 1);
Empleados[1].SueBas1 = 200000;
Empleados[1].Cargo1 = Cargos.Auxiliar;

Empleados[2] = new Empleado();
Empleados[2].Nombre1 = "María";
Empleados[2].Apellido1 = "Sosa";
Empleados[2].FecNac1 = new DateTime(1980, 4, 11);
Empleados[2].EstCiv1 = 's';
Empleados[2].IngEmp1 = new DateTime(2012, 1, 1);
Empleados[2].SueBas1 = 700000;
Empleados[2].Cargo1 = Cargos.Administrativo;

double montoTotal = 0;
int  index = 0, minAniosJub = Empleados[index].AnioJub(), aniosJub;

foreach (Empleado Empleado in Empleados)
{   
    montoTotal += Empleado.Salario();

    aniosJub = Empleado.AnioJub();

    if(aniosJub < minAniosJub)
    {
        minAniosJub = aniosJub;
        index++;
    }
}

Console.WriteLine($"Monto total en concepto de salario: ${montoTotal}");
Console.WriteLine("");
Console.WriteLine("Empleado más próximo a jubilarse:");
Console.WriteLine($"Nombre: {Empleados[index].Nombre1}");
Console.WriteLine($"Apellido: {Empleados[index].Apellido1}");
Console.WriteLine($"Fecha de nacimiento: {Empleados[index].FecNac1}");
Console.WriteLine($"Estado civil: {Empleados[index].EstCiv1}");
Console.WriteLine($"Ingreso a la empresa: {Empleados[index].IngEmp1}");
Console.WriteLine($"Sueldo básico: ${Empleados[index].SueBas1}");
Console.WriteLine($"Cargo: {Empleados[index].Cargo1}");
Console.WriteLine($"Antiguedad: {Empleados[index].Antiguedad()}");
Console.WriteLine($"Edad: {Empleados[index].Edad()}");
Console.WriteLine($"Cantidad de años para jubilarse: {Empleados[index].AnioJub()}");
Console.WriteLine($"Salario: ${Empleados[index].Salario()}");