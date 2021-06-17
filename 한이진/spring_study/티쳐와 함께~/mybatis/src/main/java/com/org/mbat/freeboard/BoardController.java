package com.org.mbat.freeboard;


import java.util.Arrays;
import java.util.List;

import javax.servlet.http.HttpServletRequest;

import org.mybatis.spring.SqlSessionTemplate;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.ui.Model;

@Controller
public class BoardController {
	/*
	 * spring 객체 담는 컨테이너에 넣는 어노테이션
	 * @component
	 * @controller : url ��ó ������ ����
	 * @service : �Խ��� ��� ���񽺸�
	 * @repository: DB ����
	 * @aspect : aop
	 */
	@Autowired
	BoardService bs;
	
	@Autowired
	SqlSessionTemplate sst;
	
	
	@RequestMapping(value = "/freeboard", method = RequestMethod.GET)
	public String freeboard(Model model) {
		
		System.out.println("게시판 홈");
		List list=sst.selectList("freeboard.select", 10);
		model.addAttribute("list",list);
		//	bs.select();
//		model.addAttribute("data", "myData");
//		List strlist =Arrays.asList("a1","a2","a3","a4");
//		List mylist =Arrays.asList(new Board(1,"title","pass","content","wdate","email",null,null),
//									new Board(2,"title2","pass2","content2","wdate2","email2",null,null));
//		model.addAttribute("strlist",strlist);
//		model.addAttribute("mylist",mylist);
		return "freeboard/freeboard";
	}
//	@RequestMapping(value = "/freeboard/insert", method = RequestMethod.GET)
//	public String freeboardinsert(Model model,HttpServletRequest request) {
//		String name= request.getParameter("name");
//		System.out.println("name= "+ name);
//		bs.insert();
//		
//		return "freeboard/freeboard";
//	}
	@RequestMapping(value = "/freeboard/insert", method = RequestMethod.GET)
	public String freeboardinsert(Model model, String name, Board board) {
		
		System.out.println("name= "+ name);
		bs.insert(board);
		System.out.println(board);
		return "freeboard/freeboard";
}
	@RequestMapping(value = "/freeboard/insertform", method = RequestMethod.GET)
	public String freeboardinsertform(Model model) {
		
		System.out.println("게시판 글쓰기");
		//bs.insert();
		
		return "freeboard/freeboardinsert";
	}
	

}
