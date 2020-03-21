class Person {
  constructor(){
    console.log("Person createdn");
    this.age = 0;
    this.name = "Bob";
  }
  speak() {
    return this.name +"I am " + this.age;
  }

}

class Student extends person{
  constructor(){
    super();
    console.log("Student Created");
    this.strudentID = 0;
    this.grades = [];
  }
        getAverageGrade(){
          let total = 0;
          this.grades.forEach(element => {
            
          });
        }
}

let student1 = new Student("Jamie");
student1.age = 21;
student1.grades = [70,80,90];
console.log(student1.getAverageGrade());
// let person = new Person();
// person.age = 21;
// console.log(person.speak());