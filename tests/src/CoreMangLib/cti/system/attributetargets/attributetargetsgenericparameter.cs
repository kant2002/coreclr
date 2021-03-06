using System;
/// <summary>
///GenericParameter
/// </summary>

public class AttributeTargetsGenericParameter
{
    public static int Main()
    {
        AttributeTargetsGenericParameter AttributeTargetsGenericParameter = new AttributeTargetsGenericParameter();

        TestLibrary.TestFramework.BeginTestCase("AttributeTargetsGenericParameter");
        if (AttributeTargetsGenericParameter.RunTests())
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
        TestLibrary.TestFramework.BeginScenario("PosTest1: Verify the AttributeTargets.GenericParameter value is 0x4000. ");
        try
        {
            int expectValue = 0x4000;
            if ((int)AttributeTargets.GenericParameter != expectValue)
            {
                TestLibrary.TestFramework.LogError("001.1", " AttributeTargets.GenericParameter should return 0x4000.");
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

