package Project;

import java.util.Scanner;

public class Main {
	public static void main(String[] args) {

		Scanner scan = new Scanner(System.in);
		while (true) {
			System.out.println("���ҷ���? 1.�Է�,2.��ȸ ,3.����,4.���� ����");
			int select = scan.nextInt();
			System.out.println("select = " + select);
			if (select == 1) {
				// �л����
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
				System.out.println("����");
				break;
			}
		}
	}
}