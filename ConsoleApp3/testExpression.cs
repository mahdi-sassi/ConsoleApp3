using BuilderExpression;
using BuilderExpression.Enums;
using BuilderExpression.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public  class testExpression<T>
    {
        //public unsafe void Xx()
        //{
        //    int x = 10;
        //    int y = 20;
        //    int* sum = &x;
        //    Console.WriteLine(*sum);
        //}
        public  Expression StringEqual(expressionn expressionn)
        {
            //string[] companies = { "Consolidated Messenger", "Alpine Ski House", "Southridge Video", "City Power & Light",
            //                   "Coho Winery", "Wide World Importers", "Graphic Design Institute", "Adventure Works",
            //                   "Humongous Insurance", "Woodgrove Bank", "Margie's Travel", "Northwind Traders",
            //                   "Blue Yonder Airlines", "Trey Research", "The Phone Company",
            //                   "Wingtip Toys", "Lucerne Publishing", "Fourth Coffee" };
            // The IQueryable data to query.
            //IQueryable<String> queryableData = companies.AsQueryable<string>();
            ParameterExpression pe = Expression.Parameter(typeof(string), "company");
            Expression left = Expression.Call(pe, typeof(string).GetMethod("ToLower", System.Type.EmptyTypes));
            Expression right = Expression.Constant("coho winery");
            Expression e1 = Expression.Equal(left, right);
            left = Expression.Property(pe, typeof(string).GetProperty("Length"));
            right = Expression.Constant(16, typeof(int));
            Expression e2 = Expression.GreaterThan(left, right);
            Expression predicateBody = Expression.OrElse(e1, e2);
            //MethodCallExpression whereCallExpression = Expression.Call(
            //    typeof(Queryable),
            //    "Where",
            //    new Type[] { Logins.ElementType },
            //    Logins.Expression,
            //    Expression.Lambda<Func<string, bool>>(predicateBody, new ParameterExpression[] { pe }));
            //MethodCallExpression orderByCallExpression = Expression.Call(
            //     typeof(Queryable),
            //     "OrderBy",
            //     new Type[] { queryableData.ElementType, queryableData.ElementType },
            //     whereCallExpression,
            //     Expression.Lambda<Func<string, string>>(pe, new ParameterExpression[] { pe }));
            return e2;
        }
        public bool intEqual(expressionn expressionn)
        {
            return true;
        }
        public ExpressionInput getExpressionInput(string expressionStr)
        {
            //switch(contain(expressionStr,"=="))
            //{
            //    case true:
            //        return 
            //}
            
            ExpressionInput expressionInput = new ExpressionInput();
            if (expressionStr.Contains("=="))
            {
                string result = expressionStr;
                int start= result.LastIndexOf('=')+1;
                int length = result.Length;               
                expressionInput.PropertyName = result.Substring(0,result.IndexOf('=')).Trim() ; 
                expressionInput.Value = result.Substring(start, (length - start)).Trim().Trim(')').Trim('\"');
                expressionInput.Operation = Operation.Equals;
            }
            else if(expressionStr.Contains("<="))
            {
                string result = expressionStr;
                int start = result.LastIndexOf('=') + 1;
                int length = result.Length;
                expressionInput.PropertyName = result.Substring(0, result.IndexOf('<')).Trim();
                expressionInput.Value = result.Substring(start, (length - start)).Trim().Trim(')').Trim('\"');
                expressionInput.Operation = Operation.LessThanOrEqual;
            }
            else if (expressionStr.Contains(">="))
            {
                string result = expressionStr;
                int start = result.LastIndexOf('=') + 1;
                int length = result.Length;
                expressionInput.PropertyName = result.Substring(0, result.IndexOf('>')).Trim();
                expressionInput.Value = result.Substring(start, (length - start)).Trim().Trim(')').Trim('\"');
                expressionInput.Operation = Operation.GreaterThanOrEqual;
            }
            else if (expressionStr.Contains("<"))
            {
                string result = expressionStr;
                int start = result.LastIndexOf('<') + 1;
                int length = result.Length;
                expressionInput.PropertyName = result.Substring(0, result.IndexOf('<')).Trim();
                expressionInput.Value = result.Substring(start, (length - start)).Trim().Trim(')').Trim('\"');
                expressionInput.Operation = Operation.LessThan;
            }
            else if (expressionStr.Contains(">"))
            {
                string result = expressionStr;
                int start = result.LastIndexOf('>') + 1;
                int length = result.Length;
                expressionInput.PropertyName = result.Substring(0, result.IndexOf('>')).Trim();
                expressionInput.Value = result.Substring(start, (length - start)).Trim().Trim(')').Trim('\"');
                expressionInput.Operation = Operation.GreaterThan;
            }
            else if (expressionStr.Contains("!="))
            {
                string result = expressionStr;
                int start = result.LastIndexOf('=') + 1;
                int length = result.Length;
                expressionInput.PropertyName = result.Substring(0, result.IndexOf('!')).Trim();
                expressionInput.Value = result.Substring(start, (length - start)).Trim().Trim(')').Trim('\"');
                expressionInput.Operation = Operation.NotEquals;
            }
            return expressionInput;
        }
        public List<string> subStringExpression(string expressionStr)
        {
            #region
            //int x = 0;
            //int y = 0;
            //for (int i = expressionStr.IndexOf('>')+1; i < expressionStr.Length; i++)
            //{
            //    if(expressionStr[i]!=' ')
            //    {
            //        expressionStr = expressionStr.Substring(i);
            //        return null;
            //    }
            //}
            //int AndIndex = expressionStr.IndexOf("AndAlso");
            //int OrIndex = expressionStr.IndexOf("OrElse");
            //int length;
            //if (OrIndex <= AndIndex)
            //    length = OrIndex;
            //else
            //    length = AndIndex;
            //for (int i = 0; i < length; i++)
            //{
            //    if (expressionStr[i] == '(')
            //        x++;
            //    if (expressionStr[i] == ')')
            //        y++;
            //}

            //List<string> result = new List<string>();
            //int start = 0;
            //int end = 0;
            //for (int i = 0; i < expressionStr.Length; i++)
            //{
            //    if(end==0)
            //    {
            //        if (expressionStr[i] == '(')
            //            start = i;
            //        if (expressionStr[i] == ')')
            //            end = i;
            //    }
            //    else
            //    {
            //        result.Add(expressionStr.Substring(start,(end+1)-start));
            //        expressionStr = expressionStr.Remove(start, (end+1) - start);
            //        end = 0;
            //        i = 0;
            //    }
            //}
            //expressionStr = expressionStr.Substring(expressionStr.IndexOf('(')+1);
            ////expressionStr = expressionStr.Trim('(');
            ////expressionStr = expressionStr.Trim(')');
            //expressionStr = expressionStr.Replace("\t", " ");
            //expressionStr = expressionStr.Replace("OrElse", "\t");
            //expressionStr = expressionStr.Replace("AndAlso", "\t");
            //string[] xx = expressionStr.Split('\t');

            //if (expressionStr.Contains("OrElse"))
            //{
            //    int x1 = expressionStr.IndexOf("OrElse");
            //    result.Add(expressionStr.Substring(0, x1));
            //    result.Add(expressionStr.Substring(x1, (expressionStr.Length - result.Last().Length)));
            //}
            ////if (expressionStr.Contains("AndAlso"))
            ////{
            ////    int x = expressionStr.IndexOf("AndAlso");
            ////    result.Add(expressionStr.Substring(0, x));
            ////    result.Add(expressionStr.Substring(x, (expressionStr.Length-result.Last().Length)));
            ////}
            #endregion
            expressionStr = expressionStr.Substring(5, expressionStr.Length - 5);
            if (expressionStr.StartsWith("(")&& expressionStr.EndsWith(")"))
            {
                expressionStr = expressionStr.Substring(1, expressionStr.Length - 2);
            }
            int indexOfAndAlso = expressionStr.IndexOf("AndAlso");
            int indexOfOrElse = expressionStr.IndexOf("OrElse");
            string strAndAlso = expressionStr.Substring(0,indexOfAndAlso+7);
            string strOrElse = expressionStr.Substring(0,indexOfOrElse+6);
            List<string> result = new List<string>();
            string ch = "";
            int x = expressionStr.IndexOf('(');
            int y = 1;
            int length = 0;
            if(x>-1)
            {
                for (int i = x+1; i < expressionStr.Length; i++)
                {
                    if(y>0)
                    {
                        if(expressionStr[i]=='(')
                        {
                            y++;
                        }
                        else if(expressionStr[i] == ')')
                        {
                            y--;
                            length = i;
                        }
                    }
                    if(y==0)
                    {
                        ch = expressionStr.Substring(x, length - x);
                        result.Add(ch);
                        return null ;
                    }
                }
                subStringExpression(ch);
            }

            return result;
        }
        public List<Expression> readerExpression(Expression<Func<T,bool>> expression)
        {
                    Expression OrElseLeft=null;
                    Expression OrElseRight=null;
                    Expression AndAlsoLeft = null;
                    Expression AndAlsoRight = null;
                    List<Expression> list = null;
            var binaryExpression = expression as BinaryExpression ;
            MemberExpression member; ConstantExpression constant;
            switch (expression.NodeType)
            {
                case ExpressionType.AndAlso:
                    if(binaryExpression!=null)
                    {
                        
                        AndAlsoLeft = binaryExpression.Left as Expression;
                        AndAlsoRight = binaryExpression.Right as Expression;
                        list.Add(AndAlsoLeft);
                        list.Add(AndAlsoRight);
                        return list;
                    }
                    return null;
                case ExpressionType.OrElse:
                    var OrElsebinaryExpression = expression as BinaryExpression;
                    if (OrElsebinaryExpression != null)
                    {
                        OrElseLeft = OrElsebinaryExpression.Left as Expression<Func<T, bool>>;
                        OrElseRight = OrElsebinaryExpression.Right as Expression<Func<T, bool>>;
                        list.Add(OrElseLeft);
                        list.Add(OrElseRight);
                        return list;
                    }
                    return null;
                    #region
                    //case ExpressionType.Add:
                    //    return null;
                    //case ExpressionType.AddChecked:
                    //    return null;
                    //case ExpressionType.And:
                    //    return null;

                    //case ExpressionType.ArrayLength:
                    //    return null;
                    //case ExpressionType.ArrayIndex:
                    //    return null;
                    //case ExpressionType.Call:
                    //    var callBinaryExpression = expression ;

                    //    if (callBinaryExpression != null)
                    //    {
                    //        var methode = callBinaryExpression.Type;
                    //    }
                    //    return null;
                    //case ExpressionType.Coalesce:
                    //    return null;
                    //case ExpressionType.Conditional:
                    //    return null;
                    //case ExpressionType.Constant:
                    //    return null;
                    //case ExpressionType.Convert:
                    //    return null;
                    //case ExpressionType.ConvertChecked:
                    //    return null;
                    //case ExpressionType.Divide:
                    //    return null;
                    //case ExpressionType.Equal:
                    //    var equalBinaryExpression = expression as BinaryExpression;
                    //    if(equalBinaryExpression!=null)
                    //    {
                    //        member = equalBinaryExpression.Left as MemberExpression;
                    //        constant = equalBinaryExpression.Right as ConstantExpression;
                    //    }
                    //        return null;
                    //case ExpressionType.ExclusiveOr:
                    //    return null;
                    //case ExpressionType.GreaterThan:
                    //    return null;
                    //case ExpressionType.GreaterThanOrEqual:
                    //    return null;
                    //case ExpressionType.Invoke:
                    //    return null;
                    //case ExpressionType.Lambda:
                    //    return null;
                    //case ExpressionType.LeftShift:
                    //    return null;
                    //case ExpressionType.LessThan:
                    //    return null;
                    //case ExpressionType.LessThanOrEqual:
                    //    return null;
                    //case ExpressionType.ListInit:
                    //    return null;
                    //case ExpressionType.MemberAccess:
                    //    return null;
                    //case ExpressionType.MemberInit:
                    //    return null;
                    //case ExpressionType.Modulo:
                    //    return null;
                    //case ExpressionType.Multiply:
                    //    return null;
                    //case ExpressionType.MultiplyChecked:
                    //    return null;
                    //case ExpressionType.Negate:
                    //    return null;
                    //case ExpressionType.UnaryPlus:
                    //    return null;
                    //case ExpressionType.NegateChecked:
                    //    return null;
                    //case ExpressionType.New:
                    //    return null;
                    //case ExpressionType.NewArrayInit:
                    //    return null;
                    //case ExpressionType.NewArrayBounds:
                    //    return null;
                    //case ExpressionType.Not:
                    //    return null;
                    //case ExpressionType.NotEqual:
                    //    return null;
                    //case ExpressionType.Or:
                    //    return null;
                    //case ExpressionType.Parameter:
                    //    return null;
                    //case ExpressionType.Power:
                    //    return null;
                    //case ExpressionType.Quote:
                    //    return null;
                    //case ExpressionType.RightShift:
                    //    return null;
                    //case ExpressionType.Subtract:
                    //    return null;
                    //case ExpressionType.SubtractChecked:
                    //    return null;
                    //case ExpressionType.TypeAs:
                    //    return null;
                    //case ExpressionType.TypeIs:
                    //    return null;
                    //case ExpressionType.Assign:
                    //    return null;
                    //case ExpressionType.Block:
                    //    return null;
                    //case ExpressionType.DebugInfo:
                    //    return null;
                    //case ExpressionType.Decrement:
                    //    return null;
                    //case ExpressionType.Dynamic:
                    //    return null;
                    //case ExpressionType.Default:
                    //    return null;
                    //case ExpressionType.Extension:
                    //    return null;
                    //case ExpressionType.Goto:
                    //    return null;
                    //case ExpressionType.Increment:
                    //    return null;
                    //case ExpressionType.Index:
                    //    return null;
                    //case ExpressionType.Label:
                    //    return null;
                    //case ExpressionType.RuntimeVariables:
                    //    return null;
                    //case ExpressionType.Loop:
                    //    return null;
                    //case ExpressionType.Switch:
                    //    return null;
                    //case ExpressionType.Throw:
                    //    return null;
                    //case ExpressionType.Try:
                    //    return null;
                    //case ExpressionType.Unbox:
                    //    return null;
                    //case ExpressionType.AddAssign:
                    //    return null;
                    //case ExpressionType.AndAssign:
                    //    return null;
                    //case ExpressionType.DivideAssign:
                    //    return null;
                    //case ExpressionType.ExclusiveOrAssign:
                    //    return null;
                    //case ExpressionType.LeftShiftAssign:
                    //    return null;
                    //case ExpressionType.ModuloAssign:
                    //    return null;
                    //case ExpressionType.MultiplyAssign:
                    //    return null;
                    //case ExpressionType.OrAssign:
                    //    return null;
                    //case ExpressionType.PowerAssign:
                    //    return null;
                    //case ExpressionType.RightShiftAssign:
                    //    return null;
                    //case ExpressionType.SubtractAssign:
                    //    return null;
                    //case ExpressionType.AddAssignChecked:
                    //    return null;
                    //case ExpressionType.MultiplyAssignChecked:
                    //    return null;
                    //case ExpressionType.SubtractAssignChecked:
                    //    return null;
                    //case ExpressionType.PreIncrementAssign:
                    //    return null;
                    //case ExpressionType.PreDecrementAssign:
                    //    return null;
                    //case ExpressionType.PostIncrementAssign:
                    //    return null;
                    //case ExpressionType.PostDecrementAssign:
                    //    return null;
                    //case ExpressionType.TypeEqual:
                    //    return null;
                    //case ExpressionType.OnesComplement:
                    //    return null;
                    //case ExpressionType.IsTrue:
                    //    return null;
                    //case ExpressionType.IsFalse:
                    //    return null;
                    //default:
                    //    return null;
                    #endregion


            }
            return null;
        }
        public object Recursive(Expression<Func<T,bool>>obj)
        {
            List<Expression> list = null;
            if(list!=null)
            {
                foreach (var item in list)
                {

                }
            }
            if (obj.ToString().Contains("AndAlso") || obj.ToString().Contains("OrElse"))
            {
                 list = readerExpression(obj);
            }
            else
            {
            }
            return Recursive(null);
        }
    }
}
