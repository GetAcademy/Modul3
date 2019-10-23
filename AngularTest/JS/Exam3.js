var app3 = angular.module('app3',[]);

app3.controller('ListControl', function($scope){
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