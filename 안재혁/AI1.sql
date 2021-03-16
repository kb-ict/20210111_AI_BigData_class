--create table emp2 as
--(select * from emp);
--
--update emp2 set ename='마이크' where empno=7499;
--commit;
--
--update emp2 set ename='삼월이'
--where empno=7499;
--
--alter table emp2 rename column sal to money;
--
--rollback;
--
--update emp2 set ename='THISis'
--where empno=7499;
--
--commit;
--
----alter table emp2 rename column sal to amount;
--
----rollback;

--select * from Employees
--where First_name='Peter' and salary>5000;
--
--select * from Employees
--where first_name='Peter' or First_name='Den';
--
--select * from Employees 
--where hire_date between '05/05/10 and '10/10/10';

--Select * from employees 
--where first_name=‘Peter’ and Salary=5000*2;
--
--Select * from employees 
--where first_name=‘Peter’ and Salary=5000/2;
--
--Select * from employees 
--where first_name=‘Peter’ and Salary=5000*2 - 1000;

--select * from employees
--where first_name<>'Peter';

--select * from employees
--where first_name!='peter';

--select * from Employees
--where first_name IN('Peter','Adam','Den');

--sELECT * FROM jobs order by job_title ASC, job_id desc;

--SELECT
--    *
--FROM jobs order by job_title DESC;

--select ename, sal
--from emp
--where sal>=2850;
--
--select ename,deptno
--from emp
--where empno=7566;
--
--select ename, sal
--from emp
--where sal<1500 or sal>2850;
--
-- select job_id from employees 
-- WHERE job_id LIKE '%LE%';
-- 
-- select job_id from employees
-- where job_id like 'I%';
-- 
-- select job_id from employees
-- where job_id like '_T%';
-- 
-- select job_id from employees
-- where job_id not like '%LE%';
--
--SELECT ep.employee_id as 사원번호, ep.commission_pct
--FROM employees where ep.commission_pct is null;
--
--select ep.employee_id as 사원번호, ep.commission_pct
--from employees ep
--where ep.commission_pct is not null;
--
--select ep.employee_id as 사원번호, ep.commission_pct
--from employees ep
--where ep.commission_pct = null;
--
--select ep.employee_id as 사원번호, ep.commission_pct
--from employees ep
--where ep.commission_pct <> null;
--
--select * from employees
--where salary >=(select salary from employees where employee_id=158);
--
--select * from employees where salary
-->= any(select salary from employees where manager_id=147);
--
--select * from employees where salary 
-->=all(select salary from employees where manager_id = 147);
--
--select * from employees where salary
-->=some(select salary from employees where manager_id=147);
--
--select distinct job_id from job_history;
--select job_id from job_history;
--
--select distinct job as 직업 from emp;
--select job as 잡 from emp;

--select first_name as 성, last_name as 이름, hire_date 
--from (select * from employees order by hire_date desc)
--where rownum<=5;
--
--select first_name as 성, last_name as 이름, hire_date, salary as 급여
--from (select * from employees order by hire_date desc)
--where rownum<=10;

--1번문제
 select distinct job as 직업
 from emp;
 
-- 5번문제
select ename as 이름, job as 직업, hiredate as 입사일
from (select ename, job, hiredate from emp order by hiredate ASC)
--order by를 where절에 써도 됨.
where hiredate between '81/02/20' and '81/05/01';

--6번문제
select ename as 이름, deptno as 부서번호
from emp 
where deptno = 10 or deptno = 30 order by ename ASC;
--deptno in (10,30) order by ename asc;

--7번문제
select ename as 사원, sal as 월급
from (select ename, sal, deptno from emp where sal >= 1500)
where  (Deptno = 10 or deptno = 30) and sal>1500;
--deptno in (10,30) and sal>1500;

--8번문제
select ename as 사원, job as 직위
from emp
where MGR is null;

--9번문제
select ename as 사원, sal as 급여, comm as 커미션
from (select ename, sal, comm from emp order by sal desc)
where comm is not null;
--comm is not null order by sal desc;
--and (comm is null or comm=0)

--10번문제
select ename as 사원, job as 직업, sal as 급여
from (select ename, job, sal from emp where sal != 1000 and sal !=3000 and sal !=5000)
where (job='CLERK' or job='ANALYST');
--job in ('CLERK', 'ANALYST') and sal not in (1000,3000,5000);








 