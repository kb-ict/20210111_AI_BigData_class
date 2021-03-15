package DB;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;


public class Insert {
	
	public static void insertDO(STUTBL stu) {
		Connection conn =null;//세션을 담는 객체
		PreparedStatement pstm =null;//쿼리문을 나타내는 객체
		ResultSet rs = null;//쿼리문에 대한 반환값을 담는 변수
		
		try{
			int count=0;
//			STUTBL[] stutbl = new STUTBL[5];//10명의 학생 정보 입력
			conn = DBConnection.getConnection();//프로시저 호출
			CallableStatement cs = conn.prepareCall("begin add_STUTBL(?,?,?,?,?); end;");

			 
//			 System.out.println("학생정보를 입력하세요>>>");
			 
			STUTBL stutbl= stu;
			cs.setInt(1, stutbl.idnum);
			 cs.setString(2, stutbl.sname);
			 cs.setString(3, stutbl.sgroup);
			 cs.setString(4, stutbl.sex);
			 cs.setInt(5, stutbl.age);
			
//			for(int i=0; i<stutbl.length;i++){
//			 cs.setInt(1, stutbl[i].idnum);
//			 cs.setString(2, stutbl[i].sname);
//			 cs.setString(3, stutbl[i].sgroup);
//			 cs.setString(4, stutbl[i].sex);
//			 cs.setInt(5, stutbl[i].age);
//			 }
			 
			 

				int seq=cs.executeUpdate();
				
				if(seq==0){
					System.out.println("값: "+seq);
				}
				else{
					System.out.println("값: "+seq);
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
	