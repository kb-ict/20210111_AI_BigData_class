package sproj.com.org;
/*
 * ���̺�� 1:1 ���ΰ��迡 �ش�Ǵ� Ŭ����
 */

public class SPRO_seatUse {
	private int num;
	private String name;
	private String phone;
	private int m_time;
	
	//alt + shift + s -> r getter setter �����
 	public int getNum() {
		return num;
	}
	public void setNum(int num) {
		this.num = num;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public String getPhone() {
		return phone;
	}
	public void setPhone(String phone) {
		this.phone = phone;
	}
	public int getM_time() {
		return m_time;
	}
	public void setM_time(int m_time) {
		this.m_time = m_time;
	}
	
	//alt + shift + s -> s toString() 
	@Override
	public String toString() {
		return "SPRO_seatUse [num=" + num + ", name=" + name + ", phone=" + phone + ", m_time=" + m_time + "]";
	}
	
	

}
