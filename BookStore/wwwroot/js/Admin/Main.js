var myApp = angular.module('myApp', []);

myApp.controller('AdminController', ['$scope', async function AdminController($scope) {
    $scope.books = await (await fetch('https://localhost:44310/api/Books/GetBookList')).json();
       $scope.$apply();
    }]);

