# Plano de Testes de Software

 
| **Caso de Teste** 	| **CT-01 – Criar conta** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-01 - A aplicação deve apresentar a funcionalidade de cadastro de usuários. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://github.com/ICEI-PUC-Minas-PMV-ADS/Letra-Independente/tree/main/src/index.html<br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, nome, sobrenome, senha, confirmação de senha) <br> - Clicar em "Cadastrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-02 – Efetuar login**	|
|Requisito Associado | RF-02	- A aplicação deve deve permitir que os usuários cadastrados façam login. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://github.com/ICEI-PUC-Minas-PMV-ADS/Letra-Independente/tree/main/src/index.html<br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Entrar" |
|Critério de Êxito | - O login foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-03 – Favoritar artigo**	|
|Requisito Associado | RF-03	- A aplicação deve permitir que o usuário cadastrado favorite os artigos que desejar. |
| Objetivo do Teste 	| Verificar se o usuário consegue favoritar um artigo. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://github.com/ICEI-PUC-Minas-PMV-ADS/Letra-Independente/tree/main/src/index.html<br> - Fazer login na aplicação <br>  - Clicar em "Artigos" <br> - Acessar o artigo que desejar <br> - Clicar no ícone de favoritar (coração) |
|Critério de Êxito | - O artigo foi favoritado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-04 – Compartilhar artigo**	|
|Requisito Associado | RF-04	- A aplicação deve permitir o compartilhamento de artigos em redes sociais por usuários cadastrados ou não. |
| Objetivo do Teste 	| Verificar se o usuário consegue compartilhar o link do artigo. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://github.com/ICEI-PUC-Minas-PMV-ADS/Letra-Independente/tree/main/src/index.html<br>  - Clicar em "Artigos" <br> - Acessar o artigo que desejar <br> - Clicar no ícone de compartilhamento |
|Critério de Êxito | - O artigo foi compartilhado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-05 – Publicar artigo**	|
|Requisito Associado | RF-05	- A aplicação deve permitir que o escritor publique artigos.	 |
| Objetivo do Teste 	| Verificar se o escritor consegue publicar um artigo. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://github.com/ICEI-PUC-Minas-PMV-ADS/Letra-Independente/tree/main/src/index.html<br> - Fazer login na aplicação <br> - Clicar em "Artigos" <br> - Clicar em "Publicar um artigo" <br> - Preencher os campos obrigatórios (título, descrição, palavra-chave) |
|Critério de Êxito | - O artigo foi publicado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-06 – Gerenciar conta**	|
|Requisito Associado | RF-06	- A aplicação deve permitir que usuários cadastrados gerenciem sua conta personalizando o perfil com foto e uma breve biografia.	 |
| Objetivo do Teste 	| Verificar se o escritor consegue gerenciar sua conta. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://github.com/ICEI-PUC-Minas-PMV-ADS/Letra-Independente/tree/main/src/index.html<br> - Fazer login na aplicação <br> - Clicar em "Minha conta" <br> - Clicar em "Editar perfil" <br> - Realizar a alteração que desejar |
|Critério de Êxito | - O perfil foi alterado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-07 – Avaliar Artigo**	|
|Requisito Associado | RF-07	- A aplicação deve permitir que o usuário cadastrado expresse se entendeu ou não o artigo, por meio de um mecanismo de avaliação do tipo "entendi / não entendi".	 |
| Objetivo do Teste 	| Verificar se o usuário cadastrado consegue avaliar um artigo. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://github.com/ICEI-PUC-Minas-PMV-ADS/Letra-Independente/tree/main/src/index.html<br> - Fazer login na aplicação <br> - Clicar em "Artigos" <br> - Acessar o artigo que desejar <br> - Clicar em "Avaliar Texto" <br> - Marcar uma das opções de avaliação <br> - Inserir um comentário se desejar <br> - Clicar em "Concluir Avaliação" |
|Critério de Êxito | - O artigo foi avaliado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-08 – Exibir Relatório**	|
|Requisito Associado | RF-08	- A aplicação deve permitir que o escritor visualize um relatório das avaliações de cada texto por ele publicado.	 |
| Objetivo do Teste 	| Verificar se o escritor consegue avaliar um artigo. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://github.com/ICEI-PUC-Minas-PMV-ADS/Letra-Independente/tree/main/src/index.html<br> - Fazer login na aplicação <br> - Clicar em "Minha conta" <br> - Clicar em "Meus artigos" <br> - Acessar o artigo que desejar <br> - Clicar em extrair relatório <br>  |
|Critério de Êxito | - O relatório foi extraído com sucesso. |
