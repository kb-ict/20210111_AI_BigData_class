----create table fktable(
----fkcolumn varchar2(20)
----);
--
----alter table fktable
----add constraint ff primary key (fkcolumn);
--
----create table ptable (
----column1 varchar(20) primary key,
----column2 constraint fktest references fktable (fkcolumn));
--
--alter table ptable
--add column3 varchar(20);
--
--alter table ptable
--add constraint fkfk foreign key (column3)
--references fktable (fkcolumn);
--
--create table uniqueEx(
--c1 varchar2(20) constraint c1unique unique,
--c2 number(3) constraint c2unique unique,
--c3 char(3)
--);
--
--insert into uniqueex values('test', 3, 'a');
--
--create table checkEx(
--c1 varchar2(20) constraint c1check check(c1 in('y', 'n')),
--c2 number(3) constraint c2check check(c2 between 1 and 10),
--c3 varchar2(10)
--);
--
----insert into checkex values('t', 10, 'test');
----insert into checkex values('y', 100, 'test');
--insert into checkex values('y', 10, 'test');
--
--alter table checkEx
--add constraint chk3 check (c3 in ('A', 'B', 'C', 'D', 'E', 'F', 'G', 'test'));
--
--create table defaultEx(
--c1 varchar(30),
--c2 varchar2(20) default '기본값',
--c3 number(3) default 123
--);
--
--insert into defaultEx (c1) values ('test');
--insert into defaultEx values ('zdkfuhkzd',default, default);
--insert into defaultEx values ('zdkfuhkzd',null, null);
--
--alter table defaultex
--modify c3 default 111;
--insert into defaultEx values ('zdkfuhkzd',null, default);
--
--create table notnullex(
--c1 varchar2(20) constraint c1nn not null,
--c2 number(30) constraint c2nn not null
--);
--
--alter table notnullex
--drop constraint c1nn;
--
--alter table notnullex
--modify c2 constraint c2nn not null unique;
--
--alter table notnullex
--modify c1 default 'basic';
--
--insert into notnullex values(default, 11);

--set SERVEROUT on;
--DECLARE
--var1 number(5);
--begin
--var1 := 15;
--if var1 = 100 then
--DBMS_OUTPUT.PUT_LINE('100입니다');
--else
--DBMS_OUTPUT.PUT_LINE('100이 아닙니다');
--end if;
--end;

--DECLARE
--    hiredate date;
--    curdate date;
--    wdays number(5);
--begin
--    select e.hire_date into hiredate
--    from ai.employees e
--    where e.employee_id = 200;
--    curdate := current_date();
--    wdays := curdate - hiredate;
--if (wdays/365) >= 5 then
--DBMS_OUTPUT.PUT_LINE('입사한지 '||wdays||'일이나 지났습니다. 축하합니다!');
--else
--DBMS_OUTPUT.PUT_LINE('입사한지 '||wdays||'일밖에 안됐네요. 일하세요!');
--end if;
--end;

--declare
--    pnumber number(3);
--    credit char(1);
--begin
--    pnumber := 77;
--    if pnumber >= 90 then
--    credit := 'A';
--    elsif pnumber >= 80 then
--    credit := 'B';
--    elsif pnumber >= 70 then
--    credit := 'C';
--    elsif pnumber >= 60 then
--    credit := 'D';
--    else
--    credit := 'F';
--end if;
--    DBMS_OUTPUT.PUT_LINE('취득점수==> '||pnumber||', 학점==>' ||credit);
--end;

--declare
--    pnumber number(3);
--    credit char(1);
--begin
--    pnumber := 44;
--    case
--    when pnumber >= 90 then
--    credit := 'A';
--    when pnumber >= 80 then
--    credit := 'B';
--    when pnumber >= 70 then
--    credit := 'C';
--    when pnumber >= 60 then
--    credit := 'D';
--    else
--    credit := 'F';
--end case;
--    DBMS_OUTPUT.PUT_LINE('취득점수==> '||pnumber||', 학점==>' ||credit);
--end;

--select u.userid, u.username, sum(b.price*b.amount) 총구매액
--    , case
--    when sum(b.price*b.amount) >= 1500 then '최우수고객'
--    when sum(b.price*b.amount) >= 1000 then '우수고객'
--    when sum(b.price*b.amount) >= 1 then '일반고객'
--    else '유령고객'
--    end 고객등급
--from buytbl b 
--right join usertbl u on b.userid=u.userid
--group by u.userid, u.username
--order by 총구매액 desc nulls last;


--declare
--    idx number(4);
--    total number(10);
--begin
--    idx :=0;
--    total :=0;
--    while idx<=1000
--        loop
----            if (idx/3 = 0 or idx/8 = 0) then
--            if (mod(idx,3) = 0 or mod(idx,8) = 0) then
--                total := total + idx;
--            end if;
--            idx:= idx+1;
--        end loop;
--        DBMS_OUTPUT.PUT_LINE('1~1000 중 3의 배수 혹은 8의 배수의 총합은 ==> '|| total);
--end;

savepoint lottonull;
rollback lottonull;

declare
    inputNum number(4);
begin
    inputNum := 2002;    
        while inputNum <= 2021
        loop
            update lotto
            set year= inputNum
            where year is null
            and substr(resultdate,0,4)=inputNum;
            
            inputNum := inputNum + 1;
            continue;
        end loop;
end;
--exec ai.QUIZ_20210310_LOTTO(2002);

select * from lotto;