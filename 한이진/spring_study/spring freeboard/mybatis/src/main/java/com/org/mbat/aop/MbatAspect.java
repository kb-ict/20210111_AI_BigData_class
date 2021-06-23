package com.org.mbat.aop;

import java.util.Arrays;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpSession;

import org.aspectj.lang.ProceedingJoinPoint;
import org.aspectj.lang.Signature;
import org.aspectj.lang.annotation.Around;
import org.aspectj.lang.annotation.Aspect;
import org.aspectj.lang.annotation.Pointcut;

@Aspect
public class MbatAspect {
	@Pointcut("execution(public * com.org.mbat.cls.*.*(..))")
	private void publicTarget() {
		
	}
	@Around("publicTarget()")
	public Object doASC(ProceedingJoinPoint joinPoint) throws Throwable {
		long start = System.nanoTime();
		HttpServletRequest request = null;
		HttpSession session = null;
		try {
			System.out.println("이전");
			Object[] obs = joinPoint.getArgs();
			for(Object o: obs) {
				if(o instanceof HttpServletRequest)
					request =(HttpServletRequest)o;
			}
			String a = request.getParameter("aaa");
			System.out.println("a = "+ a);
			
			if(request != null) {
				session = request.getSession();
				String pw= (String)session.getAttribute("id");
				System.out.println("pw= "+pw);
				if(pw==null)
					return "redirect:/"; //mian으로 이동
			}
			
			Object result = joinPoint.proceed();
			return result;
		} finally {
			long finish = System.nanoTime();
			Signature sig = joinPoint.getSignature();
			System.out.printf("%s.%s(%s) 실행 시간 : %d ns\n",
					joinPoint.getTarget().getClass().getSimpleName(),
					sig.getName(), Arrays.toString(joinPoint.getArgs()),
					(finish - start));
			System.out.println("해당클래스" + joinPoint.getTarget().getClass().getSimpleName());
			System.out.println("해당메서드" + sig.getName());
			System.out.println("해당파라메타" +  Arrays.toString(joinPoint.getArgs()));
		}
	}
}
