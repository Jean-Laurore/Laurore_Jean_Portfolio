//Json
//Key: Value
// "Key": "value"
//JavaScript Object
//Key: "Value

var myCars = {
  "name":"Emanie",
  "age":"35",
  "cars":{
    "car1":"Mercedes",
    "car2":"BMW",
    "car3":"Honda"
  }
}

console.log(myCars.cars.car2);

//Json with array
var moreCars = {
  "dealership":"Curry Auto",
  "location":"White Plains, NY",
  "Cars":[
    {"name":"Ford", "model":"mustange"},
    {"make":"Toyota", "model":"hightlander"},
    {"make":"Honda", "model":"accord"}
  ]
}
console.log(moreCars.Cars[1].make);