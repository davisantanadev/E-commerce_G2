# 🛒 E-commerce Básico (POO) — Grupo 2

Projeto desenvolvido como atividade prática da disciplina de **Programação Orientada por Objetos (POO)**, com o objetivo de simular o fluxo essencial de um sistema de e-commerce: do carrinho até a finalização de um pedido.

---

## 🎯 Objetivo

Implementar um sistema simples de e-commerce capaz de:

* Adicionar produtos ao carrinho
* Aplicar descontos
* Calcular o total da compra
* Gerenciar cliente
* Confirmar ou cancelar pedidos

---

## 🧱 Estrutura do Projeto

O sistema é composto pelas seguintes classes principais:

### 📦 Produto

Representa um item disponível para venda.

**Atributos sugeridos:**

* Nome
* Preço
* Estoque
* Desconto

**Métodos:**

* `AplicarDesconto(double desconto)` → Aplica desconto ao produto
* `AjustarEstoque(int quantidade)` → Atualiza o estoque
* `PrecoComDesconto(): double` → Retorna o preço final com desconto

---

### 🧾 ItemCarrinho

Representa um produto dentro do carrinho com uma quantidade específica.

**Atributos sugeridos:**

* Produto
* Quantidade

**Métodos:**

* `AtualizarQuantidade(int quantidade)` → Atualiza a quantidade do item
* `Subtotal(): double` → Retorna o valor total do item (quantidade × preço com desconto)
* `GetProduto(): Produto` → Retorna o produto associado

---

### 🛍️ Carrinho

Responsável por armazenar os itens da compra.

**Atributos sugeridos:**

* Lista de itens

**Métodos:**

* `AdicionarItem(Produto produto, int quantidade)` → Adiciona um item ao carrinho
* `RemoverItem(Produto produto)` → Remove um item do carrinho
* `CalcularTotal(): double` → Soma todos os subtotais dos itens

✔ **Regra importante:**
O método `CalcularTotal()` deve considerar o preço com desconto de cada produto.

---

### 👤 Cliente

Representa o usuário que realiza a compra.

**Atributos sugeridos:**

* Nome
* Contato (email ou telefone)
* Endereços
* Formas de pagamento

**Métodos:**

* `AdicionarEndereco(string endereco)`
* `AdicionarFormaPagamento(string formaPagamento)`
* `GetContato(): string`

---

### 📦 Pedido

Responsável por consolidar a compra.

**Atributos sugeridos:**

* Cliente
* Itens do carrinho
* Status do pedido

**Métodos:**

* `Confirmar(Carrinho carrinho, Cliente cliente)`

  * Só deve confirmar se o carrinho tiver itens
* `Cancelar()`
* `TotalComFrete(double frete): double`

  * Retorna o total do pedido somado ao frete

---

## 🔄 Fluxo do Sistema

1. Criar produtos
2. Adicionar produtos ao carrinho
3. Aplicar desconto (se necessário)
4. Criar cliente
5. Confirmar pedido
6. Calcular total com frete

---

## 🧪 Exemplo de Execução (Program.cs)

O programa principal deve conter:

* 2 produtos cadastrados
* Um carrinho com itens
* Um cliente
* Um pedido sendo confirmado

---

## 📊 Critérios de Avaliação

✔ Uso correto de conceitos de POO (encapsulamento, organização em classes)
✔ Cálculo correto do total com desconto
✔ Validação no método `Confirmar()` (carrinho não vazio)
✔ Código organizado e legível

---

## ⭐ Funcionalidades Extras

* Frete fixo aplicado ao pedido
* Validação de estoque ao adicionar item
* Atualização automática de estoque após confirmação

---

## 📌 Observações

* O projeto deve ser estruturado de forma modular
* Métodos devem ter responsabilidade única
* Evitar repetição de código

---

## 🚀 Resultado Esperado

Ao final, o sistema deve ser capaz de simular uma compra simples, desde a seleção de produtos até a confirmação do pedido, garantindo organização e clareza no código.


