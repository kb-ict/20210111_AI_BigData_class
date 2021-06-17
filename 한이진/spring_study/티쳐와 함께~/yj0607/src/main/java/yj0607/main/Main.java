package yj0607.main;

import org.springframework.context.annotation.AnnotationConfigApplicationContext;

import yj0607.cls.Calc;
import yj0607.cls.MyAspect;
import yj0607.conf.Myconf;

public class Main {
	/*
	 * Myconf 스프링 객체 담은 컨테이너
	 * Calc 계산기 클래스
	 * MyAscpect aop생성 클래스
	 * main 함수 실행하는 클래스
	 * 
	 * aop 데코레이션
	 * app.route("/") -> url 매핑
	 * requestMapping("/")
	 * home();
	 */
	AnnotationConfigApplicationContext acac= new AnnotationConfigApplicationContext(Myconf.class);
	
	Calc cl = acac.getBean(Calc.class);
	cl.doB(10,20);
	
	acac.close();
}
