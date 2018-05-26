using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringOrderPayQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringOrderPayQueryModel : AlipayObject
    {
        /// <summary>
        /// 外部支付订单号,唯一标识本次支付的requestID
        /// </summary>
        [JsonProperty("out_pay_no")]
        [XmlElement("out_pay_no")]
        public string OutPayNo { get; set; }

        /// <summary>
        /// pos业务订单外部主键信息
        /// </summary>
        [JsonProperty("pos_order_key")]
        [XmlElement("pos_order_key")]
        public PosOrderKey PosOrderKey { get; set; }
    }
}
