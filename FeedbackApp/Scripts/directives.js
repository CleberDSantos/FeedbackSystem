'use strict';

angular.module('app.directives', [])

    .directive('appVersion', ['version', function (version) {
        return function (scope, elm, attrs) {
            elm.text(version);
        };
    }])

    .directive('cardsPergunta', function () {

        return {
            restrict: 'AE',
            templateUrl: '/Views/Templates/cardTemplate.html',
            controller: 'FeedbackController'
        };

    });