CREATE DATABASE bd_isoul_sales;
USE bd_isoul_sales;
CREATE TABLE funcionarios (
	id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50),
    cpf VARCHAR(11)
);

CREATE TABLE fornecedores (
    id INT AUTO_INCREMENT PRIMARY KEY,
    razao_social VARCHAR(50) NOT NULL,
    nome VARCHAR(50),
    cnpj VARCHAR(14),
    atividade_economica VARCHAR(70),
    fornecedor_status BOOL,
    telefone VARCHAR(15),
    email VARCHAR(30)
);

CREATE TABLE caixas (
	id INT PRIMARY KEY AUTO_INCREMENT,
    saldo_inicial DOUBLE,
    total_entrada DOUBLE,
    total_saida DOUBLE,
    status_caixa BOOL,
    fk_id_funcionarios INTEGER NOT NULL, FOREIGN KEY (fk_id_funcionarios) REFERENCES funcionarios(id)
);

CREATE TABLE despesas (
	id INT PRIMARY KEY AUTO_INCREMENT,
	valor DOUBLE,
    vencimento DATETIME,
    data_pagamento DATETIME,
    fk_id_fornecedores INTEGER NOT NULL DEFAULT 1, FOREIGN KEY (fk_id_fornecedores) REFERENCES fornecedores(id),
    fk_id_caixas INTEGER NOT NULL, FOREIGN KEY (fk_id_caixas) REFERENCES caixas(id) 
);

CREATE TABLE servicos (
	id INT PRIMARY KEY AUTO_INCREMENT,
	valor DOUBLE,
    descricao VARCHAR(255),
    tempo TIME
);

CREATE TABLE clientes (
	id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    CPF VARCHAR(11),
	email VARCHAR(40),
    telefone VARCHAR(14),
    data_nascimento DATE
);

CREATE TABLE vendas (
	id INT PRIMARY KEY AUTO_INCREMENT,
    data_venda DATE,
    hora_venda TIME,
    valor_total DOUBLE,
    desconto DOUBLE,
    valor_final DOUBLE,
    forma_pagamento ENUM("À VISTA", "A PRAZO"),
    fk_id_clientes INTEGER, FOREIGN KEY (fk_id_clientes) REFERENCES clientes(id)    
);


CREATE TABLE venda_servicos (
	id INT PRIMARY KEY AUTO_INCREMENT,
    quantidade INTEGER,
    valor_unitario DOUBLE,
    fk_id_servicos INTEGER NOT NULL, FOREIGN KEY (fk_id_servicos) REFERENCES servicos(id),
    fk_id_vendas INTEGER NOT NULL, FOREIGN KEY (fk_id_vendas) REFERENCES vendas(id) ON DELETE CASCADE
);


CREATE TABLE recebimentos (
	id INT PRIMARY KEY AUTO_INCREMENT,
    valor DOUBLE,
    vencimento DATETIME,
    data_pagamento DATETIME,
    status_recebimento BOOL,
    fk_id_vendas INTEGER NOT NULL, FOREIGN KEY (fk_id_vendas) REFERENCES vendas(id),
    fk_id_caixas INTEGER NOT NULL, FOREIGN KEY (fk_id_caixas) REFERENCES caixas(id)
);


CREATE TABLE dispositivos (
	id INT PRIMARY KEY AUTO_INCREMENT,
	aliquota DOUBLE,
	descricao VARCHAR(255),
	status_dispositivo BOOL
);

CREATE TABLE encargos (
    id INT PRIMARY KEY AUTO_INCREMENT,
    valor DOUBLE,
    descricao VARCHAR(255),
    fk_id_recebimentos INTEGER NOT NULL, FOREIGN KEY (fk_id_recebimentos) REFERENCES recebimentos (id) ON DELETE CASCADE,
	fk_id_dispositivos INTEGER NOT NULL, FOREIGN KEY (fk_id_dispositivos) REFERENCES dispositivos (id) ON DELETE CASCADE
);
 

