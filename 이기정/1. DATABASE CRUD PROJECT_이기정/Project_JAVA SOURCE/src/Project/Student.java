package Project;

import java.io.Serializable;

public class Student implements Serializable {
	private int stuno;
	private String stuname;
	private String phone;
	private String address;
	private String grade;
	private String city;
	private int deposit;
	private String domitory;
	private int mentorid;
	// 1 setter...
	// 2 생성자로...

	//
	public Student(int stuno, String stuname, String phone, String address, String grade,
					String city, int deposit, String domitory, int mentorid) {
		this.stuno = stuno;
		this.stuname = stuname;
		this.phone = phone;
		this.address = address;
		this.grade = grade;
		this.city = city;
		this.deposit = deposit;
		this.domitory = domitory;
		this.mentorid = mentorid;
	}
	
	public void print() {
		System.out.printf("학번 : %d\t" ,stuno);
		System.out.printf("이름: %s\t" ,stuname);
		System.out.printf("전화번호: %s\t" ,phone);
		System.out.printf("주소는 %s\t" ,address);
		System.out.printf("학년은 %s\t" ,grade);
		System.out.printf("고향은 %s\t" ,city);
		System.out.printf("기숙사보증금 %d\t" ,deposit);
		System.out.printf("기숙사사용 유무 %s\t" ,domitory);
		System.out.printf("멘토번호는 %d\n" ,mentorid);
	}
}