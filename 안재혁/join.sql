select length('한글'), length('AB'),
lengthb('한글'), lengthb('AB') from dual;

select concat('이것이','Oracle이다'),
'이것이'||''||'oravle이다' from dual;

SELECT INSTR('이것이 Oracle이다. 이것도 오라클이다', '이것') FROM DUAL;
SELECT INSTR('이것이 Oracle이다. 이것도 오라클이다', '이것', 2) FROM DUAL;
SELECT INSTRB('이것이 Oracle이다. 이것도 오라클이다', '이것', 2) FROM DUAL;

SELECT LOWER('abcdEFGH'), UPPER('abcdEFGH'), 
INITCAP('this is oracle') FROM DUAL;

select replace('이것이 oracle이다','이것이','this is') from dual;
select translate('이것이 oracle이다','이것','AB') from dual;

select substr('대한민국만세',3,2) from dual;

select reverse('Oracl') from dual;

select (substr('삼성전자와 애플의 전자대결.',1,4)||'vs'||
substr('삼성전자와 애플의 전자대결.',7,2))
from dual;

SELECT LPAD('이것이', 10, '##'), RPAD('이것이', 10, '##') FROM DUAL;
SELECT LTRIM('   이것이'), RTRIM('이것이$$$', '$') FROM DUAL;
SELECT TRIM('   이것이   '), 
	TRIM(BOTH 'ㅋ' FROM 'ㅋㅋㅋ재밌어요.ㅋㅋㅋ') FROM DUAL;


SELECT ABS(-100) FROM DUAL;
SELECT CEIL(4.7), FLOOR(4.7), ROUND(4.7) FROM DUAL;
select round(3478,-2) from dual;
SELECT TRUNC(12345.12345, 2), TRUNC(12345.12345, -2) FROM DUAL;

SELECT MOD(157, 10) FROM DUAL;
SELECT POWER(2,3), SQRT(9) FROM DUAL;

SELECT SYSDATE FROM DUAL;



SELECT  B.USERID, U.USERNAME, B.PRODNAME, U.ADDR, 
	U.MOBILE1 || U.MOBILE2 AS 연락처
   FROM BUYTBL B
       INNER JOIN USERTBL U
          ON B.USERID=U.USERID ;

SELECT B.USERID, U.USERNAME, B.PRODNAME, U.ADDR, 
	U.MOBILE1 || U.MOBILE2 AS 연락처
   FROM BUYTBL B, USERTBL U
          WHERE B.USERID=U.USERID ;

SELECT B.USERID, U.USERNAME, B.PRODNAME, U.ADDR, 
	U.MOBILE1 || U.MOBILE2 AS 연락처
   FROM BUYTBL B, USERTBL U ;




SELECT U.USERID, U.USERNAME,U.ADDR
    FROM USERTBL U
    WHERE 
    EXISTS(SELECT B.USERID FROM BUYTBL B WHERE U.USERID=B.USERID) ;

SELECT U.USERID, U.USERNAME, B.PRODNAME, U.ADDR, 
	U.MOBILE1||'-'||U.MOBILE2 AS "연락처"
   FROM USERTBL U
       LEFT OUTER JOIN BUYTBL B
          ON B.USERID=U.USERID ; 

 



SELECT U.USERID, U.USERNAME, B.PRODNAME, U.ADDR, 
	U.MOBILE1||'-'||U.MOBILE2 AS "연락처"
   FROM BUYTBL B
       RIGHT OUTER JOIN USERTBL U
          ON B.USERID=U.USERID ;


SELECT A.EMP AS 부하직원,  B.EMP AS 직속상관, B.DEPARTMENT AS 직속상관부서
FROM EMPTBL A
INNER JOIN EMPTBL B
ON A.MANAGER = B.EMP
WHERE A.EMP = '우대리'; 

--1
select e.ename,d.deptno,d.dname from dept d
inner join emp e
on d.deptno=e.deptno;

--2
select e.ename,e.job,e.sal,d.dname,d.loc
from emp e
inner join dept d
on e.deptno=d.deptno
where d.loc='NEW YORK';

--3
select e.ename,d.dname,d.loc
from emp e
inner join dept d
on e.deptno=d.deptno
where e.comm is not null;

--4
select e.empno,e.ename,e.sal,d.dname
from emp e
inner join dept d
on e.deptno=d.deptno
where e.sal>=2000
order by e.sal desc;

--5
select e.empno,e.ename,e.job,e.sal,d.dname
from emp e
inner join dept d
on e.deptno=d.deptno
where e.job='MANAGER' and e.sal>=2500
order by e.empno;

--6
select e.empno,e.ename,e.sal,s.grade
from emp e
inner join salgrade s
on e.sal<=hisal and e.sal>=losal --e.sal between s.losal and s.hisal
where s.grade=4
order by e.sal desc;

--7
select e.ename,e.job,d.dname,d.loc
from emp e
inner join dept d
on e.deptno=d.deptno
where e.ename like '%L%';

--8
select  e.ename,e.hiredate, a.ename,a.hiredate
from emp e
inner join emp a
on e.mgr=a.empno
where e.hiredate<a.hiredate;

--9
select e.ename,e.sal,e.hiredate,e.comm,d.loc
from emp e
inner join dept d
on e.sal>=1500
where d.loc='DALLAS';

--10
select e.ename,e.sal,e.hiredate,d.deptno
from emp e
inner join dept d
on e.deptno=d.deptno
where MONTHS_BETWEEN (SYSDATE, hiredate)>30*12;
--SYSDATE>add_months(e.hiredate,+360);









