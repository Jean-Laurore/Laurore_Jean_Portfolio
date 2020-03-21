var userInput;
var userInput2;
var userOperator;
var operatorEnter;
var inputNumber;
var inputNumber2;
var result;

var userInput = Number(prompt("\r\nPlease enter your number: "))

inputNumber = ValidateString(userInput);

console.log("\r\nYou have enter the number: " + userInput);

var userInput2 = Number(prompt("\r\nPlease enter another number: "));
//validate
inputNumber2 = ValidateString(userInput2);

//ask user for an operator
var userOperator = prompt("\r\nPlease enter your operation ( *, /, +, -): ");
//validate
operatorEnter = ValidateString(userOperator);

console.log("\r\nYou have enter " + userOperator);

//Invoke
result = GetFinal(userOperator, inputNumber, inputNumber2);

console.log("\r\nThanks, bye now!");


//Methods
function ValidateDouble(userNumber)
{
  while(isNaN(userNumber) || userNumber == "")
  {
    userNumber = prompt("\r\nError! Please type a valid number. ");
  }
  return userNumber;
}

function ValidateString(userString)
{
  while(userString === "")
  {
    userString = prompt("\r\nError! Please enter an operator:");
  }
  return userString;
}

function GetFinal(op, num1, num2)
{
  var answer = 0;
  //Conditional
  if (op == "*")
  {
     // double answer;
      answer = num1 * num2;
      console.log("\r\nYour total is: " + answer);
      return answer;

  }
  else if (op == "/")
  {
      //double answer;
      answer = num1 / num2;
      console.log("\r\nYour total is: " + answer);
      return answer;
  }
  else if (op == "+")
  {
      //double answer;
      answer = num1 + num2;
      console.log("\r\nYour total is: " + answer);
      return answer;
  }
  else if (op == "-")
  {
      //double answer;
      answer = num1 - num2;
      console.log("\r\nYour total is: " + answer);
      return answer;
  }
  else
  {
      console.log("Wrong Operator! ");
  }
  return answer;
}