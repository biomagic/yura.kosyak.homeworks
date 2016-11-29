--CREATE table S(
--n_post char(5) PRIMARY KEY NOT NULL,
--name char(20),
--reiting smallint,
--town char(15))

--CREATE table P(
--n_det char(6) PRIMARY KEY,
--name char(20),
--cvet char(7),
--ves smallint, town char(15))

--CREATE table SP(
--n_post char(5) FOREIGN KEY REFERENCES S(n_post),
--n_det char(6) FOREIGN KEY REFERENCES P(n_det),
--date_post date,
--kol smallint)

--VALUES 
--('S1', 'Смит', 20, 'Лондон'),
--('S2', 'Джонс', 10, 'Париж'),
--('S3', 'Блейк', 30, 'Париж'),
--('S4', 'Кларк', 20, 'Лондон'),
--('S5', 'Адамс', 30, 'Атенс');

--INSERT INTO P
--VALUES 
--('P1', 'Гайка', 'Красный', 12, 'Лондон'),
--('P2', 'Болт', 'Зеленый', 17, 'Париж'),
--('P3', 'Винт', 'Голубой', 17, 'Рим'),
--('P4', 'Винт', 'Красный', 14, 'Лондон'),
--('P5', 'Кулачок', 'Голубой', 12, 'Париж'),
--('P6', 'Блюзы', 'Красный', 19, 'Лондон');

--INSERT INTO SP
--VALUES
--('S1', 'P1', '19950201', 300),
--('S1', 'P2', '19950405', 200),
--('S1', 'P3', '19950512', 400),
--('S1', 'P4', '19950615', 200),
--('S1', 'P5', '19950722', 100),
--('S1', 'P6', '19950813', 100),
--('S2', 'P1', '19950303', 300),
--('S2', 'P2', '19950612', 400),
--('S3', 'P2', '19950404', 200),
--('S4', 'P2', '19950323', 200),
--('S4', 'P4', '19950617', 300),
--('S4', 'P5', '19950822', 400);

--SELECT
--n_det as 'Номер детали', 
--name as 'Название', 
--cvet as'Цвет', 
--ves as 'Вес', 
--town as 'Город'
--FROM P;

--SELECT
--n_post as 'Номер поставщика',
--n_det as 'Номер детали',
--date_post as 'Дата поставки',
--kol as 'Количество'
--FROM SP;

-- 1. Выдать полную информацию о поставщиках.

--SELECT 
--n_post as 'Номер поставщика', 
--name as 'Фамилия', 
--reiting as 'Рейтинг', 
--town as 'Город'
--FROM S;

-- 1. Выдать таблицу S в следующем порядке: фамилия, город, рейтинг, номер_поставщика.

--SELECT 
--name as 'Фамилия',
--town as 'Город',
--reiting as 'Рейтинг', 
--n_post as 'Номер поставщика'
--FROM S;

-- 2. Выдать номера всех поставляемых деталей.

--SELECT
--n_det as 'Номер детали'
--FROM P;

-- 3. Выдать номера всех поставляемых деталей, исключая дублирование

--SELECT DISTINCT
--n_det as 'Номер детали'
--FROM P;

-- 4. Выдать сокращение фамилий до двух букв и рейтинг поставщика.

--SELECT
--SUBSTRING(name,1,2) AS 'Фамилия', 
--reiting AS 'Рейтинг'
--FROM S;

--5. Выдать список поставщиков, упорядоченных по городу, в пределах города - по рейтингу.

--SELECT 
--n_post as 'Номер поставщика', 
--name as 'Фамилия', 
--reiting as 'Рейтинг', 
--town as 'Город'
--FROM S
--ORDER BY town, reiting;

--6. Выбрать список деталей, начинающихся с буквы «Б»

--SELECT
--n_det as 'Номер детали', 
--name as 'Название',
--ves as 'Вес'
--FROM P
--WHERE name LIKE 'б%';

--7. Выдать средний, минимальный и максимальный объем поставок для поставщика S1 с соответствующим
--заголовком.

--SELECT ROUND(AVG(CAST(kol AS float)), 1) as 'average', MIN(kol) AS 'minimum', MAX(kol) 'maximum'
--FROM SP
--WHERE n_post LIKE 'S1'

--8. Выдать перечень поставок и их количество, а также день, месяц, день недели и количество дней,
--прошедших с момента поставки на сегодняшний день.

--SELECT
--n_det AS 'Номер детали',
--kol AS 'Количество',
--DAY(date_post) as 'Day',
--MONTH(date_post) as 'month',
--DATEPART(weekday, date_post) as 'weekday',
--DATEDIFF(DAY, date_post, GETDATE()) as '(Expression)'
--FROM SP;

--9. Выдать все комбинации информации о поставщиках и деталях, расположенных в одном городе

--SELECT
--n_post AS 'н_пост',
--s.name AS 'фам-я', 
--reiting AS 'рейтинг',
--s.town AS 's.город',
--n_det AS 'н_дет',
--p.name AS 'назв-е',
--cvet AS 'цвет',
--ves AS 'вес',
--p.town AS 'p.город'
--FROM P, S
--WHERE s.town = p.town

-- 10. Выдать для каждой поставляемой детали ее номер и общий объем поставок, за исключением поставок
-- поставщика S1.

--SELECT
--n_det as 'Номер детали', 
--SUM(kol) as '(Sum)'
--FROM SP
--WHERE n_post <> 'S1'
--GROUP BY n_det

-- 11. Выдать номера деталей, которые имеют вес более 16 фунтов, либо поставляются поставщиком S2.

--SELECT
--n_det 'Номер детали'
--FROM P WHERE ves > 16
--UNION
--SELECT n_det 'Номер детали'
--FROM SP
--WHERE n_post = 'S2'

-- 12. Удалить все поставки для поставщиков из Лондона.
-- Результат: таблица SP с отсутствующими строками о поставках для поставщиков из Лондона

 --DELETE FROM SP
 --WHERE 'Лондон' = (SELECT town from S where S.n_post = SP.n_post)

