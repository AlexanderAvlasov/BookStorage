var myApp = angular.module('myApp', []);

myApp.controller('AdminController', ['$scope', async function AdminController($scope) {
    $scope.newBook = {};
    $scope.refresBooks = async function () {
        $scope.books = await (await fetch('https://localhost:44310/api/Books/GetBookList')).json();
        $scope.$apply();
    }
    $scope.refresBooks();

    $scope.addNewBook = function () {
        fetch("/api/Books/AddNewBook", {
            method: "POST", body: JSON.stringify($scope.newBook), headers: {
                'Content-Type': 'application/json'
            }}).then((resp) =>  {
                alert("saved status:" + resp.status);
                $scope.newBook = {};
                $scope.refresBooks();
            });
    }
}]);


