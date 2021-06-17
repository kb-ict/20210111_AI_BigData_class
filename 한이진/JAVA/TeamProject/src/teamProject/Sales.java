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

public class Sales  extends JFrame {
	JPanel center_p= new JPanel();
	JPanel bottom_p=new JPanel();
	
	JButton btn_s = new JButton("매출조회");
	
	
	JTable jt =null;
	JScrollPane jp=null;
	
	public static DefaultTableModel DFTM=null;
	
	public static Vector<Vector> data = new Vector<Vector>();
	public static Vector<String> title = new Vector<String>();
	
	public Sales(){
		 center_p.setLayout(null);
		 
		 title.add("날짜");
		 title.add("제품코드");
		 title.add("가격");
		 title.add("재고");
		 
		 
		Vector<String> data1= new Vector<String>();
		 data1.add("날짜");
		 data1.add("제품코드");
		 data1.add("가격");
		 data1.add("재고");
		
		 
		 data.add(data1);
		 DFTM= new DefaultTableModel(data,title);
		 jt=new JTable(DFTM);
		 jt.setBounds(0,0,785,530);
		 
		 jp=new JScrollPane(jt);
		 jp.setBounds(0,0,785,530);
		 
		 center_p.add(jp,BorderLayout.CENTER);
		 
		 bottom_p.add(btn_s);
		 btn_s.addActionListener(new ActionListener(){
			 @Override
			 public void actionPerformed(ActionEvent e){
				 data.clear();
				 
				 getDate();
				 
				 DFTM.fireTableDataChanged();
				 jt = new JTable(data,title);
				 Sumview sum= new Sumview();
		 
			 }			 
		 });
		 getContentPane().add(center_p, BorderLayout.CENTER);
		 getContentPane().add(bottom_p, BorderLayout.SOUTH);
			
			setSize(800, 600);
			setVisible(true);
			setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		
	}
	public void getDate(){
		
		Vector<Vector> data = new Vector<Vector>();
		Connection conn= null;
		PreparedStatement pstmt=null;
		ResultSet rs=null;
	
		try{
			Class.forName("oracle.jdbc.driver.OracleDriver");
			conn=DriverManager.getConnection("jdbc:oracle:thin:@localhost:1521:xe","AI","1234");
			System.out.println("데이터베이스 연결 성공");
			pstmt=conn.prepareStatement("select orderdate, pid,price, count from buying where to_char(orderdate,'yy/mm/dd')=TO_char(sysdate,'yy/mm/dd')");
			rs = pstmt.executeQuery();
			
			while(rs.next()){
				Vector<String> row= new Vector<String>();
				row.add(rs.getString(1));
				row.add(rs.getString(2));
				row.add(rs.getString(3));
				row.add(rs.getString(4));
				
				Sales.data.add(row);
				
			}
			
		}catch(Exception exc){
			exc.printStackTrace();
		}finally{
			try{
				if(pstmt != null)pstmt.close();
				if(conn!=null)conn.close();
				if(rs != null)rs.close();
			}catch(Exception clo){}
//			return data;
		}
	}

	public static void main(String[] args) {
		new Orderlist();
	}
}

