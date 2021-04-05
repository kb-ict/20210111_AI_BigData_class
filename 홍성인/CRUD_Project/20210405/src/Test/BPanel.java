package Test;

import javax.swing.JPanel;
import javax.swing.JButton;

public class BPanel extends JPanel {
	public BPanel() {
		setLayout(null);
		
		JButton btnNewButton = new JButton("New button");
		btnNewButton.setBounds(121, 108, 97, 23);
		add(btnNewButton);
		
		JButton btnNewButton_1 = new JButton("New button");
		btnNewButton_1.setBounds(229, 168, 97, 23);
		add(btnNewButton_1);
		
		JButton btnNewButton_2 = new JButton("New button");
		btnNewButton_2.setBounds(88, 168, 97, 23);
		add(btnNewButton_2);
		
		JButton btnNewButton_3 = new JButton("New button");
		btnNewButton_3.setBounds(286, 47, 97, 23);
		add(btnNewButton_3);
	}

}
