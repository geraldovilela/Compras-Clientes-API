#COMPRAS-CLIENTES-API
- Cadastro de Usuários

API foi montada visando uma implementação simples e solida, utilizando DDD e EF Core;

#### Para rodar o projeto após clonar rodar o comando docker-compose up na pasta raiz do projeto.

```
docker-compose up
```

[:white_check_mark:]Não é permitido cadastrar mais de um usuario com o mesmo e-mail

[:white_check_mark:]Não é permitido cadastrar usuario sem e-mail

[:white_check_mark:]O cliente tem as propriedades nome e e-mail.

[:white_check_mark:]Um cliente pode estar relacionado à múltiplas compras

- Cadastro de Compras por Cliente

[:white_check_mark:]A entidade Compra tem pelo menos dois campos: Preço e CriadoEm.
  
[:white_check_mark:]Não é permitido cadastrar compras para usuarios invalidos.


#TODOS
- Testes unitarios.
- Authentication.
- adicionar middleware de errorhandling e trativa de exceções.
