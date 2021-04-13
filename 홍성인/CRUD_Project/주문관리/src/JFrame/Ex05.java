package JFrame;
import javax.swing.JFrame;
import javax.swing.JPanel;
import java.awt.Color;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import java.awt.CardLayout;
//class Mypanel extends JPanel{
//	public String name;
//	public Mypanel(String name) {
//		this.name = name;
//		this.add(new JButton(name));
//	}
//}
public class Ex05 extends JFrame{
	public Ex05() {
		getContentPane().setLayout(null);
		
		JButton btn1 = new JButton("버거");
		btn1.setBounds(12, 364, 97, 23);
		getContentPane().add(btn1);
		
		JButton btn2 = new JButton("치킨");
		btn2.setBounds(175, 364, 97, 23);
		getContentPane().add(btn2);
		
		JButton btn3 = new JButton("사이드");
		btn3.setBounds(334, 364, 97, 23);
		getContentPane().add(btn3);
		
		JButton btn4 = new JButton("음료");
		btn4.setBounds(514, 364, 97, 23);
		getContentPane().add(btn4);

		JPanel panel = new JPanel();	//창추가
		panel.setBackground(Color.LIGHT_GRAY);
		panel.setBounds(12, 0, 425, 295);
		getContentPane().add(panel);
		panel.setLayout(new CardLayout(0, 0));
		
//		Mypanel mp1 = new Mypanel("1");
//		Mypanel mp2 = new Mypanel("2");
//		panel.add(mp1,"1");
//		panel.add(mp2,"2");
		
		Side mp3 = new Side();
		NNPanel mp4 = new NNPanel();
		panel.add(mp3,"3");
		panel.add(mp4,"4");
		
		Ber cp0 = new Ber();
		setSize(700,400);
		panel.add(cp0,"5");
		
		
		
		
		btn1.addActionListener(new ActionListener() {
			@Override
			public void actionPerformed(ActionEvent e) {
				CardLayout cards =  (CardLayout) panel.getLayout();				
				cards.show(panel, "1");
			}
		});
		btn2.addActionListener(new ActionListener() {
			@Override
			public void actionPerformed(ActionEvent e) {
				CardLayout cards =  (CardLayout) panel.getLayout();				
				cards.show(panel, "2");
			}
		});
		
		btn3.addActionListener(new ActionListener() {
			@Override
			public void actionPerformed(ActionEvent e) {
				CardLayout cards =  (CardLayout) panel.getLayout();				
				cards.show(panel, "3");
			}
		});
		
		btn4.addActionListener(new ActionListener() {
			@Override
			public void actionPerformed(ActionEvent e) {

				CardLayout cards =  (CardLayout) panel.getLayout();				
				cards.show(panel, "5");
			}
		});
		
		setSize(700,900);
		setVisible(true);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}
	public static void main(String[] args) {
		new Ex05();
	}
}

