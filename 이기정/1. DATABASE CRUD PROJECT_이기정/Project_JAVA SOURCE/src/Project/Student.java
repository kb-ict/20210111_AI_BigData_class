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
	// 2 �����ڷ�...

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
		System.out.printf("�й� : %d\t" ,stuno);
		System.out.printf("�̸�: %s\t" ,stuname);
		System.out.printf("��ȭ��ȣ: %s\t" ,phone);
		System.out.printf("�ּҴ� %s\t" ,address);
		System.out.printf("�г��� %s\t" ,grade);
		System.out.printf("������ %s\t" ,city);
		System.out.printf("����纸���� %d\t" ,deposit);
		System.out.printf("������� ���� %s\t" ,domitory);
		System.out.printf("�����ȣ�� %d\n" ,mentorid);
	}
}