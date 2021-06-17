<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
  <link rel="stylesheet" href="./css/Style.css"/>
<title>Covid-19 Web 게시판</title>
</head>
<body>
	<nav class="navbar navbar-expand-sm">
  <!-- Brand -->
  <a class="navbar-brand" href="Main.jsp">COVID-19</a>

  <!-- Links -->
  <ul class="navbar-nav">
    <li class="nav-item">
      <a class="nav-link" href="Main.jsp">메인</a>
    </li>
    <li class="nav-item">
     	<a class="nav-link" href="./Tab/tab2.jsp">코로나 확진 현황</a>
    </li>
    <li class="nav-item">
    	<a class="nav-link" href="./Tab/NoticeBoard.jsp">국민의 소리</a>
    </li>
    <li class="nav-item">
      		<a class="nav-link" href="survey.jsp">설문조사</a>
    </li>

    <!-- Dropdown -->
    <li class="nav-item dropdown">
      <a class="nav-link dropdown-toggle" href="#" id="navbardrop" data-toggle="dropdown">
        접속하기
      </a>
      <div class="dropdown-menu">
        <a class="dropdown-item" href="login.jsp">로그인</a>
        <a class="dropdown-item" href="memberInsert.jsp">회원가입</a>
      </div>
    </li>
  </ul>
</nav>
<!-- 로그인 양식 
<div class="container">
	<div class="col-lg-6"></div>
	<div class="col-lg-6">
		<div class="jumbotron mt-5" >-->
<div class="jumbotron mt-5">
	<div class="jumbotron" align="center">
		<header>
			<h3>로그인</h3>
		</header>
		<form action="./check/login.jsp" class='col-5' method="post">
				<div class="form-group">
					<input type="text" class="form-control" placeholder="아이디" name="id" maxlength="20">
				</div>
				<div class="form-group">
					<input type="password" class="form-control" placeholder="비밀번호" name="pwd" maxlength="20">
				</div>
				<input type="submit" class="btn btn-primary form-control" value="로그인">
				<button type="button" class="btn mt-2" id = "member">
				 <img src="./Img/회원가입.JPG" width="30" height="30" class = "mr-2 img-thumbnail">회원가입</button>
			</form>
		</div>
	</div>
	<div class="col-lg-4">
</div>
</body>
</html>