using NLog;
using System;
using System.IO;

namespace ngloexample
{
    internal class Program
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();

        private static void Main(string[] args)
        {
            logger.Trace("This is app has been launched");
            ReadFile();
        }

        private static void ReadFile()
        {
            try
            {
                using (var fileReader = new StreamReader(@"/Users/test"))
                {
                    var textFile = fileReader.ReadToEnd();
                    Console.WriteLine(textFile);
                }
            }
            catch (DriveNotFoundException ex)
            {
                Console.WriteLine("Klasor bulunamadı");
                logger.Error("Klasor bulunmadı" + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Dosya bulunamadı");
                logger.Error("Dosya bulunmadı" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Dosya yeri bulunamadı");
                logger.Error("Dosya yeri bulunmadı" + ex.Message);
            }
        }
    }
}