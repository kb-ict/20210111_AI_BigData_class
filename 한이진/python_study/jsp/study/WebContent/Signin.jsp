<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="EUC-KR">
<title>Insert title here</title>
<meta charset="utf-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
<script	src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</head>
<body>
	<div class="jumbotron">
		<h1>My Study</h1>
		<p>�����Ϸ��� ȸ������!</p>
		<form action="Signproc.jsp" method="get">
		<div class="form-group">
			<label for="id">���̵�</label>
			<input type="text" name="id" class="form-control"/>
		</div>
		<div class="form-group">
			<label for="pw">��й�ȣ</label>
			<input type="text" name="pw" class="form-control"/>
		</div>
		<div class="form-group">
			<label for="name">�̸�</label>
			<input type="text" name="name" class="form-control"/>
		</div>
		<div class="form-group">
			<label for="phone">��ȭ��ȣ</label>
			<input type="text" name="phone" class="form-control"/>
		</div>
		<input type="submit" value="ȸ������" class="btn btn-primary"/>
		</form>
	</div>
</body>
</html>