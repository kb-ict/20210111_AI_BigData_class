package Test;


import java.io.*;
import java.text.SimpleDateFormat;
import java.util.Calendar;
 // �Ϸ���� ����
public class Order_save{
  public void Order(){
    try{
    	
  	  	SimpleDateFormat format1 = new SimpleDateFormat( "yy-MM-dd HH�� mm�� ss��");
  	  	SimpleDateFormat format2 = new SimpleDateFormat( "yy-MM-dd");
  	  	Calendar time = Calendar.getInstance();
  	  	String format_time1 = format1.format(time.getTime());
  	  	String format_time2 = format2.format(time.getTime());
  	  	
//  	String path = "D:\\java\\"+format2+""; //���� ���
  		File Folder = new File("C:\\Users\\donqu\\OneDrive\\���� ȭ��\\������\\"+format_time2);
  		System.out.println("C:\\Users\\donqu\\OneDrive\\���� ȭ��\\������\\"+format_time2+"");
  		// �ش� ���丮�� ������� ���丮�� �����մϴ�.
  		if (!Folder.exists()) {
  			try{
  			    Folder.mkdir(); //���� �����մϴ�.
  			    System.out.println("������ �����Ǿ����ϴ�.");
  		        } 
  		        catch(Exception e){
  			    e.getStackTrace();
  			}        
  	         }else {
  			System.out.println("�̹� ������ �����Ǿ� �ֽ��ϴ�.");
  		}
  	  	
    	FileWriter fw = new FileWriter("C:\\Users\\donqu\\OneDrive\\���� ȭ��\\������\\"+format_time2+"\\"+format_time1+".txt"); // �����ּ� ��� ����
    	BufferedWriter bw = new BufferedWriter(fw);
    	int hapap = 0;
  		
    	bw.write((format_time1+"\t\t\t")+("�ֹ���"));
    	bw.newLine(); // �ٹٲ�
    	bw.write("=====================================");
      	bw.newLine();
      	bw.write(String.format("%10s %20s %20s","�޴�","����","�հ�"));
      	bw.newLine();
      for(int i = 0; i < 2; i++){
    	  if(Main.mount[i] != 0){
    		  bw.write(String.format("%10s %20d %20d",Main.menu[i],Main.mount[i],Main.mount[i]*Main.price[i]));
    		  bw.newLine();
    		  hapap = hapap+(Main.mount[i]*Main.price[i]);
    	  }
      }
      	bw.write("=====================================");
      	bw.newLine();
      	bw.write("\t\t\t\t�� ���� : "+hapap);
      	bw.close();
    }
    catch (IOException e)
    {
      System.err.println(e); // ������ �ִٸ� �޽��� ���
    }
  }
}
