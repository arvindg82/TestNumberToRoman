using BusinessObject;

namespace BusinessLogic
{
    public abstract class Expression
    {
        public abstract void Interpret(Context value);
    }
}