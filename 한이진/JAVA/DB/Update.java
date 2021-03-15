package DB;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.Scanner;

//import DB.DBConnection;



public class Update {
	public static void updateDo(STUTBL[] stu, int num){
		Connection conn = null;
		PreparedStatement pstm = null;
		 ResultSet rs = null;
		
		 try{
			 int count =0;
			//  STUTBL[] stutbl = new STUTBL[20];
			 conn=DBConnection.getConnection();
			 CallableStatement cs = conn.prepareCall("begin update_STUTBL(?,?,?,?,?); end;");
			 
//			 System.out.println("수정할 학생 정보를 입력하세요>>>");
			 STUTBL[] stutbl = stu;
			 cs.setInt(1, stutbl[num].idnum);
			 cs.setString(2, stutbl[num].sname);
			 cs.setString(3, stutbl[num].sgroup);
			 cs.setString(4, stutbl[num].sex);
			 cs.setInt(5, stutbl[num].age);
			 
			 int seq= cs.executeUpdate();
			 
			 if(seq==0)
			 { System.out.println("값"+ seq);}
			 else
			 { System.out.println("값"+ seq);}
			 
			 cs.close();
			 conn.close();
		 } catch(Exception e){
			 e.printStackTrace();
			 }
		 finally{
				//DB 연결을 종료한다.
				//모든 프로시저 마지막에 추가
				try{
					if(rs!=null){rs.close();}
					if(pstm !=null){pstm.close();}
					if(conn !=null){conn.close();}
				}catch(Exception e){
					throw new RuntimeException(e.getMessage());
				}
		 }
	}

}