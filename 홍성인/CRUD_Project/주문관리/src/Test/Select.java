package Test;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.sql.ResultSet;

public class Select {
	public void select(){
		Connection conn = null;
		PreparedStatement ps = null;
		PreparedStatement ps2 = null;
		ResultSet rs = null; // ºø∑∫ √‚∑¬
		ResultSet rs2 = null;

		try{
			Class.forName("oracle.jdbc.driver.OracleDriver");
			conn = DriverManager.getConnection("jdbc:oracle:thin:@localhost:1521:xe", "AI", "1234");
			ps = conn.prepareStatement(
					"select menu, sum(amount)as \"∆«∏≈∑Æ\",sum(sales) as \"∏≈√‚\" from hambuger "
					+"group by menu "
					+"having sum(amount) !=0 "
					+"order by sum(sales) desc"
					);
			ps2 = conn.prepareStatement("select sum(sales) as \"√—∏≈√‚\" from hambuger ");
			rs = ps.executeQuery();
			rs2 = ps2.executeQuery();
			
			while(rs.next()){
				
				System.out.printf("%5s",rs.getString(1));
				System.out.printf("%5s",rs.getString(2));
				System.out.printf("%5s",rs.getString(3));
				System.out.println();
			}
			while(rs2.next()){
			System.out.println("√—∏≈√‚     " + rs2.getString(1));
			}
		}catch (Exception e){
			System.out.println(e.getMessage());
		}finally{
				try{
					if(rs != null)
						rs.close();
					if(ps != null)
						ps.close();
					if(conn != null)
						conn.close();
				}catch(Exception e){
					
				}
			}
		}
	}

