import java.util.Scanner;

public class EngMain {
	//	EngMain 클래스 = EngMain메소드 + main 메소드로 구성
	
	public EngMain(){
		Scanner scan = new Scanner(System.in);
		ManagerEng me = new ManagerEng();
		
		while(true){
			System.out.println("Option : 1.문장추가 2.문장수정 3.문장삭제 4.조회");
			int select = scan.nextInt();
			if(select == 1)
				me.insertEng();
			else if(select == 2)
				me.updateEng();
			else if(select == 3)
				me.deleteEng();
			else if(select == 4)
				me.selectEng();
			else
				System.exit(1);  			// check : '1'의 의미
		}
	}
	
	public static void main(String[] args){
		new EngMain(); 						// check 
	}
}
