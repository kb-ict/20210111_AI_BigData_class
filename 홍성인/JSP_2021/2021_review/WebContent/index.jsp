<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<style type="text/css">
	.container{
		width : 800px;
		height: 500px;
		background-color: #c8c8c8;
		padding: 150px 100px;
		box-sizing: border-box;
	}
</style>
<script type="text/javascript">
	window.onload = function(){
		document.getElementById('idsearch').onclick=function(){
			location.href = 'idsearch.jsp';
		}
		document.getElementById('login').onclick=function(){
			location.href = 'login.jsp?id='+id.value+'&pw='+pw.value;
		}
		document.getElementById('signin').onclick=function(){
			location.href = 'signin.jsp';
		}
		document.getElementById('outroom').onclick=function(){
			location.href = 'outroom.jsp';
		}
	}
</script>

</head>
<body>
	<div class="container">
		<table>
			<tr>
				<td>아이디</td>
				<td><input type="text" name="id" id="id"/></td>
				<td>비밀번호</td>
				<td><input type="text" name="pw" id="pw"/></td>
			</tr>
			<tr>
				<td><input type="button" value="ID찾기" id="idsearch"></td>
				<td><input type="button" value="로그인" id="login"></td>
				<td><input type="button" value="회원가입" id="signin"></td>
				<td><input type="button" value="퇴실" id="outroom"></td>
			</tr>
		</table>
	</div>
</body>
</html>