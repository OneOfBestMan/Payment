using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataMallIndicatorQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataMallIndicatorQueryModel : AlipayObject
    {
        /// <summary>
        /// 开始日期,格式:yyyyMMdd
        /// </summary>
        [JsonProperty("begin_date")]
        [XmlElement("begin_date")]
        public string BeginDate { get; set; }

        /// <summary>
        /// 业务类型，目前可选值有5个  1，mallIndustryMemberStatistics 商户会员统计信息  2，mallIndustryTradeStatistics 行业交易统计信息  3，mallIndustryEventStatistics 行业活动统计信息  4，mallIndustryInfo 最新的行业维表信息  5，mallIndustryConsumptionStatistics MALL消费能力统计信息
        /// </summary>
        [JsonProperty("biz_type")]
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 结束日期,格式:yyyyMMdd
        /// </summary>
        [JsonProperty("end_date")]
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// camp_id：为活动ID  order_by：为排序指标KEY，目前只支持文档中给出的例子字段  order_type：ASC表示升序,DESC表示降序  cate_1_ids：为门店ID，多个门店使用逗号分隔
        /// </summary>
        [JsonProperty("ext_info")]
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 当前页数，默认为1
        /// </summary>
        [JsonProperty("page_num")]
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录数,不能超过50。默认为20
        /// </summary>
        [JsonProperty("page_size")]
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
