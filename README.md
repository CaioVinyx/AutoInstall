1. Leitura da pasta de instaladores

O programa começa acessando uma pasta padrão (C:\\Instaladores) onde ficam armazenados os arquivos de instalação. Ele identifica automaticamente os arquivos com as extensões mais comuns de instaladores:

.exe (executáveis)

2. Criação de pastas organizadas por programa

Para manter a organização, o programa cria uma pasta exclusiva para cada instalador, com base no nome do arquivo, dentro do diretório C:\Programas.

Exemplo:

Se houver o instalador Python.exe, ele será instalado em C:\Programas\Python.


3. Execução automática e silenciosa

Cada instalador é executado com os argumentos corretos para uma instalação silenciosa, ou seja, sem janelas ou necessidade de cliques do usuário. O programa sabe como lidar com diferentes formatos:

.exe: executado diretamente com parâmetros de instalação automática;
