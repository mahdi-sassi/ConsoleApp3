using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public static class testExpression
    {
        public static Expression StringEqual(expressionn expressionn)
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
        public static bool intEqual(expressionn expressionn)
        {

            return true;
        }
    }
}
