// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> Modern usage detail. </summary>
    public partial class ConsumptionModernUsageDetail : ConsumptionUsageDetail
    {
        /// <summary> Initializes a new instance of <see cref="ConsumptionModernUsageDetail"/>. </summary>
        internal ConsumptionModernUsageDetail()
        {
            Kind = UsageDetailsKind.Modern;
        }

        /// <summary> Initializes a new instance of <see cref="ConsumptionModernUsageDetail"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Specifies the kind of usage details. </param>
        /// <param name="etag"> The etag for the resource. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="billingAccountId"> Billing Account identifier. </param>
        /// <param name="effectivePrice"> Effective Price that's charged for the usage. </param>
        /// <param name="pricingModel"> Identifier that indicates how the meter is priced. </param>
        /// <param name="billingAccountName"> Name of the Billing Account. </param>
        /// <param name="billingPeriodStartOn"> Billing Period Start Date as in the invoice. </param>
        /// <param name="billingPeriodEndOn"> Billing Period End Date as in the invoice. </param>
        /// <param name="billingProfileId"> Identifier for the billing profile that groups costs across invoices in the a singular billing currency across across the customers who have onboarded the Microsoft customer agreement and the customers in CSP who have made entitlement purchases like SaaS, Marketplace, RI, etc. </param>
        /// <param name="billingProfileName"> Name of the billing profile that groups costs across invoices in the a singular billing currency across across the customers who have onboarded the Microsoft customer agreement and the customers in CSP who have made entitlement purchases like SaaS, Marketplace, RI, etc. </param>
        /// <param name="subscriptionGuid"> Unique Microsoft generated identifier for the Azure Subscription. </param>
        /// <param name="subscriptionName"> Name of the Azure Subscription. </param>
        /// <param name="on"> Date for the usage record. </param>
        /// <param name="product"> Name of the product that has accrued charges by consumption or purchase as listed in the invoice. Not available for Marketplace. </param>
        /// <param name="meterId"> The meter id (GUID). Not available for marketplace. For reserved instance this represents the primary meter for which the reservation was purchased. For the actual VM Size for which the reservation is purchased see productOrderName. </param>
        /// <param name="meterName"> Identifies the name of the meter against which consumption is measured. </param>
        /// <param name="meterRegion"> Identifies the location of the datacenter for certain services that are priced based on datacenter location. </param>
        /// <param name="meterCategory"> Identifies the top-level service for the usage. </param>
        /// <param name="meterSubCategory"> Defines the type or sub-category of Azure service that can affect the rate. </param>
        /// <param name="serviceFamily"> List the service family for the product purchased or charged (Example: Storage ; Compute). </param>
        /// <param name="quantity"> Measure the quantity purchased or consumed.The amount of the meter used during the billing period. </param>
        /// <param name="unitOfMeasure"> Identifies the Unit that the service is charged in. For example, GB, hours, 10,000 s. </param>
        /// <param name="instanceName"> Instance Name. </param>
        /// <param name="costInUSD"> Estimated extendedCost or blended cost before tax in USD. </param>
        /// <param name="unitPrice"> Unit Price is the price applicable to you. (your EA or other contract price). </param>
        /// <param name="billingCurrencyCode"> The currency defining the billed cost. </param>
        /// <param name="resourceLocation"> Name of the resource location. </param>
        /// <param name="consumedService"> Consumed service name. Name of the azure resource provider that emits the usage or was purchased. This value is not provided for marketplace usage. </param>
        /// <param name="serviceInfo1"> Service-specific metadata. </param>
        /// <param name="serviceInfo2"> Legacy field with optional service-specific metadata. </param>
        /// <param name="additionalInfo"> Additional details of this usage item. Use this field to get usage line item specific details such as the actual VM Size (ServiceType) or the ratio in which the reservation discount is applied. </param>
        /// <param name="invoiceSectionId"> Identifier of the project that is being charged in the invoice. Not applicable for Microsoft Customer Agreements onboarded by partners. </param>
        /// <param name="invoiceSectionName"> Name of the project that is being charged in the invoice. Not applicable for Microsoft Customer Agreements onboarded by partners. </param>
        /// <param name="costCenter"> The cost center of this department if it is a department and a cost center is provided. </param>
        /// <param name="resourceGroup"> Name of the Azure resource group used for cohesive lifecycle management of resources. </param>
        /// <param name="reservationId"> ARM resource id of the reservation. Only applies to records relevant to reservations. </param>
        /// <param name="reservationName"> User provided display name of the reservation. Last known name for a particular day is populated in the daily data. Only applies to records relevant to reservations. </param>
        /// <param name="productOrderId"> The identifier for the asset or Azure plan name that the subscription belongs to. For example: Azure Plan. For reservations this is the Reservation Order ID. </param>
        /// <param name="productOrderName"> Product Order Name. For reservations this is the SKU that was purchased. </param>
        /// <param name="isAzureCreditEligible"> Determines if the cost is eligible to be paid for using Azure credits. </param>
        /// <param name="term"> Term (in months). Displays the term for the validity of the offer. For example. In case of reserved instances it displays 12 months for yearly term of reserved instance. For one time purchases or recurring purchases, the terms displays 1 month; This is not applicable for Azure consumption. </param>
        /// <param name="publisherName"> Name of the publisher of the service including Microsoft or Third Party publishers. </param>
        /// <param name="publisherType"> Type of publisher that identifies if the publisher is first party, third party reseller or third party agency. </param>
        /// <param name="chargeType"> Indicates a charge represents credits, usage, a Marketplace purchase, a reservation fee, or a refund. </param>
        /// <param name="frequency"> Indicates how frequently this charge will occur. OneTime for purchases which only happen once, Monthly for fees which recur every month, and UsageBased for charges based on how much a service is used. </param>
        /// <param name="costInBillingCurrency"> ExtendedCost or blended cost before tax in billed currency. </param>
        /// <param name="costInPricingCurrency"> ExtendedCost or blended cost before tax in pricing currency to correlate with prices. </param>
        /// <param name="exchangeRate"> Exchange rate used in conversion from pricing currency to billing currency. </param>
        /// <param name="exchangeRateOn"> Date on which exchange rate used in conversion from pricing currency to billing currency. </param>
        /// <param name="invoiceId"> Invoice ID as on the invoice where the specific transaction appears. </param>
        /// <param name="previousInvoiceId"> Reference to an original invoice there is a refund (negative cost). This is populated only when there is a refund. </param>
        /// <param name="pricingCurrencyCode"> Pricing Billing Currency. </param>
        /// <param name="productIdentifier"> Identifier for the product that has accrued charges by consumption or purchase . This is the concatenated key of productId and SkuId in partner center. </param>
        /// <param name="resourceLocationNormalized"> Resource Location Normalized. </param>
        /// <param name="servicePeriodStartOn"> Start date for the rating period when the service usage was rated for charges. The prices for Azure services are determined for the rating period. </param>
        /// <param name="servicePeriodEndOn"> End date for the period when the service usage was rated for charges. The prices for Azure services are determined based on the rating period. </param>
        /// <param name="customerTenantId"> Identifier of the customer's AAD tenant. </param>
        /// <param name="customerName"> Name of the customer's AAD tenant. </param>
        /// <param name="partnerTenantId"> Identifier for the partner's AAD tenant. </param>
        /// <param name="partnerName"> Name of the partner' AAD tenant. </param>
        /// <param name="resellerMpnId"> MPNId for the reseller associated with the subscription. </param>
        /// <param name="resellerName"> Reseller Name. </param>
        /// <param name="publisherId"> Publisher Id. </param>
        /// <param name="marketPrice"> Market Price that's charged for the usage. </param>
        /// <param name="exchangeRatePricingToBilling"> Exchange Rate from pricing currency to billing currency. </param>
        /// <param name="paygCostInBillingCurrency"> The amount of PayG cost before tax in billing currency. </param>
        /// <param name="paygCostInUSD"> The amount of PayG cost before tax in US Dollar currency. </param>
        /// <param name="partnerEarnedCreditRate"> Rate of discount applied if there is a partner earned credit (PEC) based on partner admin link access. </param>
        /// <param name="partnerEarnedCreditApplied"> Flag to indicate if partner earned credit has been applied or not. </param>
        /// <param name="payGPrice"> Retail price for the resource. </param>
        /// <param name="benefitId"> Unique identifier for the applicable benefit. </param>
        /// <param name="benefitName"> Name of the applicable benefit. </param>
        /// <param name="provider"> Identifier for Product Category or Line Of Business, Ex - Azure, Microsoft 365, AWS e.t.c. </param>
        /// <param name="costAllocationRuleName"> Name for Cost Allocation Rule. </param>
        internal ConsumptionModernUsageDetail(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, UsageDetailsKind kind, ETag? etag, IReadOnlyDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, string billingAccountId, decimal? effectivePrice, ConsumptionPricingModelType? pricingModel, string billingAccountName, DateTimeOffset? billingPeriodStartOn, DateTimeOffset? billingPeriodEndOn, string billingProfileId, string billingProfileName, string subscriptionGuid, string subscriptionName, DateTimeOffset? @on, string product, Guid? meterId, string meterName, string meterRegion, string meterCategory, string meterSubCategory, string serviceFamily, decimal? quantity, string unitOfMeasure, string instanceName, decimal? costInUSD, decimal? unitPrice, string billingCurrencyCode, string resourceLocation, string consumedService, string serviceInfo1, string serviceInfo2, string additionalInfo, string invoiceSectionId, string invoiceSectionName, string costCenter, string resourceGroup, string reservationId, string reservationName, string productOrderId, string productOrderName, bool? isAzureCreditEligible, string term, string publisherName, string publisherType, string chargeType, string frequency, decimal? costInBillingCurrency, decimal? costInPricingCurrency, string exchangeRate, DateTimeOffset? exchangeRateOn, string invoiceId, string previousInvoiceId, string pricingCurrencyCode, string productIdentifier, string resourceLocationNormalized, DateTimeOffset? servicePeriodStartOn, DateTimeOffset? servicePeriodEndOn, string customerTenantId, string customerName, string partnerTenantId, string partnerName, string resellerMpnId, string resellerName, string publisherId, decimal? marketPrice, decimal? exchangeRatePricingToBilling, decimal? paygCostInBillingCurrency, decimal? paygCostInUSD, decimal? partnerEarnedCreditRate, string partnerEarnedCreditApplied, decimal? payGPrice, string benefitId, string benefitName, string provider, string costAllocationRuleName) : base(id, name, resourceType, systemData, kind, etag, tags, serializedAdditionalRawData)
        {
            BillingAccountId = billingAccountId;
            EffectivePrice = effectivePrice;
            PricingModel = pricingModel;
            BillingAccountName = billingAccountName;
            BillingPeriodStartOn = billingPeriodStartOn;
            BillingPeriodEndOn = billingPeriodEndOn;
            BillingProfileId = billingProfileId;
            BillingProfileName = billingProfileName;
            SubscriptionGuid = subscriptionGuid;
            SubscriptionName = subscriptionName;
            On = @on;
            Product = product;
            MeterId = meterId;
            MeterName = meterName;
            MeterRegion = meterRegion;
            MeterCategory = meterCategory;
            MeterSubCategory = meterSubCategory;
            ServiceFamily = serviceFamily;
            Quantity = quantity;
            UnitOfMeasure = unitOfMeasure;
            InstanceName = instanceName;
            CostInUSD = costInUSD;
            UnitPrice = unitPrice;
            BillingCurrencyCode = billingCurrencyCode;
            ResourceLocation = resourceLocation;
            ConsumedService = consumedService;
            ServiceInfo1 = serviceInfo1;
            ServiceInfo2 = serviceInfo2;
            AdditionalInfo = additionalInfo;
            InvoiceSectionId = invoiceSectionId;
            InvoiceSectionName = invoiceSectionName;
            CostCenter = costCenter;
            ResourceGroup = resourceGroup;
            ReservationId = reservationId;
            ReservationName = reservationName;
            ProductOrderId = productOrderId;
            ProductOrderName = productOrderName;
            IsAzureCreditEligible = isAzureCreditEligible;
            Term = term;
            PublisherName = publisherName;
            PublisherType = publisherType;
            ChargeType = chargeType;
            Frequency = frequency;
            CostInBillingCurrency = costInBillingCurrency;
            CostInPricingCurrency = costInPricingCurrency;
            ExchangeRate = exchangeRate;
            ExchangeRateOn = exchangeRateOn;
            InvoiceId = invoiceId;
            PreviousInvoiceId = previousInvoiceId;
            PricingCurrencyCode = pricingCurrencyCode;
            ProductIdentifier = productIdentifier;
            ResourceLocationNormalized = resourceLocationNormalized;
            ServicePeriodStartOn = servicePeriodStartOn;
            ServicePeriodEndOn = servicePeriodEndOn;
            CustomerTenantId = customerTenantId;
            CustomerName = customerName;
            PartnerTenantId = partnerTenantId;
            PartnerName = partnerName;
            ResellerMpnId = resellerMpnId;
            ResellerName = resellerName;
            PublisherId = publisherId;
            MarketPrice = marketPrice;
            ExchangeRatePricingToBilling = exchangeRatePricingToBilling;
            PaygCostInBillingCurrency = paygCostInBillingCurrency;
            PaygCostInUSD = paygCostInUSD;
            PartnerEarnedCreditRate = partnerEarnedCreditRate;
            PartnerEarnedCreditApplied = partnerEarnedCreditApplied;
            PayGPrice = payGPrice;
            BenefitId = benefitId;
            BenefitName = benefitName;
            Provider = provider;
            CostAllocationRuleName = costAllocationRuleName;
            Kind = kind;
        }

        /// <summary> Billing Account identifier. </summary>
        public string BillingAccountId { get; }
        /// <summary> Effective Price that's charged for the usage. </summary>
        public decimal? EffectivePrice { get; }
        /// <summary> Identifier that indicates how the meter is priced. </summary>
        public ConsumptionPricingModelType? PricingModel { get; }
        /// <summary> Name of the Billing Account. </summary>
        public string BillingAccountName { get; }
        /// <summary> Billing Period Start Date as in the invoice. </summary>
        public DateTimeOffset? BillingPeriodStartOn { get; }
        /// <summary> Billing Period End Date as in the invoice. </summary>
        public DateTimeOffset? BillingPeriodEndOn { get; }
        /// <summary> Identifier for the billing profile that groups costs across invoices in the a singular billing currency across across the customers who have onboarded the Microsoft customer agreement and the customers in CSP who have made entitlement purchases like SaaS, Marketplace, RI, etc. </summary>
        public string BillingProfileId { get; }
        /// <summary> Name of the billing profile that groups costs across invoices in the a singular billing currency across across the customers who have onboarded the Microsoft customer agreement and the customers in CSP who have made entitlement purchases like SaaS, Marketplace, RI, etc. </summary>
        public string BillingProfileName { get; }
        /// <summary> Unique Microsoft generated identifier for the Azure Subscription. </summary>
        public string SubscriptionGuid { get; }
        /// <summary> Name of the Azure Subscription. </summary>
        public string SubscriptionName { get; }
        /// <summary> Date for the usage record. </summary>
        public DateTimeOffset? On { get; }
        /// <summary> Name of the product that has accrued charges by consumption or purchase as listed in the invoice. Not available for Marketplace. </summary>
        public string Product { get; }
        /// <summary> The meter id (GUID). Not available for marketplace. For reserved instance this represents the primary meter for which the reservation was purchased. For the actual VM Size for which the reservation is purchased see productOrderName. </summary>
        public Guid? MeterId { get; }
        /// <summary> Identifies the name of the meter against which consumption is measured. </summary>
        public string MeterName { get; }
        /// <summary> Identifies the location of the datacenter for certain services that are priced based on datacenter location. </summary>
        public string MeterRegion { get; }
        /// <summary> Identifies the top-level service for the usage. </summary>
        public string MeterCategory { get; }
        /// <summary> Defines the type or sub-category of Azure service that can affect the rate. </summary>
        public string MeterSubCategory { get; }
        /// <summary> List the service family for the product purchased or charged (Example: Storage ; Compute). </summary>
        public string ServiceFamily { get; }
        /// <summary> Measure the quantity purchased or consumed.The amount of the meter used during the billing period. </summary>
        public decimal? Quantity { get; }
        /// <summary> Identifies the Unit that the service is charged in. For example, GB, hours, 10,000 s. </summary>
        public string UnitOfMeasure { get; }
        /// <summary> Instance Name. </summary>
        public string InstanceName { get; }
        /// <summary> Estimated extendedCost or blended cost before tax in USD. </summary>
        public decimal? CostInUSD { get; }
        /// <summary> Unit Price is the price applicable to you. (your EA or other contract price). </summary>
        public decimal? UnitPrice { get; }
        /// <summary> The currency defining the billed cost. </summary>
        public string BillingCurrencyCode { get; }
        /// <summary> Name of the resource location. </summary>
        public string ResourceLocation { get; }
        /// <summary> Consumed service name. Name of the azure resource provider that emits the usage or was purchased. This value is not provided for marketplace usage. </summary>
        public string ConsumedService { get; }
        /// <summary> Service-specific metadata. </summary>
        public string ServiceInfo1 { get; }
        /// <summary> Legacy field with optional service-specific metadata. </summary>
        public string ServiceInfo2 { get; }
        /// <summary> Additional details of this usage item. Use this field to get usage line item specific details such as the actual VM Size (ServiceType) or the ratio in which the reservation discount is applied. </summary>
        public string AdditionalInfo { get; }
        /// <summary> Identifier of the project that is being charged in the invoice. Not applicable for Microsoft Customer Agreements onboarded by partners. </summary>
        public string InvoiceSectionId { get; }
        /// <summary> Name of the project that is being charged in the invoice. Not applicable for Microsoft Customer Agreements onboarded by partners. </summary>
        public string InvoiceSectionName { get; }
        /// <summary> The cost center of this department if it is a department and a cost center is provided. </summary>
        public string CostCenter { get; }
        /// <summary> Name of the Azure resource group used for cohesive lifecycle management of resources. </summary>
        public string ResourceGroup { get; }
        /// <summary> ARM resource id of the reservation. Only applies to records relevant to reservations. </summary>
        public string ReservationId { get; }
        /// <summary> User provided display name of the reservation. Last known name for a particular day is populated in the daily data. Only applies to records relevant to reservations. </summary>
        public string ReservationName { get; }
        /// <summary> The identifier for the asset or Azure plan name that the subscription belongs to. For example: Azure Plan. For reservations this is the Reservation Order ID. </summary>
        public string ProductOrderId { get; }
        /// <summary> Product Order Name. For reservations this is the SKU that was purchased. </summary>
        public string ProductOrderName { get; }
        /// <summary> Determines if the cost is eligible to be paid for using Azure credits. </summary>
        public bool? IsAzureCreditEligible { get; }
        /// <summary> Term (in months). Displays the term for the validity of the offer. For example. In case of reserved instances it displays 12 months for yearly term of reserved instance. For one time purchases or recurring purchases, the terms displays 1 month; This is not applicable for Azure consumption. </summary>
        public string Term { get; }
        /// <summary> Name of the publisher of the service including Microsoft or Third Party publishers. </summary>
        public string PublisherName { get; }
        /// <summary> Type of publisher that identifies if the publisher is first party, third party reseller or third party agency. </summary>
        public string PublisherType { get; }
        /// <summary> Indicates a charge represents credits, usage, a Marketplace purchase, a reservation fee, or a refund. </summary>
        public string ChargeType { get; }
        /// <summary> Indicates how frequently this charge will occur. OneTime for purchases which only happen once, Monthly for fees which recur every month, and UsageBased for charges based on how much a service is used. </summary>
        public string Frequency { get; }
        /// <summary> ExtendedCost or blended cost before tax in billed currency. </summary>
        public decimal? CostInBillingCurrency { get; }
        /// <summary> ExtendedCost or blended cost before tax in pricing currency to correlate with prices. </summary>
        public decimal? CostInPricingCurrency { get; }
        /// <summary> Exchange rate used in conversion from pricing currency to billing currency. </summary>
        public string ExchangeRate { get; }
        /// <summary> Date on which exchange rate used in conversion from pricing currency to billing currency. </summary>
        public DateTimeOffset? ExchangeRateOn { get; }
        /// <summary> Invoice ID as on the invoice where the specific transaction appears. </summary>
        public string InvoiceId { get; }
        /// <summary> Reference to an original invoice there is a refund (negative cost). This is populated only when there is a refund. </summary>
        public string PreviousInvoiceId { get; }
        /// <summary> Pricing Billing Currency. </summary>
        public string PricingCurrencyCode { get; }
        /// <summary> Identifier for the product that has accrued charges by consumption or purchase . This is the concatenated key of productId and SkuId in partner center. </summary>
        public string ProductIdentifier { get; }
        /// <summary> Resource Location Normalized. </summary>
        public string ResourceLocationNormalized { get; }
        /// <summary> Start date for the rating period when the service usage was rated for charges. The prices for Azure services are determined for the rating period. </summary>
        public DateTimeOffset? ServicePeriodStartOn { get; }
        /// <summary> End date for the period when the service usage was rated for charges. The prices for Azure services are determined based on the rating period. </summary>
        public DateTimeOffset? ServicePeriodEndOn { get; }
        /// <summary> Identifier of the customer's AAD tenant. </summary>
        public string CustomerTenantId { get; }
        /// <summary> Name of the customer's AAD tenant. </summary>
        public string CustomerName { get; }
        /// <summary> Identifier for the partner's AAD tenant. </summary>
        public string PartnerTenantId { get; }
        /// <summary> Name of the partner' AAD tenant. </summary>
        public string PartnerName { get; }
        /// <summary> MPNId for the reseller associated with the subscription. </summary>
        public string ResellerMpnId { get; }
        /// <summary> Reseller Name. </summary>
        public string ResellerName { get; }
        /// <summary> Publisher Id. </summary>
        public string PublisherId { get; }
        /// <summary> Market Price that's charged for the usage. </summary>
        public decimal? MarketPrice { get; }
        /// <summary> Exchange Rate from pricing currency to billing currency. </summary>
        public decimal? ExchangeRatePricingToBilling { get; }
        /// <summary> The amount of PayG cost before tax in billing currency. </summary>
        public decimal? PaygCostInBillingCurrency { get; }
        /// <summary> The amount of PayG cost before tax in US Dollar currency. </summary>
        public decimal? PaygCostInUSD { get; }
        /// <summary> Rate of discount applied if there is a partner earned credit (PEC) based on partner admin link access. </summary>
        public decimal? PartnerEarnedCreditRate { get; }
        /// <summary> Flag to indicate if partner earned credit has been applied or not. </summary>
        public string PartnerEarnedCreditApplied { get; }
        /// <summary> Retail price for the resource. </summary>
        public decimal? PayGPrice { get; }
        /// <summary> Unique identifier for the applicable benefit. </summary>
        public string BenefitId { get; }
        /// <summary> Name of the applicable benefit. </summary>
        public string BenefitName { get; }
        /// <summary> Identifier for Product Category or Line Of Business, Ex - Azure, Microsoft 365, AWS e.t.c. </summary>
        public string Provider { get; }
        /// <summary> Name for Cost Allocation Rule. </summary>
        public string CostAllocationRuleName { get; }
    }
}
