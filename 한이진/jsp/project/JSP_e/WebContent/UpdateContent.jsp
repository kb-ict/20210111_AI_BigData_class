<%@page import="jsp.com.org.Posting.PostingUpdate"%>
<%@ page language="java" contentType="text/html; charset=EUC-KR"
    pageEncoding="EUC-KR"%>
<%
PostingUpdate update = new PostingUpdate();
String num = request.getParameter("num");
String content = request.getParameter("content");

update.Update(num,content);
%>

<script>
history.replaceState({}, null, location.pathname); //�Ѱܹ��� �Ķ���͸� ����� ����
alert("�����Ϸ�")
location.href="./Tab/NoticeBoard.jsp"
</script>
