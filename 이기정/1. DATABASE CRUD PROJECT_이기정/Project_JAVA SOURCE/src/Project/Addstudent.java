package Project;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.Scanner;

import javax.swing.plaf.synth.SynthSeparatorUI;

public class Addstudent {

	public static void add(){
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
			 // 프로시저 호출
			 CallableStatement cs = conn.prepareCall("begin add_student(?,?,?,?,?,?,?,?,?); end;");
			 // 입력 파라메터
			 Scanner scan = new Scanner(System.in);
			 System.out.println("학번: 학년+순번입력하시오");
			 cs.setInt(1,scan.nextInt());
			 System.out.println("이름");
			 cs.setString(2,scan.next());
			 System.out.println("전화번호");
			 cs.setString(3,scan.next());
			 System.out.println("주소");
			 scan.nextLine();
			 String addr = scan.nextLine();
			 cs.setString(4,addr);			 
			 System.out.println("학년");
			 String gra = scan.next();
			 cs.setString(5,gra);
			 System.out.println("도시: 주소 중 시,군을 적으시오");
			 cs.setString(6,scan.next());
			 System.out.println("보증금");
			 cs.setInt(7,scan.nextInt());
			 System.out.println("기숙사유무 Y/N");
			 cs.setString(8,scan.next());
			 System.out.println("멘토 : 1학년은 103, 2학년은 104, 3학년은 105를 입력하시오");
			 cs.setInt(9,scan.nextInt());
			 int seq= cs.executeUpdate();
//			 ResultSet rs = (ResultSet)cs.getObject(1);
			 
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
		finally{
		            // DB 연결을 종료한다.
		            try{
		                if ( rs != null ){rs.close();}   
		                if ( pstm != null ){pstm.close();}   
		                if ( conn != null ){conn.close(); }
		            }catch(Exception e){
		                throw new RuntimeException(e.getMessage());
		            }
			 }
		}
}
