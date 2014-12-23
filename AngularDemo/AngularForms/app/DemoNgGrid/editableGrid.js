(function () {
    'use strict';

    angular
        .module('demoNgGridApp')
        .controller('EditableGrid', EditableGrid);
    
    function EditableGrid($scope, $http) {
        $scope.gridOptions = {
            data: 'serverData',
            showGroupPanel: true,
            enableCellSelection: true,
            enableRowSelection: true,
            enableCellEditOnFocus: true,
            columnDefs: [
                { field: 'Name', displayName: 'Name', enableCellEdit: true }
            ]
        };
        $scope.serverData = [];

        //function fetchData() {
        //    $http({
        //        url: 'http://localhost/WebApi/api/programminglanguages', type: 'Get'
        //    })
        //    .success(function (data) { $scope.serverData = data; });
        //} fetchData();

        $scope.loadData = function () {
            $http({
                url: 'http://localhost/WebApi/api/programminglanguages', type: 'Get'
            })
           .success(function (data) { $scope.serverData = data; });
        };

        $scope.showEditedData = function () {
            alert("hello");
        };
    };
}());