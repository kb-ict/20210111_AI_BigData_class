package DB;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Scanner;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class DBStart {
	public static STUTBL inPut(){
		
		Scanner scan = new Scanner(System.in);

		System.out.println("학번: ");
		int idnum = scan.nextInt();
		scan.nextLine();
		System.out.println("이름: ");
		String sname = scan.nextLine();
		System.out.println("반: ");
		String sgroup = scan.nextLine();
		System.out.println("성별: ");
		String sex=scan.nextLine();
		System.out.println("나이: ");
		int age= scan.nextInt();
		STUTBL stu= new STUTBL(idnum,sname,sgroup, sex, age);
		return stu;
}
	public static void main(String[] args) {
		
		Connection conn =null;//세션을 담는 객체
		PreparedStatement pstm =null;//쿼리문을 나타내는 객체
		ResultSet rs = null;//쿼리문에 대한 반환값을 담는 변수
		STUTBL[] stutbl = new STUTBL[5];
		Scanner scan = new Scanner(System.in);
		
		
		while(true){
			System.out.println("1.insert 2. delete 3. update 4. select");
			System.out.println("선택>>>");
			int sel= scan.nextInt();
			if(sel==1){
				System.out.println("학생 정보를 입력하세요.(학번/이름/반/성별/나이)");
				
				
				for(int i=0; i<stutbl.length; i++)
				{
					STUTBL stu = inPut();
					
//					if(stutbl[i]==null){
					stutbl[i]=stu;
					Insert.insertDO(stu);
//					}
				}
				
			}
			else if(sel==2){
				System.out.println("학생 정보를 삭제합니다.");
				Delete.deleteDo();
			}
			else if(sel==3){
				System.out.println("학생 정보를 수정합니다.");
				System.out.println("학생 학번 입력: ");
				int num= scan.nextInt();
				STUTBL stu = inPut();
				stutbl[num]=stu;
				Update.updateDo(stutbl, num);
			}
			else if(sel==4){
				System.out.println("학생 정보를 출력합니다.");
				Select.selectDo();
//				 for (int j=0; j<stutbl.length; j++){
//					 if(stutbl !=null){
//						 stutbl[j].print();
//					 }
//				 }
			}
			
			else{
				System.out.println("선택하신 사항은 없습니다.");
				System.out.println("=====프로그램 종료=====");
				break;
			}
					
				
			}
		}

	
	}
