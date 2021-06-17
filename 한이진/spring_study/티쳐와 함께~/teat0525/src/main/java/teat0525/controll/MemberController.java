package teat0525.controll;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.stereotype.Component;
import org.springframework.stereotype.Controller;

import teat0525.beans.Member;

//import org.springframework.context.annotation.Configuration;

@Controller
@Component
public class MemberController {
	@Autowired
	Member member;
	
	@Autowired
	public MemberDAo memerDA0() {
		return new MemberDAo(member);
	}
	public void memberSelect() {
		MemberDAo md= new MemberDAo(member);
		md.memberInfo();
	}
	public void memberInsert() {
		MemberDAo md= new MemberDAo(member);
		md.newMember();
	}
}
