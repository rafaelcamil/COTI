//$http -> objeto utilizado para executar serviços REST
app.service('$setorService',
    function ($http) {

        //objeto para armazemar as funções que irão 
        //fazer chamadas aos serviços da API..
        var services = {};

        services.cadastrar = function (model) {
            return $http.post(host + "setor/cadastrar", model);
        };

        services.atualizar = function (model) {
            return $http.put(host + "setor/atualizar", model);
        };

        services.excluir = function (id) {
            return $http.delete(host + "setor/excluir?id=" + id);
        };

        services.consultar = function () {
            return $http.get(host + "setor/obtertodos");
        };

        services.obter = function (id) {
            return $http.get(host + "setor/obterporid?id=" + id);
        };

        return services;
    });
