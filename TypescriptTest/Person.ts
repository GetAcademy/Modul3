class Person {
    FirstName: string;
    LastName: string;
    Age: number;
    constructor(public firstname: string, public lastname: string, public age: number){
        this.FirstName = firstname;
        this.LastName = lastname;
        this.Age = age;
    }
}