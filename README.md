# ToDo List Application

## ��������

��� ���-���������� ��� ���������� ������� ����� (ToDo list), ��������� � �������������� .NET 6+ ASP.NET Core � Entity Framework Core.

## ��������� � ������

���������� �����������:
   bash
   git clone <repository-url>
   cd ToDoList
 
���������� �����������:

dotnet restore

��������� ������ ����������� � ���� ������ � appsettings.json.

��������� �������� ��� �������� ���� ������:

dotnet ef database update

��������� ����������:

dotnet run

�������������

API �������� �� ��������� ����������:

GET /api/ToDoItems - �������� ������ ���� �����

GET /api/ToDoItems/{id} - �������� ������ �� ID

POST /api/ToDoItems - ������� ����� ������

PUT /api/ToDoItems/{id} - �������� ������ �� ID

DELETE /api/ToDoItems/{id} - ������� ������ �� ID

GET /api/ToDoItems/filter?isCompleted={true/false}&priority={1-5} - ���������� ����� �� ������� � ����������

GET /api/Users - �������� ������ ���� �������������

GET /api/Users/{id} - �������� ������������ �� ID

POST /api/Users - ������� ������ ������������

PUT /api/Users/{id} - �������� ������������ �� ID

DELETE /api/Users/{id} - ������� ������������ �� ID