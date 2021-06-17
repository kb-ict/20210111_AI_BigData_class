package com.org.yj;

import java.sql.Connection;
import java.text.DateFormat;
import java.util.Date;
import java.util.Locale;

import javax.sql.DataSource;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

/**
 * Handles requests for the application home page.
 */
@Controller
@RequestMapping(value="/board")
public class HomeController {
	
	@Autowired
	private DataSource dataSource;
	
	@RequestMapping(value="/list")
	public String home(Locale locale, Model model) {
		try {
			Connection conn = (Connection)dataSource.getConnection();
			System.out.println("성공: "+conn);
		}catch(Exception e) {
			System.out.println("실패");
			e.printStackTrace();
		}
		return "/board/list";
	}
	
}
