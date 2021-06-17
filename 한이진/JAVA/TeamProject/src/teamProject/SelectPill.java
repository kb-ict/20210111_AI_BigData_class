package teamProject;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;

public class SelectPill extends JFrame 
{
	private JPanel contentPane;
	
	public SelectPill() 
	{
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setSize(160, 300);
		setLocationRelativeTo(null);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		getContentPane().setLayout(null);
		
		setVisible(true);
			
		JButton btnHeadache = new JButton("두통");
		btnHeadache.setBounds(20, 20, 117, 37);
		getContentPane().add(btnHeadache);
		
		JButton btnCold = new JButton("감기");
		btnCold.setBounds(20, 113, 117, 37);
		getContentPane().add(btnCold);
		
		JButton btnMuscle = new JButton("근육통");
		btnMuscle.setBounds(20, 163, 117, 37);
		getContentPane().add(btnMuscle);
		
		JButton btnStomach = new JButton("소화불량");
		btnStomach.setBounds(20, 69, 117, 37);
		getContentPane().add(btnStomach);
		
		JButton btnSkin = new JButton("피부염");
		btnSkin.setBounds(20, 212, 117, 37);
		getContentPane().add(btnSkin);
		
		
		btnHeadache.addActionListener(new ActionListener() 
		{	
			@Override
			public void actionPerformed(ActionEvent e)
			{
				setVisible(false);
				HeadAche frame = new HeadAche();
			
			
			}
		});	
		btnCold.addActionListener(new ActionListener() 
		{	
			@Override
			public void actionPerformed(ActionEvent e) 
			{
				setVisible(false);
				Cold frame = new Cold();
			
			
			}
		});		
		btnMuscle.addActionListener(new ActionListener() 
		{	
			@Override
			public void actionPerformed(ActionEvent e) 
			{
				setVisible(false);
				Muscle frame = new Muscle();
			
			
			}
		});		
		btnStomach.addActionListener(new ActionListener() 
		{	
			@Override
			public void actionPerformed(ActionEvent e) 
			{
				setVisible(false);
				Stomach frame = new Stomach();
			
			
			}
		});		
		btnSkin.addActionListener(new ActionListener() 
		{	
			@Override
			public void actionPerformed(ActionEvent e) 
			{
				setVisible(false);
				Skin frame = new Skin();
			
			
			}
		});		
		
		
	}
}
