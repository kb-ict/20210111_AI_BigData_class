package teamProject;

import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.Vector;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;


public class FindCSID extends JFrame {


      JPanel center_p= new JPanel();
      JPanel bottom_p=new JPanel();
      
      JButton btn_s = new JButton("조회");
      
      
      JTable jt =null;
      JScrollPane jp=null;
      
      public static DefaultTableModel DFTM=null;
      
      public static Vector<Vector> data = new Vector<Vector>();
      public static Vector<String> title = new Vector<String>();
      
      public FindCSID(){
          center_p.setLayout(null);
          
          title.add("ID");
          title.add("고객이름");
          title.add("제품코드");
          title.add("주문날짜");
          title.add("가격");
          title.add("수량");
          
          

          
          DFTM= new DefaultTableModel(data,title);
          jt=new JTable(DFTM);
          jt.setBounds(0,0,500,500);
          
          jp=new JScrollPane(jt);
          jp.setBounds(0,0,500,500);
          
          center_p.add(jp,BorderLayout.CENTER);
          
          bottom_p.add(btn_s);
          btn_s.addActionListener(new ActionListener(){
             @Override
             public void actionPerformed(ActionEvent e){
                data.clear();
                
                getDate();
                
                DFTM.fireTableDataChanged();
                jt = new JTable(data,title);
            
          
             }          
          });
          getContentPane().add(center_p, BorderLayout.CENTER);
          getContentPane().add(bottom_p, BorderLayout.SOUTH);
            
            setSize(500, 500);
            setVisible(true);
            setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
         
      }
      public void getDate(){
         
         Vector<Vector> data = new Vector<Vector>();
         Connection conn= null;
         PreparedStatement pstmt=null;
         ResultSet rs=null;
      
         try{
            conn=DBConnec.getConnection();
            int a=Integer.parseInt(OrderSelect.tfUsername.getText());
            String quary = "SELECT * FROM buying where CID= ?";
            pstmt = conn.prepareStatement(quary);
            pstmt.setInt(1, a);
             rs = pstmt.executeQuery();
         
            
            while(rs.next()){
               Vector<String> row= new Vector<String>();
               row.add(rs.getString(1));
               row.add(rs.getString(2));
               row.add(rs.getString(3));
               row.add(rs.getString(4));
               row.add(rs.getString(5));
               row.add(rs.getString(6));
               
               FindCSID.data.add(row);
               
            }
            
         }catch(Exception exc){
            exc.printStackTrace();
            System.out.println();
         }finally{
            try{
               if(pstmt != null)pstmt.close();
               if(conn!=null)conn.close();
               if(rs != null)rs.close();
            }catch(Exception clo){}

         }
      }



}