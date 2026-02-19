function checkSignal() {

    
    let signal = "red";

    let message = "";

   
    switch (signal) {
        case "red":
            message = "Stop";
            break;

        case "yellow":
            message = "Get Ready";
            break;

        case "green":
            message = "Go";
            break;

        default:
            message = "Invalid Signal Color";
    }

  //this line shows the result on the webpage
    document.getElementById("result").innerHTML = message;

    // this Show in console
    console.log(message);
}
