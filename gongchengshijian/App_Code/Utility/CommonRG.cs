using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Utility
{
	/// <summary>
	/// Common ��ժҪ˵����
	/// </summary>
	public class CommonRG
	{
		//private const string REG_DATE   = @"^(\d{2}|\d{4})[\-\/]((0?[1-9])|(1[0-2]))[\-\/]((0?[1-9])|((1|2)[0-9])|30|31)$"; 
		private const string REG_DATE   = @"^(\d{2}|\d{4})((0[1-9])|(1[0-2]))((0[1-9])|((1|2)[0-9])|30|31)$";
		private const string REG_PHONE  = @"^((0[0-9]{2,3}){0,1}([0-9]{7,8}))$";
		private const string REG_EMAIL  = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
		private const string REG_MOBILE = @"(^0{0,1}(13|15)[0-9]{9}$)";
		private const string REG_IDCARD = @"^([0-9]{14}|[0-9]{17})(x|[0-9]){1}$";
		private const string REG_TIME   = @"^((([0-1]?[0-9])|(2[0-3]))([\:])([0-5][0-9]))$";
        private const string REG_READERNAME = @"^([0-9]{1-10})&";

        #region �����û���
        /// <summary>
        /// �����û���
        /// </summary>
        /// <param name="str">��֤���ַ���</param>
        /// <returns></returns>
        public static bool IsReaderName(string str)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            int byteCount = encoding.GetByteCount(str);
            int strLen = str.Length;

            if (strLen == byteCount)
            {
                return true;
            }

            return false;
        }
        #endregion

		#region �����֤
		/// <summary>
		/// �����֤
		/// </summary>
		/// <param name="str">��֤���ַ���</param>
		/// <returns></returns>
		public static bool IsDBC(string str)
		{
		    return Regex.IsMatch(str, CommonRG.REG_READERNAME);
		}
		#endregion

		#region ȫ����֤
		/// <summary>
		/// ȫ����֤
		/// </summary>
		/// <param name="str">��֤���ַ���</param>
		/// <returns></returns>
		public static bool IsSBC(string str)
		{
			UTF8Encoding encoding = new UTF8Encoding();
			int byteCount = encoding.GetByteCount(str);
			int strLen = str.Length;

			if(byteCount == strLen * 3 )
			{
				return true;
			}

			return false;
		}
		#endregion

		#region �����ַ�����Ч����֤
		/// <summary>
		/// �����ַ�����Ч����֤
		/// </summary>
		/// <param name="date">�����ַ���</param>
		/// <returns>��Ч:true,����:false</returns>
		public static bool IsValidDate(string date)
		{
			return Regex.IsMatch(date,CommonRG.REG_DATE);
		}
		#endregion

		#region Email��Ч����֤
		/// <summary>
		/// Email��Ч����֤
		/// </summary>
		/// <param name="email">Email�ַ���</param>
		/// <returns>��Ч:true,����:false</returns>
		public static bool IsValidEmail(string email)
		{
            return Regex.IsMatch(email, CommonRG.REG_EMAIL);
		}
		#endregion

     

		#region �绰������Ч����֤
		/// <summary>
		/// �绰������Ч����֤
		/// </summary>
		/// <param name="phone">�绰�����ַ���</param>
		/// <returns>��Ч:true,����:false</returns>
		public static bool IsVaildPhone(string phone)
		{
            return Regex.IsMatch(phone, CommonRG.REG_PHONE);
		}
		#endregion

		#region �ֻ�������Ч����֤
		/// <summary>
		/// �ֻ�������Ч����֤
		/// </summary>
		/// <param name="mobile">�ֻ������ַ���</param>
		/// <returns>��Ч:true,����:false</returns>
		public static bool IsValidMobile(string mobile)
		{
            return Regex.IsMatch(mobile, CommonRG.REG_MOBILE);
		}
		#endregion

		#region ���֤����Ч����֤
		/// <summary>
		/// ���֤����Ч����֤
		/// </summary>
		/// <param name="idCard">���֤���ַ���</param>
		/// <returns>��Ч:true,����:false</returns>
		public static bool IsValidIdCard(string idCard)
		{
            return Regex.IsMatch(idCard, CommonRG.REG_IDCARD);
		}
		#endregion

		#region �����ַ���ת�������ڶ���
		/// <summary>
		/// �����ַ���ת�������ڶ���
		/// </summary>
		/// <param name="date">�����ַ���</param>
		/// <returns>���ڶ���</returns>
		public static DateTime CastDateTime(string date)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append(date.Substring(0,4));
			builder.Append("-");
			builder.Append(date.Substring(4,2));
			builder.Append("-");
			builder.Append(date.Substring(6,2));
			
			return Convert.ToDateTime(builder.ToString());
		}
		#endregion

		#region ���ڶ���ת���������ַ���
		/// <summary>
		/// ���ڶ���ת���������ַ���
		/// </summary>
		/// <param name="date">���ڶ���</param>
		/// <returns>�����ַ���</returns>
		public static string CastDateTime(DateTime date)
		{
			string strDate = date.ToString("yyyy-MM-dd");
			strDate = strDate.Replace("-","");
			return strDate;
		}
		#endregion

		#region ʱ���ʽ��֤
		/// <summary>
		/// ʱ���ʽ��֤
		/// </summary>
		/// <param name="time">ʱ���ַ���</param>
		/// <returns>��ȷ:true,����:false</returns>
		public static bool IsValidTime(string time)
		{
			return Regex.IsMatch(time,REG_TIME);
		}
		#endregion
	}
}