package Test;

import javax.swing.JPanel;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import java.awt.Color;
import java.awt.TextField;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JTextField;
import java.awt.Font;
import javax.swing.SwingConstants;
import javax.swing.JLabel;

public class APanel extends JPanel {
	private JTextField textField;
	private JTextField textField_1;
	private JTextField textField_2;
	private JTextField textField_3;
	private JTextField textField_4;
	private JTextField textField_5;
	private JTextField textField_6;
	private JTextField textField_7;
	private JTextField textField_8;
	private JTextField textField_9;
	private JButton plus;
	private JButton plus2;
	private JButton plus3;
	private JButton plus4;
	private JButton plus5;
	private JButton plus6;
	private JButton plus7;
	private JButton plus8;
	private JButton plus9;
	private JButton plus10;
	private JButton min;
	private JButton min2;
	private JButton min3;
	private JButton min4;
	private JButton min5;
	private JButton min6;
	private JButton min7;
	private JButton min8;
	private JButton min9;
	private JButton min10;

	public APanel() {
		setBackground(Color.ORANGE);
		setLayout(null);

		JButton menu1 = new JButton("");
		menu1.setIcon(new ImageIcon("C:\\Users\\KB\\Desktop\\icon insert\\00 10 NBB \uC2DC\uADF8\uB2C8\uCC98.JPG"));
		menu1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				plus.setEnabled(true);
				min.setEnabled(true);
				textField.setText(""+Main.mount[0]);
			}
		});
		menu1.setBounds(40, 60, 100, 100);
		add(menu1);
		
		JButton menu2 = new JButton("");
		menu2.setIcon(new ImageIcon("C:\\Users\\KB\\Desktop\\icon insert\\01 11 NBB \uC624\uB9AC\uC9C0\uB110.JPG"));
		menu2.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				plus2.setEnabled(true);
				min2.setEnabled(true);
				textField_1.setText(""+Main.mount[1]);
			}
		});
		menu2.setBounds(180, 60, 100, 100);
		add(menu2);
		
		JButton menu3 = new JButton("");
		menu3.setIcon(new ImageIcon("C:\\Users\\KB\\Desktop\\icon insert\\02 12 NBB \uC5B4\uBA54\uC774\uC9D5.JPG"));
		menu3.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				plus3.setEnabled(true);
				min3.setEnabled(true);
				textField_2.setText(""+Main.mount[2]);
			}
		});
		menu3.setBounds(320, 60, 100, 100);
		add(menu3);
		
		JButton menu4 = new JButton("");
		menu4.setIcon(new ImageIcon("C:\\Users\\KB\\Desktop\\icon insert\\03 13 \uBBF8\uD2B8\uB9C8\uB2C8\uC544.JPG"));
		menu4.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				plus4.setEnabled(true);
				min4.setEnabled(true);
				textField_3.setText(""+Main.mount[3]);
			}
		});
		menu4.setBounds(460, 60, 100, 100);
		add(menu4);
		
		JButton menu5 = new JButton("");
		menu5.setIcon(new ImageIcon("C:\\Users\\KB\\Desktop\\icon insert\\04 14 \uBA54\uAC00\uBC14\uC774\uD2B8.JPG"));
		menu5.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				plus5.setEnabled(true);
				min5.setEnabled(true);
				textField_4.setText(""+Main.mount[4]);
			}
		});
		menu5.setBounds(600, 60, 100, 100);
		add(menu5);
		
		JButton menu6 = new JButton("");
		menu6.setIcon(new ImageIcon("C:\\Users\\KB\\Desktop\\icon insert\\05 15 \uC0B0\uCCB4\uC2A4.JPG"));
		menu6.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				plus6.setEnabled(true);
				min6.setEnabled(true);
				textField_5.setText(""+Main.mount[5]);
			}
		});
		menu6.setBounds(40, 220, 100, 100);
		add(menu6);
		
		JButton menu7 = new JButton("");
		menu7.setIcon(new ImageIcon("C:\\Users\\KB\\Desktop\\icon insert\\06 16 \uC2A4\uBAA8\uD0A4\uC0B4\uC0AC.JPG"));
		menu7.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				plus7.setEnabled(true);
				min7.setEnabled(true);
				textField_6.setText(""+Main.mount[6]);
			}
		});
		menu7.setBounds(180, 220, 100, 100);
		add(menu7);
		
		JButton menu8 = new JButton("");
		menu8.setIcon(new ImageIcon("C:\\Users\\KB\\Desktop\\icon insert\\07 17 \uB370\uB9AC\uB9C8\uC694.JPG"));
		menu8.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				plus8.setEnabled(true);
				min8.setEnabled(true);
				textField_7.setText(""+Main.mount[7]);
			}
		});
		menu8.setBounds(320, 220, 100, 100);
		add(menu8);
		
		JButton menu9 = new JButton("");
		menu9.setIcon(new ImageIcon("C:\\Users\\KB\\Desktop\\icon insert\\08 18 \uADF8\uB9B4\uB4DC\uBD88\uACE0\uAE30.JPG"));
		menu9.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				plus9.setEnabled(true);
				min9.setEnabled(true);
				textField_8.setText(""+Main.mount[8]);
			}
		});
		menu9.setBounds(460, 220, 100, 100);
		add(menu9);
		
		JButton menu10 = new JButton("");
		menu10.setIcon(new ImageIcon("C:\\Users\\KB\\Desktop\\icon insert\\09 19 \uCF54\uC6B8\uC2AC\uB85C\uCE58\uD0A8.JPG"));
		menu10.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				plus10.setEnabled(true);
				min10.setEnabled(true);
				textField_9.setText(""+Main.mount[9]);
			}
		});
		menu10.setBounds(600, 220, 100, 100);
		add(menu10);
		
		textField = new JTextField();
		textField.setHorizontalAlignment(SwingConstants.CENTER);
		textField.setColumns(10);
		textField.setBounds(65, 160, 50, 20);
		add(textField);
		textField.setColumns(10);
		
		textField_1 = new JTextField();
		textField_1.setHorizontalAlignment(SwingConstants.CENTER);
		textField_1.setColumns(10);
		textField_1.setBounds(205, 160, 50, 20);
		add(textField_1);
		
		textField_2 = new JTextField();
		textField_2.setHorizontalAlignment(SwingConstants.CENTER);
		textField_2.setColumns(10);
		textField_2.setBounds(345, 160, 50, 20);
		add(textField_2);
		
		textField_3 = new JTextField();
		textField_3.setHorizontalAlignment(SwingConstants.CENTER);
		textField_3.setColumns(10);
		textField_3.setBounds(485, 160, 50, 20);
		add(textField_3);
		
		textField_4 = new JTextField();
		textField_4.setHorizontalAlignment(SwingConstants.CENTER);
		textField_4.setColumns(10);
		textField_4.setBounds(625, 160, 50, 20);
		add(textField_4);
		
		textField_5 = new JTextField();
		textField_5.setHorizontalAlignment(SwingConstants.CENTER);
		textField_5.setColumns(10);
		textField_5.setBounds(65, 320, 50, 20);
		add(textField_5);
		
		textField_6 = new JTextField();
		textField_6.setHorizontalAlignment(SwingConstants.CENTER);
		textField_6.setColumns(10);
		textField_6.setBounds(205, 320, 50, 20);
		add(textField_6);
		
		textField_7 = new JTextField();
		textField_7.setHorizontalAlignment(SwingConstants.CENTER);
		textField_7.setColumns(10);
		textField_7.setBounds(345, 320, 50, 20);
		add(textField_7);
		
		textField_8 = new JTextField();
		textField_8.setHorizontalAlignment(SwingConstants.CENTER);
		textField_8.setColumns(10);
		textField_8.setBounds(485, 320, 50, 20);
		add(textField_8);
		
		textField_9 = new JTextField();
		textField_9.setHorizontalAlignment(SwingConstants.CENTER);
		textField_9.setColumns(10);
		textField_9.setBounds(625, 320, 50, 20);
		add(textField_9);
		
		
		
		/// @@@@@@@@@@@@@@@@@ ¤½,¤©·¯½º
		
		
		
		plus = new JButton("");
		plus.setIcon(new ImageIcon("C:\\Users\\KB\\Desktop\\icon insert\\add.JPG"));
		plus.setEnabled(false);
		plus.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Main.mount[0] = Main.mount[0] + 1;
				textField.setText(""+Main.mount[0]);
			}
		});
		plus.setBounds(40, 160, 25, 20);
		add(plus);
		
		plus2 = new JButton("");
		plus2.setIcon(new ImageIcon("C:\\Users\\KB\\Desktop\\icon insert\\add.JPG"));
		plus2.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Main.mount[1] = Main.mount[1] + 1;
				textField_1.setText(""+Main.mount[1]);
			}
		});
		plus2.setBounds(180, 160, 25, 20);
		add(plus2);
		plus2.setEnabled(false);
		
		plus3 = new JButton("");
		plus3.setIcon(new ImageIcon("C:\\Users\\KB\\Desktop\\icon insert\\add.JPG"));
		plus3.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Main.mount[2] = Main.mount[2] + 1;
				textField_2.setText(""+Main.mount[2]);
			}
		});
		plus3.setBounds(320, 160, 25, 20);
		add(plus3);
		plus3.setEnabled(false);
		
		plus4 = new JButton("");
		plus4.setIcon(new ImageIcon("C:\\Users\\KB\\Desktop\\icon insert\\add.JPG"));
		plus4.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Main.mount[3] = Main.mount[3] + 1;
				textField_3.setText(""+Main.mount[3]);
			}
		});
		plus4.setBounds(460, 160, 25, 20);
		add(plus4);
		plus4.setEnabled(false);
		
		plus5 = new JButton("");
		plus5.setIcon(new ImageIcon("C:\\Users\\KB\\Desktop\\icon insert\\add.JPG"));
		plus5.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Main.mount[4] = Main.mount[4] + 1;
				textField_4.setText(""+Main.mount[4]);
			}
		});
		plus5.setBounds(600, 160, 25, 20);
		add(plus5);
		plus5.setEnabled(false);
		
		plus6 = new JButton("");
		plus6.setIcon(new ImageIcon("C:\\Users\\KB\\Desktop\\icon insert\\add.JPG"));
		plus6.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Main.mount[5] = Main.mount[5] + 1;
				textField_5.setText(""+Main.mount[5]);
			}
		});
		plus6.setBounds(40, 320, 25, 20);
		add(plus6);
		plus6.setEnabled(false);
		
		plus7 = new JButton("");
		plus7.setIcon(new ImageIcon("C:\\Users\\KB\\Desktop\\icon insert\\add.JPG"));
		plus7.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Main.mount[6] = Main.mount[6] + 1;
				textField_6.setText(""+Main.mount[6]);
			}
		});
		plus7.setBounds(180, 320, 25, 20);
		add(plus7);
		plus7.setEnabled(false);
		
		plus8 = new JButton("");
		plus8.setIcon(new ImageIcon("C:\\Users\\KB\\Desktop\\icon insert\\add.JPG"));
		plus8.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Main.mount[7] = Main.mount[7] + 1;
				textField_7.setText(""+Main.mount[7]);
			}
		});
		plus8.setBounds(320, 320, 25, 20);
		add(plus8);
		plus8.setEnabled(false);
		
		plus9 = new JButton("");
		plus9.setIcon(new ImageIcon("C:\\Users\\KB\\Desktop\\icon insert\\add.JPG"));
		plus9.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Main.mount[8] = Main.mount[8] + 1;
				textField_8.setText(""+Main.mount[8]);
			}
		});
		plus9.setBounds(460, 320, 25, 20);
		add(plus9);
		plus9.setEnabled(false);
		
		plus10 = new JButton("");
		plus10.setIcon(new ImageIcon("C:\\Users\\KB\\Desktop\\icon insert\\add.JPG"));
		plus10.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Main.mount[9] = Main.mount[9] + 1;
				textField_9.setText(""+Main.mount[9]);
			}
		});
		plus10.setBounds(600, 320, 25, 20);
		add(plus10);
		plus10.setEnabled(false);
		
		
		// @@@@@@@@@@@@@@@@ »©±â•û±â
		
		
		
		min = new JButton("");
		min.setIcon(new ImageIcon("C:\\Users\\KB\\Desktop\\icon insert\\sub.JPG"));
		min.setEnabled(false);
		min.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(Main.mount[0] > 0){
					Main.mount[0] = Main.mount[0] -1;
					textField.setText(""+Main.mount[0]);
					min.setEnabled(true);
				}
				if(Main.mount[0] < 0){
					min.setEnabled(false);
				}
			}
		});
		min.setBounds(115, 160, 25, 20);
		add(min);
		
		min2 = new JButton("");
		min2.setIcon(new ImageIcon("C:\\Users\\KB\\Desktop\\icon insert\\sub.JPG"));
		min2.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(Main.mount[1] > 0){
					Main.mount[1] = Main.mount[1] -1;
					textField_1.setText(""+Main.mount[1]);
					min.setEnabled(true);
				}
				if(Main.mount[1] < 0){
					min.setEnabled(false);
				}
			}
		});
		min2.setBounds(255, 160, 25, 20);
		add(min2);
		min2.setEnabled(false);
		
		min3 = new JButton("");
		min3.setIcon(new ImageIcon("C:\\Users\\KB\\Desktop\\icon insert\\sub.JPG"));
		min3.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(Main.mount[2] > 0){
					Main.mount[2] = Main.mount[2] -1;
					textField_2.setText(""+Main.mount[2]);
					min.setEnabled(true);
				}
				if(Main.mount[2] < 0){
					min.setEnabled(false);
				}
			}
		});
		min3.setBounds(395, 160, 25, 20);
		add(min3);
		min3.setEnabled(false);
		
		min4 = new JButton("");
		min4.setIcon(new ImageIcon("C:\\Users\\KB\\Desktop\\icon insert\\sub.JPG"));
		min4.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(Main.mount[3] > 0){
					Main.mount[3] = Main.mount[3] -1;
					textField_3.setText(""+Main.mount[3]);
					min.setEnabled(true);
				}
				if(Main.mount[3] < 0){
					min.setEnabled(false);
				}
			}
		});
		min4.setEnabled(false);
		min4.setBounds(535, 159, 25, 20);
		add(min4);
		
		min5 = new JButton("");
		min5.setIcon(new ImageIcon("C:\\Users\\KB\\Desktop\\icon insert\\sub.JPG"));
		min5.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(Main.mount[4] > 0){
					Main.mount[4] = Main.mount[4] -1;
					textField_4.setText(""+Main.mount[4]);
					min.setEnabled(true);
				}
				if(Main.mount[4] < 0){
					min.setEnabled(false);
				}
			}
		});
		min5.setBounds(675, 160, 25, 20);
		add(min5);
		min5.setEnabled(false);
		
		min6 = new JButton("");
		min6.setIcon(new ImageIcon("C:\\Users\\KB\\Desktop\\icon insert\\sub.JPG"));
		min6.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(Main.mount[5] > 0){
					Main.mount[5] = Main.mount[5] -1;
					textField_5.setText(""+Main.mount[5]);
					min.setEnabled(true);
				}
				if(Main.mount[5] < 0){
					min.setEnabled(false);
				}
			}
		});
		min6.setBounds(115, 320, 25, 20);
		add(min6);
		min6.setEnabled(false);
		
		min7 = new JButton("");
		min7.setIcon(new ImageIcon("C:\\Users\\KB\\Desktop\\icon insert\\sub.JPG"));
		min7.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(Main.mount[6] > 0){
					Main.mount[6] = Main.mount[6] -1;
					textField_6.setText(""+Main.mount[6]);
					min.setEnabled(true);
				}
				if(Main.mount[6] < 0){
					min.setEnabled(false);
				}
			}
		});
		min7.setBounds(255, 320, 25, 20);
		add(min7);
		min7.setEnabled(false);
		
		min8 = new JButton("");
		min8.setIcon(new ImageIcon("C:\\Users\\KB\\Desktop\\icon insert\\sub.JPG"));
		min8.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(Main.mount[7] > 0){
					Main.mount[7] = Main.mount[7] -1;
					textField_7.setText(""+Main.mount[7]);
					min.setEnabled(true);
				}
				if(Main.mount[7] < 0){
					min.setEnabled(false);
				}
			}
		});
		min8.setBounds(395, 320, 25, 20);
		add(min8);
		min8.setEnabled(false);
		
		min9 = new JButton("");
		min9.setIcon(new ImageIcon("C:\\Users\\KB\\Desktop\\icon insert\\sub.JPG"));
		min9.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(Main.mount[8] > 0){
					Main.mount[8] = Main.mount[8] -1;
					textField_8.setText(""+Main.mount[8]);
					min.setEnabled(true);
				}
				if(Main.mount[8] < 0){
					min.setEnabled(false);
				}
			}
		});
		min9.setBounds(535, 320, 25, 20);
		add(min9);
		min9.setEnabled(false);
		
		min10 = new JButton("");
		min10.setIcon(new ImageIcon("C:\\Users\\KB\\Desktop\\icon insert\\sub.JPG"));
		min10.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(Main.mount[9] > 0){
					Main.mount[9] = Main.mount[9] -1;
					textField_9.setText(""+Main.mount[9]);
					min.setEnabled(true);
				}
				if(Main.mount[9] < 0){
					min.setEnabled(false);
				}
			}
		});
		min10.setBounds(675, 320, 25, 20);
		add(min10);
		min10.setEnabled(false);
		
		JLabel lblN = new JLabel("NBB\uC2DC\uADF8\uB2C8\uCC98\uC138\uD2B8");
		lblN.setFont(new Font("±¼¸²", Font.PLAIN, 11));
		lblN.setBounds(40, 186, 100, 15);
		add(lblN);
		
		JLabel lblNbb_1 = new JLabel("NBB\uC624\uB9AC\uC9C0\uB110\uC138\uD2B8");
		lblNbb_1.setFont(new Font("±¼¸²", Font.PLAIN, 11));
		lblNbb_1.setBounds(180, 186, 100, 15);
		add(lblNbb_1);
		
		JLabel lblNbb = new JLabel("NBB\uC5B4\uBA54\uC774\uC9D5\uC138\uD2B8");
		lblNbb.setFont(new Font("±¼¸²", Font.PLAIN, 11));
		lblNbb.setBounds(320, 186, 100, 15);
		add(lblNbb);
		
		JLabel lblN_3 = new JLabel("  \uBBF8\uD2B8\uB9C8\uB2C8\uC544\uC138\uD2B8");
		lblN_3.setFont(new Font("±¼¸²", Font.PLAIN, 11));
		lblN_3.setBounds(460, 186, 100, 15);
		add(lblN_3);
		
		JLabel lblN_4 = new JLabel("  \uBA54\uAC00\uBC14\uC774\uD2B8\uC138\uD2B8");
		lblN_4.setFont(new Font("±¼¸²", Font.PLAIN, 11));
		lblN_4.setBounds(600, 186, 100, 15);
		add(lblN_4);
		
		JLabel lblN_4_1 = new JLabel("     \uC0B0\uCCB4\uC2A4\uC138\uD2B8");
		lblN_4_1.setFont(new Font("±¼¸²", Font.PLAIN, 11));
		lblN_4_1.setBounds(40, 341, 100, 15);
		add(lblN_4_1);
		
		JLabel lblN_4_2 = new JLabel("  \uC2A4\uBAA8\uD0A4\uC0B4\uC0AC\uC138\uD2B8");
		lblN_4_2.setFont(new Font("±¼¸²", Font.PLAIN, 11));
		lblN_4_2.setBounds(180, 341, 100, 15);
		add(lblN_4_2);
		
		JLabel lblN_4_3 = new JLabel("    \uB370\uB9AC\uB9C8\uC694\uC138\uD2B8");
		lblN_4_3.setFont(new Font("±¼¸²", Font.PLAIN, 11));
		lblN_4_3.setBounds(320, 341, 100, 15);
		add(lblN_4_3);
		
		JLabel lblN_4_4 = new JLabel("\uADF8\uB9B4\uB4DC\uBD88\uACE0\uAE30\uC138\uD2B8");
		lblN_4_4.setFont(new Font("±¼¸²", Font.PLAIN, 11));
		lblN_4_4.setBounds(460, 341, 100, 15);
		add(lblN_4_4);
		
		JLabel lblN_4_5 = new JLabel("    \uCF54\uC6B8\uC2AC\uB85C\uC138\uD2B8");
		lblN_4_5.setFont(new Font("±¼¸²", Font.PLAIN, 11));
		lblN_4_5.setBounds(600, 341, 100, 15);
		add(lblN_4_5);
		
	}
	public void Clear(){
		for(int i = 0; i < 10; i++){
			Main.mount[i] = 0;
		}
		textField.setText(""+Main.mount[0]);
		textField_1.setText(""+Main.mount[1]);
		textField_2.setText(""+Main.mount[2]);
		textField_3.setText(""+Main.mount[3]);
		textField_4.setText(""+Main.mount[4]);
		textField_5.setText(""+Main.mount[5]);
		textField_6.setText(""+Main.mount[6]);
		textField_7.setText(""+Main.mount[7]);
		textField_8.setText(""+Main.mount[8]);
		textField_9.setText(""+Main.mount[9]);
		
		plus.setEnabled(false);
		plus2.setEnabled(false);
		plus3.setEnabled(false);
		plus4.setEnabled(false);
		plus5.setEnabled(false);
		plus6.setEnabled(false);
		plus7.setEnabled(false);
		plus8.setEnabled(false);
		plus9.setEnabled(false);
		plus10.setEnabled(false);
		
		min.setEnabled(false);
		min2.setEnabled(false);
		min3.setEnabled(false);
		min4.setEnabled(false);
		min5.setEnabled(false);
		min6.setEnabled(false);
		min7.setEnabled(false);
		min8.setEnabled(false);
		min9.setEnabled(false);
		min10.setEnabled(false);
	}
}
