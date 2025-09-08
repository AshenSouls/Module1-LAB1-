// Базовый класс
class Employee
{
    public string Name { get; set; }
    public int Id { get; set; }
    public string Position { get; set; }
}

    //Создаю производный класс 
    public class Worker : Employee
    {
        public decimal HourlyRate { get; set; }
        public int Hours { get; set; }
        public decimal CalculateSalary()
        {
            return HourlyRate * Hours;
        }
    }
    public class Manager : Employee
    {
        public decimal FixedSalary { get; set; }
        public decimal Bonus { get; set; }
        public decimal CalculateSalary()
        {
            return FixedSalary + Bonus;
        }
    }

class Test
{
    public static void Main()
    {
        
    }
}


