package yj0524;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;

public class YjService {
	@Autowired
	AA aa;
	
	@Autowired
	BB bb;
	
	@Autowired
	@Qualifier("cc1")
	CC cc;
	
	// 스프링컨테이너안에 dd가 없더라도 에러 안나오게
	@Autowired(required = false)
	DD dd;

	public void doAABBCC() {
		aa.doA();
		aa.doAA();
		bb.doB();
		bb.doBB();
		cc.doC();
		cc.doCC();
	}

}
