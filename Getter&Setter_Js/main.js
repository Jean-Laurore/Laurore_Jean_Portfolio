class Car{

constructor(brand) {
  this._carname = brand;
}
get carname() {
  return this._carname;
}
set carname(x) {
  this._carname = x;
}
}
mycar = new Car("Ford");
mycar.carname = "Volvo";
console.log(mycar.carname);