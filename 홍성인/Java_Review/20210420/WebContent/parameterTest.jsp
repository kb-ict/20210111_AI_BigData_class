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
		/*
		�Ķ��Ÿ ���۹��
		1. form  �±׷� ���μ� ������ ���
		2. �ּҿ�  parameterProc.jsp?a=10&b=20
		
		���� ���۹��
		session ��ü�� ���
		setAttribute("�̸�","��")   <- ���� ����Լ�
		getAttribute("�̸�")		   <- �����ö� ����ϴ� �Լ�
		
		���� �� ����� = session.invalidate()  <-���ǿ� ���� ����
		*/
		
		
		
%>
<!-- form��ũ�� ��� �Ķ���� ������ -->
	<form action="parameterProc.jsp">
		a = <input type="text" name="a"/>
		b = <input type="text" name="b"/>
		<input type="submit" value="Ȯ��"/>
	</form>
<!-- �ּҷ� ���μ� �Ķ���� ������ -->
	<a href="parameterProc.jsp?a=10">a��������</a>
	
<%
String a = request.getParameter("a");
String b = request.getParameter("b");

out.print("a = "+a);
out.print("b = "+b);

String c = request.getParameter("c");
out.print("c = "+c);

Integer se_a = (Integer)session.getAttribute("a");
String se_id = (String)session.getAttribute("id");
String se_b = (String)session.getAttribute("b");

out.println("se_a"+se_a);
out.println("se_id"+se_id);
out.println("se_b"+se_b);
%>	
</body>
</html>