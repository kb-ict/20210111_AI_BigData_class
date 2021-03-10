-- to_char(����, '����')�� ���ڸ� �پ��� ���� �������� ��ȯ
select to_char(sysdate, 'yyyy/mm/dd hh24:mi:ss')from dual;
-- 2021/03/05 11:37:20
select to_char(sysdate, 'yyyy')from dual;
-- 2021
select to_char(255500, '$999,999')from dual;
--  $255,500
select to_char(255500, '999,999')from dual;
--  255,500
select to_date('20210305')from dual;
--21/03/05 ���� �����͸� ��¥ �����ͷ� ��ȯ

-- to_number(����, '����')
-- ���ڸ� ���ڷ� ��ȯ 
select to_number('123456')from dual;
-- ���ڵ����͸� ���ڷ� ��ȯ 123456
-- '����'�� 'x'�� 16���� ��ȯ�ϴ� ����
select to_number('A','x'), to_number('FF','xx')from dual;
--10	255

--LENGTH �� ���ڿ��� ���̸� LENGTHB�� ���ڿ��� �Ҵ�� BYTE ���� ��ȯ

select length('�ѱ�'), length('ab'),

lengthb('�ѱ�'),lengthb('ab') from dual;


--CONCAT(���ڿ�1, ���ڿ�2) �Ǵ� || �� ���ڿ��� �̾��ش�

select concat('�̰���',' Oracle�̴�'),

'�̰���'||' ����Ŭ�̴�' from dual;


--INSTR(���� ���ڿ�, �κ� ���ڿ�, ã�� ������ ��ġ) :

--���ڿ��� �����ϴ� ��ġ ��ȯ

--INSTRB(���� ���ڿ�, �κ� ���ڿ�, ã�� ������ ��ġ)

--���ڿ��� �����ϴ� ��ġ�� BYTE������ ���� ��ȯ

select instr('�̰��� oracle�̴�. �̰͵� ����Ŭ�̴�', '�̰�')from dual;

--���� ���ڿ����� �κ� ���ڿ��� ã�� ���ڿ� ���� ��ġ�� ��ȯ: 1


select instr('�̰��� oracle�̴�. �̰͵� ����Ŭ�̴�', '�̰�', 2)from dual;

-- �ι�° ���ڿ����� '�̰�'�� ã�� �����ϴ� ��ġ�� ��ȯ: 15


select instrb('�̰��� oracle�̴�. �̰͵� ����Ŭ�̴�', '�̰�', 2)from dual;

-- byte������ ��ȯ�ȴ�: 25


--UPPER ��� �빮��, LOWER ��� �ҹ���, INITCATP ù ���ڸ� ��� �빮��

select lower('abcdEFGH'), upper('abcdEFGH'), initcap('this is oracle') from dual;

--abcdefgh / ABCDEFGH / This Is Oracle


select e.ename, e.sal from emp e

where lower (e.ename)=lower('ward');

-- WARD 1250


--REPLACE ���ڿ��� �ٲ��ش�

select replace ('�̰��� oracle�̴�', '�̰���', 'This is')from dual;

-- (���ڿ�, �������ڿ�, �ٲ� ���ڿ�) : This is oracle�̴�


-- TRANSLATE ���ڿ��� �� ���ھ� �ٲ��ش�(���ڿ�, �������ڿ�, �ٲ� ���ڿ�)

select translate('�̰��� oracle�̴�', '�̰���', 'AB') from dual;

-- '��'���ڴ� ��� 'A'�̰� '��'���ڴ� 'B;�� �ٲ�(������): ABA oracleA��


select TRANSLATE('�̰��� oracleoracledddet�̴�','oracl',123)from dual;

-- oracl �� ora�� �����Ǵ� 123���� �ٲ�� ������ cl�� �����ȴ�

-- �̰��� 123e123edddet�̴�


--SUBSTR(���ڿ�, ������ġ, ����) ������ġ���� ���̸�ŭ ���ڹ�ȯ

select substr('���ѹα�����', 3, 2)from dual;

-- ������ġ���� ���̸�ŭ ���ڸ� ��ȯ ���̰� �����Ǹ� ���ڿ��� ������ ��ȯ�Ѵ�

-- �α�


select (substr('�Ｚ���ڿ� ������ ���ڴ��,',1,4)||'vs'|| substr('�Ｚ���ڿ� ������ ���ڴ��.',7,2))from dual;

-- �Ｚ����vs����


-- REVERSE ���ڿ��� ������ �Ųٷ� �����

select reverse('oracle')from dual;

-- elcaro


-- LPAD or RPAD(���ڿ�, ����, ä�� ���ڿ�)

--���ڿ��� ���� ��ŭ �ø� �� �� ���� ä�� ���ڿ��� ä���.

-- ���̴� byte������ ũ���̴�

select lpad('�̰���', 10, '##'), rpad('�̰���', 10, '##')from dual;

-- �ѱ��� ���� �Ѱ��� 2�� ��ġ lpad�� ������ ä���, rpad�� �������� ä���.

-- ####�̰��� �̰���####


-- LTRIM/ RTRIM(���ڿ�,������ ����)

select ltrim(' �̰���'), RTRIM('�̰���$$$', '$')from dual;

-- ���ڿ��� ����/�������� ������ ���ڸ� �����Ѵ� �����ҹ��ڸ� ������ ������ ����

-- �̰��� �̰���


-- TRIM(������ ���� ������ ���� from ���ڿ�)

-- ������ ���⿡�� LEADING(��), BOTH(����), TRAILING(��)

-- TRIM(���ڿ�)�� ����ϸ� �յ� ������ ����

select trim(' �̰��� '), trim(both'��'from'��������վ��.������')from dual;

-- �̰��� ��վ��.

select trim(' �̰��� '), trim('��'from'��������վ��.������')from dual;

-- both�� �������൵ ���� ���� ���� ����.


select trim(both'��'from'���Ϥ�������վ��.������')from dual;

-- ���� ������ '��'�̹Ƿ� ���� ���� �������� �ʴ´�.

-- ���Ϥ�������վ��.


--ABS : ���밪,

select ABS(-100) from dual;

-- 100


-- ROUND: �ݿø�, CEIL: �ø�, FROOR: ����

select CEIL(4.7),FLOOR(4.7), ROUND(4.7)from dual;

-- 5 4 5


select round(4.785678, 2) from dual;

-- 4.79 : �ݿø��� �� �� �Ҽ��� ���ڸ��� ����

select round(22344.785678, -2) from dual;

-- 22300

-- round���� �ݿø��� trunc ����� �Բ� ����


--TRUNC : ���ڸ� �������� ���� ��ġ���� ���ϰ� �������� ������

select TRUNC(12345.12345,2), TRUNC(12345.12345, -2)from dual;

-- �Ҽ��� �������� 2�� �Ҽ������� -2�� ���� ������

-- 12345.12 / 12300


--MOD :������ ���� ������ ��, POWER : �ŵ����� ��, SQRT: ������

select MOD(157,10)from dual;

-- ������ �� : 7

select POWER(2,3), SQRT(9)from dual;

-- 8 / 3


--SYSDATE ������ ��¥�� ��ȯ

select SYSDATE from dual;

-- 21/03/05


-- ADD_MONTHS(��¥, ����) : ��¥�� �������� ������ ���ϰų� �� ���� ��ȯ

select ADD_MONTHS('2020-01-01',5), ADD_MONTHS(SYSDATE, -5)from dual;

-- 20/06/01 20/10/05 : ���� ��¥ 3������ -5 ����


--LAST_DAY �־��� ��¥�� ���� ������ ��¥�� ���Ѵ�

select LAST_DAY('2020-02-01')from dual;

-- 2���� �������� 20/02/29


--NEXT_DAY �־��� ��¥�� ������ ���� ���Ͽ� �ش�Ǵ� ��¥�� ���Ѵ�

select NEXT_DAY('2020-02-01','������'), NEXT_DAY(SYSDATE,'�Ͽ���')from dual;

-- 20/02/03 21/03/07


--MONTHS_BETWEEN �־��� ��¥ ������ ���� ���� ���Ѵ�

select MONTHS_BETWEEN(SYSDATE,'1996-11-16')from dual;

--291.659808094384707287933094384707287933



?