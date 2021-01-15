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

namespace QuanLyThiTracNghiem.Data
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLThi")]
	public partial class QuanLyThiDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCapHoc(CapHoc instance);
    partial void UpdateCapHoc(CapHoc instance);
    partial void DeleteCapHoc(CapHoc instance);
    partial void InsertQuyen(Quyen instance);
    partial void UpdateQuyen(Quyen instance);
    partial void DeleteQuyen(Quyen instance);
    partial void InsertCauTraLoi(CauTraLoi instance);
    partial void UpdateCauTraLoi(CauTraLoi instance);
    partial void DeleteCauTraLoi(CauTraLoi instance);
    partial void InsertDapAn(DapAn instance);
    partial void UpdateDapAn(DapAn instance);
    partial void DeleteDapAn(DapAn instance);
    partial void InsertGiaoVien(GiaoVien instance);
    partial void UpdateGiaoVien(GiaoVien instance);
    partial void DeleteGiaoVien(GiaoVien instance);
    partial void InsertHocSinh(HocSinh instance);
    partial void UpdateHocSinh(HocSinh instance);
    partial void DeleteHocSinh(HocSinh instance);
    partial void InsertMonHoc(MonHoc instance);
    partial void UpdateMonHoc(MonHoc instance);
    partial void DeleteMonHoc(MonHoc instance);
    partial void InsertNguoiDung(NguoiDung instance);
    partial void UpdateNguoiDung(NguoiDung instance);
    partial void DeleteNguoiDung(NguoiDung instance);
    #endregion
		
		public QuanLyThiDataContext() : 
				base(global::QuanLyThiTracNghiem.Properties.Settings.Default.QLThiConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyThiDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyThiDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyThiDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyThiDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CapHoc> CapHocs
		{
			get
			{
				return this.GetTable<CapHoc>();
			}
		}
		
		public System.Data.Linq.Table<Quyen> Quyens
		{
			get
			{
				return this.GetTable<Quyen>();
			}
		}
		
		public System.Data.Linq.Table<CauHoi> CauHois
		{
			get
			{
				return this.GetTable<CauHoi>();
			}
		}
		
		public System.Data.Linq.Table<CauTraLoi> CauTraLois
		{
			get
			{
				return this.GetTable<CauTraLoi>();
			}
		}
		
		public System.Data.Linq.Table<DapAn> DapAns
		{
			get
			{
				return this.GetTable<DapAn>();
			}
		}
		
		public System.Data.Linq.Table<GiaoVien> GiaoViens
		{
			get
			{
				return this.GetTable<GiaoVien>();
			}
		}
		
		public System.Data.Linq.Table<HocSinh> HocSinhs
		{
			get
			{
				return this.GetTable<HocSinh>();
			}
		}
		
		public System.Data.Linq.Table<MonHoc> MonHocs
		{
			get
			{
				return this.GetTable<MonHoc>();
			}
		}
		
		public System.Data.Linq.Table<NguoiDung> NguoiDungs
		{
			get
			{
				return this.GetTable<NguoiDung>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CapHoc")]
	public partial class CapHoc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDCapHoc;
		
		private string _CapHoc1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDCapHocChanging(int value);
    partial void OnIDCapHocChanged();
    partial void OnCapHoc1Changing(string value);
    partial void OnCapHoc1Changed();
    #endregion
		
		public CapHoc()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCapHoc", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IDCapHoc
		{
			get
			{
				return this._IDCapHoc;
			}
			set
			{
				if ((this._IDCapHoc != value))
				{
					this.OnIDCapHocChanging(value);
					this.SendPropertyChanging();
					this._IDCapHoc = value;
					this.SendPropertyChanged("IDCapHoc");
					this.OnIDCapHocChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="CapHoc", Storage="_CapHoc1", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string CapHoc1
		{
			get
			{
				return this._CapHoc1;
			}
			set
			{
				if ((this._CapHoc1 != value))
				{
					this.OnCapHoc1Changing(value);
					this.SendPropertyChanging();
					this._CapHoc1 = value;
					this.SendPropertyChanged("CapHoc1");
					this.OnCapHoc1Changed();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Quyen")]
	public partial class Quyen : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _QuyenID;
		
		private string _TenQuyen;
		
		private EntitySet<NguoiDung> _NguoiDungs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnQuyenIDChanging(int value);
    partial void OnQuyenIDChanged();
    partial void OnTenQuyenChanging(string value);
    partial void OnTenQuyenChanged();
    #endregion
		
		public Quyen()
		{
			this._NguoiDungs = new EntitySet<NguoiDung>(new Action<NguoiDung>(this.attach_NguoiDungs), new Action<NguoiDung>(this.detach_NguoiDungs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuyenID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int QuyenID
		{
			get
			{
				return this._QuyenID;
			}
			set
			{
				if ((this._QuyenID != value))
				{
					this.OnQuyenIDChanging(value);
					this.SendPropertyChanging();
					this._QuyenID = value;
					this.SendPropertyChanged("QuyenID");
					this.OnQuyenIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenQuyen", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenQuyen
		{
			get
			{
				return this._TenQuyen;
			}
			set
			{
				if ((this._TenQuyen != value))
				{
					this.OnTenQuyenChanging(value);
					this.SendPropertyChanging();
					this._TenQuyen = value;
					this.SendPropertyChanged("TenQuyen");
					this.OnTenQuyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Quyen_NguoiDung", Storage="_NguoiDungs", ThisKey="QuyenID", OtherKey="Quyen")]
		public EntitySet<NguoiDung> NguoiDungs
		{
			get
			{
				return this._NguoiDungs;
			}
			set
			{
				this._NguoiDungs.Assign(value);
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
		
		private void attach_NguoiDungs(NguoiDung entity)
		{
			this.SendPropertyChanging();
			entity.Quyen1 = this;
		}
		
		private void detach_NguoiDungs(NguoiDung entity)
		{
			this.SendPropertyChanging();
			entity.Quyen1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CauHoi")]
	public partial class CauHoi
	{
		
		private int _IDCauHoi;
		
		private string _CauHoi1;
		
		private string _MonHoc;
		
		private int _CapHoc;
		
		public CauHoi()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCauHoi", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int IDCauHoi
		{
			get
			{
				return this._IDCauHoi;
			}
			set
			{
				if ((this._IDCauHoi != value))
				{
					this._IDCauHoi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="CauHoi", Storage="_CauHoi1", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string CauHoi1
		{
			get
			{
				return this._CauHoi1;
			}
			set
			{
				if ((this._CauHoi1 != value))
				{
					this._CauHoi1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MonHoc", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string MonHoc
		{
			get
			{
				return this._MonHoc;
			}
			set
			{
				if ((this._MonHoc != value))
				{
					this._MonHoc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CapHoc", DbType="Int NOT NULL")]
		public int CapHoc
		{
			get
			{
				return this._CapHoc;
			}
			set
			{
				if ((this._CapHoc != value))
				{
					this._CapHoc = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CauTraLoi")]
	public partial class CauTraLoi : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _NguoiDungID;
		
		private int _MaDeThi;
		
		private int _CauHoiID;
		
		private System.Nullable<int> _DapAn;
		
		private int _MaKyThi;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNguoiDungIDChanging(int value);
    partial void OnNguoiDungIDChanged();
    partial void OnMaDeThiChanging(int value);
    partial void OnMaDeThiChanged();
    partial void OnCauHoiIDChanging(int value);
    partial void OnCauHoiIDChanged();
    partial void OnDapAnChanging(System.Nullable<int> value);
    partial void OnDapAnChanged();
    partial void OnMaKyThiChanging(int value);
    partial void OnMaKyThiChanged();
    #endregion
		
		public CauTraLoi()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NguoiDungID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int NguoiDungID
		{
			get
			{
				return this._NguoiDungID;
			}
			set
			{
				if ((this._NguoiDungID != value))
				{
					this.OnNguoiDungIDChanging(value);
					this.SendPropertyChanging();
					this._NguoiDungID = value;
					this.SendPropertyChanged("NguoiDungID");
					this.OnNguoiDungIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDeThi", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaDeThi
		{
			get
			{
				return this._MaDeThi;
			}
			set
			{
				if ((this._MaDeThi != value))
				{
					this.OnMaDeThiChanging(value);
					this.SendPropertyChanging();
					this._MaDeThi = value;
					this.SendPropertyChanged("MaDeThi");
					this.OnMaDeThiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CauHoiID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CauHoiID
		{
			get
			{
				return this._CauHoiID;
			}
			set
			{
				if ((this._CauHoiID != value))
				{
					this.OnCauHoiIDChanging(value);
					this.SendPropertyChanging();
					this._CauHoiID = value;
					this.SendPropertyChanged("CauHoiID");
					this.OnCauHoiIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DapAn", DbType="Int")]
		public System.Nullable<int> DapAn
		{
			get
			{
				return this._DapAn;
			}
			set
			{
				if ((this._DapAn != value))
				{
					this.OnDapAnChanging(value);
					this.SendPropertyChanging();
					this._DapAn = value;
					this.SendPropertyChanged("DapAn");
					this.OnDapAnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKyThi", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaKyThi
		{
			get
			{
				return this._MaKyThi;
			}
			set
			{
				if ((this._MaKyThi != value))
				{
					this.OnMaKyThiChanging(value);
					this.SendPropertyChanging();
					this._MaKyThi = value;
					this.SendPropertyChanged("MaKyThi");
					this.OnMaKyThiChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DapAn")]
	public partial class DapAn : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _DapAn1;
		
		private int _IDCauHoi;
		
		private System.Nullable<int> _IsDung;
		
		private int _STTDapAn;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDapAn1Changing(string value);
    partial void OnDapAn1Changed();
    partial void OnIDCauHoiChanging(int value);
    partial void OnIDCauHoiChanged();
    partial void OnIsDungChanging(System.Nullable<int> value);
    partial void OnIsDungChanged();
    partial void OnSTTDapAnChanging(int value);
    partial void OnSTTDapAnChanged();
    #endregion
		
		public DapAn()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="DapAn", Storage="_DapAn1", DbType="NVarChar(MAX)")]
		public string DapAn1
		{
			get
			{
				return this._DapAn1;
			}
			set
			{
				if ((this._DapAn1 != value))
				{
					this.OnDapAn1Changing(value);
					this.SendPropertyChanging();
					this._DapAn1 = value;
					this.SendPropertyChanged("DapAn1");
					this.OnDapAn1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCauHoi", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IDCauHoi
		{
			get
			{
				return this._IDCauHoi;
			}
			set
			{
				if ((this._IDCauHoi != value))
				{
					this.OnIDCauHoiChanging(value);
					this.SendPropertyChanging();
					this._IDCauHoi = value;
					this.SendPropertyChanged("IDCauHoi");
					this.OnIDCauHoiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsDung", DbType="Int")]
		public System.Nullable<int> IsDung
		{
			get
			{
				return this._IsDung;
			}
			set
			{
				if ((this._IsDung != value))
				{
					this.OnIsDungChanging(value);
					this.SendPropertyChanging();
					this._IsDung = value;
					this.SendPropertyChanged("IsDung");
					this.OnIsDungChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STTDapAn", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int STTDapAn
		{
			get
			{
				return this._STTDapAn;
			}
			set
			{
				if ((this._STTDapAn != value))
				{
					this.OnSTTDapAnChanging(value);
					this.SendPropertyChanging();
					this._STTDapAn = value;
					this.SendPropertyChanged("STTDapAn");
					this.OnSTTDapAnChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.GiaoVien")]
	public partial class GiaoVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaGV;
		
		private string _HoTen;
		
		private string _DiaChi;
		
		private System.DateTime _NgaySinh;
		
		private int _NguoiDungID;
		
		private EntityRef<NguoiDung> _NguoiDung;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaGVChanging(string value);
    partial void OnMaGVChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnNgaySinhChanging(System.DateTime value);
    partial void OnNgaySinhChanged();
    partial void OnNguoiDungIDChanging(int value);
    partial void OnNguoiDungIDChanged();
    #endregion
		
		public GiaoVien()
		{
			this._NguoiDung = default(EntityRef<NguoiDung>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaGV", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaGV
		{
			get
			{
				return this._MaGV;
			}
			set
			{
				if ((this._MaGV != value))
				{
					this.OnMaGVChanging(value);
					this.SendPropertyChanging();
					this._MaGV = value;
					this.SendPropertyChanged("MaGV");
					this.OnMaGVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="DateTime NOT NULL")]
		public System.DateTime NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this.OnNgaySinhChanging(value);
					this.SendPropertyChanging();
					this._NgaySinh = value;
					this.SendPropertyChanged("NgaySinh");
					this.OnNgaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NguoiDungID", DbType="Int NOT NULL")]
		public int NguoiDungID
		{
			get
			{
				return this._NguoiDungID;
			}
			set
			{
				if ((this._NguoiDungID != value))
				{
					if (this._NguoiDung.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnNguoiDungIDChanging(value);
					this.SendPropertyChanging();
					this._NguoiDungID = value;
					this.SendPropertyChanged("NguoiDungID");
					this.OnNguoiDungIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NguoiDung_GiaoVien", Storage="_NguoiDung", ThisKey="NguoiDungID", OtherKey="IDNguoiDung", IsForeignKey=true)]
		public NguoiDung NguoiDung
		{
			get
			{
				return this._NguoiDung.Entity;
			}
			set
			{
				NguoiDung previousValue = this._NguoiDung.Entity;
				if (((previousValue != value) 
							|| (this._NguoiDung.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NguoiDung.Entity = null;
						previousValue.GiaoViens.Remove(this);
					}
					this._NguoiDung.Entity = value;
					if ((value != null))
					{
						value.GiaoViens.Add(this);
						this._NguoiDungID = value.IDNguoiDung;
					}
					else
					{
						this._NguoiDungID = default(int);
					}
					this.SendPropertyChanged("NguoiDung");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HocSinh")]
	public partial class HocSinh : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaHS;
		
		private string _Lop;
		
		private string _HoTen;
		
		private System.DateTime _NgaySinh;
		
		private int _NguoiDungID;
		
		private string _DiaChi;
		
		private EntityRef<NguoiDung> _NguoiDung;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHSChanging(string value);
    partial void OnMaHSChanged();
    partial void OnLopChanging(string value);
    partial void OnLopChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnNgaySinhChanging(System.DateTime value);
    partial void OnNgaySinhChanged();
    partial void OnNguoiDungIDChanging(int value);
    partial void OnNguoiDungIDChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    #endregion
		
		public HocSinh()
		{
			this._NguoiDung = default(EntityRef<NguoiDung>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHS", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaHS
		{
			get
			{
				return this._MaHS;
			}
			set
			{
				if ((this._MaHS != value))
				{
					this.OnMaHSChanging(value);
					this.SendPropertyChanging();
					this._MaHS = value;
					this.SendPropertyChanged("MaHS");
					this.OnMaHSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Lop", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string Lop
		{
			get
			{
				return this._Lop;
			}
			set
			{
				if ((this._Lop != value))
				{
					this.OnLopChanging(value);
					this.SendPropertyChanging();
					this._Lop = value;
					this.SendPropertyChanged("Lop");
					this.OnLopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="DateTime NOT NULL")]
		public System.DateTime NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this.OnNgaySinhChanging(value);
					this.SendPropertyChanging();
					this._NgaySinh = value;
					this.SendPropertyChanged("NgaySinh");
					this.OnNgaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NguoiDungID", DbType="Int NOT NULL")]
		public int NguoiDungID
		{
			get
			{
				return this._NguoiDungID;
			}
			set
			{
				if ((this._NguoiDungID != value))
				{
					if (this._NguoiDung.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnNguoiDungIDChanging(value);
					this.SendPropertyChanging();
					this._NguoiDungID = value;
					this.SendPropertyChanged("NguoiDungID");
					this.OnNguoiDungIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(150)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NguoiDung_HocSinh", Storage="_NguoiDung", ThisKey="NguoiDungID", OtherKey="IDNguoiDung", IsForeignKey=true)]
		public NguoiDung NguoiDung
		{
			get
			{
				return this._NguoiDung.Entity;
			}
			set
			{
				NguoiDung previousValue = this._NguoiDung.Entity;
				if (((previousValue != value) 
							|| (this._NguoiDung.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NguoiDung.Entity = null;
						previousValue.HocSinhs.Remove(this);
					}
					this._NguoiDung.Entity = value;
					if ((value != null))
					{
						value.HocSinhs.Add(this);
						this._NguoiDungID = value.IDNguoiDung;
					}
					else
					{
						this._NguoiDungID = default(int);
					}
					this.SendPropertyChanged("NguoiDung");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MonHoc")]
	public partial class MonHoc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaMonHoc;
		
		private string _TenMonHoc;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaMonHocChanging(string value);
    partial void OnMaMonHocChanged();
    partial void OnTenMonHocChanging(string value);
    partial void OnTenMonHocChanged();
    #endregion
		
		public MonHoc()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaMonHoc", DbType="VarChar(255) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaMonHoc
		{
			get
			{
				return this._MaMonHoc;
			}
			set
			{
				if ((this._MaMonHoc != value))
				{
					this.OnMaMonHocChanging(value);
					this.SendPropertyChanging();
					this._MaMonHoc = value;
					this.SendPropertyChanged("MaMonHoc");
					this.OnMaMonHocChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenMonHoc", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenMonHoc
		{
			get
			{
				return this._TenMonHoc;
			}
			set
			{
				if ((this._TenMonHoc != value))
				{
					this.OnTenMonHocChanging(value);
					this.SendPropertyChanging();
					this._TenMonHoc = value;
					this.SendPropertyChanged("TenMonHoc");
					this.OnTenMonHocChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NguoiDung")]
	public partial class NguoiDung : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDNguoiDung;
		
		private string _TenTaiKhoan;
		
		private string _MatKhauHash;
		
		private int _Quyen;
		
		private EntitySet<GiaoVien> _GiaoViens;
		
		private EntitySet<HocSinh> _HocSinhs;
		
		private EntityRef<Quyen> _Quyen1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDNguoiDungChanging(int value);
    partial void OnIDNguoiDungChanged();
    partial void OnTenTaiKhoanChanging(string value);
    partial void OnTenTaiKhoanChanged();
    partial void OnMatKhauHashChanging(string value);
    partial void OnMatKhauHashChanged();
    partial void OnQuyenChanging(int value);
    partial void OnQuyenChanged();
    #endregion
		
		public NguoiDung()
		{
			this._GiaoViens = new EntitySet<GiaoVien>(new Action<GiaoVien>(this.attach_GiaoViens), new Action<GiaoVien>(this.detach_GiaoViens));
			this._HocSinhs = new EntitySet<HocSinh>(new Action<HocSinh>(this.attach_HocSinhs), new Action<HocSinh>(this.detach_HocSinhs));
			this._Quyen1 = default(EntityRef<Quyen>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDNguoiDung", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IDNguoiDung
		{
			get
			{
				return this._IDNguoiDung;
			}
			set
			{
				if ((this._IDNguoiDung != value))
				{
					this.OnIDNguoiDungChanging(value);
					this.SendPropertyChanging();
					this._IDNguoiDung = value;
					this.SendPropertyChanged("IDNguoiDung");
					this.OnIDNguoiDungChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenTaiKhoan", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string TenTaiKhoan
		{
			get
			{
				return this._TenTaiKhoan;
			}
			set
			{
				if ((this._TenTaiKhoan != value))
				{
					this.OnTenTaiKhoanChanging(value);
					this.SendPropertyChanging();
					this._TenTaiKhoan = value;
					this.SendPropertyChanged("TenTaiKhoan");
					this.OnTenTaiKhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhauHash", DbType="NChar(100) NOT NULL", CanBeNull=false)]
		public string MatKhauHash
		{
			get
			{
				return this._MatKhauHash;
			}
			set
			{
				if ((this._MatKhauHash != value))
				{
					this.OnMatKhauHashChanging(value);
					this.SendPropertyChanging();
					this._MatKhauHash = value;
					this.SendPropertyChanged("MatKhauHash");
					this.OnMatKhauHashChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quyen", DbType="Int NOT NULL")]
		public int Quyen
		{
			get
			{
				return this._Quyen;
			}
			set
			{
				if ((this._Quyen != value))
				{
					if (this._Quyen1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnQuyenChanging(value);
					this.SendPropertyChanging();
					this._Quyen = value;
					this.SendPropertyChanged("Quyen");
					this.OnQuyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NguoiDung_GiaoVien", Storage="_GiaoViens", ThisKey="IDNguoiDung", OtherKey="NguoiDungID")]
		public EntitySet<GiaoVien> GiaoViens
		{
			get
			{
				return this._GiaoViens;
			}
			set
			{
				this._GiaoViens.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NguoiDung_HocSinh", Storage="_HocSinhs", ThisKey="IDNguoiDung", OtherKey="NguoiDungID")]
		public EntitySet<HocSinh> HocSinhs
		{
			get
			{
				return this._HocSinhs;
			}
			set
			{
				this._HocSinhs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Quyen_NguoiDung", Storage="_Quyen1", ThisKey="Quyen", OtherKey="QuyenID", IsForeignKey=true)]
		public Quyen Quyen1
		{
			get
			{
				return this._Quyen1.Entity;
			}
			set
			{
				Quyen previousValue = this._Quyen1.Entity;
				if (((previousValue != value) 
							|| (this._Quyen1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Quyen1.Entity = null;
						previousValue.NguoiDungs.Remove(this);
					}
					this._Quyen1.Entity = value;
					if ((value != null))
					{
						value.NguoiDungs.Add(this);
						this._Quyen = value.QuyenID;
					}
					else
					{
						this._Quyen = default(int);
					}
					this.SendPropertyChanged("Quyen1");
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
		
		private void attach_GiaoViens(GiaoVien entity)
		{
			this.SendPropertyChanging();
			entity.NguoiDung = this;
		}
		
		private void detach_GiaoViens(GiaoVien entity)
		{
			this.SendPropertyChanging();
			entity.NguoiDung = null;
		}
		
		private void attach_HocSinhs(HocSinh entity)
		{
			this.SendPropertyChanging();
			entity.NguoiDung = this;
		}
		
		private void detach_HocSinhs(HocSinh entity)
		{
			this.SendPropertyChanging();
			entity.NguoiDung = null;
		}
	}
}
#pragma warning restore 1591
