-- to_char(숫자, '형식')은 숫자를 다양한 문자 형식으로 변환
select to_char(sysdate, 'yyyy/mm/dd hh24:mi:ss')from dual;
-- 2021/03/05 11:37:20
select to_char(sysdate, 'yyyy')from dual;
-- 2021
select to_char(255500, '$999,999')from dual;
--  $255,500
select to_char(255500, '999,999')from dual;
--  255,500
select to_date('20210305')from dual;
--21/03/05 문자 데이터를 날짜 데이터로 반환

-- to_number(문자, '형식')
-- 문자를 숫자로 변환 
select to_number('123456')from dual;
-- 문자데이터를 숫자로 반환 123456
-- '형식'이 'x'은 16진수 반환하는 형식
select to_number('A','x'), to_number('FF','xx')from dual;
--10	255

--LENGTH 는 문자열의 길이를 LENGTHB는 문자열에 할당된 BYTE 수를 반환

select length('한글'), length('ab'),

lengthb('한글'),lengthb('ab') from dual;


--CONCAT(문자열1, 문자열2) 또는 || 는 문자열을 이어준다

select concat('이것이',' Oracle이다'),

'이것이'||' 오라클이다' from dual;


--INSTR(기준 문자열, 부분 문자열, 찾기 시작할 위치) :

--문자열이 시작하는 위치 반환

--INSTRB(기준 문자열, 부분 문자열, 찾기 시작할 위치)

--문자열이 시작하는 위치를 BYTE단위로 세서 반환

select instr('이것이 oracle이다. 이것도 오라클이다', '이것')from dual;

--기준 문자열에서 부분 문자열을 찾아 문자열 시작 위치를 반환: 1


select instr('이것이 oracle이다. 이것도 오라클이다', '이것', 2)from dual;

-- 두번째 문자열에서 '이것'을 찾아 시작하는 위치를 반환: 15


select instrb('이것이 oracle이다. 이것도 오라클이다', '이것', 2)from dual;

-- byte단위로 반환된다: 25


--UPPER 모두 대문자, LOWER 모두 소문자, INITCATP 첫 글자를 모두 대문자

select lower('abcdEFGH'), upper('abcdEFGH'), initcap('this is oracle') from dual;

--abcdefgh / ABCDEFGH / This Is Oracle


select e.ename, e.sal from emp e

where lower (e.ename)=lower('ward');

-- WARD 1250


--REPLACE 문자열을 바꿔준다

select replace ('이것이 oracle이다', '이것이', 'This is')from dual;

-- (문자열, 원래문자열, 바꿀 문자열) : This is oracle이다


-- TRANSLATE 문자열을 한 글자씩 바꿔준다(문자열, 원래문자열, 바꿀 문자열)

select translate('이것이 oracle이다', '이것이', 'AB') from dual;

-- '이'글자는 모두 'A'이고 '것'글자는 'B;로 바뀜(대응됨): ABA oracleA다


select TRANSLATE('이것이 oracleoracledddet이다','oracl',123)from dual;

-- oracl 을 ora는 대응되는 123으로 바뀌고 나머지 cl은 삭제된다

-- 이것이 123e123edddet이다


--SUBSTR(문자열, 시작위치, 길이) 시작위치부터 길이만큼 문자반환

select substr('대한민국만세', 3, 2)from dual;

-- 시작위치부터 길이만큼 문자를 반환 길이가 생략되면 문자열의 끝까지 반환한다

-- 민국


select (substr('삼성전자와 애플의 전자대결,',1,4)||'vs'|| substr('삼성전자와 애플의 전자대결.',7,2))from dual;

-- 삼성전자vs애플


-- REVERSE 문자열의 순서를 거꾸로 만든다

select reverse('oracle')from dual;

-- elcaro


-- LPAD or RPAD(문자열, 길이, 채울 문자열)

--문자열을 길이 만큼 늘린 후 빈 곳을 채울 문자열로 채운다.

-- 길이는 byte단위의 크기이다

select lpad('이것이', 10, '##'), rpad('이것이', 10, '##')from dual;

-- 한글은 글자 한개당 2를 자치 lpad는 왼쪽을 채우고, rpad는 오른쪽을 채운다.

-- ####이것이 이것이####


-- LTRIM/ RTRIM(문자열,제거할 문자)

select ltrim(' 이것이'), RTRIM('이것이$$$', '$')from dual;

-- 문자열의 왼쪽/오른쪽의 제거할 문자를 제거한다 제거할문자를 생략시 공백을 제거

-- 이것이 이것이


-- TRIM(제거할 방향 제거할 문자 from 문자열)

-- 제거할 방향에는 LEADING(앞), BOTH(양쪽), TRAILING(뒤)

-- TRIM(문자열)만 사용하면 앞뒤 공백을 제거

select trim(' 이것이 '), trim(both'ㅋ'from'ㅋㅋㅋ재밌어요.ㅋㅋㅋ')from dual;

-- 이것이 재밌어요.

select trim(' 이것이 '), trim('ㅋ'from'ㅋㅋㅋ재밌어요.ㅋㅋㅋ')from dual;

-- both를 생략해줘도 양쪽 문자 ㅋ를 제거.


select trim(both'ㅋ'from'하하ㅋㅋㅋ재밌어요.ㅋㅋㅋ')from dual;

-- 문자 시작이 '하'이므로 앞쪽 ㅋ는 제거하지 않는다.

-- 하하ㅋㅋㅋ재밌어요.


--ABS : 절대값,

select ABS(-100) from dual;

-- 100


-- ROUND: 반올림, CEIL: 올림, FROOR: 내림

select CEIL(4.7),FLOOR(4.7), ROUND(4.7)from dual;

-- 5 4 5


select round(4.785678, 2) from dual;

-- 4.79 : 반올림을 한 뒤 소수점 두자리수 까지

select round(22344.785678, -2) from dual;

-- 22300

-- round으로 반올림과 trunc 기능을 함께 수행


--TRUNC : 숫자를 기준으로 정수 위치까지 구하고 나머지는 버린다

select TRUNC(12345.12345,2), TRUNC(12345.12345, -2)from dual;

-- 소수점 기준으로 2는 소수쪽으로 -2는 정수 쪽으로

-- 12345.12 / 12300


--MOD :나누고 남은 나머지 값, POWER : 거듭제곱 값, SQRT: 제곱근

select MOD(157,10)from dual;

-- 나머지 값 : 7

select POWER(2,3), SQRT(9)from dual;

-- 8 / 3


--SYSDATE 현재의 날짜를 반환

select SYSDATE from dual;

-- 21/03/05


-- ADD_MONTHS(날짜, 개월) : 날짜를 기준으로 개월을 더하거나 뺀 월을 반환

select ADD_MONTHS('2020-01-01',5), ADD_MONTHS(SYSDATE, -5)from dual;

-- 20/06/01 20/10/05 : 오늘 날짜 3월에서 -5 개월


--LAST_DAY 주어진 날짜의 달의 마지막 날짜를 구한다

select LAST_DAY('2020-02-01')from dual;

-- 2월의 마지막날 20/02/29


--NEXT_DAY 주어진 날짜의 다음에 오는 요일에 해당되는 날짜를 구한다

select NEXT_DAY('2020-02-01','월요일'), NEXT_DAY(SYSDATE,'일요일')from dual;

-- 20/02/03 21/03/07


--MONTHS_BETWEEN 주어진 날짜 사이의 개월 수를 구한다

select MONTHS_BETWEEN(SYSDATE,'1996-11-16')from dual;

--291.659808094384707287933094384707287933



?