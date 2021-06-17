package yj0525.main;

import org.springframework.context.support.GenericXmlApplicationContext;

import yj0525.beans.UseAABB;

public class YjMainXML {
	public static void main(String[] args) {
		GenericXmlApplicationContext gxac = new GenericXmlApplicationContext("spring0525.xml");
		
		UseAABB uab = gxac.getBean(UseAABB.class);
		uab.doAABB();
	}
}
