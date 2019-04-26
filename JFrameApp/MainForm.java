package seriouswork;

import java.awt.Component;
import java.awt.Container;
import java.awt.Desktop;
import java.awt.FileDialog;
import java.io.File;
import java.io.IOException;
import java.io.PrintStream;
import java.sql.Date;
import java.text.SimpleDateFormat;

import javax.swing.JFrame;
import javax.swing.SwingUtilities;
import javax.swing.border.Border;
import javax.swing.filechooser.FileFilter;
import javax.swing.text.SimpleAttributeSet;
import javax.swing.text.StyleConstants;
import javax.swing.text.StyledDocument;
import javax.swing.JMenuBar;
import javax.swing.JMenu;
import javax.swing.JMenuItem;
import java.awt.Font;
import java.awt.Frame;
import java.awt.Graphics2D;
import java.awt.Point;
import java.awt.Rectangle;
import java.awt.Robot;
import java.awt.image.BufferedImage;

import javax.swing.JFileChooser;
import javax.imageio.*;
import javax.swing.JTextField;

import java.awt.AWTException;
import java.awt.BorderLayout;
import javax.swing.JTextArea;
import javax.swing.JTextPane;
import java.awt.Color;
import java.awt.SystemColor;
import java.awt.Toolkit;

import javax.swing.JScrollBar;
import javax.swing.JScrollPane;
import java.awt.ScrollPane;
import java.awt.Scrollbar;
import javax.swing.JRadioButton;
import javax.swing.BorderFactory;
import javax.swing.ButtonGroup;
import javax.swing.JCheckBox;
import javax.swing.JProgressBar;

@SuppressWarnings("serial")
public class SeriousWork extends JFrame{

	public SeriousWork() {
		
		JMenuBar menuBar = new JMenuBar();
		setJMenuBar(menuBar);
		
		JMenu mnNewMenu = new JMenu("File");
		mnNewMenu.setFont(new Font("Segoe UI", Font.PLAIN, 20));
		menuBar.add(mnNewMenu);
		
		JMenu mnAfterReset = new JMenu("View(on reset)");
		mnAfterReset.setFont(new Font("Segoe UI", Font.PLAIN, 20));
		mnAfterReset.setEnabled(false);
		menuBar.add(mnAfterReset);
		
		JMenuItem mntmFull = new JMenuItem("Default");
		mntmFull.setFont(new Font("Segoe UI", Font.PLAIN, 17));
		mnAfterReset.add(mntmFull);
		
		JMenuItem mntmCenter_1 = new JMenuItem("Center");
		mntmCenter_1.setFont(new Font("Segoe UI", Font.PLAIN, 17));
		mnAfterReset.add(mntmCenter_1);
		
		JMenuItem mntmFullscreen_1 = new JMenuItem("Fullscreen");
		mntmFullscreen_1.setFont(new Font("Segoe UI", Font.PLAIN, 17));
		mnAfterReset.add(mntmFullscreen_1);
		
		JTextPane txtpnInstructionsOfUsage = new JTextPane();
		txtpnInstructionsOfUsage.setBackground(SystemColor.controlHighlight);
		txtpnInstructionsOfUsage.setFont(new Font("Segoe Script", Font.BOLD | Font.ITALIC, 18));
		txtpnInstructionsOfUsage.setText("INSTRUCTIONS OF USAGE:\r\n\r\n1. A master folder named TestDir is created under the C: drive .\r\n2. All subfolders are getting created under TestDir .\r\n3. The local coordinates are available only in Full Screen mode .\r\n4. Once in Center Screen mode, you can't switch back to default position .\r\n5. Enlarge and smaller form are not useful in Full Screen mode .\r\n6. You cannot save JForm while in Full Screen mode .");
		getContentPane().add(txtpnInstructionsOfUsage, BorderLayout.CENTER);
		
		JMenu mnNewMenu_1 = new JMenu("View");
		mnNewMenu_1.setFont(new Font("Segoe UI", Font.PLAIN, 20));
		menuBar.add(mnNewMenu_1);
		
		JMenuItem mntmDefault = new JMenuItem("Default");
		mntmDefault.setFont(new Font("Segoe UI", Font.PLAIN, 17));
		mnNewMenu_1.add(mntmDefault);
		mntmDefault.addActionListener(e -> 
		{
			this.setExtendedState(0);
			txtpnInstructionsOfUsage.setFont(new Font("Segoe Script", Font.BOLD | Font.ITALIC, 18));
			StyledDocument doc = txtpnInstructionsOfUsage.getStyledDocument();
			SimpleAttributeSet left = new SimpleAttributeSet();
			StyleConstants.setAlignment(left, StyleConstants.ALIGN_LEFT);
			doc.setParagraphAttributes(0, doc.getLength(), left, false);
			

		});
		
		JMenuItem mntmCenter = new JMenuItem("Center");
		mntmCenter.setFont(new Font("Segoe UI", Font.PLAIN, 17));
		mnNewMenu_1.add(mntmCenter);
		mntmCenter.addActionListener(e -> {
			
			this.setExtendedState(0);
			this.setLocationRelativeTo(null);
			txtpnInstructionsOfUsage.setFont(new Font("Segoe Script", Font.BOLD | Font.ITALIC, 18));
			StyledDocument doc = txtpnInstructionsOfUsage.getStyledDocument();
			SimpleAttributeSet left = new SimpleAttributeSet();
			StyleConstants.setAlignment(left, StyleConstants.ALIGN_LEFT);
			doc.setParagraphAttributes(0, doc.getLength(), left, false);
		
		});
		
		JMenuItem mntmFullscreen = new JMenuItem("Fullscreen");
		mntmFullscreen.setFont(new Font("Segoe UI", Font.PLAIN, 17));
		mnNewMenu_1.add(mntmFullscreen);
		mntmFullscreen.addActionListener(e -> 
		
		{		
			this.setExtendedState(JFrame.MAXIMIZED_BOTH);
			txtpnInstructionsOfUsage.setText("INSTRUCTIONS OF USAGE:\r\n\r\n1. A master folder named TestDir is created under the C: drive .\r\n2. All subfolders are getting created under TestDir .\r\n3. The local coordinates are available only in Full Screen mode .\r\n4. Once in Center Screen mode, you can't switch back to default position .\r\n5. Enlarge and smaller form are not useful in Full Screen mode .\r\n6. You cannot save JForm while in Full Screen mode .");
			StyledDocument doc = txtpnInstructionsOfUsage.getStyledDocument();
			SimpleAttributeSet center = new SimpleAttributeSet();
			StyleConstants.setAlignment(center, StyleConstants.ALIGN_CENTER);
			doc.setParagraphAttributes(0, doc.getLength(), center, false);
			txtpnInstructionsOfUsage.setFont(new Font("Segoe Script", Font.BOLD | Font.ITALIC, 30));
			
		});
		
		
		JMenuItem mntmNewMenuItem_2 = new JMenuItem("Reset form");
		mntmNewMenuItem_2.setFont(new Font("Segoe UI", Font.PLAIN, 17));
		mnNewMenu.add(mntmNewMenuItem_2);
		mntmNewMenuItem_2.addActionListener(e -> {
			
			this.getContentPane().removeAll();
			this.getContentPane().revalidate();
			this.getContentPane().repaint();
			mnAfterReset.setEnabled(true);
			mnNewMenu_1.setEnabled(false);
			mnNewMenu_1.setText("View(disabled)");
			
			txtpnInstructionsOfUsage.setBackground(SystemColor.controlHighlight);
			txtpnInstructionsOfUsage.setFont(new Font("Segoe Script", Font.BOLD | Font.ITALIC, 18));
			txtpnInstructionsOfUsage.setText("INSTRUCTIONS OF USAGE:\r\n\r\n1. A master folder named TestDir is created under the C: drive .\r\n2. All subfolders are getting created under TestDir .\r\n3. The local coordinates are available only in Full Screen mode .\r\n4. Once in Center Screen mode, you can't switch back to default position .\r\n5. Enlarge and smaller form are not useful in Full Screen mode .\r\n6. You cannot save JForm while in Full Screen mode .");
			getContentPane().add(txtpnInstructionsOfUsage, BorderLayout.CENTER);
		
			JCheckBox rdbtnNewRadioButton = new JCheckBox("Enlight form");
			rdbtnNewRadioButton.setFont(new Font("Tahoma", Font.PLAIN, 16));
			getContentPane().add(rdbtnNewRadioButton, BorderLayout.NORTH);
			rdbtnNewRadioButton.addActionListener(x -> {
				
				if (rdbtnNewRadioButton.isSelected())
					txtpnInstructionsOfUsage.setBackground(SystemColor.YELLOW);
				else
					txtpnInstructionsOfUsage.setBackground(SystemColor.controlHighlight);

			});	
			
			mntmFull.addActionListener(z -> 
			{
				this.setExtendedState(0);
				txtpnInstructionsOfUsage.setFont(new Font("Segoe Script", Font.BOLD | Font.ITALIC, 18));
				StyledDocument doc = txtpnInstructionsOfUsage.getStyledDocument();
				SimpleAttributeSet left = new SimpleAttributeSet();
				StyleConstants.setAlignment(left, StyleConstants.ALIGN_LEFT);
				doc.setParagraphAttributes(0, doc.getLength(), left, false);
				

			});
			
			mntmCenter_1.addActionListener(a -> {
				
				this.setExtendedState(0);
				this.setLocationRelativeTo(null);
				txtpnInstructionsOfUsage.setFont(new Font("Segoe Script", Font.BOLD | Font.ITALIC, 18));
				StyledDocument doc = txtpnInstructionsOfUsage.getStyledDocument();
				SimpleAttributeSet left = new SimpleAttributeSet();
				StyleConstants.setAlignment(left, StyleConstants.ALIGN_LEFT);
				doc.setParagraphAttributes(0, doc.getLength(), left, false);
			
			});
			
			mntmFullscreen_1.addActionListener(y -> 
			
			{		
				this.setExtendedState(JFrame.MAXIMIZED_BOTH);
				txtpnInstructionsOfUsage.setText("INSTRUCTIONS OF USAGE:\r\n\r\n1. A master folder named TestDir is created under the C: drive .\r\n2. All subfolders are getting created under TestDir .\r\n3. The local coordinates are available only in Full Screen mode .\r\n4. Once in Center Screen mode, you can't switch back to default position .\r\n5. Enlarge and smaller form are not useful in Full Screen mode .\r\n6. You cannot save JForm while in Full Screen mode .");
				StyledDocument doc = txtpnInstructionsOfUsage.getStyledDocument();
				SimpleAttributeSet center = new SimpleAttributeSet();
				StyleConstants.setAlignment(center, StyleConstants.ALIGN_CENTER);
				doc.setParagraphAttributes(0, doc.getLength(), center, false);
				txtpnInstructionsOfUsage.setFont(new Font("Segoe Script", Font.BOLD | Font.ITALIC, 30));
				
			});
		
		});
		
						
		JMenuItem mntmOpen = new JMenuItem("Open");
		mntmOpen.setFont(new Font("Segoe UI", Font.PLAIN, 17));
		mnNewMenu.add(mntmOpen);
		JFileChooser Itemopen = new JFileChooser();
		mntmOpen.addActionListener(e -> {
			
			if (Itemopen.showOpenDialog(Itemopen) == JFileChooser.APPROVE_OPTION) {
				File file = Itemopen.getSelectedFile();
				Desktop desktop = Desktop.getDesktop();
		        if(file.exists()) 
		        	{
		        		try {
							desktop.open(file);
						} catch (IOException e1) {
							// TODO Auto-generated catch block
							e1.printStackTrace();
						}
		        	}
		        
		        }});
		
		
		JMenuItem mntmSave = new JMenuItem("Save form");
		mntmSave.setFont(new Font("Segoe UI", Font.PLAIN, 17));
		mnNewMenu.add(mntmSave);
		mntmSave.addActionListener(e -> {
			
			File dir = new File("C:\\TestDir");
		    dir.mkdir();
			BufferedImage image = new BufferedImage(getWidth(), getHeight(), BufferedImage.TYPE_INT_RGB);
            Graphics2D graphics2D = image.createGraphics();
            this.paint(graphics2D);
            try {
				ImageIO.write(image,"png", new File("C:\\TestDir\\Form.png"));
			} catch (IOException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}
            
            if(mntmSave.isEnabled())
            {
            	
        		JProgressBar progressBar = new JProgressBar();
        		getContentPane().add(progressBar, BorderLayout.SOUTH);
            	progressBar.setValue(100);
            	progressBar.setStringPainted(true);
            	Border border = BorderFactory.createTitledBorder("Drawing form...");
                progressBar.setBorder(border);
            }
		
		});
		
		JMenuItem mntmSaveAs = new JMenuItem("Create txt");
		mntmSaveAs.setFont(new Font("Segoe UI", Font.PLAIN, 17));
		mnNewMenu.add(mntmSaveAs);
		JFileChooser chooser = new JFileChooser();
	    chooser.setApproveButtonText("Save");
		mntmSaveAs.addActionListener(e -> {

			if (chooser.showSaveDialog(chooser) == JFileChooser.APPROVE_OPTION) {

				File file = chooser.getSelectedFile();
		        //String path = file.getPath();
		    
			}});
		
		JMenu mnExtras = new JMenu("Extras");
		mnExtras.setFont(new Font("Segoe UI", Font.PLAIN, 17));
		mnNewMenu.add(mnExtras);
		
		txtpnInstructionsOfUsage.setBackground(SystemColor.controlHighlight);
		txtpnInstructionsOfUsage.setFont(new Font("Segoe Script", Font.BOLD | Font.ITALIC, 18));
		txtpnInstructionsOfUsage.setText("INSTRUCTIONS OF USAGE:\r\n\r\n1. A master folder named TestDir is created under the C: drive .\r\n2. All subfolders are getting created under TestDir .\r\n3. The local coordinates are available only in Full Screen mode .\r\n4. Once in Center Screen mode, you can't switch back to default position .\r\n5. Enlarge and smaller form are not useful in Full Screen mode .\r\n6. You cannot save JForm while in Full Screen mode .");
		getContentPane().add(txtpnInstructionsOfUsage, BorderLayout.CENTER);
		
		JCheckBox rdbtnNewRadioButton = new JCheckBox("Enlight form");
		rdbtnNewRadioButton.setFont(new Font("Tahoma", Font.PLAIN, 16));
		getContentPane().add(rdbtnNewRadioButton, BorderLayout.NORTH);
		
		rdbtnNewRadioButton.addActionListener(e -> {
		
			if (rdbtnNewRadioButton.isSelected())
				txtpnInstructionsOfUsage.setBackground(SystemColor.YELLOW);
			else
				txtpnInstructionsOfUsage.setBackground(SystemColor.controlHighlight);

		});
	

		JMenuItem mntmDateAndTime = new JMenuItem("Date and Time");
		mntmDateAndTime.setFont(new Font("Segoe UI", Font.PLAIN, 17));
		mnExtras.add(mntmDateAndTime);
		mntmDateAndTime.addActionListener(e -> {
			
			SimpleDateFormat sdfDate = new SimpleDateFormat("yyyy-MM-dd HH:mm");
		    Date now = new Date(1486857132);
			String content = "INSTRUCTIONS OF USAGE UP TO: ";
			String content2 = "\r\n\r\n1. A master folder named TestDir is created under the C: drive .\r\n2. All subfolders are getting created under TestDir .\r\n3. The local coordinates are available only in Full Screen mode .\r\n4. Once in Center Screen mode, you can't switch back to default position .\r\n5. Enlarge and smaller form are not useful in Full Screen mode .\r\n6. You cannot save JForm while in Full Screen mode .";
			txtpnInstructionsOfUsage.setText(content + sdfDate.format(now).toString() + content2); 
			
		});

		
		
		JMenuItem mntmPrintscreen = new JMenuItem("Printscreen");
		mntmPrintscreen.setFont(new Font("Segoe UI", Font.PLAIN, 17));
		mnExtras.add(mntmPrintscreen);		
		mntmPrintscreen.addActionListener(e -> 
		{
			File dir = new File("C:\\TestDir");
		    dir.mkdir();
			 try {
		            Robot robot = new Robot();
		            String format = "jpg";
		            String fileName = "C:\\TestDir\\FullScreenshot." + format;
		             
		            Rectangle screenRect = new Rectangle(Toolkit.getDefaultToolkit().getScreenSize());
		            BufferedImage screenFullImage = robot.createScreenCapture(screenRect);
		            ImageIO.write(screenFullImage, format, new File(fileName));
		             
		            System.out.println("A full screenshot saved!");
		        } catch (AWTException | IOException ex) {
		            System.err.println(ex);
		        }
			 
			 if(mntmPrintscreen.isEnabled())
	            {
	            	
	        		JProgressBar progressBar = new JProgressBar();
	        		getContentPane().add(progressBar, BorderLayout.SOUTH);
	            	progressBar.setValue(100);
	            	progressBar.setStringPainted(true);
	            	Border border = BorderFactory.createTitledBorder("Drawing screen...");
	                progressBar.setBorder(border);
	            }
		});

		
		JMenuItem mntmClose = new JMenuItem("Close");
		mntmClose.setFont(new Font("Segoe UI", Font.PLAIN, 17));
		mnNewMenu.add(mntmClose);
		mntmClose.addActionListener(e -> this.dispose());
	
		JMenu mnNewMenu_2 = new JMenu("Settings");
		mnNewMenu_2.setFont(new Font("Segoe UI", Font.PLAIN, 20));
		menuBar.add(mnNewMenu_2);
		
		JMenu mnNewMenu_3 = new JMenu("Tools");
		mnNewMenu_3.setFont(new Font("Segoe UI", Font.PLAIN, 20));
		menuBar.add(mnNewMenu_3);
		
		JMenu mnEntertainment = new JMenu("Entertainment");
		mnEntertainment.setFont(new Font("Segoe UI", Font.PLAIN, 20));
		menuBar.add(mnEntertainment);
		
		JMenuItem mntmEnlargeFont = new JMenuItem("Enlarge font");
		mntmEnlargeFont.setFont(new Font("Segoe UI", Font.PLAIN, 17));
		mnNewMenu_2.add(mntmEnlargeFont);
		mntmEnlargeFont.addActionListener(e -> {
		
			mnNewMenu.setFont(new Font("Segoe UI", Font.BOLD, 22));
			mnNewMenu_1.setFont(new Font("Segoe UI", Font.BOLD, 22));
			mnNewMenu_2.setFont(new Font("Segoe UI", Font.BOLD, 22));
			mnNewMenu_3.setFont(new Font("Segoe UI", Font.BOLD, 22));
			mnEntertainment.setFont(new Font("Segoe UI", Font.BOLD, 22));
			mnAfterReset.setFont(new Font("Segoe UI", Font.BOLD, 22));
			
		});
		
		JMenuItem mntmSmallerFont = new JMenuItem("Smaller font");
		mntmSmallerFont.setFont(new Font("Segoe UI", Font.PLAIN, 17));
		mnNewMenu_2.add(mntmSmallerFont);
		mntmSmallerFont.addActionListener(e -> {

			mnNewMenu.setFont(new Font("Segoe UI", Font.PLAIN, 18));
			mnNewMenu_1.setFont(new Font("Segoe UI", Font.PLAIN, 18));
			mnNewMenu_2.setFont(new Font("Segoe UI", Font.PLAIN, 18));
			mnNewMenu_3.setFont(new Font("Segoe UI", Font.PLAIN, 18));
			mnEntertainment.setFont(new Font("Segoe UI", Font.PLAIN, 18));
			mnAfterReset.setFont(new Font("Segoe UI", Font.PLAIN, 18));

		
		});	
			
		JMenuItem mntmEnlargeForm = new JMenuItem("Enlarge form");
		mntmEnlargeForm.setFont(new Font("Segoe UI", Font.PLAIN, 17));
		mnNewMenu_2.add(mntmEnlargeForm);
		mntmEnlargeForm.addActionListener(e -> {
			
			setFrame(this, 800, 600);	
		
		});
		
		
		JMenuItem mntmSmallerForm = new JMenuItem("Smaller form");
		mntmSmallerForm.setFont(new Font("Segoe UI", Font.PLAIN, 17));
		mnNewMenu_2.add(mntmSmallerForm);
		mntmSmallerForm.addActionListener(e -> {
			
			setFrame(this, 500, 300);	
		
		});
		
		JMenuItem mntmOpenDirectory = new JMenuItem("Open directory");
		mntmOpenDirectory.setFont(new Font("Segoe UI", Font.PLAIN, 17));
		mnNewMenu_3.add(mntmOpenDirectory);
		File dir = new File("C:\\TestDir");
	    dir.mkdir();
	    File subdir1 = new File("C:\\TestDir\\Subdir1");
	    File subdir2 = new File("C:\\TestDir\\Subdir2");
	    subdir1.mkdir();
	    subdir2.mkdir();
	    
	    boolean successful = dir.mkdir();
	    if (successful)
	    {
	      // creating the directory succeeded
	      System.out.println("directory was created successfully");
	    }
	    else
	    {
	      // creating the directory failed
	      System.out.println("Directory already exists!");
	    }
	    
	    mntmOpenDirectory.addActionListener(e -> {
			try {
				Desktop.getDesktop().open(dir);
			} catch (IOException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}
		});
		
		JMenuItem mntmNewMenuItem = new JMenuItem("Remove dir");
		mntmNewMenuItem.setFont(new Font("Segoe UI", Font.PLAIN, 17));
		mnNewMenu_3.add(mntmNewMenuItem);
		mntmNewMenuItem.addActionListener(e -> dir.delete());
		mntmNewMenuItem.addActionListener(e -> subdir1.delete());
		mntmNewMenuItem.addActionListener(e -> subdir2.delete());
		File xyz = new File("C:\\TestDir\\Test.txt");
		File form = new File("C:\\TestDir\\Form.png");
		File prscreen = new File("C:\\TestDir\\FullScreenshot.jpg");
		mntmNewMenuItem.addActionListener(e -> xyz.delete());
		mntmNewMenuItem.addActionListener(e -> form.delete());
		mntmNewMenuItem.addActionListener(e -> prscreen.delete());

		
		
		JMenuItem mntmNewMenuItem_1 = new JMenuItem("Remove subdirs");
		mntmNewMenuItem_1.setFont(new Font("Segoe UI", Font.PLAIN, 17));
		mnNewMenu_3.add(mntmNewMenuItem_1);
		mntmNewMenuItem_1.addActionListener(e -> subdir1.delete());
		mntmNewMenuItem_1.addActionListener(e -> subdir2.delete());
		// TODO Auto-generated constructor stub
		

		JMenuItem mntmRemoveFiles = new JMenuItem("Remove files");
		mntmRemoveFiles.setFont(new Font("Segoe UI", Font.PLAIN, 17));
		mnNewMenu_3.add(mntmRemoveFiles);
		mntmRemoveFiles.addActionListener(e -> xyz.delete());
		mntmRemoveFiles.addActionListener(e -> form.delete());
		mntmRemoveFiles.addActionListener(e -> prscreen.delete());
		mntmRemoveFiles.addActionListener(e -> dir.lastModified());
		
		
		JMenuItem mntmValidate = new JMenuItem("Validate");
		mntmValidate.setFont(new Font("Segoe UI", Font.PLAIN, 17));
		mnEntertainment.add(mntmValidate);
		
		
		mntmValidate.addActionListener(e -> {
			
			PassForm pass = new PassForm(); 
			pass.setVisible(true);
			pass.setSize(450, 300);
		});
	
	}
	

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		setFrame(new SeriousWork(), 700, 500);

	}
	
	
	
	public static void
	setFrame(final JFrame frame, final int width, final int height) {
	SwingUtilities.invokeLater(new Runnable() {
	public void run() {
	frame.setTitle(frame.getClass().getSimpleName());
	frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	frame.setSize(width, height);
	frame.setVisible(true);
	}
	});
	
	}

}
