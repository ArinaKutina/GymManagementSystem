# Система управления тренажерным залом «GymManagementSystem».
### Название приложения: GymManagementSystem
### Описание приложения:
**Это программное обеспечение, которое помогает тренажерным залам управлять данными о клиентах, тренерах, тренажерах. Она автоматизирует и упрощает многие задачи, такие как добавление, редактирование и удаление данных о клиентах, тренерах, тренажерах и многое другое.**

# Функции, реализованные в программе:
1. Добавление, редактирование и удаление данных о клиентах, тренерах, тренажерах.
2. Запись клиентов на тренировки к конкретным тренерам.
3. Ввод информации о посещаемости клиентов (дата и время тренировки).
4.	Поиск клиентов, тренеров, тренажеров по различным критериям.

# Технологии, которые были использованы для разработки приложения:
- **C#** - объектно-ориентированный язык программирования.
- **Visual Studio Community 2022** - интегрированная среда разработки (IDE), которая обеспечивает удобное создание, отладку и развертывание приложений.
- **Windows Presentation Foundation** - система для построения клиентских приложений Windows с визуально привлекательными возможностями взаимодействия с пользователем, графическая подсистема в составе .NET Framework, использующая язык XAML.
- **Microsoft SQL Server** - система управления реляционными базами данных (РСУБД), разработанная корпорацией Microsoft.
- **Entity Framework** - это набор технологий в ADO.NET, которые поддерживают разработку программных приложений, ориентированных на данные.

# Описание базы данных:
#### Файл базы данных называется GMS.bacpac <br/>
Файл базы данных расположен локально в проекте по пути **https://github.com/ArinaKutina/GymManagementSystem/blob/main/GymManagementApp/bin/Debug/GMS.bacpac** </br>
В базе данных находится 9 таблиц: _Users_, которая состоит из колонок _idUser_,, _login_ _pass_, _idRole_: в таблице хранятся данные о всех пользователях; _Roles_, которая состоит из колонок _idRole_, _nameRole_:в этой таблице хранятся данные о ролях в системе; _Clients_, которая состоит из колонок _idClient_, _surnameClient_, _nameClient_, _patronimicClient_, _stateAbonement_, _idTrainer_, _telephoneNum_: в таблице содержится информация о клиентах;  _Attendence_, которая состоит из колонок _idAttendence_, _idClient, _countTrainings_: в таблице содержится информация о посещаемости клиентов;  _AbonementState_, которая состоит из колонок _idAbonement_, _State_: в таблице содержится информация о состоянии абонементов;  _Trainers_, которая состоит из колонок  _idTrainer_, _surnameTrainer_, _nameTrainer_, _patronimicTrainer_, _idUser_, _idSpecialization_: в таблице содержится информация о тренерах;  _Schedule_, которая состоит из колонок _idSchedule_, _idTrainer_, _idApparatus_, _timeTraining_: в таблице содержится информация о расписании;  _Apparatus_, которая состоит из колонок _idApparatus_, _nameApparatus_, _count_: в таблице содержится информация о тренажерах; ;  _Specialization_, которая состоит из колонок _idSpecialization_, _nameTrainers_: в таблице содержится информация о состоянии абонементов.



# Скриншоты приложения:

<p align="center">
  <img <img src="https://github.com/ArinaKutina/GymManagementSystem/blob/main/Screenshots/Autorization.png">
</br>Окно авторизации
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/ArinaKutina/GymManagementSystem/blob/main/Screenshots/AdminWindow.png">
</br>Окно администратора
</br> </br> </br>
</p>


<p align="center">
  <img <img src="https://github.com/ArinaKutina/GymManagementSystem/blob/main/Screenshots/ClientEditWindow.png">
</br>Окно редактирования клиентов
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/ArinaKutina/GymManagementSystem/blob/main/Screenshots/ClientAdd.png">
</br>Добавление клиентов
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/ArinaKutina/GymManagementSystem/blob/main/Screenshots/ClientEdit.png">
</br>Редактирование клиентов
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/ArinaKutina/GymManagementSystem/blob/main/Screenshots/TrainerEditWindow.png">
</br>Окно редактирования тренеров
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/ArinaKutina/GymManagementSystem/blob/main/Screenshots/ApparatusTrainerWindow.png">
</br>Окно редактирования тренажеров
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/ArinaKutina/GymManagementSystem/blob/main/Screenshots/ManagerWindow.png">
</br>Окно менеджера
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/ArinaKutina/GymManagementSystem/blob/main/Screenshots/AbonementManager.png">
</br>Оформление абонемента
</br> </br> </br>
</p> 

<p align="center">
  <img <img src="https://github.com/ArinaKutina/GymManagementSystem/blob/main/Screenshots/ReportGenerate.png">
</br>Генерация отчета
</br> </br> </br>
</p> 

<p align="center">
  <img <img src="https://github.com/ArinaKutina/GymManagementSystem/blob/main/Screenshots/Reporttxt.png">
</br>Отчет в формате .txt
</br> </br> </br>
</p> 

<p align="center">
  <img <img src="https://github.com/ArinaKutina/GymManagementSystem/blob/main/Screenshots/TrainerWindow.png">
</br>Окно тренера
</br> </br> </br>
</p> 

<p align="center">
  <img <img src="https://github.com/ArinaKutina/GymManagementSystem/blob/main/Screenshots/ClientIsHere.png">
</br>Отмечание клиента как присутствующего
</br> </br> </br>
</p> 

<h3>Видео</h3>

https://github.com/ArinaKutina/GymManagementSystem/blob/main/Screenshots/%D0%97%D0%B0%D0%BF%D0%B8%D1%81%D1%8C%20%D1%8D%D0%BA%D1%80%D0%B0%D0%BD%D0%B0%20(12.06.2024%2015-01-24).wmv
