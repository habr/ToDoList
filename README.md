# ToDo List Application

## Описание

Это веб-приложение для управления списком задач (ToDo list), созданное с использованием .NET 6+ ASP.NET Core и Entity Framework Core.

## Установка и запуск

Клонируйте репозиторий:
   bash
   git clone <repository-url>
   cd ToDoList
 
Установите зависимости:

dotnet restore

Настройте строку подключения к базе данных в appsettings.json.

Выполните миграции для создания базы данных:

dotnet ef database update

Запустите приложение:

dotnet run

Использование

API доступно по следующим эндпоинтам:

GET /api/ToDoItems - Получить список всех задач

GET /api/ToDoItems/{id} - Получить задачу по ID

POST /api/ToDoItems - Создать новую задачу

PUT /api/ToDoItems/{id} - Обновить задачу по ID

DELETE /api/ToDoItems/{id} - Удалить задачу по ID

GET /api/ToDoItems/filter?isCompleted={true/false}&priority={1-5} - Фильтрация задач по статусу и приоритету

GET /api/Users - Получить список всех пользователей

GET /api/Users/{id} - Получить пользователя по ID

POST /api/Users - Создать нового пользователя

PUT /api/Users/{id} - Обновить пользователя по ID

DELETE /api/Users/{id} - Удалить пользователя по ID