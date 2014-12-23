(function () {
    'use strict';

    angular
        .module('employeeFormApp')
        .directive('employeeForm', employeeForm);
    
    function employeeForm() {
        return {
            restrict: 'E',
            templateUrl: 'app/EmployeeForm/efTemplate.html'
        }
    };
}());