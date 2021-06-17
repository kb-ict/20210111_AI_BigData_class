package teat0525.controll;

import java.util.Scanner;

import org.springframework.stereotype.Component;

import teat0525.beans.Member;
@Component
public class MemberDAo {
	private Member member;
	
	public MemberDAo(Member member) {
		this.member=member;
	}
	public void memberInfo() {
		System.out.println(member.getAge());
		System.out.println(member.getName());
		
	}
	public void newMember() {
		System.out.println("name: ");
		Scanner scan= new Scanner(System.in);
		member.setName(scan.nextLine());
		System.out.println("age: ");
		member.setAge(scan.nextInt());
	}
	

}
