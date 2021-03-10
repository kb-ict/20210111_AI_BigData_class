--select sum(price)from buyTbl;
--select cast(avg(price)as number(8,3)) from buytbl;
--select min(price) from buytbl;
--select max(price) from buytbl;
--select cast(STDDEV(price)as number(8,2)) from buytbl;
--select cast(variance(price)as number(20,3)) from buyTBL;
--select userid, sum(amount)
--from buytbl group by userid;
--select userid as "사용자 아이디", 
----sum(price*amount)as"총구매액"
----from buytbl group by userid
----HAVING sum(price*amount)>1000;
----select idnum, groupname, sum(price*amount)as "비용",
----grouping_id(idnum)as"추가비용"
----from buytbl group by rollup(groupname, idnum);
----
----select groupname, sum(price*amount)as"비용"
----from buytbl 
----group by rollup(groupname);
--
----select deptno, count(*)as"부서별 인원", 
----cast(avg(sal)as number(10,2))as"부서별 평균급여",
----sum(sal)as"부서별 급여" 
----from emp group by deptno;
----
----select job, count(*)as"업무별 인원",
----cast(avg(sal)as number(10,2))as "평균급여",
----max(sal)as"최고급여액", 
----min(sal)as"최저급여액",
----sum(sal)from 
----emp group by job;
----
------3. EMP테이블에서 직업별로 그룹화하고 전체 월급이       
------5000을 초과하는 직업과, 직업별 월급여합계를 출력하라
----select job, sum(sal)as"직업별 월급여합계"
----from emp group by job
----having sum(sal)>5000;
----
------4. Employees 테이블에서 Job_ID 별 소속 Employees_ID와 급여, 급여합계, 총합계까지 출력하라. 
------    단 급여합계와 총합계는 행에서 출력하고
------    합계를 구분할 수 있는 열도 같이 출력하라
----select employee_id, job_id, 
----count(employee_id), 
----sum(salary) as"급여"
----,grouping_id (employee_id)as"합계 구분"
----from employees group by ROLLUP(employee_id,job_id) ;
----
------5. usertbl 테이블에서 지역(addr) 별 이름(username)과, 키(height), 평균키, 총 인원의 평균키까지 출력하라. 
------단 지역별 평균키와 총원의 평균키는 행에서 출력하고
------    평균값 행을 구분할 수 있는 열도 같이 출력하라
----select addr,username, 
----avg(height)"평균키"
----,grouping_id(username)"구분"
----from usertbl group by rollup(addr, username);
--
---- union (합집합)두 쿼리의 결과를 하나로 합치는 것
---- 중복된 데이터는 제거
---- 부서 번호가 10인 행과 부서 번화가 20인 행의 합집합
---- unuon all은 중복 제거 하지 않는다
--select empno, ename, sal, deptno
--from emp where deptno=10 
--union all
--select empno, ename, sal, deptno
--from emp where deptno=20; 
---- with 비재귀적 CTE
--with abc(userID, total)
--as
--(select userID, sum(price*amount)
--from buytbl GROUP by userID)
--select *from abc order by total desc;
---- with 비재귀적 CTE
----with abc(userID, total)
----as
----(select userID, sum(price*amount)
----from buytbl GROUP by userID)
----select *from abc order by total desc;
----select * from CTE_ABC;
--
----비재귀적 CTE
---- 1단계
----select addr, max(height)
----from usertbl group by addr
----2단계
--wITH CTE_AH(addr, height)
--as
--(select addr,max(height)
--from usertbl group by addr)
----3단계 : 키의 평군을 구하는 쿼리
--select avg(height)as"각 지역별 최고의 평균" from CTE_AH;
--
----4단계: 2와 3단계를 합침
--wITH CTE_AH(addr, height)
--as
--(select addr,max(height)
--from usertbl group by addr)
--select avg(height)as"각 지역별 최고의 평균", sum(height)"각 지역별 최고의 합계" from CTE_AH;
--
----select * from CTE_AH;
--
---- 중복 CTE
--with aaa(userid, total)
--as
--(select userid, sum(price*amount)from buytbl group by userid),
--bbb(sumtotal)
--as
--(select sum(total) from aaa),
--ccc(sumavg)
--as 
--(select sumtotal/(select count(*)from buytbl)from bbb),
--ddd(total,avg)
--as
--(select sumtotal from bbb, select sumavg from ccc)
--;
--
--
----1. 비재귀적CTE를 만드는 단계를 거쳐 BUYTBL 테이블에서 		그룹별 최소가격의 평균을 출력하라
--with avgt(gname, min_price)
--as
--(select groupname, min(price)from buytbl group by groupname)
--select avg(min_price)"최소가격의 평균", sum(min_price)"최소가격의 합계"from avgt;
----2. EMPLOYEES 테이블에서 WITH을 사용하여 JOB_ID별 			최고 급여의 평균과 합계를 출력하라
--with cte_job(job,max_salary)
--as
--(select job_id, max(salary)from employees group by job_id)
--select cast(avg(max_salary)as number(6, 2))"최고 급여의 평균", 
--sum(max_salary)"최고 급여의 합계"from cte_job;
--
--select  Rpad('이것이',10, '##') from DUAL;
--create table emptbl (emp nchar(3), manager nchar(3), department nchar(3));
--insert into emptbl values('나사장','없음','없음');
--insert into emptbl values('김재무','나사장','재무부');
--insert into emptbl values('김부장','김재무','재무부');
--insert into emptbl values('이부장','김재무','재무부');
--insert into emptbl values('우대리','이부장','재무부');
--insert into emptbl values('지사원','이부장','재무부');
--insert into emptbl values('이영업','나사장','영업부');
--insert into emptbl values('한과장','이영업','영업부');
--insert into emptbl values('최정보','나사장','정보부');
--insert into emptbl values('윤차장','최정보','정보부');
--insert into emptbl values('이주임','윤차장','정보부');

-- 재귀적 CTE
--with empCTE(empname,mgrname,dept,emplevel)
--as
--(
--(select emp, manager, department, 0 
--from emptbl where manager='없음')
--union all
--(select emptbl.emp, emptbl.manager, emptbl.department, empCTE.emplevel+1
--from emptbl,empCTE
--where emptbl.manager=empCTE.empname)
--)
--select * from empCTE order by dept, emplavel;

WITH empCTE(empName, mgrName, dept, empLevel)
AS
(
 ( SELECT emp, manager, department , 0  
       FROM empTbl 
       WHERE manager = '없음' )
  UNION ALL
  (SELECT empTbl.emp, empTbl.manager, empTbl.department, empCTE.empLevel+1
   FROM empTbl ,empCTE
    WHERE EMPTBL.MANAGER=EMPCTE.EMPNAME)
)
SELECT * FROM empCTE ORDER BY dept, empLevel;
--
--
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
SELECT CONCAT(RPAD(' ㄴ', empLevel*2 + 1, 'ㄴ'),  empName) AS "직원이름", 
dept AS "직원부서"  FROM empCTE  ORDER BY dept, empLevel;

select RPAD(' ㄴ', 2*2 + 1, 'ㄴ') from dual;
select RPAD(' ㄴ', 1*2 + 1, 'ㄴ'),RPAD(' ㄴ', 2*2 + 1, 'ㄴ') from dual;
--
--
WITH empCTE(empName, mgrName, dept, empLevel)
AS
(
 ( SELECT emp, manager, department , 0  
       FROM empTbl 
       WHERE manager = '없음' ) -- 상관이 없는 사람이 바로 사장
  UNION ALL
  (SELECT empTbl.emp, empTbl.manager, empTbl.department, empCTE.empLevel+1
   FROM empTbl  ,empCTE
    WHERE EMPTBL.MANAGER=EMPCTE.EMPNAME 
    AND empLevel < 2)
)
SELECT CONCAT(RPAD(' ㄴ', empLevel*2 + 1, 'ㄴ'),  empName) AS "직원이름", dept AS "직원부서"
   FROM empCTE  ORDER BY dept, empLevel;


