package yj;

import org.springframework.context.annotation.AnnotationConfigApplicationContext;

public class MyMain {
	public static void main(String[] args) {
		AnnotationConfigApplicationContext acac= new AnnotationConfigApplicationContext(Conf.class);
		PrintAA aa = acac.getBean(PrintAA.class);
		aa.printinfoAA();
	}

}
