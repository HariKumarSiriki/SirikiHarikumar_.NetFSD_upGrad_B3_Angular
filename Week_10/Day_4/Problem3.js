"use strict";
class Employee {
    id;
    name;
    salary;
    constructor(id, name, salary) {
        this.id = id;
        this.name = name;
        this.salary = salary;
    }
    getSalary() {
        return this.salary;
    }
    setSalary(value) {
        if (value > 0) {
            this.salary = value;
        }
        else {
            console.log("Invalid salary");
        }
    }
    displayDetails() {
        console.log("Employee Details:");
        console.log("ID:", this.id);
        console.log("Name:", this.name);
        console.log("Salary:", this.salary);
        console.log();
    }
}
class Manager extends Employee {
    teamSize;
    constructor(id, name, salary, teamSize) {
        super(id, name, salary);
        this.teamSize = teamSize;
    }
    displayDetails() {
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
