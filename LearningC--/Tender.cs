using System.Linq.Expressions;

namespace LearningC__.OtherStuff
{
    internal class Tender
    {
        /// <summary>
        /// NB instead of using the .NET Func<string> delegate you can declare your own
        /// This has the same signature as Func<string>
        /// </summary>
        /// <returns></returns>
        public delegate string GetMessage();

        private void PrintMessage(GetMessage getMessage)
        {
            var message = getMessage();
            Console.WriteLine(message);
        }

        public void UseMethod()
        {
            // Note the GetMessageMethod method isn't being called here - no '()'
            // The method itself is being passed to PrintMessage
            PrintMessage(GetMessageMethod);
        }

        // 1. Use a method
        private string GetMessageMethod()
        {
            return "I am a method";
        }

        // 2. Use old-style delegate declaration (C# 2)
        public void UseDelegate()
        {
            GetMessage functionOldStyle = delegate () { return "I am a function declared using the old style."; };
            PrintMessage(functionOldStyle);
        }

        // 3. Use a lambda expression (C# 3)
        public void UseLambda()
        {
            GetMessage lambda = () => "I am a lambda expression.";
            PrintMessage(lambda);
        }

        // 4. Use an in-line lambda expression
        public void UseInlineLambda()
        {
            PrintMessage(() => "I am an inline lambda expression.");
        }

        // 5. Use a local function (C# 7)
        public void UseLocalFunction()
        {
            string localFunction() => "I am a local function.";
            PrintMessage(localFunction);
        }

        // 6. Use a compiled expression tree
        public void UseExpression()
        {
            Expression<GetMessage> expressionTree = () => "I am an expression tree.";
            // note the call to Compile() - converts Expression<Func<T>> to Func<T>
            PrintMessage(expressionTree.Compile());
        }
    }
}




