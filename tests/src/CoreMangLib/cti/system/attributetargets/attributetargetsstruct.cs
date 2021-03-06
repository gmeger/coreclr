using System;
/// <summary>
///Struct
/// </summary>

public class AttributeTargetsStruct
{
    public static int Main()
    {
        AttributeTargetsStruct AttributeTargetsStruct = new AttributeTargetsStruct();

        TestLibrary.TestFramework.BeginTestCase("AttributeTargetsStruct");
        if (AttributeTargetsStruct.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }
    public bool RunTests()
    {
        bool retVal = true;
       TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
      
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong

    public bool PosTest1()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest1: Verify the AttributeTargets.Struct value is 0x0008. ");
        try
        {
            int expectValue = 0x0008;
            if ((int)AttributeTargets.Struct != expectValue)
            {
                TestLibrary.TestFramework.LogError("001.1", " AttributeTargets.Struct should return 0x0008.");
                retVal = false;
            }
           
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.0", "Unexpected exception: " + e);
            retVal = false;
        }
       
        return retVal;
    }
   
}

