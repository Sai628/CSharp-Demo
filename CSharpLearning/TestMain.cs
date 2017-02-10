using CSharpLearning;

public class TestMain
{
    public static void Main(string[] args)
    {
        TestBase.DoTest();
        TestArray.DoTest();
        TestString.DoTest();
        TestStruct.DoTest();
        TestEnum.DoTest();
        
        TestInheritance.DoTest();
        TestPolymorphism.DoTest();
        TestOperatorOvl.DoTest();
        TestInterface.DoTest();
        TestNameSpace.DoTest();
        TestPreprocessor.DoTest();
        TestException.DoTest();
        TestFileIO.DoTest();
        
        TestAttribute.DoTest();
        TestReflection.DoTest();
        TestProperty.DoTest();
        TestIndexer.DoTest();
        TestDelegate.DoTest();
        TestEvent.DoTest();
        TestCollection.DoTest();
        TestGeneric.DoTest();
        TestAnonymousMethod.DoTest();
        TestUnsafeCode.DoTest();
        TestThread.DoTest();
    }
}

