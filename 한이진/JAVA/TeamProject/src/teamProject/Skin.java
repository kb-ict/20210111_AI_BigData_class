package teamProject;

import javax.swing.ImageIcon;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import java.awt.Image;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.image.BufferedImage;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.text.SimpleDateFormat;
import java.util.Calendar;

import javax.swing.JButton;
import javax.swing.JTextField;

public class Skin extends JFrame 
{
	OrderTable OT = new OrderTable();
	Connection conn = null;
	PreparedStatement pstmt = null;
	ResultSet rs = null;
	
	BufferedImage img = null;
	private JPanel contentPane;
	private JTextField txtmg;
	private JTextField textField_1;
	private JTextField textField_2;
	private JTextField txtmg_1;

	public Skin()
	{
		conn = DBConnec.getConnection();
		SimpleDateFormat format1 = new SimpleDateFormat("yy-MM-dd");
		Calendar time = Calendar.getInstance();
		String format_time1 = format1.format(time.getTime());
		
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setSize(300, 200);
		setLocationRelativeTo(null);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		ImageIcon imgFucidin = new ImageIcon("./src/image/200300546.jpg");
		Image temp1 =  imgFucidin.getImage();
		temp1 = temp1.getScaledInstance(117, 74, java.awt.Image.SCALE_DEFAULT);
		imgFucidin = new ImageIcon(temp1);
		JButton btnFucidin = new JButton(null,imgFucidin);
		btnFucidin.setBounds(6, 6, 117, 74);
		contentPane.add(btnFucidin);

		ImageIcon imgMadecassol = new ImageIcon("./src/image/image/123456.jpg");
		Image temp2 =  imgMadecassol.getImage();
		temp2 = temp2.getScaledInstance(117, 74, java.awt.Image.SCALE_DEFAULT);
		imgMadecassol = new ImageIcon(temp2);
		JButton btnMadecassol = new JButton(null,imgMadecassol);
		btnMadecassol.setBounds(6, 92, 117, 74);
		contentPane.add(btnMadecassol);
		
		txtmg = new JTextField();
		txtmg.setText(" 후시딘");
		txtmg.setBounds(135, 6, 130, 26);
		contentPane.add(txtmg);
		txtmg.setColumns(10);
		
		textField_1 = new JTextField();
		textField_1.setText(" 가격 ₩");
		textField_1.setColumns(10);
		textField_1.setBounds(135, 33, 130, 26);
		contentPane.add(textField_1);
		
		textField_2 = new JTextField();
		textField_2.setText(" 가격 ₩");
		textField_2.setColumns(10);
		textField_2.setBounds(135, 119, 130, 26);
		contentPane.add(textField_2);
		
		txtmg_1 = new JTextField();
		txtmg_1.setText(" 마데카솔");
		txtmg_1.setColumns(10);
		txtmg_1.setBounds(135, 92, 130, 26);
		contentPane.add(txtmg_1);
		
		setVisible(true);
		
		btnFucidin.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				try{

					
					pstmt = conn.prepareStatement("insert into buying values(?,?,?,?,?,?)");
					pstmt.setString(1, OT.tempID);
					pstmt.setString(2, OT.tempName);
					pstmt.setString(3, "200300546");
					pstmt.setString(4, format_time1);
					pstmt.setInt(5, 4500);
					pstmt.setInt(6, 1);
					pstmt.executeUpdate();
					
				}
				catch(Exception exc){
					System.out.println("실패");
				}
				
				JOptionPane.showMessageDialog(null, "주문 완료되었습니다!");
				dispose();
				
			}
		});
		btnMadecassol.addActionListener(new ActionListener() {
					
			@Override
			public void actionPerformed(ActionEvent e) {
				try{

					
					pstmt = conn.prepareStatement("insert into buying values(?,?,?,?,?,?)");
					pstmt.setString(1, OT.tempID);
					pstmt.setString(2, OT.tempName);
					pstmt.setString(3, "199300117");
					pstmt.setString(4, format_time1);
					pstmt.setInt(5, 4500);
					pstmt.setInt(6, 1);
					pstmt.executeUpdate();
					
				}
				catch(Exception exc){
					System.out.println("실패");
				}
				JOptionPane.showMessageDialog(null, "주문 완료되었습니다!");
				dispose();
				
			}
		});
	}
}
