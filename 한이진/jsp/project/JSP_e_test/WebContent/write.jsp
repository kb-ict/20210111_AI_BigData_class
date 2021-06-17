<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>게시글 작성</title>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
<!-- style 적용 css 파일 생성했습니다 -->
<link rel="stylesheet" href="/JSP/css/Style.css"/>
</head>
<body>
<header>
	<% String ID= (String)session.getAttribute("ID");%>
	<%if(ID==null){ %>
	<script>
		alert("로그인을 해야합니다.")
		location.href="./Tab/NoticeBoard.jsp"
	</script>
	<%}else{ %>
	<nav class="navbar navbar-expand-sm">
		<ul class="navbar-nav">
			<li class="nav-item active">
				<a class="nav-link" href="Main.jsp">Main</a>
			</li>
			<li class="nav-item">
     			 <a class="nav-link" href="tab2.jsp">코로나 확진 현황</a>
    		</li>
    		<li class="nav-item">
    			<a class="nav-link" href="./Tab/NoticeBoard.jsp">국민의 소리</a>
    		</li>
			<%
    		if(ID!=null){ %>
    		<li class="nav-item ">
    			<a class="nav-link float-right" href="./check/logout.jsp">로그아웃</a>
    		</li>
    		<%} %>
		</ul>
	</nav>
	</header>
	<div class="container">
			<form method="get" action="writeAction.jsp">
				<table class="table table-striped" style="text-align: center; border: 1px solid #dddddd">
					<thead>
						<tr>
							<th colspan="2" style="background-color:#9BDAF2; color:#0468BF text-align: center;" >게시글 작성하기</th>
						</tr>
					</thead>
					<tbody>
						<tr>
							<td><input type="text" class="form-control" placeholder="글 제목" name="title" maxlength="50"></td>
						</tr>
						<tr>
							<td><textarea class="form-control" placeholder="글 내용" name="content" maxlength="1000"></textarea></td>
						</tr>
					</tbody>
				</table>
				<input type="submit" class="btn btn-info pull-right" value="작성완료">
			</form>
		</div>
	</div>
	<%} %>
</body>
</html>