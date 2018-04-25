using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using ConsoleApp3;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace Aq.ExpressionJsonSerializer.Tests
{
    public class ExpressionJsonSerializerTest
    {
        public void Assignment()
        {
            TestExpression((Expression<Func<Context1, int>>) (c => c.A + c.B));
        }

        public void BitwiseAnd()
        {
            TestExpression((Expression<Func<Context1, int>>) (c => c.A & c.B));
        }

        public void LogicalAnd()
        {
            TestExpression((Expression<Func<Context1, bool>>) (c => c.A > 0 && c.B > 0));
        }

        public void ArrayIndex()
        {
            TestExpression((Expression<Func<Context1, int>>) (c => c.Array[0]));
        }

        public void ArrayLength()
        {
            TestExpression((Expression<Func<Context1, int>>) (c => c.Array.Length));
        }

        public void Method()
        {
            TestExpression((Expression<Func<Context1, int>>) (c => c.Method()));
        }

        public void MethodWithArguments()
        {
            TestExpression((Expression<Func<Context1, int>>) (c => c.Method("B")));
        }

        public void Coalesce()
        {
            TestExpression((Expression<Func<Context1, int>>) (c => c.C ?? c.A));
        }

        public void Conditional()
        {
            TestExpression((Expression<Func<Context1, int>>) (c => c.C == null ? c.A : c.B));
        }

        public void Convert()
        {
            TestExpression((Expression<Func<Context1, int>>) (c => (short) (c.C ?? 0)));
        }

        public void Decrement()
        {
            TestExpression((Expression<Func<Context1, int>>) (c => c.A - 1));
        }

        public void DivisionWithCast()
        {
            TestExpression((Expression<Func<Context1, float>>) (c => (float) c.A / c.B));
        }

        public void Equality()
        {
            TestExpression((Expression<Func<Context1, bool>>) (c => c.A == c.B));
        }

        public void Xor()
        {
            TestExpression((Expression<Func<Context1, int>>) (c => c.A ^ c.B));
        }

        public void LinqExtensions()
        {
            TestExpression((Expression<Func<Context1, int>>) (c => c.Array.FirstOrDefault()));
        }

        public void GreaterThan()
        {
            TestExpression((Expression<Func<Context1, bool>>) (c => c.A > c.B));
        }

        public void Increment()
        {
            TestExpression((Expression<Func<Context1, int>>) (c => c.A + 1));
        }

        public void Indexer()
        {
            TestExpression((Expression<Func<Context1, int>>) (c => c["A"]));
        }

        public void Invoke()
        {
            TestExpression((Expression<Func<Context1, int>>) (c => c.Func()));
        }

        public void Constant()
        {
            TestExpression((Expression<Func<Context1, bool>>) (c => false));
        }

        public void Lambda()
        {
            TestExpression((Expression<Func<Context1, int>>) (c => ((Func<Context1, int>) (_ => _.A))(c)));
        }

        public void LeftShift()
        {
            TestExpression((Expression<Func<Context1, int>>) (c => c.A << c.C ?? 0));
        }

        public void PropertyAccess()
        {
            TestExpression((Expression<Func<Context1, int>>) (c => c.B));
        }

        public void Negation()
        {
            TestExpression((Expression<Func<Context1, int>>) (c => -c.A));
        }

        public void New()
        {
            TestExpression((Expression<Func<Context1, object>>) (c => new object()));    
        }

        public void NewWithArguments()
        {
            TestExpression((Expression<Func<Context1, object>>) (c => new String('s', 1)));
        }

        public void InitArray()
        {
            TestExpression((Expression<Func<Context1, int[]>>) (c => new[] { 0 }));
        }

        public void InitEmptyArray()
        {
            TestExpression((Expression<Func<Context1, int[,]>>) (c => new int[3, 2]));
        }

        public void TypeAs()
        {
            TestExpression((Expression<Func<Context1, object>>) (c => c as object));
        }

        public void TypeOf()
        {
            TestExpression((Expression<Func<Context1, bool>>) (c => typeof (Context1) == c.GetType()));
        }

        public void TypeIs()
        {
            TestExpression((Expression<Func<Context1, bool>>) (c => c is object));
        }

        public void MethodResultCast()
        {
            TestExpression((Expression<Func<Context1, int>>) (c => (int) c.Method3()));
        }

        public sealed class Context1
        {
            public int A;
            public int B { get; set; }
            public int? C;
            public string S;
            public List<Vendors> Vendorss { get; set; }
            public int[] Array;
            public int this[string key]
            {
                get
                {
                    switch (key) {
                        case "A": return this.A;
                        case "B": return this.B;
                        case "C": return this.C ?? 0;
                        default: throw new NotImplementedException();
                    }
                }
            }
            public Func<int> Func;
            public int Method() { return this.A; }
            public int Method(string key) { return this[key]; }
            public object Method3() { return this.A; }
        }

        public static void TestExpression(LambdaExpression source)
        {
            var random = new Random();
            int u;
            var Context1 = new Context1 {
                A = random.Next(),
                B = random.Next(),
                C = (u = random.Next(0, 2)) == 0 ? null : (int?) u,
                Array = new[] { random.Next() },
                Func = () => u
            };

            //var settings = new JsonSerializerSettings();
            //settings.Converters.Add(new ExpressionJsonConverter(
            //    Assembly.GetAssembly(typeof (ExpressionJsonSerializerTest))
            //));

            //var json = JsonConvert.SerializeObject(source, settings);
            //var target = JsonConvert.DeserializeObject<LambdaExpression>(json, settings);

            //Assert.AreEqual(
            //    ExpressionResult(source, Context1),
            //    ExpressionResult(target, Context1)
            //);
        }

        private static string ExpressionResult(LambdaExpression expr, Context1 Context1)
        {
            return JsonConvert.SerializeObject(expr.Compile().DynamicInvoke(Context1));
        }
    }
}
