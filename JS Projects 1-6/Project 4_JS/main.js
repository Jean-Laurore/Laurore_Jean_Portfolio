console.log("\r\n***************************");
console.log("**** Welcome to My Theater ****");
console.log("*******************************");

var normalPrice = 12.00;
var priceDiscount = 7.00;

//Prompt the user
var userAge = prompt("\r\nPlease type in your age: ");
if(userAge < 10 || userAge >= 55)
{
  console.log("\r\nYour cost for your ticket is $" + priceDiscount);
}
else 
{
  console.log("\r\nYour cost for your ticket is $" + normalPrice);
}

console.log("\r\n*********************************");
console.log("**** Welcome to My Tire Pressure ****");
console.log("*************************************");

var userInput = prompt("\r\nPlease type your car first front tires pressure: ");
var userInput1 = prompt("\r\nPlease type your car second front tires pressure: ");

var userInput2 = prompt("\r\nPlease type your car first back tires pressure: ");
var userInput3 = prompt("\r\nPlease type your car second back tires pressure: ");

if (userInput == 30 && userInput1 == 30 && userInput2 == 30 && userInput3 == 30)
    {
      console.log("\r\nYour tires have met maintenance standards.");
    }
else
    {
      console.log("\r\nYour tires need specifications.");
    }

     console.log("\r\nThank you for using my program. Good Bye!");