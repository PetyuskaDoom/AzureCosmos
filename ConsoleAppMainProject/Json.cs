//////using Microsoft.Azure.Search;
//////using Microsoft.Azure.Search.Models;
//////using System;
//////using System.Collections.Generic;
//////using System.Linq;
//////using System.Text;
//////using System.Threading.Tasks;

//////namespace ConsoleAppMainProject
//////{
//////    [SerializePropertyNamesAsCamelCase]
//////    class Json
//////    {
//////        [SerializePropertyNamesAsCamelCase]
//////        public class Rootobject
//////        {
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public int page { get; set; }
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public int total { get; set; }
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public int records { get; set; }
//////            [IsSearchable, IsFilterable, IsFacetable]
//////            public Row[] rows { get; set; }
//////        }
//////        [SerializePropertyNamesAsCamelCase]
//////        public class Row
//////        {
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public int id { get; set; }
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public int versionValue { get; set; }
//////            [System.ComponentModel.DataAnnotations.Key]
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string uuid { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string createdBy { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string createdDate { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string lastModifiedBy { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string lastModifiedDate { get; set; }
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public int companyid { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string name { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string displayName { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string salutation { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string firstName { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string middleName { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string lastName { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string nickName { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string suffix { get; set; }
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public int genderid { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string businessUnitid { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string dateOfBirth { get; set; }
//////            [IsSearchable, IsFilterable, IsFacetable]
//////            public object[] contactTypes { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string accountingReference { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string referenceId { get; set; }
//////            [IsSearchable, IsFilterable, IsFacetable]
//////            public Languagemapping[] languageMappings { get; set; }
//////            [IsSearchable, IsFilterable, IsFacetable]
//////            public Primarynumber primaryNumber { get; set; }
//////            [IsSearchable, IsFilterable, IsFacetable]
//////            public Number[] numbers { get; set; }
//////            [IsSearchable, IsFilterable, IsFacetable]
//////            public Primaryaddress primaryAddress { get; set; }
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public float lat { get; set; }
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public float lng { get; set; }
//////            [IsSearchable, IsFilterable, IsFacetable]
//////            public Address[] addresses { get; set; }
//////            [IsSearchable, IsFilterable, IsFacetable]
//////            public Primaryemail primaryEmail { get; set; }
//////            [IsSearchable, IsFilterable, IsFacetable]
//////            public Email[] emails { get; set; }
//////            [IsFilterable, IsFacetable]
//////            public bool? hasTransportation { get; set; }
//////            [IsFilterable, IsFacetable]
//////            public bool? hasChildren { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string notes { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object companyName { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object website { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object region { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string countryOfOrigin { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string countryOfResidence { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string countryOfNationality { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string active { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string activeNote { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string availability { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string experience { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string registeredTaxId { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string bankAccount { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string sortCode { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string iban { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string swift { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string eftid { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string eftname { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object paymentMethodid { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string paymentMethodname { get; set; }
//////            [IsFilterable, IsFacetable]
//////            public bool registeredTax { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object registeredTaxIdDescription { get; set; }
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public int employmentCategoryid { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string employmentCategorydescription { get; set; }
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public int assignmentTierid { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string timeZone { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string ethnicity { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object document { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string imagePath { get; set; }
//////            [IsFilterable, IsFacetable]
//////            public bool outOfOffice { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object disableUpcomingReminder { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object disableCloseReminder { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object disableConfirmReminder { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object bankAccountDescription { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string timeWorked { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object activationDate { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object originalStartDate { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object datePhotoSentToPrinter { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object datePhotoSentToInterpreter { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object inductionDate { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object reActivationDate { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object iolNrcpdNumber { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object referralSource { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object refereeSourceName { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object recruiterName { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object taleoId { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object bankAccountReference { get; set; }
//////            public Status status { get; set; }
//////            public Ratesummary rateSummary { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string distance { get; set; }
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public int? rating { get; set; }
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public int? languagesId { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string language { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string languageCode { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string moreLanguages { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string employmentEligibilityStatus { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string number { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string address { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string email { get; set; }
//////        }

//////        [SerializePropertyNamesAsCamelCase]
//////        public class Primarynumber
//////        {
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public int id { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string parsedNumber { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object numberFormatted { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object countryCode { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object areaCode { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object number { get; set; }
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public int typeid { get; set; }
//////            [IsFilterable, IsFacetable]
//////            public bool primaryNumber { get; set; }
//////        }

//////        [SerializePropertyNamesAsCamelCase]
//////        public class Primaryaddress
//////        {
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public int id { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string clientid { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object clientLabel { get; set; }
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public int companyid { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string customerid { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string customerBillingid { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string displayLabel { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string description { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object notes { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string addrEntered { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string addrFormatted { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string aptUnit { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string preamble { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string street1 { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object street2 { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object street3 { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string cityTown { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string stateCounty { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string postalCode { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object country { get; set; }
//////            [IsFilterable, IsFacetable]
//////            public bool primaryAddress { get; set; }
//////            [IsFilterable, IsFacetable]
//////            public bool valid { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string validationStatus { get; set; }
//////            [IsFilterable, IsFacetable]
//////            public bool validated { get; set; }
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public int typeid { get; set; }
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public float lat { get; set; }
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public float lng { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object addressPhone { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object addressFax { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object addressEmail { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object contactPerson { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object costCenter { get; set; }
//////            [IsFilterable, IsFacetable]
//////            public bool active { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string parentid { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string parentlabel { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object publicNotes { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string regionid { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string billingRegionid { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object costCenterName { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object timeZone { get; set; }
//////        }

//////        [SerializePropertyNamesAsCamelCase]
//////        public class Primaryemail
//////        {
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public int id { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string emailAddress { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object addressVerified { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object dateVerified { get; set; }
//////            [IsFilterable, IsFacetable]
//////            public bool primaryEmail { get; set; }
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public int typeid { get; set; }
//////        }

//////        [SerializePropertyNamesAsCamelCase]
//////        public class Status
//////        {
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string _class { get; set; }
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public int id { get; set; }
//////            [IsFilterable, IsFacetable]
//////            public bool defaultOption { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string description { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object l10nKey { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string name { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string nameKey { get; set; }
//////        }

//////        [SerializePropertyNamesAsCamelCase]
//////        public class Ratesummary
//////        {
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string inperson { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string phone { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string video { get; set; }
//////        }

//////        [SerializePropertyNamesAsCamelCase]
//////        public class Languagemapping
//////        {
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public int id { get; set; }
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public int contactid { get; set; }
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public int languageid { get; set; }
//////            [IsSearchable, IsFilterable, IsFacetable]
//////            public Language language { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string rating { get; set; }
//////        }

//////        [SerializePropertyNamesAsCamelCase]
//////        public class Language
//////        {
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public int id { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string label { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string description { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string alternates { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string value { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string subtag { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string iso639_3Tag { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string type { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string alias { get; set; }
//////            [IsFilterable, IsFacetable]
//////            public bool enabled { get; set; }
//////        }

//////        [SerializePropertyNamesAsCamelCase]
//////        public class Number
//////        {
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public int id { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string parsedNumber { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object numberFormatted { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object countryCode { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object areaCode { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object number { get; set; }
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public int typeid { get; set; }
//////            [IsFilterable, IsFacetable]
//////            public bool primaryNumber { get; set; }
//////        }

//////        [SerializePropertyNamesAsCamelCase]
//////        public class Address
//////        {
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public int id { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string clientid { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object clientLabel { get; set; }
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public int companyid { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string customerid { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string customerBillingid { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string displayLabel { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string description { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object notes { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string addrEntered { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string addrFormatted { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string aptUnit { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string preamble { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string street1 { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object street2 { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object street3 { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string cityTown { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string stateCounty { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string postalCode { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object country { get; set; }
//////            [IsFilterable, IsFacetable]
//////            public bool primaryAddress { get; set; }
//////            [IsFilterable, IsFacetable]
//////            public bool valid { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string validationStatus { get; set; }
//////            [IsFilterable, IsFacetable]
//////            public bool validated { get; set; }
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public int typeid { get; set; }
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public float lat { get; set; }
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public float lng { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object addressPhone { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object addressFax { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object addressEmail { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object contactPerson { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object costCenter { get; set; }
//////            [IsFilterable, IsFacetable]
//////            public bool active { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string parentid { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string parentlabel { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object publicNotes { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string regionid { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string billingRegionid { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object costCenterName { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object timeZone { get; set; }
//////        }

//////        [SerializePropertyNamesAsCamelCase]
//////        public class Email
//////        {
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public int id { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public string emailAddress { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object addressVerified { get; set; }
//////            [IsSearchable, IsFilterable, IsSortable, IsFacetable]
//////            public object dateVerified { get; set; }
//////            [IsFilterable, IsFacetable]
//////            public bool primaryEmail { get; set; }
//////            [IsFilterable, IsSortable, IsFacetable]
//////            public int typeid { get; set; }
//////        }
//////    }
//////}
////// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//////
//////    using ConsoleAppTestStephenGregan;
//////
//////    var welcome = Welcome.FromJson(jsonString);
////namespace ConsoleAppMainProject
////{
////    using System;
////    using System.Collections.Generic;

////    using System.Globalization;
////    using Microsoft.Azure.Search;
////    using Microsoft.Azure.Search.Models;
////    using Newtonsoft.Json;
////    using Newtonsoft.Json.Converters;

////    [SerializePropertyNamesAsCamelCase]
////    public partial class Welcome
////    {
////        [IsFilterable, IsSortable, IsFacetable]
////        public long Page { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public long Total { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public long Records { get; set; }

////        [IsSearchable, IsFilterable, IsFacetable]
////        public Row[] Rows { get; set; }

////    }

////    public partial class Row
////    {
////        [IsFilterable, IsSortable, IsFacetable]
////        public long Id { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public long VersionValue { get; set; }

////        [System.ComponentModel.DataAnnotations.Key]
////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string Uuid { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string CreatedBy { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string CreatedDate { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string LastModifiedBy { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string LastModifiedDate { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public long CompanyId { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string Name { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string DisplayName { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string Salutation { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string FirstName { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string MiddleName { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string LastName { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string NickName { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string Suffix { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public long GenderId { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string BusinessUnitId { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string DateOfBirth { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object[] ContactTypes { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public long AccountingReference { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public long ReferenceId { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public LanguageMapping[] LanguageMappings { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public Number PrimaryNumber { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public Number[] Numbers { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public Address PrimaryAddress { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public double Lat { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public double Lng { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public Address[] Addresses { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public Email PrimaryEmail { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public Email[] Emails { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public bool? HasTransportation { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public bool? HasChildren { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string Notes { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object CompanyName { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object Website { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object Region { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string CountryOfOrigin { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string CountryOfResidence { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string CountryOfNationality { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string Active { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string ActiveNote { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string Availability { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string Experience { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string RegisteredTaxId { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string BankAccount { get; set; }

////        [JsonConverter(typeof(ParseIntegerConverter))]
////        public long? SortCode { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string Iban { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string Swift { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public BusinessUnitId EftId { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public BusinessUnitId EftName { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public PaymentMethodId PaymentMethodId { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public PaymentMethodName PaymentMethodName { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public bool RegisteredTax { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string RegisteredTaxIdDescription { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public long EmploymentCategoryId { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public EmploymentCategoryDescription EmploymentCategoryDescription { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public long AssignmentTierId { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public BusinessUnitId TimeZone { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public BusinessUnitId Ethnicity { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object Document { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public ImagePath ImagePath { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public bool OutOfOffice { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object DisableUpcomingReminder { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object DisableCloseReminder { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object DisableConfirmReminder { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object BankAccountDescription { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string TimeWorked { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object ActivationDate { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object OriginalStartDate { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object DatePhotoSentToPrinter { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object DatePhotoSentToInterpreter { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object InductionDate { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object ReActivationDate { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object IolNrcpdNumber { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object ReferralSource { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object RefereeSourceName { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object RecruiterName { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object TaleoId { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object BankAccountReference { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public Status Status { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public RateSummary RateSummary { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public Distance Distance { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public long? Rating { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public long? LanguagesId { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string Language { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string LanguageCode { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public MoreLanguages MoreLanguages { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public EmploymentEligibilityStatus EmploymentEligibilityStatus { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string Number { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string Address { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string Email { get; set; }
////    }

////    public partial class Address
////    {
////        [IsFilterable, IsSortable, IsFacetable]
////        public long Id { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public BusinessUnitId ClientId { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object ClientLabel { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public long CompanyId { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public BusinessUnitId CustomerId { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public BusinessUnitId CustomerBillingId { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string DisplayLabel { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string Description { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object Notes { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string AddrEntered { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string AddrFormatted { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string AptUnit { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object Preamble { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string Street1 { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object Street2 { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object Street3 { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string CityTown { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public StateCounty StateCounty { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string PostalCode { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object Country { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public bool PrimaryAddress { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public bool Valid { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public ValidationStatus ValidationStatus { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public bool Validated { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public long TypeId { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public double Lat { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public double Lng { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object AddressPhone { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object AddressFax { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object AddressEmail { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object ContactPerson { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object CostCenter { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public bool Active { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public BusinessUnitId ParentId { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public BusinessUnitId ParentLabel { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object PublicNotes { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public BusinessUnitId RegionId { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public BusinessUnitId BillingRegionId { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object CostCenterName { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object TimeZone { get; set; }
////    }

////    public partial class Email
////    {
////        [IsFilterable, IsSortable, IsFacetable]
////        public long Id { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string EmailAddress { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object AddressVerified { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object DateVerified { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public bool PrimaryEmail { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public long TypeId { get; set; }
////    }

////    public partial class LanguageMapping
////    {
////        [IsFilterable, IsSortable, IsFacetable]
////        public long Id { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public long ContactId { get; set; }

////        public long LanguageId { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public Language Language { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        [JsonConverter(typeof(ParseIntegerConverter))]
////        public long Rating { get; set; }
////    }

////    public partial class Language
////    {
////        [IsFilterable, IsSortable, IsFacetable]
////        public long Id { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string Label { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string Description { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string Alternates { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string Value { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string Subtag { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string Iso6393Tag { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public TypeEnum Type { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string Alias { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public bool Enabled { get; set; }
////    }

////    public partial class Number
////    {
////        [IsFilterable, IsSortable, IsFacetable]
////        public long Id { get; set; }

////        [System.ComponentModel.DataAnnotations.Key]
////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public string ParsedNumber { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object NumberFormatted { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object CountryCode { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object AreaCode { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object NumberNumber { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public long TypeId { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public bool PrimaryNumber { get; set; }
////    }

////    public partial class RateSummary
////    {
////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public Inperson Inperson { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public Inperson Phone { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public Inperson Video { get; set; }
////    }

////    public partial class Status
////    {
////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public Class Class { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public long Id { get; set; }

////        [IsFilterable, IsSortable, IsFacetable]
////        public bool DefaultOption { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public Description Description { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public object L10NKey { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public Description Name { get; set; }

////        [IsSearchable, IsFilterable, IsSortable, IsFacetable]
////        public NameKey NameKey { get; set; }
////    }

////}
//using System;
//using System.Collections.Generic;

//using System.Globalization;
//using Microsoft.Azure.Search;
//using Microsoft.Azure.Search.Models;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Converters;

//namespace ConsoleAppMainProject
//{

//    public class Rootobject
//    {
//        public int page { get; set; }
//        public int total { get; set; }
//        public int records { get; set; }
//        public Row[] rows { get; set; }
//    }

//    public class Row
//    {
//        public int id { get; set; }
//        public int versionValue { get; set; }
//        public string uuid { get; set; }
//        public string createdBy { get; set; }
//        public string createdDate { get; set; }
//        public string lastModifiedBy { get; set; }
//        public string lastModifiedDate { get; set; }
//        public int companyid { get; set; }
//        public string name { get; set; }
//        public string displayName { get; set; }
//        public string salutation { get; set; }
//        public string firstName { get; set; }
//        public string middleName { get; set; }
//        public string lastName { get; set; }
//        public string nickName { get; set; }
//        public string suffix { get; set; }
//        public int genderid { get; set; }
//        public string businessUnitid { get; set; }
//        public string dateOfBirth { get; set; }
//        public object[] contactTypes { get; set; }
//        public string accountingReference { get; set; }
//        public string referenceId { get; set; }
//        public Languagemapping[] languageMappings { get; set; }
//        public Primarynumber primaryNumber { get; set; }
//        public Number[] numbers { get; set; }
//        public Primaryaddress primaryAddress { get; set; }
//        public float lat { get; set; }
//        public float lng { get; set; }
//        public Address[] addresses { get; set; }
//        public Primaryemail primaryEmail { get; set; }
//        public Email[] emails { get; set; }
//        public bool? hasTransportation { get; set; }
//        public bool? hasChildren { get; set; }
//        public string notes { get; set; }
//        public string companyName { get; set; }
//        public string website { get; set; }
//        public string region { get; set; }
//        public string countryOfOrigin { get; set; }
//        public string countryOfResidence { get; set; }
//        public string countryOfNationality { get; set; }
//        public string active { get; set; }
//        public string activeNote { get; set; }
//        public string availability { get; set; }
//        public string experience { get; set; }
//        public string registeredTaxId { get; set; }
//        public string bankAccount { get; set; }
//        public string sortCode { get; set; }
//        public string iban { get; set; }
//        public string swift { get; set; }
//        public string eftid { get; set; }
//        public string eftname { get; set; }
//        public string paymentMethodid { get; set; }
//        public string paymentMethodname { get; set; }
//        public bool registeredTax { get; set; }
//        public string registeredTaxIdDescription { get; set; }
//        public int employmentCategoryid { get; set; }
//        public string employmentCategorydescription { get; set; }
//        public int assignmentTierid { get; set; }
//        public string timeZone { get; set; }
//        public string ethnicity { get; set; }
//        public string document { get; set; }
//        public string imagePath { get; set; }
//        public bool outOfOffice { get; set; }
//        public string disableUpcomingReminder { get; set; }
//        public string disableCloseReminder { get; set; }
//        public string disableConfirmReminder { get; set; }
//        public string bankAccountDescription { get; set; }
//        public string timeWorked { get; set; }
//        public string activationDate { get; set; }
//        public object originalStartDate { get; set; }
//        public object datePhotoSentToPrinter { get; set; }
//        public object datePhotoSentToInterpreter { get; set; }
//        public object inductionDate { get; set; }
//        public object reActivationDate { get; set; }
//        public object iolNrcpdNumber { get; set; }
//        public object referralSource { get; set; }
//        public object refereeSourceName { get; set; }
//        public object recruiterName { get; set; }
//        public object taleoId { get; set; }
//        public object bankAccountReference { get; set; }
//        public Status status { get; set; }
//        public Ratesummary rateSummary { get; set; }
//        public string distance { get; set; }
//        public int? rating { get; set; }
//        public int? languagesId { get; set; }
//        public string language { get; set; }
//        public string languageCode { get; set; }
//        public string moreLanguages { get; set; }
//        public string employmentEligibilityStatus { get; set; }
//        public string number { get; set; }
//        public string address { get; set; }
//        public string email { get; set; }

//        public override string ToString()
//        {
//            return base.ToString();
//        }
//    }

//    public class Primarynumber
//    {
//        public int id { get; set; }
//        public string parsedNumber { get; set; }
//        public object numberFormatted { get; set; }
//        public object countryCode { get; set; }
//        public object areaCode { get; set; }
//        public object number { get; set; }
//        public int typeid { get; set; }
//        public bool primaryNumber { get; set; }
//    }

//    public class Primaryaddress
//    {
//        public int id { get; set; }
//        public string clientid { get; set; }
//        public object clientLabel { get; set; }
//        public int companyid { get; set; }
//        public string customerid { get; set; }
//        public string customerBillingid { get; set; }
//        public string displayLabel { get; set; }
//        public string description { get; set; }
//        public object notes { get; set; }
//        public string addrEntered { get; set; }
//        public string addrFormatted { get; set; }
//        public string aptUnit { get; set; }
//        public object preamble { get; set; }
//        public string street1 { get; set; }
//        public object street2 { get; set; }
//        public object street3 { get; set; }
//        public string cityTown { get; set; }
//        public string stateCounty { get; set; }
//        public string postalCode { get; set; }
//        public object country { get; set; }
//        public bool primaryAddress { get; set; }
//        public bool valid { get; set; }
//        public string validationStatus { get; set; }
//        public bool validated { get; set; }
//        public int typeid { get; set; }
//        public float lat { get; set; }
//        public float lng { get; set; }
//        public object addressPhone { get; set; }
//        public object addressFax { get; set; }
//        public object addressEmail { get; set; }
//        public object contactPerson { get; set; }
//        public object costCenter { get; set; }
//        public bool active { get; set; }
//        public string parentid { get; set; }
//        public string parentlabel { get; set; }
//        public object publicNotes { get; set; }
//        public string regionid { get; set; }
//        public string billingRegionid { get; set; }
//        public object costCenterName { get; set; }
//        public object timeZone { get; set; }
//    }

//    public class Primaryemail
//    {
//        public int id { get; set; }
//        public string emailAddress { get; set; }
//        public object addressVerified { get; set; }
//        public object dateVerified { get; set; }
//        public bool primaryEmail { get; set; }
//        public int typeid { get; set; }
//    }

//    public class Status
//    {
//        public string _class { get; set; }
//        public int id { get; set; }
//        public bool defaultOption { get; set; }
//        public string description { get; set; }
//        public object l10nKey { get; set; }
//        public string name { get; set; }
//        public string nameKey { get; set; }
//    }

//    public class Ratesummary
//    {
//        public string inperson { get; set; }
//        public string phone { get; set; }
//        public string video { get; set; }
//    }

//    public class Languagemapping
//    {
//        public int id { get; set; }
//        public int contactid { get; set; }
//        public int languageid { get; set; }
//        public Language language { get; set; }
//        public string rating { get; set; }
//    }

//    public class Language
//    {
//        public int id { get; set; }
//        public string label { get; set; }
//        public string description { get; set; }
//        public string alternates { get; set; }
//        public string value { get; set; }
//        public string subtag { get; set; }
//        public string iso639_3Tag { get; set; }
//        public string type { get; set; }
//        public string alias { get; set; }
//        public bool enabled { get; set; }
//    }

//    public class Number
//    {
//        public int id { get; set; }
//        public string parsedNumber { get; set; }
//        public object numberFormatted { get; set; }
//        public object countryCode { get; set; }
//        public object areaCode { get; set; }
//        public object number { get; set; }
//        public int typeid { get; set; }
//        public bool primaryNumber { get; set; }
//    }

//    public class Address
//    {
//        public int id { get; set; }
//        public string clientid { get; set; }
//        public int companyid { get; set; }
//        public string customerid { get; set; }
//        public string customerBillingid { get; set; }
//        public string displayLabel { get; set; }
//        public string description { get; set; }
//        public object notes { get; set; }
//        public string addrEntered { get; set; }
//        public string addrFormatted { get; set; }
//        public string aptUnit { get; set; }
//        public object preamble { get; set; }
//        public string street1 { get; set; }
//        public object street2 { get; set; }
//        public object street3 { get; set; }
//        public string cityTown { get; set; }
//        public string stateCounty { get; set; }
//        public string postalCode { get; set; }
//        public object country { get; set; }
//        public bool primaryAddress { get; set; }
//        public bool valid { get; set; }
//        public string validationStatus { get; set; }
//        public bool validated { get; set; }
//        public int typeid { get; set; }
//        public float lat { get; set; }
//        public float lng { get; set; }
//        public object addressPhone { get; set; }
//        public object addressFax { get; set; }
//        public object addressEmail { get; set; }
//        public object contactPerson { get; set; }
//        public object costCenter { get; set; }
//        public bool active { get; set; }
//        public string parentid { get; set; }
//        public string parentlabel { get; set; }
//        public object publicNotes { get; set; }
//        public string regionid { get; set; }
//        public string billingRegionid { get; set; }
//        public object costCenterName { get; set; }
//        public object timeZone { get; set; }
//        public object clientLabel { get; set; }
//    }

//    public class Email
//    {
//        public int id { get; set; }
//        public string emailAddress { get; set; }
//        public object addressVerified { get; set; }
//        public object dateVerified { get; set; }
//        public bool primaryEmail { get; set; }
//        public int typeid { get; set; }
//    }
//}

