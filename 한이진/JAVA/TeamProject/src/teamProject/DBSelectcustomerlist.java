package teamProject;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.table.DefaultTableModel;
import javax.swing.JTable;


import teamProject.DBConnec;
//import teamProject.DBCustomertable.CUSTOMER;
//class GUI extends JFrame
//{
//	
//}

class DBCUSTOMER {
   private int id;
   private String name;
   private String gender;
   private int birthyear;
   private String address;
   private String phone;
   // 1 setter...
   // 2 생성자로...
   public DBCUSTOMER(int id, String name, String gender, int birthyear, String address, String phone){
      this.id = id;
      this.name = name;
      this.gender = gender;
      this.birthyear = birthyear;
      this.address = address;
      this.phone = phone;
   }
   public void print() {
      System.out.println(""+id + name);
   }
}
public class DBSelectcustomerlist extends JFrame{
	private JPanel contentPane;
	public static JTable table;

	public DBSelectcustomerlist() {
		getContentPane().setLayout(null);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setLocationRelativeTo(null);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		table = new JTable();
		db();
		table.setBounds(0, 470, 384, -467);
		contentPane.add(table);
		setSize(400,500);
		setVisible(true);
		
	}

   
   public static void db() {
      Connection conn = null;
        PreparedStatement pstm = null; 
        ResultSet rs = null; 
      try {   
         int count =0;
         DBCUSTOMER[] cus = new DBCUSTOMER[1000];
         conn = DBConnec.getConnection();
          String quary = "SELECT * FROM customer";
               
            pstm = conn.prepareStatement(quary);
            rs = pstm.executeQuery();
         String str[] = new String[6];
            int temp =0;
            while (rs.next()) {
              
//              cus[temp] = new DBCUSTOMER(rs.getInt("ID"),rs.getString("NAME"),rs.getString("GENDER"),rs.getInt("BIRTHYEAR"), rs.getString("ADDRESS"),rs.getString("PHONE"));
//            	str[0]=""+rs.getInt("ID");
//            	str[1]=rs.getString("NAME");
//            	str[2]=rs.getString("GENDER");
//            	str[3]=""+rs.getInt("BIRTHYEAR");
//            	str[4]=rs.getString("ADDRESS");
//            	str[5]=rs.getString("PHONE");
//  
               cus[temp].print();
               DefaultTableModel model = (DefaultTableModel) table.getModel();
               model.setNumRows(0);
               
               cus[temp] = new DBCUSTOMER(rs.getInt("ID"),rs.getString("NAME"),rs.getString("GENDER"),rs.getInt("BIRTHYEAR"), rs.getString("ADDRESS"),rs.getString("PHONE"));
               model = (DefaultTableModel) table.getModel();
               model.addRow(cus);

               temp++;
            }

          
          rs.close();

          conn.close();
          } catch(Exception e){
          e.printStackTrace();
          }
      
      
}
}