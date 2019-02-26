app.controller('funcionarioCadastroController',
    function ($scope, $funcaoService, $funcionarioService, $setorService) {

        $scope.funcionario = {
            Nome: "", Salario: "", DataAdmissao: "", IdFuncao: "", IdSetor: ""
        }


        $scope.cadastrar = function () {
            $scope.mensagem = "Processando, aguarde..."

            $funcionarioService.cadastrar($scope.funcionario)
                .then(function (result) {
                    $scope.mensagem = "Funcionário " + result.data.Nome + " cadastrado com sucesso.";

                    $scope.funcionario = {};
                })
                .catch(function () {
                    if (e.status === 500) {
                        $scope.mensagem = e.responseText;
                    }
                    else if (e.status === 400) {
                        $scope.mensagem = "Ocorreram erros de validação";
                    }
                });
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