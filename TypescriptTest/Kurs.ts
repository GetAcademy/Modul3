
class Kurs {
    Students: Student[];
    Teacher: string;
    Name: string;
    Description: string;
    constructor(public name: string, public teacher: string, public description: string){
        this.Name = name;
        this.Teacher = teacher;
        this.Description = description;
        this.Students = [];
    }
    Show():void {
        const Me = this;
        for(let i = 0; i < Me.Students.length; i++){
            console.log(i);
            Me.Students[i].Show();
        }
    }
}