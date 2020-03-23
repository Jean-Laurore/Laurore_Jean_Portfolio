  class Car{
    constructor(brand) {
      this.carname = brand;
    }
    //Method this will call automatically
    present(){ 
      return "I have a " + this.carname;
    }
  }
  //instantiating parent object  class
  mycar = new Car("Volks");
  
  //Inheritance inherits all the methods from another class
  class Model extends Car{
    constructor(brand, mod) {
      super (brand);
      this.model = mod;
    }
    show() {
      return this.present() + ', it is a ' + this.model;
    }
  }
  
  mycar = new Model("Volks", "Jetta");
  console.log(mycar.show());

