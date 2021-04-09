package Test;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JTextArea;

import java.awt.CardLayout;
import java.awt.Color;

import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JTextPane;
import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;

import message.MyMShow;

import javax.swing.JScrollPane;

//class Mypanel extends JPanel{
//	public String name;
//
//	public Mypanel() {
//		this.name = name;
//	}
//}
public class Main extends JFrame {

	static String[] menu = { "NBB�ñ״�ó��Ʈ", "NBB�������μ�Ʈ", "NBB�����¡��Ʈ", "��Ʈ���ϾƼ�Ʈ", "�ް�����Ʈ��Ʈ", "��ü����Ʈ", "����Ű��缼Ʈ", "�������似Ʈ",
			"�׸���Ұ�⼼Ʈ", "�ڿｽ�μ�Ʈ", "NBB�ñ״�ó", "NBB��������", "NBB�����¡", "��Ʈ���Ͼ�", "�ް�����Ʈ", "��ü��", "����Ű���", "��������", "�׸���Ұ��",
			"�ڿｽ��ġŲ", "��ġŲ�ʰ�", "��Ͼ� ����", "NBBġŲ�ʰ�", "����Ƣ��M", "����Ƣ��L", "������ġ�", "ġŲ����������", "�׸�������", "�������ΰ���ũL",
			"�������ΰ���ũS", "����ݶ�M", "���̴�M", "�̸���(������)M", "��øƽ� (0)M", "�������ֽ�M", "�Ƹ޸�ī��Hot", "�Ƹ޸�ī��Iced" };
	static int[] code = new int[menu.length];

	static int[] price = { 5300, 4700, 6500, 6900, 5900, 5700, 5600, 4700, 3900, 5800, 3500, 2900, 4900, 5300, 4300,
			3800, 3700, 2900, 1900, 3900, 2900, 2500, 2500, 1500, 2000, 2900, 3800, 3300, 15000, 4200, 1500, 1500, 1500,
			1500, 3000, 2000, 2000 };
	static int[] mount = new int[menu.length];

	Select sel = new Select();
	Update up = new Update();
	Save os = new Save();
	JTable table = new JTable();

	public Main() {
		for (int i = 0; i < menu.length; i++) {
			code[i] = i;
		}
		getContentPane().setLayout(null);

		JButton burger = new JButton("����");
		burger.setBounds(750, 0, 134, 97);
		getContentPane().add(burger);

		JButton chicken = new JButton("��Ʈ �޴�");
		chicken.setBounds(750, 97, 134, 103);
		getContentPane().add(chicken);

		JButton side = new JButton("���̵�");
		side.setBounds(750, 196, 134, 97);
		getContentPane().add(side);

		JButton beverage = new JButton("����");
		beverage.setBounds(750, 293, 134, 97);
		getContentPane().add(beverage);

		

		JPanel panel = new JPanel(); // â�߰�
		panel.setBackground(Color.LIGHT_GRAY);
		panel.setBounds(0, 0, 750, 390);
		getContentPane().add(panel);
		panel.setLayout(new CardLayout(0, 0));

		APanel a = new APanel();
		panel.add(a, "1");
		BPanel b = new BPanel();
		panel.add(b, "2");
		CPanel c = new CPanel();
		panel.add(c, "3");
		DPanel d = new DPanel();
		panel.add(d, "4");

		JButton check = new JButton("Ȯ��");
//		check.addActionListener(new ActionListener() {
//			public void actionPerformed(ActionEvent e) {
//				// select.setText("\t��ǰ��\t\t\t����\t\t\t�հ� \n");
//				// if(a.menu != null && a.count !=0){
//				// select.append(a.menu+"/t/t"+a.count+"/t/t
//				// "+(a.price*a.count)+"\n");
//				// }
//				// jtable �߰�
//				// ǥ
////				for(int i = 0; i < menu.length; i++){
////					System.out.println(code[i]);
////				}
//				order.setEnabled(true);
//				DefaultTableModel model = (DefaultTableModel) table.getModel();
//				model.setNumRows(0);
//				String str[] = new String[menu.length];
//				for (int i = 0; i < menu.length; i++) {
//					if (mount[i] != 0)
//						model = (DefaultTableModel) table.getModel();
//					// model.addRow(menu[i]+" "+mount[i]+"
//					// "+(price[i]*mount[i]));
//					str[0] = menu[i];
//					str[1] = "" + price[i];
//					str[2] = "" + mount[i];
//					str[3] = "" + (price[i] * mount[i]);
//					if ( !(str[2].equals("0")) ){//null���� �ƴϸ�
//						model.addRow(str);//���������
//						
//
//					}
//				}
//			}
//
//		});
		check.setBounds(0, 388, 447, 58);
		getContentPane().add(check);

		JButton clear = new JButton("�ʱ�ȭ");
		clear.setBounds(445, 388, 439, 58);
		getContentPane().add(clear);

		JButton btnNewButton_2 = new JButton("����");
		btnNewButton_2.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				sel.select();
			}
		});
		btnNewButton_2.setBounds(329, 827, 97, 23);
		getContentPane().add(btnNewButton_2);

		JButton exit = new JButton("����");
		exit.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				System.exit(0);
			}
		});
		exit.setBounds(491, 827, 97, 23);
		getContentPane().add(exit);

		JButton order = new JButton("�ֹ�");
		order.setEnabled(false);
		order.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {

//				for (int i = 0; i < menu.length; i++) {
//					if (mount[i] != 0) {
//						up.update(mount[i], code[i]);
//					}
//				}
				os.Order();
				
				GetTableString gts = new GetTableString();
				String message = gts.getTableData(table);
				MyMShow.showMe(message);
			}
		});
		order.setBounds(0, 814, 127, 47);
		getContentPane().add(order);
		table.setModel(new DefaultTableModel(new Object[][] { { null, null, null, null }, },
				new String[] { "��ǰ��", "����", "����", "�հ�" }));

		JScrollPane scrollPane = new JScrollPane(table);
		scrollPane.setBounds(0, 441, 884, 376);
		getContentPane().add(scrollPane);
		table.setBounds(0, 0, 0, 0);
		// getContentPane().add(table);

		burger.addActionListener(new ActionListener() {
			@Override
			public void actionPerformed(ActionEvent e) {
				CardLayout cards = (CardLayout) panel.getLayout();
				cards.show(panel, "1");
			}
		});
		chicken.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				CardLayout cards = (CardLayout) panel.getLayout();
				cards.show(panel, "2");
			}
		});
		side.addActionListener(new ActionListener() {
			@Override
			public void actionPerformed(ActionEvent e) {
				CardLayout cards = (CardLayout) panel.getLayout();
				cards.show(panel, "3");
			}
		});
		beverage.addActionListener(new ActionListener() {
			@Override
			public void actionPerformed(ActionEvent e) {
				CardLayout cards = (CardLayout) panel.getLayout();
				cards.show(panel, "4");
			}
		});
		check.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				// select.setText("\t��ǰ��\t\t\t����\t\t\t�հ� \n");
				// if(a.menu != null && a.count !=0){
				// select.append(a.menu+"/t/t"+a.count+"/t/t
				// "+(a.price*a.count)+"\n");
				// }
				// jtable �߰�
				// ǥ
//				for(int i = 0; i < menu.length; i++){
//					System.out.println(code[i]);
//				}
				order.setEnabled(true);
				DefaultTableModel model = (DefaultTableModel) table.getModel();
				model.setNumRows(0);
				String str[] = new String[menu.length];
				for (int i = 0; i < menu.length; i++) {
					if (mount[i] != 0)
						model = (DefaultTableModel) table.getModel();
					// model.addRow(menu[i]+" "+mount[i]+"
					// "+(price[i]*mount[i]));
					str[0] = menu[i];
					str[1] = "" + price[i];
					str[2] = "" + mount[i];
					str[3] = "" + (price[i] * mount[i]);
					if (!(str[2].equals("0"))) {// null���� �ƴϸ�
						model.addRow(str);// ���������

					}
				}
			}

		});

		clear.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				DefaultTableModel model = (DefaultTableModel) table.getModel();
				model.setNumRows(0);
				String str[] = new String[menu.length];
				for (int i = 0; i < menu.length; i++) {
					model = (DefaultTableModel) table.getModel();
					// model.addRow(menu[i]+" "+mount[i]+"
					// "+(price[i]*mount[i]));
					str[i] = null;
				}
				a.Clear();
				b.Clear();
				c.Clear();
				d.Clear();
				order.setEnabled(false);
			}
		});
		
		setVisible(true);
		setSize(900, 900);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

	}

	public static void main(String[] args) {
		new Main();
	}
}
