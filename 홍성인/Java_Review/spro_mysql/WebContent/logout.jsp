<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<%
	// ���� ���� ����
	session.invalidate();
	// jsp ���� ��ü 3����
	/*
		request,
			setCharacterEncoding("utf-8") utf-8�� ���ڵ� ����
			getParameter() �ּ��� �Ķ��Ÿ ��������
		response, 
			sendRedirect() �ּҷ� �̵��ϱ�
		session
			setAttribute("�̸�","��") ���� �̸� �� ����
			getAttrubute("�̸�") ���� �̸� ��������
			invalidate() ���� ���� ����
	*/
	// index.jsp �� �̵��ض�
	response.sendRedirect("index.jsp");
%>