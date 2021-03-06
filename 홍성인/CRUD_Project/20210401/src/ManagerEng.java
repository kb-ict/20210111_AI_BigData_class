import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Scanner;

public class ManagerEng {
	Scanner scan = new Scanner(System.in);
	Connection conn = null;					// <-- check
	PreparedStatement pstmt = null;			// <-- check
	
	public void insertEng(){
		String idx = null;
		String voc = null;
		String syn = null;
		String sen = null;
		
		System.out.println("번호 입력");
		idx = scan.nextLine();
		System.out.println("단어 입력");
		voc = scan.nextLine();
		System.out.println("동의어 입력");
		syn = scan.nextLine();
		System.out.println("문장 입력");
		sen = scan.nextLine();
		
			Connection conn = null;
			PreparedStatement pstmt = null;
			
			// check : ojdbc6.jar 를 추가하는 이유
			
			try{
				Class.forName("oracle.jdbc.driver.OracleDriver");
				conn = DriverManager.getConnection("jdbc:oracle:thin:@localhost:1521:xe","AI","1234");
				System.out.println("DB연결성공");
				pstmt = conn.prepareStatement("INSERT INTO ENG "+
											  "(IDX,VOC,SYN,SEN) "+
											  "VALUES "+
											  "(?,?,?,?)");
				pstmt.setString(1, idx);
				pstmt.setString(2, voc);
				pstmt.setString(3, syn);
				pstmt.setString(4, sen);
				
				pstmt.executeUpdate();
				
			}catch(Exception e){
				System.out.println("error 클래스 파일 없음");
			}
			finally{
				try{
					conn.close();
				}catch(SQLException e){
					e.printStackTrace();
				}
			}
	}
	
	public void updateEng(){
		String idx = null;
		String voc = null;
		String syn = null;
		String sen = null;
		
		System.out.println("번호 입력");
		idx = scan.nextLine();
		System.out.println("단어 입력");
		voc = scan.nextLine();
		System.out.println("동의어 입력");
		syn = scan.nextLine();
		System.out.println("문장 입력");
		sen = scan.nextLine();
		
			Connection conn = null;
			PreparedStatement pstmt = null;
		
			try{
				Class.forName("oracle.jdbc.driver.OracleDriver");
				conn = DriverManager.getConnection("jdbc:oracle:thin:@localhost:1521:xe","AI","1234");
				System.out.println("DB연결성공");
				pstmt = conn.prepareStatement("UPDATE ENG "+
										  	  "SET VOC=?,SYN=?,SEN=?"+
										  	  "WHERE IDX =?");
				pstmt.setString(1, voc);
				pstmt.setString(2, syn);
				pstmt.setString(3, sen);
				pstmt.setString(4, idx);
			
				pstmt.executeUpdate();
			
			}catch(Exception e){
				System.out.println("error 클래스 파일 없음");
			}
			finally{
				try{
					conn.close();
				}catch(SQLException e){
					e.printStackTrace();
				}
			}
	}
	
	public void deleteEng(){
		String idx = null;
		String voc = null;
		String syn = null;
		String sen = null;
		
		System.out.println("번호 입력");
		idx = scan.nextLine();
		System.out.println("단어 입력");
		voc = scan.nextLine();
		System.out.println("동의어 입력");
		syn = scan.nextLine();
		System.out.println("문장 입력");
		sen = scan.nextLine();
		
			Connection conn = null;
			PreparedStatement pstmt = null;
			
			// check : ojdbc6.jar 를 추가하는 이유
			
			try{
				Class.forName("oracle.jdbc.driver.OracleDriver");
				conn = DriverManager.getConnection("jdbc:oracle:thin:@localhost:1521:xe","AI","1234");
				System.out.println("DB연결성공");
				pstmt = conn.prepareStatement("DELETE FROM ENG "+
											  "WHERE IDX = ? ");
				//	check : 삭제 시 왜 idx,voc,syn,sen 를 다 입력해야 하는가 ??
				pstmt.setString(1, idx);
				pstmt.setString(2, voc);
				pstmt.setString(3, syn);
				pstmt.setString(4, sen);
				
				pstmt.executeUpdate();
				
			}catch(Exception e){
				System.out.println("error 클래스 파일 없음");
			}
			finally{
				try{
					conn.close();
				}catch(SQLException e){
					e.printStackTrace();
				}
			}
	}
	
	public void selectEng(){
		Connection conn = null;
		PreparedStatement pstmt = null;
		ResultSet rs = null;
		
		try{
			Class.forName("oracle.jdbc.driver.OracleDriver");
			conn = DriverManager.getConnection("jdbc:oracle:thin:@localhost:1521:xe","AI","1234");
			pstmt = conn.prepareStatement("SELECT*FROM ENG");
			rs = pstmt.executeQuery(); 						// <-- check
			while(rs.next()){
				System.out.print(rs.getString(1)+" ");		// print vs println 차이점
				System.out.print(rs.getString(2)+" ");
				System.out.print(rs.getString(3)+" ");
				System.out.println(rs.getString(4));
			}
		}catch(Exception e){
			e.printStackTrace();
		}
		finally{
			try{
				if(rs != null) rs.close();
				if(pstmt != null) pstmt.close();
				if(conn != null) conn.close();
			}catch(Exception e){}
		}
	}
}
