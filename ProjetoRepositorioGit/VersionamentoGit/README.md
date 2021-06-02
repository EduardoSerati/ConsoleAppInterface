## Documentação Passo-a-Passo para comandos básicos do Git

==1== git init (inicializa o git)
==2== git remote -v (exibe qual repositório estou conectado)
==3== git add origin <Informar_URL_Do_Repositorio> ex: https://github.com/EduardoSerati/A24VersionamentoGit.git (adicionar um repositório a origin)
==4== git remote set-url origin <Informar_URL_Do_Repositorio> ex: https://github.com/EduardoSerati/A24VersionamentoGit.git (alterar a minha origin)
==5== Gerar um arquivo README.md na raiz do projeto (README.md será utilizado para documentar informarções do projeto - na geral)
==6== git add . (Adicionando os arquivos que serão enviados para o repositório - utilizando o commit em seguida)
==7== git commit -m "INITIAL COMMIT"
==8== git push -u origin master
==9== ##OPCIONAL## Gerar uma nova BRANCH
        --9.1-- git branch <Nome_Da_Branch> (Gerar nova branch)
        --9.2-- git branch -v (Visualizar branch)