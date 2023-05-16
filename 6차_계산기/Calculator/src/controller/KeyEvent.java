package controller;

import view.CalculatorFrame;

import java.awt.event.KeyAdapter;

public class KeyEvent {
    CalculatorFrame calculatorFrame;
    public KeyEvent(CalculatorFrame calculatorFrame){
        this.calculatorFrame = calculatorFrame;
    }
    public class KeyInputListener extends KeyAdapter  {
        public void keyPressed(java.awt.event.KeyEvent e) {
            switch (e.getKeyCode()) {
                case java.awt.event.KeyEvent.VK_0:
                    calculatorFrame.calculatebuttons[17].doClick();
                    break;
                case java.awt.event.KeyEvent.VK_1:
                    calculatorFrame.calculatebuttons[12].doClick();
                    break;
                case java.awt.event.KeyEvent.VK_2:
                    calculatorFrame.calculatebuttons[13].doClick();
                    break;
                case java.awt.event.KeyEvent.VK_3:
                    calculatorFrame.calculatebuttons[14].doClick();
                    break;
                case java.awt.event.KeyEvent.VK_4:
                    calculatorFrame.calculatebuttons[8].doClick();
                    break;
                case java.awt.event.KeyEvent.VK_5:
                    calculatorFrame.calculatebuttons[9].doClick();
                    break;
                case java.awt.event.KeyEvent.VK_6:
                    calculatorFrame.calculatebuttons[10].doClick();
                    break;
                case java.awt.event.KeyEvent.VK_7:
                    calculatorFrame.calculatebuttons[4].doClick();
                    break;
                case java.awt.event.KeyEvent.VK_8:
                    calculatorFrame.calculatebuttons[5].doClick();
                    break;
                case java.awt.event.KeyEvent.VK_9:
                    calculatorFrame.calculatebuttons[6].doClick();
                    break;
            }
        }
    }
}