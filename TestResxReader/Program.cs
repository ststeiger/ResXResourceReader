
namespace TestResxReader
{


    class Program
    {

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


        static void Main(string[] args)
        {
            ReadRessourceFile();
            System.Console.WriteLine("Hello World!");
        }


    }


}
