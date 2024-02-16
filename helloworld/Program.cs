
namespace ClassObject {

  class Employee {

    string department;

    //methods
    public string getDepartment() {
      return department;
    }

    //employee can take leave
    public void takeLeave() {
      Console.WriteLine("Employee is on leave");
    }

    //employee can work
    public void work() {
      Console.WriteLine("Employee is at work");
    }

    //employee can take breakfast
    public void takeBreakfast() {
      Console.WriteLine("Employee is taking breakfast");
    }

    static void Main(string[] args) {

      // create Employee object 
      Employee sheeran = new Employee();

      // set department for sheeran
      sheeran.department = "Development";
      Console.WriteLine("Sheeran: " + sheeran.department);

      // create second object of Employee
      Employee taylor = new Employee();

      // set department for taylor
      taylor.department = "Content Writing";
      Console.WriteLine("Taylor: " + taylor.department);

        // call methods
        sheeran.takeLeave();

      Console.ReadLine();
    }
  }
}