using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceYuebaolqdDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceYuebaolqdDetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 服务入参，格式为yyyymmdd
        /// </summary>
        [JsonProperty("report_date")]
        [XmlElement("report_date")]
        public string ReportDate { get; set; }
    }
}
