using System;
using LinkoDB;

namespace LinkoDB.tests
{
    class Program
    {
        static void Main(string[] args)
        {
            string code_data = "print('Hello World!')";

            Schema new_code_scene = new Schema
            {
                CodeContent = code_data,
                CodeLanguage = "Python",
                useTimeStamp = true,
                GroupName = "Testing",
                DataName = "TestingData"
            };

            linko.CreateFromSchema(new_code_scene);
        }
    }
}
