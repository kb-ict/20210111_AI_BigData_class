package com.org.mbat.freeboard;


import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

import javax.servlet.http.HttpServletRequest;

import org.mybatis.spring.SqlSessionTemplate;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.ResponseBody;
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
		List list=sst.selectList("freeboard.select");
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
	@RequestMapping(value = "/freeboard/insert")
	public String freeboardinsert(Model model, String name, Board board) {
		
		System.out.println("name= "+ name);
		System.out.println(board);
		bs.insert(board);
		return "redirect:/freeboard";
}


	@RequestMapping(value = "/freeboard/view") 
	public String freeboardview(Model model, Board board,int idx) { 
		System.out.println("idx= "+idx);
		model.addAttribute("view",bs.selectone(board.getIdx())); 
		return "freeboard/view"; 
		}

	/*
	 * @RequestMapping(value = "/freeboard/view") public String freeboardview(Model
	 * model, Board board,int idx) { System.out.println("idx= "+idx); Board boardone
	 * = sst.selectOne("freeboard.view", idx); model.addAttribute("view",boardone);
	 * return "freeboard/view"; }
	 */
	@RequestMapping(value = "/freeboard/insertform", method = RequestMethod.GET)
	public String freeboardinsertform(Model model) {
		
		System.out.println("게시판 글쓰기");
		//bs.insert();
		
		return "freeboard/freeboardinsert";
	}	
	
	@RequestMapping(value = "/freeboard/updateform", method = RequestMethod.GET)
	public String freeboardupdateform(Model model,Board board,int idx) {
		
		System.out.println("idx= "+idx);
		//Board board = sst.selectOne("freeboard.view", idx);
		model.addAttribute("board", bs.selectone(board.getIdx()));
		return "freeboard/freeboardupdate";
	}
	
	@RequestMapping(value = "/freeboard/update", method = RequestMethod.POST)
	public String freeboardupdate(Model model,Board board) {
		bs.update(board);
		//sst.update("freeboard.updateone",board);
		return "redirect:/freeboard";
	}
	@RequestMapping(value = "/freeboard/delete", method = RequestMethod.POST)
	//@ResponseBody
	public String freeboardelete(Model model, String[] cks) {
		ArrayList<String> cklist= new ArrayList<String>(Arrays.asList(cks));
		if(cks!=null) {
			sst.delete("freeboard.delete",cklist);
			/*
			 * for(String ele:cks) { System.out.println("ele= "+ele); }
			 */
		}
		//sst.update("freeboard.updateone",board);
		return "redirect:/freeboard";
	}
}
