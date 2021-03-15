--문제) 로또 데이터의 전체 YEAR에 해당하는 값을 채우시오. 
--(마지막 회차의 YEAR 값만 존재한다)
    
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