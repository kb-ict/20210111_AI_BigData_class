package yj0531.cls;

import org.springframework.beans.factory.DisposableBean;
import org.springframework.beans.factory.InitializingBean;

public class A  implements InitializingBean, DisposableBean {
	public void doA() {
		System.out.println("doA");
	}
	public void afterPropertiesSet() throws Exception{
		System.out.println("AŬ���� �����ϰ� ���� ����");
	}
	public void destroy() throws Exception{
		System.out.println("������ ��ü ��� �� ������...");
	}

}
