package oneday.com.org;

import java.io.IOException;

import org.jsoup.Jsoup;
import org.jsoup.nodes.Document;
import org.jsoup.select.Elements;

public class OneDay1 {
	private int number1;
	
	
	public OneDay1() {
		Document doc;
		try {
			doc = Jsoup.connect("http://ncov.mohw.go.kr/").get();
			Elements el = doc.getElementsByAttributeValue("class", "data");
			number1=Integer.parseInt(el.get(0).text());
		} catch (IOException e) {
			e.printStackTrace();
		}		
	}
	public int	getNumber() {
		return number1;
	}
	
//	public void OneDay2() {
//		Document doc;
//		try {
//			doc = Jsoup.connect("http://ncov.mohw.go.kr/").get();
//			Elements el = doc.getElementsByAttributeValue("class", "data");
//			number=Integer.parseInt(el.get(1).text());
//		} catch (IOException e) {
//			e.printStackTrace();
//		}		
//	}
//	public int	getNumber1() {
//		return number;
//	}
//	public static void main(String args[]) throws IOException{
//		Document doc = Jsoup.connect("http://ncov.mohw.go.kr/").get();
//		Elements el = doc.getElementsByAttributeValue("class", "data");
//		System.out.println(el.get(0).text());
//	}
}
