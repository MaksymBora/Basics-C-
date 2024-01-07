namespace Task9;

public class Calculator
{
    public double ThreeValuesCalc(double value1, double value2, double value3, 
        StringParser.Action action1, StringParser.Action action2)
    {
        var isPriorityAction1 = IsPriorityAction(action1);
        var isPriorityAction2 = IsPriorityAction(action2);
        
        if (!IsPriorityAction(action1) && IsPriorityAction(action2))
            return TwoValuesCalc(value1, TwoValuesCalc(value2, value3, action2), action1);
        else
            return TwoValuesCalc(TwoValuesCalc(value1, value2, action1), value3, action2);
    }
    
    private bool IsPriorityAction(StringParser.Action action) => action switch
    {
        StringParser.Action.Multiply or StringParser.Action.Devide => true,
        _ => false
    };

    private double TwoValuesCalc(double value1, double value2, StringParser.Action action) => action switch
    {
        StringParser.Action.Plus => value1 + value2,
        StringParser.Action.Minus => value1 - value2,
        StringParser.Action.Multiply => value1 * value2,
        StringParser.Action.Devide => value1 / value2,
        _ => throw new Exception($"Unknown {nameof(StringParser.Action)}, value is {action}.")
    };
}