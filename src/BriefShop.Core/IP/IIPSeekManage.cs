using BriefShop.Core;

namespace BriefShop.IP
{
	/// <summary>
	/// IP查找接口
	/// </summary>
	public interface IIPSeekManage
	{
		/// <summary>
		/// 根据ip地址确定所在区域
		/// </summary>
		/// <param name="ip">ip地址</param>
		/// <returns></returns>
		Region Seek(string ip);
	}
}
