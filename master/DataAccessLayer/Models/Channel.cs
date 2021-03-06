//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18449
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
namespace DataAccessLayer.Models
{
	/// <summary>
	/// 频道
	/// </summary>
	public class Channel
	{
		/// <summary>
		/// 频道的主键
		/// </summary>
		/// <value>The identifier.</value>
		public int Id {
			get;
			set;
		}
		/// <summary>
		/// 上级编号
		/// </summary>
		/// <value>The parent identifier.</value>
		public int ParentId {
			get;
			set;
		}
		/// <summary>
		/// 频道名称
		/// </summary>
		/// <value>The name.</value>
		public string Name {
			get;
			set;
		}
		/// <summary>
		/// 显示顺序
		/// </summary>
		/// <value>The show order.</value>
		public int DisplayOrder {
			get;
			set;
		}
		/// <summary>
		/// 频道对应的Url
		/// </summary>
		/// <value>The channel URL.</value>
		public string ChannelUrl {
			get;
			set;
		}
		/// <summary>
		/// 是否显示在前台页面上
		/// </summary>
		/// <value><c>true</c> if whether display; otherwise, <c>false</c>.</value>
		public bool WhetherDisplay {
			get;
			set;
		}
		/// <summary>
		/// 频道描述
		/// </summary>
		/// <value>The description.</value>
		public string Description {
			get;
			set;
		}

	}
}

