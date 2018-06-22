
use dbLojaWeb
drop database dbLojaWeb

SELECT* FROM [dbLojaWeb].[dbo].[User]
SELECT* FROM [dbLojaWeb].[dbo].[Product]
SELECT* FROM [dbLojaWeb].[dbo].[ProdCategory]


insert into [ProdCategory](Name, Description)
values('CatTeste', 'Desc da Cat')

insert into [Product](Name, Description, Price, Quantity, CategoryId)
values('ProdutoTeste', 'Desc do Prod', 123.23, 12, 1)

truncate table [dbLojaWeb].[dbo].[User]

truncate table [dbLojaWeb].[dbo].[Product]

truncate table [dbLojaWeb].[dbo].[ProdCategory]

/*Name	Pass
Aluno	12345678
Lobo Mau	12345678
Chico Tripa	12345678
Coco Verde	12345678
Fim do Feriado	21345678
Bob Esponja	13245678
*/

insert into [User](Name, Pass)
values('Aluno', 12345678),
('Lobo Mau', 12345678),
('Chico Tripa', 12345678),
('Coco Verde', 12345678),
('Fim do Feriado', 21345678),
('Bob Esponja', 13245678)