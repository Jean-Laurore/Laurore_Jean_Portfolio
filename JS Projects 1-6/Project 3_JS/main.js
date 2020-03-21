console.log("**** Welcome to my Shopping Cart Calculator ****");
let userInput = prompt("\r\nPlease type in the cost for your PC:");

var userDicountAmount = 15;
var userStateInput = "Florida";
var userSaleTax = 0.06;
var userSaleTax2 = 0.10;


let userDiscount = prompt("\r\nWould you like to see if you qualify for a discount? Please type Yes or No.");

var pcTotal = userInput - userDicountAmount;
var pcTotal2 = pcTotal * userSaleTax;
var pcTotal3 = pcTotal2 + pcTotal;

var otherStateTotal = pcTotal;
var otherStateTotal1 = otherStateTotal * userSaleTax2;
var otherStateTotal2 = otherStateTotal1 + otherStateTotal;

//Conditional
if(userDiscount === "yes" || userDiscount === "YES")
{
  console.log("\r\n15% off your item.");
  let userStateInput = prompt("\r\nPlease type in the state you live in:");

  //if user type Florida
  if(userStateInput === "Florida" || userStateInput === "florida")
  {
    console.log("Your sale tax will be 6%.");
    console.log("Total cost of PC is: " + userInput);
    console.log("Total cost of PC with discount is: " + pcTotal);
    console.log("Total cost of PC with discount and sale tax is: " + pcTotal3);
    console.log("GrandTotal cost for Floridian is: " + pcTotal3);
  }
  // if user input Other State
  else
  {
      console.log("Your sale tax is 10%");
      console.log("Total cost of PC is: " + userInput);
      console.log("Total cost of PC with discount is: " + pcTotal);
      console.log("GrandTotal cost for other states is: " + otherStateTotal2);
  }
}

if(userDiscount === "no" || userDiscount === "No")
{
  Console.WriteLine("No discount applied.");
  let userStateInput = prompt("\r\nPlease type in the state you live in:");

  if(userStateInput === "Florida" || userStateInput === "florida")
  {
    console.log("Your sale tax will be 6%.");
    console.log("Total cost of PC is: " + userInput);
    console.log("Total cost of PC with discount is: " + pcTotal);
    console.log("Total cost of PC with discount and sale tax is: " + pcTotal3);
    console.log("GrandTotal cost for Floridian is: " + pcTotal3);
  }
  else
  {
      console.log("Your sale tax is 10%");
      console.log("Total cost of PC is: " + userInput);
      console.log("Total cost of PC with discount is: " + pcTotal);
      console.log("GrandTotal cost for other states is: " + otherStateTotal2);
  }
}

console.log("\r\nThanks for using my program!");