const userName: string = "Hari";   
let age: number = 22;             
const email: string = "hari@gmail.com";
const isSubscribed: boolean = true;

let city = "Vizag";   
let score = 90;       

age = age + 1;  

let message = `Hello ${userName}, you are ${age} years old and your email is ${email}`;

let isEligible = age > 18 && isSubscribed;  


console.log(message);
console.log("City:", city);
console.log("Score:", score);
console.log("Updated Age:", age);
console.log("Is Subscribed:", isSubscribed);
console.log("Eligible for Premium:", isEligible);