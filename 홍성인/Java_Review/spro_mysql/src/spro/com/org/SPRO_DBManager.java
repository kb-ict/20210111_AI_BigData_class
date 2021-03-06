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
			Class.forName("com.mysql.cj.jdbc.Driver");
			conn = DriverManager.getConnection("jdbc:mysql://localhost:3306/spro", "root", "1234");
			pstmt = conn.prepareStatement(""
					+ "SELECT * FROM MEMBER " 
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

	public int signInsert(String id, String pw, String name, String phone) {
		Connection conn = null;
		PreparedStatement pstmt = null;
		try{  // ojcbc jar 추가 확인
		Class.forName(DBinfo.mysql_class);
	    conn = DriverManager.getConnection(DBinfo.mysql_url,DBinfo.mysql_id,DBinfo.mysql_pw);

		pstmt = conn.prepareStatement(
				"INSERT INTO "+ 
				"MEMBER "+
				"(ID,PW,NAME,PHONE) "+	
				"VALUES "+
				"(?,?,?,?)");
		pstmt.setString(1,id);
		pstmt.setString(2,pw);
		pstmt.setString(3,name);
		pstmt.setString(4,phone);
 
		int ret = pstmt.executeUpdate();
		if(ret > 0){
			System.out.println("정상적으로 insert됨");
			return ret;
		}
		}
		catch(Exception e){
			e.printStackTrace();
		}
		finally{
			try{
				if(pstmt != null)pstmt.close();
				if(conn != null)conn.close();
			}
		catch(Exception e){
		}
	}
		return 0;
	}

	public int seat_useInsert(String seat,String name,String phone,String m_time) {
		Connection conn = null;
		PreparedStatement pstmt = null;
		try{  // ojcbc jar 추가 확인
		Class.forName(DBinfo.mysql_class);
	    conn = DriverManager.getConnection(DBinfo.mysql_url,DBinfo.mysql_id,DBinfo.mysql_pw);

		pstmt = conn.prepareStatement(
				"INSERT INTO "+ 
				"SEAT_USE "+
				"(NUM,NAME,PHONE,M_TIME) "+	
				"VALUES "+
				"(?,?,?,?)");
		pstmt.setString(1,seat);
		pstmt.setString(2,name);
		pstmt.setString(3,phone);
		pstmt.setString(4,m_time);
 
		int ret = pstmt.executeUpdate();
		if(ret > 0){
			System.out.println("정상적으로 insert됨");
			return ret;
		}
		}
		catch(Exception e){
			e.printStackTrace();
		}
		finally{
			try{
				if(pstmt != null)pstmt.close();
				if(conn != null)conn.close();
			}
		catch(Exception e){
		}
	}
		return 0;
	}
}
