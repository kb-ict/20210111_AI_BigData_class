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

public class Muscle extends JFrame 
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
	private JTextField textField_4;
	private JTextField textField_5;

	public Muscle()
	{
		conn = DBConnec.getConnection();
		SimpleDateFormat format1 = new SimpleDateFormat("yy-MM-dd");
		Calendar time = Calendar.getInstance();
		String format_time1 = format1.format(time.getTime());
		
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setSize(300, 290);
		setLocationRelativeTo(null);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		ImageIcon imgCoolpa = new ImageIcon("./src/image/A04201891.jpg");
		Image temp1 =  imgCoolpa.getImage();
		temp1 = temp1.getScaledInstance(117, 74, java.awt.Image.SCALE_DEFAULT);
		imgCoolpa = new ImageIcon(temp1);
		JButton btnCoolpa = new JButton(null,imgCoolpa);
		btnCoolpa.setBounds(6, 6, 117, 74);
		contentPane.add(btnCoolpa);

		ImageIcon imgArex = new ImageIcon("./src/image/200501321.jpg");
		Image temp2 =  imgArex.getImage();
		temp2 = temp2.getScaledInstance(117, 74, java.awt.Image.SCALE_DEFAULT);
		imgArex = new ImageIcon(temp2);
		JButton btnArex = new JButton(null,imgArex);
		btnArex.setBounds(6, 92, 117, 74);
		contentPane.add(btnArex);
		
		ImageIcon imgAnti = new ImageIcon("./src/image/199800728.jpg");
		Image temp3 =  imgAnti.getImage();
		temp3 = temp3.getScaledInstance(117, 74, java.awt.Image.SCALE_DEFAULT);
		imgAnti = new ImageIcon(temp3);
		JButton btnAnti = new JButton(null,imgAnti);
		btnAnti.setBounds(6, 178, 117, 74);
		contentPane.add(btnAnti);
		
		txtmg = new JTextField();
		txtmg.setText(" 제일 쿨파프");
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
		txtmg_1.setText(" 아렉스");
		txtmg_1.setColumns(10);
		txtmg_1.setBounds(135, 92, 130, 26);
		contentPane.add(txtmg_1);
		
		textField_4 = new JTextField();
		textField_4.setText(" 가격 ₩");
		textField_4.setColumns(10);
		textField_4.setBounds(135, 205, 130, 26);
		contentPane.add(textField_4);
		
		textField_5 = new JTextField();
		textField_5.setText(" 안티푸라민");
		textField_5.setColumns(10);
		textField_5.setBounds(135, 178, 130, 26);
		contentPane.add(textField_5);
		
		setVisible(true);
		
		btnCoolpa.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				try{

					
					pstmt = conn.prepareStatement("insert into buying values(?,?,?,?,?,?)");
					pstmt.setString(1, OT.tempID);
					pstmt.setString(2, OT.tempName);
					pstmt.setString(3, "194201891");
					pstmt.setString(4, format_time1);
					pstmt.setInt(5, 3500);
					pstmt.setInt(6, 1);
					pstmt.executeUpdate();
					
				}
				catch(Exception exc){
					System.out.println("실패");
//					System.out.println(OT.tempID);
//					System.out.println(OT.tempName);
//					System.out.println(format_time1);
//					System.out.println("104201891");


				}
				JOptionPane.showMessageDialog(null, "주문 완료되었습니다!");
				dispose();
				
			}
		});
		btnArex.addActionListener(new ActionListener() {
					
			@Override
			public void actionPerformed(ActionEvent e) {
				try{

					
					pstmt = conn.prepareStatement("insert into buying values(?,?,?,?,?,?)");
					pstmt.setString(1, OT.tempID);
					pstmt.setString(2, OT.tempName);
					pstmt.setString(3, "200501321");
					pstmt.setString(4, format_time1);
					pstmt.setInt(5, 3500);
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
		btnAnti.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				try{

					
					pstmt = conn.prepareStatement("insert into buying values(?,?,?,?,?,?)");
					pstmt.setString(1, OT.tempID);
					pstmt.setString(2, OT.tempName);
					pstmt.setString(3, "199800728");
					pstmt.setString(4, format_time1);
					pstmt.setInt(5, 4000);
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
