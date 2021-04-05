package Test;

import javax.swing.JPanel;
import java.awt.CardLayout;
import javax.swing.JButton;

public class CPanel extends JPanel {
	public CPanel() {
		setLayout(null);
		
		JButton btnNewButton = new JButton("New button");
		btnNewButton.setBounds(114, 104, 97, 23);
		add(btnNewButton);
		
		JButton btnNewButton_1 = new JButton("New button");
		btnNewButton_1.setBounds(216, 139, 97, 23);
		add(btnNewButton_1);
		
		JButton btnNewButton_2 = new JButton("New button");
		btnNewButton_2.setBounds(34, 176, 97, 23);
		add(btnNewButton_2);
		
		JButton btnNewButton_3 = new JButton("New button");
		btnNewButton_3.setBounds(341, 267, 97, 23);
		add(btnNewButton_3);
	}

}
