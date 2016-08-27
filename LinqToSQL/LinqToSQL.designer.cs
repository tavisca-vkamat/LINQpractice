﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinqToSQL
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="HotelReservationSystem")]
	public partial class LinqToSQLDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCustomerData(CustomerData instance);
    partial void UpdateCustomerData(CustomerData instance);
    partial void DeleteCustomerData(CustomerData instance);
    partial void InsertHotelData(HotelData instance);
    partial void UpdateHotelData(HotelData instance);
    partial void DeleteHotelData(HotelData instance);
    partial void InsertRoomsData(RoomsData instance);
    partial void UpdateRoomsData(RoomsData instance);
    partial void DeleteRoomsData(RoomsData instance);
    partial void InsertBookingDetail(BookingDetail instance);
    partial void UpdateBookingDetail(BookingDetail instance);
    partial void DeleteBookingDetail(BookingDetail instance);
    #endregion
		
		public LinqToSQLDataContext() : 
				base(global::LinqToSQL.Properties.Settings.Default.HotelReservationSystemConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSQLDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSQLDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSQLDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqToSQLDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CustomerData> CustomerDatas
		{
			get
			{
				return this.GetTable<CustomerData>();
			}
		}
		
		public System.Data.Linq.Table<HotelData> HotelDatas
		{
			get
			{
				return this.GetTable<HotelData>();
			}
		}
		
		public System.Data.Linq.Table<RoomsData> RoomsDatas
		{
			get
			{
				return this.GetTable<RoomsData>();
			}
		}
		
		public System.Data.Linq.Table<BookingDetail> BookingDetails
		{
			get
			{
				return this.GetTable<BookingDetail>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spInsertCustomer")]
		public int spInsertCustomer([global::System.Data.Linq.Mapping.ParameterAttribute(Name="FirstName", DbType="NVarChar(50)")] string firstName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LastName", DbType="NVarChar(50)")] string lastName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="EmailId", DbType="NVarChar(50)")] string emailId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PhoneNumber", DbType="NVarChar(50)")] string phoneNumber, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="BigInt")] ref System.Nullable<long> customerId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), firstName, lastName, emailId, phoneNumber, customerId);
			customerId = ((System.Nullable<long>)(result.GetParameterValue(4)));
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CustomerData")]
	public partial class CustomerData : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _CustomerId;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _EmailId;
		
		private string _PhoneNumber;
		
		private EntitySet<BookingDetail> _BookingDetails;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomerIdChanging(long value);
    partial void OnCustomerIdChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnEmailIdChanging(string value);
    partial void OnEmailIdChanged();
    partial void OnPhoneNumberChanging(string value);
    partial void OnPhoneNumberChanged();
    #endregion
		
		public CustomerData()
		{
			this._BookingDetails = new EntitySet<BookingDetail>(new Action<BookingDetail>(this.attach_BookingDetails), new Action<BookingDetail>(this.detach_BookingDetails));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerId", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long CustomerId
		{
			get
			{
				return this._CustomerId;
			}
			set
			{
				if ((this._CustomerId != value))
				{
					this.OnCustomerIdChanging(value);
					this.SendPropertyChanging();
					this._CustomerId = value;
					this.SendPropertyChanged("CustomerId");
					this.OnCustomerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(50)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(50)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailId", DbType="NVarChar(50)")]
		public string EmailId
		{
			get
			{
				return this._EmailId;
			}
			set
			{
				if ((this._EmailId != value))
				{
					this.OnEmailIdChanging(value);
					this.SendPropertyChanging();
					this._EmailId = value;
					this.SendPropertyChanged("EmailId");
					this.OnEmailIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="NVarChar(50)")]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this.OnPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._PhoneNumber = value;
					this.SendPropertyChanged("PhoneNumber");
					this.OnPhoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CustomerData_BookingDetail", Storage="_BookingDetails", ThisKey="CustomerId", OtherKey="CustomerId")]
		public EntitySet<BookingDetail> BookingDetails
		{
			get
			{
				return this._BookingDetails;
			}
			set
			{
				this._BookingDetails.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_BookingDetails(BookingDetail entity)
		{
			this.SendPropertyChanging();
			entity.CustomerData = this;
		}
		
		private void detach_BookingDetails(BookingDetail entity)
		{
			this.SendPropertyChanging();
			entity.CustomerData = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HotelData")]
	public partial class HotelData : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _HotelId;
		
		private string _HotelName;
		
		private string _EmailId;
		
		private string _PhoneNumber;
		
		private string _City;
		
		private string _TotalRooms;
		
		private EntitySet<RoomsData> _RoomsDatas;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnHotelIdChanging(long value);
    partial void OnHotelIdChanged();
    partial void OnHotelNameChanging(string value);
    partial void OnHotelNameChanged();
    partial void OnEmailIdChanging(string value);
    partial void OnEmailIdChanged();
    partial void OnPhoneNumberChanging(string value);
    partial void OnPhoneNumberChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnTotalRoomsChanging(string value);
    partial void OnTotalRoomsChanged();
    #endregion
		
		public HotelData()
		{
			this._RoomsDatas = new EntitySet<RoomsData>(new Action<RoomsData>(this.attach_RoomsDatas), new Action<RoomsData>(this.detach_RoomsDatas));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelId", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long HotelId
		{
			get
			{
				return this._HotelId;
			}
			set
			{
				if ((this._HotelId != value))
				{
					this.OnHotelIdChanging(value);
					this.SendPropertyChanging();
					this._HotelId = value;
					this.SendPropertyChanged("HotelId");
					this.OnHotelIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelName", DbType="NVarChar(50)")]
		public string HotelName
		{
			get
			{
				return this._HotelName;
			}
			set
			{
				if ((this._HotelName != value))
				{
					this.OnHotelNameChanging(value);
					this.SendPropertyChanging();
					this._HotelName = value;
					this.SendPropertyChanged("HotelName");
					this.OnHotelNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailId", DbType="NVarChar(50)")]
		public string EmailId
		{
			get
			{
				return this._EmailId;
			}
			set
			{
				if ((this._EmailId != value))
				{
					this.OnEmailIdChanging(value);
					this.SendPropertyChanging();
					this._EmailId = value;
					this.SendPropertyChanged("EmailId");
					this.OnEmailIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="NVarChar(50)")]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this.OnPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._PhoneNumber = value;
					this.SendPropertyChanged("PhoneNumber");
					this.OnPhoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(50)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalRooms", DbType="NVarChar(50)")]
		public string TotalRooms
		{
			get
			{
				return this._TotalRooms;
			}
			set
			{
				if ((this._TotalRooms != value))
				{
					this.OnTotalRoomsChanging(value);
					this.SendPropertyChanging();
					this._TotalRooms = value;
					this.SendPropertyChanged("TotalRooms");
					this.OnTotalRoomsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HotelData_RoomsData", Storage="_RoomsDatas", ThisKey="HotelId", OtherKey="HotelId")]
		public EntitySet<RoomsData> RoomsDatas
		{
			get
			{
				return this._RoomsDatas;
			}
			set
			{
				this._RoomsDatas.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_RoomsDatas(RoomsData entity)
		{
			this.SendPropertyChanging();
			entity.HotelData = this;
		}
		
		private void detach_RoomsDatas(RoomsData entity)
		{
			this.SendPropertyChanging();
			entity.HotelData = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RoomsData")]
	public partial class RoomsData : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Id;
		
		private long _HotelId;
		
		private string _RoomType;
		
		private int _TotalRooms;
		
		private int _AvailableRooms;
		
		private string _Price;
		
		private EntitySet<BookingDetail> _BookingDetails;
		
		private EntityRef<HotelData> _HotelData;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(long value);
    partial void OnIdChanged();
    partial void OnHotelIdChanging(long value);
    partial void OnHotelIdChanged();
    partial void OnRoomTypeChanging(string value);
    partial void OnRoomTypeChanged();
    partial void OnTotalRoomsChanging(int value);
    partial void OnTotalRoomsChanged();
    partial void OnAvailableRoomsChanging(int value);
    partial void OnAvailableRoomsChanged();
    partial void OnPriceChanging(string value);
    partial void OnPriceChanged();
    #endregion
		
		public RoomsData()
		{
			this._BookingDetails = new EntitySet<BookingDetail>(new Action<BookingDetail>(this.attach_BookingDetails), new Action<BookingDetail>(this.detach_BookingDetails));
			this._HotelData = default(EntityRef<HotelData>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelId", DbType="BigInt NOT NULL")]
		public long HotelId
		{
			get
			{
				return this._HotelId;
			}
			set
			{
				if ((this._HotelId != value))
				{
					if (this._HotelData.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnHotelIdChanging(value);
					this.SendPropertyChanging();
					this._HotelId = value;
					this.SendPropertyChanged("HotelId");
					this.OnHotelIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoomType", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string RoomType
		{
			get
			{
				return this._RoomType;
			}
			set
			{
				if ((this._RoomType != value))
				{
					this.OnRoomTypeChanging(value);
					this.SendPropertyChanging();
					this._RoomType = value;
					this.SendPropertyChanged("RoomType");
					this.OnRoomTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalRooms", DbType="Int NOT NULL")]
		public int TotalRooms
		{
			get
			{
				return this._TotalRooms;
			}
			set
			{
				if ((this._TotalRooms != value))
				{
					this.OnTotalRoomsChanging(value);
					this.SendPropertyChanging();
					this._TotalRooms = value;
					this.SendPropertyChanged("TotalRooms");
					this.OnTotalRoomsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AvailableRooms", DbType="Int NOT NULL")]
		public int AvailableRooms
		{
			get
			{
				return this._AvailableRooms;
			}
			set
			{
				if ((this._AvailableRooms != value))
				{
					this.OnAvailableRoomsChanging(value);
					this.SendPropertyChanging();
					this._AvailableRooms = value;
					this.SendPropertyChanged("AvailableRooms");
					this.OnAvailableRoomsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="NVarChar(50)")]
		public string Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RoomsData_BookingDetail", Storage="_BookingDetails", ThisKey="Id", OtherKey="RoomId")]
		public EntitySet<BookingDetail> BookingDetails
		{
			get
			{
				return this._BookingDetails;
			}
			set
			{
				this._BookingDetails.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HotelData_RoomsData", Storage="_HotelData", ThisKey="HotelId", OtherKey="HotelId", IsForeignKey=true)]
		public HotelData HotelData
		{
			get
			{
				return this._HotelData.Entity;
			}
			set
			{
				HotelData previousValue = this._HotelData.Entity;
				if (((previousValue != value) 
							|| (this._HotelData.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._HotelData.Entity = null;
						previousValue.RoomsDatas.Remove(this);
					}
					this._HotelData.Entity = value;
					if ((value != null))
					{
						value.RoomsDatas.Add(this);
						this._HotelId = value.HotelId;
					}
					else
					{
						this._HotelId = default(long);
					}
					this.SendPropertyChanged("HotelData");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_BookingDetails(BookingDetail entity)
		{
			this.SendPropertyChanging();
			entity.RoomsData = this;
		}
		
		private void detach_BookingDetails(BookingDetail entity)
		{
			this.SendPropertyChanging();
			entity.RoomsData = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BookingDetails")]
	public partial class BookingDetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _BookingId;
		
		private long _CustomerId;
		
		private long _RoomId;
		
		private System.Nullable<System.DateTime> _CheckInDate;
		
		private System.Nullable<System.DateTime> _CheckOutDate;
		
		private EntityRef<CustomerData> _CustomerData;
		
		private EntityRef<RoomsData> _RoomsData;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBookingIdChanging(long value);
    partial void OnBookingIdChanged();
    partial void OnCustomerIdChanging(long value);
    partial void OnCustomerIdChanged();
    partial void OnRoomIdChanging(long value);
    partial void OnRoomIdChanged();
    partial void OnCheckInDateChanging(System.Nullable<System.DateTime> value);
    partial void OnCheckInDateChanged();
    partial void OnCheckOutDateChanging(System.Nullable<System.DateTime> value);
    partial void OnCheckOutDateChanged();
    #endregion
		
		public BookingDetail()
		{
			this._CustomerData = default(EntityRef<CustomerData>);
			this._RoomsData = default(EntityRef<RoomsData>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookingId", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long BookingId
		{
			get
			{
				return this._BookingId;
			}
			set
			{
				if ((this._BookingId != value))
				{
					this.OnBookingIdChanging(value);
					this.SendPropertyChanging();
					this._BookingId = value;
					this.SendPropertyChanged("BookingId");
					this.OnBookingIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerId", DbType="BigInt NOT NULL")]
		public long CustomerId
		{
			get
			{
				return this._CustomerId;
			}
			set
			{
				if ((this._CustomerId != value))
				{
					if (this._CustomerData.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCustomerIdChanging(value);
					this.SendPropertyChanging();
					this._CustomerId = value;
					this.SendPropertyChanged("CustomerId");
					this.OnCustomerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoomId", DbType="BigInt NOT NULL")]
		public long RoomId
		{
			get
			{
				return this._RoomId;
			}
			set
			{
				if ((this._RoomId != value))
				{
					if (this._RoomsData.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRoomIdChanging(value);
					this.SendPropertyChanging();
					this._RoomId = value;
					this.SendPropertyChanged("RoomId");
					this.OnRoomIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CheckInDate", DbType="Date")]
		public System.Nullable<System.DateTime> CheckInDate
		{
			get
			{
				return this._CheckInDate;
			}
			set
			{
				if ((this._CheckInDate != value))
				{
					this.OnCheckInDateChanging(value);
					this.SendPropertyChanging();
					this._CheckInDate = value;
					this.SendPropertyChanged("CheckInDate");
					this.OnCheckInDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CheckOutDate", DbType="Date")]
		public System.Nullable<System.DateTime> CheckOutDate
		{
			get
			{
				return this._CheckOutDate;
			}
			set
			{
				if ((this._CheckOutDate != value))
				{
					this.OnCheckOutDateChanging(value);
					this.SendPropertyChanging();
					this._CheckOutDate = value;
					this.SendPropertyChanged("CheckOutDate");
					this.OnCheckOutDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CustomerData_BookingDetail", Storage="_CustomerData", ThisKey="CustomerId", OtherKey="CustomerId", IsForeignKey=true)]
		public CustomerData CustomerData
		{
			get
			{
				return this._CustomerData.Entity;
			}
			set
			{
				CustomerData previousValue = this._CustomerData.Entity;
				if (((previousValue != value) 
							|| (this._CustomerData.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._CustomerData.Entity = null;
						previousValue.BookingDetails.Remove(this);
					}
					this._CustomerData.Entity = value;
					if ((value != null))
					{
						value.BookingDetails.Add(this);
						this._CustomerId = value.CustomerId;
					}
					else
					{
						this._CustomerId = default(long);
					}
					this.SendPropertyChanged("CustomerData");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RoomsData_BookingDetail", Storage="_RoomsData", ThisKey="RoomId", OtherKey="Id", IsForeignKey=true)]
		public RoomsData RoomsData
		{
			get
			{
				return this._RoomsData.Entity;
			}
			set
			{
				RoomsData previousValue = this._RoomsData.Entity;
				if (((previousValue != value) 
							|| (this._RoomsData.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._RoomsData.Entity = null;
						previousValue.BookingDetails.Remove(this);
					}
					this._RoomsData.Entity = value;
					if ((value != null))
					{
						value.BookingDetails.Add(this);
						this._RoomId = value.Id;
					}
					else
					{
						this._RoomId = default(long);
					}
					this.SendPropertyChanged("RoomsData");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
