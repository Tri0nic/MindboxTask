# MindboxTask
Тестовое задание на вакансию C# developer junior / middle (.net, full-stack / back-end) компании Mindbox

## Задание 1:
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
- Юнит-тесты
- Легкость добавления других фигур
- Вычисление площади фигуры без знания типа фигуры в compile-time
- Проверку на то, является ли треугольник прямоугольным

![image](https://github.com/user-attachments/assets/b7b8f231-cc86-4fa4-8db6-8c18fc4f11ed)


## Задание 2 (см. подробнее в файле MindboxDB.pdf):
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

```sql
select product_name, category_name
from Products
join Products_and_Categories on Products.id_products = Products_and_Categories.id_products
left join categories on Products_and_Categories.id_categories = Categories.id_categories
