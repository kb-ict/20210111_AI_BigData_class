package teamProject;

import java.awt.Frame;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.Vector;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.JTextField;
import javax.swing.border.EmptyBorder;
import javax.swing.table.DefaultTableModel;

import teamProject.DBConnec;
//import teamProject.DBCustomertable.CUSTOMER;

//class DBCUSTOMER {
//   private int id;
//   private String name;
//   private String gender;
//   private int birthyear;
//   private String address;
//   private String phone;
//
//   public DBCUSTOMER(int id, String name, String gender, int birthyear, String address, String phone){
//      this.id = id;
//      this.name = name;
//      this.gender = gender;
//      this.birthyear = birthyear;
//      this.address = address;
//      this.phone = phone;
//   }
//   public void print() {
//      System.out.println(""+id + name);
//   }
//}
public class test extends JFrame {
	
	private JPanel contentPane;
	public static JTable table;
	
	public test() {
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

   static JFrame a=new JFrame("고객조회");

   public static void db() {
      a.setVisible(true);
      a.setSize(400,200);
      a.getContentPane().setLayout(null);
   
      String column[] = { "ID", "NAME", "GENDER", "BIRTHYEAR", "ADDRESS", "PHONE" };
      DefaultTableModel model = new DefaultTableModel(column,0);
       
       JTable table = new JTable(model);
       a.getContentPane().add(table);
       
       JScrollPane scrollPane=new JScrollPane(table);
       scrollPane.setSize(500,200);
       
       Connection conn = null;
        PreparedStatement pstm = null; 
        ResultSet rs = null; 
        
  
      try {
         
//         DefaultTableModel model = new DefaultTableModel(column1, 0);

         
         
         int count = 0;
//         DBCUSTOMER[] cus = new DBCUSTOMER[1000];
      
         conn = DBConnec.getConnection();
         String quary = "SELECT * FROM customer";

         pstm = conn.prepareStatement(quary);
         rs = pstm.executeQuery();
         
         String[][] datas=new String[1000][];

//         Vector<Object> row = new Vector<>();
//         while(rs.next()) {
//            row.addElement(rs.getString("ID"));
//         }
         
         
         while (rs.next()) {

//            model.addRow(
//                  new Object[] {rs.getInt("ID"), rs.getString("NAME"), rs.getString("GENDER"),
//                  rs.getInt("BIRTHYEAR"), rs.getString("ADDRESS"), rs.getString("PHONE")}
//                  );
            
            int rowCount = 0;

               String id = rs.getString("ID");
               String name = rs.getString("NAME");
               String gender = rs.getString("GENDER");
               String birthyear = rs.getString("BIRTHYEAR");
               String address = rs.getString("ADDRESS");
               String phone = rs.getString("PHONE");

         
               // 2차 배열안에 데이터를 집어넣는 방법
               datas[rowCount] = new String[6];
               
               datas[rowCount][0] = id;
               datas[rowCount][1] = name;
               datas[rowCount][2] = gender;
               datas[rowCount][3] = birthyear;
               datas[rowCount][4] = address;
               datas[rowCount][5] = phone;

               System.out.println("테이블넣기");
               System.out.println(datas[0][1]);
         
               rowCount++;      
               
               
               
//               cus[temp] = new DBCUSTOMER(rs.getInt("ID"),rs.getString("NAME"),rs.getString("GENDER"),rs.getInt("BIRTHYEAR"), rs.getString("ADDRESS"),rs.getString("PHONE"));
//               model = (DefaultTableModel) table.getModel();
//               model.addRow(cus);
               model.addRow(datas);

            
            }
          rs.close();
          conn.close();
          } catch(Exception e){
          e.printStackTrace();
          }
      
}
}