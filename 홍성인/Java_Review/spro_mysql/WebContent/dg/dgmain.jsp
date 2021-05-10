<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<%@ page import="spro.com.org.dg.SPRO_DaeGuManager" %>
<%@ page import="spro.com.org.dg.SPRO_DaeGu" %>
<%@ page import="java.util.List" %>
<%
	SPRO_DaeGuManager sdbm = new SPRO_DaeGuManager();
	List<SPRO_DaeGu> list = sdbm.select(0);
%>
<!DOCTYPE html>
<html>
<head>
<meta charset="EUC-KR">
<title>Insert title here</title>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
<link rel="stylesheet" href="/spro/css/mycss.css"/>
</head>
<body>
<div class="jumbotron">
	<h1>MY STUDY</h1>
	<p>dgmain</p>
</div>
</body>
</html>