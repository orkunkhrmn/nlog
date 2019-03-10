using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlornek
{
    class Program
    {
        static void Main(string[] args)
        {
            /// nlog.config connectionString kontrol et

            Logger logger = LogManager.GetCurrentClassLogger();

            /// properties kolonu 1
            //logger.Info("Order {orderid} created for {user}", 42, "Kenny"); 
            //logger.Debug("deneme");

            /// çoklu properties 2
            /*LogEventInfo theEvent = new LogEventInfo(LogLevel.Debug, "", "Pass my custom value");
            theEvent.Properties["MyValue"] = "My custom string";
            theEvent.Properties["MyDateTimeValue"] = new DateTime(2015, 08, 30, 11, 26, 50);
            theEvent.Properties["MyDateTimeValueWithCulture"] = new DateTime(2015, 08, 30, 11, 26, 50);
            theEvent.Properties["MyDateTimeValueWithCultureAndFormat"] = new DateTime(2015, 08, 30, 11, 26, 50);
            logger.Trace(theEvent);*/

            /// çoklu propertie 3 custom kolon
            LogEventInfo theEvent = new LogEventInfo(LogLevel.Debug, "", "Pass my custom value");
            theEvent.Properties["MyValue"] = "My custom string";
            theEvent.Properties["MyDateTimeValue"] = new DateTime(2015, 08, 30, 11, 26, 50);
            theEvent.Properties["MyDateTimeValueWithCulture"] = new DateTime(2015, 08, 30, 11, 26, 50);
            theEvent.Properties["MyDateTimeValueWithCultureAndFormat"] = new DateTime(2015, 08, 30, 11, 26, 50);

            theEvent.Properties["kullaniciId"] = 1;

            logger.Trace(theEvent);
        }
    }
}
