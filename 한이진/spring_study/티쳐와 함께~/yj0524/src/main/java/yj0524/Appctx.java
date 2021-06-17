package yj0524;

import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration
public class Appctx {
	@Bean
	public AA aa() {
		AA aa= new AA();
		return aa;
	}
    @Bean
	public BB bb() {
		BB bb = new BB();
		return bb;
	}
    @Bean
    @Qualifier("cc1")
  	public CC cc1() {
  		CC cc1 = new CC();
  		return cc1;
  	}
    @Bean
    @Qualifier("cc2")
  	public CC cc2() {
  		CC cc2 = new CC();
  		return cc2;
  	}
    //@Bean
  	//public DD dd() {
  	//	DD dd = new DD();
  	//	return dd;
  	//}
	@Bean
	public YjService yjService() {
		YjService ys =new YjService();
		return ys;
	}
}
