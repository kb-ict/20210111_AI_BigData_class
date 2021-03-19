package Project;

import java.util.Scanner;

public class Main {
	public static void main(String[] args) {

		Scanner scan = new Scanner(System.in);
		while (true) {
			System.out.println("뭐할래요? 1.입력,2.조회 ,3.수정,4.삭제 선택");
			int select = scan.nextInt();
			System.out.println("select = " + select);
			if (select == 1) {
				// 학생등록
//				Project.Addstudent p1 = new Project.Addstudent();
//				p1.Add();
				Addstudent.add();
			}
			else if (select == 2) {
				Selectstudent.select(args);
			} 
			else if (select == 3) {
				Updatestudent.update(args);
			} 
			else if (select == 4) {
				Delstudent.del(args);
			} 
			else{
				System.out.println("종료");
				break;
			}
		}
	}
}