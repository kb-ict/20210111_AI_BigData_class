package DB;

import java.util.Scanner;

public class STUTBL {
	public  int idnum;
	public  String sname;
	public  String sgroup;
	public  String sex;
	public  int age;
	
	public STUTBL(){}
	public STUTBL(int id, String n, String g, String s, int a ){
		this.idnum=id;
		this.sname=n;
		this.sgroup=g;
		this.sex=s;
		this.age=a;
	}
//	public STUTBL intPut(){
//			
//			Scanner scan = new Scanner(System.in);
//
//			System.out.println("학번: ");
//			int idnum = scan.nextInt();
//			scan.nextLine();
//			System.out.println("이름: ");
//			String sname = scan.nextLine();
//			System.out.println("반: ");
//			String sgroup = scan.nextLine();
//			System.out.println("성별: ");
//			String sex=scan.nextLine();
//			System.out.println("나이: ");
//			int age= scan.nextInt();
//			STUTBL stu= new STUTBL(idnum,sname,sgroup, sex, age);
//			return stu;
//	}
	public void print(){
		System.out.println("학번: "+ this.idnum); 
		System.out.println("이름: "+ this.sname); 
		System.out.println("반: "+ sgroup); 
		System.out.println("성별: "+ sex);
		System.out.println("나이: "+ age); 
	}

}