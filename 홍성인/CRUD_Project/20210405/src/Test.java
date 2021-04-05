import java.io.FileOutputStream;
import java.io.IOException;
import java.io.OutputStream;



public class Test {
	public static void main(String args[])throws IOException {
//		OutputStream os = new FileOutputStream("src/d.txt");			
//		String test = "æ»≥Á«œººø‰§ª§ª";
//		byte[] atest_byte = test.getBytes();
//		os.write(atest_byte);
//		os.close();

		Update up = new Update();
		Select sel = new Select();
		sel.select();
		up.update(10, 12);
//		up.update(-4,1);
//		byte[] atest_byte = test.getBytes();
//		String a = sel.select();
	}
}
