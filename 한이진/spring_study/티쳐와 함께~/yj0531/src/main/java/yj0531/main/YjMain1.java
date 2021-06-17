package yj0531.main;

import org.springframework.context.support.AbstractApplicationContext;
import org.springframework.context.support.GenericXmlApplicationContext;

import yj0531.cls.A;

public class YjMain1 {
	/*
	 * ������̼�       /    xml
	 * ������ ��ü��� �����̳� ����
	 * @Bean     /    <Bean>
	 * 
	 * ������ �ʱ� �Լ�.. �ʱ�ȭ ���....setter ���� �ʱ�ȭ ���
	 * ������ �Լ� �ʱ�ȭ: <constructor-arg name="a" value="11">/<constructor-arg>
	 * setter �Լ�: <property name=" a" value="11"></property>
	 * 
	 * @ComponentScan : �⺻ ��Ű�� �����ؼ� bean��ü �˻�
	 * @Autowrid : ������ �����̳ʿ��� �ڵ����� ��ü �������� ��
	 * 
	 * @Component : ��ü���
	 * @Service: ��ü���
	 * @Controller: ��ü���
	 * @Repository : ��ü���
	 * @Aspect: ��ü���
	 */
	public static void main(String[] args) {
		AbstractApplicationContext acac= new GenericXmlApplicationContext("myconf1.xml");
		A a = acac.getBean(A.class);
		a.doA();
		acac.close();
	}

}
