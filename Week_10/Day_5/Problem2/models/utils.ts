import { Student } from "./student.model";


export function formatName(name: string): string {
  return name.toUpperCase();
}


export function calculateAverage(students: Student[]): number {
  let total = 0;

  for (let s of students) {
    total = total + s.marks;
  }

  return total / students.length;
}