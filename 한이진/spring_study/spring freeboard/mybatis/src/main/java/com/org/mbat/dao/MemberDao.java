package com.org.mbat.dao;

import org.mybatis.spring.SqlSessionTemplate;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

import com.mysql.fabric.xmlrpc.base.Member;

@Repository
public class MemberDao {
	@Autowired
	SqlSessionTemplate sst;
	
	public void insertMember(Member member) {
		sst.insert("member.insert", member);
	}

}
