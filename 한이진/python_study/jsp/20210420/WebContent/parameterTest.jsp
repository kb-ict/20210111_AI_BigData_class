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
	1. form �±׷� ���μ� ������ ���
	2. �ּҿ� parameterProc.jsp?a=10&b=20
		Ư¡.. ���� ���������� ������ �۵�
	
	- �������� ���۹��
		Ư¡: �������� �ݱ�� ������ ������ �۵�
		sesion ��ü�� ���
		setAttribute("�̸�","��") // �����Լ�
		getAttribute("�̸�") //�����ö� ����ϴ� �Լ�
		
		���� ���� ����� session.invalidate() // ���ǿ� ���� ����
	*/
%>
<!-- form �±׷� ���μ� �Ķ���� ������ -->
<form action="parameterProc.jsp">
	a=<input type="text" name="a"/>
	b=<input type="text" name="b"/> 
	<input type="submit" value="Ȯ��"/>
</form>
<!-- �ּҷ� �Ķ���� ������ (��й�ȣ ��ȣȭ�� ���� �ʴ´�)-->
<a href="parameterProc.jsp?a=">a�� ������ </a>
</body>
</html>