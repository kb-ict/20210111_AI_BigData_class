package Test;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;

import javax.swing.JOptionPane;
import java.awt.event.ActionEvent;

public class Update {
	
	public void update(int mount,int code){
	//a = �ֹ���
	//b = �޴� �ڵ�
		Connection conn = null;
		PreparedStatement pstmt = null;
		// try �����ȿ� �ִ� ������ �����ϴٰ� ������ �߻��ϸ� catch�� ������
		try {
			// ����
			Class.forName("oracle.jdbc.driver.OracleDriver");
			conn = DriverManager.getConnection("jdbc:oracle:thin:@localhost:1521:xe", "AI", "1234");
			System.out.println("DB ���� ����");
			pstmt = conn.prepareStatement(
					"declare "+
					"plus "+ "number(10); "+
					"begin "+
					"plus := "+mount+"; "+
					"update hambuger set "+
					"amount = amount+plus,"+
					"sales = (sales+(price*plus)) "+
					"where code = "+code+";"+
					"end;");
			pstmt.executeUpdate();
			System.out.println("����");
		} catch (Exception e) {
			e.printStackTrace();
			// ���� ���н�
			System.out.println("����");
		} finally {
			try {
				// ���� �� ����
				conn.close();
			} catch (SQLException e) {
				e.printStackTrace();
			}
		}
	}
}
