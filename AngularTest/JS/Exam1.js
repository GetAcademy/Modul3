var app1 = angular.module('app1', []);

app1.controller('Control1', function($scope){
    $scope.first = 1;
    $scope.second = 1;

    $scope.imgSource = 'https://eng.beithillel.org.il/wp-content/uploads/2016/03/protected-area.jpg';

    $scope.updateValue = function () {
        $scope.calculation = `${$scope.first} + ${$scope.second} = ${$scope.first + $scope.second}`;
    };
});