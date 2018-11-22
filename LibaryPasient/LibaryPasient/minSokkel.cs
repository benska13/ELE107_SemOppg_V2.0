using System.Net;
using System.Net.Sockets;
using System.Text;

namespace LibaryPasient
{
    public class minSokkel
    {
        public static Socket VentPaaKlient(Socket lytteSokkel)
        {
            Socket kommSokkel = lytteSokkel.Accept(); // blokkerende metode
            return kommSokkel;
        }

        public static string VentPaData(Socket kommSokkel)
        {
            int recv;
            string mottattTekst = "";

            byte[] data = new byte[1024];

            recv = kommSokkel.Receive(data);

            mottattTekst = Encoding.ASCII.GetString(data, 0, recv);

            return mottattTekst;
        }

        public static void KobleTilServer()
        {
            Socket klientSokkel = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint serverEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
            klientSokkel.Connect(serverEP);
        }
    }
}

