<%@page import="oneday.com.org.Accumulate5"%>
<%@page import="oneday.com.org.Accumulate1"%>
<%@page import="oneday.com.org.Accumulate2"%>
<%@page import="oneday.com.org.Accumulate3"%>
<%@page import="oneday.com.org.Accumulate4"%>
<%@page import="oneday.com.org.Accumulate5"%>
<%@page import="oneday.com.org.Accumulate6"%>
<%@page import="oneday.com.org.Accumulate7"%>
<%@page import="oneday.com.org.Accumulate8"%>
<%@page import="oneday.com.org.OneDay1" %>
<%@page import="oneday.com.org.OneDay2" %>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<script src="https://d3js.org/d3.v6.min.js"></script>
<link rel="stylesheet"
	href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
<script
	src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script
	src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
<script
	src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
<link rel="stylesheet" href="/JSP/css/Style.css" />




<!-- 일일 집계현황 -->
<style type="text/css">
.liveboard_layout {
	position: relative;
	width: 100%;
	height: auto;
	overflow: hidden;
	margin-top: 10px;
}

.liveboard_layout .liveNumOuter {
	position: absolute;
	left: 0;
	top: 0;
	width: 480px;
	z-index: 2
} /* 현황판 */
.liveboard_layout .liveQlinkOuter {
	
} /* 기본정보 퀵배너 */
.liveboard_layout .liveToggleOuter {
	position: relative;
	width: 100%;
} /* 검사현황, 환자동향, 시도별현황 */
.liveToggleOuter>div { /* 여닫음 영역 */
	
}

.liveToggleOuter .live_left {
	float: left;
	width: 500px;
	padding-right: 20px;
}

.liveToggleOuter .live_right {
	float: left;
	width: 680px;
}

.liveboard_layout h2 {
	width: 100%;
	font-size: 18px;
	line-height: 22px;
	font-weight: 600;
	color: #174069;
}

.liveboard_layout h2>a {
	position: relative;
	display: inline-block;
	width: 100%;
}

.liveboard_layout h2>a, .liveboard_layout h2>a:link {
	font-size: 18px;
	line-height: 22px;
	font-weight: 600;
	color: #174069;
}

.liveboard_layout h2>a>.more {
	position: absolute;
	display: inline-block;
	right: 0;
	top: 0;
	font-size: 13px;
	color: #3d4656;
	vertical-align: middle
}

.liveboard_layout h2>a>.more::after {
	content: "＞";
	display: inline-block;
	margin-left: 3px;
	width: 16px;
	height: 16px;
	font-family: 'Spoqa Han Sans';
	font-size: 11px;
	font-weight: 400;
	line-height: 16px;
	color: #fff;
	text-align: center;
	background-color: #a7a7a7;
	border-radius: 100%;
	vertical-align: middle
}

.liveboard_layout .livedate {
	display: inline-block;
	margin-left: 4px;
	font-size: 14px;
	font-weight: 400;
	line-height: 26px;
	vertical-align: middle;
}

.liveboard_layout h3 {
	
}

.liveboard_layout h3>* {
	display: inline-block;
	vertical-align: middle;
}

.liveboard_layout h3>.title {
	padding-right: 16px;
	padding-left: 16px;
	font-size: 15px;
	font-weight: 600;
	letter-spacing: -0.075em;
	line-height: 22px; /* border:1px solid #dcdcdc; border-radius:11px; */
	text-align: center;
}

.liveboard_layout h3>.info {
	margin-left: 4px;
	font-size: 13px;
	color: #174069;
}

@media ( min-width :1180px) {
	/* 20210511변경
	
	.liveboard_layout .liveQlinkOuter {width:237px; position:absolute; right:0; bottom:0; z-index:2}*/
	.liveboard_layout .liveQlinkOuter {
		width: 100%;
		position: relative;
		display: table;
		padding-top: 10px;
		z-index: 2
	}
	.liveToggleOuter .liveopenBtn {
		display: none;
	}
	.liveToggleOuter .live_left {
		float: left;
		padding-top: 200px;
		width: 500px;
		padding-right: 20px;
	}
	.liveToggleOuter .live_right {
		float: left;
		width: 680px;
	}
}

@media ( min-width :768px) and (max-width:1179px) {
	.liveboard_layout .liveNumOuter {
		width: 100%;
	}
	.liveboard_layout .liveQlinkOuter {
		margin-top: 10px;
	}
	.liveToggleOuter .liveopenBtn {
		display: none;
	}
	.liveToggleOuter .live_left {
		float: none;
		padding-top: 200px;
		width: 100%;
		padding-right: 0;
		margin-bottom: 20px;
	}
	.liveToggleOuter .live_right {
		float: none;
		width: 100%;
	}
}

@media ( max-width :767px) {
	/* .liveboard_layout {padding-bottom:210px;} */
	.liveboard_layout .liveNumOuter {
		width: 100%;
	}
	.liveboard_layout .liveQlinkOuter {
		margin-top: 8px;
	}
	.liveToggleOuter {
		padding-top: 188px;
	}
	.liveToggleOuter .live_left>div, .liveToggleOuter .live_right>div {
		margin-top: 5px;
	}
	.liveToggleOuter .live_left {
		float: none;
		width: 100%;
		padding-right: 0;
	}
	.liveToggleOuter .live_right {
		float: none;
		width: 100%;
		margin-top: 20px;
	}
	.liveboard_layout h2 {
		font-size: 16px;
	}
	.liveboard_layout h2>a>.more {
		display: none
	}
	.liveboard_layout h3>.title {
		font-size: 13px;
	}
	.liveboard_layout h3>.info {
		font-size: 12px;
	}
	.liveNumOuter {
		background-color: #0b9bc9 !important;
	}
	.liveNumOuter h2 {
		padding: 10px 0 0 5px;
		color: #fff;
	}
	.liveNumOuter h2>a, .liveNumOuter h2>a:link {
		color: #fff !important;
	}
	.liveNumOuter .liveNum_today {
		border-top: 4px solid #164068;
	}
	.liveNumOuter .liveNum_today_new {
		border-top: 4px solid #164068;
	}
	.liveNumOuter .liveNum {
		margin-top: 0;
		border-top: 2px solid #164068;
	}
}

/* 현황판 모바일 Toggle 버튼*/
.liveToggleOuter .liveopenBtn {
	display: block;
	width: 100%;
	min-height: 36px;
	margin: 5px 0;
	padding: 5px 20px 5px 5px;
	background: url(../image/sub_cmn/faq_arrow_down.png) no-repeat right
		center #fff;
	border: 1px solid #a4c3ef;
	text-align: center;
	background-color: #fff;
	border-radius: 6px;
}

.liveToggleOuter .liveopenBtn>span {
	font-size: 14px;
	font-weight: 600;
	color: #0064af;
}

.liveToggleOuter .main_box_toggle.open {
	position: relative;
	width: 100%;
	height: auto;
	padding: 10px;
	line-height: inherit;
	overflow: inherit;
}

.liveToggleOuter .liveopenBtn.open {
	background: url(../image/sub_cmn/faq_arrow_up.png) no-repeat right
		center;
}

@media ( min-width :1180px) {
	.liveToggleOuter .liveopenBtn {
		display: none;
	}
}

@media ( min-width :768px) and (max-width:1179px) {
	.liveToggleOuter .liveopenBtn {
		display: none;
	}
}

/**********************************************************************************
	현황판_콘텐츠
**********************************************************************************/
/* 환자현황 - 일간*/
.liveNum_today {
	width: 100%;
}

.liveNum_today>li {
	float: left;
	width: 50%;
	height: 34px;
	overflow: hidden;
	background-color: #00c2ff;
	text-align: center;
}

.liveNum_today>li:first-child {
	border-right: 1px solid rgba(255, 255, 255, 0.2);
}

.liveNum_today>li>* {
	display: inline-block;
	font-size: 15px;
	font-weight: 600;
	letter-spacing: -0.05em;
	vertical-align: middle
}

.liveNum_today *[class^="tit"] {
	color: #000;
	line-height: 34px;
}

.liveNum_today *[class^="data"] {
	margin-left: 10px;
	padding-left: 14px;
	padding-right: 14px;
	font-size: 18px;
	font-family: 'Spoqa Han Sans';
	font-weight: 600;
	letter-spacing: 0;
	line-height: 24px; /*  border-radius:12px; */
}

.liveNum_today>li:first-child {
	background-color: #0b9bc9;
}

.liveNum_today>li:nth-child(2) {
	background-color: #53a000;
}

.liveNum_today .tit1 {
	
}

.liveNum_today .tit2 {
	
}

.liveNum_today .data1 {
	color: #fff; /* background-color:#ffcc00;  */
}

.liveNum_today .data2 {
	color: #fff; /* background-color:#70bf00; */
}

.liveNum_today::after {
	content: "";
	display: block;
	clear: both;
}

@media ( max-width :767px) {
	.liveNum_today>li {
		height: 40px;
	}
	.liveNum_today *[class^="tit"] {
		font-size: 14px;
		line-height: 40px
	}
}

/* 환자현황 - 일간_20200629*/
.liveNum_today_new {
	display: table;
	width: 100%;
}

.liveNum_today_new>* {
	display: table-cell;
	vertical-align: middle;
	text-align: center;
}

.liveNum_today_new .tit {
	position: relative;
	font-size: 14px;
	font-weight: 600;
	color: #2c322a;
	background-color: #d7d9d5;
}

.liveNum_today_new .tit::after {
	content: "";
	position: absolute;
	right: -7px;
	top: 50%;
	display: inline-block;
	width: 0px;
	height: 7px;
	margin-top: -7px;
	border-left: 7px solid #d7d9d5;
	border-bottom: 7px solid transparent;
	border-top: 7px solid transparent;
}

.liveNum_today_new .datalist {
	
}

.liveNum_today_new .datalist .subtit {
	display: inline-block;
	margin-right: 7px;
	font-size: 13px;
	line-height: inherit;
	color: #fff;
	vertical-align: middle;
}

.liveNum_today_new .datalist .subtit::before {
	content: "";
	display: inline-block;
	width: 24px;
	height: 20px;
	margin-right: 3px;
	vertical-align: middle;
}

.liveNum_today_new .datalist .data {
	display: inline-block;
	font-size: 19px;
	font-family: 'Spoqa Han Sans';
	font-weight: 600;
	letter-spacing: 0;
	color: #ffd43e;
	vertical-align: inherit;
} /*vertical-align:inherit;*/
.liveNum_today_new .datalist>ul {
	display: table;
	width: 100%;
	height: 100%;
}

.liveNum_today_new .datalist>ul>li {
	display: table-cell;
	width: 50%;
	background-color: #288000;
	vertical-align: middle
}

.liveNum_today_new .datalist>ul>li:nth-child(1) {
	border-right: 1px solid #539933;
}

.liveNum_today_new .datalist>ul>li:nth-child(1) .subtit::before {
	background: url(../image/main/ico_case1.png) no-repeat 0 0;
}

.liveNum_today_new .datalist>ul>li:nth-child(2) .subtit::before {
	background: url(../image/main/ico_case2.png) no-repeat 0 0;
}

@media ( min-width :1180px) {
	.liveNum_today_new {
		margin-top: 8px;
		height: 42px;
	}
	.liveNum_today_new .tit {
		width: 30%;
		line-height: 42px;
	}
	.liveNum_today_new .datalist {
		width: 70%;
		height: 42px;
		line-height: 42px;
	}
}

@media ( min-width :768px) and (max-width:1179px) {
	.liveNum_today_new {
		margin-top: 8px;
		height: 42px;
	}
	.liveNum_today_new .tit {
		width: 30%;
		line-height: 42px;
	}
	.liveNum_today_new .datalist {
		width: 70%;
	}
}

@media ( max-width :767px) {
	.liveNum_today_new {
		height: 35px;
	}
	.liveNum_today_new .tit {
		width: 30%;
		font-size: 13px;
		line-height: 35px;
	}
	.liveNum_today_new .datalist {
		width: 70%;
	}
	.liveNum_today_new .datalist .subtit {
		font-size: 12px;
		line-height: 35px;
		vertical-align: middle
	}
	.liveNum_today_new .datalist .data {
		font-size: 16px;
		line-height: 40px;
		vertical-align: middle
	}
	.liveNum_today_new .datalist .subtit::before {
		display: none
	}
}

/* 환자현황 - 누적*/
.liveNum {
	position: relative;
	display: table;
	width: 100%;
	margin-top: 2px;
}

.liveNum>li {
	position: relative;
	display: table-cell;
	text-align: center;
	z-index: 1
}

.liveNum>li:nth-child(1) {
	background-color: #0099ff;
}

.liveNum>li:nth-child(2) {
	background-color: #006699;
}

.liveNum>li:nth-child(3) {
	position: relative;
	background-color: #174069;
}

.liveNum>li:nth-child(4) {
	background-color: #808080;
}

.liveNum>li>* {
	display: block;
	color: #fff;
}

.liveNum>li>.tit {
	font-size: 16px;
	line-height: 22px;
	font-weight: 600
}

.liveNum>li>.num {
	font-family: 'Spoqa Han Sans';
	font-weight: 400;
	font-size: 30px;
	line-height: 1.25em;
}

.liveNum>li>.before {
	font-family: 'Spoqa Han Sans';
	font-weight: 400;
	font-size: 13px;
	line-height: 1.5em;
	letter-spacing: 0.025em
}

.liveNum .sign {
	position: absolute;
	left: -12px;
	top: 50%;
	margin-top: -12px;
	width: 24px;
	height: 24px;
	font-size: 16px;
	line-height: 22px;
	font-weight: 600;
	color: #000;
	background-color: #fff;
	border-radius: 100%;
	text-align: center;
	z-index: 2
}

.liveNum .mini {
	display: inline-block; /* margin-left:4px; */
	font-family: 'Noto Sans KR';
	font-size: 14px;
	line-height: 26px;
	vertical-align: middle
}

.liveNum .mini_tit {
	display: inline-block;
	font-family: 'Noto Sans KR';
	font-size: 15px;
	line-height: 12px;
	font-weight: 400;
	vertical-align: top
}

.liveNum .help {
	position: absolute;
	right: 15px;
	top: 15px;
	display: block;
	width: 16px;
	height: 16px;
	font-size: 12px;
	line-height: 14px;
	color: #fff;
	border: 1px solid #fff;
	border-radius: 100%;
	z-index: 2
}

.liveNum .help_info {
	position: absolute;
	left: 50%;
	top: 32px;
	display: none;
	margin-left: -70px;
	padding: 5px;
	width: 200px;
	height: auto;
	border: 1px solid #2db7cb;
	background-color: #fff;
	border-radius: 6px;
	overflow: hidden;
	z-index: 3
}

.liveNum .help_info .script_info {
	text-align: center;
	font-size: 13px;
	line-height: 16px;
	color: #005e6c;
	word-break: keep-all
}

@media ( min-width :1180px) {
	.liveNum>li {
		padding: 10px 6px 12px 6px;
	}
	.liveNum>li:nth-child(1) {
		width: 30%;
		padding-left: 0;
		padding-right: 4px;
	}
	.liveNum>li:nth-child(2) {
		width: 24%;
	}
	.liveNum>li:nth-child(3) {
		width: 25%;
	}
	.liveNum>li:nth-child(4) {
		width: 21%;
	}
	.liveNum>li>.num {
		letter-spacing: -0.05em
	}
	.liveNum>li>.tit {
		padding-left: 4px;
		height: 33px;
		vertical-align: top;
	}
}

@media ( min-width :768px) and (max-width:1179px) {
	.liveNum>li {
		padding: 10px 6px 12px 6px;
	}
	.liveNum>li:nth-child(1) {
		width: 30%;
	}
	.liveNum>li:nth-child(2) {
		width: 24%;
	}
	.liveNum>li:nth-child(3) {
		width: 25%;
	}
	.liveNum>li:nth-child(4) {
		width: 21%;
	}
	.liveNum>li>.tit {
		height: 33px;
		vertical-align: top;
	}
}

@media ( max-width :767px) {
	.liveNum>li:nth-child(1) {
		width: 30%;
	}
	.liveNum>li:nth-child(2) {
		width: 24%;
	}
	.liveNum>li:nth-child(3) {
		width: 25%;
	}
	.liveNum>li:nth-child(4) {
		width: 21%;
	}
	.liveNum>li {
		vertical-align: top;
		padding-top: 10px;
		padding-bottom: 12px;
	}
	.liveNum>li>.tit {
		font-size: 14px;
		line-height: 18px;
		height: 30px;
		vertical-align: top
	}
	.liveNum>li>.num {
		font-size: 18px;
		height: 22px;
	}
	.liveNum>li>.before {
		font-size: 12px;
	}
	.liveNum .sign {
		left: -9px;
		width: 18px;
		height: 18px;
		line-height: 16px;
		font-size: 12px;
	}
	.liveNum .mini {
		font-size: 11px;
	}
	.liveNum .mini_tit {
		font-size: 12px;
		line-height: 14px;
	}
	.liveNum .help {
		right: 2px;
		top: 5px;
	}
}
</style>



</head>
<body>

	
	<div class="liveNumOuter">
		<h3 class="hdn">일일 집계현황</h3>
		<div class="liveNum_today_new">
			<strong class="tit">일일확진자</strong>
			<div class="datalist">
				<ul>
					<li><span class="subtit">국내발생</span>
					<span class="data">
					<%OneDay1 od1 = new OneDay1();%>
<%-- 					<%OneDay1 od1 = new OneDay1();%> --%>
					<%= od1.getNumber() %>
					</li>
					<li><span class="subtit">해외유입</span>
					<span class="data">
					<%OneDay2 od2 = new OneDay2(); %>
					<%= od2.getNumber2() %>
					</span>
					</li>
				</ul>
			</div>
		</div>
		<div class="liveNum">
			<h3 class="hdn">실시간 집계현황</h3>
			<ul class="liveNum">
				<li><strong class="tit">확진환자</strong> 
				<span class="num">
				<span class="mini">(누적)</span>
				<%Accumulate1 ac1= new Accumulate1();%>
				<%=ac1.getNumber() %></span>
				<span class="before">전일대비 
				<%Accumulate5 ac5= new Accumulate5();%>
				<%=ac5.getNumber() %>
				</span></li>
				<li><em class="sign">=</em> <strong class="tit">격리해제</strong> <span
					class="num"><%Accumulate2 ac2= new Accumulate2();%>
				<%=ac2.getNumber() %></span> <span class="before">
				<%Accumulate6 ac6= new Accumulate6();%>
				<%=ac6.getNumber() %>
				</span></li>
				<li><em class="sign">+</em> <strong class="tit">치료 중<br>
					<span class="mini_tit">(격리 중)</span></strong> <span class="num">
					<%Accumulate3 ac3= new Accumulate3();%>
				<%=ac3.getNumber() %></span>
					<span class="before">
					<%Accumulate7 ac7= new Accumulate7();%>
				<%=ac7.getNumber() %>
				</span> </li>
				<li><em class="sign">+</em> <strong class="tit">사망</strong> <span
					class="num">
					<%Accumulate4 ac4= new Accumulate4();%>
				<%=ac4.getNumber() %>
				</span> <span class="before">
				<%Accumulate8 ac8= new Accumulate8();%>
				<%=ac8.getNumber() %>
				</span></li>
			</ul>
			
		</div>
	</div>
	
</body>
</html>