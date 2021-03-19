package Project;

import java.sql.*;
import oracle.jdbc.*;

public class Selectstudent {

	public static void select(String[] args) {
		// TODO Auto-generated method stub
		Connection conn = null; // DB연결된 상태(세션)을 담은 객체
		PreparedStatement pstm = null; // SQL 문을 나타내는 객체
		ResultSet rs = null; // 쿼리문을 날린것에 대한 반환값을 담을 객체
		try {
			int count = 0;
			Student[] Student = new Student[100];// 클래스 파일 만들기 위해 만든 것.
			// Class.forName("oracle.jdbc.driver.OracleDriver");
			// Connection con =
			// DriverManager.getConnection("jdbc:oracle:thin:@localhost:1521:orcl","hr","123456");
			conn = DBConnection.getConnection();
			// 프로시저 호출
			CallableStatement cs = conn.prepareCall("begin SELECTALLCOLUMN_student(?); end;");// 프로시저
																											// ?는  파라미터 수대로 넣는 것.
			// 1개의 파라미터를 받기 때문에
			// CallableStatement cs = conn.prepareCall("begin
			// singlerow_BUYTBL(?,?); end;");
			// 입력 파라메터
			// cs.setInt(1, 30);//1번째에, 들어가는 값
			// 출력 파라메터
			cs.registerOutParameter(1, oracle.jdbc.OracleTypes.CURSOR);// 1번째에,
																		// 들어가는
																		// 값
			// 실행
			cs.execute();
//			ResultSet rs = (ResultSet)cs.getObject(1);
			rs = (ResultSet) cs.getObject(1);// 파라미터가 1개이니까 1개로

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
			} // 값을 입력

			for (int i = 0; Student.length > i; i++)// string의 크기 만큼
			{
				if (Student[i] != null) {
					Student[i].print();// 프린트 함수 실행
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
