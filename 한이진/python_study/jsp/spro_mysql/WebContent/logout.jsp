<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<%
	//���� ����
	session.invalidate();
	//jsp ���� ��ü 3����
	/*
		request: getParameter() �ּ��� �Ķ��Ÿ ��������
		response: sendRedirect() �ּҷ� �̵��ϱ�
		session
			setAttribute("�̸�","��") �����̸� �� ����
			getAttribute("�̸�") ���� �̸� ��������
			invalidate() ���� ���� ����
	*/
	//index.jsp�� �̵�
	response.sendRedirect("Index.jsp");
%>