<%@page import="sproj.com.org.SPRO_DBManager"%>
<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
<script	src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
<link rel="stylesheet" href="/sproj/css/mycss.css"/>
<%
	String seat= request.getParameter("seat");
	String name= (String)session.getAttribute("name");
	String phone= (String)session.getAttribute("phone");
	String m_time="3";
	
	SPRO_DBManager sdbm= new SPRO_DBManager();
	int ret= sdbm. seat_useInsert(seat,name,phone,m_time);
	if(ret>0){
		out.println("�¼� ������ �Ϸ�Ǿ����ϴ�.");
		out.println("<a href='Index.jsp' class='btn btn-primary'>����������</a>");
	}
	else{
		out.println("�¼� ���� �����Ͽ����ϴ�");
		response.sendRedirect("seatsave.jsp");
	}
%>