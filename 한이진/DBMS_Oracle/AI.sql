--select sum(price)from buyTbl;
--select cast(avg(price)as number(8,3)) from buytbl;
--select min(price) from buytbl;
--select max(price) from buytbl;
--select cast(STDDEV(price)as number(8,2)) from buytbl;
--select cast(variance(price)as number(20,3)) from buyTBL;
--select userid, sum(amount)
--from buytbl group by userid;
--select userid as "����� ���̵�", 
--sum(price*amount)as"�ѱ��ž�"
--from buytbl group by userid
--HAVING sum(price*amount)>1000;
--select idnum, groupname, sum(price*amount)as "���",
--grouping_id(idnum)as"�߰����"
--from buytbl group by rollup(groupname, idnum);
--
--select groupname, sum(price*amount)as"���"
--from buytbl 
--group by rollup(groupname);

--select deptno, count(*)as"�μ��� �ο�", 
--cast(avg(sal)as number(10,2))as"�μ��� ��ձ޿�",
--sum(sal)as"�μ��� �޿�" 
--from emp group by deptno;
--
--select job, count(*)as"������ �ο�",
--cast(avg(sal)as number(10,2))as "��ձ޿�",
--max(sal)as"�ְ�޿���", 
--min(sal)as"�����޿���",
--sum(sal)from 
--emp group by job;
--
----3. EMP���̺��� �������� �׷�ȭ�ϰ� ��ü ������       
----5000�� �ʰ��ϴ� ������, ������ ���޿��հ踦 ����϶�
--select job, sum(sal)as"������ ���޿��հ�"
--from emp group by job
--having sum(sal)>5000;
--
----4. Employees ���̺��� Job_ID �� �Ҽ� Employees_ID�� �޿�, �޿��հ�, ���հ���� ����϶�. 
----    �� �޿��հ�� ���հ�� �࿡�� ����ϰ�
----    �հ踦 ������ �� �ִ� ���� ���� ����϶�
--select employee_id, job_id, 
--count(employee_id), 
--sum(salary) as"�޿�"
--,grouping_id (employee_id)as"�հ� ����"
--from employees group by ROLLUP(employee_id,job_id) ;
--
----5. usertbl ���̺��� ����(addr) �� �̸�(username)��, Ű(height), ���Ű, �� �ο��� ���Ű���� ����϶�. 
----�� ������ ���Ű�� �ѿ��� ���Ű�� �࿡�� ����ϰ�
----    ��հ� ���� ������ �� �ִ� ���� ���� ����϶�
--select addr,username, 
--avg(height)"���Ű"
--,grouping_id(username)"����"
--from usertbl group by rollup(addr, username);

-- union (������)�� ������ ����� �ϳ��� ��ġ�� ��
-- �ߺ��� �����ʹ� ����
-- �μ� ��ȣ�� 10�� ��� �μ� ��ȭ�� 20�� ���� ������
-- unuon all�� �ߺ� ���� ���� �ʴ´�
select empno, ename, sal, deptno
from emp where deptno=10 
union all
select empno, ename, sal, deptno
from emp where deptno=20; 
-- with ������� CTE
with abc(userID, total)
as
(select userID, sum(price*amount)
from buytbl GROUP by userID)
select *from abc order by total desc;
-- with ������� CTE
--with abc(userID, total)
--as
--(select userID, sum(price*amount)
--from buytbl GROUP by userID)
--select *from abc order by total desc;
--select * from CTE_ABC;

--������� CTE
-- 1�ܰ�
--select addr, max(height)
--from usertbl group by addr
--2�ܰ�
wITH CTE_AH(addr, height)
as
(select addr,max(height)
from usertbl group by addr)
--3�ܰ� : Ű�� ���� ���ϴ� ����
select avg(height)as"�� ������ �ְ��� ���" from CTE_AH;

--4�ܰ�: 2�� 3�ܰ踦 ��ħ
wITH CTE_AH(addr, height)
as
(select addr,max(height)
from usertbl group by addr)
select avg(height)as"�� ������ �ְ��� ���" from CTE_AH;

select * from CTE_AH;
