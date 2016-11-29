-- SELECT * FROM Products

-- 1. Выборка всех товаров с ценой в диапазоне [15,30].

--SELECT UnitPrice 
--FROM Products
--WHERE UnitPrice BETWEEN 15 AND 30

-- 2. Выборка всех товаров начинающихся на латинскую букву «с».

--SELECT ProductName 
--FROM Products
--WHERE ProductName LIKE 'c%'

-- 3. Выборка всех товаров имеющих в названии вторую латинскую букву «b».

--SELECT ProductName 
--FROM Products
--WHERE ProductName LIKE '_b%'

-- 4. Выборка всех товаров, в названии которых встречается последовательность «eso».

--SELECT ProductName 
--FROM Products
--WHERE ProductName LIKE '%eso%'

-- 5. Выборка всех товаров, название которых заканчивается на «es».

--SELECT ProductName 
--FROM Products
--WHERE ProductName LIKE '%es'

-- 6. Выборка записей о продажах. (Детализация – какой товар, количество, цена продажи)

--SELECT ProductName, UnitsInStock, UnitPrice
--FROM Products

-- 7. Выборка записей о продажах. (Детализация – какой товар, количество, цена продажи, дата продажи, покупатель)

--SELECT ProductName, UnitsInStock, UnitPrice, OrderDate, ContactName
--FROM Products, Orders, Suppliers

-- 8. Выборка записей о продажах. (Детализация – какой товар, количество, цена продажи, дата продажи, покупатель). 
-- Сортировка по наименованию товара, прямая сортировка.

--SELECT ProductName, UnitsInStock, UnitPrice, OrderDate, ContactName
--FROM Products, Orders, Suppliers
--ORDER BY ProductName

-- 9. Выборка записей о продажах, за 1997 год. (Детализация – какой товар, количество, цена продажи, дата продажи). 
-- Сортировка по цене, обратная сортировка.

--SELECT ProductName, UnitsInStock, UnitPrice, OrderDate
--FROM Products, Orders
--WHERE YEAR(OrderDate) = 1997
--ORDER BY UnitPrice DESC

-- 10. Выборка записей о продажах, сделанных до 1997 года. (Детализация – какой товар, количество, цена продажи, дата продажи).
-- Сортировка по цене, обратная сортировка.

--SELECT ProductName, UnitsInStock, UnitPrice, OrderDate
--FROM Products, Orders
--WHERE YEAR(OrderDate) < 1997
--ORDER BY UnitPrice DESC

-- 11. Выборка первых 7 записей о продажах. (Детализация – какой товар, сумма, дата продажи, покупатель). 
-- Сортировка по цене, прямая сортировка.

--SELECT TOP 7 ProductName, SUM(UnitPrice) as 'Sum', UnitPrice, OrderDate, ContactName
--FROM Products, Orders, Suppliers
--GROUP BY ProductName, UnitPrice, OrderDate, ContactName
--ORDER BY UnitPrice


-- 12. Выборка всех записей о суммарных продажах каждого товара. (Детализация – какой товар, сумма). 
-- Сортировка по сумме, обратная сортировка.

--SELECT ProductName, SUM(UnitPrice) as 'Unit price summary'
--FROM Products, Orders
--GROUP BY ProductName, UnitPrice
--ORDER BY UnitPrice DESC

-- 13. Выборка всех записей о количестве продаж каждого товара. (Детализация – товар, количество).
-- Сортировка по сумме, обратная сортировка.

--SELECT ProductName, COUNT(OrderDate) as 'Sales count'
--FROM Products, Orders
--GROUP BY ProductName, OrderDate, UnitPrice
--ORDER BY UnitPrice DESC

-- 14. Выборка всех записей о суммарных продажах каждого товара за 1997 год. (Детализация – какой товар, сумма).
-- Сортировка по сумме, обратная сортировка.

--SELECT ProductName, SUM(UnitPrice)
--FROM Products, Orders
--WHERE YEAR(OrderDate) = 1997
--GROUP BY ProductName, UnitPrice
--ORDER BY UnitPrice DESC

-- 15. Выборка первых 8 записей о суммарных продажах каждого товара за 1997 год. (Детализация – какой товар, сумма). 
-- Сортировка по сумме, обратная сортировка.

--SELECT TOP 8 ProductName, SUM(UnitPrice)
--FROM Products, Orders
--WHERE YEAR(OrderDate) = 1997
--GROUP BY ProductName, UnitPrice
--ORDER BY UnitPrice DESC

-- 16. Выборка всех записей о суммарных покупках каждого покупателя, на сумму большую 500. 
-- (Детализация – покупатель, сумма). 
-- Сортировка по сумме, обратная сортировка.

--SELECT SUM(UnitPrice), ContactName
--FROM Products, Suppliers, Orders
--GROUP BY ContactName, UnitPrice, OrderDate
--HAVING SUM(UnitPrice) > 500
--ORDER BY SUM(UnitPrice) DESC

-- 17. Выборка всех записей о суммарных покупках каждого покупателя, на сумму меньшую 1 000. 
-- (Детализация – покупатель, сумма). 
-- Сортировка по сумме, обратная сортировка.

--SELECT SUM(UnitPrice), ContactName
--FROM Products, Suppliers, Orders
--GROUP BY ContactName, UnitPrice, OrderDate
--HAVING SUM(UnitPrice) < 1000
--ORDER BY SUM(UnitPrice) DESC