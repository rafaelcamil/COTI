//criando o aplicativo Angular para SPA..
//mapear os endereços de rotas do projeto..
//$routeProvider -> objeto do Angular-Route para 
//mapeamento de rotas (endereços de páginas)
app.config(function ($routeProvider) {

    $routeProvider
        .when(
            '/setor/cadastro', //ROTA
            {
                templateUrl: '/App/Views/Setor/cadastro.html',
                controller: 'setorCadastroController'
            }
        )
        .when(
            '/setor/consulta', //ROTA
            {
                templateUrl: '/App/Views/Setor/consulta.html',
                controller: 'setorConsultaController'
            }
        )
        .when(
            '/funcao/cadastro', //ROTA
            {
                templateUrl: '/App/Views/Funcao/cadastro.html',
                controller: 'funcaoCadastroController'
            }
        )
        .when(
            '/funcao/consulta', //ROTA
            {
                templateUrl: '/App/Views/Funcao/consulta.html',
                controller: 'funcaoConsultaController'
            }
        )
        .when(
            '/funcionario/cadastro', //ROTA
            {
                templateUrl: '/App/Views/Funcionario/cadastro.html',
                controller: 'funcionarioCadastroController'
            }
        )
        .when(
            '/funcionario/consulta', //ROTA
            {
                templateUrl: '/App/Views/Funcionario/consulta.html',
                controller: 'funcionarioConsultaController'
            }
        );
});

//configurar os endereços das rotas
app.config(function ($locationProvider) {
    $locationProvider.hashPrefix('');
});
