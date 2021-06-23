package com.org.mbat.freeboard;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class BoardService {
	@Autowired
	BoardDao dao;
	
	public void insert(Board board) {
		dao.insert(board);
	}
	public Board selectone(int idx) {
		 return dao.selectone(idx);
	}
	public void update(Board board) {
		dao.update(board);
	}

}
