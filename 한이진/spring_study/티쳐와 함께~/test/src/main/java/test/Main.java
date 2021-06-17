package test;

import org.springframework.context.support.GenericXmlApplicationContext;

public class Main {
	public static void main(String[] args) {
		GenericXmlApplicationContext gxac = new GenericXmlApplicationContext("conf.xml");
		
		Test test = gxac.getBean(Test.class);
		System.out.println(test.toString());
	}

}
