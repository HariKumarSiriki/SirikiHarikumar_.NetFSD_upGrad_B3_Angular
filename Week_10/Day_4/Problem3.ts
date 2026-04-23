class Employee {
  public id: number;
  protected name: string;
  private salary: number;

  
  constructor(id: number, name: string, salary: number) {
    this.id = id;
    this.name = name;
    this.salary = salary;
  }


  get Salary(): number {
    return this.salary;
  }


  setSalary(value: number): void {
    if (value > 0) {
      this.salary = value;
    } else {
      console.log("Invalid salary");
    }
  }


  displayDetails(): void {
    console.log("Employee Details:");
    console.log("ID:", this.id);
    console.log("Name:", this.name);
    console.log("Salary:", this.salary);
    console.log();
  }
}


class Manager extends Employee {
  teamSize: number;

  constructor(id: number, name: string, salary: number, teamSize: number) {
    super(id, name, salary);
    this.teamSize = teamSize;
  }


  displayDetails(): void {
    console.log("Manager Details:");
    console.log("ID:", this.id);
    console.log("Name:", this.name);
    console.log("Team Size:", this.teamSize);
    console.log("Salary:", this.getSalary());
  }
}


let emp = new Employee(1, "Hari", 50000);
emp.displayDetails();

let mgr = new Manager(2, "Scott", 80000, 5);
mgr.displayDetails();