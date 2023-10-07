namespace InterpreterDesignPattern.Expressions;

internal class SubtractExpression : Expression
{
    private readonly Expression _left;
    private readonly Expression _right;

    public SubtractExpression(Expression left, Expression right)
    {
        _left = left;
        _right = right;
    }

    public override int Interpret()
    {
        return _left.Interpret() - _right.Interpret();
    }
}