using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace XmlNodeFormat
{
    /// <summary>
    ///     展示如何使用Linq取XML中的回傳字串並轉型為List。。
    /// </summary>
    class XDocumentToList_Linq
    {
        #region XML 回應
        public static readonly string xmlRetrun =
@"
<root>
    <Status>1</Status>
    <Message>Sucess</Message>
    <ErrorCode/>
    <DataInfo>
        <Company>
            <Id>BF724494-E7D2-47AA-AE0C-45FE752F7E19</Id>
            <Code>H1N7</Code>
            <Name>代理商(H1N7)</Name>
        </Company>
        <Company>
            <Id>E548D1C3-1608-4988-A264-46EED9F3D061</Id>
            <Code>H1N5</Code>
            <Name>代理商(H1N5)</Name>
        </Company>
        <Company>
            <Id>460952DB-5E34-468F-A728-705DAB2627AA</Id>
            <Code>H1N1</Code>
            <Name>代理商(H1N1)</Name>
        </Company>
        <Company>
            <Id>14A06D0F-1A5A-42F4-8F0F-72424CC3A581</Id>
            <Code>H1N2</Code>
            <Name>代理商(H1N2)</Name>
        </Company>
        <Company>
            <Id>EDCE4651-F69A-4591-AF78-8A5C33B24F8C</Id>
            <Code>RGSYS</Code>
            <Name>RGSYS</Name>
        </Company>
        <Company>
            <Id>426FEF87-59BE-4DE1-9927-8C2C093F3F21</Id>
            <Code>H1N0</Code>
            <Name>代理商(H1N0)</Name>
        </Company>
        <Company>
            <Id>922867E3-B151-44C6-B090-A5935D565FAA</Id>
            <Code>RFSYS</Code>
            <Name>RFSYS</Name>
        </Company>
        <Company>
            <Id>AA906D17-80E1-4ED9-95A5-B97BB3D9C3FC</Id>
            <Code>H1N3</Code>
            <Name>代理商(H1N3)</Name>
        </Company>
        <Company>
            <Id>ECC63D3F-D60D-41BE-81CA-BDACC1C6B332</Id>
            <Code>H1N8</Code>
            <Name>代理商(H1N8)</Name>
        </Company>
        <Company>
            <Id>E4408D4D-A839-4AB5-9E93-C1D509EE1541</Id>
            <Code>Royal</Code>
            <Name>Royal</Name>
        </Company>
        <Company>
            <Id>E4408D4D-A839-4AB5-9E93-C1D509EE1542</Id>
            <Code>H1TEST</Code>
            <Name>H1TEST</Name>
        </Company>
        <Company>
            <Id>8E2B0F45-BBDE-4A85-9A7C-C65ABCCD68CB</Id>
            <Code>H1N9</Code>
            <Name>代理商(H1N9)</Name>
        </Company>
        <Company>
            <Id>E7F7EEDC-A343-4EBE-84E2-D7B7BDF2B539</Id>
            <Code>H1N6</Code>
            <Name>代理商(H1N6)</Name>
        </Company>
        <Company>
            <Id>68D2F570-B56C-4F8F-9F54-E9BC56527394</Id>
            <Code>H1N4</Code>
            <Name>代理商(H1N4)</Name>
        </Company>
        <Company>
            <Id>CF7861C7-556F-499A-890C-F9C7C4190266</Id>
            <Code>RXTEST</Code>
            <Name>預設代理商</Name>
        </Company>
    </DataInfo>
</root>";
        #endregion

        public List<Company> ReadXmlReturnList()
        {
            //  讀取字串，這邊模擬XML的回傳資料。
            StringReader stringReader = new StringReader(xmlRetrun);
            //  轉換成XML(可以使用Linq的XML，並非XmlDocument)
            XDocument xDocument = XDocument.Load(stringReader);

            //  建立List<T>
            List<Company> companys =
                (
                //  開始使用Linq
                //  從Xml中取出特定Node的資料。 root/DataInfo/Company
                from XmlCompantData in xDocument.Elements("root").Elements("DataInfo").Elements("Company")
                //  將找到的資料逐一塞入
                select new Company
                {
                    Id = XmlCompantData.Element("Id").Value,
                    Code = XmlCompantData.Element("Code").Value,
                    Name = XmlCompantData.Element("Name").Value
                }
                //  轉換成List
                ).ToList();
            return companys;
        }
        public class Company
        {
            /// <summary>
            ///     Token(大寫)
            /// </summary>
            internal string Id;
            /// <summary>
            ///     編碼
            /// </summary>
            internal string Code;
            /// <summary>
            ///     公司名稱
            /// </summary>
            internal string Name;
        }

    }
}
