create table Couress (
	Id int primary key identity not null,
	CouresName varchar(20) unique not null,
	Price int not null,
);

create table [Semester cycle] (
	Id int primary key identity not null,
	CouresId int not null,
	Semester varchar(20) not null,
	StartDate date not null,
	Days int not null,
	Hours int not null,
	foreign key (CouresId) references Couress(Id)
);

create table [Lecturer details] (
	Id int primary key identity not null,
	Name varchar(20) unique not null,
	Tariff int not null
);

create table Lecturers (
	Id int primary key identity not null,
	SemesterId int not null,
	LecturerId int not null,
	Subject varchar(20) not null,
	AcademicHours int not null,
	foreign key (SemesterId) references [Semester cycle](Id),
	foreign key (LecturerId) references [Lecturer details](Id),
);


create table [Student details] (
	Id int primary key identity not null,
	Name varchar(20) not null,
	Phone bigint not null,
	Gmail varchar(30),
	Address varchar(30),
	AccountBalance int not null
);

create table Students (
	Id int primary key identity not null,
	StudentsId int not null,
	SemesterId int not null,
	foreign key (StudentsId) references [Student details](Id),
	foreign key (SemesterId) references [Semester cycle](Id),
);

create table Payments (
	Id int primary key identity not null,
	Student_SemesterID int not null,
	Payment int not null,
	foreign key (Student_SemesterID) references Students(Id),
);