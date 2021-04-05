package Test;

import javax.swing.JButton;
import javax.swing.JPanel;

public class EPanel extends JPanel {
	public EPanel() {
		setLayout(null);
		
		JButton btnNewButton = new JButton("New button");
		btnNewButton.setBounds(176, 5, 97, 23);
		add(btnNewButton);
		
		JButton btnNewButton_1 = new JButton("New button");
		btnNewButton_1.setBounds(289, 141, 97, 23);
		add(btnNewButton_1);
	}
}
