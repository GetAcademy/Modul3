var app5 = angular.module('app5', ["ngRoute"]);

app5.config(function($routeProvider) {
    $routeProvider
    .when("/", {
      templateUrl : "AngularTest1.html",
      controller : "Control1"
    })
    .when("/Test1", {
      templateUrl : "FirstRoute.htm"
    })
    .when("/Test2", {
      templateUrl : "AngularTest2.html",
      controller : "Control2", "BadMoodControl" : "GoodMoodControl"
    })
    .when("/Test3", {
      templateUrl : "AngularTest3.html",
      controller : "ListControl"
    })
    .otherwise({
        template : "<h1>None</h1><p>Nothing has been selected</p>"
      });
  });

  app5.controller('Control1', function($scope){
    $scope.first = 1;
    $scope.second = 1;

    $scope.imgSource = 'https://eng.beithillel.org.il/wp-content/uploads/2016/03/protected-area.jpg';

    $scope.updateValue = function () {
        $scope.calculation = `${$scope.first} + ${$scope.second} = ${$scope.first + $scope.second}`;
    };
});

app5.controller('Control2', function($scope){
    $scope.randomNum1 = Math.floor((Math.random()*10)+1);
    $scope.randomNum2 = Math.floor((Math.random()*10)+1);
    $scope.img = 'https://vuejs.org/images/logo.png';
});

app5.controller('BadMoodControl',function($scope){
    var BadFeelings = ['Unimportant', 'Disregarded', 'Grumpy', 'Angry'];
    $scope.bad = BadFeelings[Math.floor(Math.random()*4)];
});

app5.controller('GoodMoodControl',function($scope){
    var GoodFeelings = ['Satisfied', 'Joyfull', 'Excited', 'Relevant'];
    $scope.good = GoodFeelings[Math.floor(Math.random()*4)];
});

app5.controller('ListControl', function($scope){
    $scope.Groceries = [
        {Item: "Tomatoes", Purchase: false},
        {Item: "Potatoes", Purchased: false},
        {Item: "Grenades", Purchased: false},
        {Item: "Socks", Purchased: false},
    ];

$scope.GetList = function(){
return $scope.ShowList ? "GroceryList.html" : "OrderedGroceryList.html";
};
});

app5.controller('EventControl', function($scope){
    $scope.blur = 0;
    });