package study;

import java.util.Scanner;

public class MemberService {
	private MemberDao memberDao;
	
	public MemberService(MemberDao memberDao) {
		this.memberDao=memberDao;
	}
	public int selectPwService() {
		System.out.println("��й�ȣ: ");
		Scanner scan = new Scanner(System.in);
		String password= scan.nextLine();
		Member member= memberDao.selectPW(password);
		if(member!=null) {
			System.out.println("������ ��й�ȣ�� �����մϴ�.");
		}
		System.out.println("�̸�: ");
		String name= scan.nextLine();
		Member newmember= new Member(password,name);
		memberDao.insert(newmember);
		return newmember.getId();
	}

}
