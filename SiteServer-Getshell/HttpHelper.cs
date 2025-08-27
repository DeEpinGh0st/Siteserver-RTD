using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;
using System.IO.Compression;
using System.Web;

namespace WHC.OrderWater.Commons
{
    public class HttpHelper
    {
        #region ˽�б���
        private CookieContainer cc;
        private string contentType = "application/x-www-form-urlencoded";
        private string accept = "image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/x-shockwave-flash, application/x-silverlight, application/vnd.ms-excel, application/vnd.ms-powerpoint, application/msword, application/x-ms-application, application/x-ms-xbap, application/vnd.ms-xpsdocument, application/xaml+xml, application/x-silverlight-2-b1, */*";
        private string userAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; .NET CLR 2.0.50727; .NET CLR 3.0.04506.648; .NET CLR 3.5.21022)";
        
        private Encoding encoding = Encoding.GetEncoding("utf-8");
        private int delay = 1000;
        private int maxTry = 3;
        private int currentTry = 0;
        #endregion

        #region ����

        public string ContentType
        {
            get { return contentType; }
            set { contentType = value; }
        }

        public string Accept
        {
            get { return accept; }
            set { accept = value; }
        }

        public string UserAgent
        {
            get { return userAgent; }
            set { userAgent = value; }
        }  

        /// <summary>
        /// Cookie����
        /// </summary>
        public CookieContainer CookieContainer
        {
            get
            {
                return cc;
            }
        }

        /// <summary>
        /// ��ȡ��ҳԴ��ʱʹ�õı���
        /// </summary>
        /// <value></value>
        public Encoding Encoding
        {
            get
            {
                return encoding;
            }
            set
            {
                encoding = value;
            }
        }

        public int NetworkDelay
        {
            get
            {
                Random r = new Random();
                return (r.Next(delay / 1000, delay / 1000 * 2))*1000;
            }
            set
            {
                delay = value;
            }
        }

        public int MaxTry
        {
            get
            {
                return maxTry;
            }
            set
            {
                maxTry = value;
            }
        }
        #endregion

        #region ���캯��
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpHelper"/> class.
        /// </summary>
        public HttpHelper()
        {
            cc = new CookieContainer();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpHelper"/> class.
        /// </summary>
        /// <param name="cc">The cc.</param>
        public HttpHelper(CookieContainer cc)
        {
            this.cc = cc;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpHelper"/> class.
        /// </summary>
        /// <param name="contentType">Type of the content.</param>
        /// <param name="accept">The accept.</param>
        /// <param name="userAgent">The user agent.</param>
        public HttpHelper(string contentType, string accept, string userAgent)
        {
            this.contentType = contentType;
            this.accept = accept;
            this.userAgent = userAgent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpHelper"/> class.
        /// </summary>
        /// <param name="cc">The cc.</param>
        /// <param name="contentType">Type of the content.</param>
        /// <param name="accept">The accept.</param>
        /// <param name="userAgent">The user agent.</param>
        public HttpHelper(CookieContainer cc, string contentType, string accept, string userAgent)
        {
            this.cc = cc;
            this.contentType = contentType;
            this.accept = accept;
            this.userAgent = userAgent;
        }
        #endregion

        #region ��������
                        
        /// <summary>
        /// ��ȡָ��ҳ���HTML����
        /// </summary>
        /// <param name="url">ָ��ҳ���·��</param>
        /// <param name="postData">�ط�������</param>
        /// <param name="isPost">�Ƿ���post��ʽ��������</param>
        /// <param name="cookieCollection">Cookie����</param>
        /// <returns></returns>
        public string GetHtml(string url, CookieContainer cookieContainer, string postData, bool isPost)
        {
            return GetHtml(url, cookieContainer, postData, isPost, url);
        }

        /// <summary>
        /// ��ȡָ��ҳ���HTML����
        /// </summary>
        /// <param name="url">ָ��ҳ���·��</param>
        /// <param name="postData">�ط�������</param>
        /// <param name="isPost">�Ƿ���post��ʽ��������</param>
        /// <param name="cookieCollection">Cookie����</param>
        /// <returns></returns>
        public string GetHtml(string url, CookieContainer cookieContainer, string postData, bool isPost, string referer)
        {
            if (string.IsNullOrEmpty(postData))
            {
                CookieCollection Cookie = new CookieCollection();
                return GetHtml(url, cookieContainer, referer);
            }

            //Thread.Sleep(NetworkDelay);
            currentTry++;
            try
            {
                byte[] byteRequest = Encoding.Default.GetBytes(postData);

                HttpWebRequest httpWebRequest;
                httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
                httpWebRequest.CookieContainer = cookieContainer;
                httpWebRequest.ContentType = contentType;
                httpWebRequest.Referer = referer;
                httpWebRequest.Accept = accept;
                httpWebRequest.Headers["User-Agent"] = userAgent;
                httpWebRequest.Method = isPost ? "POST" : "GET";
                httpWebRequest.ContentLength = byteRequest.Length;

                httpWebRequest.AllowAutoRedirect = false;

                Stream stream = httpWebRequest.GetRequestStream();
                stream.Write(byteRequest, 0, byteRequest.Length);
                stream.Close();

                HttpWebResponse httpWebResponse;
                try
                {
                    httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    //redirectURL = httpWebResponse.Headers["Location"];// Get redirected uri
                }
                catch (WebException ex)
                {
                    httpWebResponse = (HttpWebResponse)ex.Response;
                }
                Stream responseStream = httpWebResponse.GetResponseStream();
                StreamReader streamReader = new StreamReader(responseStream, encoding);
                string html = streamReader.ReadToEnd();
                streamReader.Close();
                responseStream.Close();

                currentTry = 0;
                return html;
            }
            catch (Exception e)
            {
                if (currentTry <= maxTry)
                {
                    GetHtml(url, cookieContainer, postData, isPost);
                }

                currentTry = 0;
                return string.Empty;
            }
        }

        /// <summary>
        /// ��ȡָ��ҳ���HTML����
        /// </summary>
        /// <param name="url">ָ��ҳ���·��</param>
        /// <param name="cookieCollection">Cookie����</param>
        /// <returns></returns>
        public string GetHtml(string url, CookieContainer cookieContainer, string reference)
        {
            //Thread.Sleep(NetworkDelay);
            currentTry++;

            try
            {
                HttpWebRequest httpWebRequest;
                httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
                httpWebRequest.CookieContainer = cookieContainer;
                httpWebRequest.ContentType = contentType;
                httpWebRequest.Referer = reference;
                httpWebRequest.Accept = accept;
                httpWebRequest.Headers["User-Agent"] = userAgent;
                httpWebRequest.Method = "GET";

                HttpWebResponse httpWebResponse;
                httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                Stream responseStream = httpWebResponse.GetResponseStream();
                StreamReader streamReader = new StreamReader(responseStream, encoding);
                string html = streamReader.ReadToEnd();
                streamReader.Close();
                responseStream.Close();

                currentTry = 0;
                return html;
            }
            catch (Exception e)
            {
                if (currentTry <= maxTry)
                {
                    GetHtml(url, cookieContainer, reference);
                }

                currentTry = 0;
                return string.Empty;
            }
        }
        /// <summary>
        /// ��ȡָ��ҳ���HTML����
        /// </summary>
        /// <param name="url">ָ��ҳ���·��</param>
        /// <returns></returns>
        public string GetHtml(string url)
        {
            return GetHtml(url, cc, url);
        }

        /// <summary>
        /// ��ȡָ��ҳ���HTML����
        /// </summary>
        /// <param name="url">ָ��ҳ���·��</param>
        /// <returns></returns>
        public string GetHtml(string url, string reference)
        {
            return GetHtml(url, cc, reference);
        }
        /// <summary>
        /// ��ȡָ��ҳ���HTML����
        /// </summary>
        /// <param name="url">ָ��ҳ���·��</param>
        /// <param name="postData">�ط�������</param>
        /// <param name="isPost">�Ƿ���post��ʽ��������</param>
        /// <returns></returns>
        public string GetHtml(string url, string postData, bool isPost)
        {
            string redirectUrl = "";
            return GetHtml(url, cc, postData, isPost, redirectUrl);
        }
                        
        /// <summary>
        /// ��ȡָ��ҳ���Stream
        /// </summary>
        /// <param name="url">ָ��ҳ���·��</param>
        /// <param name="postData">�ط�������</param>
        /// <param name="isPost">�Ƿ���post��ʽ��������</param>
        /// <param name="cookieCollection">Cookie����</param>
        /// <returns></returns>
        public Stream GetStream(string url, CookieContainer cookieContainer)
        {
            return GetStream(url, cookieContainer, url);
        }

        /// <summary>
        /// ��ȡָ��ҳ���Stream
        /// </summary>
        /// <param name="url">ָ��ҳ���·��</param>
        /// <param name="postData">�ط�������</param>
        /// <param name="isPost">�Ƿ���post��ʽ��������</param>
        /// <param name="cookieCollection">Cookie����</param>
        /// <returns></returns>
        public Stream GetStream(string url, CookieContainer cookieContainer, string reference)
        {
            //Thread.Sleep(delay);

            currentTry++;
            try
            {
                HttpWebRequest httpWebRequest;
                httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
                httpWebRequest.CookieContainer = cookieContainer;
                httpWebRequest.ContentType = contentType;
                httpWebRequest.Referer = reference;
                httpWebRequest.Accept = accept;
                httpWebRequest.Headers["User-Agent"] = userAgent;
                httpWebRequest.Method = "GET";

                HttpWebResponse httpWebResponse;
                httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                Stream responseStream = httpWebResponse.GetResponseStream();
                currentTry = 0;
                return responseStream;
            }
            catch (Exception e)
            {
                if (currentTry <= maxTry)
                {
                    CookieCollection cookie = new CookieCollection();
                    GetHtml(url, cookieContainer, url);
                }

                currentTry = 0;
                return null;
            }
        }

        public CookieCollection GetCookieCollection(string cookieString)
        {
            CookieCollection cc = new CookieCollection();
            //string cookieString = "SID=ARRGy4M1QVBtTU-ymi8bL6X8mVkctYbSbyDgdH8inu48rh_7FFxHE6MKYwqBFAJqlplUxq7hnBK5eqoh3E54jqk=;Domain=.google.com;Path=/,LSID=AaMBTixN1MqutGovVSOejyb8mVkctYbSbyDgdH8inu48rh_7FFxHE6MKYwqBFAJqlhCe_QqxLg00W5OZejb_UeQ=;Domain=www.google.com;Path=/accounts";
            Regex re = new Regex("([^;,]+)=([^;,]+);Domain=([^;,]+);Path=([^;,]+)", RegexOptions.IgnoreCase);
            foreach (Match m in re.Matches(cookieString))
            {
                //name,   value,   path,   domain   
                Cookie c = new Cookie(m.Groups[1].Value, m.Groups[2].Value, m.Groups[3].Value, m.Groups[3].Value);
                cc.Add(c);
            }
            return cc;
        }

        /// <summary>
        /// ��ȡHTMLҳ�����ƶ�Key��Value����
        /// </summary>
        /// <param name="html"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetHiddenKeyValue(string html, string key)
        {
            string result = "";
            string sRegex = string.Format("<input\\s*type=\"hidden\".*?name=\"{0}\".*?\\s*value=[\"|'](?<value>.*?)[\"|'^/]", key);
            Regex re = new Regex(sRegex, RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline);
            Match mc = re.Match(html);
            if (mc.Success)
            {
                result = mc.Groups[1].Value;
            }
            return result;
        }

        public string GetEncoding(string url)
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            StreamReader reader = null;
            try
            {
                request = (HttpWebRequest)WebRequest.Create(url);
                request.Timeout = 20000;
                request.AllowAutoRedirect = false;
                response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK && response.ContentLength < 1024 * 1024)
                {
                    if (response.ContentEncoding != null && response.ContentEncoding.Equals("gzip", StringComparison.InvariantCultureIgnoreCase))
                    {
                        reader = new StreamReader(new GZipStream(response.GetResponseStream(), CompressionMode.Decompress));
                    }
                    else
                    {
                        reader = new StreamReader(response.GetResponseStream(), Encoding.ASCII);
                    }
                    
                    string html = reader.ReadToEnd();
                    Regex reg_charset = new Regex(@"charset\b\s*=\s*(?<charset>[^""]*)");
                    if (reg_charset.IsMatch(html))
                    {
                        return reg_charset.Match(html).Groups["charset"].Value;
                    }
                    else if (response.CharacterSet != string.Empty)
                    {
                        return response.CharacterSet;
                    }
                    else
                    {
                        return Encoding.Default.BodyName;
                    }
                }
            }
            catch
            {
            }
            finally
            {
                if (response != null)
                {
                    response.Close();
                    response = null;
                }
                if (reader != null)
                    reader.Close();
                if (request != null)
                    request = null;
            }
            return Encoding.Default.BodyName;
        }

        /// <summary>
        /// �ж�URL�Ƿ���Ч
        /// </summary>
        /// <param name="url">���жϵ�URL����������ҳ�Լ�ͼƬ���ӵ�</param>
        /// <returns>200Ϊ��ȷ������Ϊ������ҳ�������</returns>
        public int GetUrlError(string url)
        {
            int num = 200;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
                ServicePointManager.Expect100Continue = false;
                ((HttpWebResponse)request.GetResponse()).Close();
            }
            catch (WebException exception)
            {
                if (exception.Status != WebExceptionStatus.ProtocolError)
                {
                    return num;
                }
                if (exception.Message.IndexOf("500 ") > 0)
                {
                    return 500;
                }
                if (exception.Message.IndexOf("401 ") > 0)
                {
                    return 401;
                }
                if (exception.Message.IndexOf("404") > 0)
                {
                    num = 404;
                }
            }
            catch
            {
                num = 401;
            }
            return num;
        }

        /// <summary>
        /// �Ƴ�Html���
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public string RemoveHtml(string content)
        {
            string regexstr = @"<[^>]*>";
            return Regex.Replace(content, regexstr, string.Empty, RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// ���� HTML �ַ����ı�����
        /// </summary>
        /// <param name="inputData">�ַ���</param>
        /// <returns>������</returns>
        public static string HtmlEncode(string inputData)
        {
            return HttpUtility.HtmlEncode(inputData);
        }

        /// <summary>
        /// ���� HTML �ַ����Ľ�����
        /// </summary>
        /// <param name="str">�ַ���</param>
        /// <returns>������</returns>
        public static string HtmlDecode(string str)
        {
            return HttpUtility.HtmlDecode(str);
        }

        #endregion
    }
}
