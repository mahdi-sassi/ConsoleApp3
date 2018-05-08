using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using BuilderExpression.Models;
using BuilderExpression.Enums;
using BuilderExpression;
using System.Linq.Expressions;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Remoting.Contexts;
using Aq.ExpressionJsonSerializer;
using System.Reflection;
using Aq.ExpressionJsonSerializer.Tests;
using static Aq.ExpressionJsonSerializer.Tests.ExpressionJsonSerializerTest;
using RestSharp;
using Root.Services.ExpressionJson;
using ConsoleApp3.Models;
using ClassLibrary1;
using System.Text;

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

        public static string TestExpression(LambdaExpression source)
        {
            //var random = new Random();
            //int u;
            //var context = new Context1
            //{
            //    A = random.Next(),
            //    B = random.Next(),
            //    C = (u = random.Next(0, 2)) == 0 ? null : (int?)u,
            //    Array = new[] { random.Next() },
            //    Func = () => u
            //};

            var settings = new JsonSerializerSettings();
            settings.Converters.Add(new ExpressionJsonConverter(
                Assembly.GetAssembly(typeof(ExpressionJsonSerializerTest))
            ));

            var json = JsonConvert.SerializeObject(source, settings);
            var target = JsonConvert.DeserializeObject<LambdaExpression>(json, settings);
            return json;
            //Assert.AreEqual(
            //    ExpressionResult(source, context),
            //    ExpressionResult(target, context)
            //);
        }
        static void  Main(string[] args)
        {

            string strPassword = "123qwe";
            string strUserName = "Admin@root.sa"; 
            byte[] bytePassword = Encoding.ASCII.GetBytes(strPassword);
            byte[] byteUserName = Encoding.ASCII.GetBytes(strUserName);
            Hash hash = new Hash();
            byte[] ByteHashPassword = hash.Encrypt(ref bytePassword);
            byte[] ByteHashUserName = hash.Encrypt(ref byteUserName);
            string base64Password = Convert.ToBase64String(ByteHashPassword);
            string base64UserName = Convert.ToBase64String(ByteHashUserName);
            byte[] b = Convert.FromBase64String(base64Password);
            byte[] xxx = hash.Encrypt(ref b);
            string strings = Encoding.ASCII.GetString(xxx);
            var xhxhx = 0;



            var client = new RestClient("http://localhost:55574/api/account/Login");
            var request = new RestRequest(Method.POST);
            request.AddHeader("postman-token", "58c4b473-b70d-dd4d-973e-82fd80edb2e8");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", "{\n\t\"Grant_Type\":\"password\",\n\t\"Password\":\""+ base64Password+"\",\n\t\"UserName\":\""+base64UserName+"\"\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);




            //Console.WriteLine(strings);
            //Console.ReadLine();
            //Console.WriteLine(BitConverter.ToString(bytePassword));
            //Console.ReadLine();
            //string ss = BitConverter.ToString(ByteHashPassword);
            //string hashpass = "";

            //for (int i = 0; i < ss.Length; i = i + 3)
            //{
            //    string x = ss.Substring(i, 2);
            //    long n1 = Int64.Parse(x.ToString(), System.Globalization.NumberStyles.HexNumber);
            //    hashpass = hashpass + n1.ToString() + "-";
            //}
            //Console.WriteLine(hashpass);
            //Console.ReadLine();

            //Console.WriteLine(BitConverter.ToString(AsciiByteHashPassword));
            //Console.ReadLine();









            List<Vendors> li = new List<Vendors>()
            {
                new Vendors
                {
                    ID=Guid.NewGuid(),
                    UpdatedDate = DateTime.Now,
                    NameAr = "بلابهعبه",
                    NameEn = "dhbkfj"
                },
                new Vendors
                {
                    ID = Guid.NewGuid(),
                    UpdatedDate = DateTime.Now.AddHours(-1),
                    NameAr = "بلابهعبه",
                    NameEn = "dhbkfj"
                }
            };
            IQueryable<Vendors> vendors = li.AsQueryable();

            var expressionJson = new ExpressionJson<Vendors>();
            var jsonString = expressionJson.Serialize((Expression<Func<Vendors, bool>>)(c => c.UpdatedDate<DateTime.Now&&c.IsDeleted==false));
            string s = jsonString;// JsonConvert.SerializeObject(jsonString);
                                  //while(s.Contains("ConsoleApp3.Models.BaseTable"))
                                  //{
                                  //    StringReplace stringReplace = new StringReplace();
                                  //    s = stringReplace.replace(s);
                                  //}
            //s = s.Replace("ConsoleApp3.Models", "WmsPosApi.Models");
            //s = s.Replace("ConsoleApp3", "BLL.Models");
            var IncludeJson = expressionJson.Serialize((Expression<Func<Vendors, object>>)(c => c.VendorsCategories));
            var OrderByJson = expressionJson.Serialize((Expression<Func<Vendors, Object>>)(c => c.UpdatedDate));
            //var jsonString =TestExpression((Expression<Func<Categorys, bool>>)(c => c.Address=="" && c.Name==""));
            //expressionJson.Deserialize(OrderByJson).Reduce


            LambdaExpression or = expressionJson.Deserialize(OrderByJson);
            LambdaExpression exppp = expressionJson.Deserialize(s);
            var v =vendors.Where((Expression<Func<Vendors, bool>>)exppp).OrderBy((Expression<Func<Vendors, Object>>)or).ToList();



            string OrderByString = OrderByJson; //JsonConvert.SerializeObject(OrderByJson);
            //OrderByString = OrderByString.Replace("ConsoleApp3.Models.BaseTable", "BLL.Models");
            //OrderByString = OrderByString.Replace("ConsoleApp3.Models", "WmsPosApi.Models");
            //OrderByString = OrderByString.Replace("ConsoleApp3", "BLL.Models");

            string IncludeString = IncludeJson;// JsonConvert.SerializeObject(IncludeJson);
            //IncludeString = IncludeString.Replace("ConsoleApp3.Models.BaseTable", "BLL.Models");
            //IncludeString = IncludeString.Replace("ConsoleApp3.Models", "WmsPosApi.Models");
            //IncludeString = IncludeString.Replace("ConsoleApp3", "BLL.Models");


            InputExpressions inputExpressions = new InputExpressions();
            inputExpressions.Expression = s;
            inputExpressions.Includes = new List<string>();
            inputExpressions.OrderBy = new List<string>();
            //inputExpressions.Includes.Add(IncludeString);
            //inputExpressions.OrderBy.Add(OrderByString);
            inputExpressions.Skip = 0;
            inputExpressions.Take = 0;

            string input = JsonConvert.SerializeObject(inputExpressions);
            //input = input.Replace("ConsoleApp3", "WmsPosApi.Models");

            //expressionString.Name = s;
            //string xxxx = JsonConvert.SerializeObject(expressionString);

            //var client = new RestClient("http://rootwms.azurewebsites.net/api/PostGetVendors");
            //var client = new RestClient("http://192.168.1.26:45455/api/PostGetVendors");
            //var request = new RestRequest(Method.POST);
            //request.AddHeader("postman-token", "e72cf7ad-5f5c-d51a-d2a0-587bb689b350");
            //request.AddHeader("cache-control", "no-cache");
            //request.AddHeader("content-type", "application/json");
            //request.AddParameter("application/json", input, ParameterType.RequestBody);
            ////request.AddParameter("application/json", IncludeString, ParameterType.RequestBody);
            ////request.AddParameter("application/json", xxxx);
            //IRestResponse response = client.Execute(request);

            var x12 = 0;


            //string UrlApi = "http://localhost:53173/api/categorys";
            //try
            //{
            //    var getUrl = UrlApi;
            //    //var s = nameof(Vendors.DescriptionAr);
            //    var httpClient = new HttpClient();

            //    //Set token in the Header of the request

            //    //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_token.TokenType, _token.AccessToken);
            //    IEnumerable<string> headerValues = new List<string>() { "aa", "bb", "cc", "dd", "ee", "ff" };
            //    httpClient.DefaultRequestHeaders.Add("Json", jsonString);
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
            #region


            ////string[] s = vendors.GetType().GetFields().
            //#region
            ////        //    List
            ////        //    <Login> list1 = new List<Login>(4) {
            ////        //    new Login()
            ////        //{
            ////        //    username="xxx",
            ////        //    password="xxx",
            ////        //    code="xxx"
            ////        //},
            ////        // new Login()
            ////        //{
            ////        //    username = "xxx",
            ////        //    password = "xxx",
            ////        //    code = "xxx"
            ////        //},
            ////        // new Login()
            ////        //{
            ////        //    username = "xxx",
            ////        //    password = "xxx",
            ////        //    code = "xxx"
            ////        //},
            ////        //new Login()
            ////        //{
            ////        //    username = "xxx",
            ////        //    password = "xxx",
            ////        //    code = "xxx"
            ////        //}};
            ////        //    IQueryable<Login> logins = list1.AsQueryable();
            ////            //SendLogin log = new SendLogin();
            ////            //log.SendRequestAsync();


            ////            //string strPassword = "Root-123";

            ////            //byte[] bytePassword = Encoding.ASCII.GetBytes(strPassword);
            ////            //Hash hash = new Hash();
            ////            //byte[] AsciiByteHashPassword = hash.Encrypt(ref bytePassword);
            ////            //string a =Encoding.ASCII.GetString(AsciiByteHashPassword);
            ////            //byte[] b = Encoding.ASCII.GetBytes(a);
            ////            //byte[] xxx = hash.Encrypt(ref b);
            ////            //string strings = Encoding.ASCII.GetString(xxx);
            ////            //Console.WriteLine(strings);
            ////            //Console.ReadLine();
            ////            //Console.WriteLine(BitConverter.ToString(bytePassword));
            ////            //Console.ReadLine();
            ////            //string s = BitConverter.ToString(AsciiByteHashPassword);
            ////            //string hashpass = "";

            ////            //for (int i = 0; i < s.Length; i=i+3)
            ////            //{
            ////            //    string x = s.Substring(i,  2);
            ////            //    long n1 = Int64.Parse(x.ToString(), System.Globalization.NumberStyles.HexNumber);
            ////            //    hashpass = hashpass + n1.ToString()+"-";
            ////            //}

            ////            //Console.WriteLine(BitConverter.ToString(AsciiByteHashPassword));
            ////            //Console.ReadLine();


            ////            //string s1 = "C8";
            ////            //long n = Int64.Parse(s1, System.Globalization.NumberStyles.HexNumber);
            ////            //int intValue = 200;
            ////            //// Convert integer 182 as a hex in a string variable
            ////            //string hexValue = intValue.ToString("X");
            ////            ////byte[] c = new byte[8];
            ////            ////c[1] = Convert.ToByte(n.ToString(), 16);

            ////            //int num = 45;
            ////            //int bcdNum = 16 * (num / 10) + (num % 10);
            ////            //byte[] intBytes = BitConverter.GetBytes(n);
            ////            //Array.Reverse(intBytes);
            ////            //byte[] result = intBytes;


            ////            //string value = intValue.ToString("X");
            ////            //// Convert it back to a number.
            ////            //try
            ////            //{
            ////            //    byte number = Convert.ToByte(value, 16);
            ////            //    int intAgain = int.Parse(value, System.Globalization.NumberStyles.HexNumber);
            ////            //    Console.WriteLine("0x{0} converts to {1}.", value, number);
            ////            //    Console.ReadLine();
            ////            //}
            ////            //catch (OverflowException)
            ////            //{
            ////            //    Console.WriteLine("Unable to convert '0x{0}' to a byte.", value);
            ////            //    Console.ReadLine();
            ////            //}
            ////            //byte xxx = Convert.ToByte('A');


            ////            //string result = System.Text.Encoding.UTF8.GetString(AsciiByteHashPassword);
            ////            //string Asciitostring = BitConverter.ToString(AsciiByteHashPassword).Replace("-","");
            ////            //bytePassword = Encoding.ASCII.GetBytes(result);
            ////            //byte[] ResultAsciiByteHashPassword=hash.Encrypt(ref bytePassword);
            ////            //Console.WriteLine(BitConverter.ToString(ResultAsciiByteHashPassword));
            ////            //Console.ReadLine();
            ////            ////Console.WriteLine(BitConverter.ToString(AsciiByteHashPassword));
            ////            ////Console.ReadLine();
            ////            ////string AsciiStrHashPassword = BitConverter.ToString(AsciiByteHashPassword).Replace("-","");
            ////            //// Console.WriteLine( BitConverter.ToString(x));
            ////            ////Console.WriteLine(x3);


            ////            //Login login = new Login()
            ////            //{
            ////            //    //code = code,
            ////            //    hashPassword = hashpass,
            ////            //    password = "Root-123",
            ////            //    username = "Test@root.sa"
            ////            //};
            ////            //SendLogin sl = new SendLogin();
            ////            //sl.postAsync(login);


            ////            //SendLogin s1 = new SendLogin();
            ////            //object x =s1.changeValue(c => c.code == "cccc");
            ////            //Console.WriteLine(x.ToString());
            ////            //Console.ReadLine();
            ////            //string ch1 = "{\n\t\"username\":\"test@root.sa\",\n\t\"password\":\"Root-123\",\n\t\"hashPassword\":\"" + hashpass + "\"\n}";

            ////            //var client = new RestClient("http://localhost:63338/api/Account/Login");
            ////            //var request = new RestRequest(Method.POST);
            ////            //request.AddHeader("postman-token", "fc4e93f3-4ec0-afde-2b71-94fc8b9808e4");
            ////            //request.AddHeader("cache-control", "no-cache");
            ////            //request.AddHeader("content-type", "application/json");
            ////            //request.AddParameter("application/json", ch1, ParameterType.RequestBody);
            ////            //IRestResponse response = client.Execute(request);






            ////            //expressionn expressionn = new expressionn()
            ////            //{
            ////            //    compare = "==",
            ////            //    propriety = "Code",
            ////            //    value = 10
            ////            //};
            ////            //Expression ex =expressionn.Express(expressionn);

            ////            string[] companies = { "Consolidated Messenger", "Alpine Ski House", "Southridge Video", "City Power & Light",
            ////                               "Coho Winery", "Wide World Importers", "Graphic Design Institute", "Adventure Works",
            ////                               "Humongous Insurance", "Woodgrove Bank", "Margie's Travel", "Northwind Traders",
            ////                               "Blue Yonder Airlines", "Trey Research", "The Phone Company",
            ////                               "Wingtip Toys", "Lucerne Publishing", "Fourth Coffee" };

            ////            // The IQueryable data to query.
            ////            IQueryable<String> queryableData = companies.AsQueryable<string>();

            ////            // Compose the expression tree that represents the parameter to the predicate.
            ////            ParameterExpression pe = Expression.Parameter(typeof(string), "company");
            ////            ParameterExpression pe1 = Expression.Parameter(typeof(string), "c");
            ////            Expression left1 = Expression.Constant("code");
            ////            Expression right1 = Expression.Constant("123456");
            ////            Expression e11 = Expression.Equal(left1, right1);
            ////            //ParameterExpression pe1 = Expression.Parameter(typeof(Login), "c");
            ////            //List<string> list = new List<string>() { "code", "==", "123456", "userName", "Containt", "a" };
            ////            //for (int i = 0; i < list.Count; i=i+3)
            ////            //{
            ////            //    Expression left1 = Expression.
            ////            //    Expression left111 = Expression.Call(pe1,);
            ////            //    Expression right1= Expression.Constant("coho winery");
            ////            //    Expression e11 = Expression.Equal(left1, right1);
            ////            //}
            ////            // ***** Where(company => (company.ToLower() == "coho winery" || company.Length > 16)) *****
            ////            // Create an expression tree that represents the expression 'company.ToLower() == "coho winery"'.
            ////            Expression left = Expression.Call(pe, typeof(string).GetMethod("ToLower", System.Type.EmptyTypes));
            ////            Expression right = Expression.Constant("coho winery");
            ////            Expression e1 = Expression.Equal(left, right);

            ////            // Create an expression tree that represents the expression 'company.Length > 16'.
            ////            left = Expression.Property(pe, typeof(string).GetProperty("Length"));
            ////            right = Expression.Constant(16, typeof(int));
            ////            Expression e2 = Expression.GreaterThan(left, right);

            ////            // Combine the expression trees to create an expression tree that represents the 
            ////            // expression '(company.ToLower() == "coho winery" || company.Length > 16)'.
            ////            Expression predicateBody = Expression.OrElse(e1, e2);

            ////            // Create an expression tree that represents the expression 
            ////            // 'queryableData.Where(company => (company.ToLower() == "coho winery" || company.Length > 16))'
            ////            MethodCallExpression whereCallExpression = Expression.Call(
            ////                typeof(Queryable),
            ////                "Where",
            ////                new Type[] { queryableData.ElementType },
            ////                queryableData.Expression,
            ////                Expression.Lambda<Func<string, bool>>(predicateBody, new ParameterExpression[] { pe }));
            ////            // ***** End Where ***** 

            ////            // ***** OrderBy(company => company) ***** 
            ////            // Create an expression tree that represents the expression 
            ////            // 'whereCallExpression.OrderBy(company => company)'
            ////            MethodCallExpression orderByCallExpression = Expression.Call(
            ////                typeof(Queryable),
            ////                "OrderBy",
            ////                new Type[] { queryableData.ElementType, queryableData.ElementType },
            ////                whereCallExpression,
            ////                Expression.Lambda<Func<string, string>>(pe, new ParameterExpression[] { pe }));
            ////            // ***** End OrderBy ***** 

            ////            // Create an executable query from the expression tree.
            ////            IQueryable<string> results = queryableData.Provider.CreateQuery<string>(orderByCallExpression);

            ////            // Enumerate the results. 
            ////            foreach (string company in results)
            ////                Console.WriteLine(company);
            ////       




            //////var expressionList = new List<ExpressionInput>
            //////    {
            //////        new ExpressionInput
            //////        {
            //////            Operand = QueryOperand.And, //First Item does not matter And or OR
            //////            Operation = Operation.Contains,
            //////            PropertyName = "username",
            //////            Value = "Jack"
            //////        }
            //////    };
            //////new ExpressionInput
            //////{
            //////    Operand = QueryOperand.Or,
            //////    Operation = Operation.NotEquals,
            //////    PropertyName = "isDeleted",
            //////    Value = false
            //////},
            //////new ExpressionInput
            //////{
            //////    Operand = QueryOperand.And,
            //////    Operation = Operation.GreaterThanOrEqual,
            //////    PropertyName = "code",
            //////    Value = (int)500000 //Value need to be parsed to Expression's object (T) type. Here T is of Citizen type and AnnualIncome is of double type.
            //////}
            //////};

            //////var expressionList = ExpressionInputGenerator.GetExpressionInputList();

            ////Expression<Func<Login, bool>> expression = DynamicExpressionBuilder.ExpressionBuilder.GetExpression<Login>(expressionList); //Passing to expression builder. Here we are getting expression of Type Citizen
            ////Console.WriteLine($"Final Expression = {expression.ToString()}");
            ////Console.ReadLine();
            //#endregion

            ////var listExpressions = new Expressions();
            ////listExpressions.Expression = new List<ExpressionInput>
            ////{
            ////    new ExpressionInput
            ////    {
            ////        Operand=null,
            ////        Operation=Operation.Equals,
            ////        PropertyName="Name.ToLower()",
            ////        Value="zzz",
            ////        Order=null
            ////    },
            ////    new ExpressionInput
            ////    {
            ////        Operand=ExpressionType.AndAlso,
            ////        Operation=Operation.Equals,
            ////        PropertyName="DescriptionAr",
            ////        Value="zzz",
            ////        Order=null
            ////    },
            ////    new ExpressionInput
            ////    {
            ////        Operand=ExpressionType.OrElse,
            ////        Operation=Operation.Equals,
            ////        PropertyName="DescriptionAr",
            ////        Value="zzz",
            ////        Order=null
            ////    }
            ////};
            ////listExpressions.Include = new List<ExpressionInput>
            ////{
            ////    new ExpressionInput
            ////    {
            ////        PropertyName = "VendorsCategories",
            ////        Order = null,
            ////        Operand = null,
            ////        Operation = null,
            ////        Value = null,
            ////    }
            ////};
            //////listExpressions.OrderBy = new List<ExpressionInput>();
            ////listExpressions.OrderBy = new List<ExpressionInput>
            ////{
            ////    new ExpressionInput
            ////    {
            ////        PropertyName="NameEn",
            ////        Order=Order.Descending,
            ////        Operation=null,
            ////        Operand=null,
            ////        Value=null
            ////    }
            ////};
            ////listExpressions.skip = 1;
            ////listExpressions.take = 2;
            ////var builderExpressions = BuilderExpressions.GetExpression<Vendors>(listExpressions.Expression);




            ////var wx = 10;
            ////var expres = new BuilderExpression();
            ////string UrlApi = "http://localhost:55574/api/vendors";
            ////try
            ////{
            ////    //var s = nameof(Vendors.DescriptionAr);
            ////    var httpClient = new HttpClient();

            ////    //Set token in the Header of the request
            ////    string output = JsonConvert.SerializeObject(listExpressions);
            ////    //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_token.TokenType, _token.AccessToken);
            ////    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            ////    httpClient.DefaultRequestHeaders.Add("Expressions", output);
            ////    //Get Data from the Api in JSON Format
            ////    var json = httpClient.GetStringAsync(UrlApi).Result;


            //Expression<Func<TestClass1, bool>> ex = c => c.Name.Length==10;
            //ReaderExpressions.readerExpression<TestClass1>(ex);

            //IQueryable<TestClass1> query = new List<TestClass1>().AsQueryable();
            //Expression<Func<TestClass1, bool>> expression = null;


            //    query = query.Where(x => x.Name == "");




            //expression = query.Expression as Expression<Func<TestClass1, bool>>; //This convert is not working, it returns null.

            ////return this.Context.Events.Where(expression);



            //Expression<Func<TestClass1, bool>> expression1 = c => c.Name == ""&&c.age==20;
            //string ex1 = expression.Body.ToString();
            //Match m = Regex.Match("var4 < 433", @"(?'leftOperand'\w+)\s*(?'operator'(<|<=|>|>=|==|!=))\s*(?'rightOperand'\w+)");
            //Match m1 = Regex.Match(ex1, @"(?'leftOperand'\w+)\s*(?'operator'(OrElse|AndAlso))\s*(?'rightOperand'\w+)");
            //string s = m.Groups["leftOperand"].Value;//the varaible or constant on left side of the operator
            //string s1 = m.Groups["operator"].Value;//the operator
            //string s2 = m.Groups["rightOperand"].Value;


            ////Deserialize the request response to "IEnumerable<T>" 
            ////byte[] i =(byte[]) Convert.ChangeType(expression, typeof(byte[])) ;
            ////byte ii = Convert.ToByte(expression.Body as BinaryExpression);
            //var json = JsonConvert.SerializeObject(expression);
            //var result = JsonConvert.DeserializeObject<Expression<Func<TestClass1, bool>>>(json);

            ////    //SaveDataLocal(result.ToList());

            ////    Console.WriteLine(result);
            ////    Console.ReadLine();
            ////}
            ////catch (Exception e)
            ////{
            ////    Console.WriteLine(e.Message);
            ////    throw new Exception(e.Message, e.InnerException);
            ////}
            ////List<string> result = new List<string>();
            ////Expression<Func<TestClass1, bool>> expression = c  => c.testClass2.Where(x=>x.age>=20).Count()>10 && (c.age>10||c.Name.ToLower().Contains(""))&&(c.UserName=="azerty");
            ////Expression<Func<TestClass1, bool>> expressionn = c  => c.age > 10;
            ////string output = JsonConvert.SerializeObject(expressionn);
            //////Expression obj = JsonConvert.DeserializeObject<Expression>(output);
            ////Console.WriteLine(output);
            ////Console.ReadLine();
            ////List<Expression<Func<TestClass1, bool>>> expressions = new List<Expression<Func<TestClass1, bool>>>() ;
            ////expressions.Add(c => c.age >= 10);
            ////expressions.Add(c => c.Name.Contains("   "));
            ////expressions.Add(c => c.UserName == "azerty");
            ////string s2 = expression.ToString();
            ////testExpression tx = new testExpression();

            //////result = tx.subStringExpression(s2);
            //////foreach (string item in result)
            //////{
            //////    Console.WriteLine(item);
            //////}

            ////ExpressionInput expressionInput = tx.getExpressionInput(s2.Split('.')[1]);
            ////Console.WriteLine(expressionInput.PropertyName);
            ////Console.WriteLine(expressionInput.Value);
            ////Console.WriteLine(expressionInput.Operation.ToString());
            ////Console.ReadLine();


            ////testExpression < TestClass1> readerExpressions = new testExpression<TestClass1>();
            ////Expression<Func<TestClass1, bool>> expression = c => c.Name.Contains(" ")||c.age>20;
            //////var methode = expression.Body
            ////readerExpressions.readerExpression(expression);
            #endregion
            //long size = 0;
            //object o = "aaaaaaaaaaaaaaaaaaa";
            //int x;
            //using (Stream s = new MemoryStream())
            //{
            //    BinaryFormatter formatter = new BinaryFormatter();
            //    formatter.Serialize(s, o);
            //    size = s.Length;
            //}
            //Expression<Func<TestClass1, bool>> expression = c => c.age < 10;
            Expression<Func<Vendors, bool>> exp = c => ((c.NameAr == "" && c.NameEn == "") || (c.Phone == "" && (c.IsDeleted == false || c.Fax=="")));
            //LambdaExpression lambdaExpression = exp as Expression;
            ReaderExpressions<Vendors>.read(exp);
        }
    }
}
    