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

public class Stomach extends JFrame 
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
	private JTextField textField_6;
	private JTextField textField_7;

	public Stomach()
	{
		conn = DBConnec.getConnection();
		SimpleDateFormat format1 = new SimpleDateFormat("yy-MM-dd");
		Calendar time = Calendar.getInstance();
		String format_time1 = format1.format(time.getTime());
		
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setSize(300, 370);
		setLocationRelativeTo(null);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		ImageIcon imgBearse = new ImageIcon("./src/image/198700405.jpg");
		Image temp1 =  imgBearse.getImage();
		temp1 = temp1.getScaledInstance(117, 74, java.awt.Image.SCALE_DEFAULT);
		imgBearse = new ImageIcon(temp1);
		JButton btnBearse = new JButton(null,imgBearse);
		btnBearse.setBounds(6, 6, 117, 74);
		contentPane.add(btnBearse);

		ImageIcon imgDrBearse = new ImageIcon("./src/image/200300406.jpg");
		Image temp2 =  imgDrBearse.getImage();
		temp2 = temp2.getScaledInstance(117, 74, java.awt.Image.SCALE_DEFAULT);
		imgDrBearse = new ImageIcon(temp2);
		JButton btnDrBearse = new JButton(null,imgDrBearse);
		btnDrBearse.setBounds(6, 92, 117, 74);
		contentPane.add(btnDrBearse);
		
		ImageIcon imgFestalGold = new ImageIcon("./src/image/199900926.jpg");
		Image temp3 =  imgFestalGold.getImage();
		temp3 = temp3.getScaledInstance(117, 74, java.awt.Image.SCALE_DEFAULT);
		imgFestalGold = new ImageIcon(temp3);
		JButton btnFestalGold = new JButton(null,imgFestalGold);
		btnFestalGold.setBounds(6, 178, 117, 74);
		contentPane.add(btnFestalGold);
		
		ImageIcon imgFestalPlus = new ImageIcon("./src/image/199801026.jpg");
		Image temp4 =  imgFestalPlus.getImage();
		temp4 = temp4.getScaledInstance(117, 74, java.awt.Image.SCALE_DEFAULT);
		imgFestalPlus = new ImageIcon(temp4);
		JButton btnFestalPlus = new JButton(null,imgFestalPlus);
		btnFestalPlus.setBounds(6, 264, 117, 74);
		contentPane.add(btnFestalPlus);	
		
		txtmg = new JTextField();
		txtmg.setText(" 베아제");
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
		txtmg_1.setText(" 닥터 베아제");
		txtmg_1.setColumns(10);
		txtmg_1.setBounds(135, 92, 130, 26);
		contentPane.add(txtmg_1);
		
		textField_4 = new JTextField();
		textField_4.setText(" 가격 ₩");
		textField_4.setColumns(10);
		textField_4.setBounds(135, 205, 130, 26);
		contentPane.add(textField_4);
		
		textField_5 = new JTextField();
		textField_5.setText(" 훼스탈 골드");
		textField_5.setColumns(10);
		textField_5.setBounds(135, 178, 130, 26);
		contentPane.add(textField_5);
		
		textField_6 = new JTextField();
		textField_6.setText(" 가격 ₩");
		textField_6.setColumns(10);
		textField_6.setBounds(135, 291, 130, 26);
		contentPane.add(textField_6);
		
		textField_7 = new JTextField();
		textField_7.setText(" 훼스탈 플러스");
		textField_7.setColumns(10);
		textField_7.setBounds(135, 264, 130, 26);
		contentPane.add(textField_7);
		
		setVisible(true);
		
		btnBearse.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				try{

					
					pstmt = conn.prepareStatement("insert into buying values(?,?,?,?,?,?)");
					pstmt.setString(1, OT.tempID);
					pstmt.setString(2, OT.tempName);
					pstmt.setString(3, "198700405");
					pstmt.setString(4, format_time1);
					pstmt.setInt(5, 1800);
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
		btnDrBearse.addActionListener(new ActionListener() {
					
			@Override
			public void actionPerformed(ActionEvent e) {
				try{

					
					pstmt = conn.prepareStatement("insert into buying values(?,?,?,?,?,?)");
					pstmt.setString(1, OT.tempID);
					pstmt.setString(2, OT.tempName);
					pstmt.setString(3, "200300406");
					pstmt.setString(4, format_time1);
					pstmt.setInt(5, 2000);
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
		btnFestalGold.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				try{

					
					pstmt = conn.prepareStatement("insert into buying values(?,?,?,?,?,?)");
					pstmt.setString(1, OT.tempID);
					pstmt.setString(2, OT.tempName);
					pstmt.setString(3, "199900926");
					pstmt.setString(4, format_time1);
					pstmt.setInt(5, 2300);
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
		btnFestalPlus.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				try{

					
					pstmt = conn.prepareStatement("insert into buying values(?,?,?,?,?,?)");
					pstmt.setString(1, OT.tempID);
					pstmt.setString(2, OT.tempName);
					pstmt.setString(3, "199801026");
					pstmt.setString(4, format_time1);
					pstmt.setInt(5, 2100);
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
