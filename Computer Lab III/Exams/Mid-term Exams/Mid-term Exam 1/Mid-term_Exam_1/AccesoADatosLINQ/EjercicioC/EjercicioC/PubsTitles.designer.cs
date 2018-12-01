﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EjercicioC
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="pubs")]
	public partial class PubsTitlesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void Inserttitles(titles instance);
    partial void Updatetitles(titles instance);
    partial void Deletetitles(titles instance);
    #endregion
		
		public PubsTitlesDataContext() : 
				base(global::EjercicioC.Properties.Settings.Default.pubsConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public PubsTitlesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PubsTitlesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PubsTitlesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PubsTitlesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<titles> titles
		{
			get
			{
				return this.GetTable<titles>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.titles")]
	public partial class titles : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _title_id;
		
		private string _title;
		
		private string _type;
		
		private string _pub_id;
		
		private System.Nullable<decimal> _price;
		
		private System.Nullable<decimal> _advance;
		
		private System.Nullable<int> _royalty;
		
		private System.Nullable<int> _ytd_sales;
		
		private string _notes;
		
		private System.DateTime _pubdate;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Ontitle_idChanging(string value);
    partial void Ontitle_idChanged();
    partial void OntitleChanging(string value);
    partial void OntitleChanged();
    partial void OntypeChanging(string value);
    partial void OntypeChanged();
    partial void Onpub_idChanging(string value);
    partial void Onpub_idChanged();
    partial void OnpriceChanging(System.Nullable<decimal> value);
    partial void OnpriceChanged();
    partial void OnadvanceChanging(System.Nullable<decimal> value);
    partial void OnadvanceChanged();
    partial void OnroyaltyChanging(System.Nullable<int> value);
    partial void OnroyaltyChanged();
    partial void Onytd_salesChanging(System.Nullable<int> value);
    partial void Onytd_salesChanged();
    partial void OnnotesChanging(string value);
    partial void OnnotesChanged();
    partial void OnpubdateChanging(System.DateTime value);
    partial void OnpubdateChanged();
    #endregion
		
		public titles()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title_id", DbType="VarChar(6) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string title_id
		{
			get
			{
				return this._title_id;
			}
			set
			{
				if ((this._title_id != value))
				{
					this.Ontitle_idChanging(value);
					this.SendPropertyChanging();
					this._title_id = value;
					this.SendPropertyChanged("title_id");
					this.Ontitle_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="VarChar(80) NOT NULL", CanBeNull=false)]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this.OntitleChanging(value);
					this.SendPropertyChanging();
					this._title = value;
					this.SendPropertyChanged("title");
					this.OntitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_type", DbType="Char(12) NOT NULL", CanBeNull=false)]
		public string type
		{
			get
			{
				return this._type;
			}
			set
			{
				if ((this._type != value))
				{
					this.OntypeChanging(value);
					this.SendPropertyChanging();
					this._type = value;
					this.SendPropertyChanged("type");
					this.OntypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pub_id", DbType="Char(4)")]
		public string pub_id
		{
			get
			{
				return this._pub_id;
			}
			set
			{
				if ((this._pub_id != value))
				{
					this.Onpub_idChanging(value);
					this.SendPropertyChanging();
					this._pub_id = value;
					this.SendPropertyChanged("pub_id");
					this.Onpub_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Money")]
		public System.Nullable<decimal> price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_advance", DbType="Money")]
		public System.Nullable<decimal> advance
		{
			get
			{
				return this._advance;
			}
			set
			{
				if ((this._advance != value))
				{
					this.OnadvanceChanging(value);
					this.SendPropertyChanging();
					this._advance = value;
					this.SendPropertyChanged("advance");
					this.OnadvanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_royalty", DbType="Int")]
		public System.Nullable<int> royalty
		{
			get
			{
				return this._royalty;
			}
			set
			{
				if ((this._royalty != value))
				{
					this.OnroyaltyChanging(value);
					this.SendPropertyChanging();
					this._royalty = value;
					this.SendPropertyChanged("royalty");
					this.OnroyaltyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ytd_sales", DbType="Int")]
		public System.Nullable<int> ytd_sales
		{
			get
			{
				return this._ytd_sales;
			}
			set
			{
				if ((this._ytd_sales != value))
				{
					this.Onytd_salesChanging(value);
					this.SendPropertyChanging();
					this._ytd_sales = value;
					this.SendPropertyChanged("ytd_sales");
					this.Onytd_salesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_notes", DbType="VarChar(200)")]
		public string notes
		{
			get
			{
				return this._notes;
			}
			set
			{
				if ((this._notes != value))
				{
					this.OnnotesChanging(value);
					this.SendPropertyChanging();
					this._notes = value;
					this.SendPropertyChanged("notes");
					this.OnnotesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pubdate", DbType="DateTime NOT NULL")]
		public System.DateTime pubdate
		{
			get
			{
				return this._pubdate;
			}
			set
			{
				if ((this._pubdate != value))
				{
					this.OnpubdateChanging(value);
					this.SendPropertyChanging();
					this._pubdate = value;
					this.SendPropertyChanged("pubdate");
					this.OnpubdateChanged();
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