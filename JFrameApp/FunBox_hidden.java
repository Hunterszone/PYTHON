package seriouswork;

import java.awt.Font;
import java.awt.Graphics;
import java.awt.Image;
import java.awt.Toolkit;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.awt.image.BufferedImage;
import java.awt.image.RenderedImage;
import java.io.File;
import java.io.IOException;
import java.net.MalformedURLException;
import java.net.URI;
import java.net.URISyntaxException;
import java.net.URL;

import javax.imageio.ImageIO;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JCheckBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JMenu;
import javax.swing.JPasswordField;
import javax.swing.JTextField;
import javax.swing.SwingUtilities;
import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Desktop;

import javax.swing.JMenuBar;
import javax.swing.JMenuItem;
import javax.swing.JPanel;

@SuppressWarnings("serial")
public class PassForm extends JFrame {

	public PassForm() {
		setTitle("Validation form");
		// TODO Auto-generated constructor stub
		
		JMenuBar menuBar = new JMenuBar();
		setJMenuBar(menuBar);
		
		JMenu mnFunbox = new JMenu("FunBox");
		mnFunbox.setEnabled(false);
		mnFunbox.setFont(new Font("Segoe UI", Font.BOLD | Font.ITALIC, 20));
		menuBar.add(mnFunbox);
		
		
		JMenu mnNewMenu = new JMenu("Searching   ");
		mnNewMenu.setFont(new Font("Segoe UI", Font.PLAIN, 17));
		mnFunbox.add(mnNewMenu);
		
		
		JMenuItem mntmGoogle = new JMenuItem("Google   ");
		mntmGoogle.setFont(new Font("Segoe UI", Font.PLAIN, 17));
		mnNewMenu.add(mntmGoogle);
		mntmGoogle.addActionListener(e -> {
			try {
				Desktop.getDesktop().browse(new URI("http://www.google.com"));
			} catch (IOException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			} catch (URISyntaxException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}
		});

		
		JMenuItem mntmBing = new JMenuItem("Bing     ");
		mntmBing.setFont(new Font("Segoe UI", Font.PLAIN, 17));
		mnNewMenu.add(mntmBing);
		mntmBing.addActionListener(e -> {
			try {
				Desktop.getDesktop().browse(new URI("http://www.bing.com"));
			} catch (IOException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			} catch (URISyntaxException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}
		});
		
		JMenu mnWebSites = new JMenu("Web Sites");
		mnWebSites.setFont(new Font("Segoe UI", Font.PLAIN, 17));
		mnFunbox.add(mnWebSites);
		
		JMenuItem mntmFacebook = new JMenuItem("Facebook");
		mntmFacebook.setFont(new Font("Segoe UI", Font.PLAIN, 17));
		mnWebSites.add(mntmFacebook);
		mntmFacebook.addActionListener(e -> {
			try {
				Desktop.getDesktop().browse(new URI("http://www.facebook.com"));
			} catch (IOException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			} catch (URISyntaxException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}
		});
		
		JMenuItem mntmYoutube = new JMenuItem("YouTube");
		mntmYoutube.setFont(new Font("Segoe UI", Font.PLAIN, 17));
		mnWebSites.add(mntmYoutube);
		mntmYoutube.addActionListener(e -> {
			try {
				Desktop.getDesktop().browse(new URI("http://www.youtube.com"));
			} catch (IOException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			} catch (URISyntaxException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}
		});
		
		
		JMenuItem mntmGoogle_1 = new JMenuItem("Google+");
		mntmGoogle_1.setFont(new Font("Segoe UI", Font.PLAIN, 17));
		mnWebSites.add(mntmGoogle_1);
		mntmGoogle_1.addActionListener(e -> {
			try {
				Desktop.getDesktop().browse(new URI("https://plus.google.com/collections/featured"));
			} catch (IOException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			} catch (URISyntaxException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}
		});
		
		
		JCheckBox age = new JCheckBox("My age is over 18");
		age.setFont(new Font("Tahoma", Font.PLAIN, 16));
		getContentPane().add(age, BorderLayout.CENTER);
		
		
		JButton Login = new JButton("Validate");
		Login.setFont(new Font("Segoe UI", Font.PLAIN, 17));
		getContentPane().add(Login, BorderLayout.SOUTH);
		
		Login.addActionListener(e -> {
		
			if(age.isSelected())
			{
				mnFunbox.setEnabled(true);
				mnFunbox.setOpaque(true);
				
			}
				mnFunbox.setBackground(Color.GREEN);	
				
		});

		JMenuItem mntmClose = new JMenuItem("Close");
		mntmClose.setFont(new Font("Segoe UI", Font.PLAIN, 17));
		mnFunbox.add(mntmClose);
		mntmClose.addActionListener(e -> this.dispose());

	}
	

	public static void main(String[] args) throws Exception {
		// TODO Auto-generated method stub
		setFrame(new PassForm(), 450, 300);
	    
	}
	
	
	
	public static void
	setFrame(final JFrame frame, final int width, final int height) {
	SwingUtilities.invokeLater(new Runnable() {
	public void run() {
	/*	URL url = null;
		try {
			url = new URL("https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQimF5gsnL4G5ryB61f1yklONy9TZznLzB4WiNUlCQJErin0xEj");
		} catch (MalformedURLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		Image image = null;
		try {
			image = ImageIO.read(url);
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}*/

    //JLabel label = new JLabel(new ImageIcon(image));
    frame.setTitle(frame.getClass().getSimpleName());
	frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	frame.setSize(width, height);
	frame.setVisible(true);
	//frame.getContentPane().add(label, BorderLayout.CENTER);
    //frame.pack();
    
	
	}
	});
	
	
	}

}
