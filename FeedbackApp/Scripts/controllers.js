﻿'use strict';

// Google Analytics Collection APIs Reference:
// https://developers.google.com/analytics/devguides/collection/analyticsjs/



angular.module('app.controllers', ['underscore'])

    // Path: /
    .controller('HomeCtrl', ['$scope', '$location', '$window', function ($scope, $location, $window) {
        $scope.$root.title = 'AngularJS SPA Template for Visual Studio';
        $scope.$on('$viewContentLoaded', function () {
            $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
        });
    }])

    .controller('FeedbackController', ['$scope', '$location', '$window','_', function ($scope, $location, $window, _) {

        $scope.categorias = [];

        var excelente = {

            inicial: 96,
            final: 100,
            smiles: ["r1_c18", "r1_c16", "r19_c19"],
            up: true
        }

        var otimo = {

            inicial: 76,
            final: 95,
            smiles: ["r5_c14", "r1_c14", "r5_c22", "r2_c6"],
            up: true
        }

        var bom = {

            inicial: 51,
            final: 75,
            smiles: ["r17_c2", "r19_c3", "r19_c15", "r2_c20", "r2_c2", "r2_c6"],
            up: true
        }

        var regular = {

            inicial: 31,
            final: 51,
            smiles: ["r7_c6", "r7_c2", "r7_c10", "r7_c14", "r11_c22", "r9_c14", "r7_c14", "r13_c18", "r9_c22", "r17_c10", "r19_c7"],
            up: false
        }

        var ruim = {

            inicial: 16,
            final: 30,
            smiles: ["r21_c18", "r13_c2", "r11_c14", "r11_c10", "r11_c6", "r13_c6", "r9_c18", "r7_c16"],
            up: false
        }

        var pessimo = {

            inicial: 6,
            final: 15,
            smiles: ["r13_c6", "r13_c10", "r7_c18", "r15_c10", "r21_c14", "r11_c2", "r7_c20"],
            up: false
        }

        var horrivel = {

            inicial: 0,
            final: 5,
            smiles: ["r15_c2", "r7_c22", "r13_c18", "r5_c18", "r21_c6", "r23_c11"],
            up:false
        }


        $scope.categorias.push(excelente,otimo,bom,regular,ruim,pessimo,horrivel);

        $scope.questoes = [];

        var questao = {
            imagem: "Cards.fw_r2_c2.png",
            slider: 50,
            titulo: "Comportamental",
            conteudo: "Cometi alguns erros no passado, uma delas é que sem perceber acabava sendo imersivo em assuntos do qual não estava sendo consultado. Coloquei como meta, a redução desses incidentes. como estou indo?",
            smileBom: "",
            smileMau: ""

        };


        var questao2 = {
            imagem: "lideranca.png",
            slider: 50,
            titulo: "Liderança",
            conteudo: "Vendo o Profissional que sou hoje, se fosse nomeado como seu líder, você se sentiria confortável? Mostre-me qual seria seu sentimento?",
            smileBom: "",
            smileMau: ""

        };


        var questao3 = {
            imagem: "confianca-tecnica.png",
            slider: 50,
            titulo: "Confiança técnica",
            conteudo: "Digamos que fechamos um novo projeto .NET extremamente estratégico, e você foi escolhido para montar a equipe de dois Desenvolvedores. Qual seria a probabilidade de você me escolher?",
            smileBom: "",
            smileMau: ""

        };


        var questao4 = {
            imagem: "senso-urgencia.png",
            slider: 50,
            titulo: "Senso de urgência",
            conteudo: "Digamos que durante uma reunião, surgiu uma atividade que precisa ser resolvida com extrema urgência e um atraso poderia afetar diretamente em nossa remuneração variável. Essa atividade foi direcionada para eu resolver. Em sua opinião, qual seria a chance dessa tarefa atrasar?",
            smileBom: "",
            smileMau: ""

        };


        var questao5 = {
            imagem: "mentoria.png",
            slider: 50,
            titulo: "Mentoria",
            conteudo: "De dois meses até os dias atuais, eu demonstrei algo para você que agregou valor em sua carreira profissional? Como se sente quanto a isso?",
            smileBom: "",
            smileMau: ""

        };


        var questao6 = {
            imagem: "qualidade.png",
            slider: 50,
            titulo: "Qualidade",
            conteudo: "Busquei como meta reduzir quantidade de erros e melhorar minha qualidade de código. Qual sua reação quando ler um código desenvolvido por mim recentemente?",
            smileBom: "",
            smileMau: ""

        };


        $scope.questoes.push(questao, questao2, questao3, questao4, questao5, questao6);

        $scope.ProcessarSmiles = function (questao) {
            var valor = parseInt(questao.slider);


            if(valor % 2 != 0){
                return;
            }

            var categoria = _.filter($scope.categorias, function (categoria) {

                return (valor >= categoria.inicial && valor <= categoria.final)
            });


            questao.smileBom = "";
            questao.smileMau = "";

            if (categoria[0].up) {
                questao.smileBom = categoria[0].smiles[Math.floor(Math.random() * categoria[0].smiles.length)];
            }
            else {
                questao.smileMau = categoria[0].smiles[Math.floor(Math.random() * categoria[0].smiles.length)];
            }

        }


    }])

    // Path: /error/404
    .controller('Error404Ctrl', ['$scope', '$location', '$window', function ($scope, $location, $window) {
        $scope.$root.title = 'Error 404: Página não encontrada';
        $scope.$on('$viewContentLoaded', function () {
            $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
        });
    }])
   