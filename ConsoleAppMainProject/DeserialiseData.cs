// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using ConsoleAppMainProject;
//
//    var welcome = Welcome.FromJson(jsonString);

namespace AzureCosmosProj
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Welcome
    {
        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("records")]
        public long Records { get; set; }

        [JsonProperty("rows")]
        public List<Row> Rows { get; set; }
    }

    public partial class Row
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("versionValue")]
        public long VersionValue { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        [JsonProperty("lastModifiedDate")]
        public string LastModifiedDate { get; set; }

        [JsonProperty("company.id")]
        public long CompanyId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("salutation")]
        public BusinessUnitId Salutation { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("nickName")]
        public BusinessUnitId NickName { get; set; }

        [JsonProperty("suffix")]
        public BusinessUnitId Suffix { get; set; }

        [JsonProperty("gender.id")]
        public long GenderId { get; set; }

        [JsonProperty("businessUnit.id")]
        public BusinessUnitId BusinessUnitId { get; set; }

        [JsonProperty("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("contactTypes")]
        public List<object> ContactTypes { get; set; }

        [JsonProperty("accountingReference")]
        public string AccountingReference { get; set; }

        [JsonProperty("referenceId")]
        public string ReferenceId { get; set; }

        [JsonProperty("languageMappings")]
        public List<LanguageMapping> LanguageMappings { get; set; }

        [JsonProperty("primaryNumber")]
        public Number PrimaryNumber { get; set; }

        [JsonProperty("numbers")]
        public List<Number> Numbers { get; set; }

        [JsonProperty("primaryAddress")]
        public Address PrimaryAddress { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("addresses")]
        public List<Address> Addresses { get; set; }

        [JsonProperty("primaryEmail")]
        public Email PrimaryEmail { get; set; }

        [JsonProperty("emails")]
        public List<Email> Emails { get; set; }

        [JsonProperty("hasTransportation")]
        public bool? HasTransportation { get; set; }

        [JsonProperty("hasChildren")]
        public bool? HasChildren { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("companyName")]
        public object CompanyName { get; set; }

        [JsonProperty("website")]
        public object Website { get; set; }

        [JsonProperty("region")]
        public object Region { get; set; }

        [JsonProperty("countryOfOrigin")]
        public string CountryOfOrigin { get; set; }

        [JsonProperty("countryOfResidence")]
        public CountryOfResidence? CountryOfResidence { get; set; }

        [JsonProperty("countryOfNationality")]
        public string CountryOfNationality { get; set; }

        [JsonProperty("active")]
        public Active Active { get; set; }

        [JsonProperty("activeNote")]
        public string ActiveNote { get; set; }

        [JsonProperty("availability")]
        public string Availability { get; set; }

        [JsonProperty("experience")]
        public string Experience { get; set; }

        [JsonProperty("registeredTaxId")]
        public string RegisteredTaxId { get; set; }

        [JsonProperty("bankAccount")]
        public string BankAccount { get; set; }

        [JsonProperty("sortCode")]
        public string SortCode { get; set; }

        [JsonProperty("iban")]
        public string Iban { get; set; }

        [JsonProperty("swift")]
        public string Swift { get; set; }

        [JsonProperty("eft.id")]
        public BusinessUnitId EftId { get; set; }

        [JsonProperty("eft.name")]
        public BusinessUnitId EftName { get; set; }

        [JsonProperty("paymentMethod.id")]
        public PaymentMethodId PaymentMethodId { get; set; }

        [JsonProperty("paymentMethod.name")]
        public PaymentMethodName PaymentMethodName { get; set; }

        [JsonProperty("registeredTax")]
        public bool RegisteredTax { get; set; }

        [JsonProperty("registeredTaxIdDescription")]
        public string RegisteredTaxIdDescription { get; set; }

        [JsonProperty("employmentCategory.id")]
        public long EmploymentCategoryId { get; set; }

        [JsonProperty("employmentCategory.description")]
        public EmploymentCategoryDescription EmploymentCategoryDescription { get; set; }

        [JsonProperty("assignmentTier.id")]
        public long AssignmentTierId { get; set; }

        [JsonProperty("timeZone")]
        public BusinessUnitId TimeZone { get; set; }

        [JsonProperty("ethnicity")]
        public BusinessUnitId Ethnicity { get; set; }

        [JsonProperty("document")]
        public object Document { get; set; }

        [JsonProperty("imagePath")]
        public ImagePath ImagePath { get; set; }

        [JsonProperty("outOfOffice")]
        public bool OutOfOffice { get; set; }

        [JsonProperty("disableUpcomingReminder")]
        public object DisableUpcomingReminder { get; set; }

        [JsonProperty("disableCloseReminder")]
        public object DisableCloseReminder { get; set; }

        [JsonProperty("disableConfirmReminder")]
        public object DisableConfirmReminder { get; set; }

        [JsonProperty("bankAccountDescription")]
        public object BankAccountDescription { get; set; }

        [JsonProperty("timeWorked")]
        public string TimeWorked { get; set; }

        [JsonProperty("activationDate")]
        public object ActivationDate { get; set; }

        [JsonProperty("originalStartDate")]
        public object OriginalStartDate { get; set; }

        [JsonProperty("datePhotoSentToPrinter")]
        public object DatePhotoSentToPrinter { get; set; }

        [JsonProperty("datePhotoSentToInterpreter")]
        public object DatePhotoSentToInterpreter { get; set; }

        [JsonProperty("inductionDate")]
        public object InductionDate { get; set; }

        [JsonProperty("reActivationDate")]
        public object ReActivationDate { get; set; }

        [JsonProperty("iolNrcpdNumber")]
        public object IolNrcpdNumber { get; set; }

        [JsonProperty("referralSource")]
        public object ReferralSource { get; set; }

        [JsonProperty("refereeSourceName")]
        public object RefereeSourceName { get; set; }

        [JsonProperty("recruiterName")]
        public object RecruiterName { get; set; }

        [JsonProperty("taleoId")]
        public object TaleoId { get; set; }

        [JsonProperty("bankAccountReference")]
        public object BankAccountReference { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("rateSummary")]
        public RateSummary RateSummary { get; set; }

        [JsonProperty("distance")]
        public Distance Distance { get; set; }

        [JsonProperty("rating")]
        public long? Rating { get; set; }

        [JsonProperty("languagesId")]
        public long? LanguagesId { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("languageCode")]
        public string LanguageCode { get; set; }

        [JsonProperty("moreLanguages")]
        public MoreLanguages MoreLanguages { get; set; }

        [JsonProperty("employmentEligibilityStatus")]
        public EmploymentEligibilityStatus EmploymentEligibilityStatus { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public partial class Address
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("client.id")]
        public BusinessUnitId ClientId { get; set; }

        [JsonProperty("clientLabel")]
        public object ClientLabel { get; set; }

        [JsonProperty("company.id")]
        public long CompanyId { get; set; }

        [JsonProperty("customer.id")]
        public BusinessUnitId CustomerId { get; set; }

        [JsonProperty("customerBilling.id")]
        public BusinessUnitId CustomerBillingId { get; set; }

        [JsonProperty("displayLabel")]
        public string DisplayLabel { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("notes")]
        public object Notes { get; set; }

        [JsonProperty("addrEntered")]
        public string AddrEntered { get; set; }

        [JsonProperty("addrFormatted")]
        public string AddrFormatted { get; set; }

        [JsonProperty("aptUnit")]
        public string AptUnit { get; set; }

        [JsonProperty("preamble")]
        public object Preamble { get; set; }

        [JsonProperty("street1")]
        public string Street1 { get; set; }

        [JsonProperty("street2")]
        public object Street2 { get; set; }

        [JsonProperty("street3")]
        public object Street3 { get; set; }

        [JsonProperty("cityTown")]
        public string CityTown { get; set; }

        [JsonProperty("stateCounty")]
        public StateCounty StateCounty { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public object Country { get; set; }

        [JsonProperty("primaryAddress")]
        public bool PrimaryAddress { get; set; }

        [JsonProperty("valid")]
        public bool Valid { get; set; }

        [JsonProperty("validationStatus")]
        public ValidationStatus ValidationStatus { get; set; }

        [JsonProperty("validated")]
        public bool Validated { get; set; }

        [JsonProperty("type.id")]
        public long TypeId { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("addressPhone")]
        public object AddressPhone { get; set; }

        [JsonProperty("addressFax")]
        public object AddressFax { get; set; }

        [JsonProperty("addressEmail")]
        public object AddressEmail { get; set; }

        [JsonProperty("contactPerson")]
        public object ContactPerson { get; set; }

        [JsonProperty("costCenter")]
        public object CostCenter { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("parent.id")]
        public BusinessUnitId ParentId { get; set; }

        [JsonProperty("parent.label")]
        public BusinessUnitId ParentLabel { get; set; }

        [JsonProperty("publicNotes")]
        public object PublicNotes { get; set; }

        [JsonProperty("region.id")]
        public BusinessUnitId RegionId { get; set; }

        [JsonProperty("billingRegion.id")]
        public BusinessUnitId BillingRegionId { get; set; }

        [JsonProperty("costCenterName")]
        public object CostCenterName { get; set; }

        [JsonProperty("timeZone")]
        public object TimeZone { get; set; }
    }

    public partial class Email
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("addressVerified")]
        public object AddressVerified { get; set; }

        [JsonProperty("dateVerified")]
        public object DateVerified { get; set; }

        [JsonProperty("primaryEmail")]
        public bool PrimaryEmail { get; set; }

        [JsonProperty("type.id")]
        public long TypeId { get; set; }
    }

    public partial class LanguageMapping
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("contact.id")]
        public long ContactId { get; set; }

        [JsonProperty("language.id")]
        public long LanguageId { get; set; }

        [JsonProperty("language")]
        public Language Language { get; set; }

        [JsonProperty("rating")]
        public string Rating { get; set; }
    }

    public partial class Language
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("alternates")]
        public string Alternates { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("subtag")]
        public string Subtag { get; set; }

        [JsonProperty("iso639_3Tag")]
        public string Iso6393Tag { get; set; }

        [JsonProperty("type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public partial class Number
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("parsedNumber")]
        public string ParsedNumber { get; set; }

        [JsonProperty("numberFormatted")]
        public object NumberFormatted { get; set; }

        [JsonProperty("countryCode")]
        public object CountryCode { get; set; }

        [JsonProperty("areaCode")]
        public object AreaCode { get; set; }

        [JsonProperty("number")]
        public object NumberNumber { get; set; }

        [JsonProperty("type.id")]
        public long TypeId { get; set; }

        [JsonProperty("primaryNumber")]
        public bool PrimaryNumber { get; set; }
    }

    public partial class RateSummary
    {
        [JsonProperty("inperson")]
        public Inperson Inperson { get; set; }

        [JsonProperty("phone")]
        public Inperson Phone { get; set; }

        [JsonProperty("video")]
        public Inperson Video { get; set; }
    }

    public partial class Status
    {
        [JsonProperty("class")]
        public Class Class { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("defaultOption")]
        public bool DefaultOption { get; set; }

        [JsonProperty("description")]
        public Description Description { get; set; }

        [JsonProperty("l10nKey")]
        public object L10NKey { get; set; }

        [JsonProperty("name")]
        public Description Name { get; set; }

        [JsonProperty("nameKey")]
        public NameKey NameKey { get; set; }
    }

    public enum Active { Y };

    public enum BusinessUnitId { Empty };

    public enum StateCounty { CountyCork, CountyDublin, CountyKildare, CountyWexford };

    public enum ValidationStatus { Ok, OkMultipleResults, OkPartial };

    public enum CountryOfResidence { Fra, Irl };

    public enum Distance { NA };

    public enum EmploymentCategoryDescription { PreferredContractor, Vendor };

    public enum EmploymentEligibilityStatus { Pass };

    public enum ImagePath { HttpsTieInterpreterintelligenceComImagesPlaceholderPng };

    public enum TypeEnum { Language };

    public enum MoreLanguages { Empty, The1, The3, The4 };

    public enum PaymentMethodName { Eft, Empty, Overseas };

    public enum Inperson { SummaryUnavailable };

    public enum Class { ComNgsIdModelTypeActiveContactStatus, ComNgsIdModelTypeInactiveStatus };

    public enum Description { Active, Inactive };

    public enum NameKey { Active, Inactive };

    public partial struct PaymentMethodId
    {
        public BusinessUnitId? Enum;
        public long? Integer;

        public bool IsNull => Integer == null && Enum == null;
    }

    public partial class Welcome
    {
        public static Welcome FromJson(string json) => JsonConvert.DeserializeObject<Welcome>(json, AzureCosmosProj.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Welcome self) => JsonConvert.SerializeObject(self, AzureCosmosProj.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                ActiveConverter.Singleton,
                BusinessUnitIdConverter.Singleton,
                StateCountyConverter.Singleton,
                ValidationStatusConverter.Singleton,
                CountryOfResidenceConverter.Singleton,
                DistanceConverter.Singleton,
                EmploymentCategoryDescriptionConverter.Singleton,
                EmploymentEligibilityStatusConverter.Singleton,
                ImagePathConverter.Singleton,
                TypeEnumConverter.Singleton,
                MoreLanguagesConverter.Singleton,
                PaymentMethodIdConverter.Singleton,
                PaymentMethodNameConverter.Singleton,
                InpersonConverter.Singleton,
                ClassConverter.Singleton,
                DescriptionConverter.Singleton,
                NameKeyConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ActiveConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Active) || t == typeof(Active?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "Y")
            {
                return Active.Y;
            }
            throw new Exception("Cannot unmarshal type Active");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Active)untypedValue;
            if (value == Active.Y)
            {
                serializer.Serialize(writer, "Y");
                return;
            }
            throw new Exception("Cannot marshal type Active");
        }

        public static readonly ActiveConverter Singleton = new ActiveConverter();
    }

    internal class BusinessUnitIdConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BusinessUnitId) || t == typeof(BusinessUnitId?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "")
            {
                return BusinessUnitId.Empty;
            }
            throw new Exception("Cannot unmarshal type BusinessUnitId");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (BusinessUnitId)untypedValue;
            if (value == BusinessUnitId.Empty)
            {
                serializer.Serialize(writer, "");
                return;
            }
            throw new Exception("Cannot marshal type BusinessUnitId");
        }

        public static readonly BusinessUnitIdConverter Singleton = new BusinessUnitIdConverter();
    }

    internal class StateCountyConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StateCounty) || t == typeof(StateCounty?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "County Cork":
                    return StateCounty.CountyCork;
                case "County Dublin":
                    return StateCounty.CountyDublin;
                case "County Kildare":
                    return StateCounty.CountyKildare;
                case "County Wexford":
                    return StateCounty.CountyWexford;
            }
            throw new Exception("Cannot unmarshal type StateCounty");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (StateCounty)untypedValue;
            switch (value)
            {
                case StateCounty.CountyCork:
                    serializer.Serialize(writer, "County Cork");
                    return;
                case StateCounty.CountyDublin:
                    serializer.Serialize(writer, "County Dublin");
                    return;
                case StateCounty.CountyKildare:
                    serializer.Serialize(writer, "County Kildare");
                    return;
                case StateCounty.CountyWexford:
                    serializer.Serialize(writer, "County Wexford");
                    return;
            }
            throw new Exception("Cannot marshal type StateCounty");
        }

        public static readonly StateCountyConverter Singleton = new StateCountyConverter();
    }

    internal class ValidationStatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ValidationStatus) || t == typeof(ValidationStatus?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "OK":
                    return ValidationStatus.Ok;
                case "OK.MULTIPLE_RESULTS":
                    return ValidationStatus.OkMultipleResults;
                case "OK.PARTIAL":
                    return ValidationStatus.OkPartial;
            }
            throw new Exception("Cannot unmarshal type ValidationStatus");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ValidationStatus)untypedValue;
            switch (value)
            {
                case ValidationStatus.Ok:
                    serializer.Serialize(writer, "OK");
                    return;
                case ValidationStatus.OkMultipleResults:
                    serializer.Serialize(writer, "OK.MULTIPLE_RESULTS");
                    return;
                case ValidationStatus.OkPartial:
                    serializer.Serialize(writer, "OK.PARTIAL");
                    return;
            }
            throw new Exception("Cannot marshal type ValidationStatus");
        }

        public static readonly ValidationStatusConverter Singleton = new ValidationStatusConverter();
    }

    internal class CountryOfResidenceConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CountryOfResidence) || t == typeof(CountryOfResidence?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "fra":
                    return CountryOfResidence.Fra;
                case "irl":
                    return CountryOfResidence.Irl;
            }
            throw new Exception("Cannot unmarshal type CountryOfResidence");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CountryOfResidence)untypedValue;
            switch (value)
            {
                case CountryOfResidence.Fra:
                    serializer.Serialize(writer, "fra");
                    return;
                case CountryOfResidence.Irl:
                    serializer.Serialize(writer, "irl");
                    return;
            }
            throw new Exception("Cannot marshal type CountryOfResidence");
        }

        public static readonly CountryOfResidenceConverter Singleton = new CountryOfResidenceConverter();
    }

    internal class DistanceConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Distance) || t == typeof(Distance?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "n/a")
            {
                return Distance.NA;
            }
            throw new Exception("Cannot unmarshal type Distance");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Distance)untypedValue;
            if (value == Distance.NA)
            {
                serializer.Serialize(writer, "n/a");
                return;
            }
            throw new Exception("Cannot marshal type Distance");
        }

        public static readonly DistanceConverter Singleton = new DistanceConverter();
    }

    internal class EmploymentCategoryDescriptionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EmploymentCategoryDescription) || t == typeof(EmploymentCategoryDescription?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Preferred contractor":
                    return EmploymentCategoryDescription.PreferredContractor;
                case "Vendor":
                    return EmploymentCategoryDescription.Vendor;
            }
            throw new Exception("Cannot unmarshal type EmploymentCategoryDescription");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (EmploymentCategoryDescription)untypedValue;
            switch (value)
            {
                case EmploymentCategoryDescription.PreferredContractor:
                    serializer.Serialize(writer, "Preferred contractor");
                    return;
                case EmploymentCategoryDescription.Vendor:
                    serializer.Serialize(writer, "Vendor");
                    return;
            }
            throw new Exception("Cannot marshal type EmploymentCategoryDescription");
        }

        public static readonly EmploymentCategoryDescriptionConverter Singleton = new EmploymentCategoryDescriptionConverter();
    }

    internal class EmploymentEligibilityStatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EmploymentEligibilityStatus) || t == typeof(EmploymentEligibilityStatus?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "pass")
            {
                return EmploymentEligibilityStatus.Pass;
            }
            throw new Exception("Cannot unmarshal type EmploymentEligibilityStatus");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (EmploymentEligibilityStatus)untypedValue;
            if (value == EmploymentEligibilityStatus.Pass)
            {
                serializer.Serialize(writer, "pass");
                return;
            }
            throw new Exception("Cannot marshal type EmploymentEligibilityStatus");
        }

        public static readonly EmploymentEligibilityStatusConverter Singleton = new EmploymentEligibilityStatusConverter();
    }

    internal class ImagePathConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ImagePath) || t == typeof(ImagePath?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "https://tie.interpreterintelligence.com/images/placeholder.png")
            {
                return ImagePath.HttpsTieInterpreterintelligenceComImagesPlaceholderPng;
            }
            throw new Exception("Cannot unmarshal type ImagePath");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ImagePath)untypedValue;
            if (value == ImagePath.HttpsTieInterpreterintelligenceComImagesPlaceholderPng)
            {
                serializer.Serialize(writer, "https://tie.interpreterintelligence.com/images/placeholder.png");
                return;
            }
            throw new Exception("Cannot marshal type ImagePath");
        }

        public static readonly ImagePathConverter Singleton = new ImagePathConverter();
    }

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "language")
            {
                return TypeEnum.Language;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            if (value == TypeEnum.Language)
            {
                serializer.Serialize(writer, "language");
                return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }

    internal class MoreLanguagesConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MoreLanguages) || t == typeof(MoreLanguages?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return MoreLanguages.Empty;
                case " (+1)":
                    return MoreLanguages.The1;
                case " (+3)":
                    return MoreLanguages.The3;
                case " (+4)":
                    return MoreLanguages.The4;
            }
            throw new Exception("Cannot unmarshal type MoreLanguages");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (MoreLanguages)untypedValue;
            switch (value)
            {
                case MoreLanguages.Empty:
                    serializer.Serialize(writer, "");
                    return;
                case MoreLanguages.The1:
                    serializer.Serialize(writer, " (+1)");
                    return;
                case MoreLanguages.The3:
                    serializer.Serialize(writer, " (+3)");
                    return;
                case MoreLanguages.The4:
                    serializer.Serialize(writer, " (+4)");
                    return;
            }
            throw new Exception("Cannot marshal type MoreLanguages");
        }

        public static readonly MoreLanguagesConverter Singleton = new MoreLanguagesConverter();
    }

    internal class PaymentMethodIdConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PaymentMethodId) || t == typeof(PaymentMethodId?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new PaymentMethodId { Integer = integerValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<BusinessUnitId>(reader);
                    return new PaymentMethodId { Enum = stringValue };
            }
            throw new Exception("Cannot unmarshal type PaymentMethodId");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (PaymentMethodId)untypedValue;
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.Enum != null)
            {
                serializer.Serialize(writer, value.Enum);
                return;
            }
            throw new Exception("Cannot marshal type PaymentMethodId");
        }

        public static readonly PaymentMethodIdConverter Singleton = new PaymentMethodIdConverter();
    }

    internal class PaymentMethodNameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PaymentMethodName) || t == typeof(PaymentMethodName?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return PaymentMethodName.Empty;
                case "EFT":
                    return PaymentMethodName.Eft;
                case "Overseas":
                    return PaymentMethodName.Overseas;
            }
            throw new Exception("Cannot unmarshal type PaymentMethodName");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PaymentMethodName)untypedValue;
            switch (value)
            {
                case PaymentMethodName.Empty:
                    serializer.Serialize(writer, "");
                    return;
                case PaymentMethodName.Eft:
                    serializer.Serialize(writer, "EFT");
                    return;
                case PaymentMethodName.Overseas:
                    serializer.Serialize(writer, "Overseas");
                    return;
            }
            throw new Exception("Cannot marshal type PaymentMethodName");
        }

        public static readonly PaymentMethodNameConverter Singleton = new PaymentMethodNameConverter();
    }

    internal class InpersonConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Inperson) || t == typeof(Inperson?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "summary unavailable")
            {
                return Inperson.SummaryUnavailable;
            }
            throw new Exception("Cannot unmarshal type Inperson");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Inperson)untypedValue;
            if (value == Inperson.SummaryUnavailable)
            {
                serializer.Serialize(writer, "summary unavailable");
                return;
            }
            throw new Exception("Cannot marshal type Inperson");
        }

        public static readonly InpersonConverter Singleton = new InpersonConverter();
    }

    internal class ClassConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Class) || t == typeof(Class?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "com.ngs.id.model.type.ActiveContactStatus":
                    return Class.ComNgsIdModelTypeActiveContactStatus;
                case "com.ngs.id.model.type.InactiveStatus":
                    return Class.ComNgsIdModelTypeInactiveStatus;
            }
            throw new Exception("Cannot unmarshal type Class");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Class)untypedValue;
            switch (value)
            {
                case Class.ComNgsIdModelTypeActiveContactStatus:
                    serializer.Serialize(writer, "com.ngs.id.model.type.ActiveContactStatus");
                    return;
                case Class.ComNgsIdModelTypeInactiveStatus:
                    serializer.Serialize(writer, "com.ngs.id.model.type.InactiveStatus");
                    return;
            }
            throw new Exception("Cannot marshal type Class");
        }

        public static readonly ClassConverter Singleton = new ClassConverter();
    }

    internal class DescriptionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Description) || t == typeof(Description?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Active":
                    return Description.Active;
                case "Inactive":
                    return Description.Inactive;
            }
            throw new Exception("Cannot unmarshal type Description");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Description)untypedValue;
            switch (value)
            {
                case Description.Active:
                    serializer.Serialize(writer, "Active");
                    return;
                case Description.Inactive:
                    serializer.Serialize(writer, "Inactive");
                    return;
            }
            throw new Exception("Cannot marshal type Description");
        }

        public static readonly DescriptionConverter Singleton = new DescriptionConverter();
    }

    internal class NameKeyConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(NameKey) || t == typeof(NameKey?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "active":
                    return NameKey.Active;
                case "inactive":
                    return NameKey.Inactive;
            }
            throw new Exception("Cannot unmarshal type NameKey");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (NameKey)untypedValue;
            switch (value)
            {
                case NameKey.Active:
                    serializer.Serialize(writer, "active");
                    return;
                case NameKey.Inactive:
                    serializer.Serialize(writer, "inactive");
                    return;
            }
            throw new Exception("Cannot marshal type NameKey");
        }

        public static readonly NameKeyConverter Singleton = new NameKeyConverter();
    }
}
