package teat0525.main;

import org.springframework.context.support.GenericXmlApplicationContext;

import teat0525.controll.MemberController;
import teat0525.controll.MemberDAo;

public class Main {
	public static void main(String[] args) {
		GenericXmlApplicationContext gx = new GenericXmlApplicationContext("appctx.xml");
		
		MemberController mc= gx.getBean(MemberController.class);
		mc.memberInsert();
		mc.memberSelect();
	}

}
