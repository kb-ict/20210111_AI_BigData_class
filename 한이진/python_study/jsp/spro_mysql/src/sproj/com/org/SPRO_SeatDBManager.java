package sproj.com.org;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;

/*
 * mysql �����ͺ��̽��� �����ؼ�
 * seatuse
 * select insert update delete �Լ� ����
 */
public class SPRO_SeatDBManager implements DBInfo {
	
	public ArrayList<SPRO_seatUse> select() {
		Connection conn = null; //DB ���� ��ü ����
		PreparedStatement pstmt=null; // SQL ����� ��ü ����
		ResultSet rs =null; //sql�� �����ϰ� ��ȯ�� ��� ��ü ����
		ArrayList<SPRO_seatUse> list = new ArrayList<SPRO_seatUse>();
		
		try {
			Class.forName(DBInfo.mysql_class);
			conn=DriverManager.getConnection(DBInfo.mysql_url,DBInfo.mysql_id,DBInfo.mysql_pw);
			pstmt=conn.prepareStatement("Select*from seat_use");
			rs=pstmt.executeQuery();
			
			while(rs.next()) {
				SPRO_seatUse ssu = new SPRO_seatUse();
				ssu.setM_time(rs.getInt("m_time"));
				ssu.setName(rs.getString("name"));
				ssu.setPhone(rs.getString("phone"));
				ssu.setNum(rs.getInt("num"));
				list.add(ssu);
			}
		}catch(Exception e) {
			e.printStackTrace();
		}finally {
			try {
				if(rs!=null)rs.close();
				if(pstmt!= null)pstmt.close();
				if(conn!= null)conn.close();
			}catch(Exception c) {
				
			}			
		}return list;
	}

}
