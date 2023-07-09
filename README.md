# CourseProjectCS2

### Стэк

* .NET Framework 4.7.2
* .NET 7.0
* ADO.NET => EntityFramework (EF)
* IDentity
* WPF / ASP / WinForms
* Sockets (TCP / UDP)

---

### Клиентская часть

#### Визуальная часть

* Описание макетов форм (верстка)
* Описание стилей (Цветовые решения, Стили элементов, Подбор шрифтов) ?
* Выбор темы (Темная Светлая) ?

#### Бизнес логика

* Локализация ?
* Отправка комманд на сервер (создание чата, редактировать сообщение, удалить сообщение, выдать роль пользователю)
* Отправка/получение сообщений
* Добавление/удаление пользователей в контакты
* Отображение списка чатов, и пользователей в чате (Находиься в данный момент в сети ?)

---

### Серверная часть

* Конфигурация из файла
* Создание поключений
* Асинхронность
* Запрос к бд
* Отправка данных клиентской части
* Авторизация
* Логирование ?
* Возможность управления сервером внутри программы (Ожидание ввода команд из консоли пример: ```shutdown``` остановит прослушивание сокетов, закроет уже открытые сокеты, закроет приложение). В процессе ожидания ввода не останавливает вывод информации (Многопоточность)
* Парсер сообщений

---

### База данных

* Проектирование базы данных
* Попытка написать собственную ОРМ либо хранимаыми процедурами либо програмным кодом

---

#### Уточнение

```пункт ?``` - Задачи не первостепенной важности в текущем проекте

```Понимание чатов``` - Груповой чат тоже самое что и чат один-на-один принцип такой же как и у групповых, создается в БД при первой отпрвки сообщения другому пользователю

```сообщение``` - Сериализуемый класс содержащий: *Отправителя*, *Текст сообщения*, *дату/вермя*. Храниться в истории чата.

```чат``` - Содержит полователей и их роли в чате, а также историю сообщений

```Роли пользователей``` - Привилегии указывающие серверу что может делать пользователей в чате, в котором пользователь числится. Глобально пользователь не имеет роли

```Понимание сокетов``` - Делятся на 2 группы Серверный сокет и Клиентский сокет. Данные между сокетами отправляются массивом байт. Массив байт можно попытатся привести к любому классу/типу что позволяет сериализовывать и отправлять определенные параметром ```[serializeable]``` классы по сети. Должно иметься Классы отправляемые по сети как на сервере так и на клиенте. Что наводит на разумность поместить данный класс в dll библиотеку и поставлять с клиентской частью

## Полезное

[Консольный чат на UDP сокетах](https://metanit.com/sharp/net/5.3.php)
[WPF](https://metanit.com/sharp/wpf/1.php)
[ADO](https://metanit.com/sharp/adonetcore/)
[EF](https://metanit.com/sharp/efcore/)
[professorweb C#](https://professorweb.ru)
