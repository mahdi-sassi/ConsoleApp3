//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp3
//{

//    public class Rootobject
//    {
//        public string nodeType { get; set; }
//        public Type type { get; set; }
//        public string typeName { get; set; }
//        public object name { get; set; }
//        public Parameter1[] parameters { get; set; }
//        public Body body { get; set; }
//        public bool tailCall { get; set; }
//    }

//    public class Type
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public Genericargument[] genericArguments { get; set; }
//    }

//    public class Genericargument
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Body
//    {
//        public string nodeType { get; set; }
//        public Type1 type { get; set; }
//        public string typeName { get; set; }
//        public Left left { get; set; }
//        public Right5 right { get; set; }
//        public object method { get; set; }
//        public object conversion { get; set; }
//        public bool liftToNull { get; set; }
//    }

//    public class Type1
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Left
//    {
//        public string nodeType { get; set; }
//        public Type2 type { get; set; }
//        public string typeName { get; set; }
//        public Left1 left { get; set; }
//        public Right1 right { get; set; }
//        public object method { get; set; }
//        public object conversion { get; set; }
//        public bool liftToNull { get; set; }
//    }

//    public class Type2
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Left1
//    {
//        public string nodeType { get; set; }
//        public Type3 type { get; set; }
//        public string typeName { get; set; }
//        public Left2 left { get; set; }
//        public Right right { get; set; }
//        public object method { get; set; }
//        public object conversion { get; set; }
//        public bool liftToNull { get; set; }
//    }

//    public class Type3
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Left2
//    {
//        public string nodeType { get; set; }
//        public Type4 type { get; set; }
//        public string typeName { get; set; }
//        public Expression expression { get; set; }
//        public Member member { get; set; }
//    }

//    public class Type4
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Expression
//    {
//        public string nodeType { get; set; }
//        public Type5 type { get; set; }
//        public string typeName { get; set; }
//        public string name { get; set; }
//    }

//    public class Type5
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Member
//    {
//        public Type6 type { get; set; }
//        public int memberType { get; set; }
//        public string name { get; set; }
//        public string signature { get; set; }
//    }

//    public class Type6
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Right
//    {
//        public string nodeType { get; set; }
//        public Type7 type { get; set; }
//        public string typeName { get; set; }
//        public Value value { get; set; }
//    }

//    public class Type7
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Value
//    {
//        public Type8 type { get; set; }
//        public int value { get; set; }
//    }

//    public class Type8
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Right1
//    {
//        public string nodeType { get; set; }
//        public Type9 type { get; set; }
//        public string typeName { get; set; }
//        public Left3 left { get; set; }
//        public Right3 right { get; set; }
//        public object method { get; set; }
//        public object conversion { get; set; }
//        public bool liftToNull { get; set; }
//    }

//    public class Type9
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Left3
//    {
//        public string nodeType { get; set; }
//        public Type10 type { get; set; }
//        public string typeName { get; set; }
//        public Left4 left { get; set; }
//        public Right2 right { get; set; }
//        public object method { get; set; }
//        public object conversion { get; set; }
//        public bool liftToNull { get; set; }
//    }

//    public class Type10
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Left4
//    {
//        public string nodeType { get; set; }
//        public Type11 type { get; set; }
//        public string typeName { get; set; }
//        public Expression1 expression { get; set; }
//        public Member1 member { get; set; }
//    }

//    public class Type11
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Expression1
//    {
//        public string nodeType { get; set; }
//        public Type12 type { get; set; }
//        public string typeName { get; set; }
//        public string name { get; set; }
//    }

//    public class Type12
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Member1
//    {
//        public Type13 type { get; set; }
//        public int memberType { get; set; }
//        public string name { get; set; }
//        public string signature { get; set; }
//    }

//    public class Type13
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Right2
//    {
//        public string nodeType { get; set; }
//        public Type14 type { get; set; }
//        public string typeName { get; set; }
//        public Value1 value { get; set; }
//    }

//    public class Type14
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Value1
//    {
//        public Type15 type { get; set; }
//        public int value { get; set; }
//    }

//    public class Type15
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Right3
//    {
//        public string nodeType { get; set; }
//        public Type16 type { get; set; }
//        public string typeName { get; set; }
//        public Left5 left { get; set; }
//        public Right4 right { get; set; }
//        public object method { get; set; }
//        public object conversion { get; set; }
//        public bool liftToNull { get; set; }
//    }

//    public class Type16
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Left5
//    {
//        public string nodeType { get; set; }
//        public Type17 type { get; set; }
//        public string typeName { get; set; }
//        public Expression2 expression { get; set; }
//        public Member2 member { get; set; }
//    }

//    public class Type17
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public Genericargument1[] genericArguments { get; set; }
//    }

//    public class Genericargument1
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Expression2
//    {
//        public string nodeType { get; set; }
//        public Type18 type { get; set; }
//        public string typeName { get; set; }
//        public string name { get; set; }
//    }

//    public class Type18
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Member2
//    {
//        public Type19 type { get; set; }
//        public int memberType { get; set; }
//        public string name { get; set; }
//        public string signature { get; set; }
//    }

//    public class Type19
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Right4
//    {
//        public string nodeType { get; set; }
//        public Type20 type { get; set; }
//        public string typeName { get; set; }
//        public Operand operand { get; set; }
//        public object method { get; set; }
//    }

//    public class Type20
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public Genericargument2[] genericArguments { get; set; }
//    }

//    public class Genericargument2
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Operand
//    {
//        public string nodeType { get; set; }
//        public Type21 type { get; set; }
//        public string typeName { get; set; }
//        public Value2 value { get; set; }
//    }

//    public class Type21
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Value2
//    {
//        public Type22 type { get; set; }
//        public int value { get; set; }
//    }

//    public class Type22
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Right5
//    {
//        public string nodeType { get; set; }
//        public Type23 type { get; set; }
//        public string typeName { get; set; }
//        public Left6 left { get; set; }
//        public Right6 right { get; set; }
//        public object method { get; set; }
//        public object conversion { get; set; }
//        public bool liftToNull { get; set; }
//    }

//    public class Type23
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Left6
//    {
//        public string nodeType { get; set; }
//        public Type24 type { get; set; }
//        public string typeName { get; set; }
//        public Object _object { get; set; }
//        public Method method { get; set; }
//        public Argument[] arguments { get; set; }
//    }

//    public class Type24
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Object
//    {
//        public string nodeType { get; set; }
//        public Type25 type { get; set; }
//        public string typeName { get; set; }
//        public Expression3 expression { get; set; }
//        public Member3 member { get; set; }
//    }

//    public class Type25
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Expression3
//    {
//        public string nodeType { get; set; }
//        public Type26 type { get; set; }
//        public string typeName { get; set; }
//        public string name { get; set; }
//    }

//    public class Type26
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Member3
//    {
//        public Type27 type { get; set; }
//        public int memberType { get; set; }
//        public string name { get; set; }
//        public string signature { get; set; }
//    }

//    public class Type27
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Method
//    {
//        public Type28 type { get; set; }
//        public string name { get; set; }
//        public string signature { get; set; }
//    }

//    public class Type28
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Argument
//    {
//        public string nodeType { get; set; }
//        public Type29 type { get; set; }
//        public string typeName { get; set; }
//        public Value3 value { get; set; }
//    }

//    public class Type29
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Value3
//    {
//        public Type30 type { get; set; }
//        public string value { get; set; }
//    }

//    public class Type30
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Right6
//    {
//        public string nodeType { get; set; }
//        public Type31 type { get; set; }
//        public string typeName { get; set; }
//        public Left7 left { get; set; }
//        public Right8 right { get; set; }
//        public object method { get; set; }
//        public object conversion { get; set; }
//        public bool liftToNull { get; set; }
//    }

//    public class Type31
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Left7
//    {
//        public string nodeType { get; set; }
//        public Type32 type { get; set; }
//        public string typeName { get; set; }
//        public object _object { get; set; }
//        public Method1 method { get; set; }
//        public Argument1[] arguments { get; set; }
//    }

//    public class Type32
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Method1
//    {
//        public Type33 type { get; set; }
//        public string name { get; set; }
//        public string signature { get; set; }
//        public Generic[] generic { get; set; }
//    }

//    public class Type33
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Generic
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Argument1
//    {
//        public string nodeType { get; set; }
//        public Type34 type { get; set; }
//        public string typeName { get; set; }
//        public object _object { get; set; }
//        public Method2 method { get; set; }
//        public Argument2[] arguments { get; set; }
//    }

//    public class Type34
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public Genericargument3[] genericArguments { get; set; }
//    }

//    public class Genericargument3
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Method2
//    {
//        public Type35 type { get; set; }
//        public string name { get; set; }
//        public string signature { get; set; }
//        public Generic1[] generic { get; set; }
//    }

//    public class Type35
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Generic1
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Argument2
//    {
//        public string nodeType { get; set; }
//        public Type36 type { get; set; }
//        public string typeName { get; set; }
//        public Expression4 expression { get; set; }
//        public Member4 member { get; set; }
//        public object name { get; set; }
//        public Parameter[] parameters { get; set; }
//        public Body1 body { get; set; }
//        public bool tailCall { get; set; }
//    }

//    public class Type36
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public Genericargument4[] genericArguments { get; set; }
//    }

//    public class Genericargument4
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Expression4
//    {
//        public string nodeType { get; set; }
//        public Type37 type { get; set; }
//        public string typeName { get; set; }
//        public string name { get; set; }
//    }

//    public class Type37
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Member4
//    {
//        public Type38 type { get; set; }
//        public int memberType { get; set; }
//        public string name { get; set; }
//        public string signature { get; set; }
//    }

//    public class Type38
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Body1
//    {
//        public string nodeType { get; set; }
//        public Type39 type { get; set; }
//        public string typeName { get; set; }
//        public Left8 left { get; set; }
//        public Right7 right { get; set; }
//        public object method { get; set; }
//        public object conversion { get; set; }
//        public bool liftToNull { get; set; }
//    }

//    public class Type39
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Left8
//    {
//        public string nodeType { get; set; }
//        public Type40 type { get; set; }
//        public string typeName { get; set; }
//        public Expression5 expression { get; set; }
//        public Member5 member { get; set; }
//    }

//    public class Type40
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Expression5
//    {
//        public string nodeType { get; set; }
//        public Type41 type { get; set; }
//        public string typeName { get; set; }
//        public string name { get; set; }
//    }

//    public class Type41
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Member5
//    {
//        public Type42 type { get; set; }
//        public int memberType { get; set; }
//        public string name { get; set; }
//        public string signature { get; set; }
//    }

//    public class Type42
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Right7
//    {
//        public string nodeType { get; set; }
//        public Type43 type { get; set; }
//        public string typeName { get; set; }
//        public Value4 value { get; set; }
//    }

//    public class Type43
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Value4
//    {
//        public Type44 type { get; set; }
//        public bool value { get; set; }
//    }

//    public class Type44
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Parameter
//    {
//        public string nodeType { get; set; }
//        public Type45 type { get; set; }
//        public string typeName { get; set; }
//        public string name { get; set; }
//    }

//    public class Type45
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Right8
//    {
//        public string nodeType { get; set; }
//        public Type46 type { get; set; }
//        public string typeName { get; set; }
//        public Value5 value { get; set; }
//    }

//    public class Type46
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Value5
//    {
//        public Type47 type { get; set; }
//        public int value { get; set; }
//    }

//    public class Type47
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//    public class Parameter1
//    {
//        public string nodeType { get; set; }
//        public Type48 type { get; set; }
//        public string typeName { get; set; }
//        public string name { get; set; }
//    }

//    public class Type48
//    {
//        public string assemblyName { get; set; }
//        public string typeName { get; set; }
//        public object genericArguments { get; set; }
//    }

//}
