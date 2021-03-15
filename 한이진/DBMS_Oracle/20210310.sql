--foreign key
--다른 테이블에서 PRIMARY KEY에 해당
--해당 PRIMARY KEY 컬럼에 있는 값 또는 Null 값만 허용

-- FkTable 생성
Create Table FkTable ( FKColumn varchar(20));
--제약조건 추가
-- alter table 테이블이름 add constraint 제약조건이름 p.k(열 이름);
Alter Table FKTable 
    Add Constraint ff Primary Key (FKColumn);
    
-- ptable 생성과  p.k, f.k 제약조건 함께 생성
--constraint 제약조건이름 references 참조할 테이블명 (참조하는 열이름); 
Create Table Ptable ( 
	Column1 varchar(20) Primary Key, 
	Column2 constraint FKTest References FKTable (FKColumn)
	); 
-- 열 추가
alter table ptable
add column3 varchar(20);
-- 제약조건 추가
alter table Ptable
   add constraint fkfk foreign key (Column3)
   references fktable (fkcolumn);

-- uniqueEx테이블만들고 제약조건 설정
create Table UniqueEX(
column1 varchar2(20) constraint column1Unique Unique,
column2 number(3) constraint column2Unique Unique,
column3 char(3));

insert into uniqueex values ('1',2,'');
insert into uniqueex values ('2',2,'');
insert into uniqueex values ('3',4,'');

-- check: 특정 범위 값만 지정
create table checkEx(
column1 varchar2(20) constraint column1Check check (column1 between 1 and 10),
column2 number(3) constraint columne2Check check (column2 In('Y','N')),
column3 varchar2(10));

insert into checkex values(2,'Y','');
insert into checkex values (20,'FFF',''); 

alter table checkEx
add constraint column1Check check (column1 between 1 and 10);
alter table checkEx
add constraint columne2Check check (column2 In('Y','N'));
alter table checkEx
add constraint chk3 check (column2 in('A','B', 'C', 'D', 'F'));
insert into  checkEx values (1,'Y','A');
insert into checkex values(2,'N','B');
insert into checkex values

--default 기본값 지정
Create Table DefaultEx(	
	column1 varchar(30),
	column2 varchar2(20) Default '기본값',	
    column3 number(4) Default 1234 			
   );
   
insert into defaultex
(column1) values ('땡땡');
insert into defaultex
values ('당당', null, null);
insert into defaultex
values ('당당', null, DEFAULT);
--이미 생성된 테이블 default 지정할때
alter table defaultex
modify column3 default 123;

-- not null
--빈값을 허용하지 않는다
-- 데이터 중복 허용
create table NotNullEx(
column1 varchar2(20)not null unique,
column2 number(3));
-- 이미생성된 테이블에 not null 지정
--ALTER TABLE 테이블명 MODIFY 컬럼명 NOT NULL;
alter table notnullex modify column2 constraint column2NotNull not null;
drop table notnullex;
insert into notnullex values ('101','222');
-- null값이 들어가지 않는다
insert into notnullex values ('102',null);
insert into notnullex values ('102','333');
insert into notnullex values ('102','333');

--제약조건 삭제
alter table notnullex
drop constraint column2notnull;
insert into notnullex values('103',null);
--ALTER TABLE NOTNULLEX  
--MODIFY (COLUMN2 DEFAULT 'BASIC' );