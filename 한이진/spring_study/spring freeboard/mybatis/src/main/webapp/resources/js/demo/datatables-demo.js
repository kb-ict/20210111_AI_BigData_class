// Call the dataTables jQuery plugin
$(document).ready(function() {
  $('#dataTable').DataTable({//테이블 처리 라이브러리
	  order : [[0,"desc"]]
/*		// 표시 건수기능 숨기기
		lengthChange: true,
		// 검색 기능 숨기기
		searching: true,
		// 정렬 기능 숨기기
		ordering: false,
		// 정보 표시 숨기기
		info: false,
		// 페이징 기능 숨기기
		paging: false*/
		

	});
});
/*		var b ={
a=10,
b=20,
c= function(){},
d= function(){}
};
var c = [];
c.push('aa');*/

/*		doA({a:"bbb",b: "cccc"})
function doA(obj){
alert(obj.a);
if(obj.b == "ccc"){
console.log('aaaaaa');
}
}*/