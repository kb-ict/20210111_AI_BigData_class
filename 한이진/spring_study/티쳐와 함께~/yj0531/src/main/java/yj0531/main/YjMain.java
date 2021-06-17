package yj0531.main;

import org.springframework.beans.BeansException;
import org.springframework.beans.factory.config.ConfigurableListableBeanFactory;
import org.springframework.context.annotation.AnnotationConfigApplicationContext;
import org.springframework.context.annotation.AnnotationConfigApplicationContextExtensionsKt;
import org.springframework.context.support.AbstractApplicationContext;

import yj0531.cls.A;
import yj0531.conf.Myconf1;

public class YjMain {
	/*
	 * spring chapter 5
	 * mybatis ¼³Á¤ 
	 * 
	 */
	public static void main(String[] args) {
		AbstractApplicationContext acac = new AnnotationConfigApplicationContext(Myconf1.class);
		A a = acac.getBean(A.class);
		a.doA();
		acac.close();
	}

}
