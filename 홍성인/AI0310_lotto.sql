--����) �ζ� �������� ��ü YEAR�� �ش��ϴ� ���� ä��ÿ�. 
--(������ ȸ���� YEAR ���� �����Ѵ�)
    
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