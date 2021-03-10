
--���� �߿��� ���� ���� ���Ǵ� ����
--�Ϲ������� Join�̶�� �ϸ� Inner Join �̴�
--Inner join ����
--Select <�� ���>
--From <ù ��° ���̺�>
--Inner Join <�� ��° ���̺�>
--On <���ε� ����>
--[Where �˻�����]

--USERTBL ���̺�� BUYTBL ���̺��� JOIN �ϴ� ����
SELECT b.userid, u.username, b.prodname, u.addr, 
	u.mobile1 || u.mobile2 AS "����ó"
   FROM BUYTBL B
       INNER JOIN USERTBL U
          ON b.userid=u.userid ;

select b.userid, u.username, b.prodname, u.addr, 
u.mobile1 || u.mobile2 as "����ó"
from buytbl b, usertbl u
where b.userid = u.userid;

select b.userid, u.username, b.prodname, u.addr
, u.mobile1 || u.mobile2 as "����ó"
from buytbl b, usertbl u;

-- ��ǰ�� ���ű���� �ִ� ���, distinct�� �ߺ��� ����
select distinct u.userid, u.username, u.addr
from usertbl u, buytbl b 
where u.userid=b.userid;

--EXISTS �� �������� ����� �����ϸ� TRUE ������ FALSE
select u.userid, u.username, u.addr
from usertbl u
where
EXISTS(select b.userid from buytbl b 
where u.userid=b.userid);


--outer join
--������ ���ǿ� �������� �ʴ� ������� ���Խ�Ű�� ��
--OUTER JOIN ����
--SELECT <�� ���>
--FROM <ù ��° ���̺�(LEFT ���̺�)>
--<LEFT | RIGHT | FULL> OUTER JOIN <�� ��° ���̺�(RIGHT ���̺�)>
--ON <���ε� ����>

--left outer join�� ���� ���̺��� ���� ��� ���
select u.userid, u.username, b.prodname, u.addr,
u.mobile1 || u.mobile2 as "����ó"
from usertbl u
left outer join buytbl b
on b.userid= u.userid;

--right outer join�� ������ ���̺��� ���� ��� ���
select u.userid, u.username, b.prodname, u.addr,
u.mobile1 || u.mobile2 as "����ó"
from buytbl b
right outer join usertbl u
on b.userid= u.userid;

--right outer join�� ������ ���̺��� ���� ��� ���
select u.userid, u.username, b.prodname, u.addr,
u.mobile1 || u.mobile2 as "����ó"
from usertbl u
right outer join buytbl b 
on b.userid= u.userid;

select u.userid, u.username, b.prodname, u.addr,
u.mobile1 || u.mobile2 as "����ó"
from buytbl b
right outer join usertbl u
on b.userid= u.userid
where b.prodname is null;

-- cross join
--�׽�Ʈ�� ����� ���� �뷮�� �����͸� ������ �� �ַ� ����Ѵ�
select *from buytbl, usertbl;

select *from buytbl cross join usertbl;

create table copy(select );

--self join
--�ڱ��ڽŰ� �����Ѵ�
select a.emp as ��������, b.emp as ���ӻ��, b.department as ���ӻ���μ�
from emptbl a
inner join emptbl b
on a.manager= b.emp
where a.emp='��븮';
-- ��븮	�̺���	�繫��

--�μ� ���̺�: DEPT , ������̺� : EMP, �޿� ��� ���̺� : SALGRADE
--DEPT : DNAME(�μ���), DEPTNO(�μ���ȣ), LOC(��ġ)// 
--EMP : EMPNO(���),ENAME(�����), JOB(����), SAL(�޿�)
--1.��� ���̺�� �μ����̺��� ��� ����� ���� �̸�, �μ���ȣ ,�μ����� ����϶�
select e.ename, d.deptno, d.dname
from emp e 
inner join dept d
on e.deptno=d.deptno;
--
select e.ename, d.deptno,d.dname from emp e 
left outer join dept d on e.deptno= d.deptno;
--
select e.ename, d.deptno, d.dname 
from emp e
left outer join dept d
on e.deptno=d.deptno;

--2. �μ����̺�� ������̺��� ��ġ�� NEW YORK��  �μ��� �����, ����, �޿�, 
--        �μ����� ����϶�
select e.ename ,e.job, e.sal, d.dname
from dept d
inner join emp e
on d.deptno=e.deptno
where d.loc= upper('new york');

select e.ename ,e.job, e.sal, d.dname
from emp e, dept d
where e.deptno=d.deptno
and upper(d.loc)=upper('new york');

select e.ename ,e.job, e.sal, d.dname
from emp e
inner join dept d
on d.deptno=e.deptno
where d.loc= upper('new york');

select e.ename, e.job, e.sal,d.loc 
from emp e,dept d
where e.deptno=d.deptno and upper(d.loc)=upper('new york');

--3. ������̺�� �μ����̺��� COMM�� NULL�� �ƴ� ����� �����, �μ���, 
--       ��ġ�� ����϶�  

select e.ename, d.dname, d.loc
from emp e
inner join dept d
on e.deptno= d.deptno
where e.comm is not null;

select e.ename, d.dname,d.loc 
from emp e, dept d  
where e.deptno=d.deptno and e.comm is not null;

select e.ename, d.dname,d.loc 
from emp e, dept d
where e.deptno= d.deptno
and e.comm is not null;

--�޿� ��� ���̺� : SALGRADE
--SALGRADE : GRADE(���),LOSAL(���Ѱ�),HISAL(���Ѱ�)
--4.�μ� ���̺�� ������̺��� �޿��� 2000 �̻��� ����� ���, ����� , �޿� ,  
--    �μ����� ����϶�(�޿����� �������� ����)
select e.empno, e.ename, e.sal, d.deptno
from emp e
inner join dept d
on d.deptno=e.deptno
where sal>=2000
order by e.sal desc;

select b.empno, b.sal, a.dname 
from dept a, emp b 
where a.deptno=b.deptno
and b.sal >= 2000 order by sal desc;

select e.empno,
d.empno, d.sal, d.dname
from emp e, dept d
where e.deptno= d.deptno
and e.sal>=2000
order by e.sal desc;
--5. �μ� ���̺�� ��� ���̺��� ������ Manager�̸� �޿��� 2500 �̻��� ����� 
--     ���, �����, ����, �޿� , �μ����� ����϶�(������� �������� ����). 
select e.empno, e.ename, e.job, e.sal, d.deptno
from emp e
inner join dept d
on e.deptno=d.deptno
where e.job=upper('manager') and e.sal>=2500
order by e.empno asc;

select a.empno, a.ename,a.job,a.sal,b.dname
from emp a, dept b 
where a.deptno=b.deptno
and upper(a.job)=upper('manager') and a.sal > 2500
order by a.empno asc;

select a.empno, a.ename,a.job,a.sal,b.dname
from emp e, dept d
where e.deptno=d.deptno
and upper(e.job)=upper('manager')
and e.sal > 2500
order by e.empno asc;

--�޿� ��� ���̺� : SALGRADE
--SALGRADE : GRADE(���),LOSAL(���Ѱ�),HISAL(���Ѱ�)
--
--6. ��� ���̺�� �޿� ��� ���̺��� �޿��� ���Ѱ��� ���Ѱ� ������ ���Եǰ� 
--     ����� 4�� ���, �����, �޿�, ����� ����϶�. (�޿����� �������� ����)
select e.empno, e.ename, e.sal, s.grade
from emp e
left outer join salgrade s
on e.sal between s.losal and s.hisal 
where s.grade= 4
order by e.sal desc; 

select e.empno, e.ename, e.sal, s.grade
from emp e, salgrade s
where e.sal between s.losal and s.hisal
and s.grade=4
order by e.sal desc;

select e.empno, e.ename,e.sal, s.grade
from emp e, salgrade s
where s.grade=4
and e.sal between s.losal and s.hisal
order by e.sal desc;

--7.������̺�� �μ����̺��� ����� L �ڰ� �ִ� ����� �����, ����, �μ���, ��ġ�� ����϶�
select e.ename, e.job, d.dname, d.loc
from emp e
inner join dept d
on e.deptno=d.deptno
where e.ename like '%L%';

select e.ename, e.job, d.dname, d.loc
from emp e, dept d
where e.deptno=d.deptno
and e.ename like '%L%';

--8.��� ���̺��� ����� �����ں��� ���� �Ի��� ����� �����, �̸�, �Ի���, ������ �̸�, ������ �Ի����� ����϶�
select e.ename, e.hiredate, m.ename, m.hiredate
from emp e
inner join emp m
on e.mgr= m.empno
where e.hiredate<m.hiredate;

select a.ename, a.hiredate, b.ename, b.hiredate
    from emp a --���
    inner join emp b --������
    on a.mgr=b.empno
where a.hiredate<b.hiredate;
--9.DALLAS�� �ٹ��ϴ� ��� �� �޿� 1500 �̻��� ����� �̸�, �޿�, �Ի��� , 
--    COMM�� ����϶�
select e.ename, e.sal, e.hiredate, e.comm
from emp e
inner join dept d
on e.deptno=d.deptno
where d.loc=upper('dallas') and e.sal>=1500;

select e.ename, e.sal, e.hiredate, e.comm
from emp e, dept d
where e.deptno= d.deptno
and upper(d.loc)=upper('dallas')
and e.sal>=1500;


--10.���� �� ����ð� �������� �ٹ� ���� ���� 30��(12 * 30����) ���� ���� ����� 
--   �̸�, �޿� , �Ի��� , �μ����� ����϶�
select e.ename, e.sal, e.hiredate, d.dname
from emp e
inner join dept d
on e.deptno=d.deptno
where months_between (sysdate, e.hiredate)>(12*36);

select e.ename, e. sal, e.hiredate, d.dname
from emp e, dept d
where e.deptno=d.deptno
and months_between(sysdate, e.hiredate)>(12*36);