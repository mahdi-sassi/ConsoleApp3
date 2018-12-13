using Serialize.Linq.Interfaces;
using Serialize.Linq.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public static class JsonDeserializeExpression<T> where T : class
    {
        public static string SerializeWhere(Expression json)
        {
            string expression = null;
            foreach (var textSerializer in new ITextSerializer[] { new Serialize.Linq.Serializers.JsonSerializer() })
            {
                //json = json.Replace("BrandFullMobile.Model", "WebServices.ViewModels");
                try
                {
                    var serializer = new ExpressionSerializer(textSerializer);
                    expression = serializer.SerializeText(json);
                }
                catch (Exception e)
                {
                    return null;
                }
            }
            return expression;
        }

        public static Expression<Func<T, bool>> DeserializeWhere(string json)
        {
            Expression<Func<T, bool>> expression = null;
            foreach (var textSerializer in new ITextSerializer[] { new Serialize.Linq.Serializers.JsonSerializer() })
            {
                json = json.Replace("BrandFullMobile.Model", "WebServices.ViewModels");
                try
                {
                    var serializer = new ExpressionSerializer(textSerializer);
                    expression = (Expression<Func<T, bool>>)serializer.DeserializeText(json);
                }
                catch (Exception e)
                {
                    return null;
                }
            }
            return expression;
        }
        public static Expression<Func<T, object>> DeserializeOrderBy(string json)
        {
            Expression<Func<T, object>> expression = null;
            foreach (var textSerializer in new ITextSerializer[] { new Serialize.Linq.Serializers.JsonSerializer() })
            {
                json = json.Replace("WMS.Models.BaseTables", "BLL.Models");
                json = json.Replace("WMS.Models", "WmsPosApi.Models");
                try
                {
                    var serializer = new ExpressionSerializer(textSerializer);
                    expression = (Expression<Func<T, object>>)serializer.DeserializeText(json);
                }
                catch (Exception)
                {
                    return null;
                }

            }
            return expression;
        }
    }
}
