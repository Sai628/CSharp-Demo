using System;

namespace CSharpDemo
{
    public class TestMain
	{
        static void Main(string[] args)
        {
            TestBase.DoTest();
            TestArray.DoTest();
            TestString.DoTest();
            TestStruct.DoTest();
            TestEnum.DoTest();
            TestInheritance.DoTest();
            TestPolymorphism.DoTest();
            TestOperatorOvl.DoTest();
        }
	}
}

