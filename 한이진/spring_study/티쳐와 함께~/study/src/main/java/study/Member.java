package study;

public class Member {
	private int id;
	private String password;
	private String name;
	
	public Member(String pw, String name) {
		this.password=pw;
		this.name= name;
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getPassword() {
		return password;
	}

	public void setPassword(String password) {
		this.password = password;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}
	public void changePassword(String oldPw, String newPw) {
		if(!password.equals(oldPw))
			throw new WrongIdPasswordException();
		this.password= newPw;
	}

}
