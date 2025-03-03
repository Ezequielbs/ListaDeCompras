/*O banco de dados ListaDeCompras foi desenvolvido para um sistema de gerenciamento de listas de compras,
 permitindo que os usuários comparem preços de produtos em diferentes mercados, aproveitem promoções e avaliem produtos. 
 Ele é composto por sete tabelas principais, cada uma com uma função específica dentro do sistema.*/
-- Criando o banco de dados
CREATE DATABASE ListaDeCompras1;
USE ListaDeCompras1;

/* tabela de usuários, tem a função de cadatrar o usuário*/
CREATE TABLE usuarios (
    id_usuario INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(80) NOT NULL,
    email VARCHAR(80) UNIQUE NOT NULL,
    senha VARCHAR(100) NOT NULL,
    endereco VARCHAR(200),
    cidade VARCHAR(100),
    estado VARCHAR(80),
    cep VARCHAR(9),
    data_cadastro Date
);

/*Criando tabela de mercados, tem a função de cadastrar todos os mercados da região*/
CREATE TABLE mercados (    
    id_mercado INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    endereco VARCHAR(255) NOT NULL,
    cidade VARCHAR(100) NOT NULL,
    estado VARCHAR(3) NOT NULL,
    cep VARCHAR(9) NOT NULL,
    latitude DOUBLE  NOT NULL,
    longitude DOUBLE NOT NULL,
    telefone VARCHAR(20),
    horario_funcionamento VARCHAR(50),
    data_cadastro DATE
);

/*tabela de produtos, tem a função de cadastrar os produtos na promoção*/
CREATE TABLE produtos (
    id_produto INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(80) NOT NULL,
    marca VARCHAR(80) NOT NULL, 
    categoria VARCHAR(50) NOT NULL, 
    unidade_medida VARCHAR(20) NOT NULL, 
    peso DOUBLE, 
    descricao TEXT,
    data_cadastro DATE
);

/* tabela de relação entre produtos e mercados , tem a função de relacionar o produto com o mercado*/
CREATE TABLE produto_mercado (
    id_produto_mercado INT AUTO_INCREMENT PRIMARY KEY,
    preco DOUBLE,
    ultima_atualizacao DATETIME,
	fk_id_produto INT NOT NULL,
    fk_id_mercado INT NOT NULL,
    FOREIGN KEY (fk_id_produto) REFERENCES produtos(id_produto) ON DELETE CASCADE,
    FOREIGN KEY (fk_id_mercado) REFERENCES mercados(id_mercado) ON DELETE CASCADE
);
/*tabela de promoções */
CREATE TABLE promocoes (
    id_promocao INT AUTO_INCREMENT PRIMARY KEY,
    desconto DOUBLE,
    data_inicio DATE NOT NULL,
    data_fim DATE NOT NULL,
    descricao VARCHAR(255),
	fk_id_produto_mercado INT NOT NULL,
    FOREIGN KEY (fk_id_produto_mercado) REFERENCES produto_mercado(id_produto_mercado) 
);

/* tabela de listas de compras*/
CREATE TABLE listas_compras (
    id_lista INT AUTO_INCREMENT PRIMARY KEY,
    nome_lista VARCHAR(100) NOT NULL,
    data_criacao DATE,
    fk_id_usuario INT NOT NULL,
    FOREIGN KEY (fk_id_usuario) REFERENCES usuarios(id_usuario)
);

/*tabela de itens da lista tem a função de saber qual produto está na lista de compra*/
CREATE TABLE itens_lista (
    id_item INT AUTO_INCREMENT PRIMARY KEY,
    quantidade DOUBLE,
    unidade_medida VARCHAR(20) NOT NULL,
	fk_id_lista INT NOT NULL,
    fk_id_produto_mercado INT NOT NULL,
    FOREIGN KEY (fk_id_lista) REFERENCES listas_compras(id_lista),
    FOREIGN KEY (fk_id_produto_mercado) REFERENCES produto_mercado(id_produto_mercado) 
);

/* tabela de avaliações de produtos */
CREATE TABLE avaliacoes_produtos (
    id_avaliacao INT AUTO_INCREMENT PRIMARY KEY,
    avaliacao INT NOT NULL,
    comentario TEXT,
    data_avaliacao DATETIME,
	fk_id_usuario INT NOT NULL,
    fk_id_produto INT NOT NULL,
    FOREIGN KEY (fk_id_usuario) REFERENCES usuarios(id_usuario),
    FOREIGN KEY (fk_id_produto) REFERENCES produtos(id_produto)
);

-- Consulta para verificar os produtos
SELECT * FROM produtos;

INSERT INTO produtos (nome, marca, categoria, unidade_medida, peso, descricao, data_cadastro)
VALUES ('Banana', 'Tio João', 'Alimentos', 'kg', 5.0, 'Arroz de boa qualidade', '2025-03-02');

/*DROP DATABASE ListaDeCompras1;*/
