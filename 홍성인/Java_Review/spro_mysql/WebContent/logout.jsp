<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<%
	// 세션 내용 삭제
	session.invalidate();
	// jsp 내장 객체 3가지
	/*
		request,
			setCharacterEncoding("utf-8") utf-8로 인코딩 지정
			getParameter() 주소의 파라메타 가져오기
		response, 
			sendRedirect() 주소로 이동하기
		session
			setAttribute("이름","값") 세션 이름 값 지정
			getAttrubute("이름") 세션 이름 가져오기
			invalidate() 세션 내용 삭제
	*/
	// index.jsp 로 이동해라
	response.sendRedirect("index.jsp");
%>