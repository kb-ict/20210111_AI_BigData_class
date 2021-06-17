package yj0525.main;

import org.springframework.context.annotation.AnnotationConfigApplicationContext;

import yj0525.beans.AA;
import yj0525.beans.BB;
import yj0525.conf.Appctx;

public class YJMain {
	public static void main(String[] args) {
		AnnotationConfigApplicationContext acac= new AnnotationConfigApplicationContext(Appctx.class);
		
		AA aa1= acac.getBean(AA.class);
		aa1.doA();
		aa1.doB();
		
		AA aa2= acac.getBean(AA.class);
		System.out.println(aa1); // 싱글톤 같은 주소를 출력
		System.out.println(aa2);
		
		System.out.println("aa1.a = "+aa1.a);// 싱글톤 같은 주소를 출력
		aa1.a=20;
		System.out.println("aa2.a= " +aa2.a);
		
		BB bb = acac.getBean(BB.class);
		bb.doB();
		bb.doBB();
	}

}
