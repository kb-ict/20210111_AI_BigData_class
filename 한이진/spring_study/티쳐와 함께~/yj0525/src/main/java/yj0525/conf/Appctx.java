package yj0525.conf;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.context.annotation.Configuration;

import yj0525.beans.UseAABB;

@Configuration
@ComponentScan(basePackages = {"yj0525.beans"})//yj0525.beans 패키지의 클래스(beans, 컴포넌트)를 불러온다 
public class Appctx {
	@Bean
	public UseAABB useAABB() {
		return new UseAABB();
	}
	

}
