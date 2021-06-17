<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>회원가입</title>

<link rel="stylesheet"
	href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
<script
	src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script
	src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
<script
	src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>

<style type="text/css">
label {
	margin-bottom: 0px;
}

#idcheck {
	margin-left: 0px
}

body {
	background-color: #e9ecef
}
</style>


</head>
<body>

	<div class="jumbotron" align="center">
		<header>
			<h1 class="display-1">회원가입</h1>
		</header>

		<form action="./check/insertMember.jsp" class='col-5'>
			<div class="form-group">
				<label for="NAME" class="float-left mt-2">성명:</label>
				 <input type="text" class="form-control mt-2" id="inputName" name="NAME" placeholder="이름을 입력하세요.">
			</div>
			<div class="form-group">
				<label for="ID" class="float-left">아이디:</label><br> <input
					type="text" class="form-control float-left mt-2 col-9" id="inputId"
					name="ID" required="required" placeholder="아이디를 입력하세요."> <input
					type="button" class="float-left mt-2 btn btn-success col-3"
					value="아이디 확인" id="idcheck" name="idcheck"><br>
				<div class="check_font" id="id_check"></div>
			</div>
			<div class="form-group">
				<label for="pwd" class="float-left mt-2">비밀번호:</label> <input
					type="password" class="form-control mt-2" id="inputPwd" name="PW"
					placeholder="비밀번호를 입력하세요.">
			</div>
			<div>
				<label for="chpwd" class="float-left mt-2">비밀번호 확인:</label> <input
					type="password" class="form-control mt-2" id="inputPwd2"
					placeholder="비밀번호를  재입력하세요.">
				<div id="pw_check"></div>
			</div>
			<div class="form-group">
				<label for="phone" class="float-left mt-2">전화번호:</label> <input
					type="text" class="form-control mt-2" id="inputPhone" name="PHONE"
					placeholder="비밀번호를 입력하세요.">
			</div>
			<button type="button" class="btn btn-primary mt-3 col-3 float-left"
				id="cancel">취소</button>
			<button type="submit" class="btn btn-primary mt-3 col-3 float-right"
				id="OK" disabled='disabled'>가입</button>
		</form>
	</div>
	<footer align="center"><p>Copyright ⓒ By MOHW. All Rights Reserved.</p></footer>
</body>

<script>
	var check = 0;
	// 아이디 유효성 검사
	$('#idcheck').click(function idcheck() {
		var user_id = $('#inputId').val();
		if (user_id == "") { //아이디를 입력하지 않고 중복확인시 메시지를 띄우면서 가입버튼은 활성화 안됨
			$("#id_check").text("아이디를 입력해주세요");
			$("#OK").attr("disabled", true);
			$("#id_check").css("color", "red");
			return false;
		}
		$.ajax({
			type : 'POST',
			data : {
				"user_id" : user_id
			},
			datatype : 'json',
			url : "./check/idcheck.jsp",
			success : function(data) {
				if (data == 1) {
					// 1 : 아이디가 중복되는 문구
					$("#id_check").text("사용중인 아이디입니다");
					$("#id_check").css("color", "red");
					$("#OK").attr("disabled", true);
					btn = document.getElementById('OK');
				} else {
					$("#id_check").text("사용가능한 아이디입니다");
					$("#id_check").css("color", "red");
					$("#OK").attr("disabled", false);
					check = 1;
				}
			},
			error : function() {
				alert("수행중에 오류가 발생하였습니다.")
			}
		});
	});

	//아이디 중복확인후 아이디 변경시 이벤트
	$("#inputId").on("propertychange change keyup paste input", function() {
		if (check == 1) {
			$("#OK").attr("disabled", true);
			$("#id_check").text("아이디를 다시 확인해주세요");
			$("#id_check").css("color", "red");
			check = 0;
		}
	});

	//비밀번호 확인

	$("#inputPwd2").keyup(function() {
		if ($("#inputPwd2").val() == $("#inputPwd").val()) {
			$("#pw_check").text("비밀번호가 일치합니다.");
			$("#pw_check").css("color", "red");
		} else {
			$("#pw_check").text("비밀번호가 일치하지않습니다.");
			$("#pw_check").css("color", "red");
		}
	});

	//가입버튼 이벤트
	$('#OK').click(function() {

		if ($('#inputId').val() == "") {
			alert("ID를 입력하세요")
			return false;
		}

		if ($('#inputName').val() == "") {
			alert("이름을 입력하세요")
			return false;
		}

		if ($('#inputId').val() == $('#inputPwd').val()) {
			alert("아이디와 비밀번호가 동일합니다.")
			return false;
		}

		if ($('#inputPwd').val() == "") {
			alert("비밀번호를 입력하세요")
			return false;
		}
		if ($('#inputPwd2').val() == "") {
			alert("비밀번호를 입력하세요")
			return false;
		}
		if ($('#inputPwd').val() != $('#inputPwd2').val()) {
			alert("비밀번호가 일치하지않습니다.")
			return false;
		}
		if ($('#inputPhone').val() == "") {
			alert("전화번호를 입력하세요")
			return false;
		}

	});

	//취소버튼
	$('#cancel').click(function() {
		location.href = "Main.jsp"
	});
</script>


</html>