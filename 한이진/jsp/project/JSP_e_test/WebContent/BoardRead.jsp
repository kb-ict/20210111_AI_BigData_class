<%@page import="jsp.com.org.PostingData"%>
<%@page import="java.util.List"%>
<%@page import="jsp.com.org.PostingRead"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    <% PostingRead PRD = new PostingRead();
    	String num = (String)request.getParameter("num");
    	List<PostingData> content = PRD.Read(num);
    	System.out.println(num);
    	if(content!=null){
    		System.out.println(content);	
    	}
    %>
    
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
<!-- style 적용 css 파일 생성했습니다 -->
<link rel="stylesheet" href="/JSP/css/Style.css"/>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<header>
	
	<nav class="navbar navbar-expand-sm">
		<ul class="navbar-nav">
			<li class="nav-item active">
				<a class="nav-link" href="Main.jsp">Main</a>
			</li>
			<li class="nav-item">
     			 <a class="nav-link" href="./Tab/tab2.jsp">코로나 확진 현황</a>
    		</li>
    		<li class="nav-item">
    			<a class="nav-link" href="./Tab/NoticeBoard.jsp">국민의 소리</a>
    		</li>
			<%
    		String ID= (String)session.getAttribute("ID");
    		if(ID!=null){ %>
    		<li class="nav-item ">
    			<a class="nav-link float-right" href="./check/logout.jsp">로그아웃</a>
    		</li>
    		<%} %>
		</ul>
	</nav>
	<div class="jumbotron text-center">
		<h1>이겨내자! COVID-19</h1>
	</div>
	</header>
	
	
	<div class="container">
					<%for(int i=0; i<content.size();i++){PostingData Pdata = content.get(i);%>
			<form method="get" action="writeAction.jsp">
				<table class="table table-striped" style="text-align: center; border: 1px solid #dddddd">
					
      						<tr>
        						<td  style="background-color:#1AD9D9; color:#142273; text-align: center;">제목</td>
        						<td><%out.print(Pdata.getTitle());%></td>
        					</tr>
        					<tr>
        						<td  style="background-color:#B6ECF2; color:#142273; text-align: center;">작성일</td>
        						<td><%out.print(Pdata.getDate());%></td>
        					</tr>
        					<tr>
        						<td  style="background-color:#62CDD9; color:#142273; text-align: center;">작성자</td>
        						<td><%out.print(Pdata.getUserid());%></td>
      						</tr>
					
					
						<tr>
							<td  style="background-color:#B6ECF2; color:#142273; text-align: center;">내용</td>
							<td><%out.print(Pdata.getContent());%></td>
						</tr>
					
				</table>
					<%} %>
    					
</body>
</html>