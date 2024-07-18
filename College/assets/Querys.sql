-- הוספת קורס חדש
insert into Courses (CourseName, Price) 
values (
    @Name,
    @Price
);

-- הוספת מחזור חדש
insert into [Semester cycle] (CourseId, Semester, StartDate, Days, Hours)
values (
    (select Id from Courses where CourseName = @CourseName),
    @Semester, 
    @StartDate, 
    @Days, 
    @Hours
);

-- הוספת מרצה חדש
insert into [Lecturer details] (Name, Tariff)
values (
    @Name,
    @Tariff
);

-- הוספת מרצה ונושא בקורס
insert into Lecturers (SemesterId, LecturerId, Subject, AcademicHours)
values (
    (select Id from [Semester cycle] where Semester = @Semester and CourseId = 
        (select Id from Courses where CourseName = @CourseName)),
    (select Id from [Lecturer details] where Name = @LecturerName),
    @Subject,
    @AcademicHours
);

-- הוספת תלמיד חדש
insert into [Student details] (Name, Phone, Gmail, Address, AccountBalance)
values (
    @Name,
    @Phone,
    @Gmail,
    @Address,
    0
);

-- הרשמה לקורס ועדכון היתרה
insert into Students (StudentId, SemesterId)
values (
    (select Id from [Student details] where Name = @StudentName),
    (select Id from [Semester cycle] where Semester = @Semester and CourseId = 
        (select Id from Courses where CourseName = @CourseName))
);

update [Student details]
set AccountBalance = (select Price from Courses where CourseName = @CourseName)
where Name = @StudentName;

-- הוספת תשלום ועדכון יתרה
insert into Payments (Student_SemesterID, Payment)
values (
    (select Students.Id from Students
     inner join [Student details] on Students.StudentId = [Student details].Id
     inner join [Semester cycle] on Students.SemesterId = [Semester cycle].Id
     inner join Courses on Courses.Id = [Semester cycle].CourseId
     where [Student details].Name = @StudentName and Courses.CourseName = @CourseName),
    @Payment
);

update [Student details]
set AccountBalance = AccountBalance - @Payment
where Name = @StudentName;
