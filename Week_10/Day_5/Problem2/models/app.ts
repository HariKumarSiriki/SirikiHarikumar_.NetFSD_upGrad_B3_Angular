import { Student } from "./student.model.js";
import { getGrade, getTopper } from "./student.service.js";
import { formatName, calculateAverage } from "./utils.js";
import { PASS_MARKS } from "./constants.js";


let students: Student[] = [
  { id: 1, name: "hari", marks: 80 },
  { id: 2, name: "scott", marks: 60 },
  { id: 3, name: "kiran", marks: 35 }
];


for (let s of students) {
  console.log("Name:", formatName(s.name));
  console.log("Marks:", s.marks);
  console.log("Grade:", getGrade(s.marks));
  console.log("Pass Marks:", PASS_MARKS);
  console.log("------------------");
}


console.log("Average Marks:", calculateAverage(students));


let topper = getTopper(students);
console.log("Topper:", topper.name);