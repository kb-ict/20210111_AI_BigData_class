create or replace procedure del_stu(
stuno  student.studentno%type)
is
begin 
delete from student where studentno=stuno;
commit;
end del_stu;




execute del_buytbl(25);


create or replace PROCEDURE add_stu
  (  s_no             student.studentno%type
   , s_name             student.name%type
   , s_pnum           student.phonenumber%type
   , s_city          student.city%type
   , s_depart              student.department%type
   , s_prof             student.professor%type
   )
IS
BEGIN
  INSERT INTO student (studentno, name, phonenumber,
                           city, department,professor)
    VALUES(s_no, s_name, s_pnum, s_city, s_depart,s_prof);
    commit;
END add_stu;

create or replace PROCEDURE sel_stu 
 (
 p_cursor OUT SYS_REFCURSOR)
 IS
 BEGIN
 OPEN p_cursor FOR
 SELECT *
 FROM student;
-- WHERE sal > p_sal;
END sel_stu;


create or replace PROCEDURE update_stu
  (  s_no             student.studentno%type
   , s_name             student.name%type
   , s_pnum           student.phonenumber%type
   , s_city          student.city%type
   , s_depart              student.department%type
   , s_prof             student.professor%type
 )
   
IS

 BEGIN
      update student
      set 
         name = s_name
        ,phonenumber = s_pnum
        ,city  =   s_city
        ,department =   s_depart
        ,professor =   s_prof
      where studentno=s_no;
      commit;
      exception
       when no_data_found then
        dbms_output.put_line('오류 발생');
END update_stu;

execute del_stu(21911114);