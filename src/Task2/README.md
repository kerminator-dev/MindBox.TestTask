## Задание: В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

MS SQL Server нет, но есть SQLite.

## <a href="https://github.com/kerminator-dev/MindBox.TestTask/blob/main/src/Task2/db">База данных</a>:
### Таблица "Product":
- Структура:

![alt text](https://github.com/kerminator-dev/MindBox.TestTask/blob/main/src/Task2/img/Product_table_structure.PNG?raw=true)

- Данные:

![alt text](https://github.com/kerminator-dev/MindBox.TestTask/blob/main/src/Task2/img/Product_table_data.PNG?raw=true)

### Таблица "Category":
- Структура:

![alt text](https://github.com/kerminator-dev/MindBox.TestTask/blob/main/src/Task2/img/Category_table_structure.PNG?raw=true)

- Данные:

![alt text](https://github.com/kerminator-dev/MindBox.TestTask/blob/main/src/Task2/img/Category_table_data.PNG?raw=true)

### Таблица "ProductCategory":
- Структура:

![alt text](https://github.com/kerminator-dev/MindBox.TestTask/blob/main/src/Task2/img/ProductCategory_table_structure.PNG?raw=true)

- Данные:

![alt text](https://github.com/kerminator-dev/MindBox.TestTask/blob/main/src/Task2/img/ProductCategory_table_data.PNG?raw=true)

### <a href="https://github.com/kerminator-dev/MindBox.TestTask/blob/main/src/Task2/query.txt">SQL-запрос</a>:
![alt text](https://github.com/kerminator-dev/MindBox.TestTask/blob/main/src/Task2/img/Query.PNG?raw=true)

### Результат выполнения:
![alt text](https://github.com/kerminator-dev/MindBox.TestTask/blob/main/src/Task2/img/Result.PNG?raw=true)
