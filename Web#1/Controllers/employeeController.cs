using Microsoft.AspNetCore.Mvc;
using Web_1.Models;

namespace Web_1.Controllers;


[ApiController]
[Route("[controller]/[action]")]
public class employeeController : ControllerBase
    {
    public static List<Employee> Employeesdatabase = new List<Employee>();

    [HttpGet]
    public List<Employee> Get()
    {
        
        return Employeesdatabase;
    }
    [HttpPost]//Add
    public string Add(int Id,string Name , string lastname)
    {
        Employee employeeadd = new Employee();
        employeeadd.Id = 1;
        employeeadd.Name = "odai";
        employeeadd.Lastname = "alqutami";
            
    
        Employeesdatabase.Add(employeeadd);
        return "employee added" + " " + employeeadd.Name;
       
       
    }
    [HttpPut]//Update
    public string Update( Employee employee)
    {
        return "employee adede!" + " " + employee.Id + " " +employee.Name + " " + employee.Lastname;
    }
    [HttpDelete]//Delete
    public string Delete(int id)
    {
        foreach (Employee emp in Employeesdatabase)
        {
            if(emp.Id == id)
            {
                Employeesdatabase.Remove(emp);
                break;
            }
        }
        return "employee deleted!" + " " + id;
    }
}
