package teat0525.main;

import org.springframework.context.annotation.AnnotationConfigApplicationContext;

import teat0525.conf.Appctx;
import teat0525.controll.MemberController;

public class Main2 {
	public static void main(String[] args) {
		AnnotationConfigApplicationContext ac = new AnnotationConfigApplicationContext(Appctx.class);
		
		MemberController mc = ac.getBean(MemberController.class);
		mc.memberInsert();
		mc.memberSelect();
	}

}
