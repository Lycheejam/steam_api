using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Runtime.Serialization;
using System.Web;
using System.Runtime.Serialization.Json;

namespace steam_api
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void actBtn_Click(object sender, EventArgs e)
        {
            if (idBox.Text != "")
            {
                try
                {
                    // URLエンコーディング
                    string url = "http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key=XXX_api_key_XXX&steamids=";
                    // HTTPアクセス
                    WebRequest req = WebRequest.Create(url + idBox.Text);

                    WebResponse res = req.GetResponse();
                    // レスポンス(JSON)をオブジェクトに変換
                    SteamStats sstats;
                    using (res)
                    {
                        using (var resStream = res.GetResponseStream())
                        {
                            var serializer = new DataContractJsonSerializer(typeof(SteamStats));
                            sstats = (SteamStats)serializer.ReadObject(resStream);
                        }
                    }
                    // 結果を出力
                    foreach (var s in sstats.response.players)
                    {
                        nameBox.Text = s.realname;
                        pb1.ImageLocation = s.avatarfull;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }

    [DataContract]
    public class SteamStats
    {
        [DataMember]
        public Response response { get; set; }
    }
    [DataContract]
    public class Response
    {
        [DataMember]
        public List<Player> players { get; set; }

        [DataContract]
        public class Player
        {
            [DataMember]
            public string steamid { get; set; }
            [DataMember]
            public string communityvisibilitystate { get; set; }
            [DataMember]
            public string profilestate { get; set; }
            [DataMember]
            public string personaname { get; set; }
            [DataMember]
            public long lastlogoff { get; set; }
            [DataMember]
            public string profileurl { get; set; }
            [DataMember]
            public string avatar { get; set; }
            [DataMember]
            public string avatarmedium { get; set; }
            [DataMember]
            public string avatarfull { get; set; }
            [DataMember]
            public string personastate { get; set; }
            [DataMember]
            public string realname { get; set; }
            [DataMember]
            public string primaryclanid { get; set; }
            [DataMember]
            public long timecreated { get; set; }
            [DataMember]
            public int personastateflags { get; set; }
            [DataMember]
            public string loccountrycode { get; set; }
            [DataMember]
            public string locstatecode { get; set; }
            [DataMember]
            public int loccityid { get; set; }
        }
    }
 
}
