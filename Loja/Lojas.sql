CREATE TABLE Venda (
  idVenda INTEGER  NOT NULL   IDENTITY ,
  Data_Venda DATE  NOT NULL  ,
  Valor_Total REAL  NOT NULL    ,
PRIMARY KEY(idVenda));
GO




CREATE TABLE Departamento (
  idDepartamento INTEGER  NOT NULL   IDENTITY ,
  Sigla_Departamento VARCHAR(20)  NOT NULL  ,
  Perc_Departamento REAL  NOT NULL  ,
  Nome_Departamento VARCHAR(45)  NOT NULL    ,
PRIMARY KEY(idDepartamento));
GO




CREATE TABLE Vendedor (
  idVendedor INTEGER  NOT NULL   IDENTITY ,
  Vendedor_idVendedor INTEGER    ,
  Departamento_idDepartamento INTEGER  NOT NULL  ,
  Nome_Vendedor VARCHAR(255)  NOT NULL  ,
  RG_Vendedor INTEGER  NOT NULL  ,
  CPF_Vendedor CHAR(15)  NOT NULL  ,
  Data_admissao_Vendedor DATE  NOT NULL  ,
  Situacao_Vendedor VARCHAR(20)  NOT NULL    ,
PRIMARY KEY(idVendedor)    ,
  FOREIGN KEY(Departamento_idDepartamento)
    REFERENCES Departamento(idDepartamento),
  FOREIGN KEY(Vendedor_idVendedor)
    REFERENCES Vendedor(idVendedor));
GO


CREATE INDEX Vendedor_FKIndex1 ON Vendedor (Departamento_idDepartamento);
GO
CREATE INDEX Vendedor_FKIndex2 ON Vendedor (Vendedor_idVendedor);
GO


CREATE INDEX IFK_tem ON Vendedor (Departamento_idDepartamento);
GO
CREATE INDEX IFK_Rel_15 ON Vendedor (Vendedor_idVendedor);
GO


CREATE TABLE Produto (
  idProduto INTEGER  NOT NULL   IDENTITY ,
  Departamento_idDepartamento INTEGER  NOT NULL  ,
  Nome_Produto VARCHAR(45)  NOT NULL  ,
  Preco_Produto REAL  NOT NULL  ,
  Quantidade_Produto INTEGER  NOT NULL    ,
PRIMARY KEY(idProduto)  ,
  FOREIGN KEY(Departamento_idDepartamento)
    REFERENCES Departamento(idDepartamento));
GO


CREATE INDEX Produto_FKIndex1 ON Produto (Departamento_idDepartamento);
GO


CREATE INDEX IFK_tem ON Produto (Departamento_idDepartamento);
GO


CREATE TABLE Produto_Similar (
  idProduto_Similar INTEGER  NOT NULL   IDENTITY ,
  Produto_idProduto INTEGER  NOT NULL    ,
PRIMARY KEY(idProduto_Similar)  ,
  FOREIGN KEY(Produto_idProduto)
    REFERENCES Produto(idProduto));
GO


CREATE INDEX Produto_Similar_FKIndex1 ON Produto_Similar (Produto_idProduto);
GO


CREATE INDEX IFK_Rel_06 ON Produto_Similar (Produto_idProduto);
GO


CREATE TABLE Registro_Venda (
  Produto_idProduto INTEGER  NOT NULL  ,
  Venda_idVenda INTEGER  NOT NULL  ,
  Departamento_idDepartamento INTEGER  NOT NULL  ,
  Vendedor_idVendedor INTEGER  NOT NULL  ,
  Valor_Comissao REAL  NOT NULL    ,
PRIMARY KEY(Produto_idProduto, Venda_idVenda)        ,
  FOREIGN KEY(Produto_idProduto)
    REFERENCES Produto(idProduto),
  FOREIGN KEY(Venda_idVenda)
    REFERENCES Venda(idVenda),
  FOREIGN KEY(Vendedor_idVendedor)
    REFERENCES Vendedor(idVendedor),
  FOREIGN KEY(Departamento_idDepartamento)
    REFERENCES Departamento(idDepartamento));
GO


CREATE INDEX Produto_has_Venda_FKIndex1 ON Registro_Venda (Produto_idProduto);
GO
CREATE INDEX Produto_has_Venda_FKIndex2 ON Registro_Venda (Venda_idVenda);
GO
CREATE INDEX Registro_Venda_FKIndex3 ON Registro_Venda (Vendedor_idVendedor);
GO
CREATE INDEX Registro_Venda_FKIndex4 ON Registro_Venda (Departamento_idDepartamento);
GO


CREATE INDEX IFK_Rel_04 ON Registro_Venda (Produto_idProduto);
GO
CREATE INDEX IFK_Rel_05 ON Registro_Venda (Venda_idVenda);
GO
CREATE INDEX IFK_Rel_12 ON Registro_Venda (Vendedor_idVendedor);
GO
CREATE INDEX IFK_Rel_08 ON Registro_Venda (Departamento_idDepartamento);
GO


CREATE TABLE Registro_Venda_Produto (
  Registro_Venda_Venda_idVenda INTEGER  NOT NULL  ,
  Registro_Venda_Produto_idProduto INTEGER  NOT NULL  ,
  Produto_idProduto INTEGER  NOT NULL  ,
  Valor_Unitario REAL  NOT NULL  ,
  Quantidade_Produto INTEGER  NOT NULL    ,
PRIMARY KEY(Registro_Venda_Venda_idVenda, Registro_Venda_Produto_idProduto, Produto_idProduto)    ,
  FOREIGN KEY(Registro_Venda_Produto_idProduto, Registro_Venda_Venda_idVenda)
    REFERENCES Registro_Venda(Produto_idProduto, Venda_idVenda),
  FOREIGN KEY(Produto_idProduto)
    REFERENCES Produto(idProduto));
GO


CREATE INDEX Registro_Venda_has_Produto_FKIndex1 ON Registro_Venda_Produto (Registro_Venda_Produto_idProduto, Registro_Venda_Venda_idVenda);
GO
CREATE INDEX Registro_Venda_has_Produto_FKIndex2 ON Registro_Venda_Produto (Produto_idProduto);
GO


CREATE INDEX IFK_Rel_09 ON Registro_Venda_Produto (Registro_Venda_Produto_idProduto, Registro_Venda_Venda_idVenda);
GO
CREATE INDEX IFK_Rel_10 ON Registro_Venda_Produto (Produto_idProduto);
GO



