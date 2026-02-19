function analyzeNumber() {

  
    let num = 8;  

    let output = "";

   //this is ternary operator if the number is positive prints"positive" or else "negative"
    let sign = (num >= 0) ? "Positive" : "Negative";
    output += "Number: " + num + "<br>";
    output += "Sign of the number : " + sign + "<br>";

   
    if (num % 2 === 0) {
        output = output + "Number is : Even<br>"; // this is one type of assigning
    } else {
        output += "Number is : Odd<br>"; // this is shorcut using Assignment Operators
    }

  
    output += "Numbers from 1 to " + num + "<br>";

    for (let i = 1; i <= num; i++) {
        output += i + " ";
    }

   
    document.getElementById("result").innerHTML = output;

    console.log("Sign:", sign);
}
