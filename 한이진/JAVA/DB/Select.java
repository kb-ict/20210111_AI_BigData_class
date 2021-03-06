package DB;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.Scanner;

public class Select {
	public static void selectDo(){
		Connection conn = null;
		PreparedStatement pstm = null;
		 ResultSet rs = null;
		
		 try{
			 int i =0;
			 STUTBL[] stutbl = new STUTBL[5];
			 conn=DBConnection.getConnection();
			 CallableStatement cs = conn.prepareCall("begin selectall_STUTBL(?); end;");
			 cs.registerOutParameter(1, oracle.jdbc.OracleTypes.CURSOR);
			 cs.execute();
			 rs=(ResultSet)cs.getObject(1);//(?) (물음표 개수)
			 while(rs.next()){
				 stutbl[i]=new STUTBL(rs.getInt("idnum"), rs.getString("sname"),rs.getString("sgroup"),
						 rs.getString("sex"), rs.getInt("age"));
				i++;
			 }
			 for (int j=0; j<stutbl.length; j++){
				 if(stutbl[j] !=null){
					 stutbl[j].print();
				 }
			 }
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
