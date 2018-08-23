
namespace TestResxReader
{


    class Program
    {
#if false

        public static void ReadRessourceFile()
        {
            //Requires Assembly System.Windows.Forms '
            string filename = @"C:\Program Files\paint.net\resx\PaintDotNet.Strings.3.resx";
            filename = "/root/github/EntityFrameworkCore/src/EFCore.Sqlite.Core/Properties/SqliteStrings.resx";
            filename = "/root/github/ExpressProfiler/ExpressProfiler/MainForm.resx";
            System.Resources.ResXResourceReader rsxr = new System.Resources.ResXResourceReader(filename);

            // Iterate through the resources and display the contents to the console. '    
            foreach (System.Collections.DictionaryEntry d in rsxr)
            {
                if(d.Key != null)
                    System.Console.Write(d.Key.ToString() + ":\t");
                
                if(d.Value != null) 
                    System.Console.Write(d.Value.ToString());
                
                System.Console.WriteLine();
            }

            //Close the reader. '
            rsxr.Close();
        }
#endif

        static void Main(string[] args)
        {
            // ReadRessourceFile();
            string filename = @"C:\Program Files\paint.net\resx\PaintDotNet.Strings.3.resx";

            // .NET-Core resources are different ? 
            System.Resources.ResourceReader rsxr = new System.Resources.ResourceReader(filename);

            System.Resources.ResourceManager RM = new System.Resources.ResourceManager("basename", System.Reflection.Assembly.GetExecutingAssembly());

            // ResourceNamespace.ResxFileName.ResourceManager.GetString("ResourceKey");

            var rs = RM.GetResourceSet(System.Globalization.CultureInfo.CurrentCulture, false, false);
            // rs.GetDefaultReader().
            // http://www.lhotka.net/weblog/NETCoreUsingExistingResxResourceFile.aspx


            foreach (System.Collections.DictionaryEntry d in rsxr)
            {
                if (d.Key != null)
                    System.Console.Write(d.Key.ToString() + ":\t");

                if (d.Value != null)
                    System.Console.Write(d.Value.ToString());

                System.Console.WriteLine();
            }

            System.Console.WriteLine(" --- Press any key to continue --- ");
            System.Console.ReadKey();
        }


    }


}
