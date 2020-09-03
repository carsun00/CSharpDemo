using ASP.Net_OpenAPIWithSwagger.AgentBackstage;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OpenAPIClineDemo
{
    /// <summary>
    ///     展示如何在Framework中，使用OPENAPI(Swagger)
    ///     
    ///     安裝
    ///         1.  VS 2019中點選[延伸模組 -> 管理延伸模組]
    ///         2.  尋找 [ Unchase OpenAPI (Swagger) Connected Service ]並下載
    ///         3.  重新啟動VS 2019已完成安裝
    ///     
    ///     加入參考
    ///         1.  [ASP.Net_OpenAPIWithSwagger]中點選[ 右鍵 -> 加入 ->　連線服務]
    ///         2.  [其他服務 -> Unchase OpenAPI (Swagger) Connected Service ]
    ///         3.  在[Specification Endpoint -> 輸入你的網址列]、
    ///         4.  選擇妳要產生的檔案類型，這邊選擇[Generate CSharp Client]。
    ///         5.  在[CSharp Client Settings]中設定連線的指定方式
    ///         
    ///             A.  Client 底下的 
    ///                 [ Use the base URL for the request ] - 自行指定
    ///                 [ Generate the BaseUrl property(must be defined on the bass class otherwise). ] - 寫死在程式
    ///             B.  Inject HttpClient via constructor (life cycle is managed by the caller)     - 使用CLIENT
    ///         
    ///         6.  可以單獨設定要載入的部分[DTO Class]
    ///             Exclude type names later (in a sperated window)
    ///             
    ///     實作
    ///         參考下方使用方式。
    /// </summary>
    class Program
    {
        static async Task Main(string[] args)
        {

            HttpClient client_ = new HttpClient() 
            { 
                BaseAddress = new Uri("http://210.66.176.243:2244/") 
            };


            Client cl = new Client(client_);
            var tr = await cl.ApiNewsLanguageAsync("zh-tw");
            Console.WriteLine(tr);

            Console.WriteLine(JsonConvert.SerializeObject(tr));
        }
    }
}
