package mh0519;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import org.springframework.context.ApplicationContext;
import org.springframework.context.annotation.AnnotationConfigApplicationContext;
import org.springframework.context.support.GenericXmlApplicationContext;

public class MemberController {
	
	public static ApplicationContext acac = null;
	MemberService memberService;
	BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
	
	public MemberController(MemberService memberService) throws IOException {
		this.memberService = memberService;
		
		while(true) {
			System.out.println("???ҷ????");
			String cmd = br.readLine();
			if(cmd.equals("insert")) {
				memberService.insert();
			}
		}
	}
	
	public static void main(String[] args) throws IOException {
		
//		acac = new AnnotationConfigApplicationContext(MyConf.class);
		
//		MemberService ms = acac.getBean("memberService",MemberService.class);
		
		GenericXmlApplicationContext gxac = new GenericXmlApplicationContext("myconf.xml");
		
		MemberService ms = gxac.getBean("memberService",MemberService.class);
		
		new MemberController(ms);
//		new MemberController(new MemberService(new MemberDao()));
	}

}
