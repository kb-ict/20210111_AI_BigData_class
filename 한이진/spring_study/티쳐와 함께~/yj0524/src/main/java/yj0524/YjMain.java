package yj0524;

import org.springframework.context.annotation.AnnotationConfigApplicationContext;

//@Contorrler
public class YjMain {
	public static void main(String[] args) {
		AnnotationConfigApplicationContext acac = new AnnotationConfigApplicationContext(Appctx.class);
		
		/*
		 * AA aa= acac.getBean(AA.class); aa.doA(); aa.doAA();
		 * 
		 * BB b = acac.getBean(BB.class); b.doB(); b.doBB();
		 */
		
		YjService ys = acac.getBean(YjService.class);
		ys.doAABBCC();
	}
	
}
