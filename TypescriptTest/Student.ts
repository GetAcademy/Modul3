

class Student extends Person{
    Grade: string;
    Teacher: string;
    constructor(public firstname: string, public lastname: string, public age: number, public grade: string, public teacher: string){
        super(firstname,lastname,age);
        this.Grade = grade;
        this.Teacher = teacher;
    }
    Show():void{
        document.getElementById("Main").innerHTML += this.FirstName;
        document.getElementById("Main").innerHTML += this.LastName;
        document.getElementById("Main").innerHTML += this.Age;
        document.getElementById("Main").innerHTML += this.Grade;
    }
}