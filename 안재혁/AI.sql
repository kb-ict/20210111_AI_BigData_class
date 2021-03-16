--insert into member_shop values
--(111114, 'ÁÖÈñ', null, null,(to_date('2021/02/26', 'yyyy/mm/dd')), 'A', '¼­¿ï', '4', null);

update member_shop set customername = 'ÁøÇõ', phone = '222-2222-222'
where customerno = 111111;

delete from member_shop;

rollback; 

rollback;