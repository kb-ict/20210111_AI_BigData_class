package study;

import java.util.Collection;
import java.util.HashMap;
import java.util.Map;

public class MemberDao {
	private static int nextId = 0;
	
	
	private Map<String, Member> map = new HashMap<String, Member>();
	
	public Member selectPW(String password) {
		return map.get(password);
	}
	public void insert(Member member) {
		member.setId(++nextId);
		map.put(member.getPassword(), member);
	}
	public void update(Member member) {
		map.put(member.getPassword(),member);
	}
	public Collection<Member> selectAll(){
		return map.values();
	}

}
