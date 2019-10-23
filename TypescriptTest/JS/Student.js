var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Student = /** @class */ (function (_super) {
    __extends(Student, _super);
    function Student(firstname, lastname, age, grade, teacher) {
        var _this = _super.call(this, firstname, lastname, age) || this;
        _this.firstname = firstname;
        _this.lastname = lastname;
        _this.age = age;
        _this.grade = grade;
        _this.teacher = teacher;
        _this.Grade = grade;
        _this.Teacher = teacher;
        return _this;
    }
    Student.prototype.Show = function () {
        document.getElementById("Main").innerHTML += this.FirstName;
        document.getElementById("Main").innerHTML += this.LastName;
        document.getElementById("Main").innerHTML += this.Age;
        document.getElementById("Main").innerHTML += this.Grade;
    };
    return Student;
}(Person));
