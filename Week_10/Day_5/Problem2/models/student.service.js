export function getGrade(marks) {
    if (marks >= 75) {
        return "A";
    }
    else if (marks >= 50) {
        return "B";
    }
    else if (marks >= 40) {
        return "C";
    }
    else {
        return "Fail";
    }
}
export function getTopper(students) {
    let top = students[0];
    for (let s of students) {
        if (s.marks > top.marks) {
            top = s;
        }
    }
    return top;
}
