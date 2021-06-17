package test;

public class Test {
	private int num;
	private String str;
	
	public Test() {
		
	}
	public Test(int num, String str) {
		super();
		this.num=num;
		this.str=str;
	}
	
	public int getNum() {
		return num;
	}
	public void setNum(int num) {
		this.num = num;
	}
	public String getStr() {
		return str;
	}
	public void setStr(String str) {
		this.str = str;
	}
	
	@Override
	public String toString() {
		return "Test [num=" + num + ", str=" + str + "]";
	}
	public void tester() {
		System.out.println("testÀÔ´Ï´Ù.");
	}

}
