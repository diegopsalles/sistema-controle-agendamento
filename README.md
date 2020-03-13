# sistema-controle-agendamento
## Sistema de Agendamento
Um escritório de advocacia requer um sistema para gerenciamento de Processos. 
O sistema deve permitir o cadastro das informações pertinentes à um processo como Número do Processo, estado em que o mesmo está sendo executado, data de criação, entre outros. 

O sistema deve cadastrar as informações do cliente, como nome, cnpj e estado em que o cliente se encontra. Os processos devem obrigatoriamente ser anexados a um cliente do escritório.

## Casos de Teste
1) Calcular a soma dos processos ativos. A aplicação deve retornar R$ 1.087.000,00
2) Calcular a a média do valor dos processos no Rio de Janeiro para o Cliente "Empresa A". A aplicação deve retornar R$ 110.000,00.
3) Calcular o Número de processos com valor acima de R$ 100.000,00. A aplicação deve retornar 2.
4) Obter a lista de Processos de Setembro de 2007. A aplicação deve retornar uma lista com somente o Processo “00010TRABAM”.
5) Obter a lista de processos no mesmo estado do cliente, para cada um dos clientes. A aplicação deve retornar uma lista com os processos de número “00001CIVELRJ”,”00004CIVELRJ” para o Cliente "Empresa A" e “00008CIVELSP”,”00009CIVELSP” para o o Cliente "Empresa B".
6) Obter a lista de processos que contenham a sigla “TRAB”. A aplicação deve retornar uma lista com os processos “00003TRABMG” e “00010TRABAM”

## Stack Utilizada 
1. .Net Core 3.1
2. Entity FrameWork Core 3.1.1 (Usando Migrations)
4. DependencyInjection 2.1.1
5. Swagger

## Instalação
Só realizar o git clone do projeto

```git clone https://github.com/diegopsalles/sistema-controle-agendamento```
