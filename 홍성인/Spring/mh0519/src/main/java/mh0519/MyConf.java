package mh0519;

import java.io.IOException;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.context.annotation.Import;

@Configuration
@Import(MyConf1.class)
public class MyConf {
	
	
	@Bean
	public MemberDao memberDao() {
		MemberDao md = new MemberDao();
		return md;
	}
	
	@Bean
	public MemberService memberService() {
		return new MemberService(memberDao());
	}
	
	
//	@Bean
//	public MemberController memberController() throws IOException {
//		return new MemberController(memberService());
//	}
	
}
