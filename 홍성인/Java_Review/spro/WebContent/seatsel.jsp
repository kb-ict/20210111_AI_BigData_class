<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="EUC-KR">
<title>Insert title here</title>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
<link rel="stylesheet" href="/spro/css/mycss.css"/>
<script type="text/javascript">
	$('document').ready(function(){	
		// css
		/*
		 	1) #id명 : id 선택자
		 	2) .class명 : class 선택자
		 	3) tag명 : tag 선택자
		 	ex)
		 	$('#id명')
		 	$('.class명')
		 	$('h1')
		*/
		$('button').on('click',function(obj){
			$('button').attr('class','btn btn-primary w80');
			//모든 버튼 태그들을 'click'이라는 이벤트를 설정하고 btn btn-primary w80로 바꾼다
			// 빨간색
			$(this).attr('class','btn btn-danger w80');
			//선택한 버튼 태그들의 속성으로 class의 btn btn-danger w80로 바꾼다
			
			//text() 태그 사이에 글자만 가져오기
			//html() 태그 사이에 html 태그 포함해서 글자 가져오기
			//val() input 태크에 있는 value 값 가져오기
		});
		$('#confirm').on('click',function(){
			var seatnum = '';
			$('button').each(function(index,obj){
				if($(this).attr('class')=='btn btn-danger w80'){
					//console.log("$(this).attr('class') = "+$(this).attr('class'));
					//console.log("$(this).text() = "+$(this).text());
					seat = $(this).text();
				}
				})
			// 좌석이 빨간색인거 찾아서 seatsave.jsp 호출
			location.href='seatsave.jsp?seat='+seat;
		})
	})
</script>
</head>
<body>
<div class="jumbotron">
	<h1>MY STUDY</h1>
	<p>공부할려면 좌석선택</p>
	<div class="row text-center">
		<div class="col-sm-2"><button class="btn btn-primary w80">1</button></div>
		<div class="col-sm-2"><button class="btn btn-primary w80">2</button></div>
		<div class="col-sm-2"><button class="btn btn-primary w80">3</button></div>
		<div class="col-sm-2"><button class="btn btn-primary w80">4</button></div>
		<div class="col-sm-2"><button class="btn btn-primary w80">5</button></div>
		<div class="col-sm-2"><button class="btn btn-primary w80">6</button></div>	
	</div>
	<div class="row text-center mt-2">
		<div class="col-sm-2"><button class="btn btn-primary w80">7</button></div>
		<div class="col-sm-8"></div>
		<div class="col-sm-2"><button class="btn btn-primary w80">8</button></div>
	</div>
	<div class="row text-center mt-2">
		<div class="col-sm-2"><button class="btn btn-primary w80">9</button></div>
		<div class="col-sm-1"></div>
		<div class="col-sm-2"><button class="btn btn-primary w80">10</button></div>
		<div class="col-sm-2"><button class="btn btn-primary w80">11</button></div>
		<div class="col-sm-2"><button class="btn btn-primary w80">12</button></div>
		<div class="col-sm-1"></div>
		<div class="col-sm-2"><button class="btn btn-primary w80">13</button></div>
	</div>
	<div class="row text-center mt-2">
		<div class="col-sm-2"><button class="btn btn-primary w80">14</button></div>
		<div class="col-sm-1"></div>
		<div class="col-sm-2"><button class="btn btn-primary w80">15</button></div>
		<div class="col-sm-2"><button class="btn btn-primary w80">16</button></div>
		<div class="col-sm-2"><button class="btn btn-primary w80">17</button></div>
		<div class="col-sm-1"></div>
		<div class="col-sm-2"><button class="btn btn-primary w80">18</button></div>
	</div>
	<div class="row text-center mt-2">
		<div class="col-sm-2"><button class="btn btn-primary w80">19</button></div>
		<div class="col-sm-8"></div>
		<div class="col-sm-2"><button class="btn btn-primary w80">20</button></div>
	</div>
	<div class="row text-center mt-2">
		<div class="col-sm-2"><button class="btn btn-primary w80">21</button></div>
		<div class="col-sm-2"><button class="btn btn-primary w80">22</button></div>
		<div class="col-sm-2"><button class="btn btn-primary w80">23</button></div>
		<div class="col-sm-2"><button class="btn btn-primary w80">24</button></div>
		<div class="col-sm-2"><button class="btn btn-primary w80">25</button></div>
		<div class="col-sm-2"><button class="btn btn-primary w80">26</button></div>	
	</div>
	
	<div class="row text-center mt-2">
		<div class="col-sm-2"></div>
		<div class="col-sm-2"></div>
		<div class="col-sm-2"><input type="button" id="cancel" class="btn btn-warning w80" value="취소"/></div>
		<div class="col-sm-2"><input type="button" id="confirm" class="btn btn-warning w80" value="확인"/></div>
		<div class="col-sm-2"></div>
		<div class="col-sm-2"></div>	
	</div>
</div>
</body>
</html>