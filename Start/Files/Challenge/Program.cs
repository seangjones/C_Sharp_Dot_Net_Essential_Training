// See https://aka.ms/new-console-template for more information

class DirCatalog
{
    static void Main(){
        // Build target directory path
        string workingdir = "FileCollection";
        string curdir = Directory.GetCurrentDirectory();

        //Console.WriteLine($"Current directory: {curdir}");
        string targetdir = $"{curdir}\\{workingdir}";

        //Console.WriteLine($"Target dir: {targetdir}");

        // Verify that target directory exists
        if (!Directory.Exists(targetdir)){
            Console.WriteLine($"Error: \'{targetdir}\' does not exist.");
            return;
        }

        // Get all the file contents from the target directory
        

        try{
            List<string> fileList = new List<string>(Directory.EnumerateFiles(targetdir));

            // Count up instances of each MS Office file type and total file sizes
            int wordCount = 0, excelCount = 0, powerpointCount = 0, totalCount = 0;
            long wordSize = 0, excelSize = 0, powerpointSize = 0, totalSize = 0;
            FileInfo fi;

            foreach (string f in fileList){
                fi = new FileInfo(f);
                //Console.WriteLine($"{fi.Name}: {fi.Extension}");
                switch (fi.Extension){
                    case ".docx":
                        wordCount++;
                        totalCount++;
                        wordSize += fi.Length;
                        totalSize += fi.Length;
                        break;
                    
                    case ".xlsx":
                        excelCount++;
                        totalCount++;
                        excelSize += fi.Length;
                        totalSize += fi.Length;
                        break;
                    case ".pptx":
                        powerpointCount++;
                        totalCount++;
                        powerpointSize += fi.Length;
                        totalSize += fi.Length;
                        break;
                    default:
                        // Not a file type we're counting

                        //Console.WriteLine("Not an Office file");
                        break;
                }
            }

            string resultsFile = "results.txt";

            // Output the summary report
            using (StreamWriter sw = File.CreateText(resultsFile)){
                sw.WriteLine($"Summary Report:");
                sw.WriteLine($"Directory name:{targetdir}\n");

                sw.WriteLine($"File type counts:");
                sw.WriteLine($"Total files     : {totalCount}");
                sw.WriteLine($"Word files      : {wordCount}");
                sw.WriteLine($"Excel files     : {excelCount}");
                sw.WriteLine($"Powerpoint files: {powerpointCount}\n");
            
                sw.WriteLine($"File sizes:");
                sw.WriteLine($"Total file size : {totalSize,0:N0} bytes");                
                sw.WriteLine($"Word files      : {wordSize,0:N0} bytes");
                sw.WriteLine($"Excel files     : {excelSize,0:N0} bytes");
                sw.WriteLine($"Powerpoint files: {powerpointSize,0:N0} bytes");
            }
            
        }
        catch (Exception e){
            Console.WriteLine($"Exception occurred: {e}");
        }
        
        

        
    }
}



