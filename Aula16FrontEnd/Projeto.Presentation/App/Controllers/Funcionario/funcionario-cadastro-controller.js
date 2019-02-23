app.controller('funcionarioCadastroController',
    function ($scope, $funcaoService, $funcionarioService, $setorService) {

        $scope.cadastrar = function () {
            $scope.mensagem = "Processando, aguarde..."
        };

        $scope.carregarSetores = function () {
            $setorService.consultar()
                .then(function (result) {
                    $scope.setores = result.data;
                })
                .catch(function (e) {
                    console.log(e);
                });

        };

        $scope.carregarFuncoes = function () {
            $funcaoService.consultar()
                .then(function (result) {
                    $scope.funcoes = result.data;
                })
                .catch(function (e) {
                    console.log(e);
                });

        };

    }

);