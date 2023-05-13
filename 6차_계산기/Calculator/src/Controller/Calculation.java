package Controller;

public class Calculation {

    public Double calculateNumbers(String operator, Double number, Double preCalculatedNumber){

        Double result = null;

        switch (operator){
            case "+":
                result = preCalculatedNumber + number;
                break;
            case "-":
                result = preCalculatedNumber - number;
                break;
            case "x":
                result = preCalculatedNumber * number;
                break;
            case "/":
                result = preCalculatedNumber / number;
                break;
            case "=":
                break;
        }

        return result;
    }

    public void performAdditionalFunction(String operator){

        switch (operator){

            case "CE":
                break;
            case "C":
                break;
            case "backSpace":
                break;
            case "period":
                break;
            case "plusAndMinus":
                break;
        }
    }
}
