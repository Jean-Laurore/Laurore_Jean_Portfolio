//JavaScript Classes

class Car{
  constructor(brand) {
    this.carname = brand;
  }
  //Method
  present(){
    return "I have a " + this.carname;
  }
}
//object 
mycar = new Car("Ford");

//Inheritance
class Model extends Car{
  constructor(brand, mod) {
    super (brand);
    this.model = mod;
  }
  show() {
    return this.present() + ', it is a ' + this.model;
  }
}

mycar = new Model("Ford", "Mustang");
console.log(mycar.show());
