using LoggerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    /// <summary>
    /// This class handle the Million expression
    /// </summary>
    public class MillionExpression : TerminalExpression
    {
        public override string One() { return "M"; }
        public override string Four() { return ""; }
        public override string Five() { return ""; }
        public override string Nine() { return ""; }
        public override int Multiplier() { return 1000000; }
    }

    /// <summary>
    /// This class handle the Hundred Thousand expression
    /// </summary>
    class HundredThousandExpression : TerminalExpression
    {
        public override string One() { return "C"; }
        public override string Four() { return "CD"; }
        public override string Five() { return "D"; }
        public override string Nine() { return "CM"; }
        public override int Multiplier() { return 100000; }
    }

    /// <summary>
    /// This class handle the Ten Thousand expression
    /// </summary>
    class TenThousandExpression : TerminalExpression
    {
        public override string One() { return "X"; }
        public override string Four() { return "XL"; }
        public override string Five() { return "L"; }
        public override string Nine() { return "XC"; }
        public override int Multiplier() { return 10000; }
    }

    /// <summary>
    /// This class handle the Thousand expression
    /// </summary>
    class ThousandExpression : TerminalExpression
    {
        public override string One() { return "M"; }
        public override string Four() { return "MV"; }
        public override string Five() { return "V"; }
        public override string Nine() { return "MX"; }
        public override int Multiplier() { return 1000; }
    }

    /// <summary>
    /// This class handle the Hundred expression
    /// </summary>
    public class HundredExpression : TerminalExpression
    {
        
        public override string One() { return "C"; }
        public override string Four() { return "CD"; }
        public override string Five() { return "D"; }
        public override string Nine() { return "CM"; }
        public override int Multiplier() { return 100; }
    }
    /// <summary>
    /// This class handle the Ten expression
    /// </summary>
    class TenExpression : TerminalExpression
    {
        public override string One() { return "X"; }
        public override string Four() { return "XL"; }
        public override string Five() { return "L"; }
        public override string Nine() { return "XC"; }
        public override int Multiplier() { return 10; }
    }

    /// <summary>
    /// This class handle the One expression
    /// </summary>
    class OneExpression : TerminalExpression
    {
        public override string One() { return "I"; }
        public override string Four() { return "IV"; }
        public override string Five() { return "V"; }
        public override string Nine() { return "IX"; }
        public override int Multiplier() { return 1; }
    }
}
