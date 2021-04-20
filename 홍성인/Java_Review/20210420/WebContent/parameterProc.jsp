<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="EUC-KR">
<title>Insert title here</title>
</head>
<body>
<%

String a = request.getParameter("a");
String b = request.getParameter("b");

out.print("a = "+a);
out.print("b = "+b);

String c = request.getParameter("c");
out.print("c = "+c);

	
%>

</body>
</html>