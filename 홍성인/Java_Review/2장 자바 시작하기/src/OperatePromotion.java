
public class OperatePromotion {
	public static void main(String[] args){
		byte num0 = 1;
		
		short num1 = 11;
		short num2 = 22;
		
		int num3 = 33;
		int num4 = 44;
		
		long num5 = 55;
		long num6 = 66;
		
		// �� byte(short) result �� ������ ���� ����
		// ��ǻ���� ������ ����Ű�� ���ؼ� �ּ� ������ int(long)�� �����Ͽ��� �����̴�
		
		long result = num0 + num1;
//		short result = (short) (num1 + num2);
		
		System.out.println(num1);
		System.out.println(num2);
		System.out.println(result);
	}
}
