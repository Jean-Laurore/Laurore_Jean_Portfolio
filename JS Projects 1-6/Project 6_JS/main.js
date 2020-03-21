console.log("********************************");
console.log("**** Welcome to Shirt Size! ****");
console.log("********************************");

var userInput = prompt("\r\nPlease enter your shirt size: ");
console.log("Notes: Only type S, M, L OR XL. Thank You!");

ValidatingString(userInput);

ShirtSizes(userInput);

function ShirtSizes(userInput)
{
  var sizes = ["s", "s", "l", "m", "l", "s", "m", "l", "xl", "l", "m", "s"];
  var smallCountSize = 0;
  var mediumCountSize = 0;
  var largeCountSize = 0;
  var xLargeCountSize = 0;

  for (var i = 0; i < sizes.length; i++)
  {
    if (sizes[i] == "s")
    {
        smallCountSize++;

    }

    else if (sizes[i] == "m")
    {
        mediumCountSize++;

    }

    else if (sizes[i] == "l")
    {
        largeCountSize++;

    }

    else if (sizes[i] == "xl")
    {
        xLargeCountSize++;

    }
    else
    {
        Console.WriteLine("Wrong Input");
    }
  }
  console.log("Only " + smallCountSize + " Small Shirt(s) available.");
  console.log("Only " + mediumCountSize + " Medium Shirt(s) available.");
  console.log("Only " + largeCountSize + " Large Shirt(s) available.");
  console.log("Only " + xLargeCountSize + " XL Shirt(s) available.");
}

//funtion validating string
function ValidatingString(userString)
{
  while(userString === "")
  {
    userString = prompt("Error! Please try again!");
  }
  return userString;
}
