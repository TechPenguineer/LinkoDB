# LinkoDB
 A database for storing code chunks and their data!


 # Library
 ## Import
 ``` using LinkoDB ```

 ## Usage
 ### Create Schema 
 ```cs
             Schema new_schema_name = new Schema
            {
                CodeContent = "{CODE_CONTENT}", // <--- STRING TYPE
                CodeLanguage = "{LANGUAGE}",   // <--- STRING TYPE
                useTimeStamp = true            // <--- BOOL TYPE
            };
```