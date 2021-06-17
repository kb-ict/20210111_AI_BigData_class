package yj0607.conf;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.context.annotation.EnableAspectJAutoProxy;

import yj0607.cls.Calc;
import yj0607.cls.MyAspect;

@Configuration
@EnableAspectJAutoProxy
public class Myconf {
	@Bean
	public MyAspect myAsperct() {
		MyAspect ma = new MyAspect();
		return ma;
	}
	@Bean 
	public Calc calc() {
		Calc cl = new Calc();
		return cl;
	}
}
