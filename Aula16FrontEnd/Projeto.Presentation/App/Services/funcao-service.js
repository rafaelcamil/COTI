//$http -> objeto utilizado para executar serviços REST
app.service('$funcaoService',
    function ($http) {

        //objeto para armazemar as funções que irão 
        //fazer chamadas aos serviços da API..
        var services = {};

        services.cadastrar = function (model) {
            return $http.post(host + "funcao/cadastrar", model);
        };

        services.atualizar = function (model) {
            return $http.put(host + "funcao/atualizar", model);
        };

        services.excluir = function (id) {
            return $http.delete(host + "funcao/excluir?id=" + id);
        };

        services.consultar = function () {
            return $http.get(host + "funcao/obtertodos");
        };

        services.obter = function (id) {
            return $http.get(host + "funcao/obterporid?id=" + id);
        };

        return services;
    });
