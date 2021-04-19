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
		document.getElementById('idsearch').onclick=function(){
			location.href = 'idsearch.jsp'; //버튼 누르면 idsearch.jsp로 이동
		}
		document.getElementById('login').onclick=function(){
	//		var id = document.getElementById('id');
	//		var pw = document.getElementById('pw');
	//		alert('id='+id.value);
	//		alert('pw='+pw.value);
			location.href = 'login.jsp?id='+id.value+'&pw='+pw.value; 
			//버튼 누르면 login.jsp로 이동, 이때 id와 pw를 가지고 이동해야함.
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

</head>
<body>
	<div class="jumbotron">
  		<h1>My Study Page</h1>
  		<p>Raise and raised again till a lamb becomes a lion!</p>
		<div class="form-group">
  			<label for="id">Name:</label>
  			<input type="text" class="form-control" id="id">
		</div>
		<div class="form-group">
  			<label for="pw">Password:</label>
  			<input type="password" class="form-control" id="pw">
		</div>  
		<div class="row">
			<input type="button" value="ID찾기" id="idsearch" class="btn btn-primary ml-2 mr-2">
			<input type="button" value="로그인" id="login" class="btn btn-primary mr-2">
			<input type="button" value="회원가입" id="signin" class="btn btn-primary mr-2">
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