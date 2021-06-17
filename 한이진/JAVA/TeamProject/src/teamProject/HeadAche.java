package teamProject;

import java.awt.Image;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.image.BufferedImage;
import java.sql.Connection;
import java.sql.Date;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.text.SimpleDateFormat;
import java.util.Calendar;

import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.border.EmptyBorder;

public class HeadAche extends JFrame
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
	private JTextField textField_8;
	private JTextField textField_9;

	public HeadAche()
	{
		conn = DBConnec.getConnection();
		SimpleDateFormat format1 = new SimpleDateFormat("yy-MM-dd");
		Calendar time = Calendar.getInstance();
		String format_time1 = format1.format(time.getTime());
		
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setSize(300, 460);
		setLocationRelativeTo(null);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		ImageIcon imgTylenol500 = new ImageIcon("./src/image/199303108.jpg");	
		Image temp1 =  imgTylenol500.getImage();
		temp1 = temp1.getScaledInstance(117, 74, java.awt.Image.SCALE_DEFAULT);
		imgTylenol500 = new ImageIcon(temp1);
		JButton btnTylenol500 = new JButton(imgTylenol500);
		btnTylenol500.setBounds(6, 6, 117, 74);
		contentPane.add(btnTylenol500);

		ImageIcon imgTylenol160 = new ImageIcon("./src/image/199402278.jpg");
		Image temp2 =  imgTylenol160.getImage();
		temp2 = temp2.getScaledInstance(117, 74, java.awt.Image.SCALE_DEFAULT);
		imgTylenol160 = new ImageIcon(temp2);
		JButton btnTylenol160 = new JButton(null,imgTylenol160);
		btnTylenol160.setBounds(6, 92, 117, 74);
		contentPane.add(btnTylenol160);
		
		ImageIcon imgTylenolKid = new ImageIcon("./src/image/199303109.jpg");
		Image temp3 =  imgTylenolKid.getImage();
		temp3 = temp3.getScaledInstance(117, 74, java.awt.Image.SCALE_DEFAULT);
		imgTylenolKid = new ImageIcon(temp3);
		JButton btnTylenolKid = new JButton(null,imgTylenolKid);
		btnTylenolKid.setBounds(6, 178, 117, 74);
		contentPane.add(btnTylenolKid);
		
		ImageIcon imgTylenolKidLiquid = new ImageIcon("./src/image/199603002.jpg");
		Image temp4 =  imgTylenolKidLiquid.getImage();
		temp4 = temp4.getScaledInstance(117, 74, java.awt.Image.SCALE_DEFAULT);
		imgTylenolKidLiquid = new ImageIcon(temp4);
		JButton btnTylenolKidLiquid = new JButton(null,imgTylenolKidLiquid);
		btnTylenolKidLiquid.setBounds(6, 264, 117, 74);
		contentPane.add(btnTylenolKidLiquid);
		
		ImageIcon imgBrufen = new ImageIcon("D:/bjy_git/java_work21/workspace/teamProject/src/image/198601920.jpg");
		Image temp5 =  imgBrufen.getImage();
		temp5 = temp5.getScaledInstance(117, 74, java.awt.Image.SCALE_DEFAULT);
		imgBrufen = new ImageIcon(temp5);
		JButton btnBrufen = new JButton(null,imgBrufen);
		btnBrufen.setBounds(6, 350, 117, 74);
		contentPane.add(btnBrufen);
		
		txtmg = new JTextField();
		txtmg.setText(" 타이레놀 500mg");
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
		txtmg_1.setText(" 타이레놀 160mg");
		txtmg_1.setColumns(10);
		txtmg_1.setBounds(135, 92, 130, 26);
		contentPane.add(txtmg_1);
		
		textField_4 = new JTextField();
		textField_4.setText(" 가격 ₩");
		textField_4.setColumns(10);
		textField_4.setBounds(135, 205, 130, 26);
		contentPane.add(textField_4);
		
		textField_5 = new JTextField();
		textField_5.setText(" 어린이용 타이레놀");
		textField_5.setColumns(10);
		textField_5.setBounds(135, 178, 130, 26);
		contentPane.add(textField_5);
		
		textField_6 = new JTextField();
		textField_6.setText(" 가격 ₩");
		textField_6.setColumns(10);
		textField_6.setBounds(135, 291, 130, 26);
		contentPane.add(textField_6);
		
		textField_7 = new JTextField();
		textField_7.setText(" 타이레놀 현탁액");
		textField_7.setColumns(10);
		textField_7.setBounds(135, 264, 130, 26);
		contentPane.add(textField_7);
		
		textField_8 = new JTextField();
		textField_8.setText(" 가격 ₩");
		textField_8.setColumns(10);
		textField_8.setBounds(135, 377, 130, 26);
		contentPane.add(textField_8);
		
		textField_9 = new JTextField();
		textField_9.setText(" 부루펜");
		textField_9.setColumns(10);
		textField_9.setBounds(135, 350, 130, 26);
		contentPane.add(textField_9);
		
		setVisible(true);
		
		btnTylenol500.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				
				try{

					
					pstmt = conn.prepareStatement("insert into buying values(?,?,?,?,?,?)");
					pstmt.setString(1, OT.tempID);
					pstmt.setString(2, OT.tempName);
					pstmt.setString(3, "199303108");
					pstmt.setString(4, format_time1);
					pstmt.setInt(5, 3100);
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
		btnTylenol160.addActionListener(new ActionListener() {
					
			@Override
			public void actionPerformed(ActionEvent e) {
				
				try{

					
					pstmt = conn.prepareStatement("insert into buying values(?,?,?,?,?,?)");
					pstmt.setString(1, OT.tempID);
					pstmt.setString(2, OT.tempName);
					pstmt.setString(3, "199402278");
					pstmt.setString(4, format_time1);
					pstmt.setInt(5, 2500);
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
		btnTylenolKid.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				
				try{

					
					pstmt = conn.prepareStatement("insert into buying values(?,?,?,?,?,?)");
					pstmt.setString(1, OT.tempID);
					pstmt.setString(2, OT.tempName);
					pstmt.setString(3, "199603002");
					pstmt.setString(4, format_time1);
					pstmt.setInt(5, 6750);
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
		
		btnTylenolKidLiquid.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				try{

					
					pstmt = conn.prepareStatement("insert into buying values(?,?,?,?,?,?)");
					pstmt.setString(1, OT.tempID);
					pstmt.setString(2, OT.tempName);
					pstmt.setString(3, "199603002");
					pstmt.setString(4, format_time1);
					pstmt.setInt(5, 6750);
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
		btnBrufen.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				try{

					
					pstmt = conn.prepareStatement("insert into buying values(?,?,?,?,?,?)");
					pstmt.setString(1, OT.tempID);
					pstmt.setString(2, OT.tempName);
					pstmt.setString(3, "198601920");
					pstmt.setString(4, format_time1);
					pstmt.setInt(5, 7500);
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

