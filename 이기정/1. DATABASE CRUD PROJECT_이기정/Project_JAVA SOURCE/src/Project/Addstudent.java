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
		Connection conn = null; // DB����� ����(����)�� ���� ��ü
        PreparedStatement pstm = null;  // SQL ���� ��Ÿ���� ��ü
        ResultSet rs = null;  // �������� �����Ϳ� ���� ��ȯ���� ���� ��ü
		try {	
			int count =0;
			Student[] Student = new Student[100];
//			 Class.forName("oracle.jdbc.driver.OracleDriver");
//			 Connection con = DriverManager.getConnection("jdbc:oracle:thin:@localhost:1521:orcl","hr","123456");
			conn = DBConnection.getConnection();
			 // ���ν��� ȣ��
			 CallableStatement cs = conn.prepareCall("begin add_student(?,?,?,?,?,?,?,?,?); end;");
			 // �Է� �Ķ����
			 Scanner scan = new Scanner(System.in);
			 System.out.println("�й�: �г�+�����Է��Ͻÿ�");
			 cs.setInt(1,scan.nextInt());
			 System.out.println("�̸�");
			 cs.setString(2,scan.next());
			 System.out.println("��ȭ��ȣ");
			 cs.setString(3,scan.next());
			 System.out.println("�ּ�");
			 scan.nextLine();
			 String addr = scan.nextLine();
			 cs.setString(4,addr);			 
			 System.out.println("�г�");
			 String gra = scan.next();
			 cs.setString(5,gra);
			 System.out.println("����: �ּ� �� ��,���� �����ÿ�");
			 cs.setString(6,scan.next());
			 System.out.println("������");
			 cs.setInt(7,scan.nextInt());
			 System.out.println("��������� Y/N");
			 cs.setString(8,scan.next());
			 System.out.println("���� : 1�г��� 103, 2�г��� 104, 3�г��� 105�� �Է��Ͻÿ�");
			 cs.setInt(9,scan.nextInt());
			 int seq= cs.executeUpdate();
//			 ResultSet rs = (ResultSet)cs.getObject(1);
			 
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
		finally{
		            // DB ������ �����Ѵ�.
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
