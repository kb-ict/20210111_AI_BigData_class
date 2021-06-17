
<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>

<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<script src="https://d3js.org/d3.v6.min.js"></script>
<link rel="stylesheet"
	href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
<script
	src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script
	src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
<script
	src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
<link rel="stylesheet" href="/JSP/css/Style.css" />


</head>
<body>
	<header>
		<nav class="navbar navbar-expand-sm">
			<ul class="navbar-nav">
				<li class="nav-item active"><a class="nav-link"
					href="../Main.jsp">Main</a></li>
				<li class="nav-item"><a class="nav-link" href="tab2.jsp">코로나
						확진 현황</a></li>
				<li class="nav-item"><a class="nav-link" href="NoticeBoard.jsp">국민의
						소리</a></li>
				<%
					String ID = (String) session.getAttribute("ID");
					if (ID != null) {
				%>
				<li class="nav-item "><a class="nav-link float-right"
					href="../check/logout.jsp">로그아웃</a></li>
				<%
					}
				%>
			</ul>
		</nav>
	</header>
	

</body>
</html>