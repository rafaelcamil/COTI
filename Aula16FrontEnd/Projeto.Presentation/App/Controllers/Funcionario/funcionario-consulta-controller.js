app.controller('funcionarioConsultaController',
    function ($scope, $funcaoService, $setorService, $funcionarioService) {
        
        $scope.consultarFuncionarios = function () {
            
            $funcionarioService.consultar()
                .then(function (result) {                                         
                    $scope.funcionarios = result.data;
                })
                .catch(function (e) { 
                    console.log(e);
                });
        };        

    });