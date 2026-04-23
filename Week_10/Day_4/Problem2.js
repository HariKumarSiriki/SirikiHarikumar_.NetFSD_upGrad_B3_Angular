"use strict";
function getWelcomeMessage(name) {
    return "Welcome " + name;
}
function getUserInfo(name, age) {
    if (age !== undefined) {
        return name + " is " + age + " years old";
    }
    else {
        return name + " age not provided";
    }
}
function getSubscriptionStatus(name, isSubscribed = false) {
    if (isSubscribed) {
        return name + " is subscribed";
    }
    else {
        return name + " is not subscribed";
    }
}
function isEligibleForPremium(age) {
    return age > 18;
}
const getGreeting = (name) => {
    return "Hello " + name;
};
const notificationService = {
    appName: "MyApp",
    showMessage: (user) => {
        console.log(user + " welcome to " + notificationService.appName);
    }
};
console.log(getWelcomeMessage("Hari"));
console.log(getUserInfo("Hari", 22));
console.log(getUserInfo("Hari"));
console.log(getSubscriptionStatus("Hari", true));
console.log(getSubscriptionStatus("Hari"));
console.log(isEligibleForPremium(22));
console.log(getGreeting("Hari"));
notificationService.showMessage("Hari");
