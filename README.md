# Dio_decola_tech_2024 - Avanade
Desafios de codigo e outros exercicios relacionados ao bootcamp

## 1° Desafio de Codigo.

### Proposta

Você precisará construir uma classe chamada "Estacionamento", conforme o diagrama.
A classe contém três variáveis, sendo:
precoInicial: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.
precoPorHora: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.
veiculos: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.
A classe contém três métodos, sendo:
AdicionarVeiculo: Método responsável por receber uma placa digitada pelo usuário e guardar na variável veiculos.
RemoverVeiculo: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: precoInicial * precoPorHora, exibindo para o usuário.
ListarVeiculos: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".
Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:

1 Cadastrar veículo
2 Remover veículo
3 Listar veículos
4 Encerrar



## 2° Desafio de Codigo.

Criar um sistema em .NET, do tipo console, mapeando uma classe abstrata 
e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

### Regras e validações
A classe Smartphone deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
A classe Nokia e Iphone devem ser classes filhas de Smartphone.
O método InstalarAplicativo deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.