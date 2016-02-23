﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BAGA
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BAEntities : DbContext
    {
        public BAEntities()
            : base("name=BAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<ContactPersonalInfo> ContactPersonalInfoes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerType> CustomerTypes { get; set; }
        public virtual DbSet<Equipment> EquipmentSet { get; set; }
        public virtual DbSet<Trip> Trips { get; set; }
        public virtual DbSet<Destination> Destinations { get; set; }
        public virtual DbSet<Lodging> Lodgings { get; set; }
        public virtual DbSet<OldReservation> OldReservations { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<CustomersinPastYear> CustomersinPastYears { get; set; }
        public virtual DbSet<vOfficeAddress> vOfficeAddresses { get; set; }
        public virtual DbSet<vPaymentsforPeriod> vPaymentsforPeriods { get; set; }
    
        public virtual ObjectResult<ActivitiesOnATrip_Result> ActivitiesOnATrip(Nullable<int> tripID)
        {
            var tripIDParameter = tripID.HasValue ?
                new ObjectParameter("tripID", tripID) :
                new ObjectParameter("tripID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ActivitiesOnATrip_Result>("ActivitiesOnATrip", tripIDParameter);
        }
    
        public virtual ObjectResult<ContactsAddedinDateRange_Result> ContactsAddedinDateRange(Nullable<System.DateTime> startdate, Nullable<System.DateTime> enddate)
        {
            var startdateParameter = startdate.HasValue ?
                new ObjectParameter("startdate", startdate) :
                new ObjectParameter("startdate", typeof(System.DateTime));
    
            var enddateParameter = enddate.HasValue ?
                new ObjectParameter("enddate", enddate) :
                new ObjectParameter("enddate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ContactsAddedinDateRange_Result>("ContactsAddedinDateRange", startdateParameter, enddateParameter);
        }
    
        public virtual ObjectResult<CreateCustomerfromContact_Result> CreateCustomerfromContact(Nullable<int> contactID)
        {
            var contactIDParameter = contactID.HasValue ?
                new ObjectParameter("contactID", contactID) :
                new ObjectParameter("contactID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CreateCustomerfromContact_Result>("CreateCustomerfromContact", contactIDParameter);
        }
    
        public virtual ObjectResult<CustomersWhoTravelledinDateRange_Result> CustomersWhoTravelledinDateRange(Nullable<System.DateTime> startdate, Nullable<System.DateTime> enddate)
        {
            var startdateParameter = startdate.HasValue ?
                new ObjectParameter("startdate", startdate) :
                new ObjectParameter("startdate", typeof(System.DateTime));
    
            var enddateParameter = enddate.HasValue ?
                new ObjectParameter("enddate", enddate) :
                new ObjectParameter("enddate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CustomersWhoTravelledinDateRange_Result>("CustomersWhoTravelledinDateRange", startdateParameter, enddateParameter);
        }
    
        public virtual int DeleteContact(Nullable<int> contactID)
        {
            var contactIDParameter = contactID.HasValue ?
                new ObjectParameter("ContactID", contactID) :
                new ObjectParameter("ContactID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteContact", contactIDParameter);
        }
    
        public virtual int DeleteCustomer(Nullable<int> contactID, Nullable<int> customerTypeID, Nullable<int> primaryDest, Nullable<int> secondaryDest, Nullable<int> primaryAct, Nullable<int> secondaryAct)
        {
            var contactIDParameter = contactID.HasValue ?
                new ObjectParameter("ContactID", contactID) :
                new ObjectParameter("ContactID", typeof(int));
    
            var customerTypeIDParameter = customerTypeID.HasValue ?
                new ObjectParameter("CustomerTypeID", customerTypeID) :
                new ObjectParameter("CustomerTypeID", typeof(int));
    
            var primaryDestParameter = primaryDest.HasValue ?
                new ObjectParameter("PrimaryDest", primaryDest) :
                new ObjectParameter("PrimaryDest", typeof(int));
    
            var secondaryDestParameter = secondaryDest.HasValue ?
                new ObjectParameter("SecondaryDest", secondaryDest) :
                new ObjectParameter("SecondaryDest", typeof(int));
    
            var primaryActParameter = primaryAct.HasValue ?
                new ObjectParameter("PrimaryAct", primaryAct) :
                new ObjectParameter("PrimaryAct", typeof(int));
    
            var secondaryActParameter = secondaryAct.HasValue ?
                new ObjectParameter("SecondaryAct", secondaryAct) :
                new ObjectParameter("SecondaryAct", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteCustomer", contactIDParameter, customerTypeIDParameter, primaryDestParameter, secondaryDestParameter, primaryActParameter, secondaryActParameter);
        }
    
        public virtual int DeletePayment(Nullable<int> paymentID, byte[] rowversion)
        {
            var paymentIDParameter = paymentID.HasValue ?
                new ObjectParameter("PaymentID", paymentID) :
                new ObjectParameter("PaymentID", typeof(int));
    
            var rowversionParameter = rowversion != null ?
                new ObjectParameter("rowversion", rowversion) :
                new ObjectParameter("rowversion", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeletePayment", paymentIDParameter, rowversionParameter);
        }
    
        public virtual ObjectResult<EventLocationsInDateRange_Result> EventLocationsInDateRange(Nullable<System.DateTime> startdate, Nullable<System.DateTime> enddate)
        {
            var startdateParameter = startdate.HasValue ?
                new ObjectParameter("startdate", startdate) :
                new ObjectParameter("startdate", typeof(System.DateTime));
    
            var enddateParameter = enddate.HasValue ?
                new ObjectParameter("enddate", enddate) :
                new ObjectParameter("enddate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EventLocationsInDateRange_Result>("EventLocationsInDateRange", startdateParameter, enddateParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> InsertContact(string firstName, string lastName, string title)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var titleParameter = title != null ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("InsertContact", firstNameParameter, lastNameParameter, titleParameter);
        }
    
        public virtual int InsertCustomer(Nullable<int> contactID, Nullable<int> customerTypeID, Nullable<int> primaryDest, Nullable<int> secondaryDest, Nullable<int> primaryAct, Nullable<int> secondaryAct, string notes)
        {
            var contactIDParameter = contactID.HasValue ?
                new ObjectParameter("ContactID", contactID) :
                new ObjectParameter("ContactID", typeof(int));
    
            var customerTypeIDParameter = customerTypeID.HasValue ?
                new ObjectParameter("CustomerTypeID", customerTypeID) :
                new ObjectParameter("CustomerTypeID", typeof(int));
    
            var primaryDestParameter = primaryDest.HasValue ?
                new ObjectParameter("PrimaryDest", primaryDest) :
                new ObjectParameter("PrimaryDest", typeof(int));
    
            var secondaryDestParameter = secondaryDest.HasValue ?
                new ObjectParameter("SecondaryDest", secondaryDest) :
                new ObjectParameter("SecondaryDest", typeof(int));
    
            var primaryActParameter = primaryAct.HasValue ?
                new ObjectParameter("PrimaryAct", primaryAct) :
                new ObjectParameter("PrimaryAct", typeof(int));
    
            var secondaryActParameter = secondaryAct.HasValue ?
                new ObjectParameter("SecondaryAct", secondaryAct) :
                new ObjectParameter("SecondaryAct", typeof(int));
    
            var notesParameter = notes != null ?
                new ObjectParameter("Notes", notes) :
                new ObjectParameter("Notes", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertCustomer", contactIDParameter, customerTypeIDParameter, primaryDestParameter, secondaryDestParameter, primaryActParameter, secondaryActParameter, notesParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> InsertPayment(Nullable<System.DateTime> date, Nullable<int> reservationID, Nullable<decimal> amount)
        {
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var reservationIDParameter = reservationID.HasValue ?
                new ObjectParameter("reservationID", reservationID) :
                new ObjectParameter("reservationID", typeof(int));
    
            var amountParameter = amount.HasValue ?
                new ObjectParameter("amount", amount) :
                new ObjectParameter("amount", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("InsertPayment", dateParameter, reservationIDParameter, amountParameter);
        }
    
        public virtual ObjectResult<PaymentsforPeriod_Result> PaymentsforPeriod(Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate)
        {
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("startDate", startDate) :
                new ObjectParameter("startDate", typeof(System.DateTime));
    
            var endDateParameter = endDate.HasValue ?
                new ObjectParameter("endDate", endDate) :
                new ObjectParameter("endDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PaymentsforPeriod_Result>("PaymentsforPeriod", startDateParameter, endDateParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<TripLocationsInDateRange_Result> TripLocationsInDateRange(Nullable<System.DateTime> startdate, Nullable<System.DateTime> enddate)
        {
            var startdateParameter = startdate.HasValue ?
                new ObjectParameter("startdate", startdate) :
                new ObjectParameter("startdate", typeof(System.DateTime));
    
            var enddateParameter = enddate.HasValue ?
                new ObjectParameter("enddate", enddate) :
                new ObjectParameter("enddate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TripLocationsInDateRange_Result>("TripLocationsInDateRange", startdateParameter, enddateParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> TripSalesforDateRange(Nullable<System.DateTime> startdate, Nullable<System.DateTime> enddate)
        {
            var startdateParameter = startdate.HasValue ?
                new ObjectParameter("startdate", startdate) :
                new ObjectParameter("startdate", typeof(System.DateTime));
    
            var enddateParameter = enddate.HasValue ?
                new ObjectParameter("enddate", enddate) :
                new ObjectParameter("enddate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("TripSalesforDateRange", startdateParameter, enddateParameter);
        }
    
        public virtual ObjectResult<byte[]> UpdateContact(Nullable<int> contactID, string firstName, string lastName, string title)
        {
            var contactIDParameter = contactID.HasValue ?
                new ObjectParameter("ContactID", contactID) :
                new ObjectParameter("ContactID", typeof(int));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var titleParameter = title != null ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<byte[]>("UpdateContact", contactIDParameter, firstNameParameter, lastNameParameter, titleParameter);
        }
    
        public virtual int UpdateCustomer(Nullable<int> contactID, Nullable<int> customerTypeID, Nullable<int> primaryDest, Nullable<int> secondaryDest, Nullable<int> primaryAct, Nullable<int> secondaryAct, string notes)
        {
            var contactIDParameter = contactID.HasValue ?
                new ObjectParameter("ContactID", contactID) :
                new ObjectParameter("ContactID", typeof(int));
    
            var customerTypeIDParameter = customerTypeID.HasValue ?
                new ObjectParameter("CustomerTypeID", customerTypeID) :
                new ObjectParameter("CustomerTypeID", typeof(int));
    
            var primaryDestParameter = primaryDest.HasValue ?
                new ObjectParameter("PrimaryDest", primaryDest) :
                new ObjectParameter("PrimaryDest", typeof(int));
    
            var secondaryDestParameter = secondaryDest.HasValue ?
                new ObjectParameter("SecondaryDest", secondaryDest) :
                new ObjectParameter("SecondaryDest", typeof(int));
    
            var primaryActParameter = primaryAct.HasValue ?
                new ObjectParameter("PrimaryAct", primaryAct) :
                new ObjectParameter("PrimaryAct", typeof(int));
    
            var secondaryActParameter = secondaryAct.HasValue ?
                new ObjectParameter("SecondaryAct", secondaryAct) :
                new ObjectParameter("SecondaryAct", typeof(int));
    
            var notesParameter = notes != null ?
                new ObjectParameter("Notes", notes) :
                new ObjectParameter("Notes", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateCustomer", contactIDParameter, customerTypeIDParameter, primaryDestParameter, secondaryDestParameter, primaryActParameter, secondaryActParameter, notesParameter);
        }
    
        public virtual int UpdateCustomerWithMappings(Nullable<int> contactID, Nullable<int> customerTypeID, Nullable<System.DateTime> initialDate, Nullable<int> primaryDesintation, Nullable<int> secondaryDestination, Nullable<int> primaryActivity, Nullable<int> secondaryActivity, string notes, string firstName, string lastName, string title, Nullable<System.DateTime> addDate, Nullable<System.DateTime> modifiedDate, Nullable<System.DateTime> birthDate, Nullable<int> heightInches, Nullable<int> weightPounds, string dietaryRestrictions, byte[] custTimeStamp, byte[] contactTimeStamp)
        {
            var contactIDParameter = contactID.HasValue ?
                new ObjectParameter("ContactID", contactID) :
                new ObjectParameter("ContactID", typeof(int));
    
            var customerTypeIDParameter = customerTypeID.HasValue ?
                new ObjectParameter("CustomerTypeID", customerTypeID) :
                new ObjectParameter("CustomerTypeID", typeof(int));
    
            var initialDateParameter = initialDate.HasValue ?
                new ObjectParameter("InitialDate", initialDate) :
                new ObjectParameter("InitialDate", typeof(System.DateTime));
    
            var primaryDesintationParameter = primaryDesintation.HasValue ?
                new ObjectParameter("PrimaryDesintation", primaryDesintation) :
                new ObjectParameter("PrimaryDesintation", typeof(int));
    
            var secondaryDestinationParameter = secondaryDestination.HasValue ?
                new ObjectParameter("SecondaryDestination", secondaryDestination) :
                new ObjectParameter("SecondaryDestination", typeof(int));
    
            var primaryActivityParameter = primaryActivity.HasValue ?
                new ObjectParameter("PrimaryActivity", primaryActivity) :
                new ObjectParameter("PrimaryActivity", typeof(int));
    
            var secondaryActivityParameter = secondaryActivity.HasValue ?
                new ObjectParameter("SecondaryActivity", secondaryActivity) :
                new ObjectParameter("SecondaryActivity", typeof(int));
    
            var notesParameter = notes != null ?
                new ObjectParameter("Notes", notes) :
                new ObjectParameter("Notes", typeof(string));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var titleParameter = title != null ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(string));
    
            var addDateParameter = addDate.HasValue ?
                new ObjectParameter("AddDate", addDate) :
                new ObjectParameter("AddDate", typeof(System.DateTime));
    
            var modifiedDateParameter = modifiedDate.HasValue ?
                new ObjectParameter("ModifiedDate", modifiedDate) :
                new ObjectParameter("ModifiedDate", typeof(System.DateTime));
    
            var birthDateParameter = birthDate.HasValue ?
                new ObjectParameter("BirthDate", birthDate) :
                new ObjectParameter("BirthDate", typeof(System.DateTime));
    
            var heightInchesParameter = heightInches.HasValue ?
                new ObjectParameter("HeightInches", heightInches) :
                new ObjectParameter("HeightInches", typeof(int));
    
            var weightPoundsParameter = weightPounds.HasValue ?
                new ObjectParameter("WeightPounds", weightPounds) :
                new ObjectParameter("WeightPounds", typeof(int));
    
            var dietaryRestrictionsParameter = dietaryRestrictions != null ?
                new ObjectParameter("DietaryRestrictions", dietaryRestrictions) :
                new ObjectParameter("DietaryRestrictions", typeof(string));
    
            var custTimeStampParameter = custTimeStamp != null ?
                new ObjectParameter("CustTimeStamp", custTimeStamp) :
                new ObjectParameter("CustTimeStamp", typeof(byte[]));
    
            var contactTimeStampParameter = contactTimeStamp != null ?
                new ObjectParameter("ContactTimeStamp", contactTimeStamp) :
                new ObjectParameter("ContactTimeStamp", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateCustomerWithMappings", contactIDParameter, customerTypeIDParameter, initialDateParameter, primaryDesintationParameter, secondaryDestinationParameter, primaryActivityParameter, secondaryActivityParameter, notesParameter, firstNameParameter, lastNameParameter, titleParameter, addDateParameter, modifiedDateParameter, birthDateParameter, heightInchesParameter, weightPoundsParameter, dietaryRestrictionsParameter, custTimeStampParameter, contactTimeStampParameter);
        }
    
        public virtual ObjectResult<byte[]> UpdatePayment(Nullable<int> paymentID, Nullable<System.DateTime> date, Nullable<int> reservationID, Nullable<decimal> amount, Nullable<System.DateTime> modifiedDate, byte[] rowversion)
        {
            var paymentIDParameter = paymentID.HasValue ?
                new ObjectParameter("PaymentID", paymentID) :
                new ObjectParameter("PaymentID", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var reservationIDParameter = reservationID.HasValue ?
                new ObjectParameter("reservationID", reservationID) :
                new ObjectParameter("reservationID", typeof(int));
    
            var amountParameter = amount.HasValue ?
                new ObjectParameter("amount", amount) :
                new ObjectParameter("amount", typeof(decimal));
    
            var modifiedDateParameter = modifiedDate.HasValue ?
                new ObjectParameter("modifiedDate", modifiedDate) :
                new ObjectParameter("modifiedDate", typeof(System.DateTime));
    
            var rowversionParameter = rowversion != null ?
                new ObjectParameter("rowversion", rowversion) :
                new ObjectParameter("rowversion", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<byte[]>("UpdatePayment", paymentIDParameter, dateParameter, reservationIDParameter, amountParameter, modifiedDateParameter, rowversionParameter);
        }
    }
}
