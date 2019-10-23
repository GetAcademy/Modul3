
var GetIt = new Kurs("GetIt", "Terje", "Et programmerings kurs som hovedsaklig tar for seg Backend og database delen av systemutviklingen og erfaring ute i bedrift gjennom utplassering");

GetIt.Students.push(
                    new Student("Henrik", "Bjørhall", 27, "A", GetIt.Teacher),
                    new Student("Patrick", "Johnsen", 24, "A", GetIt.Teacher),
                    new Student("Ibrahim", " ", 0, "A", GetIt.Teacher));




GetIt.Show();