
namespace TestResxReader
{


    class Program
    {

        public static void ReadRessourceFile()
        {
            //Requires Assembly System.Windows.Forms '
            string filename = @"C:\Program Files\paint.net\resx\PaintDotNet.Strings.3.resx";
            System.Resources.ResXResourceReader rsxr = new System.Resources.ResXResourceReader(filename);

            // Iterate through the resources and display the contents to the console. '    
            foreach (System.Collections.DictionaryEntry d in rsxr)
            {
                System.Console.WriteLine(d.Key.ToString() + ":\t" + d.Value.ToString());
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
