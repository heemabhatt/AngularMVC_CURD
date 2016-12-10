//Angular Code
var MyApp = angular.module("MyApp", []);
MyApp.controller('EmployeeCtrl', function ($scope,$http) {
    $scope.employees = "";
    $http.get("/Employee/GetAllEmployees")
        .success(function (result) {
            $scope.employees = result;
        })
        .error(function (result) {
            console.log(result);
        });

    $scope.saveData = function (employee) {
       
        $http.post("/Employee/AddEmployee", { Emp1: employee })
            .success(function(result){
                $scope.employees = result;
                $scope.employee = "";//
            })
            .error(function(result){
                console.log(result);
            });
    }
    $scope.employee = "";
    $scope.selectEmployee = function (Id) {
        $http.post("/Employee/GetEmployeeById", { id1: Id })
           .success(function (result) {
               $scope.employee = result;

           })
           .error(function (result) {
               console.log(result);
           });
    }
   
    $scope.updateData = function (employee) {

        $http.post("/Employee/UpdateEmployee", { Emp1: employee })
            .success(function (result) {
                $scope.employees = result;
                $scope.employee = "";//
            })
            .error(function (result) {
                console.log(result);
            });
    }

    $scope.deleteEmployee = function (Id) {
        $http.post("/Employee/DeleteEmployee", { id1: Id })
           .success(function (result) {
               $scope.employees = result;
              
           })
           .error(function (result) {
               console.log(result);
           });
    }
});