package yj0525.beans2;

import org.springframework.stereotype.Component;

@Component("a1")
public class AA {
	public void doA() {
		System.out.println("이 클래스(컴포넌트, 빈)는 a1로 가져와야 한다.");
	}

}
