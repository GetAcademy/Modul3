var Kurs = /** @class */ (function () {
    function Kurs(name, teacher, description) {
        this.name = name;
        this.teacher = teacher;
        this.description = description;
        this.Name = name;
        this.Teacher = teacher;
        this.Description = description;
        this.Students = [];
    }
    Kurs.prototype.Show = function () {
        var Me = this;
        for (var i = 0; i < 3; i++) {
            console.log(i);
            Me.Students[i].Show();
        }
    };
    return Kurs;
}());
