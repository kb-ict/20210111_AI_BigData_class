package Project;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.Scanner;

public class Delstudent {

	public static void del(String[] args) {
		// TODO Auto-generated method stub
		Connection conn = null; // DB연결된 상태(세션)을 담은 객체
        PreparedStatement pstm = null;  // SQL 문을 나타내는 객체
        ResultSet rs = null;  // 쿼리문을 날린것에 대한 반환값을 담을 객체
		try {	
			int count =0;
			Student[] Student = new Student[100];
//			 Class.forName("oracle.jdbc.driver.OracleDriver");
//			 Connection con = DriverManager.getConnection("jdbc:oracle:thin:@localhost:1521:orcl","hr","123456");
			conn = DBConnection.getConnection();
			Scanner scan = new Scanner(System.in);
			 // 프로시저 호출
			 CallableStatement cs = conn.prepareCall("begin del_student(?); end;");
			 System.out.println("삭제할 학번은?");
			 int sno = scan.nextInt();
			 // 입력 파라메터 1개
			 cs.setInt(1, sno);//첫번째위치에서, 1개의 값을 set
			 int seq = cs.executeUpdate();
//			 ResultSet rs = (ResultSet)cs.getObject(1);
//			 확인
//			 if ( seq ==0 )
//			 {
//				 System.out.println(seq+"값");
//			 }
//			 else
//			 {
//				 System.out.println(seq+"값");
//			 }
			 
//			 rs.close();
			 cs.close();
			 conn.close();
			 } catch(Exception e){
			 e.printStackTrace();
			 }
	}

}
