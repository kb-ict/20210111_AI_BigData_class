package spro.com.org.dg;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.util.List;

import spro.com.org.DBinfo;

public class SPRO_DaeGuManager {
	public List<SPRO_DaeGu> select(int pageNum) {
		pageNum = 0;
		Connection conn = null;
		PreparedStatement pstmt = null;
		try{
			Class.forName(DBinfo.mysql_class);

			conn = DriverManager.getConnection(DBinfo.mysql_url, DBinfo.mysql_id, DBinfo.mysql_pw);
			
			// 블럭 지정 후 ctrl+ shift + x 대문자 지정
			// 블럭 지정 후 ctrl+ shift + y 소문자 지정
			pstmt = conn.prepareStatement(
					"select*from daegu limit 0,100"
					);
			
			int ret = pstmt.executeUpdate();
			if(ret > 0 ){
				System.out.println("테이블 내용 있음");
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
		return null;
	}
}
