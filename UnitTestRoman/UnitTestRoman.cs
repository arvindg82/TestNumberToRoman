using BusinessLogic;
using BusinessObject;

namespace UnitTestRoman
{
    public class UnitTestRoman
    {       
        
        [Fact]
        public void Roman_1_I()
        {
            Context ctx = new Context(1);
            var parser = new NumberToRomanParser();
            parser.Interpret(ctx);
            Assert.Equal("I", ctx.Output);
        }

        [Fact]
        public void Roman_2_II()
        {
            Context ctx = new Context(2);
            var parser = new NumberToRomanParser();
            parser.Interpret(ctx);
            Assert.Equal("II", ctx.Output);
        }

        [Fact]
        public void Roman_3_III()
        {
            Context ctx = new Context(3);
            var parser = new NumberToRomanParser();
            parser.Interpret(ctx);
            Assert.Equal("III", ctx.Output);
        }

        [Fact]
        public void Roman_4_IV()
        {
            Context ctx = new Context(4);
            var parser = new NumberToRomanParser();
            parser.Interpret(ctx);
            Assert.Equal("IV", ctx.Output);
        }

        [Fact]
        public void Roman_5_V()
        {
            Context ctx = new Context(5);
            var parser = new NumberToRomanParser();
            parser.Interpret(ctx);
            Assert.Equal("V", ctx.Output);
        }
        /// <summary>
        /// Negative Testing
        /// </summary>
        [Fact]
        public void Roman_9_IX()
        {
            Context ctx = new Context(9);
            var parser = new NumberToRomanParser();
            parser.Interpret(ctx);
            Assert.NotEqual("IXI", ctx.Output);
        }

        [Fact]
        public void Roman_10_X()
        {
            Context ctx = new Context(10);
            var parser = new NumberToRomanParser();
            parser.Interpret(ctx);
            Assert.Equal("X", ctx.Output);
        }

        [Fact]
        public void Roman_49_XLIX()
        {
            Context ctx = new Context(49);
            var parser = new NumberToRomanParser();
            parser.Interpret(ctx);
            Assert.Equal("XLIX", ctx.Output);
        }

        [Fact]
        public void Roman_50_L()
        {
            Context ctx = new Context(50);
            var parser = new NumberToRomanParser();
            parser.Interpret(ctx);
            Assert.Equal("L", ctx.Output);
        }

        [Fact]
        public void Roman_100_C()
        {
            Context ctx = new Context(100);
            var parser = new NumberToRomanParser();
            parser.Interpret(ctx);
            Assert.Equal("C", ctx.Output);
        }

        [Fact]
        public void Roman_400_CD()
        {
            Context ctx = new Context(400);
            var parser = new NumberToRomanParser();
            parser.Interpret(ctx);
            Assert.Equal("CD", ctx.Output);
        }

        [Fact]
        public void Roman_500_D()
        {
            Context ctx = new Context(500);
            var parser = new NumberToRomanParser();
            parser.Interpret(ctx);
            Assert.Equal("D", ctx.Output);
        }

        [Fact]
        public void Roman_900_CM()
        {
            Context ctx = new Context(900);
            var parser = new NumberToRomanParser();
            parser.Interpret(ctx);
            Assert.Equal("CM", ctx.Output);
        }

        [Fact]
        public void Roman_1000_M()
        {
            Context ctx = new Context(1000);
            var parser = new NumberToRomanParser();
            parser.Interpret(ctx);
            Assert.Equal("M", ctx.Output);
        }

        [Fact]
        public void Roman_11984_XMCMLXXXIV()
        {
            Context ctx = new Context(11984);
            var parser = new NumberToRomanParser();
            parser.Interpret(ctx);
            Assert.Equal("XMCMLXXXIV", ctx.Output);
        }
        [Fact]
        public void Roman_1903_MCMIII()
        {
            Context ctx = new Context(1903);
            var parser = new NumberToRomanParser();
            parser.Interpret(ctx);
            Assert.Equal("MCMIII", ctx.Output);
        }
    }
}