<%@page import="jsp.com.org.Posting.PostingDelete"%>
<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>

<%PostingDelete del = new PostingDelete();
String num = request.getParameter("num");
del.delete(num);%>

<script>
alert("�����Ϸ�Ǿ����ϴ�.")
location.href="./Tab/NoticeBoard.jsp"
</script>