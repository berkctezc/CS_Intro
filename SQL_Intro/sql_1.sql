--Select
--ANSII
SELECT ContactName Ad,CompanyName SirketAdi,City Sehir from Customers

select * from Customers where City = 'Berlin'

--case insensitive
select * from products where CategoryID=1 or CategoryID=3
select * from products where CategoryID=1 and UnitPrice>=10

select * from Products where Categoryid=2 order by UnitPrice asc --ascending --desc (descending)

select count(*) urunsayimiz from Products where CategoryID=5

--having kümülatiflere uygulanır
--having her kategoriye bakıp countu 10dan küçük olanları göster where: unitprice 20den büyük olanları filtrele
select categoryid,count(*) from products where UnitPrice>20 group by CategoryID having count(*)<10

--productstan categoryidleri kategoriler ile categoryidler ile eşleşen verilerin secilen alanlarını goster ++where ile productlar arasında unitpricei 10dan yuksek olanlar
select Products.ProductID, products.ProductName, products.UnitPrice, Categories.CategoryName from Products inner join Categories on Products.CategoryID = categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation Object

--left: solda olup sağda olmayanlar --right:sağda olup sağda olmayanlar
select * from Products p left join [Order Details] od on p.ProductID = od.ProductID

select * from customers c left join [Orders] o on c.CustomerID = o.CustomerId where o.CustomerID is null