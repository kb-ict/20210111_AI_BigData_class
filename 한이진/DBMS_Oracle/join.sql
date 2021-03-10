
--조인 중에서 가장 많이 사용되는 조인
--일반적으로 Join이라고 하면 Inner Join 이다
--Inner join 형식
--Select <열 목록>
--From <첫 번째 테이블>
--Inner Join <두 번째 테이블>
--On <조인될 조건>
--[Where 검색조건]

--USERTBL 테이블과 BUYTBL 테이블을 JOIN 하는 예시
SELECT b.userid, u.username, b.prodname, u.addr, 
	u.mobile1 || u.mobile2 AS "연락처"
   FROM BUYTBL B
       INNER JOIN USERTBL U
          ON b.userid=u.userid ;

select b.userid, u.username, b.prodname, u.addr, 
u.mobile1 || u.mobile2 as "연락처"
from buytbl b, usertbl u
where b.userid = u.userid;

select b.userid, u.username, b.prodname, u.addr
, u.mobile1 || u.mobile2 as "연락처"
from buytbl b, usertbl u;

-- 제품을 구매기록이 있는 사람, distinct로 중복값 제거
select distinct u.userid, u.username, u.addr
from usertbl u, buytbl b 
where u.userid=b.userid;

--EXISTS 의 서브쿼리 결과가 존재하면 TRUE 없으면 FALSE
select u.userid, u.username, u.addr
from usertbl u
where
EXISTS(select b.userid from buytbl b 
where u.userid=b.userid);


--outer join
--조인의 조건에 만족되지 않는 행까지도 포함시키는 것
--OUTER JOIN 형식
--SELECT <열 목록>
--FROM <첫 번째 테이블(LEFT 테이블)>
--<LEFT | RIGHT | FULL> OUTER JOIN <두 번째 테이블(RIGHT 테이블)>
--ON <조인될 조건>

--left outer join은 왼쪽 테이블의 것은 모두 출력
select u.userid, u.username, b.prodname, u.addr,
u.mobile1 || u.mobile2 as "연락처"
from usertbl u
left outer join buytbl b
on b.userid= u.userid;

--right outer join은 오른쪽 테이블의 것은 모두 출력
select u.userid, u.username, b.prodname, u.addr,
u.mobile1 || u.mobile2 as "연락처"
from buytbl b
right outer join usertbl u
on b.userid= u.userid;

--right outer join은 오른쪽 테이블의 것은 모두 출력
select u.userid, u.username, b.prodname, u.addr,
u.mobile1 || u.mobile2 as "연락처"
from usertbl u
right outer join buytbl b 
on b.userid= u.userid;

select u.userid, u.username, b.prodname, u.addr,
u.mobile1 || u.mobile2 as "연락처"
from buytbl b
right outer join usertbl u
on b.userid= u.userid
where b.prodname is null;

-- cross join
--테스트로 사용할 많은 용량의 데이터를 생성할 때 주로 사용한다
select *from buytbl, usertbl;

select *from buytbl cross join usertbl;

create table copy(select );

--self join
--자기자신과 조인한다
select a.emp as 부하직원, b.emp as 직속상관, b.department as 직속상관부서
from emptbl a
inner join emptbl b
on a.manager= b.emp
where a.emp='우대리';
-- 우대리	이부장	재무부

--부서 테이블: DEPT , 사원테이블 : EMP, 급여 등급 테이블 : SALGRADE
--DEPT : DNAME(부서명), DEPTNO(부서번호), LOC(위치)// 
--EMP : EMPNO(사번),ENAME(사원명), JOB(업무), SAL(급여)
--1.사원 테이블과 부서테이블에서 모든 사원에 대한 이름, 부서번호 ,부서명을 출력하라
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

--2. 부서테이블과 사원테이블에서 위치가 NEW YORK인  부서의 사원명, 업무, 급여, 
--        부서명을 출력하라
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

--3. 사원테이블과 부서테이블에서 COMM이 NULL이 아닌 사원의 사원명, 부서명, 
--       위치를 출력하라  

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

--급여 등급 테이블 : SALGRADE
--SALGRADE : GRADE(등급),LOSAL(하한값),HISAL(상한값)
--4.부서 테이블과 사원테이블에서 급여가 2000 이상인 사원의 사번, 사원명 , 급여 ,  
--    부서명을 출력하라(급여기준 내림차순 정렬)
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
--5. 부서 테이블과 사원 테이블에서 업무가 Manager이며 급여가 2500 이상인 사원의 
--     사번, 사원명, 업무, 급여 , 부서명을 출력하라(사번기준 오름차순 정렬). 
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

--급여 등급 테이블 : SALGRADE
--SALGRADE : GRADE(등급),LOSAL(하한값),HISAL(상한값)
--
--6. 사원 테이블과 급여 등급 테이블에서 급여가 하한값과 상한값 범위에 포함되고 
--     등급이 4인 사번, 사원명, 급여, 등급을 출력하라. (급여기준 내림차순 정렬)
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

--7.사원테이블과 부서테이블에서 사원명에 L 자가 있는 사원의 사원명, 업무, 부서명, 위치를 출력하라
select e.ename, e.job, d.dname, d.loc
from emp e
inner join dept d
on e.deptno=d.deptno
where e.ename like '%L%';

select e.ename, e.job, d.dname, d.loc
from emp e, dept d
where e.deptno=d.deptno
and e.ename like '%L%';

--8.사원 테이블에서 사원의 관리자보다 먼저 입사한 사원의 사원명, 이름, 입사일, 관리자 이름, 관리자 입사일을 출력하라
select e.ename, e.hiredate, m.ename, m.hiredate
from emp e
inner join emp m
on e.mgr= m.empno
where e.hiredate<m.hiredate;

select a.ename, a.hiredate, b.ename, b.hiredate
    from emp a --사원
    inner join emp b --관리자
    on a.mgr=b.empno
where a.hiredate<b.hiredate;
--9.DALLAS에 근무하는 사원 중 급여 1500 이상인 사원의 이름, 급여, 입사일 , 
--    COMM을 출력하라
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


--10.직원 중 현재시간 기준으로 근무 개월 수가 30년(12 * 30개월) 보다 많은 사람의 
--   이름, 급여 , 입사일 , 부서명을 출력하라
select e.ename, e.sal, e.hiredate, d.dname
from emp e
inner join dept d
on e.deptno=d.deptno
where months_between (sysdate, e.hiredate)>(12*36);

select e.ename, e. sal, e.hiredate, d.dname
from emp e, dept d
where e.deptno=d.deptno
and months_between(sysdate, e.hiredate)>(12*36);