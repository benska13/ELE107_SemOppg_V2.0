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

            // MessageBox.Show("Venter på en klient ...");
            //kommSokkel = lytteSokkel.Accept(); // blokkerende metode

            //IPEndPoint klientInfo = (IPEndPoint)kommSokkel.RemoteEndPoint;
            //IPEndPoint serverInfo = (IPEndPoint)kommSokkel.LocalEndPoint;

            //Thread thread = new Thread

            //thread.Start();

            //MessageBox.Show("Har forbindelse med {0} på port {1}, server bruker {2} og port {3}",
            //    klientInfo.Address.ToString(),
            //    klientInfo.Port.ToString(),
            //    serverInfo.Address.ToString(),
            //    serverInfo.Port.ToString());

            //byte[] data = new byte[1024];

            //string hilsen = "OK fra sentral";
            //data = Encoding.ASCII.GetBytes(hilsen);
            //kommSokkel.Send(data, data.Length, SocketFlags.None);
            // MessageBox.Show("koblet til monitor");
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

//private void KlientrtTraad(object state)
//{
//Socket kommSocket = state as Socket;
//IPEndPoint klientInfo = (IPEndPoint)kommSocket.RemoteEndPoint;
//IPEndPoint serverInfo = (IPEndPoint)kommSocket.LocalEndPoint;
///*
//s.Connect (lep);

//Using the RemoteEndPoint property.
//Console.WriteLine ("I am connected to " + IPAddress.Parse (((IPEndPoint)s.RemoteEndPoint).Address.ToString ()) + "on port number " + ((IPEndPoint)s.RemoteEndPoint).Port.ToString ());
//Using the LocalEndPoint property.
//Console.WriteLine ("My local IpAddress is :" + IPAddress.Parse (((IPEndPoint)s.LocalEndPoint).Address.ToString ()) + "I am connected on port number " + ((IPEndPoint)s.LocalEndPoint).Port.ToString ());
//*/




////listBox.Items.Add(("Har forbindelse med {0} på port {1}, server bruker {2} og port {3}",
////klientInfo.Address, klientInfo.Port, serverInfo.Address, serverInfo.Port));
//}