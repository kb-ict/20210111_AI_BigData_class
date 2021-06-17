package yj;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration
public class Conf {
	@Bean 
	public AA aa() {
		return new AA();
	}
	@Bean
	public PrintAA printaa(AA aa) {
		PrintAA pa = new PrintAA(aa);
		pa.printinfoAA();
		return pa;
	}

}
