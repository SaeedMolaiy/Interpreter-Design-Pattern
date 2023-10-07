namespace InterpreterDesignPattern.Expressions;

internal class NumberExpression : Expression
{
    private readonly int _number;

    public NumberExpression(int number)
    {
        _number = number;
    }

    public override int Interpret()
    {
        return _number;
    }
}