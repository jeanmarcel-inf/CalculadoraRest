# CalculadoraRest

- Este projeto dispõe de operações matemáticas básicas: soma, subtração, multiplicação, divisão, média e raiz quadrada.
- O contralador "Calculator" é responsável por conter todas as actions relacionadas às operações.
- Cada action recebe um valor de tipo string, isto torna mais fácil a implementação da validação dos dados de entrada.
- Para a validação dos dados, foi criado o método booleano "IsNumeric()", este, recebe a entrada de dados passado via URL e invoca o método "TryParse()" de double.

  ## Operações Matemáticas

  - As operações matemáticas são acessadas através de um caminho na URL
  - Os valores de uso destas operações, também, são passados via caminho na URL  

  ### Soma
  - sum/primeiroNumero/segundoNumero

  ### Subtração
  - subtraction/primeiroNumero/segundoNumero

  ### Multiplicação
  - multiply/primeiroNumero/segundoNumero

  ### Divisão
  - division/primeiroNumero/segundoNumero

  ### Média
  - mean/primeiroNumero/segundoNumero

  ### Raiz Quadrada
  - sqrt/numero
