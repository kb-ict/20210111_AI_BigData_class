--create table emp2 as
--(select * from emp);
--
--update emp2 set ename='����ũ' where empno=7499;
--commit;
--
--update emp2 set ename='�����'
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
--where first_name=��Peter�� and Salary=5000*2;
--
--Select * from employees 
--where first_name=��Peter�� and Salary=5000/2;
--
--Select * from employees 
--where first_name=��Peter�� and Salary=5000*2 - 1000;

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
--SELECT ep.employee_id as �����ȣ, ep.commission_pct
--FROM employees where ep.commission_pct is null;
--
--select ep.employee_id as �����ȣ, ep.commission_pct
--from employees ep
--where ep.commission_pct is not null;
--
--select ep.employee_id as �����ȣ, ep.commission_pct
--from employees ep
--where ep.commission_pct = null;
--
--select ep.employee_id as �����ȣ, ep.commission_pct
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
--select distinct job as ���� from emp;
--select job as �� from emp;

--select first_name as ��, last_name as �̸�, hire_date 
--from (select * from employees order by hire_date desc)
--where rownum<=5;
--
--select first_name as ��, last_name as �̸�, hire_date, salary as �޿�
--from (select * from employees order by hire_date desc)
--where rownum<=10;

--1������
 select distinct job as ����
 from emp;
 
-- 5������
select ename as �̸�, job as ����, hiredate as �Ի���
from (select ename, job, hiredate from emp order by hiredate ASC)
--order by�� where���� �ᵵ ��.
where hiredate between '81/02/20' and '81/05/01';

--6������
select ename as �̸�, deptno as �μ���ȣ
from emp 
where deptno = 10 or deptno = 30 order by ename ASC;
--deptno in (10,30) order by ename asc;

--7������
select ename as ���, sal as ����
from (select ename, sal, deptno from emp where sal >= 1500)
where  (Deptno = 10 or deptno = 30) and sal>1500;
--deptno in (10,30) and sal>1500;

--8������
select ename as ���, job as ����
from emp
where MGR is null;

--9������
select ename as ���, sal as �޿�, comm as Ŀ�̼�
from (select ename, sal, comm from emp order by sal desc)
where comm is not null;
--comm is not null order by sal desc;
--and (comm is null or comm=0)

--10������
select ename as ���, job as ����, sal as �޿�
from (select ename, job, sal from emp where sal != 1000 and sal !=3000 and sal !=5000)
where (job='CLERK' or job='ANALYST');
--job in ('CLERK', 'ANALYST') and sal not in (1000,3000,5000);








 