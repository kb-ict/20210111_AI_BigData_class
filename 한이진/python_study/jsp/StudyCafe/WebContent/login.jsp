<%@page import="Studycafe.com.org.Member"%>
<%@page import="Studycafe.com.org.DBmanager"%>

<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>

<!DOCTYPE html>
<html>
<head>
<meta charset="EUC-KR">
<title>Insert title here</title>
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
<script	src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
<link rel="stylesheet" href="/sproj/css/mycss.css"/>
</head>
<body>
	<div class="jumbotron">
		<h1>My Study</h1>
		<p>��������!</p>
	</div>
</body>
<%
	
	String id = (String)request.getParameter("id");
	String pw = (String)request.getParameter("pw");
	DBmanager bdm = new DBmanager();
	Member ret = bdm.checkLogin(id, pw);
	if(ret!=null){
		session.setAttribute("id",id);
		session.setAttribute("pw",pw);
		session.setAttribute("name",ret.getName());
		session.setAttribute("phone", ret.getPhone());
		out.println("�α��� ����");
		out.println("<a href= 'index.jsp' class='btn btn-primary'>����������</a>");
	}else{
		out.println("�α��� ����");
		out.println("<a href= 'index.jsp' class='btn btn-primary'>�α��� â</a>");
	}
	
%>
</html>