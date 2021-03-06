﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using WooCommerceNET.Base;

namespace WooCommerceNET.WooCommerce
{
    public class OrderBatch
    {
        [DataMember(EmitDefaultValue = false)]
        public OrderList create { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public OrderList update { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<int> delete { get; set; }
    }

    [CollectionDataContract]
    public class OrderList : List<Order>
    {
        [DataMember]
        public List<Order> orders { get; set; }
    }

    [DataContract]
    public class Order : JsonObject
    {
        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? id { get; set; }

        /// <summary>
        /// Parent order ID.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? parent_id { get; set; }

        /// <summary>
        /// Order status. Default is pending. Options (plugins may include new status): pending, processing, on-hold, completed, cancelled, refunded and failed.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string status { get; set; }

        /// <summary>
        /// Order key. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string order_key { get; set; }

        /// <summary>
        /// Currency the order was created with, in ISO format, e.g USD. Default is the current store currency.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string currency { get; set; }

        /// <summary>
        /// Version of WooCommerce when the order was made. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string version { get; set; }

        /// <summary>
        /// Shows if the prices included tax during checkout. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public bool? prices_include_tax { get; set; }

        /// <summary>
        /// The date the order was created, in the site’s timezone. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public DateTime? date_created { get; set; }

        /// <summary>
        /// The date the order was last modified, in the site’s timezone. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public DateTime? date_modified { get; set; }

        /// <summary>
        /// User ID who owns the order. Use 0 for guests. Default is 0.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? customer_id { get; set; }

        /// <summary>
        /// Total discount amount for the order. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal? discount_total { get; set; }

        /// <summary>
        /// Total discount tax amount for the order. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal? discount_tax { get; set; }

        /// <summary>
        /// Total shipping amount for the order. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal? shipping_total { get; set; }

        /// <summary>
        /// Total shipping tax amount for the order. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal? shipping_tax { get; set; }

        /// <summary>
        /// Sum of line item taxes only. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal? cart_tax { get; set; }

        /// <summary>
        /// Grand total. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal? total { get; set; }

        /// <summary>
        /// Sum of all taxes. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal? total_tax { get; set; }

        /// <summary>
        /// Billing address. See Customer Billing Address properties.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public BillingAddress billing { get; set; }

        /// <summary>
        /// Shipping address. See Customer Shipping Address properties.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public ShippingAddress shipping { get; set; }

        /// <summary>
        /// Payment method ID.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string payment_method { get; set; }

        /// <summary>
        /// Payment method title.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string payment_method_title { get; set; }

        /// <summary>
        /// Define if the order is paid. It will set the status to processing and reduce stock items. Default is false. 
        /// write-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public bool? set_paid { get; set; }

        /// <summary>
        /// Unique transaction ID. In write-mode only is available if set_paid is true.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string transaction_id { get; set; }

        /// <summary>
        /// Customer’s IP address. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string customer_ip_address { get; set; }

        /// <summary>
        /// User agent of the customer. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string customer_user_agent { get; set; }

        /// <summary>
        /// Shows where the order was created. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string created_via { get; set; }

        /// <summary>
        /// Note left by customer during checkout.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string customer_note { get; set; }

        /// <summary>
        /// The date the order was completed, in the site’s timezone. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public DateTime? date_completed { get; set; }

        /// <summary>
        /// The date the order has been paid, in the site’s timezone. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false, Name = "date_paid")]
        private object date_paidValue { get; set; }

        public DateTime? date_paid { get; set; }

        /// <summary>
        /// MD5 hash of cart items to ensure orders are not modified. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string cart_hash { get; set; }

        /// <summary>
        /// Line items data. See Line Items properties.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public LineItemList line_items { get; set; }

        /// <summary>
        /// Tax lines data. See Tax Lines properties. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public TaxLineList tax_lines { get; set; }

        /// <summary>
        /// Shipping lines data. See Shipping Lines properties.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public ShippingLineList shipping_lines { get; set; }

        /// <summary>
        /// Fee lines data. See Fee Lines Properites.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public FeeLineList fee_lines { get; set; }

        /// <summary>
        /// Coupons line data. See Coupon Lines properties.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public CouponLineList coupon_lines { get; set; }
    }
    
    [CollectionDataContract]
    public class LineItemList : List<LineItem>
    {
        [DataMember]
        public List<LineItem> line_items { get; set; }
    }

    [DataContract]
    public class LineItem
    {
        /// <summary>
        /// Item ID. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? id { get; set; }

        /// <summary>
        /// Product name. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }

        /// <summary>
        /// Product SKU. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string sku { get; set; }

        /// <summary>
        /// Product ID.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? product_id { get; set; }

        /// <summary>
        /// Variation ID, if applicable.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? variation_id { get; set; }

        /// <summary>
        /// Quantity ordered.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? quantity { get; set; }

        /// <summary>
        /// Tax class of product. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string tax_class { get; set; }

        /// <summary>
        /// Product price. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal? price { get; set; }

        /// <summary>
        /// Line subtotal (before discounts).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal? subtotal { get; set; }

        /// <summary>
        /// Line subtotal tax (before discounts).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal? subtotal_tax { get; set; }

        /// <summary>
        /// Line total (after discounts).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal? total { get; set; }

        /// <summary>
        /// Line total tax (after discounts).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal? total_tax { get; set; }

        /// <summary>
        /// Line taxes with id, total and subtotal. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public TaxItemList taxes { get; set; }

        /// <summary>
        /// Line item meta data with key, label and value. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public MetaItemList meta { get; set; }
    }


    [CollectionDataContract]
    public class MetaItemList : List<MetaItem>
    {
        [DataMember]
        public List<MetaItem> metas { get; set; }
    }

    [DataContract]
    public class MetaItem
    {
        /// <summary>
        /// Meta item key
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string key { get; set; }

        /// <summary>
        /// Meta item label
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string label { get; set; }

        /// <summary>
        /// Meta item value
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string value { get; set; }
    }

    [CollectionDataContract]
    public class TaxItemList : List<TaxItem>
    {
        [DataMember]
        public List<TaxItem> taxes { get; set; }
    }

    [DataContract]
    public class TaxItem
    {
        /// <summary>
        /// tax item id
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? id { get; set; }

        /// <summary>
        /// tax item total
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal? total { get; set; }

        /// <summary>
        /// tax item subtotal
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal? subtotal { get; set; }
    }


    [CollectionDataContract]
    public class ShippingLineList : List<ShippingLine>
    {
        [DataMember]
        public List<ShippingLine> shipping_lines { get; set; }
    }

    [DataContract]
    public class ShippingLine
    {
        /// <summary>
        /// Item ID. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? id { get; set; }

        /// <summary>
        /// Shipping method name.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string method_title { get; set; }

        /// <summary>
        /// Shipping method ID. 
        /// required
        /// </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = true)]
        public string method_id { get; set; }

        /// <summary>
        /// Line total (after discounts).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal? total { get; set; }

        /// <summary>
        /// Line total tax (after discounts). 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal? total_tax { get; set; }

        /// <summary>
        /// Line taxes with id and total. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public TaxItemList taxes { get; set; }
    }


    [CollectionDataContract]
    public class TaxLineList : List<TaxLine>
    {
        [DataMember]
        public List<TaxLine> tax_lines { get; set; }
    }

    public class TaxLine
    {
        /// <summary>
        /// Item ID. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? id { get; set; }

        /// <summary>
        /// Tax rate code. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string rate_code { get; set; }

        /// <summary>
        /// Tax rate ID. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string rate_id { get; set; }

        /// <summary>
        /// Tax rate label. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string label { get; set; }

        /// <summary>
        /// Show if is a compound tax rate. Compound tax rates are applied on top of other tax rates. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public bool? compound { get; set; }

        /// <summary>
        /// Tax total (not including shipping taxes). 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal? tax_total { get; set; }

        /// <summary>
        /// Shipping tax total. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal? shipping_tax_total { get; set; }
    }


    [CollectionDataContract]
    public class FeeLineList : List<FeeLine>
    {
        [DataMember]
        public List<FeeLine> fee_lines { get; set; }
    }

    [DataContract]
    public class FeeLine
    {
        /// <summary>
        /// Item ID. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? id { get; set; }

        /// <summary>
        /// Fee name. 
        /// required
        /// </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = true)]
        public string name { get; set; }

        /// <summary>
        /// Tax class. 
        /// required if the fee is taxable
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string tax_class { get; set; }

        /// <summary>
        /// Tax status of fee. Set to taxable if need apply taxes.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string tax_status { get; set; }

        /// <summary>
        /// Line total (after discounts).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal? total { get; set; }

        /// <summary>
        /// Line total tax (after discounts).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal? total_tax { get; set; }

        /// <summary>
        /// Line taxes with id, total and subtotal. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public TaxItemList taxes { get; set; }
    }


    [CollectionDataContract]
    public class CouponLineList : List<CouponLine>
    {
        [DataMember]
        public List<CouponLine> coupon_lines { get; set; }
    }

    [DataContract]
    public class CouponLine
    {
        /// <summary>
        /// Item ID. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? id { get; set; }

        /// <summary>
        /// Coupon code. 
        /// required
        /// </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = true)]
        public string code { get; set; }

        /// <summary>
        /// Discount total. 
        /// required
        /// </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = true)]
        public decimal? discount { get; set; }

        /// <summary>
        /// Discount total tax. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal? discount_tax { get; set; }
    }


    [CollectionDataContract]
    public class OrderNoteList : List<OrderNote>
    {
        [DataMember]
        public List<OrderNote> order_notes { get; set; }
    }

    [DataContract]
    public class OrderNote
    {
        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? id { get; set; }

        /// <summary>
        /// The date the order note was created, in the site’s timezone. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public DateTime? date_created { get; set; }

        /// <summary>
        /// Order note. 
        /// required
        /// </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = true)]
        public string note { get; set; }

        /// <summary>
        /// Shows/define if the note is only for reference or for the customer (the user will be notified). Default is false.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public bool? customer_note { get; set; }
    }


    [CollectionDataContract]
    public class OrderRefundList : List<OrderRefund>
    {
        [DataMember]
        public List<OrderRefund> order_refunds { get; set; }
    }

    [DataContract]
    public class OrderRefund
    {
        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? id { get; set; }

        /// <summary>
        /// The date the order refund was created, in the site’s timezone. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public DateTime? date_created { get; set; }

        /// <summary>
        /// Refund amount. 
        /// required
        /// </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = true)]
        public decimal? amount { get; set; }

        /// <summary>
        /// Reason for refund.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string reason { get; set; }

        /// <summary>
        /// Line items data. See Refunds Line Items properties.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public OrderRefundLineList line_items { get; set; }
    }

    [CollectionDataContract]
    public class OrderRefundLineList : List<OrderRefundLine>
    {
        [DataMember]
        public List<OrderRefundLine> orderrefundlines { get; set; }
    }

    [DataContract]
    public class OrderRefundLine
    {
        /// <summary>
        /// Item ID. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? id { get; set; }

        /// <summary>
        /// Product name. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string name { get; set; }

        /// <summary>
        /// Product SKU. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string sku { get; set; }

        /// <summary>
        /// Product ID.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? product_id { get; set; }

        /// <summary>
        /// Variation ID, if applicable.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? variation_id { get; set; }

        /// <summary>
        /// Quantity ordered.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int? quantity { get; set; }

        /// <summary>
        /// Tax class of product. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string tax_class { get; set; }

        /// <summary>
        /// Product price. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal? price { get; set; }

        /// <summary>
        /// Line subtotal (before discounts).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal? subtotal { get; set; }

        /// <summary>
        /// Line subtotal tax (before discounts).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal? subtotal_tax { get; set; }

        /// <summary>
        /// Line total (after discounts).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal? total { get; set; }

        /// <summary>
        /// Line total tax (after discounts).
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public decimal? total_tax { get; set; }

        /// <summary>
        /// Line total tax with id, total and subtotal. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public TaxItemList taxes { get; set; }

        /// <summary>
        /// Line item meta data with key, label and value. 
        /// read-only
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public MetaItemList meta { get; set; }
    }
}
