using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using DynamicExpressionBuilder.Enums;
using DynamicExpressionBuilder.Models;
namespace ConsoleApp3
{
    class Program
    {
        //static int? GetNullableInt()
        //{
        //    return null;
        //}

        //static string GetStringValue()
        //{
        //    return "aaa";
        //}

       
        static void  Main(string[] args)
        {

            //string[] s = vendors.GetType().GetFields().
            #region
            //        //    List
            //        //    <Login> list1 = new List<Login>(4) {
            //        //    new Login()
            //        //{
            //        //    username="xxx",
            //        //    password="xxx",
            //        //    code="xxx"
            //        //},
            //        // new Login()
            //        //{
            //        //    username = "xxx",
            //        //    password = "xxx",
            //        //    code = "xxx"
            //        //},
            //        // new Login()
            //        //{
            //        //    username = "xxx",
            //        //    password = "xxx",
            //        //    code = "xxx"
            //        //},
            //        //new Login()
            //        //{
            //        //    username = "xxx",
            //        //    password = "xxx",
            //        //    code = "xxx"
            //        //}};
            //        //    IQueryable<Login> logins = list1.AsQueryable();
            //            //SendLogin log = new SendLogin();
            //            //log.SendRequestAsync();


            //            //string strPassword = "Root-123";

            //            //byte[] bytePassword = Encoding.ASCII.GetBytes(strPassword);
            //            //Hash hash = new Hash();
            //            //byte[] AsciiByteHashPassword = hash.Encrypt(ref bytePassword);
            //            //string a =Encoding.ASCII.GetString(AsciiByteHashPassword);
            //            //byte[] b = Encoding.ASCII.GetBytes(a);
            //            //byte[] xxx = hash.Encrypt(ref b);
            //            //string strings = Encoding.ASCII.GetString(xxx);
            //            //Console.WriteLine(strings);
            //            //Console.ReadLine();
            //            //Console.WriteLine(BitConverter.ToString(bytePassword));
            //            //Console.ReadLine();
            //            //string s = BitConverter.ToString(AsciiByteHashPassword);
            //            //string hashpass = "";

            //            //for (int i = 0; i < s.Length; i=i+3)
            //            //{
            //            //    string x = s.Substring(i,  2);
            //            //    long n1 = Int64.Parse(x.ToString(), System.Globalization.NumberStyles.HexNumber);
            //            //    hashpass = hashpass + n1.ToString()+"-";
            //            //}

            //            //Console.WriteLine(BitConverter.ToString(AsciiByteHashPassword));
            //            //Console.ReadLine();


            //            //string s1 = "C8";
            //            //long n = Int64.Parse(s1, System.Globalization.NumberStyles.HexNumber);
            //            //int intValue = 200;
            //            //// Convert integer 182 as a hex in a string variable
            //            //string hexValue = intValue.ToString("X");
            //            ////byte[] c = new byte[8];
            //            ////c[1] = Convert.ToByte(n.ToString(), 16);

            //            //int num = 45;
            //            //int bcdNum = 16 * (num / 10) + (num % 10);
            //            //byte[] intBytes = BitConverter.GetBytes(n);
            //            //Array.Reverse(intBytes);
            //            //byte[] result = intBytes;


            //            //string value = intValue.ToString("X");
            //            //// Convert it back to a number.
            //            //try
            //            //{
            //            //    byte number = Convert.ToByte(value, 16);
            //            //    int intAgain = int.Parse(value, System.Globalization.NumberStyles.HexNumber);
            //            //    Console.WriteLine("0x{0} converts to {1}.", value, number);
            //            //    Console.ReadLine();
            //            //}
            //            //catch (OverflowException)
            //            //{
            //            //    Console.WriteLine("Unable to convert '0x{0}' to a byte.", value);
            //            //    Console.ReadLine();
            //            //}
            //            //byte xxx = Convert.ToByte('A');


            //            //string result = System.Text.Encoding.UTF8.GetString(AsciiByteHashPassword);
            //            //string Asciitostring = BitConverter.ToString(AsciiByteHashPassword).Replace("-","");
            //            //bytePassword = Encoding.ASCII.GetBytes(result);
            //            //byte[] ResultAsciiByteHashPassword=hash.Encrypt(ref bytePassword);
            //            //Console.WriteLine(BitConverter.ToString(ResultAsciiByteHashPassword));
            //            //Console.ReadLine();
            //            ////Console.WriteLine(BitConverter.ToString(AsciiByteHashPassword));
            //            ////Console.ReadLine();
            //            ////string AsciiStrHashPassword = BitConverter.ToString(AsciiByteHashPassword).Replace("-","");
            //            //// Console.WriteLine( BitConverter.ToString(x));
            //            ////Console.WriteLine(x3);


            //            //Login login = new Login()
            //            //{
            //            //    //code = code,
            //            //    hashPassword = hashpass,
            //            //    password = "Root-123",
            //            //    username = "Test@root.sa"
            //            //};
            //            //SendLogin sl = new SendLogin();
            //            //sl.postAsync(login);


            //            //SendLogin s1 = new SendLogin();
            //            //object x =s1.changeValue(c => c.code == "cccc");
            //            //Console.WriteLine(x.ToString());
            //            //Console.ReadLine();
            //            //string ch1 = "{\n\t\"username\":\"test@root.sa\",\n\t\"password\":\"Root-123\",\n\t\"hashPassword\":\"" + hashpass + "\"\n}";

            //            //var client = new RestClient("http://localhost:63338/api/Account/Login");
            //            //var request = new RestRequest(Method.POST);
            //            //request.AddHeader("postman-token", "fc4e93f3-4ec0-afde-2b71-94fc8b9808e4");
            //            //request.AddHeader("cache-control", "no-cache");
            //            //request.AddHeader("content-type", "application/json");
            //            //request.AddParameter("application/json", ch1, ParameterType.RequestBody);
            //            //IRestResponse response = client.Execute(request);






            //            //expressionn expressionn = new expressionn()
            //            //{
            //            //    compare = "==",
            //            //    propriety = "Code",
            //            //    value = 10
            //            //};
            //            //Expression ex =expressionn.Express(expressionn);

            //            string[] companies = { "Consolidated Messenger", "Alpine Ski House", "Southridge Video", "City Power & Light",
            //                               "Coho Winery", "Wide World Importers", "Graphic Design Institute", "Adventure Works",
            //                               "Humongous Insurance", "Woodgrove Bank", "Margie's Travel", "Northwind Traders",
            //                               "Blue Yonder Airlines", "Trey Research", "The Phone Company",
            //                               "Wingtip Toys", "Lucerne Publishing", "Fourth Coffee" };

            //            // The IQueryable data to query.
            //            IQueryable<String> queryableData = companies.AsQueryable<string>();

            //            // Compose the expression tree that represents the parameter to the predicate.
            //            ParameterExpression pe = Expression.Parameter(typeof(string), "company");
            //            ParameterExpression pe1 = Expression.Parameter(typeof(string), "c");
            //            Expression left1 = Expression.Constant("code");
            //            Expression right1 = Expression.Constant("123456");
            //            Expression e11 = Expression.Equal(left1, right1);
            //            //ParameterExpression pe1 = Expression.Parameter(typeof(Login), "c");
            //            //List<string> list = new List<string>() { "code", "==", "123456", "userName", "Containt", "a" };
            //            //for (int i = 0; i < list.Count; i=i+3)
            //            //{
            //            //    Expression left1 = Expression.
            //            //    Expression left111 = Expression.Call(pe1,);
            //            //    Expression right1= Expression.Constant("coho winery");
            //            //    Expression e11 = Expression.Equal(left1, right1);
            //            //}
            //            // ***** Where(company => (company.ToLower() == "coho winery" || company.Length > 16)) *****
            //            // Create an expression tree that represents the expression 'company.ToLower() == "coho winery"'.
            //            Expression left = Expression.Call(pe, typeof(string).GetMethod("ToLower", System.Type.EmptyTypes));
            //            Expression right = Expression.Constant("coho winery");
            //            Expression e1 = Expression.Equal(left, right);

            //            // Create an expression tree that represents the expression 'company.Length > 16'.
            //            left = Expression.Property(pe, typeof(string).GetProperty("Length"));
            //            right = Expression.Constant(16, typeof(int));
            //            Expression e2 = Expression.GreaterThan(left, right);

            //            // Combine the expression trees to create an expression tree that represents the 
            //            // expression '(company.ToLower() == "coho winery" || company.Length > 16)'.
            //            Expression predicateBody = Expression.OrElse(e1, e2);

            //            // Create an expression tree that represents the expression 
            //            // 'queryableData.Where(company => (company.ToLower() == "coho winery" || company.Length > 16))'
            //            MethodCallExpression whereCallExpression = Expression.Call(
            //                typeof(Queryable),
            //                "Where",
            //                new Type[] { queryableData.ElementType },
            //                queryableData.Expression,
            //                Expression.Lambda<Func<string, bool>>(predicateBody, new ParameterExpression[] { pe }));
            //            // ***** End Where ***** 

            //            // ***** OrderBy(company => company) ***** 
            //            // Create an expression tree that represents the expression 
            //            // 'whereCallExpression.OrderBy(company => company)'
            //            MethodCallExpression orderByCallExpression = Expression.Call(
            //                typeof(Queryable),
            //                "OrderBy",
            //                new Type[] { queryableData.ElementType, queryableData.ElementType },
            //                whereCallExpression,
            //                Expression.Lambda<Func<string, string>>(pe, new ParameterExpression[] { pe }));
            //            // ***** End OrderBy ***** 

            //            // Create an executable query from the expression tree.
            //            IQueryable<string> results = queryableData.Provider.CreateQuery<string>(orderByCallExpression);

            //            // Enumerate the results. 
            //            foreach (string company in results)
            //                Console.WriteLine(company);
            //       



            //string UrlApi = "http://localhost:55574/api/vendors";
            //try
            //{
            //    var getUrl = UrlApi;
            //    var s = nameof(Vendors.DescriptionAr);
            //    var httpClient = new HttpClient();

            //    //Set token in the Header of the request

            //    //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_token.TokenType, _token.AccessToken);
            //    IEnumerable<string> headerValues = new List<string>() { "aa", "bb", "cc", "dd", "ee", "ff" };
            //    httpClient.DefaultRequestHeaders.Add("PropertyName", s);
            //    httpClient.DefaultRequestHeaders.Add("Operand", "And");
            //    httpClient.DefaultRequestHeaders.Add("Operation", "Contains");
            //    httpClient.DefaultRequestHeaders.Add("Value", "zzz");
            //    //Get Data from the Api in JSON Format
            //    var json = httpClient.GetAsync(getUrl).Result.Content.ToString();

            //    //Deserialize the request response to "IEnumerable<T>" 
            //    var result = JsonConvert.DeserializeObject<IEnumerable<Vendors>>(json);

            //    //SaveDataLocal(result.ToList());

            //    Console.WriteLine(result);
            //    Console.ReadLine();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    throw new Exception(e.Message, e.InnerException);
            //}
            ////var expressionList = new List<ExpressionInput>
            ////    {
            ////        new ExpressionInput
            ////        {
            ////            Operand = QueryOperand.And, //First Item does not matter And or OR
            ////            Operation = Operation.Contains,
            ////            PropertyName = "username",
            ////            Value = "Jack"
            ////        }
            ////    };
            ////new ExpressionInput
            ////{
            ////    Operand = QueryOperand.Or,
            ////    Operation = Operation.NotEquals,
            ////    PropertyName = "isDeleted",
            ////    Value = false
            ////},
            ////new ExpressionInput
            ////{
            ////    Operand = QueryOperand.And,
            ////    Operation = Operation.GreaterThanOrEqual,
            ////    PropertyName = "code",
            ////    Value = (int)500000 //Value need to be parsed to Expression's object (T) type. Here T is of Citizen type and AnnualIncome is of double type.
            ////}
            ////};

            ////var expressionList = ExpressionInputGenerator.GetExpressionInputList();

            //Expression<Func<Login, bool>> expression = DynamicExpressionBuilder.ExpressionBuilder.GetExpression<Login>(expressionList); //Passing to expression builder. Here we are getting expression of Type Citizen
            //Console.WriteLine($"Final Expression = {expression.ToString()}");
            //Console.ReadLine();
            #endregion

            var listExpressions = new Expressions();
            listExpressions.Expression = new List<ExpressionInput>
            {
                new ExpressionInput
                {
                    Operand=QueryOperand.And,
                    Operation=Operation.Contains,
                    PropertyName="DescriptionAr",
                    Value="zzz",
                    Order=null
                }
            };
            listExpressions.Include = new List<ExpressionInput>
            {
                new ExpressionInput
                {
                    PropertyName="VendorsCategories",
                    Order=null,
                    Operand=null,
                    Operation=null,
                    Value=null,
                }
            };
            listExpressions.OrderBy = new List<ExpressionInput>
            {
                new ExpressionInput
                {
                    PropertyName="NameEn",
                    Order=Order.Descending,
                    Operation=null,
                    Operand=null,
                    Value=null
                }
            };
            listExpressions.skip = 1;
            listExpressions.tacke = 2;

            string UrlApi = "http://localhost:55574/api/vendors";
            try
            {
                //var s = nameof(Vendors.DescriptionAr);
                var httpClient = new HttpClient();

                //Set token in the Header of the request
                string output = JsonConvert.SerializeObject(listExpressions);
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_token.TokenType, _token.AccessToken);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Add("Expressions", output);
                //Get Data from the Api in JSON Format
                var json = httpClient.GetStringAsync(UrlApi).Result;

                //Deserialize the request response to "IEnumerable<T>" 
                var result = JsonConvert.DeserializeObject<IEnumerable<Vendors>>(json);

                //SaveDataLocal(result.ToList());

                Console.WriteLine(result);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception(e.Message, e.InnerException);
            }
        }
    }
    }
    