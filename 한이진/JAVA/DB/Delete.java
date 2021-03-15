package DB;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.Scanner;

public class Delete {
	public static void deleteDo(){
		Connection conn = null;
		PreparedStatement pstm = null;
		 ResultSet rs = null;
		
		 try{
			 int count =0;
			 STUTBL[] stutbl = new STUTBL[20];
			 conn=DBConnection.getConnection();
			 CallableStatement cs = conn.prepareCall("begin del_STUTBL(?); end;");
			 
			 System.out.println("삭제할 학번 입력하세요>>>");
			 Scanner scan = new Scanner(System.in);
			 int num = scan.nextInt();
			 cs.setInt(1, num);
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
