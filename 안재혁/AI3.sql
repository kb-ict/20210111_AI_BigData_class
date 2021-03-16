select sum(price) from buyTbL;
select cast(avg(price)as number(8,3)) from buyTbL;
select min(price) from buyTbL;
select max(price) from buyTbL;
select STDDEV(price) from buyTbL;
select cast(variance(price)as  number(20,3)) from buyTbL;


select userID,sum(amount)
from buyTBL group by userid;

select userID as "사용자 아이디",
sum(price*amount)as "총 구매액"
from buyTBL group by userID
having sum(price*amount)>1000;

select idnum,groupName,sum(price*amount)as 비용
from buyTbl group by rollup(groupname,idnum);

select groupName,sum(price*amount)as 비용
from buyTbl group by rollup(groupname);

select groupName,sum(price*amount)as 비용,
grouping_ID(idnum)as 추가행여부
from buyTbl 
group by rollup(groupname,idnum);

--1
select deptno,count(deptno)as 부서합, cast(avg(sal)as number(8,1))as 평균 ,cast(sum(sal)as number(8,1))as 합
from emp
group by deptno;

--2
select job,count(job), cast(avg(sal)as number(8,1))as 평균 ,
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
SELECT AVG(Height) AS "각 지역별 최고키 평균" FROM hh;


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
select cast(avg(sal)as number(8,2)) 평균,sum(sal) 합계 from bb;



CREATE TABLE empTbl (emp NCHAR(3), manager NCHAR(3), department NCHAR(3));

INSERT INTO empTbl VALUES('나사장','없음','없음');
INSERT INTO empTbl VALUES('김재무','나사장','재무부');
INSERT INTO empTbl VALUES('김부장','김재무','재무부');
INSERT INTO empTbl VALUES('이부장','김재무','재무부');
INSERT INTO empTbl VALUES('우대리','이부장','재무부');
INSERT INTO empTbl VALUES('지사원','이부장','재무부');
INSERT INTO empTbl VALUES('이영업','나사장','영업부');
INSERT INTO empTbl VALUES('한과장','이영업','영업부');
INSERT INTO empTbl VALUES('최정보','나사장','정보부');
INSERT INTO empTbl VALUES('윤차장','최정보','정보부');
INSERT INTO empTbl VALUES('이주임','윤차장','정보부');


WITH empCTE(empName, mgrName, dept, empLevel)
AS
(
 ( SELECT emp, manager, department , 0  
       FROM empTbl 
       WHERE manager = '없음' ) -- 상관이 없는 사람이 바로 사장
  UNION ALL
  (SELECT empTbl.emp, empTbl.manager, empTbl.department, empCTE.empLevel+1
   FROM empTbl, empCTE
    WHERE EMPTBL.MANAGER=EMPCTE.EMPNAME)
)
SELECT CONCAT(RPAD('ㄴ', empLevel*2+1, 'ㄴ'),  empName) AS "직원이름", dept AS "직원부서",empLevel  FROM empCTE  ORDER BY dept, empLevel;










