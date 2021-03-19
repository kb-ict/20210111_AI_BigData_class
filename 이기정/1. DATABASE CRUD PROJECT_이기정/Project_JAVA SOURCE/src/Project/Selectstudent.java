package Project;

import java.sql.*;
import oracle.jdbc.*;

public class Selectstudent {

	public static void select(String[] args) {
		// TODO Auto-generated method stub
		Connection conn = null; // DB����� ����(����)�� ���� ��ü
		PreparedStatement pstm = null; // SQL ���� ��Ÿ���� ��ü
		ResultSet rs = null; // �������� �����Ϳ� ���� ��ȯ���� ���� ��ü
		try {
			int count = 0;
			Student[] Student = new Student[100];// Ŭ���� ���� ����� ���� ���� ��.
			// Class.forName("oracle.jdbc.driver.OracleDriver");
			// Connection con =
			// DriverManager.getConnection("jdbc:oracle:thin:@localhost:1521:orcl","hr","123456");
			conn = DBConnection.getConnection();
			// ���ν��� ȣ��
			CallableStatement cs = conn.prepareCall("begin SELECTALLCOLUMN_student(?); end;");// ���ν���
																											// ?��  �Ķ���� ����� �ִ� ��.
			// 1���� �Ķ���͸� �ޱ� ������
			// CallableStatement cs = conn.prepareCall("begin
			// singlerow_BUYTBL(?,?); end;");
			// �Է� �Ķ����
			// cs.setInt(1, 30);//1��°��, ���� ��
			// ��� �Ķ����
			cs.registerOutParameter(1, oracle.jdbc.OracleTypes.CURSOR);// 1��°��,
																		// ����
																		// ��
			// ����
			cs.execute();
//			ResultSet rs = (ResultSet)cs.getObject(1);
			rs = (ResultSet) cs.getObject(1);// �Ķ���Ͱ� 1���̴ϱ� 1����

			while (rs.next()) {

				/*
				 * System.out.println(rs.getInt("empno")+":"+
				 * rs.getString("ename")+":"+ rs.getString("job")+":"+
				 * rs.getString("mgr")+":"+ rs.getString("hiredate")+":"+
				 * rs.getString("comm")+":"+ rs.getString("deptno")+":"+
				 * rs.getInt("sal"));
				 */
				Student[count] = new Student(rs.getInt("stuno"), 
											 rs.getString("stuname"),
											 rs.getString("phone"),
											 rs.getString("address"),
											 rs.getString("grade"),
											 rs.getString("city"),
											 rs.getInt("deposit"),
											 rs.getString("domitory"),
											 rs.getInt("mentorid"));
				count++;
			} // ���� �Է�

			for (int i = 0; Student.length > i; i++)// string�� ũ�� ��ŭ
			{
				if (Student[i] != null) {
					Student[i].print();// ����Ʈ �Լ� ����
				}
			}

			rs.close();
			cs.close();
			conn.close();
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

}
