import java.util.Scanner;

public class EngMain {
	//	EngMain Ŭ���� = EngMain�޼ҵ� + main �޼ҵ�� ����
	
	public EngMain(){
		Scanner scan = new Scanner(System.in);
		ManagerEng me = new ManagerEng();
		
		while(true){
			System.out.println("Option : 1.�����߰� 2.������� 3.������� 4.��ȸ");
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
				System.exit(1);  			// check : '1'�� �ǹ�
		}
	}
	
	public static void main(String[] args){
		new EngMain(); 						// check 
	}
}
