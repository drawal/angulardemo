(function () {
    'use strict';

    angular
        .module('demoNgGridApp')
        .controller('RegularGrid', RegularGrid);

    function RegularGrid($scope, $http) {
        $scope.gridOptions = {
            data: 'serverData',
            showGroupPanel: true
        };
        $scope.serverData = [];

        function fetchData() {
            $http({
                url: 'http://localhost/WebApi/api/displayitems', type: 'Get'
            })
            .success(function (data) { $scope.serverData = data; });
        } fetchData();

        $scope.loadData = function () {
            $http({
                url: 'http://localhost/WebApi/api/displayitems', type: 'Get'
            })
           .success(function (data) { $scope.serverData = data; });
        };

    };
}());