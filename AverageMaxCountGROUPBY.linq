<Query Kind="Program">
  <Namespace>System</Namespace>
  <Namespace>System.Collections.Generic</Namespace>
  <Namespace>System.IO</Namespace>
  <Namespace>System.Linq</Namespace>
</Query>


public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
{
	var result = new Dictionary<string, int>();

	var groupedCompanies = employees.GroupBy(x => x.Company, x => x.Age, (x, elem) => new { x, elem });

	foreach (var element in groupedCompanies)
	{
		result.Add(element.x, element.elem.Sum() / element.elem.Count());
	}
	return result;
}

public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
{
	var groupedEmpFromCompany = employees.GroupBy(comp => comp.Company, x => x.Company, (x, elements) => new { x, count = elements.Count() })
										 .ToDictionary(item => item.x, item => (int)item.count);
	return groupedEmpFromCompany;
}

public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
{
	var result = new Dictionary<string, Employee>();
	var groupedEmp = employees.GroupBy(x => x.Company, x => x, (x, elements) => new { x, elements });

	foreach (var group in groupedEmp)
	{
		var oldEmployeeByCompany = group.elements.Aggregate((max, next) => next.Age > max.Age ? next : max);
		result.Add(group.x, oldEmployeeByCompany);
	}
	return result;
}

public static void Main()
{
	var employees = new List<Employee>() {
		new Employee(){
			Age = 35,
			Company = "Endava",
			FirstName = "Ronni",
			LastName = "Papraniku"
		},
		new Employee(){
			Age = 30,
			Company = "Endava",
			FirstName = "Hana",
			LastName = "Maliqi"
		},
		new Employee(){
			Age = 20,
			Company = "Endava",
			FirstName = "Lisa",
			LastName = "Papraniku"
		},
		new Employee(){
			Age = 50,
			Company = "SimCorp",
			FirstName = "Nina",
			LastName = "Papra"
		},
		new Employee(){
			Age = 30,
			Company = "ITGMA",
			FirstName = "Grida",
			LastName = "Papra"
		},
	};

	foreach (var emp in AverageAgeForEachCompany(employees))
	{
		Console.WriteLine($"The average age for company {emp.Key} is {emp.Value}");
	}

	foreach (var emp in CountOfEmployeesForEachCompany(employees))
	{
		Console.WriteLine($"The count of employees for company {emp.Key} is {emp.Value}");
	}

	foreach (var emp in OldestAgeForEachCompany(employees))
	{
		Console.WriteLine($"The oldest employee of company {emp.Key} is {emp.Value.FirstName} {emp.Value.LastName} having age {emp.Value.Age}");
	}
}

public class Employee
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public int Age { get; set; }
	public string Company { get; set; }
}
