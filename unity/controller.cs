using WebSocketSharp;

namespace myfirstapp{
    public class Program {
        static void Main(string[] args){
            WebSocket ws = new WebSocket("ws://localhost:8081");
            ws.OnMessage += (sender, e) =>
            Console.WriteLine ("Laputa says: " + e.Data);

            ws.Connect();
            ws.Send ("BALUS");
        }
    }

}
