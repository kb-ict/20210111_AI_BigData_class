<%@page import="Studycafe.com.org.DBmanager"%>
<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<%
	String seat= request.getParameter("seat");
	String name=(String)session.getAttribute("name");
	String phone=(String)session.getAttribute("phone");
	String time="3";
	
	DBmanager dbm = new DBmanager();
	int ret= dbm.seatSelect(seat,name,phone,time);
	if(ret>0){
		out.println("�¼� ���� �Ϸ�");
	}
	else{
		out.println("�¼� ���� ����");
	}
%>
<!DOCTYPE html>
<html>
<head>
<meta charset="EUC-KR">
<title>Insert title here</title>
</head>
<body>

</body>
</html>