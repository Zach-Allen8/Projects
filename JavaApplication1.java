package javaapplication1;
import java.awt.*;
import javax.swing.*;
import javax.swing.border.*;
import java.text.DecimalFormat;
public class JavaApplication1 {
    public static void main(String[] args) {
        CarPayment application = new CarPayment();
        application.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }
}
class CarPayment extends JFrame{
    private JPanel inputJPanel;
    
    
    private JLabel priceJLabel;
    private JTextField priceJTextField;
    
    private JLabel interestJLabel;
    private JTextField interestJTextField;
    
    private JLabel downPaymentJLabel;
    private JTextField downPaymentJTextField;
    
    private JButton calculateJButton;
    
    private JTextArea paymentsJTextArea;
    
    
    public CarPayment(){
        createUserInterface();
    }
    
    private void createUserInterface(){
        Container contentPane = getContentPane();
        contentPane.setLayout(null);
        
        inputJPanel = new JPanel();
        inputJPanel.setLayout(null);
        inputJPanel.setBorder(new TitledBorder("Car Loan Input"));
        inputJPanel.setBounds(20, 4, 260, 118);
        contentPane.add(inputJPanel);
        
        //price
        priceJLabel = new JLabel();
        priceJLabel.setBounds(40, 24, 80, 21);
        priceJLabel.setText("Price: ");
        inputJPanel.add(priceJLabel);
        
        priceJTextField = new JTextField();
        priceJTextField.setBounds(184, 24, 56, 21);
        priceJTextField.setHorizontalAlignment(JTextField.RIGHT);
        inputJPanel.add(priceJTextField);
        
        
        downPaymentJLabel = new JLabel();
        downPaymentJLabel.setBounds(40, 56, 106, 21);
        downPaymentJLabel.setText("Down Payment: ");
        inputJPanel.add(downPaymentJLabel);
        
        downPaymentJTextField = new JTextField();
        downPaymentJTextField.setBounds(184, 56, 56, 21);
        downPaymentJTextField.setHorizontalAlignment(JTextField.RIGHT);
        inputJPanel.add(downPaymentJTextField);
        
        
        interestJLabel = new JLabel();
        interestJLabel.setBounds(40, 88, 130, 21);
        interestJLabel.setText("Annual Interest rate: ");
        inputJPanel.add(interestJLabel);
        
        interestJTextField = new JTextField();
        interestJTextField.setBounds(184, 88, 56, 21);
        interestJTextField.setHorizontalAlignment(JTextField.RIGHT);
        inputJPanel.add(interestJTextField);
        
        calculateJButton = new JButton();
        calculateJButton.setText("Calculate");
        calculateJButton.setBounds(92, 128, 94, 24);
        contentPane.add(calculateJButton);
        
        paymentsJTextArea = new JTextArea();
        paymentsJTextArea.setBounds(28, 168, 232, 90);
        paymentsJTextArea.setEditable(false);
        contentPane.add(paymentsJTextArea);
        
        
        setTitle("Car Payment Calculator");
        setSize(325, 250);
        setVisible(true);
    }
}

