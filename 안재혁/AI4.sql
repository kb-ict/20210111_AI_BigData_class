
Create Table FkTable ( FKColumn varchar(20));
Alter Table FKTable 
    Add Constraint ff Primary Key (FKColumn);
Create Table Ptable ( 
	Column1 varchar(20) Primary Key, 
	Column2 constraint FKTest References FKTable (FKColumn)
	); 

alter table ptable
add column3 varchar(20);

alter table ptable
add constraint fkfk foreign key(column3)
references fktable(fkcolumn);


create table uniqueEx(
column1 varchar2(20) constraint column1unique unique,
column2 number(3) unique,
column3 char(3));

insert into uniqueex values('1',2,'');
insert into uniqueex values('1',2,'');
insert into uniqueex values('3',4,'');


create table checkex(
column1 number(3) check(column1 between 1 and 10),
column2 varchar(20) check(column2 in('y','n')),
column3 varchar2(10));

insert into checkex values(2,'y','');
insert into checkex values(20,'ppp','');




alter table CheckEx 
    add constraint chk3 check (column3 in ('A','B','C','D','F'));

insert into checkex values(1,'n','A');
insert into checkex values(1,'n','K');
insert into checkex values(1,'m','A');




Create Table DefaultEx(	
	column1 varchar(30),
	column2 varchar2(20) Default '기본값',
    column3 number(5) Default 1234 			
   );

insert into defaultex(column1) values('떙땡');
insert into defaultex values('떙똫',default,default);
insert into defaultex values('당당',NULL,NULL);
select * from defaultex;


alter table defaultex
modify column3 default 123;

create table notnullex
(column1 varchar2(20) not null unique,
column2 number(3) );

alter table notnullex
modify column2 constraint column2notnullr not null;

 alter table notnullex drop constraint
 column2notnullr;


set serveroutput on;
declare 
var1 number(5);
begin 
var1:=100;
if var1=100 then
dbms_output.put_line('100입니다');
else 
dbms_output.put_line('100이 아닙니다');
end if;
end;





declare
hiredate date;
curdate date;
wdays number(5);
begin
select hire_date into hiredate 
from AI.employees
where EMPLOYEES_ID =200;
curdate := current_date();
wdays :=curdate - hiredate;
if(wdays/365)>= 15 then
dbms_output.put_line('입사한지 '||wdays||' 일이나 지났습니다. 축하합니다');
else
dbms_output.put_line('입사한지 '||wdays||' 일 밖에 안됐네요 열심히 하세요.');
end if;
end;

declare
pnumber number(3);
credit char(1);
begin
pnumber :=50;
case 
when pnumber>=90 then
credit :='A';
when pnumber>=80 then
credit :='B';
when pnumber>=70 then
credit :='C';
when pnumber>=60 then
credit :='D';
else
credit :='F';
end case;
DBMS_OUTPUT.PUT_LINE('취득점수==>'||pnumber||',학점==>'||credit);
end;






select u.userid,u.username,sum(price*amount),
case
when (sum(price*amount))>=1500 then '최우수고객'
when (sum(price*amount))>=1000 then '우수고객'
when (sum(price*amount))>=1 then '일반고객'
else '유령고객'
end as 등급
from buytbl b
right join usertbl u
on b.userid=u.userid
group by u.username, u.userid
order by sum(price*amount) desc nulls last;


declare
num number(7);
isum number(7);

begin
num :=1;
isum :=0;
while num <=1000
loop
if (mod(num,3)=0) or (mod(num,8)=0) then
isum := isum+num;

end if;
num := num+1;
end loop;
DBMS_OUTPUT.put_line(isum);
end;

declare
inum number(5);
anum number(5);

begin
select year into inum
from lotto
while 
loop
if









