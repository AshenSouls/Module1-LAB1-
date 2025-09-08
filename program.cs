// Базовый класс
class Employee
{
    public string Name { get; set; }
    public int Id { get; set; }
    public string Position { get; set; }

    public Employee(string name, int id, string position)
    {
        Name = name;
        Id = id;
        Position = position;
    }
}

