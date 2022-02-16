USE ExamManager_ListStudentInformation
GO
CREATE TABLE Class
(
  ClassName VARCHAR(12) PRIMARY KEY
)
GO
CREATE TABLE Student
(
	StudentId VARCHAR(7) PRIMARY KEY,
	Fullname NVARCHAR(40),
	ClassName VARCHAR(12) REFERENCES Class(ClassName)
)

SELECT * FROM CLASS
SELECT * FROM STUDENT
SELECT * FROM STUDENT WHERE ClassName = 'CTK41-PM'

insert into Class values('CTK41-PM')
insert into Class values('CTK41-MMT')
insert into Class values('CTK42')

insert into Student values('1710303',N'Phạm Hoàng Việt','CTK41-PM')
insert into Student values('1710289',N'Phan Quốc Trung','CTK41-PM')
insert into Student values('1710252',N'Trần Đình Quang','CTK41-MMT')
insert into Student values('1710249',N'Lương Tuyên Quang','CTK41-PM')
insert into Student values('1710194',N'Trần Công Khanh','CTK41-MMT')
insert into Student values('1710265',N'Nguyễn Đức Thành','CTK41-MMT')
insert into Student values('1710291',N'Trần Nhất Trường','CTK41-MMT')

insert into Student values('1812751',N'Nguyễn Thị Hà','CTK42')
insert into Student values('1710274',N'Nguyễn Tiến Thuận','CTK42')
insert into Student values('1812828',N'Võ Thị Thúy Phương','CTK42')
insert into Student values('1812805',N'Nguyễn Thị Quỳnh Nga','CTK42')

delete from Student
delete from Class