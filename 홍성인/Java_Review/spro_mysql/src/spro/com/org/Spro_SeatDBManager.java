package spro.com.org;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;

/*
 *	mysql 데이터베이스와 연결해서
	select insert update 함수 구현 
 */

public class Spro_SeatDBManager {
	public ArrayList<SPRO_SeatUse> select() {
		ArrayList<SPRO_SeatUse> list = new ArrayList<SPRO_SeatUse>();
		Connection conn = null; // DB 연결 객체 변수
		PreparedStatement pstmt = null; // SQL 만드는 객체변수
		ResultSet rs = null; // SQL문 실행하고 반환값 담는 객체변수
		try {
			Class.forName(DBinfo.mysql_class);
			conn = DriverManager.getConnection(DBinfo.mysql_url,DBinfo.mysql_id,DBinfo.mysql_pw);
			pstmt = conn.prepareStatement("select*from seat_use");
			rs = pstmt.executeQuery();
			while(rs.next()) {
				SPRO_SeatUse ssu = new SPRO_SeatUse();
				ssu.setM_time(rs.getInt("m_time"));
				ssu.setName(rs.getString("name"));
				ssu.setPhone(rs.getString("phone"));
				ssu.setNum(rs.getInt("num"));
				list.add(ssu);
			}
		}catch (Exception e) {
			e.printStackTrace();
		}
		finally {
			try {
				if (rs != null) rs.close();
				if (pstmt != null) pstmt.close();
				if (conn != null) conn.close();
			} catch (Exception e) {}
		}
		return list;
	}
}
