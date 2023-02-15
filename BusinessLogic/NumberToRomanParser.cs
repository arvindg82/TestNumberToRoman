using BusinessObject;
using LoggerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class NumberToRomanParser : Expression
    {
        private List<Expression> expressionTree = new List<Expression>()
                                                  {
                                                      new MillionExpression(),
                                                      new HundredThousandExpression(),
                                                      new TenThousandExpression(),
                                                      new ThousandExpression(),
                                                      new HundredExpression(),
                                                      new TenExpression(),
                                                      new OneExpression()
                                                  };

        public override void Interpret(Context value)
        {
            WriteLogFile.WriteLog("ConsoleLog", String.Format("{0} @ {1}", "Start of processing: " + value.Input, DateTime.Now));
            foreach (Expression exp in expressionTree)
            {
                exp.Interpret(value);
            }
        }
    }
}
