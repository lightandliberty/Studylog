using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FreeNet;
using System.Net.Sockets;

namespace StudyLog.Server
{
    public partial class HostForm : Form
    {
        static List<CUser> userList;
        public bool isHost = false;
        CNetworkService service;
        string ipAddress;
        string port = ", 7979";
        public HostForm()
        {
            InitializeComponent();
        }

        private void HostForm_Load(object sender, EventArgs e)
        {
            HostInit();
//            ipAddress = GetIPAddress();
            ipAddress = GetIPAddress_FromUDPEndpoint() + ", 7979";
        }

        private void hostPN_Click(object sender, EventArgs e)
        {
            isHost = !isHost;
            if (isHost)
                HostOn();
            else
                HostOff();
        }

        private string GetIPAddress()
        {
            IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
            for(int i = 0; i < hostEntry.AddressList.Length; i++)
            {
                if (hostEntry.AddressList[i].AddressFamily != System.Net.Sockets.AddressFamily.InterNetwork)  // ipv6는 System.Net.Sockets.AddressFamily.InterNetworkV6 사용
                    continue;
                else
                    return hostEntry.AddressList[i].ToString();
            }
            return "";
        }

        private string GetIPAddress_FromUDPEndpoint()
        {
            string localIP = string.Empty;
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                localIP = endPoint.Address.ToString();
            }
            return localIP;
        }

        private void HostInit()
        {
            CPacketBufferManager.Initialize(2000);
            userList = new List<CUser>();
            service = new CNetworkService();
            // 콜백 메서드 호출
            service.session_created_callback += OnSessionCreated;
            // 초기화
            service.Initialize();
        }

        private void HostOn()
        {
            // IPAddress.Any와 7979포트로 접속 받아들임.
            service.Listen("0.0.0.0", 7979, 100);
            this.hostPN.TextString = "호스트\r\n" + ipAddress;

        }

        private void HostOff()
        {
                service.ListenStop();
                lock (userList)
                {
                    userList.ForEach(user => userList.Remove(user));
                }
                this.hostPN.TextString = "호스트\r\n접속 받기";
                this.hostPN.Refresh();
        }

        /// <summary>
        /// 클라이언트가 접속 완료하였을 때 호출됨.
        /// n개의 워커 스레드에서 호출될 수 있으므로, 공유 자원(유저 리스트) 접근시 동기화 처리해야 함.
        /// </summary>
        /// <param name="token"></param>
        static void OnSessionCreated(CUserToken token)
        {
            // token.peer에 CUser메서드들을 묶고, token을 CUser에 저장.
            CUser user = new CUser(token);
            // CUser를 userList에 추가.
            lock(userList)
            {
                userList.Add(user);
            }
        }

        public static void RemoveUser(CUser user)
        {
            lock(userList)
            {
                userList.Remove(user);
            }
        }

        private void HostForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isHost) // 호스트를 연 상태면, 닫음.
                HostOff();
            //lock(userList)
            //{
            //    userList.ForEach(user => userList.Remove(user));
            //}
        }
    }
}
