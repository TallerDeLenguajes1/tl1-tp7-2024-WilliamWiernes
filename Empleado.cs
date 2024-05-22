namespace EspacioEmpleado;

public enum Cargos
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}

public class Empleado
{
    private string Nombre;
    private string Apellido;
    private DateTime FecNac;
    private char EstCiv;
    private DateTime IngEmp;
    private double SueBas;
    private Cargos Cargo;

    public string Nombre1 { get => Nombre; set => Nombre = value; }
    public string Apellido1 { get => Apellido; set => Apellido = value; }
    public DateTime FecNac1 { get => FecNac; set => FecNac = value; }
    public char EstCiv1 { get => EstCiv; set => EstCiv = value; }
    public DateTime IngEmp1 { get => IngEmp; set => IngEmp = value; }
    public double SueBas1 { get => SueBas; set => SueBas = value; }
    public Cargos Cargo1 { get => Cargo; set => Cargo = value; }

    public int Antiguedad()
    {
        int antiguedad;
        DateTime fechaActual = DateTime.Now;

        antiguedad = fechaActual.Year - IngEmp1.Year;

        if (fechaActual.Month < IngEmp1.Month || (fechaActual.Month == IngEmp1.Month && fechaActual.Day < IngEmp1.Day))
        {
            antiguedad--;
        }

        return antiguedad;
    }

    public int Edad()
    {
        int edad;
        DateTime fechaActual = DateTime.Now;

        edad = fechaActual.Year - FecNac1.Year;

        if (fechaActual.Month < FecNac1.Month || (fechaActual.Month == FecNac1.Month && fechaActual.Day < FecNac1.Day))
        {
            edad--;
        }

        return edad;
    }

    public int AnioJub()
    {
        int aniosJub, edad = Edad();

        aniosJub = 65 - edad;

        return aniosJub;
    }

    public double Salario()
    {
        double salario, adicional;
        int antiguedad = Antiguedad();

        if (antiguedad < 20)
        {
            adicional = SueBas1 * 0.01 * antiguedad;
        }
        else
        {
            adicional = SueBas1 * 0.25;
        }

        if (Cargo1 == Cargos.Ingeniero || Cargo1 == Cargos.Especialista)
        {
            adicional += adicional * 0.5;
        }

        if (EstCiv1 == 'c')
        {
            adicional += 150000;
        }

        salario = SueBas1 + adicional;

        return salario;
    }
}