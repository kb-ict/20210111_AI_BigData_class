<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<style type = "text/css">
	
</style>
<script type ="text/javascript">
	window.onload = function(){
	/*
		1. document = '웹 페이지 그 자체'
		2. getElementById()=지정된 유일한 Id를 가진 요소(element)를 찾는 함수
	*/
		document.getElementById('idsearch').onclick=function(){
			location.href = 'idsearch.jsp'; 
		}
		document.getElementById('login').onclick=function(){
			var id = document.getElementById('id');
			var pw = document.getElementById('pw');
			location.href = 'login.jsp?id='+id.value+'&pw='+pw.value; 
			// 버튼 누르면 login.jsp로 이동, 이때 id와 pw를 가지고 이동한다.
		}
		document.getElementById('signin').onclick=function(){
			location.href = 'signin.jsp'; //버튼 누르면 signin.jsp로 이동
		}
		document.getElementById('outroom').onclick=function(){
			location.href = 'outroom.jsp'; //버튼 누르면 outroom.jsp로 이동
		}
	}
</script>

<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
<script type="text/javascript">
	$('document').ready(function(){
		$('#seatsel').on('click',function(){
			location.href='seatsel.jsp';
		})
		$('#logout').on('click',function(){
			location.href='logout.jsp';
		})
		$('#chart').on('click',function(){
			location.href='dg/dgmain.jsp'
		});
	})
</script>

</head>
<body>
	<div class="jumbotron">
		<div class="row">
			<input class="btn btn-primary ml-2 ml-2" id="chart" value="차트"/>
		</div>
  		<h1>My Study Page</h1>
  		<p>Raise and raised again till a lamb becomes a lion!</p>
  		
  		<%  
  			Object name = session.getAttribute("name");
  			if ( name != null ){ 
  		%>
  			안녕하세요...<% out.print((String)name); %>님
  		<% }else{ %>
  			<div class="form-group">
  				<label for="id">Name:</label>
  				<input type="text" class="form-control" id="id">
			</div>
			<div class="form-group">
  				<label for="pw">Password:</label>
  				<input type="password" class="form-control" id="pw">
			</div>
  		<% } %>
  		
		  
		<div class="row">
			<input type="button" value="ID찾기" id="idsearch" class="btn btn-primary ml-2 mr-2">
			<%  
  			if ( name != null ){ 
  			%>
			<input type="button" value="로그아웃" id="logout" class="btn btn-primary mr-2">
  			<% }else{ %>
  			<input type="button" value="로그인" id="login" class="btn btn-primary mr-2">
			<%} %>
			<input type="button" value="회원가입" id="signin" class="btn btn-primary mr-2">
			<input type="button" value="좌석선택" id="seatsel" class="btn btn-primary mr-2">
			<input type="button" value="시간충전" id="timecharge" class="btn btn-primary mr-2">
			<input type="button" value="퇴실" id="outroom" class="btn btn-primary mr-2">
		</div>		 
	</div>

	
	<div class="container">
  		<div class="row">
    		<div class="col-sm-4">
      			<h3>Column 1</h3>
      				<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit...</p>
      				<p>Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris...</p>
   		    </div>
    	<div class="col-sm-4">
      		<h3>Column 2</h3>
      			<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit...</p>
     			<p>Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris...</p>
    	</div>
    	<div class="col-sm-4">
      		<h3>Column 3</h3>        
      			<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit...</p>
      			<p>Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris...</p>
    	</div>
  </div>
</div>
	
</body>
</html>