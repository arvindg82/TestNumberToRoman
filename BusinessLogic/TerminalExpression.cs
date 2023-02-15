using BusinessObject;
using LoggerService;

namespace BusinessLogic
{
    public abstract class TerminalExpression : Expression
    {
        /// <summary>
        /// This function interprets the input value received
        /// </summary>
        /// <param name="value">Input value</param>
        public override void Interpret(Context value)
        {
            try
            {
                WriteLogFile.WriteLog("ConsoleLog", String.Format("{0} @ {1}", "Processing of value: " + value.Input, DateTime.Now));
                while (value.Input - 9 * Multiplier() >= 0)
                {
                    value.Output += Nine();
                    value.Input -= 9 * Multiplier();
                }
                while (value.Input - 5 * Multiplier() >= 0)
                {
                    value.Output += Five();
                    value.Input -= 5 * Multiplier();
                }
                while (value.Input - 4 * Multiplier() >= 0)
                {
                    value.Output += Four();
                    value.Input -= 4 * Multiplier();
                }
                while (value.Input - Multiplier() >= 0)
                {
                    value.Output += One();
                    value.Input -= Multiplier();
                }
            }
            catch(Exception ex)
            {
                WriteLogFile.WriteLog("ConsoleLog", String.Format("{0} @ {1}", "Error occured: " + ex.Message, DateTime.Now));
            }
        }

        public abstract string One();
        public abstract string Four();
        public abstract string Five();
        public abstract string Nine();
        public abstract int Multiplier();
    }
}
