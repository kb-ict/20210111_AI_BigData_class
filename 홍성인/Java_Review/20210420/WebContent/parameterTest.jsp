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
		파라메타 전송방법
		1. form  태그로 감싸서 보내는 방식
		2. 주소에  parameterProc.jsp?a=10&b=20
		
		세션 전송방법
		session 객체를 사용
		setAttribute("이름","값")   <- 설정 사용함수
		getAttribute("이름")		   <- 가져올때 사용하는 함수
		
		세션 값 지우기 = session.invalidate()  <-세션에 내용 삭제
		*/
		
		
		
%>
<!-- form태크로 감까서 파라메터 보내기 -->
	<form action="parameterProc.jsp">
		a = <input type="text" name="a"/>
		b = <input type="text" name="b"/>
		<input type="submit" value="확인"/>
	</form>
<!-- 주소로 감싸서 파라메터 보내기 -->
	<a href="parameterProc.jsp?a=10">a값보내기</a>
	
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