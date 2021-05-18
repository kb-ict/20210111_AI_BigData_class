package singleton_pattern;

public class Main {
	public static void main(String[] args) {
		Normal normal1 = new Normal();
		Normal normal2 = new Normal();
		
		Singleton singleton1 = Singleton.getInstance();
		Singleton singleton2 = Singleton.getInstance();
		
		if(normal1 == normal2) {
			System.out.println("normal1�� normal2�� ���� �����ϴ�.");
		}else {
			System.out.println("normal1�� normal2�� ���� �ٸ��ϴ�.");
		}
		
		if(singleton1 == singleton2) {
			System.out.println("singleton1�� singleton2�� ���� �����ϴ�.");
		}else {
			System.out.println("singleton1�� singleton2�� ���� �ٸ��ϴ�.");
		}
	}
}
