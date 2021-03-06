-- to_char(収切, '莫縦')精 収切研 陥丞廃 庚切 莫縦生稽 痕発
select to_char(sysdate, 'yyyy/mm/dd hh24:mi:ss')from dual;
-- 2021/03/05 11:37:20
select to_char(sysdate, 'yyyy')from dual;
-- 2021
select to_char(255500, '$999,999')from dual;
--  $255,500
select to_char(255500, '999,999')from dual;
--  255,500
select to_date('20210305')from dual;
--21/03/05 庚切 汽戚斗研 劾促 汽戚斗稽 鋼発

-- to_number(庚切, '莫縦')
-- 庚切研 収切稽 痕発 
select to_number('123456')from dual;
-- 庚切汽戚斗研 収切稽 鋼発 123456
-- '莫縦'戚 'x'精 16遭呪 鋼発馬澗 莫縦
select to_number('A','x'), to_number('FF','xx')from dual;
--10	255

--LENGTH 澗 庚切伸税 掩戚研 LENGTHB澗 庚切伸拭 拝雁吉 BYTE 呪研 鋼発

select length('廃越'), length('ab'),

lengthb('廃越'),lengthb('ab') from dual;


--CONCAT(庚切伸1, 庚切伸2) 暁澗 || 澗 庚切伸聖 戚嬢層陥

select concat('戚依戚',' Oracle戚陥'),

'戚依戚'||' 神虞適戚陥' from dual;


--INSTR(奄層 庚切伸, 採歳 庚切伸, 達奄 獣拙拝 是帖) :

--庚切伸戚 獣拙馬澗 是帖 鋼発

--INSTRB(奄層 庚切伸, 採歳 庚切伸, 達奄 獣拙拝 是帖)

--庚切伸戚 獣拙馬澗 是帖研 BYTE舘是稽 室辞 鋼発

select instr('戚依戚 oracle戚陥. 戚依亀 神虞適戚陥', '戚依')from dual;

--奄層 庚切伸拭辞 採歳 庚切伸聖 達焼 庚切伸 獣拙 是帖研 鋼発: 1


select instr('戚依戚 oracle戚陥. 戚依亀 神虞適戚陥', '戚依', 2)from dual;

-- 砧腰属 庚切伸拭辞 '戚依'聖 達焼 獣拙馬澗 是帖研 鋼発: 15


select instrb('戚依戚 oracle戚陥. 戚依亀 神虞適戚陥', '戚依', 2)from dual;

-- byte舘是稽 鋼発吉陥: 25


--UPPER 乞砧 企庚切, LOWER 乞砧 社庚切, INITCATP 湛 越切研 乞砧 企庚切

select lower('abcdEFGH'), upper('abcdEFGH'), initcap('this is oracle') from dual;

--abcdefgh / ABCDEFGH / This Is Oracle


select e.ename, e.sal from emp e

where lower (e.ename)=lower('ward');

-- WARD 1250


--REPLACE 庚切伸聖 郊蚊層陥

select replace ('戚依戚 oracle戚陥', '戚依戚', 'This is')from dual;

-- (庚切伸, 据掘庚切伸, 郊蝦 庚切伸) : This is oracle戚陥


-- TRANSLATE 庚切伸聖 廃 越切梢 郊蚊層陥(庚切伸, 据掘庚切伸, 郊蝦 庚切伸)

select translate('戚依戚 oracle戚陥', '戚依戚', 'AB') from dual;

-- '戚'越切澗 乞砧 'A'戚壱 '依'越切澗 'B;稽 郊会(企誓喫): ABA oracleA陥


select TRANSLATE('戚依戚 oracleoracledddet戚陥','oracl',123)from dual;

-- oracl 聖 ora澗 企誓鞠澗 123生稽 郊餓壱 蟹袴走 cl精 肢薦吉陥

-- 戚依戚 123e123edddet戚陥


--SUBSTR(庚切伸, 獣拙是帖, 掩戚) 獣拙是帖採斗 掩戚幻鏑 庚切鋼発

select substr('企廃肯厩幻室', 3, 2)from dual;

-- 獣拙是帖採斗 掩戚幻鏑 庚切研 鋼発 掩戚亜 持繰鞠檎 庚切伸税 魁猿走 鋼発廃陥

-- 肯厩


select (substr('誌失穿切人 蕉巴税 穿切企衣,',1,4)||'vs'|| substr('誌失穿切人 蕉巴税 穿切企衣.',7,2))from dual;

-- 誌失穿切vs蕉巴


-- REVERSE 庚切伸税 授辞研 暗荷稽 幻窮陥

select reverse('oracle')from dual;

-- elcaro


-- LPAD or RPAD(庚切伸, 掩戚, 辰随 庚切伸)

--庚切伸聖 掩戚 幻鏑 潅鍵 板 朔 員聖 辰随 庚切伸稽 辰錘陥.

-- 掩戚澗 byte舘是税 滴奄戚陥

select lpad('戚依戚', 10, '##'), rpad('戚依戚', 10, '##')from dual;

-- 廃越精 越切 廃鯵雁 2研 切帖 lpad澗 図楕聖 辰酔壱, rpad澗 神献楕聖 辰錘陥.

-- ####戚依戚 戚依戚####


-- LTRIM/ RTRIM(庚切伸,薦暗拝 庚切)

select ltrim(' 戚依戚'), RTRIM('戚依戚$$$', '$')from dual;

-- 庚切伸税 図楕/神献楕税 薦暗拝 庚切研 薦暗廃陥 薦暗拝庚切研 持繰獣 因拷聖 薦暗

-- 戚依戚 戚依戚


-- TRIM(薦暗拝 号狽 薦暗拝 庚切 from 庚切伸)

-- 薦暗拝 号狽拭澗 LEADING(蒋), BOTH(丞楕), TRAILING(及)

-- TRIM(庚切伸)幻 紫遂馬檎 蒋及 因拷聖 薦暗

select trim(' 戚依戚 '), trim(both'せ'from'せせせ仙衡嬢推.せせせ')from dual;

-- 戚依戚 仙衡嬢推.

select trim(' 戚依戚 '), trim('せ'from'せせせ仙衡嬢推.せせせ')from dual;

-- both研 持繰背操亀 丞楕 庚切 せ研 薦暗.


select trim(both'せ'from'馬馬せせせ仙衡嬢推.せせせ')from dual;

-- 庚切 獣拙戚 '馬'戚糠稽 蒋楕 せ澗 薦暗馬走 省澗陥.

-- 馬馬せせせ仙衡嬢推.


--ABS : 箭企葵,

select ABS(-100) from dual;

-- 100


-- ROUND: 鋼臣顕, CEIL: 臣顕, FROOR: 鎧顕

select CEIL(4.7),FLOOR(4.7), ROUND(4.7)from dual;

-- 5 4 5


select round(4.785678, 2) from dual;

-- 4.79 : 鋼臣顕聖 廃 及 社呪繊 砧切軒呪 猿走

select round(22344.785678, -2) from dual;

-- 22300

-- round生稽 鋼臣顕引 trunc 奄管聖 敗臆 呪楳


--TRUNC : 収切研 奄層生稽 舛呪 是帖猿走 姥馬壱 蟹袴走澗 獄鍵陥

select TRUNC(12345.12345,2), TRUNC(12345.12345, -2)from dual;

-- 社呪繊 奄層生稽 2澗 社呪楕生稽 -2澗 舛呪 楕生稽

-- 12345.12 / 12300


--MOD :蟹刊壱 害精 蟹袴走 葵, POWER : 暗旧薦咽 葵, SQRT: 薦咽悦

select MOD(157,10)from dual;

-- 蟹袴走 葵 : 7

select POWER(2,3), SQRT(9)from dual;

-- 8 / 3


--SYSDATE 薄仙税 劾促研 鋼発

select SYSDATE from dual;

-- 21/03/05


-- ADD_MONTHS(劾促, 鯵杉) : 劾促研 奄層生稽 鯵杉聖 希馬暗蟹 捌 杉聖 鋼発

select ADD_MONTHS('2020-01-01',5), ADD_MONTHS(SYSDATE, -5)from dual;

-- 20/06/01 20/10/05 : 神潅 劾促 3杉拭辞 -5 鯵杉


--LAST_DAY 爽嬢遭 劾促税 含税 原走厳 劾促研 姥廃陥

select LAST_DAY('2020-02-01')from dual;

-- 2杉税 原走厳劾 20/02/29


--NEXT_DAY 爽嬢遭 劾促税 陥製拭 神澗 推析拭 背雁鞠澗 劾促研 姥廃陥

select NEXT_DAY('2020-02-01','杉推析'), NEXT_DAY(SYSDATE,'析推析')from dual;

-- 20/02/03 21/03/07


--MONTHS_BETWEEN 爽嬢遭 劾促 紫戚税 鯵杉 呪研 姥廃陥

select MONTHS_BETWEEN(SYSDATE,'1996-11-16')from dual;

--291.659808094384707287933094384707287933



?