package Test;

import javax.swing.JPanel;
import javax.swing.JButton;
import java.awt.Color;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.SwingConstants;
import java.awt.Font;

public class APanel extends JPanel {
	int count = 0;
	String menu;
	int price;
	private JTextField Bul_Field;
	private JTextField Chi_Field;
	public APanel() {
		setBackground(new Color(255, 215, 0));
		setLayout(null);
		
		
		
		// @@@@@@@@@@@@@@@@@@@@ 불고기 버거
		JButton bul = new JButton("불고기 버거");
		bul.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Main.mount[0] = 0;
				Main.menu[0] = "불고기버거";
				Main.price[0] = 3000;
			}
		});
		bul.setBounds(15, 10, 128, 90);
		add(bul);
		setSize(900, 380);
		//- 버튼
		JButton bul_minus = new JButton("-");
		bul_minus.setFont(new Font("Adobe Song Std L", Font.PLAIN, 14));
		bul_minus.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(Main.mount[0] > 0){
					Main.mount[0] = Main.mount[0] -1;
					getTextField().setText(Main.mount[0]+"");
					System.out.println(Main.mount[0]);
					bul_minus.setEnabled(true);
				}
				if(Main.mount[0] < 0){
					bul_minus.setEnabled(false);
				}
			}
		});
		bul_minus.setBounds(15, 124, 41, 23);
		add(bul_minus);
		// + 버튼
		JButton bul_plus = new JButton("+");
		bul_plus.setFont(new Font("굵은안상수체", Font.PLAIN, 14));
		bul_plus.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Main.mount[0] = Main.mount[0] + 1;
				getTextField().setText(Main.mount[0]+"");
			}
		});
		bul_plus.setBounds(102, 124, 41, 23);
		add(bul_plus);
		
		
		setTextField(new JTextField());
		getTextField().setText(""+Main.mount[0]);
		getTextField().setBounds(55, 123, 46, 23);
		add(getTextField());
		getTextField().setColumns(10);
		
		
		
		// @@@@@@@@@@@@@@@@@@@@ 치킨버거
		JButton chi = new JButton("치킨 버거");
		chi.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Main.mount[1] = 0;
				Main.menu[1] = "치킨 버거";
				Main.price[1] = 4000;
			}
		});
		chi.setBounds(184, 10, 111, 90);
		add(chi);
		// - 버튼
		JButton chi_minus = new JButton("-");
		chi_minus.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if(Main.mount[1] > 0){
					Main.mount[1] = Main.mount[1] -1;
					getTextField1().setText(Main.mount[1]+"");
					System.out.println(Main.mount[1]);
					chi_minus.setEnabled(true);
				}
				if(Main.mount[1] < 0){
					chi_minus.setEnabled(false);
				}
			
			}
		});
		chi_minus.setBounds(177, 122, 24, 23);
		add(chi_minus);
		// +버튼
		JButton chi_plus = new JButton("+");
		chi_plus.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Main.mount[1] = Main.mount[1] + 1;
				getTextField1().setText(Main.mount[1]+"");
			}
		});
		chi_plus.setBounds(271, 122, 24, 23);
		add(chi_plus);
		
		Chi_Field = new JTextField();
		Chi_Field.setText(""+Main.mount[1]);
		Chi_Field.setColumns(10);
		Chi_Field.setBounds(213, 122, 46, 23);
		add(Chi_Field);
		
		JLabel lblNewLabel = new JLabel("     \uBD88\uACE0\uAE30 \uBC84\uAC70");
		lblNewLabel.setBounds(15, 99, 111, 23);
		add(lblNewLabel);
		
	}
	//@@@@@ 불고기 버거
	public JTextField getTextField() {
		return Bul_Field;
	}
	public void setTextField(JTextField textField) {
		this.Bul_Field = textField;
	}
	//@@@@@ 치킨버거 chi_
	public JTextField getTextField1() {
		return Chi_Field;
	}
	public void setTextField2(JTextField txtddffgg) {
		this.Chi_Field = txtddffgg;
	}
}
