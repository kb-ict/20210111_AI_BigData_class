
public class VariableDecl {
	public static void main(String[] args){
		double num1, num2;
		double result;
		
		num1 = 1.0000001;
		num2 = 2.0000001;
		
		result = num1 + num2;
		
		System.out.println(result);
		
		// 결과값 3.0000003 이 나오지 않는다. 왜냐하면 실수 표현에는 오차가 존재하기 때문이다
		
		// 변수 이름 제약사항
		// 1. 자바는 대소문자를 구분한다
		// 2. 숫자로 시작 할 수 없다
		// 3. $ 와 _ 이외의 특수문자는 사용할 수 없다
		// 4. 키워드는 사용 할 수 없다
	}
}
