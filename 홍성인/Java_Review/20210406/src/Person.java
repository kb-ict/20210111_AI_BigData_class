
class Person {
	private int num;
	private String name;
	private String age;
	
	public Person(String name, String age){
		this.name = name;
		this.age = age;
	}
	
	public Person(){
		
	}

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

	public String getAge() {
		return age;
	}

	public void setAge(String age) {
		this.age = age;
	}
	
}
