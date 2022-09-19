var app = angular.module('myApp', ['treeview']);
app.controller('treeController', ['$scope', '$http', function ($scope, $http) {
    console.log($http);
    $http.get('/home/GetFileStructure').then(function (response) {
        $scope.List = response.data;
        $scope.mytree.currentNode = $scope.List[0].children[0];
    })
    
    $scope.$watch( 'mytree.currentNode', function( newObj, oldObj ) {
        if( $scope.mytree && angular.isObject($scope.mytree.currentNode) ) {
            console.log( $scope.mytree.currentNode );
        }
    }, false)
}])