function calculateDiscount() {

   
    let amount = 4500;
    let discount = 0;
    let finalAmount = 0;

   
    if (amount >= 5000) {
        discount = amount * 0.20;
    }
    else if (amount >= 3000) {
        discount = amount * 0.10;
    }
    else {
        discount = 0;
    }

   
    finalAmount = amount - discount;

    // This will display result on the  webpage
    document.getElementById("result").innerHTML =
        "Purchase Amount: " + amount + "<br>" +
        "Discount price : " + discount + "<br>" +
        "Final Amount to pay : " + finalAmount;

    // we can use console.log to show using console tab
    console.log("Purchase Amount:", amount);
    console.log("Discount price:", discount);
    console.log("Final Amount to pay:", finalAmount);
}
