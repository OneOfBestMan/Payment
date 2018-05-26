using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAgreementSignConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAgreementSignConfirmModel : AlipayObject
    {
        /// <summary>
        /// 代扣签约申请时，支付宝返回的签约申请token，商户可利用该值完成签约的确认。
        /// </summary>
        [JsonProperty("apply_token")]
        [XmlElement("apply_token")]
        public string ApplyToken { get; set; }

        /// <summary>
        /// 支付宝用户的身份证后4位。  签约确认接口目前只有国际极简会校验身份证后4位。
        /// </summary>
        [JsonProperty("cert_no")]
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 能唯一确认用户身份的标识号，如：手机验证码等。
        /// </summary>
        [JsonProperty("confirm_no")]
        [XmlElement("confirm_no")]
        public string ConfirmNo { get; set; }
    }
}
