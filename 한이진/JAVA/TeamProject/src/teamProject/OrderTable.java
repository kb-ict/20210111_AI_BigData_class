package teamProject;

import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.text.SimpleDateFormat;
import java.util.Calendar;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.border.EmptyBorder;

public class OrderTable extends JFrame {

//   OrderTable OT = new OrderTable();
   Connection conn = null;
   PreparedStatement pstmt = null;
   ResultSet rs = null;
   
   private JPanel contentPane;
   private JLabel lblOrder;
   private JButton BtnNext;
   private JTextField tfUid;
   private JTextField tfName;
   private JTextField tfAddress;
   private JTextField tfPhone;
   private JTextField tfSymptom;
   private JLabel lblAge;
   private JTextField tfage;
   private JTextField tfGender;
   private JLabel lblGender;
   private JButton BtnBack;
   public static String tempID;
   public static String tempName;

   public OrderTable() {
      conn = DBConnec.getConnection();
      SimpleDateFormat format1 = new SimpleDateFormat("yy-MM-dd");
      Calendar time = Calendar.getInstance();
      String format_time1 = format1.format(time.getTime());
      
      setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
      setSize(430, 530);
      setLocationRelativeTo(null);
      contentPane = new JPanel();
      contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
      setContentPane(contentPane);
      contentPane.setLayout(null);
      
      lblOrder = new JLabel("주문");
      Font f1 = new Font("돋움", Font.BOLD, 20);
      lblOrder.setFont(f1); 
      lblOrder.setBounds(159, 41, 101, 20);
      contentPane.add(lblOrder);
      
      JLabel lblId = new JLabel("ID");
      lblId.setBounds(69, 93, 69, 20);
      contentPane.add(lblId);
      
      JLabel lblName = new JLabel("이름");
      lblName.setBounds(69, 140, 69, 20);
      contentPane.add(lblName);
      
      JLabel lblAge = new JLabel("나이");
      lblAge.setBounds(69, 187, 69, 20);
      contentPane.add(lblAge);
      
      JLabel lblAddress = new JLabel("주소");
      lblAddress.setBounds(69, 234, 69, 20);
      contentPane.add(lblAddress);
      
      JLabel lblPhone = new JLabel("전화번호");
      lblPhone.setBounds(69, 281, 69, 20);
      contentPane.add(lblPhone);
      
      
      JLabel lblGender = new JLabel("성별");
      lblGender.setBounds(69, 375, 69, 20);
      contentPane.add(lblGender);      
      
      tfUid = new JTextField();
      tfUid.setColumns(10);
      tfUid.setBounds(159, 86, 186, 35);
      contentPane.add(tfUid);
      
      tfName = new JTextField();
      tfName.setColumns(10);
      tfName.setBounds(159, 133, 186, 35);
      contentPane.add(tfName);
      
      tfAddress = new JTextField();
      tfAddress.setColumns(10);
      tfAddress.setBounds(159, 227, 186, 35);
      contentPane.add(tfAddress);
      
      tfPhone = new JTextField();
      tfPhone.setColumns(10);
      tfPhone.setBounds(159, 274, 186, 35);
      contentPane.add(tfPhone);

      
      tfage = new JTextField();
      tfage.setColumns(10);
      tfage.setBounds(159, 180, 186, 35);
      contentPane.add(tfage);
      
      tfGender = new JTextField();
      tfGender.setColumns(10);
      tfGender.setBounds(159, 368, 186, 35);
      contentPane.add(tfGender);

      BtnBack = new JButton("이전");
      BtnBack.setBounds(49, 445, 139, 29);
      contentPane.add(BtnBack);
      
      BtnNext = new JButton("다음");
      BtnNext.setBounds(216, 445, 139, 29);
      contentPane.add(BtnNext);
      
      setVisible(true);
      
      BtnNext.addActionListener(new ActionListener() {
         
         @Override
         public void actionPerformed(ActionEvent e1) {
            
            try{

               pstmt = conn.prepareStatement("insert into customer values(?,?,?,?,?,?)");
               pstmt.setString(1, tfUid.getText());
            pstmt.setString(2, tfName.getText());
            pstmt.setString(3, tfGender.getText());
            pstmt.setString(4, tfage.getText());
            pstmt.setString(5, tfAddress.getText());
            pstmt.setString(6, tfPhone.getText());
               pstmt.executeUpdate();
               
               tempID = tfUid.getText();
               tempName = tfName.getText();
               
            }
            catch(Exception exc){
               exc.printStackTrace();
               System.out.println("실패");
            }
            setVisible(false);
            SelectPill frame = new SelectPill();
         }
      });
      
      BtnBack.addActionListener(new ActionListener() {
         
         @Override
         public void actionPerformed(ActionEvent e2) {
            setVisible(false);
            Customer frame = new Customer();
         }
      });

   }
}