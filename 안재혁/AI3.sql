select sum(price) from buyTbL;
select cast(avg(price)as number(8,3)) from buyTbL;
select min(price) from buyTbL;
select max(price) from buyTbL;
select STDDEV(price) from buyTbL;
select cast(variance(price)as  number(20,3)) from buyTbL;


select userID,sum(amount)
from buyTBL group by userid;

select userID as "����� ���̵�",
sum(price*amount)as "�� ���ž�"
from buyTBL group by userID
having sum(price*amount)>1000;

select idnum,groupName,sum(price*amount)as ���
from buyTbl group by rollup(groupname,idnum);

select groupName,sum(price*amount)as ���
from buyTbl group by rollup(groupname);

select groupName,sum(price*amount)as ���,
grouping_ID(idnum)as �߰��࿩��
from buyTbl 
group by rollup(groupname,idnum);

--1
select deptno,count(deptno)as �μ���, cast(avg(sal)as number(8,1))as ��� ,cast(sum(sal)as number(8,1))as ��
from emp
group by deptno;

--2
select job,count(job), cast(avg(sal)as number(8,1))as ��� ,
min(sal),max(sal)
from emp
group by job;

--3
select job,sum(sal)
from emp
group by job
having sum(sal)>5000;

--4
select job_ID,employee_ID,sum(salary),
grouping_ID (employee_ID)
from employees
group by rollup(job_ID,employee_ID);
--5
select ADDR,username,avg(height),
grouping_ID (username)
from USERTBL
group by rollup( username,ADDR);


select empno, ename, sal,deptno
from emp 
where deptno=10
union
select empno,ename,sal,deptno
from emp where deptno=20;

WITH abc(userID, total)
    AS
    (  SELECT userID, SUM(price*amount)  
          FROM buyTbl  GROUP BY userID  )
    SELECT * FROM abc
    ORDER BY total DESC ;
    
    with hh(locate,height)
    as(
    select addr,max(height) from usertbl 
    group by addr)
SELECT AVG(Height) AS "�� ������ �ְ�Ű ���" FROM hh;


with
aaa(userID,total)
as
(select userID,sum(price*amount) from buyTbl group by userID),
bbb(sumtotal)
as(
select sum(total) from aaa),
ccc(sumabg)
as(select sumtotal/(select count(*) from buytbl) from bbb)
select * from ccc;


with aa(groupname, PR)
as(
select groupname, min(PRICE) from BUYTBL
group by groupname)
select avg(PR) from aa  ;


with bb(job_ID,sal)
as(
select job_ID ,max(salary) from employees
group by job_ID)
select cast(avg(sal)as number(8,2)) ���,sum(sal) �հ� from bb;



CREATE TABLE empTbl (emp NCHAR(3), manager NCHAR(3), department NCHAR(3));

INSERT INTO empTbl VALUES('������','����','����');
INSERT INTO empTbl VALUES('���繫','������','�繫��');
INSERT INTO empTbl VALUES('�����','���繫','�繫��');
INSERT INTO empTbl VALUES('�̺���','���繫','�繫��');
INSERT INTO empTbl VALUES('��븮','�̺���','�繫��');
INSERT INTO empTbl VALUES('�����','�̺���','�繫��');
INSERT INTO empTbl VALUES('�̿���','������','������');
INSERT INTO empTbl VALUES('�Ѱ���','�̿���','������');
INSERT INTO empTbl VALUES('������','������','������');
INSERT INTO empTbl VALUES('������','������','������');
INSERT INTO empTbl VALUES('������','������','������');


WITH empCTE(empName, mgrName, dept, empLevel)
AS
(
 ( SELECT emp, manager, department , 0  
       FROM empTbl 
       WHERE manager = '����' ) -- ����� ���� ����� �ٷ� ����
  UNION ALL
  (SELECT empTbl.emp, empTbl.manager, empTbl.department, empCTE.empLevel+1
   FROM empTbl, empCTE
    WHERE EMPTBL.MANAGER=EMPCTE.EMPNAME)
)
SELECT CONCAT(RPAD('��', empLevel*2+1, '��'),  empName) AS "�����̸�", dept AS "�����μ�",empLevel  FROM empCTE  ORDER BY dept, empLevel;










