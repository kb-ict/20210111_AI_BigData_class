--foreign key
--�ٸ� ���̺��� PRIMARY KEY�� �ش�
--�ش� PRIMARY KEY �÷��� �ִ� �� �Ǵ� Null ���� ���

-- FkTable ����
Create Table FkTable ( FKColumn varchar(20));
--�������� �߰�
-- alter table ���̺��̸� add constraint ���������̸� p.k(�� �̸�);
Alter Table FKTable 
    Add Constraint ff Primary Key (FKColumn);
    
-- ptable ������  p.k, f.k �������� �Բ� ����
--constraint ���������̸� references ������ ���̺�� (�����ϴ� ���̸�); 
Create Table Ptable ( 
	Column1 varchar(20) Primary Key, 
	Column2 constraint FKTest References FKTable (FKColumn)
	); 
-- �� �߰�
alter table ptable
add column3 varchar(20);
-- �������� �߰�
alter table Ptable
   add constraint fkfk foreign key (Column3)
   references fktable (fkcolumn);

-- uniqueEx���̺���� �������� ����
create Table UniqueEX(
column1 varchar2(20) constraint column1Unique Unique,
column2 number(3) constraint column2Unique Unique,
column3 char(3));

insert into uniqueex values ('1',2,'');
insert into uniqueex values ('2',2,'');
insert into uniqueex values ('3',4,'');

-- check: Ư�� ���� ���� ����
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

--default �⺻�� ����
Create Table DefaultEx(	
	column1 varchar(30),
	column2 varchar2(20) Default '�⺻��',	
    column3 number(4) Default 1234 			
   );
   
insert into defaultex
(column1) values ('����');
insert into defaultex
values ('���', null, null);
insert into defaultex
values ('���', null, DEFAULT);
--�̹� ������ ���̺� default �����Ҷ�
alter table defaultex
modify column3 default 123;

-- not null
--���� ������� �ʴ´�
-- ������ �ߺ� ���
create table NotNullEx(
column1 varchar2(20)not null unique,
column2 number(3));
-- �̹̻����� ���̺� not null ����
--ALTER TABLE ���̺�� MODIFY �÷��� NOT NULL;
alter table notnullex modify column2 constraint column2NotNull not null;
drop table notnullex;
insert into notnullex values ('101','222');
-- null���� ���� �ʴ´�
insert into notnullex values ('102',null);
insert into notnullex values ('102','333');
insert into notnullex values ('102','333');

--�������� ����
alter table notnullex
drop constraint column2notnull;
insert into notnullex values('103',null);
--ALTER TABLE NOTNULLEX  
--MODIFY (COLUMN2 DEFAULT 'BASIC' );