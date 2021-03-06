#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4971
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[System.Data.Linq.Mapping.DatabaseAttribute(Name="dining")]
public partial class Dining : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertDining1(Dining1 instance);
  partial void UpdateDining1(Dining1 instance);
  partial void DeleteDining1(Dining1 instance);
  #endregion
	
	public Dining(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
//	public Dining(System.Data.IDbConnection connection) : 
//			base(connection, mappingSource)
//	{
//		OnCreated();
//	}
	
//	public Dining(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
//			base(connection, mappingSource)
//	{
//		OnCreated();
//	}
	
//	public Dining(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
//			base(connection, mappingSource)
//	{
//		OnCreated();
//	}
	
	public System.Data.Linq.Table<Dining1> Restaurants
	{
		get
		{
			return this.GetTable<Dining1>();
		}
	}
}

[Table(Name="dining")]
public partial class Dining1 : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private long _Unique_id;
	
	private System.Nullable<decimal> _On_campus;
	
	private System.Nullable<decimal> _Meal_plan;
	
	private System.Nullable<decimal> _Meal_money;
	
	private string _Phone;
	
	private string _Url;
	
	private string _Type;
	
	private System.Nullable<decimal> _Favorite;
	
	private string _Description;
	
	private string _Saturday_hours;
	
	private string _Friday_hours;
	
	private string _Thursday_hours;
	
	private string _Wednesday_hours;
	
	private string _Tuesday_hours;
	
	private string _Monday_hours;
	
	private string _Sunday_hours;
	
	private System.Nullable<decimal> _Lat;
	
	private System.Nullable<decimal> _Long;
	
	private string _Name;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUnique_idChanging(long value);
    partial void OnUnique_idChanged();
    partial void OnOn_campusChanging(System.Nullable<decimal> value);
    partial void OnOn_campusChanged();
    partial void OnMeal_planChanging(System.Nullable<decimal> value);
    partial void OnMeal_planChanged();
    partial void OnMeal_moneyChanging(System.Nullable<decimal> value);
    partial void OnMeal_moneyChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnUrlChanging(string value);
    partial void OnUrlChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    partial void OnFavoriteChanging(System.Nullable<decimal> value);
    partial void OnFavoriteChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnSaturday_hoursChanging(string value);
    partial void OnSaturday_hoursChanged();
    partial void OnFriday_hoursChanging(string value);
    partial void OnFriday_hoursChanged();
    partial void OnThursday_hoursChanging(string value);
    partial void OnThursday_hoursChanged();
    partial void OnWednesday_hoursChanging(string value);
    partial void OnWednesday_hoursChanged();
    partial void OnTuesday_hoursChanging(string value);
    partial void OnTuesday_hoursChanged();
    partial void OnMonday_hoursChanging(string value);
    partial void OnMonday_hoursChanged();
    partial void OnSunday_hoursChanging(string value);
    partial void OnSunday_hoursChanged();
    partial void OnLatChanging(System.Nullable<decimal> value);
    partial void OnLatChanged();
    partial void OnLongChanging(System.Nullable<decimal> value);
    partial void OnLongChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
	
	public Dining1()
	{
		OnCreated();
	}
	
	[Column(Name="unique_id", Storage="_Unique_id", DbType="BigInt NOT NULL", IsPrimaryKey=true)]
	public long Unique_id
	{
		get
		{
			return this._Unique_id;
		}
		set
		{
			if ((this._Unique_id != value))
			{
				this.OnUnique_idChanging(value);
				this.SendPropertyChanging();
				this._Unique_id = value;
				this.SendPropertyChanged("Unique_id");
				this.OnUnique_idChanged();
			}
		}
	}
	
	[Column(Name="on_campus", Storage="_On_campus", DbType="Decimal(18,0)")]
	public System.Nullable<decimal> On_campus
	{
		get
		{
			return this._On_campus;
		}
		set
		{
			if ((this._On_campus != value))
			{
				this.OnOn_campusChanging(value);
				this.SendPropertyChanging();
				this._On_campus = value;
				this.SendPropertyChanged("On_campus");
				this.OnOn_campusChanged();
			}
		}
	}
	
	[Column(Name="meal_plan", Storage="_Meal_plan", DbType="Decimal(18,0)")]
	public System.Nullable<decimal> Meal_plan
	{
		get
		{
			return this._Meal_plan;
		}
		set
		{
			if ((this._Meal_plan != value))
			{
				this.OnMeal_planChanging(value);
				this.SendPropertyChanging();
				this._Meal_plan = value;
				this.SendPropertyChanged("Meal_plan");
				this.OnMeal_planChanged();
			}
		}
	}
	
	[Column(Name="meal_money", Storage="_Meal_money", DbType="Decimal(18,0)")]
	public System.Nullable<decimal> Meal_money
	{
		get
		{
			return this._Meal_money;
		}
		set
		{
			if ((this._Meal_money != value))
			{
				this.OnMeal_moneyChanging(value);
				this.SendPropertyChanging();
				this._Meal_money = value;
				this.SendPropertyChanged("Meal_money");
				this.OnMeal_moneyChanged();
			}
		}
	}
	
	[Column(Name="phone", Storage="_Phone", DbType="NText", UpdateCheck=UpdateCheck.Never)]
	public string Phone
	{
		get
		{
			return this._Phone;
		}
		set
		{
			if ((this._Phone != value))
			{
				this.OnPhoneChanging(value);
				this.SendPropertyChanging();
				this._Phone = value;
				this.SendPropertyChanged("Phone");
				this.OnPhoneChanged();
			}
		}
	}
	
	[Column(Name="url", Storage="_Url", DbType="NText", UpdateCheck=UpdateCheck.Never)]
	public string Url
	{
		get
		{
			return this._Url;
		}
		set
		{
			if ((this._Url != value))
			{
				this.OnUrlChanging(value);
				this.SendPropertyChanging();
				this._Url = value;
				this.SendPropertyChanged("Url");
				this.OnUrlChanged();
			}
		}
	}
	
	[Column(Name="type", Storage="_Type", DbType="NText", UpdateCheck=UpdateCheck.Never)]
	public string Type
	{
		get
		{
			return this._Type;
		}
		set
		{
			if ((this._Type != value))
			{
				this.OnTypeChanging(value);
				this.SendPropertyChanging();
				this._Type = value;
				this.SendPropertyChanged("Type");
				this.OnTypeChanged();
			}
		}
	}
	
	[Column(Name="favorite", Storage="_Favorite", DbType="Decimal(18,0)")]
	public System.Nullable<decimal> Favorite
	{
		get
		{
			return this._Favorite;
		}
		set
		{
			if ((this._Favorite != value))
			{
				this.OnFavoriteChanging(value);
				this.SendPropertyChanging();
				this._Favorite = value;
				this.SendPropertyChanged("Favorite");
				this.OnFavoriteChanged();
			}
		}
	}
	
	[Column(Name="description", Storage="_Description", DbType="NText", UpdateCheck=UpdateCheck.Never)]
	public string Description
	{
		get
		{
			return this._Description;
		}
		set
		{
			if ((this._Description != value))
			{
				this.OnDescriptionChanging(value);
				this.SendPropertyChanging();
				this._Description = value;
				this.SendPropertyChanged("Description");
				this.OnDescriptionChanged();
			}
		}
	}
	
	[Column(Name="saturday_hours", Storage="_Saturday_hours", DbType="NText", UpdateCheck=UpdateCheck.Never)]
	public string Saturday_hours
	{
		get
		{
			return this._Saturday_hours;
		}
		set
		{
			if ((this._Saturday_hours != value))
			{
				this.OnSaturday_hoursChanging(value);
				this.SendPropertyChanging();
				this._Saturday_hours = value;
				this.SendPropertyChanged("Saturday_hours");
				this.OnSaturday_hoursChanged();
			}
		}
	}
	
	[Column(Name="friday_hours", Storage="_Friday_hours", DbType="NText", UpdateCheck=UpdateCheck.Never)]
	public string Friday_hours
	{
		get
		{
			return this._Friday_hours;
		}
		set
		{
			if ((this._Friday_hours != value))
			{
				this.OnFriday_hoursChanging(value);
				this.SendPropertyChanging();
				this._Friday_hours = value;
				this.SendPropertyChanged("Friday_hours");
				this.OnFriday_hoursChanged();
			}
		}
	}
	
	[Column(Name="thursday_hours", Storage="_Thursday_hours", DbType="NText", UpdateCheck=UpdateCheck.Never)]
	public string Thursday_hours
	{
		get
		{
			return this._Thursday_hours;
		}
		set
		{
			if ((this._Thursday_hours != value))
			{
				this.OnThursday_hoursChanging(value);
				this.SendPropertyChanging();
				this._Thursday_hours = value;
				this.SendPropertyChanged("Thursday_hours");
				this.OnThursday_hoursChanged();
			}
		}
	}
	
	[Column(Name="wednesday_hours", Storage="_Wednesday_hours", DbType="NText", UpdateCheck=UpdateCheck.Never)]
	public string Wednesday_hours
	{
		get
		{
			return this._Wednesday_hours;
		}
		set
		{
			if ((this._Wednesday_hours != value))
			{
				this.OnWednesday_hoursChanging(value);
				this.SendPropertyChanging();
				this._Wednesday_hours = value;
				this.SendPropertyChanged("Wednesday_hours");
				this.OnWednesday_hoursChanged();
			}
		}
	}
	
	[Column(Name="tuesday_hours", Storage="_Tuesday_hours", DbType="NText", UpdateCheck=UpdateCheck.Never)]
	public string Tuesday_hours
	{
		get
		{
			return this._Tuesday_hours;
		}
		set
		{
			if ((this._Tuesday_hours != value))
			{
				this.OnTuesday_hoursChanging(value);
				this.SendPropertyChanging();
				this._Tuesday_hours = value;
				this.SendPropertyChanged("Tuesday_hours");
				this.OnTuesday_hoursChanged();
			}
		}
	}
	
	[Column(Name="monday_hours", Storage="_Monday_hours", DbType="NText", UpdateCheck=UpdateCheck.Never)]
	public string Monday_hours
	{
		get
		{
			return this._Monday_hours;
		}
		set
		{
			if ((this._Monday_hours != value))
			{
				this.OnMonday_hoursChanging(value);
				this.SendPropertyChanging();
				this._Monday_hours = value;
				this.SendPropertyChanged("Monday_hours");
				this.OnMonday_hoursChanged();
			}
		}
	}
	
	[Column(Name="sunday_hours", Storage="_Sunday_hours", DbType="NText", UpdateCheck=UpdateCheck.Never)]
	public string Sunday_hours
	{
		get
		{
			return this._Sunday_hours;
		}
		set
		{
			if ((this._Sunday_hours != value))
			{
				this.OnSunday_hoursChanging(value);
				this.SendPropertyChanging();
				this._Sunday_hours = value;
				this.SendPropertyChanged("Sunday_hours");
				this.OnSunday_hoursChanged();
			}
		}
	}
	
	[Column(Name="lat", Storage="_Lat", DbType="Decimal(18,0)")]
	public System.Nullable<decimal> Lat
	{
		get
		{
			return this._Lat;
		}
		set
		{
			if ((this._Lat != value))
			{
				this.OnLatChanging(value);
				this.SendPropertyChanging();
				this._Lat = value;
				this.SendPropertyChanged("Lat");
				this.OnLatChanged();
			}
		}
	}
	
	[Column(Name="long", Storage="_Long", DbType="Decimal(18,0)")]
	public System.Nullable<decimal> Long
	{
		get
		{
			return this._Long;
		}
		set
		{
			if ((this._Long != value))
			{
				this.OnLongChanging(value);
				this.SendPropertyChanging();
				this._Long = value;
				this.SendPropertyChanged("Long");
				this.OnLongChanged();
			}
		}
	}
	
	[Column(Name="name", Storage="_Name", DbType="NText", UpdateCheck=UpdateCheck.Never)]
	public string Name
	{
		get
		{
			return this._Name;
		}
		set
		{
			if ((this._Name != value))
			{
				this.OnNameChanging(value);
				this.SendPropertyChanging();
				this._Name = value;
				this.SendPropertyChanged("Name");
				this.OnNameChanged();
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
#pragma warning restore 1591
