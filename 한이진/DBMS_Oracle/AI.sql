--select sum(price)from buyTbl;
--select cast(avg(price)as number(8,3)) from buytbl;
--select min(price) from buytbl;
--select max(price) from buytbl;
--select cast(STDDEV(price)as number(8,2)) from buytbl;
--select cast(variance(price)as number(20,3)) from buyTBL;
--select userid, sum(amount)
--from buytbl group by userid;
--select userid as "사용자 아이디", 
--sum(price*amount)as"총구매액"
--from buytbl group by userid
--HAVING sum(price*amount)>1000;
--select idnum, groupname, sum(price*amount)as "비용",
--grouping_id(idnum)as"추가비용"
--from buytbl group by rollup(groupname, idnum);
--
--select groupname, sum(price*amount)as"비용"
--from buytbl 
--group by rollup(groupname);

--select deptno, count(*)as"부서별 인원", 
--cast(avg(sal)as number(10,2))as"부서별 평균급여",
--sum(sal)as"부서별 급여" 
--from emp group by deptno;
--
--select job, count(*)as"업무별 인원",
--cast(avg(sal)as number(10,2))as "평균급여",
--max(sal)as"최고급여액", 
--min(sal)as"최저급여액",
--sum(sal)from 
--emp group by job;
--
----3. EMP테이블에서 직업별로 그룹화하고 전체 월급이       
----5000을 초과하는 직업과, 직업별 월급여합계를 출력하라
--select job, sum(sal)as"직업별 월급여합계"
--from emp group by job
--having sum(sal)>5000;
--
----4. Employees 테이블에서 Job_ID 별 소속 Employees_ID와 급여, 급여합계, 총합계까지 출력하라. 
----    단 급여합계와 총합계는 행에서 출력하고
----    합계를 구분할 수 있는 열도 같이 출력하라
--select employee_id, job_id, 
--count(employee_id), 
--sum(salary) as"급여"
--,grouping_id (employee_id)as"합계 구분"
--from employees group by ROLLUP(employee_id,job_id) ;
--
----5. usertbl 테이블에서 지역(addr) 별 이름(username)과, 키(height), 평균키, 총 인원의 평균키까지 출력하라. 
----단 지역별 평균키와 총원의 평균키는 행에서 출력하고
----    평균값 행을 구분할 수 있는 열도 같이 출력하라
--select addr,username, 
--avg(height)"평균키"
--,grouping_id(username)"구분"
--from usertbl group by rollup(addr, username);

-- union (합집합)두 쿼리의 결과를 하나로 합치는 것
-- 중복된 데이터는 제거
-- 부서 번호가 10인 행과 부서 번화가 20인 행의 합집합
-- unuon all은 중복 제거 하지 않는다
select empno, ename, sal, deptno
from emp where deptno=10 
union all
select empno, ename, sal, deptno
from emp where deptno=20; 
-- with 비재귀적 CTE
with abc(userID, total)
as
(select userID, sum(price*amount)
from buytbl GROUP by userID)
select *from abc order by total desc;
-- with 비재귀적 CTE
--with abc(userID, total)
--as
--(select userID, sum(price*amount)
--from buytbl GROUP by userID)
--select *from abc order by total desc;
--select * from CTE_ABC;

--비재귀적 CTE
-- 1단계
--select addr, max(height)
--from usertbl group by addr
--2단계
wITH CTE_AH(addr, height)
as
(select addr,max(height)
from usertbl group by addr)
--3단계 : 키의 평군을 구하는 쿼리
select avg(height)as"각 지역별 최고의 평균" from CTE_AH;

--4단계: 2와 3단계를 합침
wITH CTE_AH(addr, height)
as
(select addr,max(height)
from usertbl group by addr)
select avg(height)as"각 지역별 최고의 평균" from CTE_AH;

select * from CTE_AH;
