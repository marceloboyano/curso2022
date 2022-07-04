
var a = 1;
var b = 1.22;


string[] employees = { "Joe", "Bob", "Carol", "Alice", "Will" };

IEnumerable<string> employeeQuery = from person in employees
                                    orderby person descending
                                    select person;

foreach (string employee in employeeQuery)
{
    Console.WriteLine(employee);
}