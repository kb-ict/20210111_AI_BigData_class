package study;

import java.util.Scanner;

public class MemberService {
	private MemberDao memberDao;
	
	public MemberService(MemberDao memberDao) {
		this.memberDao=memberDao;
	}
	public int selectPwService() {
		System.out.println("비밀번호: ");
		Scanner scan = new Scanner(System.in);
		String password= scan.nextLine();
		Member member= memberDao.selectPW(password);
		if(member!=null) {
			System.out.println("동일한 비밀번호가 존재합니다.");
		}
		System.out.println("이름: ");
		String name= scan.nextLine();
		Member newmember= new Member(password,name);
		memberDao.insert(newmember);
		return newmember.getId();
	}

}
