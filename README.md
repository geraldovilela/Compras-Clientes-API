#COMPRAS-CLIENTES-API
- Cadastro de Usuários

[ ]Não é permitido cadastrar mais de um usuario com o mesmo e-mail

[ ]Não é permitido cadastrar usuario sem e-mail

[ ]O cliente tem as propriedades nome e e-mail.

[ ]Um cliente pode estar relacionado à múltiplas compras

- Cadastro de Compras por Cliente

[ ]A entidade Compra tem pelo menos dois campos: Preço e CriadoEm.
  
[ ]Não é permitido cadastrar compras para usuarios invalidos.

[ ]O usuario precisa estar autenticado na aplicação para realizar a compra.

A aplicação deve expor pelo menos os endpoints para as seguintes tarefas:
-	Retornar uma lista de clientes, sem ordems.
-	Retornar um cliente específico com suas ordens.
-	Adicionar uma nova ordem para um cliente existente.
-	Adicionar um novo cliente.
