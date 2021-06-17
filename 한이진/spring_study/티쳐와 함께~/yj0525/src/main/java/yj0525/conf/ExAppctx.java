package yj0525.conf;

import org.springframework.context.annotation.ComponentScan;
import org.springframework.context.annotation.ComponentScan.Filter;
import org.springframework.context.annotation.Configuration;
import org.springframework.context.annotation.FilterType;

import yj0525.anno.MyAnno;

@Configuration
@ComponentScan(basePackages = {"yj0525.beans"},
		excludeFilters = @Filter(type=FilterType.ANNOTATION, classes= {MyAnno.class}))
public class ExAppctx {

}
