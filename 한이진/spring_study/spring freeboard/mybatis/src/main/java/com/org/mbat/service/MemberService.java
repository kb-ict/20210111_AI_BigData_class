package com.org.mbat.service;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.org.mbat.dao.MemberDao;

@Service
public class MemberService {
	@Autowired
	MemberDao md;
	
	
	

}
