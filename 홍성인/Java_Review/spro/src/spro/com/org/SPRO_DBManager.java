package spro.com.org;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;

public class SPRO_DBManager {
	public SPRO_MEMBER ckLogin(String id,String pw) {
		SPRO_MEMBER member = null;
		
		Connection conn = null;						//DB 연결객체
		PreparedStatement pstmt = null;
		ResultSet rs = null;
		try {
			Class.forName("oracle.jdbc.driver.OracleDriver");
			conn = DriverManager.getConnection("jdbc:oracle:thin:@localhost:1521:xe", "AI", "1234");
			pstmt = conn.prepareStatement(""
					+ "SELECT * FROM SPRO_MEMBER " 
					+ " WHERE ID=? AND PW=? "
					+ "");
			pstmt.setString(1,id);			// sql구문에 WHERE ID=? AND PW=? 로 수정 후
			pstmt.setString(2,pw);			// pstmt.setString(1,id) 추가
			rs = pstmt.executeQuery();
			
			if(rs.next()) {
				member = new SPRO_MEMBER();
				member.setId(id);
				member.setPw(pw);
				member.setName(rs.getString("name"));
				member.setPhone(rs.getString("phone"));
			}
		}catch (Exception e) {
			e.printStackTrace();
			
		}
		finally {
			try{
				if(rs != null) rs.close();
				if(pstmt != null)pstmt.close();
				if(conn != null)conn.close();
			}catch(Exception e){
				
			}
		}
		return member;
	}
}
