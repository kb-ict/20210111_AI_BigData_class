package yj0525.main;

import org.springframework.context.annotation.AnnotationConfigApplicationContext;

import yj0525.beans.UseAABB;
import yj0525.conf.Appctx;

public class YjMainAuto {
	public static void main(String[] args) {
		AnnotationConfigApplicationContext acac= new AnnotationConfigApplicationContext(Appctx.class);
		
		UseAABB uab = acac.getBean("useAABB",UseAABB.class);
		uab.doAABB();
	}

}
