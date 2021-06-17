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

<script type="text/javascript">
<%Object ID = session.getAttribute("id");%>
history.replaceState({}, null, location.pathname); //넘겨받은 파라메터를 숨기는 구문
window.onload = function() {
	<%if(ID!=null){ %>	//로그인시 로그아웃 버튼 활성화
	document.getElementById('logout').onclick = function() {
		<%session.invalidate();%>
		location.href = 'Main.jsp';
	}
	<%}else{%>	//로그인 안했을때 활성화되는 버튼
	document.getElementById('member').onclick = function() {
		location.href = 'memberInsert.jsp';
	}
	<%}%>
}	
</script>

<style>

	.tablinks{
	margin-left:40px;
	}
	
	nav{margin-right: 100px}
	
	form{
		display:inline;
		padding-left: 0px;
		padding-right: 0px;
		}
        
</style>

<script type="text/javascript">	
	
	//탭내용 변경 스크립트
	function openTab(evt, tabName) { var i, tabcontent, tablinks; 
	tabcontent = document.getElementsByClassName("tabcontent"); 
	for (i = 0; i < tabcontent.length; i++) { tabcontent[i].style.display = "none"; } 
	tablinks = document.getElementsByClassName("tablinks");
	for (i = 0; i < tablinks.length; i++) { tablinks[i].className = tablinks[i].className.replace(" active", "");}
	document.getElementById(tabName).style.display = "block"; evt.currentTarget.className += " active"; }



</script>
</head>
<body>
	<header>
	<div class="container">
		<h1 class="display-2" align="center">test</h1>
	</div>
	</header>
	
	<nav>
			<div class="tab"> 
			<button class="tablinks active col-2 btn btn-outline-secondary" onclick="openTab(event, 'tab1')">메인</button> 
			<button class="tablinks col-2 btn btn-outline-secondary" onclick="openTab(event, 'tab2')">현황</button> 
			<button class="tablinks col-2 btn btn-outline-secondary" onclick="openTab(event, 'tab3')">자유게시판</button> 
			
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
			
			<%}else{%>
			<button type = "button" class="btn btn-success ml-3 float-right col-2" id = "logout">로그아웃</button>
			<%}%>
			
			</div> 
			
			
			
	</nav>
	
 		<!--탭의 내용을 가져오기 위해 사용 -->
		<%@ include file="tab1.jsp" %> 	
		<%@ include file="tab2.jsp" %>
		<%@ include file="tab3.jsp" %>
		
		
		
		
		
	


</body>
</html>