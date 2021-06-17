package teamProject;

import java.sql.Connection;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JTable;

public class CustomerSelectGui extends JFrame
{
	private JPanel contentPane;
	private JTable table;

	public CustomerSelectGui() {
		getContentPane().setLayout(null);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setLocationRelativeTo(null);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		table = new JTable();
		DBSelectcustomerlist dsc = new DBSelectcustomerlist();
		Connection conn = null;
		table.setBounds(0, 470, 384, -467);
		contentPane.add(table);
		setSize(400,500);
		setVisible(true);
		
	}
}
