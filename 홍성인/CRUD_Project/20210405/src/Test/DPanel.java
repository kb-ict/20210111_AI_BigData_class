package Test;

import javax.swing.JPanel;
import javax.swing.JButton;

public class DPanel extends JPanel {
	public DPanel() {
		setLayout(null);
		
		JButton btnNewButton = new JButton("New button");
		btnNewButton.setBounds(176, 5, 97, 23);
		add(btnNewButton);
		
		JButton btnNewButton_1 = new JButton("New button");
		btnNewButton_1.setBounds(289, 141, 97, 23);
		add(btnNewButton_1);
	}

}
