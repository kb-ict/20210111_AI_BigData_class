package yj0531.conf;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

import yj0531.cls.A;
import yj0531.cls.B;

@Configuration
public class Myconf1{
	@Bean
	public A a(){
		A a = new A();
		return a;
	}
	@Bean(initMethod = "init", destroyMethod = "des")
	// 
	public B b() {
		B b = new B();
		return b;
	}


}
