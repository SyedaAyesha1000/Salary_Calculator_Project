using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Employee person = new Employee();
        person.Calculator();
        Console.WriteLine("Enter Employee Type");
        person.employeeType = Console.ReadLine();
        Engineer eng = new Engineer();
        Manager mana = new Manager();
        Analyst ana = new Analyst();
        if (person.employeeType == "Engineer" || person.employeeType == "engineer")
        {
            eng.Calculator();
        }
        else if (person.employeeType == "Manager" || person.employeeType == "manager")
        {
            mana.Calculator();
        }
        else if (person.employeeType == "Analyst" || person.employeeType == "analyst")
        {
            ana.Calculator();
        }
        else
        {
            Console.WriteLine("This is not valid employee");
        }
    }
}
public class Employee
{
    public string employeeType;
    public void Calculator()
    {
        double grossSalary = 0;
        double basic = 1500;
        double fuel = 0;
        double medical = 0;
        grossSalary = basic + fuel + medical;
        Console.WriteLine("Gross Salary of normal employee : $" + grossSalary);
    }
}
public class Engineer : Employee
{
    public void Calculator()
    {
        double grossSalary = 0;
        double basic = 1500;
        double fuel = 100;
        double medical = 500;
        grossSalary = basic + fuel + medical;
        Console.WriteLine("Gross Salary of Engineer : $" + grossSalary);
    }
}
public class Manager : Employee
{
    public void Calculator()
    {
        double grossSalary = 0;
        double basic = 1500;
        double fuel = 250;
        double medical = 1000;
        grossSalary = basic + fuel + medical;
        Console.WriteLine("Gross Salary of Manager : $" + grossSalary);
    }
}
public class Analyst : Employee
{
    public void Calculator()
    {
        double grossSalary = 0;
        double basic = 1500;
        double fuel = 150;
        double medical = 800;
        grossSalary = basic + fuel + medical;
        Console.WriteLine("Gross Salary of Analyst : $" + grossSalary);
    }
}