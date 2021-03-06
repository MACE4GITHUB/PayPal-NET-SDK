//==============================================================================
//
//  This file was auto-generated by a tool using the PayPal REST API schema.
//  More information: https://developer.paypal.com/docs/api/
//
//==============================================================================
using Newtonsoft.Json;

namespace PayPal.Api
{
    /// <summary>
    /// The custom amount to apply to an invoice. If you include a label, you must include a custom amount.
    /// <para>
    /// See <a href="https://developer.paypal.com/docs/api/">PayPal Developer documentation</a> for more information.
    /// </para>
    /// </summary>
    public class CustomAmount : PayPalSerializableObject
    {
        /// <summary>
        /// The custom amount label.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "label")]
        public string label { get; set; }

        /// <summary>
        /// The custom amount value. Valid value is from -999999.99 to 999999.99.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "amount")]
        public Currency amount { get; set; }
    }
}
