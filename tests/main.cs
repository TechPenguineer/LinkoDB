using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkoDB;
namespace LinkoDB.tests
{
    class main
    {
        public void testing()
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
