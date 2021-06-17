package yj0518;

public class MemberDTO {
	public String name;
	public MemberDTO() {
		
	}
	public MemberDTO(String name) {
		this.name=name;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	@Override
	public String toString() {
		return "MemberDTO [name=" + name + "]";
	}
	
}
