var app2 = angular.module('app2',[]);

app2.controller('Control1', function($scope){
    $scope.randomNum1 = Math.floor((Math.random()*10)+1);
    $scope.randomNum2 = Math.floor((Math.random()*10)+1);
});

app2.controller('BadMoodControl',function($scope){
    var BadFeelings = ['Unimportant', 'Disregarded', 'Grumpy', 'Angry'];
    $scope.bad = BadFeelings[Math.floor(Math.random()*4)];
});

app2.controller('GoodMoodControl',function($scope){
    var GoodFeelings = ['Satisfied', 'Joyfull', 'Excited', 'Relevant'];
    $scope.good = GoodFeelings[Math.floor(Math.random()*4)];
});