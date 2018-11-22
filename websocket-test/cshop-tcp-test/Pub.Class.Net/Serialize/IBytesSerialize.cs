using System;

#if NETCLIENT
namespace Pub.Class.NetClient {
#else 
namespace Pub.Class.Net {
#endif
    /// <summary>
    /// ���л��ͷ����л��ӿ�
    /// 
    /// �޸ļ�¼
    ///     2011.07.11 �汾��1.0 livexy ��������
    /// 
    /// </summary>
    public interface IBytesSerialize {
        void RegisterTypes(params Type[] types);
        /// <summary>
        /// ���л�
        /// </summary>
        /// <param name="o">����</param>
        /// <returns>�ַ���</returns>
        byte[] Serialize<T>(T o);
        /// <summary>
        /// data�����л��ɶ���
        /// </summary>
        /// <typeparam name="T">��������</typeparam>
        /// <param name="data">����</param>
        /// <returns>����</returns>
        T Deserialize<T>(byte[] data);
    }
}
