<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>코로나19 현황</title>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
<!-- style 적용 css 파일 생성했습니다 -->
<link rel="stylesheet" href="/JSP/css/Style.css"/>

<script type="text/javascript">
	<%String ID = (String)session.getAttribute("ID");%>
	history.replaceState({}, null, location.pathname); //넘겨받은 파라메터를 숨기는 구문
	window.onload = function() {
		<%if(ID==null){ %>	//로그인 안했을때 활성화되는 버튼
		document.getElementById('member').onclick = function() {
			location.href = 'memberInsert.jsp';
		}
		<%}%>
	}
	
	
</script>

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
			<%if(ID!=null){ %>
    		<li class="nav-item ">
    			<a class="nav-link float-right" href="./check/logout.jsp">로그아웃</a>
    		</li>
    		<%} %>
		</ul>
	</nav>
	<div class="jumbotron text-center">
		<h1 >이겨내자! COVID-19</h1>
		<%if(ID==null){ %>
			<form class="col-2 float-right" action="./check/login.jsp">
				 <label for="ID">ID:</label>
				 <input type="id" class="form-control" id="id" placeholder="아이디를 입력하세요" name="id">
				 <label for="PWD">Password:</label> 
				 <input type="password" class="form-control" id="pwd" placeholder="비밀번호를 입력하세요" name="pwd">
				 <button type="button" class="btn mt-2" id = "member">
				 <img src="./Img/회원가입.JPG" width="30" height="30" class = "mr-2 img-thumbnail">회원가입</button>
				 <button type="submit" class="btn btn-success mt-2" id ="login">로그인</button>
			</form>
			<%}%>
	</div>
	
	</header>	
			
			
			</div>
			<%@ include file="./Tab/Main_tab.jsp" %>


</body>
</html>