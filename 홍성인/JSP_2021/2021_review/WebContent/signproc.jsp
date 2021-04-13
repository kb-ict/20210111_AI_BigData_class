<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%
	out.println(123);
	out.println("<p>문단</p>");
	for(int i=0;i<10;i++){
		out.println("i = "+i);
	}
	
	String p_id = (String)request.getParameter("id");
	String p_pw = (String)request.getParameter("pw");
	String p_name = (String)request.getParameter("name");
	String p_phone = (String)request.getParameter("phone");
	
	out.println("<br>");
	out.println("p_id = "+p_id);
	out.println("<br>");
	out.println("p_pw = "+p_pw);
	out.println("<br>");
	out.println("p_name = "+p_name);
	out.println("<br>");
	out.println("p_phone = "+p_phone);
%>