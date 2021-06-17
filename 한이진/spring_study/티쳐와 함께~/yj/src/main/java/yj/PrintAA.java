package yj;

public class PrintAA {
	private AA aa= new AA();
	
	public PrintAA(AA aa) {
		this.aa=aa;
	}
	public void printinfoAA() {
		System.out.println("a= "+ aa.getA()+"b= "+aa.getB());
	}

}
