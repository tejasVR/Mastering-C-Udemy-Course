using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var encorder = new VideoEncoder();
            encorder.RegisterNotificationChannel(new MailNotification());
            encorder.RegisterNotificationChannel(new SMSNotification());
            Encoder.Encode(new Video());
        }
    }
}
