//$http -> objeto utilizado para executar serviços REST
app.service('$funcionarioService',
    function ($http) {

        //objeto para armazemar as funções que irão 
        //fazer chamadas aos serviços da API..
        var services = {};

        services.cadastrar = function (model) {
            return $http.post(host + "funcionario/cadastrar", model);
        };

        services.atualizar = function (model) {
            return $http.put(host + "funcionario/atualizar", model);
        };

        services.excluir = function (id) {
            return $http.delete(host + "funcionario/excluir?id=" + id);
        };

        services.consultar = function () {
            return $http.get(host + "funcionario/obtertodos");
        };

        services.obter = function (id) {
            return $http.get(host + "funcionario/obterporid?id=" + id);
        };

        return services;
    });
