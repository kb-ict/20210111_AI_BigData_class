package JFrame;
import javax.swing.JPanel;
import javax.swing.JButton;

public class MMPanel2 extends JPanel {
	public MMPanel2() {
		setLayout(null);
		
		JButton btnNewButton = new JButton("New button");
		btnNewButton.setBounds(36, 41, 97, 23);
		add(btnNewButton);
		
		JButton btnNewButton_1 = new JButton("New button");
		btnNewButton_1.setBounds(36, 105, 97, 23);
		add(btnNewButton_1);
		
		JButton btnNewButton_2 = new JButton("New button");
		btnNewButton_2.setBounds(36, 169, 97, 23);
		add(btnNewButton_2);
		
		JButton btnNewButton_3 = new JButton("New button");
		btnNewButton_3.setBounds(36, 233, 97, 23);
		add(btnNewButton_3);
	}

}
