package Project;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.Scanner;

public class Delstudent {

	public static void del(String[] args) {
		// TODO Auto-generated method stub
		Connection conn = null; // DB����� ����(����)�� ���� ��ü
        PreparedStatement pstm = null;  // SQL ���� ��Ÿ���� ��ü
        ResultSet rs = null;  // �������� �����Ϳ� ���� ��ȯ���� ���� ��ü
		try {	
			int count =0;
			Student[] Student = new Student[100];
//			 Class.forName("oracle.jdbc.driver.OracleDriver");
//			 Connection con = DriverManager.getConnection("jdbc:oracle:thin:@localhost:1521:orcl","hr","123456");
			conn = DBConnection.getConnection();
			Scanner scan = new Scanner(System.in);
			 // ���ν��� ȣ��
			 CallableStatement cs = conn.prepareCall("begin del_student(?); end;");
			 System.out.println("������ �й���?");
			 int sno = scan.nextInt();
			 // �Է� �Ķ���� 1��
			 cs.setInt(1, sno);//ù��°��ġ����, 1���� ���� set
			 int seq = cs.executeUpdate();
//			 ResultSet rs = (ResultSet)cs.getObject(1);
//			 Ȯ��
//			 if ( seq ==0 )
//			 {
//				 System.out.println(seq+"��");
//			 }
//			 else
//			 {
//				 System.out.println(seq+"��");
//			 }
			 
//			 rs.close();
			 cs.close();
			 conn.close();
			 } catch(Exception e){
			 e.printStackTrace();
			 }
	}

}
