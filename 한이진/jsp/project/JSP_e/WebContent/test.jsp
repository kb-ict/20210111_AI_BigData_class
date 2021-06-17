<%@page import="jsp.com.org.Posting.Posting"%>
<%@page import="java.util.List"%>
<%@page import="jsp.com.org.Posting.PostingDB"%>
<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="EUC-KR">
<title>Insert title here</title>
</head>
<body>
<% int PageNum=Integer.parseInt(request.getParameter("PageNum"));
	PostingDB PDB = new PostingDB();
	List<Posting> list = PDB.select_reload(PageNum);
	out.println(list);
%>
</body>
</html>