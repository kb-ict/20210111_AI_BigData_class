
public class BoxMana {
	BoxMana(){
		//�ڷ����� ����
		Box<Apple> abox = new Box<Apple>(new Apple());
		Box<Orange> bbox= new Box<Orange>(new Orange());
		
		Apple a= abox.getObj();
		Orange b= bbox.getObj();
		
//		Apple aa= bbox.getObj(); error ������ �ٷ� Ȯ�� ����������.
		
		System.out.println(a);
		System.out.println(b);
		
	}
	public static void main(String[] args) {
		new BoxMana();
	}

}
