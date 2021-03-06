package spro.com.org;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;

public class Default {

	public void copy() {
		Connection conn = null;
		PreparedStatement pstmt = null;
		try{
			Class.forName(DBinfo.mysql_class);

			conn = DriverManager.getConnection(DBinfo.mysql_url, DBinfo.mysql_id, DBinfo.mysql_pw);
			
			// 블럭 지정 후 ctrl+ shift + x 대문자 지정
			// 블럭 지정 후 ctrl+ shift + y 소문자 지정
			pstmt = conn.prepareStatement(
					"INSERT INTO "+ 
					"SEAT_USE "+
					"(NUM,NAME,PHONE,M_TIME) "+
					"VALUES "+
					"(?,?,?,?)");
			
			int ret = pstmt.executeUpdate();
			if(ret > 0 ){
				System.out.println("정상적으로 insert됨");
			}
		}
		catch(Exception e){
			e.printStackTrace();
		}
		finally{
			try{
				if(pstmt != null) pstmt.close();
				if(conn != null) conn.close();
			}catch(Exception ex){
				
			}
		}
	}
}
