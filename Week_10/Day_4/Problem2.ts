
function getWelcomeMessage(name: string): string {
  return "Welcome " + name;
}


function getUserInfo(name: string, age?: number): string {
  if (age !== undefined) {
    return name + " is " + age + " years old";
  } else {
    return name + " age not provided";
  }
}


function getSubscriptionStatus(name: string, isSubscribed: boolean = false): string {
  if (isSubscribed) {
    return name + " is subscribed";
  } else {
    return name + " is not subscribed";
  }
}


function isEligibleForPremium(age: number): boolean {
  return age > 18;
}

const getGreeting = (name: string): string => {
  return "Hello " + name;
};


const notificationService = {
  appName: "MyApp",

  showMessage: (user: string): void => {
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