package yj0525.conf;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.context.annotation.Configuration;

import yj0525.beans.UseAABB;

@Configuration
@ComponentScan(basePackages = {"yj0525.beans"})//yj0525.beans ��Ű���� Ŭ����(beans, ������Ʈ)�� �ҷ��´� 
public class Appctx {
	@Bean
	public UseAABB useAABB() {
		return new UseAABB();
	}
	

}
