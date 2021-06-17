package yj0524;

import org.springframework.context.support.GenericXmlApplicationContext;

public class YjMain2 {
	public static void main(String[] args) {
		GenericXmlApplicationContext gxac = new GenericXmlApplicationContext("appctx.xml");
		
		YjService ys = gxac.getBean(YjService.class);
		ys.doAABBCC();
	}

}
