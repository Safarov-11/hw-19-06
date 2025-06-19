# Razor Pages

## Tasks for home, working with Razor Pages.


### Create a Simple CRUD Application

Objective:

- Develop a simple CRUD (Create, Read, Update, Delete) application for managing a list of books using Razor Pages.

Instructions:

- Create a new Razor Pages project.
- Set up a database context using Entity Framework Core.
- Create a model class for the Book entity with properties like Id, Title, Author, Genre, and PublishedDate.
- Scaffold Razor Pages for the Book model to generate the necessary pages for CRUD operations.
- Implement and customize the Create, Read, Update, and Delete functionality for the books.
- Style the pages using Css or Sass.

### Implement Search Functionality

Objective:

- Add search functionality to the CRUD application to filter books by title or author.

Instructions:

- Add a search form to the Index page of the Books.
- Modify the code-behind to filter the list of books based on the search query.
- Update the Index page to display the filtered list of books.
- Ensure the search query persists across pagination, if applicable.

### Add Sorting and Paging

Objective:

- Enhance the book list page with sorting and paging functionality.

Instructions:

- Modify the Index page to include column headers that allow sorting by Title, Author, Genre, and PublishedDate.
- Implement sorting logic in the code-behind.
- Add pagination controls to the Index page.
- Implement paging logic in the code-behind to handle large datasets.

### Implement Validation

Objective:

- Add client-side and server-side validation to the book form.

Instructions:

- Add data annotations to the Book model properties for validation rules (e.g., required fields, maximum length).
- Implement server-side validation in the code-behind and display validation messages in the form.

### Create a Partial View for Book Details

Objective:

- Create a partial view to display detailed information about a selected book.

Instructions:

- Create a partial view that displays the details of a book.
- Modify the Index page to include a link or button to view the book details.
- Use AJAX to load the partial view into a modal or a dedicated section of the page without refreshing the entire page.


##

# Razor Pages


## Задания для дома, работа с Razor Pages.

### Создать простое CRUD-приложение

Цель:
- Разработать простое CRUD-приложение (Create, Read, Update, Delete) для управления списком книг с помощью Razor Pages.

Инструкции:

- Создать новый проект Razor Pages.
- Настроить контекст базы данных с помощью Entity Framework Core.
- Создать класс модели для сущности Book со свойствами, такими как Id, Title, Author, Genre и PublishedDate.
- Создать шаблон Razor Pages для модели Book, чтобы сгенерировать необходимые страницы для операций CRUD.
- Реализовать и настроить функции Create, Read, Update и Delete для книг.
- Стилизировать страницы с помощью Css или Sass.

### Реализовать функцию поиска

Цель:
- Добавить функцию поиска в приложение CRUD для фильтрации книг по названию или автору.

Инструкции:

- Добавить форму поиска на страницу индекса книг.
- Измените код-бэкенд для фильтрации списка книг на основе поискового запроса.
- Обновите страницу индекса, чтобы отобразить отфильтрованный список книг.
- Убедитесь, что поисковый запрос сохраняется при разбиении на страницы, если применимо.

### Добавить сортировку и разбиение на страницы

Цель:
- Улучшить страницу списка книг с помощью функций сортировки и разбиения на страницы.

Инструкции:

- Измените страницу индекса, включив заголовки столбцов, которые позволяют сортировать по названию, автору, жанру и дате публикации.
- Реализовать логику сортировки в код-бэкенд.
- Добавить элементы управления разбиением на страницы на страницу индекса.
- Реализовать логику разбиения на страницы в код-бэкенд для обработки больших наборов данных.

### Реализовать проверку

Цель:
- Добавить клиентскую и серверную проверку в форму книги.

Инструкции:

- Добавить аннотации данных в свойства модели книги для правил проверки (например, обязательные поля, максимальная длина).
- Реализовать серверную проверку в коде-бэкенде и отобразить сообщения проверки в форме.

### Создать частичное представление для сведений о книге

Цель:
- Создать частичное представление для отображения подробной информации о выбранной книге.

Инструкции:

- Создать частичное представление, отображающее сведения о книге.
- Измените страницу индекса, включив ссылку или кнопку для просмотра сведений о книге.
- Используйте AJAX для загрузки частичного представления в модальное окно или выделенный раздел страницы без обновления всей страницы.