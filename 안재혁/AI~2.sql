--create table student(
--studentNO NUMBER(8) PRIMARY KEY,
--name varchar(5),
--phonenumber varchar(13),
--city varchar(3),
--department varchar(5)
--);

--insert into student values(
--'21911111', '민수', '010-1111-1111', '대구', '역사학과');

--insert into student values(
--'21911112', '철수', '010-1111-2222', '서울', '정보통신과'
--);
--
--insert into student values(
--'21911113', '영희', '010-1111-3333', '부산', '국문학과'
--);

--insert into student values(
--'21911114', '민희', '010-1234-1234', '대구', '영문학과'
--);

--alter table student
--add professor varchar(20);

update student set professor='김명수'
where name='영희';







