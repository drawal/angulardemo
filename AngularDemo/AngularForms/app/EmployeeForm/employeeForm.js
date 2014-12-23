(function () {
    'use strict';

    angular
        .module('employeeFormApp')
        .controller('EmployeeForm', EmployeeForm);

    function EmployeeForm($scope, employeeFormService, $location) {

        $scope.employee = employeeFormService.employee;

        $scope.departments = [
            "Engineering",
            "Marketing",
            "Finance",
            "Administration"
        ];
        $scope.submitForm = function () {
            alert($location.absUrl());
        };
    };
}());