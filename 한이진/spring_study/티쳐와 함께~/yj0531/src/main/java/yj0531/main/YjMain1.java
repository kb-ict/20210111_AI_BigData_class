package yj0531.main;

import org.springframework.context.support.AbstractApplicationContext;
import org.springframework.context.support.GenericXmlApplicationContext;

import yj0531.cls.A;

public class YjMain1 {
	/*
	 * 어노테이션       /    xml
	 * 스프링 객체담는 컨테이너 생성
	 * @Bean     /    <Bean>
	 * 
	 * 생성자 초기 함수.. 초기화 방식....setter 설정 초기화 방식
	 * 생성자 함수 초기화: <constructor-arg name="a" value="11">/<constructor-arg>
	 * setter 함수: <property name=" a" value="11"></property>
	 * 
	 * @ComponentScan : 기본 패키지 설정해서 bean객체 검색
	 * @Autowrid : 스프링 컨테이너에서 자동으로 객체 가져오는 거
	 * 
	 * @Component : 객체담기
	 * @Service: 객체담기
	 * @Controller: 객체담기
	 * @Repository : 객체담기
	 * @Aspect: 객체담기
	 */
	public static void main(String[] args) {
		AbstractApplicationContext acac= new GenericXmlApplicationContext("myconf1.xml");
		A a = acac.getBean(A.class);
		a.doA();
		acac.close();
	}

}
