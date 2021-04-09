
public class OperatePromotion {
	public static void main(String[] args){
		byte num0 = 1;
		
		short num1 = 11;
		short num2 = 22;
		
		int num3 = 33;
		int num4 = 44;
		
		long num5 = 55;
		long num6 = 66;
		
		// ※ byte(short) result 가 오류가 나는 이유
		// 컴퓨터의 성능을 향상시키기 위해서 최손 단위로 int(long)로 설정하였기 때문이다
		
		long result = num0 + num1;
//		short result = (short) (num1 + num2);
		
		System.out.println(num1);
		System.out.println(num2);
		System.out.println(result);
	}
}
