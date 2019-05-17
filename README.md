# Desafio_Attributor

<p>Desafio processo seletivo Attributor</p>

<h1><b>Criando o projeto</b></h1>

1.Clique em <b>criar novo projeto</b> ao abrir o Visual Studio

2.Insisa ASP.NET na tabela de pesquisa e escolha C# na linguagem de programação

3.Escolha o <b>Aplicativo Web ASP.NET (.NET Framework)</b> e clique em <b>Próximo</b>

4.Nomeie seu aplicativo e clique em <b>Criar</b> 

5.Selecione <b>MVC</b> e clique em <b>Criar</b>

<h1><b>Criando e enviando arquivos para o repositório no github</b></h1>

1.Abra a conta do github, faça login e clique em <b>New Repository</b>

2.Abra o prompt de comando vá até o caminho da sua pasta e para transformar ela em um repositório digiti <b>git init</b>

<code> $ git init </code>

3.Adicione o caminho para o repositório

<code>$ git remote add origin https://github.com/mfilardi3/Desafio_Attributor/</code>

4.Para verificar as alterações no git digite <b>git status</b>

5.Adicione os seus arquivos ao repositório 

<code>$ git add *</code>

6.Para confirmar as mudanças feitas digite <b>git commit</b>

<code>$ git commit -m "comentário"</code>

7.Envie as mudanças feitas ao repositório remoto

<code>$ git push -u origin master</code>

Obs: Caso haja mudanças no repositório que não estão no seu arquivo é preciso usar o <b>git pull</b>

<code>$ git pull</code>

<h1><b>Codificando</h1></b>
<h2>Aplicações MVC:</h2>
<img src="https://cdn-images-1.medium.com/max/1600/1*1qspMILbe0d48nq4sEhKLQ.png">
É uma arquitetura para implementar a interface do usuário.
<h2>View</h2>
Responsável pela exibição de dados .

<h2>Controller</h2>
Recebe as requisições do usuário controlando qual Model usar e qual view será mostrado ao usuário.

<h2>Model</h2>
Responsável pela leitura, escrita e validação dos dados 
